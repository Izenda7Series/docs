==========================
Installation Guide
==========================

The following outlines the steps to install Izenda's Stand Alone Portal. While our installation process is still in progress, you can follow the steps below to install Izenda.


Architectural Goal
------------------------

.. figure:: /_static/images/StandaloneArchDiagram2.png

   A diagram of implementation

Pre-install Preparations
------------------------

The setup of Izenda requires a download of the latest version of the stand-alone front-end and the back-end and a proper web server setup. Izenda can be installed on a local machine on a Windows machine for testing purposes and is a best practice for ensuring permissions and performance can be validated locally prior to moving toward more embedded and integrated examples, but it is not recommended for live deployments.

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

.. note::

   All of the information covered in this document can also be found in video from `here <https://www.izenda.com/7-series-installation-videos/#portal-install>`__

Web Server Setup
----------------

To ensure that Izenda works properly, your Web Server requires additional components that may not be present on your server by default.

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

   .. note::

      .. figure:: /_static/images/Server_Role_Web_Server_ASP.NET_4.6.png
         :align: right
         :width: 524px

         Install Server ASP.NET 4.6

      For Windows Server 2016, also check ASP.NET 4.6 in this step and skip adding "IIS:ASP.NET 4.5" in next step. |br|

#. Accept other default options then click Install.

.. _Install_ASP.NET_4.5_and_URL_Rewrite_Components:

Install ASP.NET 4.5 and URL Rewrite Components
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

#. Open Microsoft Web Platform Installer’s `download page <https://www.microsoft.com/web/downloads/platform.aspx>`__.

       This can also be opened from IIS Manager Actions panel, "Get New
       Web Platform Components" link.

#. Download and run the installer.
#. Open Microsoft Web Platform Installer.
#. Search for "ASP.NET", select "IIS:ASP.NET 4.5" and click Add. (Not applicable for Windows Server 2016)
#. Similarly search for URL Rewrite 2.0 and click Add.
#. Click Install.

.. _IIS_ASP.NET_install:

   .. figure:: /_static/images/IIS_ASP.NET_install.png
      :width: 667px

      Install IIS ASP.NET 4.5 |br|

Izenda Installation As Two Separate Sites
------------------------------------------

The most common testing scenario places the front-end and the back-end on two separate sites. Virtual Directories and Virtual Applications deployments are possible with additional configuration and are outlined in another section below.

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
   #. Update the Back-end API url in Front-end package: |br|
      Edit the file ``App\izenda_config.js``, replace the default value "WebApiUrl" with the correct ip and port:
      ``"WebApiUrl": "http://127.0.0.1:8888/api/",``

Deploying Izenda as a Virtual Directory or Application
------------------------------------------------------

For Setting Izenda up using a Virtual Directory the following steps must
be taken.

Initial Set Up
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

*  Add your Front-end package to IIS as a virtual directory. (For the purpose of this tutorial we have given it the alias of IzendaFront)
*  Add your Back-end package but then convert it to an application. (For the purpose of this tutorial we have given it the alias of IzendaBack)

Within the UI Folder of your Deployment
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

#. Edit the izenda\_config.js, point the BaseURL and the WebApiUrl to
   the virtual directory for your front/back-end respectively

   -  Target code:

      .. code-block:: text

         BaseUrl:"/<your Url here>/"

         WebApiUrl:"http://<Your API URL here>/api/"

   -  Example change:

      .. code-block:: text

         BaseUrl:"/IzendaFront/"

         WebApiUrl:"http://localhost:80/IzendaBack/api/"

#. Edit the index.html file and add the URL for the Virtual Directory as
   below, this should follow the ending </style> tag

   -  Target code:

      .. code-block:: html

         <script>
            window.IzendaPublicPath = '/<your Url here>/';
         </script>

   -  Example change:

      .. code-block:: html

         <script>
            window.IzendaPublicPath = '/IzendaFront/';
         </script>

#. Alter the location of the files in the index.html file to point to
   the new location:

   -  Target code:

      .. code-block:: html

          <link rel="shortcut icon" href="/<your Url here>/favicon.png">
          <link href="/<your Url here>/izenda-app.css?
             4676ff4fe0cdf3cd2bab" rel="stylesheet"></head>

          <body>
             <div class="container" id="izenda-root"></div>
             <script type="text/javascript" src="/<your Url here>/izenda-vendors.js?4676ff4fe0cdf3cd2bab"></script>
             <script type="text/javascript" src="/<your Url here>/izenda_app.js?4676ff4fe0cdf3cd2bab"></script>
          </body>

   -  Example change:

      .. code-block:: html

         <link rel="shortcut icon" href="/IzendaFront/favicon.png">
         <link href="/IzendaFront/izenda-app.css?
         4676ff4fe0cdf3cd2bab" rel="stylesheet"></head>

         <body>
            <div class="container" id="izenda-root"></div>
            <script type="text/javascript" src="/IzendaFront/izenda-vendors.js?4676ff4fe0cdf3cd2bab"></script>
            <script type="text/javascript" src="/IzendaFront/izenda_app.js?4676ff4fe0cdf3cd2bab"></script>
         </body>

#. Update the web.config file in the UI folder

   -  Target code:

      .. code-block:: html

         <action type="Rewrite" url="/<your Url here>/" />

   -  Example change:

      .. code-block:: html

         <action type="Rewrite" url="/IzendaFront/" />

Within the API Folder of your Deployment
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

-  Update the Web.config file

   -  Target code:

      .. code-block:: xml

          <httpHandlers>
             <add verb="*" type="Nancy.Hosting.Aspnet.NancyHttpRequestHandler" path="/<Your API URL here>/api/*" />
          </httpHandlers>

          <handlers>
             <add name="Nancy" verb="*" type="Nancy.Hosting.Aspnet.NancyHttpRequestHandler" path="/<Your API URL here>/api/*"/>
          </handlers>

   -  Example change:

      .. code-block:: xml

         <httpHandlers>
            <add verb="*" type="Nancy.Hosting.Aspnet.NancyHttpRequestHandler" path="/IzendaBack/api/*" />
         </httpHandlers>

         <handlers>
            <add name="Nancy" verb="*" type="Nancy.Hosting.Aspnet.NancyHttpRequestHandler" path="/IzendaBack/api/*"/>
         </handlers>

Troubleshooting & Verifying the Installation
-------------------------------------------------------

*  To ensure that your API site is running correctly, navigate to http://YOUR_API_URL/api/404 (e.g. http://localhost:8080/api/404)

   If your API is installed correctly, you should see the graphic below:

   .. figure:: /_static/images/SuccessfulAPI.png
   
      Successful Connection to API displays a stylized 404 error

*  Navigate to the API folder, you should see a 'logs' folder with with at least one log file. If you do not see the folder and/or files, verify that the application pool and/or web site user have write permissions to the API folder.
*  In build 1.23.0, an exception may occur after creating an APP and API websites. If you receive  an error akin to the following:

   .. code-block:: text
   
      Exception type: ConfigurationErrorsException
      Exception message: Could not load file or assembly 'Oracle.ManagedDataAccessDTC.DLL' or one of its dependencies. The specified module could not be found.

   Then remove Oracle.ManagedDataAccessDTC.DLL from your API/bin/ folder and place it in a separate location. If the problem persists, place the file back in the API/bin/ folder.

Editing the Configuration Files
--------------------------------

Additional features can be set for a customized deployment experience. For live sites, several of the features below are recommended.

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

      -  ``"WebApiUrl": "http://127.0.0.1:8888/api/",``

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


Next: :doc:`Install Izenda System Database and Apply License </ui/doc_system_db_and_license>`
------------------------------------------------------------------------------------------------------------

 

.. seealso::

   -  `Installing IIS 8.5 on Windows Server 2012
      R2 <http://www.iis.net/learn/install/installing-iis-85/installing-iis-85-on-windows-server-2012-r2>`__.
   -  `Install IIS and ASP.NET
      Modules <http://www.iis.net/learn/application-frameworks/scenario-build-an-aspnet-website-on-iis/configuring-step-1-install-iis-and-asp-net-modules>`__
   -  `Understanding built in user and group accounts in
      IIS <https://www.iis.net/learn/get-started/planning-for-security/understanding-built-in-user-and-group-accounts-in-iis>`__
