===================================
Mvc5Starterkit
===================================

*Understanding The MVC Starter Kit* outlines the contents of the kit and
where particular functionality is showcased.

.. note::

   The MVC Kit is designed for demonstration purposes and should not be
   used as an "as-is" fully-integrated solution. You can use the kit for
   reference or a baseline but ensure that security and customization meet
   the standards of your company.

For MVC set up steps, please refer to the :doc:`/install/doc_mvc_setup_guide`.

*Under Construction.*

Location and Descriptions of Features
-------------------------------------

    *This section outlines the key features of the MVC starter kit and
    which files to review for each feature.*

Unique Styling For Tenants
~~~~~~~~~~~~~~~~~~~~~~~~~~

-  Content Folder for tenants

   * Equals TenantID
   * Top of Layout.cshtml

Izenda User Creation
~~~~~~~~~~~~~~~~~~~~

-  AccountController.cs

   * Register, line 162

Izenda User Authentication
~~~~~~~~~~~~~~~~~~~~~~~~~~

-  **Login.cshtml:** User input form for login information
-  **UserController.cs:** The UserController only handles users logging
   into the MVC application. Once they log in, a token generated with
   their information that will then be used in IzendaTokenAuthorization

   * GenerateToken() and GetCurrentTenant()

-  **IzendaTokenAuthorization.cs**

   * GetToken and GetUserInfo

-  **AccountController.cs**

   * Login, line 73

Rendering Izenda UI
~~~~~~~~~~~~~~~~~~~

-  Izenda.integrate.js
-  Views -> Home and Views -> Report

Understanding the Front End Contents
------------------------------------

    *This section outlines the front end components defined in the MVC
    starter kit. It does not outline Izenda's front end but rather the
    front end components a developer might define in an integrated
    scenario.*

Understanding the Back End Contents
-----------------------------------

    *This section outlines the back end components defined in the MVC
    starter kit. It does not outline Izenda's API but rather the back
    end components a developer might define in an integrated scenario.*

App\_Start
~~~~~~~~~~

   This folder is contained at the root directory and is among the main
   driving components of an MVC Solution. This folder's classes are
   explained below

   *  **Startup.Auth.cs:** This class supports OWIN authentication. For a
      high level understanding, OWIN defines a standard interface between .NET
      web servers and web applications. The Startup.Auth.cs gives you the
      flexibility to integrate your application to allow users for quick
      authentication modes such as using google and facebook accounts as their
      preferred logins.

   *  **BundleConfig.cs**: This class allows developers to bundle
      javascript and css files. With so many javascript and css classes that
      an MVC solution might reference, each call to a resource for example has
      the potential to reference multiple of these files which as a result can
      significantly impact the load time of a page. Below are some of Izenda's
      bundled javascipt files to allow your page for faster rendering.

      .. code-block:: javascript

          bundles.Add(new ScriptBundle("~/bundles/izenda").Include(
                                  "~/Scripts/izenda/izenda_common.js",
                                  "~/Scripts/izenda/izenda_locales.js",
                                 "~/Scripts/izenda/izenda_vendors.js",
                                 "~/Scripts/izenda/izenda_ui.js",
                                 "~/Scripts/izenda.integrate.js",
                                 "~/Scripts/izenda.utils.js"));

   *  **RouteConfig.cs:** This class contains all the routing
      configuration for your urls in an MVC application. A Route simply
      defines a url pattern that is mapped to handler. Notice, that the url
      doesn't necessarily have to point to a file. A developer can define a
      more user friendly url pattern. This in return will be mapped to a
      handler to reference the MVC controllers.

Izenda's Web.config overview
~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Izenda utilizes **Nancy**, a light-weight framework for building HTTP
based services on .NET and Mono. Nancy supports all the common HTTP
methods such as the DELETE, GET, HEAD, OPTIONS, POST, PUT and PATCH
requests.

Below is the default configuration for both httpHandlers and Handlers
settings.

.. code-block:: xml

    <httpHandlers>
          <add verb="*" type="Nancy.Hosting.Aspnet.NancyHttpRequestHandler" path="api/*" />
    </httpHandlers>

    <handlers>
          <add name="Nancy" verb="*" type="Nancy.Hosting.Aspnet.NancyHttpRequestHandler" path="api/*" />
    </handlers>

.. note::

   * httpHandlers ->     this setting is used for sites running on  IIS 5 – 6, or IIS 7.x in Classic mode (IIS 6 compatibility mode).
   * handlers     ->     this setting is used for sites running on sites running on IIS 7.x (Integrated mode).

Understanding the Data Model
----------------------------

    *This section outlines the databases defined in the MVC starter
    kit.*

Izenda Configuration Database
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

+-----------------------------+--------------------------------------------------------------------------------------------------------------------------------------+
| Column Name                 | Column Details                                                                                                                       |
+=============================+======================================================================================================================================+
| LicenseWebAPIUrl            | The value for this column allows the Mvc5Starterkit application to reference Izenda's main licensing page.                           |
+-----------------------------+--------------------------------------------------------------------------------------------------------------------------------------+
| ApiSecretToken              | The value for this column holds the configured and assigned API Token for the Mvc5Starterkit application.                            |
+-----------------------------+--------------------------------------------------------------------------------------------------------------------------------------+
| AuthenticationBaseAddress   | The value for this column points to the local/virtual machine where the Mvc5Starterkit application will run.                         |
+-----------------------------+--------------------------------------------------------------------------------------------------------------------------------------+
| AuthenticationUrl           | The value for this column references the url address that will validate the assigned Mvc5Starterkit application's API Secret Token   |
+-----------------------------+--------------------------------------------------------------------------------------------------------------------------------------+

Table: [dbo].[IzendaSystemSetting]

A Granular Overview Of The Mvc5Starterkit Database Tables
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    ''The Izenda User Store is located within the '''[insert database
    location here]. **[Describe what it does here.]** ''

Table: [dbo].[AspNetUsers]

+---------------+-------------------------------------------------------+
| Column Name   | Column Details                                        |
+===============+=======================================================+
| Name          | The value for this column points to a Tenant's name   |
+---------------+-------------------------------------------------------+

Table: [dbo].[Tenants]

MVC5 User Database
~~~~~~~~~~~~~~~~~~

    ''The MVC5 User Database is located within the *'[insert database
    location here]. It simulates a your company's database information
    and is used to accurately route to a user in the Izenda
    Configuration Database.*

Retail Reporting Database
~~~~~~~~~~~~~~~~~~~~~~~~~

    ''The Retail Reporting Database is located within the '''[insert
    database location here]. **[Describe what it does here.]** ''

Updates
-------

02/08/2017
~~~~~~~~~~

Updates to the Mvc5StarterKit required for exporting:
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

1. Ensure you have set the front end url in the IzendaSystemSettings
table for WebUrl If you are using the standard MvcStarterKit it will be
set in dbo.IzendaSystemSetting table in Izenda.mdf file. The standard
value for the kit is: http://localhost:14809/

2. Add a new route to Mvc5StarterKit/App\_Start/RouteConfig.cs
routes.MapRoute(

| ``               name: "ReportPart",``
| ``               url: "viewer/reportpart/{id}",``
| ``               defaults: new { controller = "Home", action = "ReportPart" }``
| ``           );``

3. Add the following method to
Mvc5StarterKit/Controllers/HomeController.cs

::

     public ActionResult ReportPart(Guid id, string token)
            {
                ViewBag.Id = id;
                ViewBag.Token = token;
                return View();
            }

4. Add the following methods to
Mvc5StarterKit/Scripts/izenda.integrate.js

::

    // Render report part
    var izendaInitReportPartViewer = function (reportPartId) {
        function successFunc(data, status) {
            var currentUserContext = {
                token: data.token
            };
            IzendaSynergy.setCurrentUserContext(currentUserContext);
            IzendaSynergy.renderReportPart(document.getElementById('izenda-root'), {
                id: reportPartId
            });
        }
        this.DoRender(successFunc);
    };
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

5. Create a new View named Mvc5StarterKit/Views/Home/ReportPart.cshtml:

::

    @{
       Layout = "~/Views/Shared/Izenda_Layout.cshtml";
       ViewBag.Title = "Report Viewer";
    }

    @section scripts
    {
       <script type="text/javascript">
           $(document).ready(function () {
               izendaInitReportPartExportViewer('@ViewBag.Id', '@ViewBag.Token');
               
           });
       </script>
    }
    <style>
       #izenda-root>.izenda {
           background-color: transparent !important;
       }
    </style>

    <div class="izenda-container" id="izenda-root" style="margin-top:0px;"></div>

6. Move the line below in
Mvc5StarterKit/Views/Shared/Izenda\_Layout.cshtml Move line below
(originally at line 58)

::

    @RenderSection("scripts", required: false)

Just before the closing body tag, e.g.

::

       @RenderSection("scripts", required: false)
    </body>
    </html>

7. Move the line below in Mvc5StarterKit/Views/Shared/\_Layout.cshtml

Move line below (originally at line 99)

::

    @RenderSection("scripts", required: false)

Just before the closing body tag, e.g.

::

       @RenderSection("scripts", required: false)
    </body>
    </html>

8. Alter the file Mvc5StarterKit/Web.config (Optional) At line 44,
change the extension of the Izenda-log file to .log

::

    <file value="logs\izenda-log.txt" />

Change to

::

    <file value="logs\izenda-log.log" />

9. Edit the Post Build Events replace what is currently there with
below. This will allow maps to be used as report parts in the
Mvc5StarterKit:

::

    XCOPY /S /I /Y  "$(ProjectDir)IzendaResources\Content" "$(ProjectDir)\bin\Content\"
    XCOPY /S /I /Y  "$(ProjectDir)IzendaResources\EmailTemplates" "$(ProjectDir)\bin\EmailTemplates\"
    XCOPY /S /I /Y  "$(ProjectDir)IzendaResources\Export" "$(ProjectDir)\bin\Export\"
    XCOPY /S /I /Y  "$(ProjectDir)IzendaReferences\Resources" "$(ProjectDir)\bin\Resources\"
    XCOPY /S /I /Y  "$(ProjectDir)IzendaResources\Content\maps" "$(ProjectDir)\Content\maps\"
