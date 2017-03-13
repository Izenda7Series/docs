

==========================
Installation Guide
==========================

An automatic installation process is still in progress.

In the mean time, installation includes the following manual steps.

Pre-install Preparations
------------------------

-  Izenda installation packages

   *  .. _Izenda_App_folder:

      .. figure:: /_static/images/Izenda_App_folder.png
         :align: right
         :width: 482px

         Content of Front-end package

      An Izenda Front-end Package (Default name "App"). |br|
   *  .. _Izenda_API_folder:

      .. figure:: /_static/images/Izenda_API_folder.png
         :align: right
         :width: 482px

         Content of Back-end package

      An Izenda Back-end Package (Default name "API"). |br|

-  Server

   *  Windows Server with Internet Information Services (IIS) Web Server.

Web Server Setup
----------------

Add Web Server Role and .NET Framework
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 

#. Open Server Manager.
#. Click Quick Start, then Add roles and features to open Add Roles and
   Features dialog box.
#. Click Next to accept default selections until Select Server Roles.
#. Tick the Web Server (IIS) check-box.
#. Click Add Features in the next dialog box.
#. Expand .NET Framework 3.5 features and tick .NET Framework 3.5
   check-box.
#. Expand .NET Framework 4.5 features and tick .NET Framework 4.5
   check-box.
#. Accept other default options then click Install.

Install ASP.NET 4.5 and URL Rewrite Components
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 

#. Open Microsoft Web Platform Installer’s `download page <https://www.microsoft.com/web/downloads/platform.aspx>`__.

       This can also be opened from IIS Manager Actions panel, "Get New
       Web Platform Components" link.

#. Download and run the installer.
#. Open Microsoft Web Platform Installer and search for "ASP.NET".
#. Select "IIS:ASP.NET 4.5" and click Add.
#. Similarly search for URL Rewrite 2.0 and click Add.
#. Click Install.

.. _IIS_ASP.NET_install:

   .. figure:: /_static/images/IIS_ASP.NET_install.png
      :width: 667px

      Install IIS ASP.NET 4.5 |br|

Izenda Installation
-------------------

 

#. Extract the Izenda Front-end and Back-end packages to 2 separate
   folders, preferably at C:\\inetpub\\wwwroot\\Izenda\\App and
   C:\\inetpub\\wwwroot\\Izenda\\API.
#. Izenda can be installed in multiple configurations: new website, new
   application to an existing website, or new virtual application under
   an existing website:

   -  New website

      #. Right-click the local connection and select Add Website...
      #. Name the website IzendaApp and accept the Application pool with
         the same name.
      #. Click the ellipsis (...) button to select the location of the
         extracted Izenda Front-end package
         (C:\\inetpub\\wwwroot\\Izenda\\App).
      #. Skip the Connect as... and Test Settings... buttons for now,
         since permissions have not been set for Izenda package folders.
      #. The Port for Front-end is best kept at the default value of 80.
      #. Optionally enter the website address into host name box, but
         you will have to bind that address with the correct ip in
         "C:\\WINDOWS\\System32\\drivers\\etc\\hosts" file.

             e.g. with website address www.acme.com and the ip
             127.0.0.1, the following line needs to be added in hosts
             file:
             ``127.0.0.1    www.acme.com``

      #. Click OK to create the website.

      .. _IIS_Add_Website:

      .. figure:: /_static/images/IIS_Add_Website.png
         :width: 439px

         New Website |br|

   -  New application or virtual application option will go through some
      of the above steps.

#. Install Izenda Back-end package similarly with a different port.

#. .. _IIS_Folder_Permissions:

   .. figure:: /_static/images/IIS_Folder_Permissions.png
      :align: right
      :width: 239px

      Folder Permissions

   Set folder permissions

   #. Right-click the newly-created website, application or virtual
      application and select Edit Permissions to open the folder
      properties.
   #. In Security tab, click Edit to open Permissions dialog box.
   #. Click Add then enter ``IUSR`` then click OK (for IIS 7 and above).

          For older IIS versions, use ``NT AUTHORITY\\NETWORKSERVICE``.

   #. Back in Permissions dialog box, tick the Modify check-box for
      IUSR.
   #. Click OK to close all dialogs. |br|
   #. Set similar permissions for the other package.

Edit Configuration Files
------------------------

-  Update the Back-end API url in Front-end package:

       Edit the file ``App\izenda_config.js``, replace the default value
       "WebApiUrl" with the correct ip and port:

           ``"WebApiUrl": "<nowiki>http://127.0.0.1:8888/api/</nowiki>",``

-  Change the Back-end passphrase, which is the key to encrypt and
   decrypt data in Izenda.

       Enter a 29-character value into the value of this key:
       ``<appSettings>``, ``<add key="izedapassphrase" value="" />``

.. warning::

   This passphrase cannot be changed afterwards since already encrypted data cannot be decrypted with another passphrase.

-  Recommended: add :ref:`security
   configurations <Web_Server_Security_Configurations>`

-  Optionally change the default Back-end path ``/api/``

       e.g. change the path to ``/rest/``

   #. Edit the file ``API\Web.config``, replace the default value "api"
      with the new value at the following places:

      -  ``<appSettings>``, ``<add key="izedaapiprefix" value="api" />``
      -  ``<system.web>``, ``<httpHandlers>``,
         ``<add verb="*" type="Nancy.Hosting.Aspnet.NancyHttpRequestHandler" path="api/*" />``
      -  ``<system.webServer>``, ``<handlers>``,
         ``<add name="Nancy" verb="*" type="Nancy.Hosting.Aspnet.NancyHttpRequestHandler" path="api/*" />``

   #. Also edit the file ``App\izenda_config.js``, replace the default
      value "api" with the new value at the following places:

      -  ``"WebApiUrl": "<nowiki>http://127.0.0.1:8888/api/</nowiki>",``

-  Optionally change Izenda log file settings

   -  Change the default log file location in ``<log4net ..>``,
      ``<appender name="RollingFileAppender" ..>``,
      ``<file value="logs\izenda-log.log" />``, which resolves to
      C:\\inetpub\\wwwroot\\Izenda\\API\\logs in a typical installation.
   -  Change how the log files are archived/rotated/rolled in
      ``<log4net ..>``, ``<appender name="RollingFileAppender" ..>``.

          The default setting is to keep maximum 1000 last files of 5MB
          each every day. See other examples at `log4net
          document <https://logging.apache.org/log4net/release/config-examples.html#rollingfileappender>`__.

   -  Enable folder compression: log file content is all text and will
      compress up to 2% of the original size.

      #. Right-click on the folder
         (C:\\inetpub\\wwwroot\\Izenda\\API\\logs) and click Properties.
      #. Click Advanced button in General tab.
      #. Tick Compress contents to save disk space check-box, then click
         OK twice.
      #. Select either option: this folder only, or this folder,
         subfolders and files then click OK.
      #. Confirm the compression status: the folder will have blue name,
         or have two arrows added at the top right of its icon (from
         Windows 10).

-  Optionally enter settings for `EVO PDF
   Azure <http://www.evopdf.com/azure-html-to-pdf-converter.aspx>`__
   option, or accept the default values to use the local embedded
   library.

   #. Under ``<configuration>``, find or add the following section:
      ::

          <evoPdfSettings cloudEnable="false">
            <azureCloudService server="" port="" servicePassword="" />
          </evoPdfSettings>

   #. Set ``cloudEnable="true"`` to use the Azure option, then enter the
      server IP, port and password.

Deploying Izenda as a Virtual Directory or Application
------------------------------------------------------

For Setting Izenda up using a Virtual Directory the following steps must
be taken.

Within the UI Folder of your Deployment
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

-  Edit the izenda\_config.js, point the BaseURL and the WebApiUrl to
   the virtual directory for your front/back-end respectively

   ::

      BaseUrl:"/<your Url here>/"

   ::

      WebApiUrl:"http://<Your API URL here>/api/"

-  Edit the index.html file and add the URL for the Virtual Directory as
   below, this should follow the ending </style> tag

   ::

      <script>
         window.IzendaPublicPath = '/<your Url here>/';
      </script>

-  Alter the location of the files in the index.html file to point to
   the new location:

   ::

      <link rel="shortcut icon" href="/<your Url here>/favicon.png"><link href="/<your Url here>/izenda-app.css?
        4676ff4fe0cdf3cd2bab" rel="stylesheet">

   ::

      <body>
           <div class="container" id="izenda-root"></div>
           <script type="text/javascript" src="/<your Url here>/izenda-vendors.js?4676ff4fe0cdf3cd2bab"></script>
           <script type="text/javascript" src="/<your Url here>/izenda_app.js?4676ff4fe0cdf3cd2bab"></script>
      </body>

-  Update the web.config file in the UI folder to add

   ::

      <action type="Rewrite" url="/<your Url here>/" />

Within the API Folder of your Deployment
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

-  Update the Web.config file

::

        <httpHandlers>
         <add verb="*" type="Nancy.Hosting.Aspnet.NancyHttpRequestHandler" path="/<Your API URL here>/api/*" />
        </httpHandlers>


::

        <handlers>
         <add name="Nancy" verb="*" type="Nancy.Hosting.Aspnet.NancyHttpRequestHandler" path="/<Your API URL here>/api/*"/>
        </handlers>


Example Changes
~~~~~~~~~~~~~~~

-  The Both the API and Front-end are virtual applications within the
   Default Web Site in IIS (localhost:80)
-  The Front-end is Aliased as IzendaFront
-  The Back-end is Aliased as IzendaBack

-  APP: izenda\_config.js Changes:

::

         BaseUrl:"/IzendaFront/"

         WebApiUrl:"http://localhost:80/IzendaBack/api/"

-  APP: index.html Changes:

::

         <script>
              window.IzendaPublicPath = '/IzendaFront/';
         </script>

::

         <link rel="shortcut icon" href="/IzendaFront/favicon.png">
         <link href="/IzendaFront/izenda-app.css?4676ff4fe0cdf3cd2bab" rel="stylesheet">
         </head>

::

         <body>
              <div class="container" id="izenda-root"></div>
              <script type="text/javascript" src="/IzendaFront/izenda-vendors.js?4676ff4fe0cdf3cd2bab"></script>
              <script type="text/javascript" src="/IzendaFront/izenda_app.js?4676ff4fe0cdf3cd2bab"></script>
         </body>

-  APP: web.config Changes:

::

         <action type="Rewrite" url="/IzendaFront/" />

-  API: web.config Changes:

::

        <httpHandlers>
         <add verb="*" type="Nancy.Hosting.Aspnet.NancyHttpRequestHandler" path="/IzendaBack/api/*" />
        </httpHandlers>

::

        <handlers>
         <add name="Nancy" verb="*" type="Nancy.Hosting.Aspnet.NancyHttpRequestHandler" path="/IzendaBack/api/*"/>
        </handlers>

Next: :doc:`Install Izenda System Database and Apply License </ui/doc_system_db_and_license>`
------------------------------------------------------------------------------------------------------------

 

.. seealso::

   -  `Installing IIS 8.5 on Windows Server 2012
      R2 <http://www.iis.net/learn/install/installing-iis-85/installing-iis-85-on-windows-server-2012-r2>`__.
   -  `Install IIS and ASP.NET
      Modules <http://www.iis.net/learn/application-frameworks/scenario-build-an-aspnet-website-on-iis/configuring-step-1-install-iis-and-asp-net-modules>`__
   -  `Understanding built in user and group accounts in
      IIS <https://www.iis.net/learn/get-started/planning-for-security/understanding-built-in-user-and-group-accounts-in-iis>`__
