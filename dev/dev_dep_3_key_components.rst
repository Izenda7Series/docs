==================================================
Deployment Mode 3: Key Components for Integration
==================================================

Deployment Mode 3 is considered a tight integration where the Izenda API resources exist *inside* the host application. 

	* The Host Application must use a a .NET-ready codebase including frameworks such as .Net MVC5 and Webforms.
	
	* Authorization logic is written in C#
	
	* The Izenda "Front End" is most commonly served from the same application that hosts the Izenda API (e.g. views within an MVC5 Application). The "Front End" can exist as a separate application but such use cases are often better suited for Deployment Mode 1.

.. DANGER::
	Deployment Mode 3 may result in versioning conflicts if your application utlizes resources that are also used within the Izenda API. If your application contains resources that may conflict, the recommended deployment mode is Deployment Mode 1. A full list of Izenda dependencies can be found `here. <https://www.izenda.com/docs/acknowledgements.html>`_


..note::
	A full `tutorial. <https://www.izenda.com/docs/dev/howto_mvc5kit.html>`_ is available for creating an application that uses Deployment Mode 3.
	
	
The following diagram illustrates the minimum components necessary for an application in deployment mode 3.

[Image]
	
Configuring The Host Application for Izenda's API Resources
=======================================================

Web.Config
-----------------

The Web Config contains all of the configuration information for your application and will also need to contain all of the configuration information for the Izenda API resources that exist within your application. This will include:

* Configuring nancyFX for Izenda API routing

* Configuring log4net for system interaction and error logging

* Recommended: Configuring app settings for Izenda that can be used throughout the application.

	* This may include global values you wish to keep in once place such as credentials for back-end API interactions, the routing prefix your application will ignore in the RouteConfig, and the Izenda API URL that will be used on the client side to make requests to the Izenda API.


A detailed guide for creating  the Web.Config can be found `here. <https://www.izenda.com/docs/dev/howto_mvc5kit.html#izenda-api-service-hosting-config>`_ 

.. note::
	After downloading a new version of the Izenda API, you will need to ensure that any updates in the new API resource's Web.Config are reflected in the host application's Web.Config

RouteConfig.cs
-----------------------

Within the route config, you will need to configure a rule for the host application to ignore requests intended for the Izenda API. This will ensure there are no conflicts when the front end resources request data from the API. 

* The route to ignore should correspond to the Nancy Handler established in the Web.Config.  For instance, if you Handler for NancyFX has the path value path="api/*"  (e.g. <add name="Nancy" verb="*" type="Nancy.Hosting.Aspnet.NancyHttpRequestHandler" path="api/*" />), then you will configure your Route Config to ignore routes to "api" (e.g. routes.IgnoreRoute("api/{*pathInfo}"); ).

More information can be found at `here <https://www.izenda.com/docs/dev/howto_mvc5kit.html#izenda-api-service-hosting-config>`_  and `here  <https://www.izenda.com/docs/dev/howto_mvc5kit.html#izenda-api-service-hosting-config>`_  


IzendaConfig.cs
-----------------------
IzendaConfig.cs in an extension class where you will register logic for Izenda token validation and Izenda server-side token generation for exports. Sections below outline these components and how they are used in the integration.

A detailed guide for creating the IzendaConfig.cs can be found `here. <https://www.izenda.com/docs/dev/howto_mvc5kit.html#izendaconfig>`_  .


.. note::
	To ensure that your authorization logic is registered, you will need to call IzendaConfig.RegisterLoginLogic() when you application first starts. In .Net applications, this will often occur in the Application_Start() function of the Global.asax


Izenda API-Izenda Configuration Database Interactions
=======================================================

The Izenda API interacts with the Izenda Configuration database through the connection string stored in the file izendadb.config. 

* The izendadb.config file will exist within the root directory of your API and can be created by using the API Endpoint `databaseSetup/databaseInfo . <https://www.izenda.com/docs/ref/api_systemdb_and_license.html#post-databasesetup-databaseinfo>`_
	
	* If the connection is established via the API, the connection string in izendadb.config will be encrypted.
	
	* If the database specified in the connection string is does not contain the Izenda Configuration tables, the tables will automatically be created.
	
	* To change the Izenda Configuraton Database connection string, the izendadb.config file must be deleted or a valid access_token must be supplied to subsequent requests to the API Endpoint.


Structures in Host Application
===============================
* **ValidateTokenResult Object** : An object that contains the necessary information to clearly identify an user within Izenda.
	* Click `here. <https://www.izenda.com/docs/ref/models/ValidateTokenResult.html?highlight=validatetokenresult>`_  for more information.

	* An Izenda user can only exist in a single tenant but Izenda can be configured to allow the same username to exist in multiple tenants. As a result, the User's name "UserName" and the Tenant ID "TenantUniqueName" pair is used as an identifier for a User.

		* *UserName* : This value corresponds to a UserName value found within the IzendaUser table of the Izenda Configuration Database.

		* *TenantUniqueName* : This value corresponds to a TenantID field in the IzendaTenant table of the Izenda Configuration Database.

	* Whenever your application returns this information to the Izenda API, it will be interpretted as a JSON similar to {UserName : "IzendaAdmin", TenantUniqueName: ""}
	
	* Additional data can be added to the object but it will not be interpretted by Izenda during the security handshake. The additional data could be used in custom logic such as IAdHocExtension implementations (e.g. hidden filters).

* **Token** : A token refers to an encrypted string that the host appication will provide authorization into Izenda. In its unencrypted form, the token will contain the information found in a ValidateTokenResult Object.


Client-Side Interactions
============================


Rendering the Front End Application
------------------------------------


Embedded UI
~~~~~~~~~~~~

The Embedded UI refer to the Izenda Front End resources used to render the front end application.  If desired, these resources can be bundled in a resource bundler such as Webpack.

izenda.integrate.js
~~~~~~~~~~~~~~~~~~~~

Many of our sample applications contain an "Izenda Integrate" file that implements several of our Front-End integration API endpoints. A full list of integration endpoints can be found `here. <https://www.izenda.com/docs/dev/api_frontend_integration.html>`_

The following steps can be used to render an Izenda Component in your application.

1. **Configuring Izenda** : Use the endpoint `IzendaSynergy.config(configJson) <https://www.izenda.com/docs/dev/api_frontend_integration.html#config-configjson>`_ to configure Izenda with your application's presets. The following are the most frequent customizations to the configuration JSON for this Endpoint.

   * *WebApiUrl* : The URL of your Izenda API (*e.g. http://localhost:8085/api/"*)
   
   * *RootPath* : The relative location of your Izenda Resources in your application (*e.g. /scripts/izenda*). This path is required for Form report parts.
   
   * *CssFile* : The name of your CSS file (*e.g. "izenda-ui.css"*)

2. **Setting the User Context** : Whenever rendering an Izenda component, you must first set the User Context with a token from you application. The User Context will be set using `setCurrentUserContext({token:access_token}). <https://www.izenda.com/docs/dev/api_frontend_integration.html#setcurrentusercontext-token-access-token>`_ The User Context allows the front end to call the Izenda API *on behalf of* the user in your application.

 * The token stored in the User Context will be stored as the object *token* . Whenever it is sent to the API, it will be sent as the header *access_token*

 * In Deployment Mode 3, Izenda Integrate often contains a mechanism to retrieve a token from the host application (e.g. via an AJAX call). This process is described in greater detail in *Standard Security Handshake* section below.

3. **Rendering a Component** : Once the User Context is set, you can call any of Izenda's render functions. To Render the full platform, use the endpoint `render(element) <https://www.izenda.com/docs/dev/api_frontend_integration.html#render-element>`_ .


Page To Render Platform
~~~~~~~~~~~~~~~~~~~~~~~~~

A page will exist in your application to render Izenda Components. This page will need to include references to the EmbeddedUI resources and must have an HTML Element to render the component within.

* **Referencing the EmbeddedUI Resources** : the EmbeddedUI resources can be bundled with the host application's resources or referenced directly on the page. The following order ensures that resources are loaded correctly to be referenced in "izenda.integrate.js" or a comparable front-end implementation in the host application.

    * izenda_common.js
    
    * izenda_locales.js
    
    * izenda_vendors.js
    
    * izenda_ui.js
    
    * izenda.integrate.js

* **Calling a function in izenda.integrate.js** : After the resources are loaded, the page can call a function in izenda.integrate.js to render an Izenda component.



Standard Security Handshake
----------------------------

Generating the token
~~~~~~~~~~~~~~~~~~~~~
Generating the token will be necessary from the front end to allow a user to access Izenda. This corresponds with the "/generatetoken" route in the image above.

* In its unencrypted form, the token should contain the information found within a "ValidateTokenResult" object.

* There is not a set formula to generate the token. If desired, the information needed for a ValidateTokenResult object  can be wrapped within your own application's token, the token can be stored within a cookie, or the token can even be uniquely generated every time a new Izenda page loads. In our sample kits, this is handled by a restful API call to the host application in a file called "izenda.integrate.js"

* Before rendering Izenda, you will need to retrieve a token from your application. Once a token is retrieved, you will need to set the Izenda User Context on the client side to use the token. This will be done using the Front End Integration Endpoint *setCurrentUserContext* .

Calling the Izenda API
~~~~~~~~~~~~~~~~~~~~~~~

For the majority of Izenda API endpoints, a header "access_token" is required.

  * When the front end calls the API, the access_token is retrieved from the current Izenda User Context applied.

  * If the API is called outside of the platform (e.g. a custom role creation page in your application), the Izenda User Context cannot be accessed and the access_token can be specified by the host application's requirements.


Validating the token
~~~~~~~~~~~~~~~~~~~~~~
When the Izenda API recieves a request, it will take the access_token sent with the request and ask the host application to interpret it to ensure that it refers to a valid user.  

* Your token validation function for your application will be an inverse of your token generation function. The goal is to decrypt the token, interpret the data, and return a valid ValidateTokenResult to Izenda.

* In Deployment Mode 3, your logic to validate tokens must be registered with the Izenda resources within the host application. The registration will be handled within a file called IzendaConfig.cs and will be registered as UserIntegrationConfig.ValidateToken .
	* The access token is passed into the registered function within the "ValidateTokenArgs args" parameter as args.AccessToken.

Server-Side Interactions
=========================

Export Security Handshake
-------------------------------
When reports are exported, scheduled instances are established, or emails are sent, the exported result is rendered on the server and sent to the desired recipient.
Since these interactions occur on the server side, the "authentication" mechanism will differ from the Standard Security Handshake.

* When a report is exported, the Izenda API will need an access_token so that the API calls required for the render will return successfully.

* Since the export process is handled server-side, the access_token must originate from the server-side and, therefore, cannot be passed from a client's user context.

  * **Problem** : Although the Izenda API has the information to create a ValidateTokenResult object (the UserName and TenantUniqueName are stored in the Izenda Configuration database), it doesn't have the ability to create access_tokens that can be validated with the host application.

  * **Solution** : The Izenda API will send the information it does have to the host application so that the host application can return a valid access_token. Since the Izenda API exists within the same application as the token generation logic, this information is passed in plain text to the host applicaiton's logic.

Getting The Token
~~~~~~~~~~~~~~~~~~

* In Deployment Mode 3, your logic to get tokens server-side must be registered with the Izenda resources within the host application. The registration will be handled within a file called IzendaConfig.cs and will be registered as UserIntegrationConfig.GetAccessToken.
 
	* This logic differs from your Token Generation method as it is never called RESTfully and does not require authentication with the host application to create a token.
  
		* This logic is only used by Izenda server-side. End users have no means to use this mechanism to create tokens without authenticating.
		
	*  The UserName and TenantUniqueName is passed into the registered function within the "String args" parameter as args.UserName and args.TenantUniqueName, respectively.
		
		* If additional data is usually stored in the host application's ValidateTokenResult object structure, logic will need to exist to retrieve the necessary information.
	
* Once a ValidateTokenResult object is created, the object can be encrypted as a token and returned to Izenda. Remember, this token must be decryptable by our Token Validation logic.

  
Validating the token
~~~~~~~~~~~~~~~~~~~~

Token validation will still be handled by the same Token Validation logic that was previously registred with Izenda.


Rendering Exports and Sending Links
------------------------------------

The host applicaiton will need to refer to the Izenda resources to adhere to any customizations made to the front-end.

WebURL
~~~~~~~
The WebURL will be the "Base URL" for email links and the route used for exports. 

* The WebURL will point to the application that holds your Embedded UI resources.
  
  * In the MVC Kit, the EmbeddedUI resources are found within the MVC Kit hosted on 14809. In turn, the WebURL would be http://localhost:14809/ . 
  
Page To Render Exports
~~~~~~~~~~~~~~~~~~~~~~~
After the Izenda API obtains a valid access token from the AuthGetAccessTokenURL, it will attempt to access this route to render the report on the server.

* Since this process occurs on the server, schedules and exports can run successfully without a user being active on the front end. This page will be used to render any chart visualizations.

* Izenda has a definite structure for this route, WebURL + "/viewer/reportpart/". This corresponds to the "Page to render exports" in the image above.

* Similar to the Page to Render the platform, this page will need to reference the EmbeddedUI and an HTML Element to render Izenda Components.
  
  * The token will be sent to this page in a query string as *token* . The host application will set the user context using this value.
  
  * The Report Part ID will be sent to this page in a query string as *id* . The host application will use the Front End Integration Endpoint `renderReportPart(element,params) <https://www.izenda.com/docs/dev/api_frontend_integration.html#renderreportpart-element-params>`_ to render the a chart report part for export.
  
  * The Izenda API will call this page multiple times to render all chart report parts in the selected report.
  
Copying Reports from One Environment To Another
---------------------------------------------------------------------------

Reports can be copied from one Izenda instance to another via the Izenda Copy Console. To use the Copy Console in integrated modes, a route must exist in your application that allows for a user to authenticate with your application and immediately returns an access_token to be used with Izenda API interactions. In the diagram above, this route corresponds to the "/copyconsoleauth
" route.

A detailed description of the Copy Console and its requirements can be found at `here <https://www.izenda.com/docs/ui/doc_copy_console.html>`_
