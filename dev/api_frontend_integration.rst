==========================
Front-end Integration APIs
==========================

This list documents the JavaScript APIs used for Front-end Integration.

List of APIs
------------

.. list-table::
   :widths: 63 37
   :header-rows: 1

   * - Class and Method
     - Purpose
   * - **IzendaSynergy**
     -
   * - .. container:: lpad2
   
          `config(configJson)`_
     - Configure Izenda
   * - .. container:: lpad2
   
          `render(element)`_
     - Render all Izenda web page inside hosting web
   * - .. container:: lpad2
   
          `renderSettingPage(element)`_
     - Render Izenda Setting page only inside hosting web
   * - .. container:: lpad2
   
          `renderReportPage(element)`_
     - Render Izenda Report page only inside hosting web
   * - .. container:: lpad2
   
          `renderReportDesignerPage(element)`_
     - Render Izenda Report Designer Page (New/Edit Report) inside hosting web
   * - .. container:: lpad2
   
          `renderReportViewerPage(element,report_id)`_
     - Render Izenda Report Viewer page only inside hosting web
   * - .. container:: lpad2
   
          `renderReportPart(element,{"id":report_part_id})`_
     - Render specific :term:`Report Part` inside hosting web
   * - .. container:: lpad2
   
          `renderDashboardPage(element)`_
     - Render Izenda Dashboard page only inside hosing web
   * - .. container:: lpad2
   
          `renderNewDashboardPage(element)`_
     - Render Izenda New Dashboard page
   * - .. container:: lpad2
   
          `setCurrentUserContext({"token":access_token}`_
     - Authentication and authorization between hosting web and Izenda




config(configJson)
----------------------------------------------------------------------------------------------

Configure Izenda


**Parameters**

    configJson

    .. code-block:: javascript

       {
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
          "Timeout": 3600
       }

**Samples**

    .. code-block:: javascript

       var hostApi = location.protocol + '//' + location.host + "/api/";
       
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
          "Timeout": 3600
       };
       
       IzendaSynergy.config(configJson);



render(element)
----------------------------------------------------------------------------------------------

Render all Izenda web page inside hosting web


**Parameters**

    element

**Samples**

    .. code-block:: javascript

       IzendaSynergy.render(document.getElementById('izenda-root'));

    .. figure:: /_static/images/All_Izenda_Inside.png

       Izenda Inside

renderSettingPage(element)
----------------------------------------------------------------------------------------------

Render Izenda Setting page only inside hosting web


**Parameters**

    element

**Samples**

    .. code-block:: javascript

       IzendaSynergy.renderSettingPage(document.getElementById('izenda-root'));

    .. figure:: /_static/images/Izenda_Settings.png

       Izenda Settings

renderReportPage(element)
----------------------------------------------------------------------------------------------

Render Izenda Report page only inside hosting web


**Parameters**

    element

**Samples**

    .. code-block:: javascript

       IzendaSynergy.renderReportPage(document.getElementById('izenda-root'));

    .. figure:: /_static/images/Izenda_Report_only.png

       Izenda Report only

renderReportDesignerPage(element)
----------------------------------------------------------------------------------------------

Render Izenda Report Designer Page (New/Edit Report) inside hosting web


**Parameters**

    element

**Samples**

    .. code-block:: javascript

       IzendaSynergy.renderReportDesignerPage(document.getElementById('izenda-root'));v

    .. figure:: /_static/images/Izenda_Report_Designer_only.png

       Izenda Report Designer only

renderReportViewerPage(element,report_id)
----------------------------------------------------------------------------------------------

Render Izenda Report Viewer page only inside hosting web


**Parameters**

    element |br|
    report_id

**Samples**

    .. code-block:: javascript

       IzendaSynergy.renderReportViewerPage(document.getElementById('izenda-root'), "C2946606-7159-4FB3-82B7-E7D4ED3162A0");

    .. figure:: /_static/images/Izenda_Report_Viewer.png

       Izenda Report Viewer Only

renderReportPart(element,{"id":report_part_id})
----------------------------------------------------------------------------------------------

Render specific :term:`Report Part` inside hosting web


**Parameters**

        element |br|
        report_part_id

**Samples**

    .. code-block:: javascript

       IzendaSynergy.renderReportPart(document.getElementById('izenda-part1'), {
          "id": "804B35C8-44A4-4535-A484-F27E8ABA410D"
       });

    .. figure:: /_static/images/Render_Specific_report_part.png

       Izenda Specific Report Part

renderDashboardPage(element)
----------------------------------------------------------------------------------------------

Render Izenda Dashboard page only inside hosing web


**Parameters**

    element

**Samples**

    .. code-block:: javascript

       IzendaSynergy.renderDashboardPage(document.getElementById('izenda-root'));

    .. figure:: /_static/images/Izenda_Dashboard.png

       Izenda Dashboard Only

renderNewDashboardPage(element)
----------------------------------------------------------------------------------------------

Render Izenda New Dashboard page


**Parameters**

    element

**Samples**

    .. code-block:: javascript

       IzendaSynergy.renderNewDashboardPage(document.getElementById('izenda-root'));

    .. figure:: /_static/images/Izenda_New_Dashboard.png

       Izenda Dashboard Designer Only

setCurrentUserContext({"token":access_token}
----------------------------------------------------------------------------------------------

Authentication and authorization between hosting web and Izenda


**Parameters**

    element |br|
    access_token

**Samples**

    .. code-block:: javascript

       var currentUserContext = {
          token: data.token
       };
       
       IzendaSynergy.setCurrentUserContext(currentUserContext);

**Tags**

Embed, Embedding, Fully Embedable. 
