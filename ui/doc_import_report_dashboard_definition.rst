

========================================
Import Report or Dashboard Definition
========================================
.. note::

   Import Report or Dashboard Definition is available from release v2.8.0.

The Import Page allows system admin to:

* Import reports and dashboards from definition files to system or specific tenant
* Import reports/dashboards to either Global Category or Local Category
* Configure reports/dashboards names and locations for new reports/dashboards
* Define Database Mapping rules and validate data model consistency
* Define whether import source report settings: source report access right, the filter values


Browse file page
----------------------

#. In browser, log in to Izenda as System Administrator.
#. Select Settings, then Data Setup, then Import in the left menu.
#. Select the Setting Level: either System or a specific tenant to define where the import reports/dashboards belong to.
#. In browse files page, drag and drops files or click on Browse Files button and select files to upload.

.. figure:: /_static/images/ui/import_definition/DataSetup_Import_BrowserFile.PNG
   :align: center

   Browse file page

.. note::

   * Izenda import report/dashboard definition only allows the following formats: |br|

      \- .birt: the report definition file format |br|
      \- .bidb: the dashboard definition file format

   * The version of exported files must be not newer than the current Import system.

   * The system will store uploaded files in folder **IzendaImport** in the app's directory by default. System admin can change file storage by configuring the **ImportFileSystemPath** field in :doc:`IzendaSystemSetting table </ref/spec_izendasystemsetting_table>`.

Import Page
--------------------------------

After browsing files, application will switch to **Import Page**.

.. figure:: /_static/images/ui/import_definition/DataSetup_Import_ImportPage.PNG
   :align: center

   Import page

#. Tick the **Import the source access** check-box to keep access right in destination. Please notice that any sharing with User and not existing Role Name will not be imported. The existing sharings in destination will not be altered in case re-import without slecting this option.

#. Tick the **Import the filter values** check-box to import filter values. The existing filter values in destination will not be altered in case re-import without slecting this option.

#. Type the new name for each report and dashboard.

#. Input the category and subcategory for each report and dashboard.

#. Choose the destination database name and schema in Database Mapping section. To do mapping easily, click on |informationIcon| icon to view :ref:`Report/Dashboard Information pop-up <Import_Definition_Information>`.

   .. |informationIcon| image:: /_static/images/ui/import_definition/DataSetup_Import_InfoIcon.PNG

#. Click **Import** button to execute the importing progress.
   - If there is any report or dashboard duplication, the :ref:`Overwrite Confirmation pop-up <Import_Definition_Overwrite>` will display. |br|
   - Else if all validations pass, the :ref:`Import Progress pop-up <Import_Definition_Progress>` will display.

.. note::

   * A dashboard that belongs to Global Category cannot contain any local report.

   * All reports inside dashboard will be always overwritten when overwriting dashboard.

   * Click on |deleteIcon| icon at the end of row to delete a definition file that have just uploaded by mistake.

     .. |deleteIcon| image:: /_static/images/ui/import_definition/DataSetup_Import_DeleteIcon.PNG

   * The subreport link is only maintained in the following cases: |br|

      \- The report and subreport(s) are imported in the same batch |br|
      \- Re-import one of the reports and both the report and sub-report(s) already exist in destination


.. _Import_Definition_Information:

Report/Dashboard Information pop-up
------------------------------------

The Information pop-up will list out the following information:

* In Data Information section:
   - Setting Level: The setting level that the source belongs to. (It can be System or Tenant level)
   - Databases: All databases (alias name) are being used within the report/dashboard
   - Data Sources: All table, views, stored procedures are being used within the report/dashboard
   - Custom Views: All custom views are being used within the report/dashboard
   - Data Model Calculated Fields: All data model calculated fields (alias name) are being used in the report/dashboard

* In Access Rights section: All sharing with existing Roles and Everyone

.. figure:: /_static/images/ui/import_definition/DataSetup_Import_ReportInfo.PNG
   :width: 400px
   :align: left

   Report Information pop-up 

.. figure:: /_static/images/ui/import_definition/DataSetup_Import_DashboardInfo.PNG
   :width: 400px
   :align: right

   Dashboard Information pop-up |br|

|br|


.. _Import_Definition_Overwrite:

Overwrite Confirmation pop-up
------------------------------

The Overwrite Confirmation pop-up displays all existing reports and dashboards with their Category/Subcategory. System admin can specify reports or dashboards to overwrite by ticking on the checkboxes then click **OK** button.

.. figure:: /_static/images/ui/import_definition/DataSetup_Import_OverwriteConfirmation.PNG
   :align: center

   Import Reports/Dashboards - Overwrite Confirmation popup

.. note::

   * The reports inside dasboard will not be listed in the pop-up because they will be always overwritten if existing in destination when overwriting the dashboard they belong to.

   * A report/template/dashboard is considered as duplicate when its sourceID exists in destination not its name.


.. _Import_Definition_Progress:

Import Progress pop-up
-----------------------

* The Import progress pop-up shows the status of all importing transactions.
* Click on **Cancel the Import** button will abort the progress except the completed imported reports and dashboards.

.. figure:: /_static/images/ui/import_definition/DataSetup_Import_InProgressPopup.PNG
   :align: center

   Import Progress pop-up



