

========================================
Import Report or Dashboard Definition
========================================
.. note::

   Import Report or Dashboard Definition is available from release v2.8.0.

The Import Page allow to:

* Import reports and dashboards from definition files
* Configure report name and location for new report
* Define Database Mapping rules and validate data model consistency
* Define whether import source report settings: source report access right, the filter values
* Validate data model consistency


Browse file page
----------------------

#. In browser, log in to Izenda as System Administrator.
#. Select Settings, then Data Setup, then Import in the left menu.
#. In browser files page, drag and drops files or click on Browse files button and select files to upload.

.. figure:: /_static/images/ui/import_definition/DataSetup_Import_BrowserFile.PNG
   :align: center

   Browse file page

.. note::

   Izenda import report/dashboard definition only allows the following formats: |br|

      \- .birt: the report definition file format |br|
      \- .bidb: the dashboard definition file format


Import Page
--------------------------------

After browsing files, application will switch to **Import Page**.

.. figure:: /_static/images/ui/import_definition/DataSetup_Import_ImportPage.PNG
   :align: center

   Import page

#. Tick the **Import the source access** check-box to keep access right in destination. Please notice that any sharing with User and not existing Role Name will not be imported.

#. Tick the **Import the filter values** check-box to import filter values. The existing filter values will not be altered in case re-import.

#. Type the new name for each report and dashboard. If not the current name will be kept as default.

#. Input the category for each report and dashboard.

#. Choose the destination database name and schema in Database Mapping section. To do mapping easily, click on |information| icon to view :ref:`Report/Dashboard Information pop-up <Import_Definition_Information>`.

   .. |information| image:: /_static/images/ui/import_definition/DataSetup_Import_InfoIcon.PNG

#. Click **Import** button to execute the importing progress.
   - If there is any report or dashboard duplication, the :ref:`Overwrite Confirmation pop-up <Import_Definition_Overwrite>` will display. |br|
   - Else if all validations pass, the :ref:`Import Progress pop-up <Import_Definition_Progress>` will display.

.. note::

   * A dashboard that belongs Global Category cannot contain any local report.
   * All reports inside dashboard will be override when re-import dashboard.

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

The Overwrite Confirmation pop-up displays all existing reports and dashboards with their Cataegory. System admin can specify reports or dashboards to overwrite by ticking on the checkboxes then click **OK** button.

.. figure:: /_static/images/ui/import_definition/DataSetup_Import_InProgressPopup.PNG
   :align: center

   Import Reports/Dashboards - Overwrite Confirmation popup

.. note::

   * The reports inside dasboard will not be listed in the pop-up because they will be always overwritten if existing in destination when overwriting the dashboard they belong to.

   * A report/template/dashboard is considered as duplicate when its sourceID exists in destination not its name.


.. _Import_Definition_Progress:

Import Progress pop-up
-----------------------

* The Import progress pop-up shows the status of all importing transactions.
* Click on **Cancel the Import** button will abort the progress except the successfully imported reports and dashboards.

.. figure:: /_static/images/ui/import_definition/DataSetup_Import_OverwriteConfirmation.PNG
   :align: center

   Import Progress pop-up



