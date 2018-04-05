================================================
Auto Collapse Filter Panel
================================================

How can I set the filter panels in Report and Dashbaord to collapse by default?
-------------------------------------------------------------------------------

JavaScript Setting to Collapse Filter Panel 
#############################################

- To Implement this setting please see below:
		For Standalone use the izenda_config.js file 
		
		.. code-block:: javascript
		
		    // to collapse by default, the value should be 1, 0 is expanded by default
			UIPreferences: { 
				ReportFilterSectionExpanded: !1
			}	 
			
		For integrated scenarios like the MVC kit, use the Scripts/izenda.integrate.js (or izenda.integrate.ts for the Angular kit)

		.. code-block:: javascript
		   :emphasize-lines: 15-18
		   
		    var configJson = {
				"WebApiUrl": hostApi,
				"BaseUrl": "/izenda",
				"RootPath": "/Scripts/izenda",
				"CssFile": "izenda-ui.css",
				"Routes": {
					"Settings": "settings",
					"New": "new",
					"Dashboard": "dashboard",
					"Report": "report",
					"ReportViewer": "reportviewer",
					"ReportViewerPopup": "reportviewerpopup",
					"Viewer": "viewer"
				},
				// to collapse by default, the value should be 1
				"UIPreferences": {
					"ReportFilterSectionExpanded": !1
				},
				"OnReceiveUnauthorizedResponse": redirectToLoginPage,
				"Timeout": 3600
			};
