.. _WL:


White Labeling URLs
---------------------------------------------

=============================
Standalone: White labeling URLs
=============================
In our standalone application, the Izenda configuration settings can be found in the Izenda_config.js. Here, you can modify the route names associated with various components.

By default, the standalone application labels URls with an Izenda namespace.

When you first navigate to the Izenda login page, for instance, your URL will look
similar to the following:

``http://localhost:80/account/login``

To modify this namespace, update the files below:

   In this example, we change the route 'account' to 'verification'.
   
 
 *  **Scripts\\izenda_config.js:**

   .. code-block:: javascript

      Account:"verification",
	  
After making this modification, if you navigate to your front end application, you should be redirected to the following:

``http://localhost:80/verification/login``

=============================
Integrated: White Labeling URLs
=============================
White labeling URLs in an integrated scenario is a two-step process-- white labeling the Izenda routes and host application routes. In our sample kits, the initial Izenda configuration is handled in a file named "Izenda Integrate" and the host application routes are handled by their respective frameworks (e.g. .Net MVC5, .Net Webforms, Angular 2).

The following will walk through an example of white labeling a URL in our sample MVC Kit but the logic can be applied to all sample kits and extended to all integrated scenarios.  The full source of the original code can be found `here. <https://github.com/Izenda7Series/Mvc5StarterKit/blob/master/Mvc5StarterKit/Scripts/izenda.integrate.js#L8>`_

By default, the MVC Kit labels URLs with an Izenda namespace for you to modify.

When you navigate to your Report List for instance, your URL will look
similar to the following:

   ``http://localhost:14809/Home/Reports#?source=%2Fizenda%2Freport``

To modify this namespace, update the files below:

   In this example, we change 'izenda' to 'reporting'.

*  **Scripts\\izenda.integrate.js:**

   .. code-block:: javascript

      "BaseUrl": "/reporting",

   .. figure:: /_static/images/Integrate.png

      izenda.integrate.js

*  **HomeController.cs:**

   *Update the appropriate routes in the controller*

   .. code-block:: csharp

      #region Izenda Actions
      
      [Route("reporting/settings")]
      [Route("reporting/new")]
      [Route("reporting/dashboard")]
      [Route("reporting/report")]
      [Route("reporting/reportviewer")]
      [Route("reporting/reportviewerpopup")]
      [Route("reporting")]
      public ActionResult Izenda()
      {
          return View();
      }

   .. figure:: /_static/images/Home.png

      HomeController.cs
	  
=====================
Available Izenda Routes
=====================
Routes are set up in a "Config JSON" passed to Izenda's front end function 'config().' For more information on this method, please refer to  our :ref:`Front-end-Integration`


 In our sample kits, the initial Izenda configuration is handled in a file named "Izenda Integrate."  The following are examples of Izenda routes with sample modifications and expected results in our Angular 2 Sample Applicaiton but the logic can be applied to all sample kits and extended to all integrated scenarios.

 The full source of the original code can be found `here. <https://github.com/Izenda7Series/Angular2Starterkit/blob/master/Angular2StarterKitWeb/app/_helpers/izendaintegrate.ts#L22>`_

.. container:: toggle

   .. container:: header

      **Original  Route JSON Object**:

   .. code-block:: json
   
	"Routes": {
		 "Settings": "settings",
		 "Dashboard": "dashboard",
		 "Report": "report",
		 "ReportViewer": "reportviewer",
		 "Viewer": "viewer"
	   }


.. container:: toggle

   .. container:: header

      **Modified Route JSON Object**:

   .. code-block:: json

	"Routes": {
		"Settings": "nike",
		"Dashboard": "hades",
		"Report": "persephone",
		"ReportViewer": "hercules",
		"ReportDesigner": "leto",
		"Viewer": "sibyl",
		"MyProfile": "hermes"
	}


------------
Settings
------------

* **Location in Angular 2 Kit:** Izenda page, settings tab.
* **Original JSON Value:  "Settings":** "settings"
* **Modified Value in JSON:** "Settings": "nike"
* **URL Before Modification:** ``http://localhost:3000/izenda#?source=settings``
* **URL After Modification:** ``http://localhost:3000/izenda#?source=nike``
* **Screenshot Examples:**
   .. figure:: /_static/images/White_Label/image001.png

------------
Dashboard
------------
* **Location in Angular 2 Kit:** Izenda page, dashboard tab; Dashboards Menu Item, all available pages found in dropdown (In screenshot 2, “Dashboard List” is shown)
* **Original Value in JSON:** "Dashboard": “dashboard”
* **Modified Value in JSON:** "Dashboard": "hades"
* **URL Before Modification:** ``http://localhost:3000/izenda#?source=dashboard`` ; ``http://localhost:3000/izenda/dashboard#?source=dashboard``
* **URL After Modification:** ``http://localhost:3000/izenda#?source=hades`` ; ``http://localhost:3000/izenda/dashboard#?source=hades``
* **Screenshot Examples:**
    .. figure:: /_static/images/White_Label/image003.png
   
     .. figure:: /_static/images/White_Label/image005.png


------------
Report
------------

* **Location in Angular 2 Kit:** Izenda Page, Report List Tab. Report Menu Item, “Report List” page in dropdown.
* **Original Value in JSON:** "Report": "report"
* **Modified Value in JSON:** "Report": "persephone"
* **URL Before Modification:** ``http://localhost:3000/izenda/report#?source=report``
* **URL After Modification:** ``http://localhost:3000/izenda/report#?source=persephone``
* **Screenshot Examples:**
    .. figure:: /_static/images/White_Label/image007.png
	
------------
ReportViewer
------------
* **Location in Angular 2 Kit:** Reports Menu Item, “Report Viewer” page in dropdown.
* **Original Value in JSON:** N/A
* **Modified Value in JSON:** "ReportViewer": "hercules"
* **URL Before Modification:** ``http://localhost:3000/izenda/reportviewer#?source=reportviewer/[your report id]``
* **URL After Modification:** ``http://localhost:3000/izenda/reportviewer#?source=hercules/[your report id]``
* **Screenshot Examples:**
    .. figure:: /_static/images/White_Label/image009.png


------------
ReportDesigner
------------
* **Location in Angular 2 Kit:** Izenda Page, “New Report” tab; Reports Menu Item, “New Report” page in dropdown.
* **Original Value in JSON: ** "ReportViewer": "reportviewer"
* **Modified Value in JSON:** "ReportDesigner": "leto"
* **URL Before Modification:** ``http://localhost:3000/izenda#?source= reportviewer`` ; ``http://localhost:3000/izenda/reportdesigner#?source= reportviewer``
* **URL After Modification:**  ``http://localhost:3000/izenda#?source=leto . http://localhost:3000/izenda/reportdesigner#?source=leto
* **Screenshot Examples:**
    .. figure:: /_static/images/White_Label/image011.png
   
    .. figure:: /_static/images/White_Label/image013.png
------------
Viewer
------------
* **Location in Angular 2 Kit:** Used for printing. In the report viewer, press the “print” button
* **Original Value in JSON:** "Viewer": "viewer"
* **Modified Value in JSON:** "Viewer": "sibyl"
* **URL Before Modification:** ``http://localhost:3000/izenda#?source=viewer/reportbody ...``
* **URL After Modification:**  ``http://localhost:3000/izenda#?source=sibyl/reportbody ...``
* **Screenshot Examples:**
    .. figure:: /_static/images/White_Label/image015.png

------------
MyProfile
------------
* **Location in Angular 2 Kit:** Izenda Page, My Profile dropdown
* **Original Value in JSON:** n/a
* **Modified Value in JSON:** "MyProfile": "hermes"
* **URL Before Modification:** 
* **URL After Modification:** ``http://localhost:3000/izenda#?source=hermes`` 
* **Screenshot Examples:**
    .. figure:: /_static/images/White_Label/image017.png

------------
Account
------------
*Route visibly used in standalone scenarios of Izenda*

See `Standalone: White labeling URLs`_

---------
New
--------
*Route obsolete in v 2.4.2 and greater*
	  
