

==========================
Security Recommendations
==========================

Recommendations on configuring the system for security best-practices.

.. _Web_Server_Security_Configurations:

Web Server Security Configurations
----------------------------------

Use Custom Error Messages
~~~~~~~~~~~~~~~~~~~~~~~~~

Besides being too technical for end-users, error messages may contain
sensitive information of the system or its users. Therefore, it is best
practice to show original error messages to only local clients (opened
on the server box), and friendly error messages to remote clients
(end-users).

For example, this erroneous API call
``http://127.0.0.1:8888/api/report/info/foo`` will
result in a 500 Internal Server Error:

.. code-block:: json

   {
      "message" : "The application has encountered an unknown error. Please contact System Administrator for further information."
   }

On the other hand, end-users should be presented with a non-technical
and more friendly message such as:

.. code-block:: text

   Something's wrong!

   It looks like something is broken in our system.
   Don't panic - the situation has been logged and we will get to it as soon as we can.

HTML source of a sample error page - save it as the file ErrorPage.html under C:\\inetpub\\wwwroot\\Izenda\\API:

.. container:: toggle

    .. container:: header

       Error page HTML source

    .. code-block:: html
       :linenos:

       <!DOCTYPE html>
       <html style="height:100%">
       <head><title> 500 Internal Server Error
       </title></head>
       <body>
       <h2 style="margin-top:20px;font-size: 30px;">Something's wrong!
       </h2>
       <p>It looks like something is broken in our system.<br> Don't panic - the situation has been logged and we will get to it as soon as we can.</p>
       </body>
       </html>

To configure IIS 7.0+:

-  Add the following under ``<system.webServer>``:

.. code-block:: html

   <httpErrors errorMode="DetailedLocalOnly">
      <remove statusCode="500" subStatusCode="-1" />
      <error statusCode="500" path="/ErrorPage.html" responseMode="ExecuteURL" />
   </httpErrors>

-  Possible values for ``errorMode``:

   -  DetailedLocalOnly: Returns detailed error information if the
      request is from the local computer, and returns a custom error
      message if the request is from an external computer.
   -  Custom: Replaces the error that the module or server generates
      with a custom page that you specify.
   -  Detailed: Sends detailed error information back to all clients.

-  Alternatively configure IIS via the UI:

   #. Select the Izenda site.
   #. Double-click Error Pages in the middle panel (Features View).
   #. Select the status code then click Edit Feature Settings.. in right
      panel to configure.

To configure IIS 6.0:

-  Add the following under ``<system.web>``:

.. code-block:: html

   <customErrors mode="RemoteOnly">
      <error redirect="/ErrorPage.html" statusCode="500" />
   </customErrors>

-  Possible values for ``mode``:

   -  On: Specifies that custom errors are enabled. If no
      defaultRedirect attribute is specified, users see a generic error.
      The custom errors are shown to the remote clients and to the local
      host.
   -  Off: Specifies that custom errors are disabled. The detailed
      ASP.NET errors are shown to the remote clients and to the local
      host.
   -  RemoteOnly: Specifies that custom errors are shown only to the
      remote clients, and that ASP.NET errors are shown to the local
      host. This is the default value.

-  Alternatively configure IIS via the UI similarly to IIS 7.0+.

Configure Cross-Origin HTTP Access (CORS)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Browser security prevents a web page from making HTTP requests to
another domain. This restriction is called the `same-origin
policy <https://en.wikipedia.org/wiki/Same-origin_policy>`__, and
prevents a malicious site from reading sentitive data from another site.
However, our web API wants to allow the calls from the Front-end site,
which may be on another domain. This can be configured using the `Cross
Origin Resource Sharing (CORS) <http://www.w3.org/TR/cors/>`__ standard.

To allow calls from only the Front-end site while rejecting others:

#. In Web.config, locate the section ``<system.webServer>``,
   ``<httpProtocol>``, ``<customHeaders>``,
   ``<add name="Access-Control-Allow-Origin" value="*" />``.
#. Change the default value \* to the addresses (and ports) of the
   Front-end sites, separated by comma. For example:
   ``<add name="Access-Control-Allow-Origin" value="http://www.acme.com,http://www.example.com" />``.

Izenda Security Configurations
------------------------------

Replace the default System Admin account
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 

The default Izenda System Admin account comes with a pre-defined username. For best security, :ref:`another System Admin account <Add_a_System_Admin_user>` should be created, then the default account be deactivated or deleted to prevent attempts on that pre-defined username.

Set Password Policies
~~~~~~~~~~~~~~~~~~~~~

 

Make use of the :ref:`Password Complexity settings <Configure_Password_Complexity_Sample>` in System Configuration > Security Policies page to enforce strong
passwords.

Reference
---------

-  `IIS HTTP
   Errors <https://www.iis.net/configreference/system.webserver/httperrors>`__
-  `Enabling Cross-Origin Requests in ASP.NET Web API
   2 <https://www.asp.net/web-api/overview/security/enabling-cross-origin-requests-in-web-api#allowed-origins>`__
