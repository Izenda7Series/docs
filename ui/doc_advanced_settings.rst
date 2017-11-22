

=================
Advanced Settings
=================

The **Advanced Settings** page allows user to


* manage the list of data source categories
* update system settings in related groups

Update settings in Performance group
------------------------------------

#. In browser, log in to Izenda as a user with Advanced Settings
   permission.
#. Click Settings, then Data Setup then Advanced Settings in the left
   menu.
#. Select the Setting Level: either System or a specific tenant.
#. Click on Others tab.
#. The settings are list as below:

   .. figure:: /_static/images/Advanced_Settings_Performance.png
      :align: center
      :width: 1653px

      Setting values provied in Others group

#. Hover on information icon following the value name to see the brief guide of that value

   .. figure:: /_static/images/Advanced_Settings_Performance_Hover_Brief_Guide.png
      :align: center
      :width: 1001px

      Brief guide of a configuration option.

#. Update the values.
#. Click Save button at the top to save the whole settings.

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
         -  To limit the number of data sources in a single reprot.
      *  -  Field Limit
         -  To limit the number of filed in a reprot part.
      *  -  Query Limit
         -  To limit the number of values return from the query in Report Designer, Report Viewer, Dashboard and Export.
      *  -  Pivot Column Limit
         -  Limit the number of columns in a pivot report part.
      *  -  Filter Limit
         -  Limit the number of items displayed in Filter Value dropdown


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

.. _Update_settings_in_Performance_Security_Additive_Fields_and_Others_group:

Update settings in Performance, Security/Additive Fields and Others group
-------------------------------------------------------------------------

#. In browser, log in to Izenda as a user with Advanced Settings
   permission.
#. Click Settings, then Data Setup then Advanced Settings in the left
   menu.
#. Select the Setting Level: either System or a specific tenant.
#. .. _Menu_Advanced_Settings_Performance_Security_and_Others:

   .. figure:: /_static/images/Menu_Advanced_Settings_Performance_Security_Others.jpg
      :align: right
      :width: 389px

      Performance, Security and Others

   Click Performance, Security or Others. (:numref:`Menu_Advanced_Settings_Performance_Security_and_Others`) |br|
#. The settings are listed together with their current values.
#. Update the values.

      User can revert any setting back to its system default value by clicking the back arrow icon (↺). (:numref:`Advanced_Settings_Back_to_Default_Value`)

      .. _Advanced_Settings_Back_to_Default_Value:

      .. figure:: /_static/images/Advanced_Settings_Back_to_default_value.jpg
         :width: 618px

         Revert back to default value |br|

#. Click Save button at the top to save the whole setting group.

   .. note::

      The input boxes only accept a limited range of values and will not allow invalid entries.

   .. note::

      For a detailed description of any setting, point over that setting to see the information icon (i), then point over that icon to see the description tooltip. (:numref:`Advanced_Settings_Detailed_Description_Tooltip`)

      .. _Advanced_Settings_Detailed_Description_Tooltip:

      .. figure:: /_static/images/Advanced_Settings_Detailed_description_tooltip.jpg
         :width: 617px

         Detailed description tooltip |br|

.. note::

   The Use No Lock setting instructs the database engine to return the current version of data immediately, instead of waiting for all pending transactions to complete. Check the possible consequences `here <https://www.izenda.com/blog/high-performance-sql-views-using-withnolock/>`__ before using this option.

Update settings in Security/Tenant group
-----------------------------------------

For security in multi-tenant systems, it is a best practice to have an
automatic filter condition to always restrict data retrieval to only
that of the current tenant. To enable this feature:

#. Untick Show Tenant Field check-box.
#. Enter the name of tenant id fields into the Tenant Field box. The Tenant Field must be enclosed in brackets [fieldname] and multiple fields should be separated by a semi-colon.
#. Click Save button at the top.
#. Then:

   -  These tenant id fields will be hidden from Report Designer.
   -  The reports will automatically have a filter condition to restrict
      data retrieval to only that of the current tenant.

Cancel the changes
*******************

.. _Settings_Cancel_Confirmation:

.. figure:: /_static/images/Cancel_Confirmation.jpg
   :align: right
   :width: 465px

   Cancel confirmation pop-up

To cancel any changes without saving:

#. Click the Cancel button at the top.
#. Click OK in the confirmation pop-up. (:numref:`Settings_Cancel_Confirmation`) |br|

Update settings in Others group
--------------------------------


#. In browser, log in to Izenda as a user with Advanced Settings
   permission.
#. Click Settings, then Data Setup then Advanced Settings in the left
   menu.
#. Select the Setting Level: either System or a specific tenant.
#. Click on Others tab.
#. The settings are list as below:

   .. figure:: /_static/images/Advanced_Settings_Others.png
      :align: center
      :width: 1649px

      Setting values provied in Others group

#. Hover on information icon following the value name to see the brief guide of that value

   .. figure:: /_static/images/Advanced_Settings_Others_Hover_Brief_Guide.png
      :align: center
      :width: 1376px

      Brief guide of a configuration option.

#. Update the values.
#. Click Save button at the top to save the whole settings.

Sort Colum Name 
****************

This option allows user to alphabetically sort the lists of column or field names in the following pages/items:

   * Report Designer > Data Source tab > Middle Panel
   * Report Designer > Field tab > Middle Panel
   * Report Designer > Field tab > Add Calculated Field popup > Field Name section
   * Report Designer > Field tab > Filter section > Item in the filter dropdown
   * Report Designer > Filter Properties Panel > Item in the Filter Name dropdown
   * Field Selection popup

Select checkbox in the value column of this option to use this function.

Trim Time In Joins
*******************

To trim the time portion form the Date Time field in a join statement in Report DEsigner - Relationship page, slect the checkbox of this option.

Please see the maping below for more detail.

  .. list-table::
      :header-rows: 1

      *  -  Date & Time group
         -  Date group
      *  -  = (Date & Time)
         -  = (Date)
      *  -  <> (Date & Time)
         -  <> (Date)
      *  -  > (Date & Time)
         -  > (Date)
      *  -  < (Date & Time)
         -  < (Date)
      *  -  >= (Date & Time)
         -  >= (Date)
      *  -  <= (Date & Time)
         -  <= (Date)

Timezone for Data Offset 
************************

This section allows user to set default value for the Timezone Data Offset in Settings > User Setup page. And this setting will effect to displayed data value of Datetime/Time fields in the report part.

For example, in database the data value is 11:00. If user sets “+5” in the textbox of this section then the data value will be shown as 16:00 in the report part.

Timezone for Timestamp Offset
******************************

This section allows user to set default value for the Timezone Data Offset in Settings > User Setup page. And this setting will effect to all Datetime/Time field in system

For example: The created date of report is 11:00. If user sets “+5” in the textbox of this section then the created date will be shown as 16:00 in the system

Convert Null to Empty String
*****************************

To convert all null values to blank (empty) in reports or dashboards, select the checkbox of this section in the value column.

Show Schema Name
*****************

This section allows user to show schema name together with the the data source name in any place, such as:

   * Report Designer > Data Source tab > Middle Panel
   * Report Designer > Data Source tab > Relationship 
   * Report Designer > Field tab > Middle Panel
   * Data Setup > Data Model > Relationship
   * etc…

To use this function, select the checkbox of this section in the value column.

Show Introduction Text
***********************

This section allows user to show the Introduction Text in the following section:

   * Report Designer > Data Source tab > Content Panel > under Report Name
   * Report List > Content Panel > under each report name

To use this function, select the checkbox of this section in the value column then input to the Introduction Text textbox below.

Send to Disk Path
*****************

To define the path to save files for all Scheduled/Subcribed instances with **Send to Disk** delivery method, input path in the textbox of that section.

.. note::

   * When the report is saved into this location, system will save report name together data time so that saving the new version of this report will not overwrite this report. The format when saved: <report name>_<mmddyyyy>_<hhmmss>

   * For example:

      If I have report “ABC” and save to disk path at 10/22/2016, 23:59:00 then the report will be saved with name = ABC_10222016_235900

Determine common filter for the same field based on
***************************************************

Sellect one of three options in this section to determine how the filters considered whether different or the same in the dasboard so they will be common filter or not.

Allow Multiple Sorts on Grid Header
***********************************

By selecting this section, user can sort on multiple columns when clicking on Grid header in Vertical/Horizontal report. Otherwise, user can only sort by one column at a time.

Show Preview section in Configuration Mode
*******************************************

By slecting this checkbox, both Configuration and Preview sections display in the report part’s backside and setting popups in following areas:

   * Report Designer > backside on each report part
   * Report Viewer > Quick Edit mode > backside on each report part
   * Chart > Report Part Properties > Border, Background Color, XY-Plan, Grid Lines, Legend, Thresholds popup
   * Gauge > Report Part Properties > Border, Background Color (?) popup
   * Map > Report Part Properties > Border, Background Color, Legend, Zoom popup
   * Form > Report Part Properties > Border popup

See also
--------

-  :ref:`Data Model - Assign a category to a table, view or stored procedure <Assign_a_category_to_a_table_view_or_stored_procedure>`
