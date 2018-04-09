==================================================
Deployment Mode 1: Key Components for Integration
==================================================

The following diagram illustrates the minimum components necessary for an application in deployment mode 1.

[Image]



Standard Security Handshake
============================

Generating the token
---------------------
Generating the token will be necessary from the front end to allow a user to access Izenda.

* In its unencrypted form, the token should contain the information found within an Izenda UserInfo object, the Izenda User name ("UserName") and unique Izenda tenant ("TenantUniqueName") name.

* There is not a set formula to generate the token— if desired, your Izenda User Info can be wrapped within your own application’s token, stored within a cookie, or even uniquely generated every time a new Izenda page loads. In our sample kits, this is handled by a restful API call to the host application in a file called "izenda.integrate.js"

* Before rendering Izenda, you will need to retrieve a token from your application. Once a token is retrieved, you will need to set the Izenda User Context on the client side to use the token. This will be done using the Front End Integration Endpoint *setCurrentUserContext* .

Calling the Izenda API
----------------------

For the majority of Izenda API endpoints, a header "access_token" is required.

  * When the front end calls the API, the access_token is retrieved from the current Izenda User Context applied.

  * If the API is called outside of the platform (e.g. a custom role creation page in your application), the Izenda user context cannot be accessed and the access_token can be specified by the host application's requirements.


Validating the token
--------------------

When the Izenda API recieves a request, it will take the access_token sent with the request and ask the host application to interpret it to ensure that it refers to a valid user. 

* Within the IzendaSystemSetting table of your configuration database, there is an entry for AuthValidateAccessTokenUrl. The AuthValidateAccessTokenUrl defines a route within the host application that will validate an access_token.

* Your token validation function for your application will be an inverse of your token generation function. The goal is to decrypt the token, interpret the data, and return a valid User Info Object to Izenda.

Exports
=========

Server-Side Security Handshake
-------------------------------
When reports are exported, scheduled instances are established, or emails are sent, the exported result is rendered on the server and sent to the desired recipient.
Since these interactions occur on the server side, the "authentication" mechanism will differ from the Standard Security Handshake.

* When a report is exported, the Izenda API will need an access_token so that the API calls required for the render will return successfully.

* Since the export process is handled server-side, the access_token must originate from the server-side and, therefore, cannot be passed from a client's user context.

  * Problem: Although the Izenda API has the information to create a User Info object (the UserName and TenantUniqueName are stored in the Izenda Configuration database), it doesn't have the ability to create access_tokens that can be validated with the host application.

  * Solution: The Izenda API will send the information it does have to the host application so that the host application can return a valid access_token. To ensure security, the information sent to the host application will be encrypted using a standard mechanism, RSA.

Validating the token
~~~~~~~~~~~~~~~~~~~~

Token validation will still be handled by the AuthValidateAccessTokenUrl route within the host application.


Getting The Token
~~~~~~~~~~~~~~~~~~

* Within the IzendaSystemSetting table of your configuration database, there is an entry for AuthGetAccessTokenURL. This will be a route in your that will generate a valid token given an RSA-Encrypted Message.
  
  * This route differs from our Token Generation method as it does not require authentication with the host application.
  
  * The message itself will be encrypted by the Izenda API using the RSAPublicKey found in the Izenda Configuration Database. In its unencrypted form, the message contains the information for a UserInfo object.
  
  * The host application will have a corresponding RSA Private Key to decrypt the message. Once the message is decrypted,  the host application will need to create an token that can be decrypted with your Token Validation route above.

Rendering Exports
--------------------
