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
#. On your Server, create a directory named **IzendaSimpleAuthorization**. Here, create three directories: *IzendaAPI*, *Server*, and *Client*.

***************************
Creating an Izenda API
***************************
**GOAL:  Create a standalone API on IIS to interact with in deployment mode 1.**


.. figure::  /_static/images/dev/howto_dep1/1.PNG

1.	Copy the Izenda API into the IzendaSimpleAuthorization **/IzendaAPI** directory. The result should have **/IzendaAPI/API/** as a new directory.
2.	For this tutorial, we will be deploying the Izenda API to IIS using port 8085 (http://localhost:8085)
3.	Deploy the Izenda API to IIS. Review the steps found at https://www.izenda.com/docs/install/doc_installation_guide.html  . Since we will be creating an integrated front end application, you will not need to follow the steps for setting up the standalone Front End.

******************************************************
Connecting the Izenda API to the Izenda Database
******************************************************
**GOAL: Connect the Izenda back end to the Izenda database using an izendadb.config file. Remember, database contains all reports, dashboards, Izenda users, tenants, and roles.**

.. figure::  /_static/images/dev/howto_dep1/2.PNG

Connecting with an Encrypted Connection String
===============================================

1.	Create a new database in SSMS named *IzendaConfigurationDB* 
2.	In Postman, create a POST request for the endpoint */api/databaseSetup/DatabaseInfo*  e.g. http://localhost:8085/api/databaseSetup/DatabaseInfo  . For more information see https://www.izenda.com/docs/ref/api_systemdb_and_license.html?highlight=databasesetup%20databaseinfo#post-databasesetup-databaseinfo .
3.	If the API is successful, you will receive *{"success":true,"messages":null,"data":null}*
  *	If the Izenda tables do not exist within the specified database, they will be created.
  *	A file named *izendadb.config* will be created in the root directory of your API (**IzendaSimpleAuthorization/IzendaAPI/API/**). To confirm that the connection string is encrypted, open the *izendadb.config* in your preferred text editor.
4.	If desired, you can replace the encrypted connection string with a plain text connection string for debugging.

Connecting With a Plain Text Connection String
===============================================
.. note::

   This option is best for development and testing. Once your environment is production-ready, we recommend converting to an encrypted connection string. This can be accomplished by following the steps below or by entering your connection string on the System DB & License page within the platform.

If you have an *empty* configuration database, you can follow the steps for “Connecting with an encrypted Connection String” to populate Izenda’s default tables and values.
1.	Download a copy of sample *izendadb.config* file. This can be found within our MVC5 Sample Kit but can be used for any Izenda API (see https://github.com/Izenda7Series/Mvc5StarterKit/blob/master/Mvc5StarterKit/izendadb.config). Place the izendadb.config into  in the root directory of your API (**IzendaSimpleAuthorization/IzendaAPI/API/**).

2.	Modify the *izendadb.config* file with a valid connection string to this new database.
  *	SQLEXPRESS;database=IzendaConfigurationDB;User Id=Demo2;Password=demo123;
  *	If your connection string contains a backslash, you will need to escape it .e.g. server=MY-PC\SQLEXPRESS;database=IzendaConfigurationDB;User Id=Demo2;Password=demo123; ==> server=MY-PC\\SQLEXPRESS;database=IzendaConfigurationDB;User Id=Demo2;Password=demo123;

Verifying the Connection
============================

#.	To verify that your connection string is properly set up, create a GET request for the following endpoint: systemSetting/systemMode e.g. *http://localhost:8085/api/systemSetting/systemMode* . This will also confirm the current deployment mode of your Izenda instance.

Modifying the Deployment Mode
===============================

The API Deployment Mode can be set in the Izenda System Setting table of your configuration database. For more information on deployment modes, please refer to https://www.izenda.com/docs/intro/understanding_the_three-tiered_architecture.html 

#.	In SSMS, run the following query:  *UPDATE IzendaSystemSetting SET Value = 1 WHERE Name = 'DeploymentMode';*
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

* **Generating the token:** Generating the token will be necessary from the front end to allow a user to access Izenda. 
  * In its unencrypted form, the token should contain the Izenda User name and unique Izenda tenant name or a value that your Validation route can interpret to obtain this data.
  * There isn’t a set formula to generate the token— if desired, your Izenda User Info can be wrapped within your own application’s token, stored within a cookie, or even uniquely generated every time a new Izenda page loads. 
  * Once a token is retrieved, the Izenda User Context will be set in the front end using the token. When the front end attempts to render a page, the Izenda API will be notified to validate the token.
* **Validating the token:** Within the IzendaSystemSetting table of your configuration database, there is an entry for AuthValidateAccessTokenUrl. The AuthValidateAccessTokenUrl defines a route within your host application for the API to verify the token is, in fact, valid.
  * Your token validation function for your application will be an inverse of your token generation function. The goal is to decrypt the token, interpret the data, and return a valid User Info Object to Izenda.
  
*********************************************
Creating a Simple Authorization Application
*********************************************

**GOAL: Create an authorization application that uses an impersonated security model. In an impersonated security model, authentication is ignored to demonstrate the authorization process.**

.. figure::  /_static/images/dev/howto_dep1/3.PNG

Python Code: Initial Setup
============================

#.	In your **IzendaSimpleAuthorization/Server** directory, create a new file named *app.py* .

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

.. note::
 At this phase, our goal is to demonstrate simple authorization. Please adhere to your own company standards regarding token encryption and authentication.

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
#. Open Windows PowerShell into the **IzendaSimpleAuthorization/Server** directory.
#. Run the following command: *python app.py*
#. In Postman, create a GET request for our “generate token” route e.g. localhost:8080/generatetoken
  *	Expected Response: 22
#. In Postman, create a GET request for our “validate token” route e.g. localhost:8080/validatetoken?access_token=22
  * Expected Response: "UserName" : "IzendaAdmin", "TenantUniqueName": ""

Linking the Izenda API to Our Application
===========================================

**GOAL: Provide a logical link from the Izenda API to our Application**

.. figure::  /_static/images/dev/howto_dep1/4.PNG

Now that we have a route to generate tokens for the front end and a route to validate tokens for the Izenda API, we need to provide a logic link to our Application. Since the Izenda API will always have access to the Izenda Configuration database, we will store a URL to our authentication route in the AuthValidateAccessTokenUrl entry in the IzendaSystemSetting table.

#. Recall, our authorization application is running at localhost:8080

#. In SSMS, run the following query:  *UPDATE IzendaSystemSetting SET Value = ‘http://localhost:8080/validatetoken’ WHERE Name = ‘AuthValidateAccessTokenUrl’;*

#. After setting the AuthValidateAccessTokenUrl in the database, you will need to refresh your Izenda API App Pool for the change to take effect.

Creating a Simple Front-End
=============================

**GOAL: Create a simple front end application (HTML and JavaScript) that will render Izenda as a single page application.**

.. figure::  /_static/images/dev/howto_dep1/5.PNG

1.	In your file browser, navigate to your **IzendaSimpleAuthorization/Client** directory and create a folder named *scripts*. This will contain all of our JavaScript for our front end application.
2.	Within the **IzendaSimpleAuthorization/Client/scripts** directory, create a folder named *izenda.* This will hold our front end resources.


Adding the Izenda Resources
----------------------------

1.	Download the *Embedded UI* resources from our Downloads page. Ensure that the version matches the version of your Izenda API.
2.	Copy the contents of Izenda *Embedded UI* into the **IzendaSimpleAuthorization/Client/scripts/izenda** directory.

Creating izendaintegrate.js
-----------------------------
Many of our sample kits contain a file named “izenda integrate” that contains working examples of the numerous rendering options available to render Izenda within your application. For this tutorial, we will be using a preexisting izendaintegrate.js file. Additional render function documentation can be found at https://www.izenda.com/docs/dev/api_frontend_integration.html.

Downloading Izenda Integrate
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
1.	Download a copy of izendaintegrate.js from https://github.com/Izenda7Series/Mvc5StarterKit_BE_Standalone/blob/master/Mvc5StarterKit/Scripts/izenda.integrate.js . Save this file as *izendaintegrate.js* into your **scripts** directory. 
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

JavaScript Code: Referencing Our Front End Resources for Izenda Forms
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

The Izenda Forms editor uses a virtual DOM to allow users to build HTML-centric report parts. In order to utilize the "Visual" tab of Forms, you will need to ensure that your config references the Izenda UI resource location correctly.

#.	Locate the “RootPath” in DoIzendaConfig. This will contain the relative path to our Izenda Front End resources. Recall, our Izenda Front End resources are located within */scripts/izenda* .
#.	Modify entry:   *"WebApiUrl": “/scripts/izenda”*

JavaScript Code: Connecting Our Front End to Our Application
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

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
    *	izendaintegrate.js (remember, this is the JavaScript code you will write and maintain for your development)

#.	In your Windows Explorer, navigate to **IzendaSimpleAuthorization/Client/** and create a new file named *index.html*.
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
        <script src="/scripts/izendaintegrate.js" type="text/javascript"></script>
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

1.	In *IzendaSimpleAuthorization/Server/app.py*, Create an array named “UserStore” this will contain Dictionaries that will represent users within your application. In a production scenario, we recommend creating a structure for your application’s users and to store this information in a secure location (e.g. a database). The following sample has sample information for a user named “Bob.”

.. code-block:: python
     
     UserStore = [{"EmployeeID":"22","UName":"Bob","Passw": "test123","IzendaName":"IzendaAdmin","IzendaTenant":""}] #Array of User Objects.

2.	Remove global object “EmployeeID.” In the next step, we will “query” our UserStore to find the appropriate information for a given Employee ID.

3.	Create two helper functions— getUserInfo and findUser. “getUserInfo” will return a UserInfo object (a dictionary) that properly formats the Izenda user name and Izenda tenant name for Izenda. “findUser” will return a UserInfo object for a given employee ID.

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
2.	At the top of *app.py*, include the following:

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

1.	Open izendaintegrate.js and locate the url within DoRender.
2.	Modify entry:   *url : “http://localhost:8080/generatetoken?employee_id=22”*
3.	Save result and restart your application pool on IIS.

*********************************************
Adding Simple Authentication
*********************************************

**GOAL: Provide a method to log in to the host application. This will allow us to remove the hard-coded employee_id in our Izenda Integrate file**

.. figure::  /_static/images/dev/howto_dep1/6.PNG

Python Code: Create A Post Route to Log into Host Application
===============================================================

For this demonstration, when a user logs in to the host application, they will receive their Employee ID to access Izenda. The Employee ID will be sent in a cookie to the Front-End application and this cookie will be used to generate the Izenda Access Token.

Prepare Application For Pre-Flight Requests
---------------------------------------------
In the initial setup, we enabled CORS for our Authorization Application Endpoints because our Front-End is hosted separately from our authorization application. This included setting our 'Access-Control-Allow-Origin' header to accept requests from any source ('*'). In order to utilize our employee_id cookie, we will need to limit our application to only accept requests from our Front-End.

1. In *app.py* Locate the *enable_cors()* function.
2. Modify the value for *response.headers['Access-Control-Allow-Origin']* . The result should point to our Front End Application (http://localhost:8086)

.. code-block:: python

	response.headers['Access-Control-Allow-Origin'] = 'http://localhost:8086'

Create a helper function to find an employee ID
-------------------------------------------------
The following function will be used to find an Employee ID given a specified username and password.

.. code-block:: python
  
     def validateLogin(uName, passw): 
      for user in UserStore:
       if user.get("UName") == uName and user.get("Passw") == passw:
        return  user.get("EmployeeID")
      return None	

Create a route for log in
--------------------------
This route requires a username and password specified by the user. If a login is successful, a cookie "employee_id" will be set and the Employee ID and Username will be returned in the response body. The Employee ID in the response body allows for you to extend the authentication logic should a browser not support cookies. The Username is a value you may opt to add to your application.

If a login is unsuccessful, we will raise an exception and return a 400 status code. Expected request body: *{ "uName": "",   "passw": "" }*

.. code-block:: python
  
     #Route to authenticate with the host application. This is not a required standard for Izenda but completes the authentication/authorization workflow	
     @app.route('/login',  method=['POST', 'OPTIONS'])
     def login():

      data = request.json
      if data is not None:
       uName = data.get('uName')
       passw = data.get('passw')

       myEmployeeID = validateLogin(uName, passw)
       if myEmployeeID is None:
        raise HTTPResponse(output='Invalid Credentials', status=422)
       else:
       	response.set_cookie("employee_id", myEmployeeID, domain='localhost', path='/')
	return {"employee_id" : myEmployeeID, "uName": uName} 
      return "Requires uName and passw"	

Testing Our Code
-----------------
1.	Open Windows PowerShell into the IzendaSimpleAuthorization/Server directory.
2.	Run the following command python app.py
3.	In Postman, create a *POST* request for our “login” route e.g. *http://localhost:8080/login* 
   * Request Body: *{ "uName": "Bob",  "passw": "test123"}*
   * Expected Response: *{"employee_id": "22", "uName": "Bob"}*

Extension: Encryption
----------------------

Remember, we are passing the employee ID to the front end to grant access to Izenda. In production scenarios, we recommend encrypting your own authentication token similar to the steps taken when encrypting our Izenda access token. With our current setup, you would need to encrypt the employee ID in our login route and decrypt the employee ID our token generation route.
In addition to encrypting your Employee ID / authentication token, it would be good practice to store encrypted versions of your users’ passwords within your user store.

Modifying our Generate Token Route
-----------------------------------

Since we are storing our Employee ID in a cookie, we no longer need to retrieve it from the front end via a query string because the cookie will be sent with all requests from the browser. We will need to modify our Generate Token route to retrieve this value from the cookie rather than the query string. Since the pre-flight "Options" request is more prevalent, you should gracefully handle the request type. For this demonstration, we will simply return an empty response body.

.. code-block:: python

   @app.route('/generatetoken', method=['GET', 'OPTIONS'])
   def generatetoken():
   	if request.method == 'OPTIONS':  #Gracefully handle 'OPTIONS' Request for preflight requests
		return {}
	employeeID = request.cookies.employee_id #Get Employee ID from Cookkie
	myUserInfo = findUser(employeeID)
	if myUserInfo is None: #If the user wasn't found
		raise HTTPResponse(output='Invalid Credentials', status=422)
	else:
		return {"token": encrypt(myUserInfo)}


JavaScript Code: Create Login Logic
=====================================

1.	In your Windows Explorer, navigate to **IzendaSimpleAuthorization/Client/scripts/** and create a new file named *login.js*. This file will contain the necessary logic to log in to our Python Authentication application.
2.	Open login.js in a text editor and add the following code. This code will provide a function that calls our login route in our authorization application. If the login is successful, we can retrieve the employee ID from the response. Given our authorization logic, if a 400 error is returned, the login was invalid.

.. code-block:: javascript
  
     $(document).ready(function(){
      var authURL = "http://localhost:8080";

      //login to api

      function validateInput(username, password){
       return JSON.stringify({"uName": username, "passw": password});
      }

      function redirectToPlatform(employeeID, location){
       window.location.replace(location);
      }

      function login(authorizationURL, jsonData){
         $.ajax({
        type: 'POST',
        url: authorizationURL + "/login",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: jsonData,
	xhrFields: { withCredentials: true },
	crossDomain : true, 
        success: function(data) {
          if(data.employee_id != null){
           redirectToPlatform(data.employee_id, "/");
          }
        },
        error: function(){
         alert("Invalid Credentials.");
        }
       })
      }

         $("#login").click(function(){
       var jsonData = validateInput($('#username').val(), $('#password').val());
       login(authURL, jsonData);
      });

     });
     
3.	The code above creates a mechanism to log in to our authentication application hosted on port 8080. If a login is successful, a cookie will be added named “employee_id” and the user will be redirected to index.html. Recall, index.html contains our Izenda platform. We will need to modify our Izenda Integrate file to account for the dynamically set Employee ID.

JavaScript Code: Modifying Izenda integrate
============================================

As with our previous set up, the Employee ID will be passed to our token generation route but, instead of hard-coding the value “22” for our user, we will retrieve it from our cookie. Since there is a possibility that a user lands on an Izenda page with an invalid employee ID (e.g. the cookie expires) we will design a mechanism to catch unauthorized requests.

Retrieving employee ID from cookie
-----------------------------------

After logging in to our host application, we stored our Employee ID in a cookie.

      
1. Open *izendaintegrate.js* and locate our *DoRender* function.

2. Since our "employee_id" is stored within the cookie, we no longer need to pass it in the query string. Modify the DoRender function and remove the hard-coded employee ID. In addition, we will need to add a setting for xhrFields and crossDomain to allow the employee_id cookie to be sent with the request.

.. code-block:: javascript

      var DoRender = function (successFunc) {
          $.ajax({
             type: "GET",
             url: "http://localhost:8080/generatetoken", //remove employee_id query string
             contentType: "application/json; charset=utf-8",
	     
             dataType: "json",
             success: successFunc,
             error: errorFunc,
	     xhrFields: { withCredentials: true },
	     crossDomain : true   //allows us to pass the employee_id cookie with request
          });
      };
      
Redirecting to Login
---------------------

In our authorization application, we raised an except if an Employee ID could not be verified and, in turn, a token is not generated. This exception raises a 400 error which will trigger the generic error function used in the DoRender function of Izenda Integrate. 
1.	In Izenda Integrate, create a new function named redirectToLoginPage.

.. code-block:: javascript

     function redirectToLoginPage(){
      window.location.replace("/login.html");
     }
2.	Modify the generic function of the to read as the following. If an invalid token is generated, the user will be redirected to our login page.

.. code-block:: javascript

     function errorFunc() {
         alert('Token was not generated correctly. Please login.');
         redirectToLoginPage();
     }

*****************************************************
Implementing A Route for Schedules and Subscriptions
*****************************************************
**GOAL: Create a way to export reports from Izenda**

For Izenda to properly export, two routes will need to be established in your application to ensure proper exporting functionality.
* **AuthGetAccessTokenURL:** This will be a route in our authentication application (Python) that will generate a valid token given an RSA-Encrypted Message. 
 * This route differs from our Token Generation method as it does not require authentication with the host application.
 * The message itself will be encrypted by the Izenda API using the RSAPublicKey found in the Izenda Configuration Database. 
 * Our authentication application will have a corresponding RSA Private Key to decrypt the message and create the Izenda token.
* **Report Rendering Route:** After the Izenda API obtains a valid access token from the AuthGetAccessTokenURL, it will attempt to access this route to render the report on the server. 
 * Since this process occurs on the server, schedules and exports can run successfully without a user being active on the front end.
 * Izenda has a definite structure for this route, WebURL + "/viewer/reportpart/". Depending on your front-end implementation and framework of choice, you could handle this in a view or by using a URL Rewrite Rule.

Establishing Routes (No RSA Security)
======================================
In this phase of the project, we will simply create an Izenda token for the IzendaAdmin account and wrap it in a structure that the Izenda Exporting logic requires.

.. note::

 Using the IzendaAdmin in this manner credentials provides ALL users the visibility of data that the IzendaAdmin user has. This method is dangerous in a production scenario as a user may see data one way in the application and another way in an export. After completing this section, we encourage you to continue with the “Adding RSA Encryption” section.


Establishing a Route to Get an Access Token
--------------------------------------------
In our current application model, this will be handled in Python where our authentication and authorization routes exist. 

.. figure::  /_static/images/dev/howto_dep1/7.PNG


Python Code: Creating A Route to Get an Izenda Token
-----------------------------------------------------
1.	Return to our *app.py* file found in the **IzendaSimpleAuthorization/Server** directory.
2.	Add the following route to our application:

.. code-block:: python

     #Route to validate an encrypted token. This will return a JSON containing an encrypted token.
     @app.route('/gettoken',  method=['GET', 'OPTIONS'])
     def gettoken():	
      myToken = { "Token" : encrypt( getUserInfo("IzendaAdmin", "")) } #Izenda requires that our token is wrapped in a JSON Object. The token will be encrypted in the same manner as our generatetoken route.
      return myToken


SQL Script: Setting AuthGetAccessTokenURL and RSAPublicKey in Database
------------------------------------------------------------------------

.. figure::  /_static/images/dev/howto_dep1/8.PNG

1.	In SSMS, run the following query: *UPDATE IzendaSystemSetting SET Value = ‘http://localhost:8080/gettoken’ WHERE Name = 'AuthGetAccessTokenUrl';*

2.	Even though we are not actively using RSA Encryption, we will need to designate a place holder in our database to ensure that the Izenda API can run successfully. In SSMS, run the following query:  *UPDATE IzendaSystemSetting SET Value = ‘<RSAKeyValue><Modulus>yY776bGTUlm57UG1R04K6IZ7MZJ7dMuOrumWXDAPBhGGDKaN3uO9oEDTWILiGEYOorGt/so1DkKTNHTMQNStiY2UjUeamE/iaHt52Y8+4nbbyiLYjx9rktERLtHWeSahuWSiR9AD+uOz+OwRECuDH+I4t2u5fX/Y3ti/odPvH78=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>’ WHERE Name = 'AuthRSAPublicKey’;* 
     
We will return to this setting later when we’ve implemented RSA Encrypted into our application.


Establishing a Route to Render Our Export
------------------------------------------
Since our Izenda front end is separate from our authentication application, this setup will be handled in IIS where the Front End Resources are located.

.. figure::  /_static/images/dev/howto_dep1/9.PNG

JavaScript Code:
~~~~~~~~~~~~~~~~~

1.	Return to our *izendaintegrate.js* file found in the **IzendaSimpleAuthorization/Client/scripts** directory.
2.	The following function will be used to render an Izenda export. Unlike the render function used in our index.html page, this function does not have a success function because it does not use “DoRender.”

.. code-block:: javascript
  
     var izendaInitReportPartExportViewer = function (reportPartId, token) {
         var currentUserContext = {
             token: token
         };
         IzendaSynergy.setCurrentUserContext(currentUserContext);
         IzendaSynergy.renderReportPart(document.getElementById('izenda-root'), {
             id: reportPartId,
             useQueryParam: true,
             useHash: false
         });
     };

3.	The next step falls into the realm of the “Chicken or The Egg” Principle. We will create a function that will return a dictionary of key/values found in a query string. We will utilize this in our next two sections to retrieve the Access Token and Report ID from our export renderer route to push in to izendaInitReportPartExportViewer defined above. 

.. code-block:: javascript
  
     var getUrlVars = function() {
         var vars = [], hash;
         var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
         for(var i = 0; i < hashes.length; i++)
         {
             hash = hashes[i].split('=');
             vars.push(hash[0]);
             vars[hash[0]] = hash[1];
         }
         return vars;
     };

.. note::

 Depending on your implementation, this logic could be handled by more robust means. For instance, if our report export renderer route were handled by Python Bottle, you could simply retrieve query string values like *token = request.query.token*

HTML Code: Creating a Page to Render our Exports
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
In this Izenda deployment, exportrender.html will contain the necessary format and logic to render our Izenda exports, a process will be handled on the server side. Similar to our index.html development, you will need to be mindful of the Izenda resources and ensure that they are loaded in the correct order. In your own implementation, you may opt to bundle these resources with your own application’s resources.

1.	In your Windows Explorer, navigate to **IzendaSimpleAuthorization/Client/** and create a new file named *exportrender.html*. This file will contain the necessary format and logic to render our export.
2.	Open *exportrender.html* in a text editor and add the following:

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
         <!-- <link href="/scripts/izenda-ui-custom.css" rel="stylesheet" type="text/css" /> -->
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
         <script src="/scripts/izendaintegrate.js" type="text/javascript"></script>
         <!--Izenda Configraution function and render function-->
         <script type="text/javascript">
             $(window).load(function () {
                 DoIzendaConfig();
                var queryStringVars = getUrlVars();	   
          myToken = decodeURIComponent(queryStringVars['token'].toString()); //Izenda encodes tokens by default. To ensure that our token can be decrypted in the back end, we will decode it.
         izendaInitReportPartExportViewer(queryStringVars['id'], myToken);
             });
         </script>
     </body>
     </html>

SQL Script: Configuring the WebURL
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
The Web URL will determine the location of the front end resources of your application. In our setup, this will be located at localhost:8086 .
1.	In SSMS, run the following query:  *UPDATE IzendaSystemSetting SET Value = ‘http://localhost:8086/’ WHERE Name =  ‘WebUrl’;*
 
Configuring A URL Rewrite Rule
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

By design, the Izenda will attempt to render an export using the *URL WebURL  + viewer/reportpart* . The WebURL will be retrieved from the Izenda Configuration Database and the route */viewer/reportpart/* should exist in the application.
The requested route may look similar to the following: *http://localhost:8086/viewer/reportpart/532ad716-ffe8-4acf-95e2-e981aa50cf4d?hideTitle=true&print=true&width=1080&height=360&masterReportId=171438a9-f6b3-440a-9532-24b6a774c1e9&inheritFilter=false&masterReportPartId=00000000-0000-0000-0000-000000000000&containerName=*

For this implementation, we will create a URL Rewrite Rule that will interpret the URL provided by the Izenda API and replace it with a format that our front end application can handle (i.e. redirecting to exportrender.html created above). If your front end is encapsulated within a robust framework such as .NET, you would be able to handle this logic in your Route.Config file.

1.	URLRewrite is a prerequisite for installing Izenda. To complete the following section, ensure that URLRewrite is installed on IIS.
2.	In your Windows Explorer, navigate to **IzendaSimpleAuthorization/Client/** and find the file named web.config. Open the *web.config* in a text editor. If this file does not exist, create it.
3.	In the “rules” section of the “rewrite” XML object, add the following rule:
.. code-block:: text

     <rule name="IzendaExport" stopProcessing="true">
      <match url="viewer/reportpart/(.*)" />
      <action type="Redirect" url="http://localhost:8086/exportrender.html?id={R:1}" logRewrittenUrl="true" />
     </rule>


Testing Exports
~~~~~~~~~~~~~~~~

1.	Ensure that you have reset IIS, cleared your browser cache, and restarted our Authentication Application.
2.	Log in to the application and create a report containing a Chart.
3.	Save the Report and navigate to the Report Viewer. 
4.	In the report viewer, select Export > PDF.



Adding RSA Encryption
======================

To ensure that only secure requests can be sent/interpreted by our exporting endpoint, Izenda sends an RSA encrypted message to our Get Token route. Our application will need to decode this message, decrypt it, and interpret the contents of the result. This result will contain an object similar to our User Info object. We’ll use the data within it to create a valid encrypted token. If your host application requires additional values, you may need to add them here as well.

Python Code: Creating an RSA Encryption Class
----------------------------------------------

The following RSA implementation uses the RSA module of the pyca/cryptography library. Recall, we used a module in this library earlier to encrypt our Izenda tokens.

1.	In your Windows Explorer, navigate to **IzendaSimpleAuthorization/Server/** and create a new file named *rsa_encryption.py*. This file will contain the logic to load a private key from a file and decrypt messages sent from the Izenda API.
2.	Open *rsa_encryption.py* in a text editor and add the following:

.. code-block:: python
   
      from cryptography.hazmat.backends import default_backend #private key creation
      from cryptography.hazmat.primitives.asymmetric import rsa #private key creation
      from cryptography.hazmat.primitives import hashes
      from cryptography.hazmat.primitives.asymmetric import padding
      from cryptography.hazmat.primitives import serialization 
      import base64

      class RSAEncryption:
       #loads a private key in pem format from a file
       def loadPrivateKey(self, my_key_file, my_password):
        key_file = open(my_key_file, "rb")
        private_key = serialization.load_pem_private_key(
        key_file.read(),
        password=my_password,
        backend=default_backend()
        )
        return private_key

       #decodes cipher text to base 64 format.  The PKCS1v15 padding is the RSA padding of choice by Izenda
       def decrypt(self, private_key, ciphertext):	
        plaintext = private_key.decrypt(
         base64.b64decode(ciphertext),
         padding.PKCS1v15()
        )
        return plaintext	

      if __name__ == '__main__':
        '''The following should result in {UserName: "IzendaAdmin", TenantUniqueName: ""}
        '''
        encryptor = RSAEncryption()
        private = encryptor.loadPrivateKey("C:/ IzendaSimpleAuthorization/Server/ rsa_private.pem", None)  #Ensure that this points to the location of your rsa_private.pem file
        ciphertext = 'weysQayCQSHUZyasEiYcD6YsLUbdp3nnVpP5onxGeGZQrUHTVZNE/U/ek/e9lgafGlHKD7zQdLJekZXUpoBYT2r48cirM0WCH2xHgK7O8oVZ6/1Q87o5P0GGjpWWDCHWudxAXizk2OI5tBdD1QQDWnJzF0wCUhcMU23sQDmDxDc='
        plaintext = encryptor.decrypt(private, ciphertext)
        print "plaintext : " + plaintext

Creating A file to store a Private Key
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
1.	In your Windows Explorer, navigate to **IzendaSimpleAuthorization/Server/** and create a new file named *rsa_private.pem* . This file will contain the private key that can be used to decrypt the message in our sample in the main method of *rsa_encryption.py*
2.	Open rsa_private.pem in a text editor and add the following:

.. code-block:: text

      -----BEGIN RSA PRIVATE KEY-----
      MIICXAIBAAKBgQDJjvvpsZNSWbntQbVHTgrohnsxknt0y46u6ZZcMA8GEYYMpo3e
      472gQNNYguIYRg6isa3+yjUOQpM0dMxA1K2JjZSNR5qYT+Joe3nZjz7idtvKItiP
      H2uS0REu0dZ5JqG5ZKJH0AP647P47BEQK4Mf4ji3a7l9f9je2L+h0+8fvwIDAQAB
      AoGAHaSkQvnlT1K35/9mcE63hvwkSSWgd4xqdyoOfY9p3jwciWbDbbjzzgpKqvVQ
      2D4Rb/cOvm6xv9+ls6zLz2sX/GR7Rk+LaaU17AcOlnJH7KwPu5x0JdrufeWqMoyN
      foctdnHWTOaXD9QoDJkyuADep4+SKkPt3CXJ3yxghs7S/SkCQQDyfMLc4qpChpos
      fjHM10qjIReGYaB9DemVuTDdjcpuVrUmhLZK5DYsHi86eFyVJEJHbe5nFbeFBNcw
      AcyLkhtZAkEA1MpYyLjhigDsjD2vClU9wxC4sEIfVIWqSkE2BBzUXUWKvDrYPURA
      Phorj7KDO3bZ7vEkdlO+3vq6pDHGzE5o1wJAUy79YezX325xYSYBS3XngsKNYWoI
      Nh4ZrWUUIEzNzsAr8ITCTDqxYr0QEozLpdYEbqCFkhNfG2CnuS5EzvRWMQJBAJMI
      DjkDprQY11o/9QcKx1ZV44fG6KcahQQx8wT8drDMMITHlEshMdK3eoocKxmXkhbM
      gQlR7H1eekCiNF9PfpkCQF/Ax5burt/eboCfU0beP7A2DNzCbq8aULobqQ7qjkI6
      jL6Kz4DBzZUrUZ9ZiP9SzCLMUDRwGIItqcRfuXiVfok=
      -----END RSA PRIVATE KEY-----

Testing Decryption
~~~~~~~~~~~~~~~~~~~

1.	Open A PowerShell window at **IzendaSimpleAuthorization/Server/**
2.	Run *python rsa_encryption.py*
3.	This will run the main method of rsa_encryption which will load an RSA Private Key and decrypt the encoded message hardcoded in the file. Please note, this message was encrypted using the following Public Key and was created for testing purposes. 

.. code-block:: text

   <RSAKeyValue><Modulus>yY776bGTUlm57UG1R04K6IZ7MZJ7dMuOrumWXDAPBhGGDKaN3uO9oEDTWILiGEYOorGt/so1DkKTNHTMQNStiY2UjUeamE/iaHt52Y8+4nbbyiLYjx9rktERLtHWeSahuWSiR9AD+uOz+OwRECuDH+I4t2u5fX/Y3ti/odPvH78=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>

Python Code: Modifying our Get Token Route
---------------------------------------------
1.	Return to our **IzendaSimpleAuthorization/Server/app.py** file in a text editor.
2.	At the top of the file, we will need to import our newly created rsa_encryption module:
from rsa_encryption import RSAEncryption
3.	Modify our Get Token Route.

.. code-block:: python
 
    #Route to validate an encrypted token. This will return a JSON containing an encrypted token.
    @app.route('/gettoken',  method=['GET', 'OPTIONS'])
    def gettoken():	
     message = request.query.message #Get Message from Query String. This will contain the info required to build an Izenda token. If your application has additional information to add to the token, you would need to add it here.

     #Set Up RSA Encryption for Exports.
     rsa_encryptor = RSAEncryption()
     rsa_private_key = rsa_encryptor.loadPrivateKey("C:/source/PythonTest/Python Dev/Server/rsa_private.pem", None) 

     plaintext = rsa_encryptor.decrypt(rsa_private_key, message) #This is the plain text decryption of the RSA encrypted message from the Izenda API
     decryptedIzendaObject =  eval(plaintext) #this converts the plain text to a dictionary
     myUserInfo = getUserInfo(decryptedIzendaObject.get("UserName"), decryptedIzendaObject.get("TenantUniqueName"))
     myToken = { "Token" : encrypt(myUserInfo) } #Izenda requires that our token is wrapped in a JSON Object. The token will be encrypted in the same manner as our generatetoken route.
     return myToken

Creating Unique RSA Keys
-------------------------
Izenda’s RSATool can be used to create a unique private key and public key pair for your application (see https://downloads.izenda.com/Utilities/Izenda.Synergy.RSATool.zip). With our current setup, the Private Key will need to be saved in PEM format in the rsa_private.pem file but this can be changed to fit your RSA Implementation. 

The public key will always be stored in XML format in the Izenda System Setting Table. The following query can be used to update the public key value. Remember, you will need to restart your Izenda API for this change to take effect. 

.. code-block:: text
 
    UPDATE IzendaSystemSetting SET Value = 'YOUR XML RSA PUBLIC KEY HERE' WHERE Name = 'AuthRSAPublicKey';

**************************************
Implementing A Route For Copy Console
**************************************

The Izenda Copy Console is an application that allows you to copy reports from one environment to another. A full explanation of the Copy Console and its usage can be found at https://www.izenda.com/docs/ui/doc_copy_console.html . 

.. figure::  /_static/images/dev/howto_dep1/9b.PNG


* **Copy Console Application** : A Black Box application to copy reports from one environment to another.
* **SampleConfig.xml** : A configuration file that will allow you to specify the source and destinations for your copy process. In integrated scenarios, you will specify an *authAppRoute* to authenticate against your application.
* **/ccauth** : A route in our Python application that the Copy Console will use as our *authAppRoute* for either our Source or Destination instance of Izenda

Creating The Copy Console Route
=================================

In order to use the Copy Console with an integrated instance of Izenda, you will need to provide an "authAppRoute" route that (1) Authenticates the user against your application and (2) Creates a valid access token the API can use to authorize against your application. At its core, this will be a combination of the logic used in our **/login** route and our **/generatetoken** route but the token will need to be wrapped in a specific JSON Structure to work with the Copy Console.

The following Python code utilizes the concepts demonstrated in the C# *authAppRoute* sample code provided at https://www.izenda.com/docs/ui/doc_copy_console.html#configuring-the-appauthurl-endpoint . This utilizes the authentication and authorization methods we created in previous sections to create the expected JSON for the copy console. An updated JSON can be found with the original C# Code Sample.

1. In *IzendaSimpleAuthorization/Server/app.py*, create the following **/ccauth** route.

.. code-block:: python

 @app.route('/ccauth',  method=['POST', 'OPTIONS'])	
 def ccauth():
  #Retrieve username and Password from Copy Console request
  username  = request.forms.get('username')
  password = request.forms.get('Password')

  #Authenticate against our application. Recall the result of the validation should be an employeeID
  employeeID = validateLogin(username, password)
  #Get a user info object given our employee ID
  userInfo = findUser(employeeID)
  #Generate a token for our application 
  token = "" 
  if userInfo is not None:
   token = encrypt(userInfo)
  #Wrap token in the expected response body from the Copy Console	
  accessToken = { "cultureName" : "en-US", "tenant" : "", "isExpired" : "false", "notifyDuringDay" : "", "dateFormat" : "DD/MM/YYYY", "token" : token }

  response={}
  headers = {'Content-type': 'application/json'}
  response['status'] ="Success"
  response['data']= accessToken
  result = json.dumps(response,headers)
  raise HTTPResponse(result,status=200,headers=headers)

Configuring The SampleConfig.xml
=================================

The copy console uses an XML file for all configuration settings including credentials for source and destination, Report IDs to copy, and database mappings from the Source to Destination. A sample config can be found on our downloads page.

1. Download a copy of the SampleConfig.xml from https://downloads.izenda.com/Utilities/SampleConfig.xml .
2. Open the SampleConfig.xml in your text editor. The following XML will allow the Copy Console to authenticate with our sample user's credentials:

.. code-block:: text

   <credentials userName="Bob" password="test123" apiUrl="http://localhost:8085/api/" appAuthUrl="http://localhost:8080/ccauth"/>

Testing The Copy Console Route
=================================

Our copy console route can be tested using Postman but would best be tested directly with the Izenda Copy Console. In order to use to Copy Console, we will need to specify a Source as well as a Destination in your SampleConfig.xml. The Copy Console is Deployment Mode agnostic which will allows us to copy reports from a standalone instance of Izenda to an embedded instance of Izenda or vice versa. When specifying the credentials for a standalone instance of Izenda, an appAuthUrl is not required.

Recall, a full explanation of the Copy Console and its usage can be found at https://www.izenda.com/docs/ui/doc_copy_console.html . 

**********
Extensions
**********

* Migrating Your User Store to a database: In a production environment, we recommend storing your users in a database. Here, be sure to encrypt your users’ passwords

* Encryption: In our current sample, users are authorized in the host application by using a simple employee ID number.  In a production scenario, be sure to encrypt this value. Depending on how tightly you wish to integrate Izenda, you may be able to store this information in the same authorization token and simply provide this token after a user logs in. This process could eliminate the generate token route we use in our Izenda Integrate file because the user would already have their token.

* Serving HTML Pages and Authenticating/Authorizing from one application: This sample separated the authentication/authorization application from the front end development. Depending on your framework, you may opt to merge the two layers together to reduce potential latency.

*********************************************
Summary Route Locations and Database Changes
*********************************************

.. figure::  /_static/images/dev/howto_dep1/summaryB.PNG

* **Izenda API**
  * Izenda API is hosted on IIS using port 8085 (http://localhost:8085)
* **Client (HTML Front End Application)**
  * Our simple front end application is hosted on IIS using port 8086 (http://localhost:8086).
    * index.html : Renders Izenda as a single page application.
    *	login.html : Provides a place to log in to our host application.
    *	exportrender.html : A page that will be used to render Izenda exports on the server.
    *	Scripts
  * login.js : logs a user in to the host application.
  * izendaintegrate.js: holds the core logic for rendering Izenda. A front end implementation similar to this is recommended.
  *	izenda : this folder contains all of the Izenda Embedded UI elements.
* **Server (Authorization Application)**
  * Our Authorization Application (app.py) is hosted on Python’s development server using port 8080 (http://localhost:8080)
    * *Required Application Routes for Izenda*
      *	/validatetoken: Corresponds to AuthValidateAccessTokenURL. Validates a token sent from the Izenda API. This method will return a user info object (Izenda Username and a Unique Tenant name) for the Izenda API.
      *	/gettoken : Corresponds to AuthGetAccessTokenURL. Get token decrypts an RSA Message sent from the Izenda API and creates a valid token based off of the contents in the decrypted message. Unencrypted, the token generated should contain an Izenda Username and a Unique Tenant name.
     *	*Beneficial Application Routes*
       *	/generatetoken: Generates a token to be used in the validation process. In this sample, it requires verification that the user is logged in to host application. Unencrypted, the token generated should contain an Izenda Username and a Unique Tenant name. 
       *	/login : Allows user to log in to host application.
       * /ccauth : A route in our Python application that the Copy Console will use as our *authAppRoute* for either our Source or Destination instance of Izenda
   * rsa_encryption.py : Holds methods to load an RSA private key from a file and decrypt messages that are encrypted by the Izenda API. Used in our gettoken route.
   *	rsa_private.pem: Holds our RSA private key for export decryption. At this time, this file is not password protected.

*	**Izenda Database** : System Setting Table Values
  *	*Validation*
    *	AuthValidateAccessTokenURL: http://localhost:8080/validatetoken
  *	*Exporting*
    *	AuthGetAccessTokenURL: http://localhost:8080/gettoken
    *	RSAPublicKey: <RSAKeyValue><Modulus>yY776bGTUlm57UG1R04K6IZ7MZJ7dMuOrumWXDAPBhGGDKaN3uO9oEDTWILiGEYOorGt/so1DkKTNHTMQNStiY2UjUeamE/iaHt52Y8+4nbbyiLYjx9rktERLtHWeSahuWSiR9AD+uOz+OwRECuDH+I4t2u5fX/Y3ti/odPvH78=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>
    *	WebURL: http://localhost:8086/

*	**Application Login:** Username: Bob, Password: test123
