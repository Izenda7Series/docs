******************
Prerequisites
******************

Goal
=====
In this guide, we will be embedding Izenda into an HTML application. Authentication will be handled through a simple in-memory user store that, upon logging in, a user will be given their employee ID and will be redirected to a page with Izenda embedded. 
An Authorization application will be created in Python’s Bottle micro-framework to model the routes and resources you will need to implement in your application. Using an application-specific value, Employee ID, the application will generate an authorization token that can be used to access the Izenda platform. If a user attempts to access Izenda components without a valid employee ID, they will be redirected to the login page. 

.. note::
 This guide is intended to demonstrate the key concepts of embedding Izenda and constructing the key routes within your application to authorize the use of Izenda. Please adhere to your company’s security standards regarding authentication and encryption of data.

Requirements
============
* Izenda API resources and Embedded UI Resources
* IIS
* SSMS
* Python 
  * Pip : Pip is a package manager for Python. It will be useful when installing our Python packages below.
    * https://github.com/BurntSushi/nfldb/wiki/Python-&-pip-Windows-installation 
  * Bottle : For this demonstration, our Authorization application will be written in Bottle, a Python micro framework for rapidly developing simple APIs https://bottlepy.org/docs/dev/tutorial.html#installation
  * Cherrypy: Is a multi-threaded minimalist Python Web Framework. We will be using cherrypy’s server rather than Bottle’s default server because of its multi-threaded capabilities. 
    * To install the version used in this tutorial, run the following in your windows terminal: pip install "cherrypy>=3.0.8,<9.0.0"
    * http://cherrypy.org/
  * pyca/cryptography : We will use this encryption library to encrypt our tokens and validate exports (RSA)
    * http://docs.python-guide.org/en/latest/scenarios/crypto/
    * https://cryptography.io/en/latest/
* Postman: debug and test our Authorization App endpoints
    * https://www.getpostman.com/

Initial Set Up
===============
#. On your Server, create a directory named “IzendaSimpleAuthorization.” Here, create three directories: IzendaAPI, Server, and Client.

***************************
Creating an Izenda API
***************************
**GOAL:  Create a standalone API on IIS to interact with in deployment mode 1.**

[Image 1]

1.	Copy the Izenda API into the IzendaSimpleAuthorization /IzendaAPI directory.
2.	For this tutorial, we will be deploying the Izenda API to IIS using port 8085 (http://localhost:8085)
3.	Deploy the Izenda API to IIS. Review the steps found at https://www.izenda.com/docs/install/doc_installation_guide.html  . Since we will be creating an integrated front end application, you will not need to follow the steps for setting up the standalone Front End.

******************************************************
Connecting the Izenda API to the Izenda Database
******************************************************
**GOAL: Connect the Izenda back end to the Izenda database using an izendadb.config file. Remember, database contains all reports, dashboards, Izenda users, tenants, and roles.**

[Image 2]

Connecting with an Encrypted Connection String
===============================================

#.	Create a new database in SSMS named “IzendaConfigurationDB” 
#.	In Postman, create a POST request for the endpoint /api/databaseSetup/DatabaseInfo  e.g. http://localhost:8085/api/databaseSetup/DatabaseInfo  . For more information see https://www.izenda.com/docs/ref/api_systemdb_and_license.html?highlight=databasesetup%20databaseinfo#post-databasesetup-databaseinfo .
#.	If the API is successful, you will receive {"success":true,"messages":null,"data":null}
  *	If the Izenda tables do not exist within the specified database, they will be created.
  *	A file named izendadb.config will be created in the root directory of your API. To confirm that the connection string is encrypted, open the izendadb.config in your preferred text editor.
#.	If desired, you can replace the encrypted connection string with a plain text connection string for debugging.

Connecting With a Plain Text Connection String
===============================================
.. note::

   This option is best for development and testing. Once your environment is production-ready, we recommend converting to an encrypted connection string. This can be accomplished by following the steps below or by entering your connection string on the System DB & License page within the platform.

If you have an *empty* configuration database, you can follow the steps for “Connecting with an encrypted Connection String” to populate Izenda’s default tables and values.
#.	Download a copy of sample izendadb.config file. This can be found within our MVC5 Sample Kit but can be used for any Izenda API (see https://github.com/Izenda7Series/Mvc5StarterKit/blob/master/Mvc5StarterKit/izendadb.config)
#.	Modify the izendadb.config file with a valid connection string to this new database.
  *	SQLEXPRESS;database=IzendaConfigurationDB;User Id=Demo2;Password=demo123;
  *	If your connection string contains a backslash, you will need to escape it e.g. server=MY-PC\SQLEXPRESS;database=IzendaConfigurationDB;User Id=Demo2;Password=demo123;  server=MY-PC\\SQLEXPRESS;database=IzendaConfigurationDB;User Id=Demo2;Password=demo123;

Verifying the Connection
============================

#.	To verify that your connection string is properly set up, create a GET request for the following endpoint: systemSetting/systemMode e.g. http://localhost:8085/api/systemSetting/systemMode . This will also confirm the current deployment mode of your Izenda instance.

Modifying the Deployment Mode
===============================

The API Deployment Mode can be set in the Izenda System Setting table of your configuration database. For more information on deployment modes, please refer to https://www.izenda.com/docs/intro/understanding_the_three-tiered_architecture.html 

#.	In SSMS, run the following query:  UPDATE IzendaSystemSetting SET Value = 1 WHERE Name = 'DeploymentMode';
#.	After setting the deployment mode in the database, you will need to refresh your Izenda API App Pool for the change to take effect.

************************************
Authentication and Authorization
************************************

Overview
==========
Authentication
----------------

Authentication will occur in the host application. Once the user is authenticated within your system, you can design the mechanisms to authorize the user to interact with Izenda.

Authorization
---------------

* Generating the token: Generating the token will be necessary from the front end to allow a user to access Izenda. 
  * In its unencrypted form, the token should contain the Izenda User name and unique Izenda tenant name or a value that your Validation route can interpret to obtain this data.
  * There isn’t a set formula to generate the token— if desired, your Izenda User Info can be wrapped within your own application’s token, stored within a cookie, or even uniquely generated every time a new Izenda page loads. 
  * Once a token is retrieved, the Izenda User Context will be set in the front end using the token. When the front end attempts to render a page, the Izenda API will be notified to validate the token.
* Validating the token: Within the IzendaSystemSetting table of your configuration database, there is an entry for AuthValidateAccessTokenUrl. The AuthValidateAccessTokenUrl defines a route within your host application for the API to verify the token is, in fact, valid.
  * Your token validation function for your application will be an inverse of your token generation function. The goal is to decrypt the token, interpret the data, and return a valid User Info Object to Izenda.
  
*********************************************
Creating a simple Authorization Application
*********************************************

**GOAL: Create an authorization application that uses an impersonated security model. In an impersonated security model, authentication is ignored to demonstrate the authorization process.**

[Image 3]

Python Code: Initial Setup
============================

#.	In your IzendaSimpleAuthorization/Server directory, create a new file named app.py .

The following code will be used to set up our bottle application to easily define response header options (GET, POST, OPTION). Please note, the Access-Control-Allow-Origin setting ‘*’ should not be used in production. Additionally, when the code runs, it will run on port 8080 in development mode. Code written in subsequent steps will be written in place of the comment "Our Development In Future Steps Will Be Here"


.. code-block:: python
  from bottle import Bottle, request, response, run, HTTPResponse 
  app = Bottle()
  @app.hook('after_request')
  def enable_cors():
      """
      You need to add some headers to each request.
      Don't use the wildcard '*' for Access-Control-Allow-Origin in production.
      """
      response.headers['Access-Control-Allow-Origin'] = '*'
      response.headers['Access-Control-Allow-Methods'] = 'PUT, GET, POST, DELETE, OPTIONS'
      response.headers['Access-Control-Allow-Headers'] = 'Origin, Accept, Content-Type, X-Requested-With, X-CSRF-Token'

      """
      Our Development In Future Steps Will Be Here
      """

  if __name__ == '__main__':
      from optparse import OptionParser
      parser = OptionParser()
      parser.add_option("--host", dest="host", default="localhost",
                        help="hostname or ip address", metavar="host")
      parser.add_option("--port", dest="port", default=8080,
                        help="port number", metavar="port")
      (options, args) = parser.parse_args()
  run(app, host=options.host, port=int(options.port), server='cherrypy', reloader=True)

Python Code: Creating Generate Token Route
-------------------------------------------
This route will generate a token when requested. The end goal for this application will be to accept an Employee ID and return an encrypted token to our front end application. At this phase, however it will simply return the value of a variable named EmployeeID (22). 
**NOTE: At this phase, our goal is to demonstrate simple authorization. Please adhere to your own company standards regarding token encryption and authentication.**

.. code-block:: python

  EmployeeID = ‘22’
  @app.route('/generatetoken', method=['GET', 'OPTIONS'])
  def generatetoken():
      return {"token" : EmployeeID}

Python Code: Creating a ValidateToken Route
==============================================
This route will retrieve the access_token from a query string sent in a GET request. Next, it will interpret the access token and return a valid User Info object back to the request source (the Izenda API). This allows for a secure interaction with the Izenda API.

.. code-block:: python

  @app.route('/validatetoken',  method=['GET', 'OPTIONS'])
  def validatetoken():
    myToken = request.query.access_token
    if myToken == '22':
      return{"UserName" : "IzendaAdmin", "TenantUniqueName": "" }
    else:		
      return{"No Permission From Host Application"}

Testing Our Code
----------------
#. Open Windows PowerShell into the IzendaSimpleAuthorization/Server directory.
#. Run the following command python app.py
#. In Postman, create a GET request for our “generate token” route e.g. localhost:8080/generatetoken
  *	Expected Response: 22
#. In Postman, create a GET request for our “validate token” route e.g. localhost:8080/validatetoken?access_token=22
  * Expected Response: "UserName" : "IzendaAdmin", "TenantUniqueName": ""

Linking the Izenda API to Our Application
===========================================

** GOAL: Provide a logical link from the Izenda API to our Application **

[Image 4]

Now that we have a route to generate tokens for the front end and a route to validate tokens for the Izenda API, we need to provide a logic link to our Application. Since the Izenda API will always have access to the Izenda Configuration database, we will store a URL to our authentication route in the AuthValidateAccessTokenUrl entry in the IzendaSystemSetting table.
#. Recall, our authorization application is running at localhost:8080
#. In SSMS, run the following query:  UPDATE IzendaSystemSetting SET Value = ‘http://localhost:8080/validatetoken’ WHERE Name = ‘AuthValidateAccessTokenUrl’;
#. After setting the AuthValidateAccessTokenUrl in the database, you will need to refresh your Izenda API App Pool for the change to take effect.

Creating a simple front-end
=============================

** GOAL: Create a simple front end application (HTML and JavaScript) that will render Izenda as a single page application. **

[Image 5]

1.	In your file browser, navigate to your ** IzendaSimpleAuthorization/Client ** directory and create a folder named “scripts.” This will contain all of our JavaScript for our front end application.
2.	Within the ** IzendaSimpleAuthorization/Client/scripts ** directory, create a folder named “izenda.” This will hold our front end resources.


Adding the Izenda Resources
----------------------------

1.	Download the Embedded UI resources from our Downloads page. Ensure that the version matches the version of your Izenda API.
2.	Copy the contents of Izenda Embedded UI into the IzendaSimpleAuthorization \Client\scripts\izenda directory.

Creating izenda_integrate.js
-----------------------------
Many of our sample kits contain a file named “izenda integrate” that contains working examples of the numerous rendering options available to render Izenda within your application. For this tutorial, we will be using a preexisting izenda_integrate.js file. Additional render function documentation can be found at https://www.izenda.com/docs/dev/api_frontend_integration.html.

Downloading Izenda Integrate
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
1.	Download a copy of izendaintegrate.js from https://github.com/Izenda7Series/Mvc5StarterKit_BE_Standalone/blob/master/Mvc5StarterKit/Scripts/izenda.integrate.js . Save this file as “izenda_integrate.js” into your “scripts” directory. 
2.	Open file in your preferred text editor.
3.	For this tutorial, we will be using the functions DoIzendaConfig, DoRender, and izendaInit

Understanding Izenda Integrate
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

The following are descriptions for the functions we will use for this tutorial.

* **DoIzendaConfig:** A function that will run to set up the defaults for Izenda’s front end components. This includes establishing Izenda route names, the location of your Izenda API, and the location of Izenda’s resources.

* **DoRender:** A function that will interact with your authentication application. This will request a token to be generated. If the request is successful, the success function passed in to the function will run. If the request is unsuccessful, the generic error function written in the script will run.

* **izendaInit:** A function that will render all of Izenda as a single page application. This function stages a “success” function for DoRender. 
  
  * Within the success function, a token is set (retrieved from the authorization application) and the Izenda user context is set according to this value. NOTE: This is the token value used in the validation process.


JavaScript Code: Connecting Our Front End to the Izenda API
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

#.	Locate the “WebApiUrl” in DoIzendaConfig. This will contain a URL to our Izenda API. Recall, our Izenda API is located on port 8085 (http://localhost:8085).
#.	Modify entry:   *"WebApiUrl": “http://localhost:8085/api/”*

JS Code: Connecting Our Front End to Our Application
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

#.	Locate the “url” in DoRender. This will contain a URL to our Authorization Application. Recall, our Authorization Application is located on port 8080 (http://localhost:8080).
#.	Modify entry:   *url : “http://localhost:8080/generatetoken”*
#.	Save result.

Creating index.html
--------------------
In this Izenda deployment, index.html will contain the necessary format and logic to render Izenda as a single page application. Here, be mindful of the Izenda resources and ensure that they are loaded in the correct order. In your own implementation, you may opt to bundle these resources with your own application’s resources.
* Resource Order
    * izenda/izenda-ui.css
    * izenda/izenda_common.js
    * izenda/izenda_locales.js
    *	izenda/izenda_vendors.js
    *	izenda/izenda_ui.js 
    *	izenda_integrate.js (remember, this is the JavaScript code you will write and maintain for your development)

#.	In your Windows Explorer, navigate to IzendaSimpleAuthorization/Client/ and create a new file named index.html .
#.	Open index.html in a text editor and add the following:

  .. code-block:: html
  
    <!DOCTYPE html>
    <html>
    <!--Resources required within the head of any page rendering an Izenda container-->
    <head>
        <title>HTML Embedded Izenda Example</title>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
        <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0' name='viewport' />
        <link href="/scripts/izenda/izenda-ui.css?db1ebd9b10aa86f1fd76" rel="stylesheet">
        <script src="https://code.jquery.com/jquery-1.12.4.min.js"
                integrity="sha256-ZosEbRLbNQzLpnKIkEdrPv7lOy9C27hHQ+Xp8a4MxAQ="
                crossorigin="anonymous"></script>
        <style>
            .container {
                width: 100%;
                height: 100vh;
                min-height: 100vh;
            }
        </style>
    </head>
    <!--Resources required within the body of any page rendering an Izenda container-->
    <body>
        <!--Izenda container <div> tag-->
        <div class="container" id="izenda-root"></div>
        <!--On page scripts-->
        <script type="text/javascript" src="/scripts/izenda/izenda_common.js?db1ebd9b10aa86f1fd76"></script>
        <script type="text/javascript" src="/scripts/izenda/izenda_locales.js?db1ebd9b10aa86f1fd76"></script>
        <script type="text/javascript" src="/scripts/izenda/izenda_vendors.js?db1ebd9b10aa86f1fd76"></script>
        <script type="text/javascript" src="/scripts/izenda/izenda_ui.js?db1ebd9b10aa86f1fd76"></script>
        <script src="/scripts/izenda_integrate.js" type="text/javascript"></script>
        <!--Izenda Configraution function and render function-->
        <script type="text/javascript">
           $(window).load(function () {
                DoIzendaConfig();
                izendaInit();
            });
        </script>
    </body>
    </html>

*********************************************
Extending the Authorization Application
*********************************************


Python Code: Adding a Simple User Store
========================================
**GOAL: Remove hard-coded values in our token generation and validation routes.**

#.	In IzendaSimpleAuthorization/Server/app.py, Create an array named “UserStore” this will contain Dictionaries that will represent users within your application. In a production scenario, we recommend creating a structure for your application’s users and to store this information in a secure location (e.g. a database). The following sample has sample information for a user named “Bob.”

  .. code-block:: python
     
     UserStore = [{"EmployeeID":"22","UName":"Bob","Passw": "test123","IzendaName":"IzendaAdmin","IzendaTenant":""}] #Array of User Objects.

#.	Remove global object “EmployeeID.” In the next step, we will “query” our UserStore to find the appropriate information for a given Employee ID.
#.	Create two helper functions— getUserInfo and findUser. “getUserInfo” will return a UserInfo object (a dictionary) that properly formats the Izenda user name and Izenda tenant name for Izenda. “findUser” will return a UserInfo object for a given employee ID.
  .. code-block:: python
  
     def getUserInfo(izendaUserName, izendaTenant): #Returns a  "User Info" dictionary for Izenda
       return {"UserName" : izendaUserName, "TenantUniqueName": izendaTenant}

     def findUser(employeeID): #generates the user info required to authenticate with Izenda based off of an employee ID
      for user in UserStore:
       if user.get("EmployeeID") == employeeID:
        return  getUserInfo(user.get("IzendaName"), user.get("IzendaTenant"))
      return None	

Python Code: Adding Encryption
=================================

**GOAL: Create a more expressive token (includes user name and tenant name) in order to remove hard-coded values in our token validation route. Apply encryption.**

At this phase, an end user will send an “employee_id” in a query string to our token generation route. Given an employee_id, we will create an encrypted token that contains the Izenda User Name and Izenda Tenant Name (a “User Info” object).
NOTE: At this phase, our goal is to demonstrate authorization with token encryption. Please adhere to your own company standards regarding authentication.

1.	Ensure that pyca/cryptography is installed in your environment (to install, run pip cryptography in a new Powershell window)
2.	At the top of your application include the following:
  .. code-block:: python
     
     from cryptography.fernet import Fernet #Used for Token Encryption

3.	For this demonstration, we will use Fernet encryption. Add a global object into your application
  .. code-block:: python
     
     #Set Up Encryption
     key = Fernet.generate_key()
     encryptor = Fernet(key)
4.	Create two helper functions—encrypt and decrypt. These functions will use the Fernet library’s encryption methods and format the data to work well with generate and validate token routes.
  .. code-block:: python
  
     def encrypt(userInfo): #converts userInfo object to string and encrypts it
      token = encryptor.encrypt(str(userInfo))
      return token

     def decrypt(token): #decrypts tokens and converts result to a dictionary
      userInfo = eval(encryptor.decrypt(str(token)))
      return userInfo

5.	Modify our token generation route to include token encryption. Now that we can encrypt our data, our Access Token will contain the username and tenant name rather than passing in a hard-coded “Employee ID” value. The Employee ID value will, instead, be retrieved from our query string. If a particular Employee ID cannot be found, we will raise an exception and return a 400 status code.
  .. code-block:: python
     #Route to Generate Encrypted Token based off of an employeeID. The employee ID will be provided by the host application
     @app.route('/generatetoken', method=['GET', 'OPTIONS'])
     def generatetoken():
      employeeID = request.query.employee_id #Get Employee ID from Query String
      myUserInfo = findUser(employeeID) 
      if myUserInfo is None: #If the user wasn't found
       raise HTTPResponse(output='Invalid Credentials', status=400)
      else:
       return {"token": encrypt(myUserInfo)}
6.	Modify our token validation route to include token decryption. Now that we can decrypt messages, we no longer need to compare the “Employee ID” value in this method.
  
  .. code-block:: python
  
     @app.route('/validatetoken',  method=['GET', 'OPTIONS'])
     def validatetoken():
      token = request.query.access_token
      return decrypt(token)

JavaScript Code: Updating the Front End Application
======================================================
At this point, we have created a way to encrypt a user info object in our token generation route and a way to decrypt the token in our token validation route. This removed our hard-coded user info object in our validation and our hard-coded employee ID in our token generation route. In step 5 of the previous section, we created a mechanism to retrieve the Employee ID from a query string so we will now need to provide a value in our DoRender function of our Izenda Integrate JS file.

1.	Open izenda_integrate.js and locate the url within DoRender.
2.	Modify entry:   *url : “http://localhost:8080/generatetoken?employee_id=22”*
3.	Save result and restart your application pool on IIS.

*********************************************
Adding Simple Authentication
*********************************************

**GOAL: Provide a method to log in to the host application. This will allow us to remove the hard-coded employee_id in our Izenda Integrate file**

[Image 6]

Python Code: Create A Post Route to Log into Host Application
===============================================================

For this demonstration, when a user logs in to the host application, they will receive their Employee ID to access Izenda. 
Create a helper function to find an employee ID

The following function will be used to find an employee ID given a specified username and password.

  .. code-block:: python
  
     def validateLogin(uName, passw): 
      for user in UserStore:
       if user.get("UName") == uName and user.get("Passw") == passw:
        return  user.get("EmployeeID")
      return None	

