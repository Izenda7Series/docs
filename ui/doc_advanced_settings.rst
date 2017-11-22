

=================
Advanced Settings
=================

The **Advanced Settings** page allows user to


* manage the list of data source categories
* update system settings in related groups

Steps to config Advanced Settings
--------------------------------------

#. In browser, log in to Izenda as a user with Advanced Settings
   permission.
#. Click Settings, then Data Setup then Advanced Settings in the left
   menu.
#. Select the Setting Level: either System or a specific tenant.
#. Click on a tab to view values.

#. Hover on information icon following the value name to see the brief guide of that value

   .. figure:: /_static/images/Advanced_Settings_Performance_Hover_Brief_Guide.png
      :align: center
      :width: 1001px

      Brief guide of a configuration option.

#. Update the values.
#. Click Save button at the top to save the whole settings.

Update Performance Settings
------------------------------------

In Advanced Settings page, click on Performance tab in Middle Panel to view the items. The Performance items are list as below:

   .. figure:: /_static/images/Advanced_Settings_Performance.png
      :align: center
      :width: 1653px

      Setting values provied in Performance tab

  .. list-table::
      :widths: 35 65
      :header-rows: 1

      *  -  Section
         -  Purpose
      *  -  Query Timeout
         -  To limit the duration of all queries in any page.
      *  -  Use No Lock
         -  To not use NOLOCK (dirty read) statement when querying data.
      *  -  Data Source Limit
         -  To limit the number of data sources in a single report.
      *  -  Field Limit
         -  To limit the number of field in a report part.
      *  -  Query Limit
         -  To limit the number of values return from the query in Report Designer, Report Viewer, Dashboard and Export.
      *  -  Pivot Column Limit
         -  Limit the number of columns in a pivot report part.
      *  -  Filter Limit
         -  Limit the number of items displayed in Filter Value dropdown

.. note::

   The Use No Lock setting instructs the database engine to return the current version of data immediately, instead of waiting for all pending transactions to complete. Check the possible consequences `here <https://www.izenda.com/blog/high-performance-sql-views-using-withnolock/>`__ before using this option.

Update Security Settings
--------------------------
In Advanced Settings page, click on Security tab in Middle Panel to view the items. The Security items are list as below:

   .. figure:: /_static/images/Advanced_Settings_Sercurity.png
      :align: center
      :width: 1657px

      Setting values provied in Security tab

Update settings in Tenant group
***********************************

   * Tick on **Show Tenant Field** checkbox will show the Tenant field in following areas:

      \- Report Designer > Data Source tab > Middle Panel or Relationship |br|
      \- Report Designer > Field tab > Middle Panel |br|
      \- Report Designer > Filter section > filter dropdown |br|
      \- Report Viewer > Filter section |br|
      \- Report Viewer > Quick Edit mode > Field Selection and Filter Selection |br|
      \- Field Selection popup

   * Input the name of Tenant Field in **Tenant Field** textbox then all the reports and dashboards will automatically restrict data retrieval to only that of the current tenant. The Tenant Field must be enclosed in brackets [fieldname] and multiple fields should be separated by a semi-colon.

   .. note::

      For security in multi-tenant systems, it is a best practice to have an automatic filter condition to always restrict data retrieval to only that of the current tenant. To enable this feature:

         #. Untick Show Tenant Field check-box.
         #. Enter the name of tenant id fields into the Tenant Field box. 
         #. Click Save button at the top.
         #. Then:

            -  These tenant id fields will be hidden from Report Designer.
            -  The reports will automatically have a filter condition to restrict
               data retrieval to only that of the current tenant.

   .. _Update_settings_in_Security_Additive_Fields_group:

Update settings in Additive Fields group
********************************************

   * Tick on **Set Additive Field Auto Visible** will automatically set the additive field when physical data model changes as Visible
   * Tick on **Set Additive Field Auto Filterable** will automatically set the additive field when physical data model changes as Filterable


Update Categories Settings
---------------------------

.. _Add_data_source_categories:

Add data source categories
***************************

   A category should be added before showing up for assignment to a data
   source.

   #. In browser, log in to Izenda as a user with Advanced Settings
      permission.
   #. Click Settings, then Data Setup then Advanced Settings in the left
      menu.
   #. Select the Setting Level: either System or a specific tenant.
   #. .. _Menu_Advanced_Settings_Category:

      .. figure:: /_static/images/Menu_Advanced_Settings_Category.jpg
         :align: right
         :width: 391px

         Category Menu

      Click Category in the Middle Panel. (:numref:`Menu_Advanced_Settings_Category`) |br|
   #. Click Add New + button and type the name into the new text box. (:numref:`Settings_Category_Add_New`)

      .. _Settings_Category_Add_New:

      .. figure:: /_static/images/Settings_Category_Add_New.jpg
         :width: 622px

         Add New button |br|
   #. Continue to click Add New + button to enter more categories.
   #. Click Save button at the top to save the whole list.

   .. note::

      User will not be able to save the list unless there is no duplication.

Delete data source categories
******************************

   #. In the category list, click the delete icon (x) on the right of each category to delete it. (:numref:`Settings_Category_Delete`)

      .. _Settings_Category_Delete:

      .. figure:: /_static/images/Settings_Category_Delete.jpg
         :width: 621px

         Delete icon |br|
   #. Click OK in the pop-up confirmation. (:numref:`Category_Deletion_Confirmation`)

      .. _Category_Deletion_Confirmation:

      .. figure:: /_static/images/Category_Deletion_Confirmation.jpg
         :width: 456px

         Delete confirmation |br|
   #. The category is deleted immediately.

         The Save and Cancel buttons at the top does not have any effect in this action.

   .. note::

      The category will be deleted even if it has been assigned to data sources. After that these data sources will have no category.

   .. note::

      To change the name of a category, the `Rename data source categories`_ feature should be used instead.

Rename data source categories
******************************

   Renaming a category will only change the name and keep the assignments
   to data sources intact.

   #. In the category list, click the text box of any category and change the name. (:numref:`Settings_Category_Rename`)

      .. _Settings_Category_Rename:

      .. figure:: /_static/images/Settings_Category_Rename.jpg
         :align: right
         :width: 617px

         Rename categories |br|
   #. Continue to change more category names
   #. Click Save button at the top to save the whole list.

Update Others Settings
-----------------------

In Advanced Settings page, click on Others tab in Middle Panel to view the items. The Others items are list as below:

   .. figure:: /_static/images/Advanced_Settings_Others.png
      :align: center
      :width: 1649px

      Setting values provied in Others group

  .. list-table::
      :widths: 30 70
      :header-rows: 1

      *  -  Section
         -  Purpose
      *  -  Sort Colum Name 
         -  To alphabetically sort the lists of column or field names
      *  -  Trim Time In Joins 
         -  To trim the time portion form the Date Time field in a join statement in Report Designer - Relationship page
      *  -  Timezone for Data Offset 
         -  To set default value for the Timezone Data Offset in Settings > User Setup page. And this setting will effect to displayed data value of Datetime/Time fields in the report part. |br|

               **For example:**
                  
                  In database the data value is 11:00. If user sets “+5” in the textbox of this section then the data value will be shown as 16:00 in the report part.
      *  -  Timezone for Timestamp Offset
         -  To set default value for the Timezone Data Offset in Settings > User Setup page. And this setting will effect to all Datetime/Time field in system. |br|

               **For example:** |br|
                  
                  The created date of report is 11:00. If user sets “+5” in the textbox of this section then the created date will be shown as 16:00 in the system.
      *  -  Convert Null to Empty String
         -  To convert all null values to blank (empty) in reports or dashboards, select the checkbox of this section in the value column.
      *  -  Show Schema Name
         -  To show schema name together with the the data source name in any place
      *  -  Show Introduction Text
         -  To show the Introduction Text in the following section:

               * Report Designer > Data Source tab > Content Panel > under Report Name
               * Report List > Content Panel > under each report name
      *  -  Send to Disk Path
         -  To define the path to save files for all Scheduled/Subcribed instances with **Send to Disk** delivery method, input path in the textbox of that section.

            .. note::

               * When the report is saved into this location, system will save report name together data time so that saving the new version of this report will not overwrite this report. The format when saved: <report name>_<mmddyyyy>_<hhmmss>

               * For example:

                  If report “ABC” is saved to disk path at 10/22/2016, 23:59:00 then the report will be saved with name = ABC_10222016_235900
      *  -  Determine common filter for the same field based on
         -  To determine how the filters considered whether different or the same in the dasboard so they will be common filter or not.
      *  -  Allow Multiple Sorts on Grid Header
         -  By selecting this section, user can sort on multiple columns when clicking on Grid header in Vertical/Horizontal report. Otherwise, user can only sort by one column at a time.
      *  -  Show Preview section in Configuration Mode
         -  By selecting this checkbox, both Configuration and Preview sections display in the report part’s backside and setting popups. Otherwise, system only shows Configuration section.

Cancel the changes
-------------------

.. _Settings_Cancel_Confirmation:

.. figure:: /_static/images/Cancel_Confirmation.jpg
   :align: right
   :width: 465px

   Cancel confirmation pop-up

To cancel any changes without saving:

#. Click the Cancel button at the top.
#. Click OK in the confirmation pop-up. (:numref:`Settings_Cancel_Confirmation`) |br|

See also
--------

-  :ref:`Data Model - Assign a category to a table, view or stored procedure <Assign_a_category_to_a_table_view_or_stored_procedure>`
