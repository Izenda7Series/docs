
==============
Release Notes
==============

.. note::
	- Preview Release - x.x.1 - Early access to new features in isolation
	- Core Release - x.1.x - Quarterly stable release with preview releases and hotfixes combined
	- Major Release - 1.x.x - Larger Features, potential breaking changes

.. warning::
   - For all upgrades and installations, downloads.izenda.com is moved to our customer portal at app.izenda.com

 For more advanced information and details on our releases where needed, please see our :ref:`Release_Details` and :ref:`Breaking_Changes` .

For the current release notes, please see :ref:`Release_Notes`
For the release notes for Izenda vesrion 2.0.0 - 3.0.0, please see :ref:`Release_Notes_v2.0`


v1.25.4
~~~~~~~

FIXES
^^^^^
-  Defect 15875 Dynamic Supplementary KPI is not shown on gauge after saving report
-  Defect 15873 Stacked Bar Chart fails to render when using separator and selected color values
-  Defect 15878 Exporting fails for some gauges and charts
-  Defect 15908 Update Languages - The two language options provided in the base application are being removed. The new language pack can be accessed on a public GitHub repo `here <https://github.com/Izenda7Series/LanguagePacks>`__ with full installation instructions
-  Defect 15910 Scheduler popup locks when attempting to add user as recipient
-  Defect 15911 When using hidden filters, some field mappings are not properly passed to subreports
-  Defect 15874 Horizontal Grid does not render proper field formats


v1.25.3
~~~~~~~

FIXES
^^^^^
-  Defect 15570 When copying reports with subreports and a dashboard the subreport links do not show up in destination
-  Defect 15571 Data Setup > Connection String: SQL Injection issue noted for MySQL
-  Defect 15595 Tree filter is not displaying values when inherited from top level report
-  Defect 15640 Filters do not load for dashboard when copying reports after copying dashboard is separate copy workspace
-  Defect 15660 Oracle Issues in 12C as Izenda Configuration Database Inconsistent Data types error
-  Defect 15683 Value in Tree Filter of Dashboard is duplicated when using with Custom DLL

v1.25.2
~~~~~~~

FIXES
^^^^^
-  Defect 15498 In integrated and stand alone mode hidden filters are showing in the report designer and the viewer report is saved when new calculated field is added
-  Defect 15499 Reports copied with copy console show broken relationship screen in the report designer
-  Defect 15520 When copying a report with join alias and filter field from aliased table report errors in detination
-  Defect 15397 Cannot Create Sub-Report Mapping on Calculated Field

v1.25.1
~~~~~~~

FIXES
^^^^^
-  Defect 15457 When using a date/time field on the x axis and a separator the chart fails to render

v1.25.0
~~~~~~~

BREAKING CHANGES
^^^^^^^^^^^^^^^^
-  For integrations using deployment mode 1 (Front End Integrated and Back End Standalone) you must update the Izenda System Settings table. The following Settings must contain the full URL including the base address AuthValidateAccessTokenUrl and AuthGetAccessTokenUrl. These would have been relative paths prior and now must be the full url including the base url.

FEATURES
^^^^^^^^
-  Additional Join Functionality with key join allows setting a comparison to another field, null, not null or a value which can be entered manually by the user. This can be used by any user with access to joins in the report designer. Currently this feature cannot be used in cross database joins. This will be implemented later with an additional option for an in comparison.
-  Property Panel changes for simple data source users (users without ability to add joins in report designer) to show less options by default in the property panels of the report designer and the quick edit mode. The uer can still access the features using the More option on the property panel. Users with full access can select Less option to see less options in the property panels as well.
-  Improve rendering performance of report parts Form
-  Apply lazy loading for Popup, Combo Box, Dropdown to improve performance
-  Add Ability for user to add more than one field at a time in the report designer or quick add mode. Using the + symbol or the link to add field from report part.
-  Users can now use PostgreSQL functions as stored procedures. All functions which return a set are added as stored procedures
-  Added new filter operators for date time fields. Now a date, date time or time only option are provided
-  Added context menu to dashboard tile so the user can flip the tile using the context menu like the report part tiles
-  Property panel items with gear icons to show additional setting options now show the green check box when used and also display a red X to remove the additional settings and reset back to default state
-  Added options to the Render Report API to show/hide navigation, filter panel and toolbar
-  New Javascript API added to update results for Dashboard, Report and Report Parts
-  Exporting will now always export all records to the export limit or the limit set by each report part in the report designer
-  Performance enhancement when exporting to PDF with 10k records

FIXES
^^^^^
-  Defect 7470 Column Group for grid is not displaying in the report
-  Defect 13079 User must scroll to the bottom of the report body to get to the horizontal scroll bar due to extra vertical scroll bar
-  Defect 13255 Missing line breaks after {dashboard Link} text in schedule's email body.
-  Defect 13300 Null and Blank values are displayed as Undefined Value in Charts and Gauges
-  Defect 13457 Some areas of the application are referring to templates as reports ("Example Report Name")
-  Defect 13575 The list of fields of a data source is sorted incorrectly when "Sort Column Name" flag is turned on in data model
-  Defect 13800 Introduction text is not refreshed for system admins when switching between system and tenant on report designer
-  Defect 13858 After saving a report containing subreport with icon style selected, system is reverting to link style
-  Defect 13935 When user selects home or end key in some input text fields a numeric is displaying in the text box
-  Defect 13953 Removed the [] brackets from custom functions used in the calculated fields
-  Defect 14002 When using multiple Grand total lines some lines display a "0" where there should be no value
-  Defect 14012 User cannot un-sort the Funnel chart labels
-  Defect 14014 Sort icons are still appearing on some chart when the value should not be sortable
-  Defect 14018 Separators for Funnel charts are still allowing an unsorted view and should always be sorted
-  Defect 14039 Add new Field indicator is not removed on Data Model page when user clicks on save button for newly added stored procedures
-  Defect 14136 Timezone offsets for data and time stamps not working properly
-  Defect 14181 Reduce margin of Linear Gauge to make them larger and use the space provided
-  Defect 14227 Build a chart with multiple data sources and it fails to render preview in the XY-Plane popup setting
-  Defect 14235 Filter Sorting Does Not Work for Pop up and Checkbox & Tool Tip Is Wrong on sort icon
-  Defect 14287 If user clicks update results after adding a filter and prior to adding an operator, error message is shown for filter logic.
-  Defect 14298 Missing Loading progress bar when user changes Preview Records in View Mode/Quick Edit Mode
-  Defect 14302 Header format color changes the sort arrow color
-  Defect 14303 After adding a format to a field if the user selects none, the data remains formatted
-  Defect 14345 Label text is displayed incorrectly for Roles in copy management screen when selected for copy
-  Defect 14656 Save notification showing when user has just saved and clicked on Report Viewer
-  Defect 14657 Separator used in chart showing incorrect data on hover, shows all items not just the one grouping being hovered on.
-  Defect 14676 Custom URL will not work in some cases, the field value is not passed in the url only the reference as {fieldname}
-  Defect 14691 In Filter Equivalence missing scrollbar for checkbox type and not limit number of items to show
-  Defect 14738 Stored Procedure Parameter Filters do not show up in the Scheduled instance Filters
-  Defect 14762 When using Equals Tree filter child nodes are not unchecked when deleting parent node
-  Defect 14778 Using Not Equals Tree Filter Unknown error message shows when updating results
-  Defect 14793 Full access should be applied well when user checked "Full Report and Dashboard Access" checkbox in setting
-  Defect 14795 Filter ignored on report after adding one filter saving and adding another filter. Filter logic is set by system on save and should not be.
-  Defect 14798 Typing in dates for between calendar filter when user is in dd/mm/yyyy format alters date
-  Defect 14809 If user date format is not set there are errors in the users ability to see all date formats and when executing sp with date inputs
-  Defect 14824 In forms when user adds a sub total/grand total generates a new smart tag
-  Defect 14855 When changing setting level in New Dashboard, page redirect to Dashboard List
-  Defect 14881 User has full permission on Role setup cannot set role active/deactive
-  Defect 14901 List user in User pop up is blank when user creates 1 schedule/Email in Report Designer or in Dashboard
-  Defect 14907 List user in User pop up is blank when user creates Access right for User on Report Designer or Dashboard page
-  Defect 14920  Null value is displayed instead of blank on the rows which is not configured Grand Total/Sub Total
-  Defect 14927 Tenant link is displayed on Left Nav of Setting page while System User has no role for Tenant
-  Defect 14929 The format of Grand Total value for a separator in the preview section is different from the preview result in the popup
-  Defect 14934 Tenant link is missing of Setting page while System User has full permission role for Tenant permission
-  Defect 14935 In Tenant Permissions Access section of Role Setup permission doesn't display although it is checked in Tenant Setup permission
-  Defect 14943 When two grids are side by side even with enough space to print they are not exporting
-  Defect 14944 Report with Required Filters are executing a query prior to required filters being set
-  Defect 14945 Position Index does not work for either Custom Javascript or Custom URL
-  Defect 14946 Alternating background colors (rows and columns) not working on pivots
-  Defect 14950 Export progress bar is loading forever after editing broken reports
-  Defect 14951 Search report part on Dashboard, system returns the list of No records found
-  Defect 14955 User has "Full Report and Dashboard Access" has no permission on Save/Save As/Copy/Move/Delete/Access in Report List/Report Viewer/Report Designer
-  Defect 14956 Success message does not display after clicking Save button in System Config > Report
-  Defect 14958 Tenant Setup section is still displayed on Role Setup page in single Tenant mode
-  Defect 14965 Pagination doesn't update after user have just created new report and changed Preview Records value
-  Defect 14974 Some users may experience issues when inputting dates / times in scheduler and subscriptions.
-  Defect 14975 Embedded pages using margins throw off dropdown calculations and dropdowns appear out of alignment with the container
-  Defect 14980 System shows a null error msg when user navigates from Report Viewer to Report Designer
-  Defect 14984 Save function doesn't work when Version History's checkboxes are checked
-  Defect 15018 Newly created user does not appear in the sharing list option
-  Defect 15021 Category highlight status fails to update after saving as
-  Defect 15026 Default bubble size on map is too large causing many data points to over lap.
-  Defect 15027 Charts with X-Axis and interval setting not allowign decimal Intervals
-  Defect 15047 Roboto Font is not properly exporting in PDF
-  Defect 15048 Between Calendar Date filter errors when only one date is used, system should validate that both dates are entered. Also error thrown when both values are removed.
-  Defect 15051 The button has a fuzzy edge redundantly in some popups (Chart Border Settings, Grid Lines Settings, Legend Settings)
-  Defect 15052 The checkbox and field in 'Data Refresh Interval Settings' popup should be aligned for consistency.
-  Defect 15055 Introduction text does not display correctly when changing settings level.
-  Defect 15058 Subtotal/ Grand total inherits the format of column above it instead of using its own format
-  Defect 15059 API request for filtered reports requiring case sensitive information (keys and guid values must be lower case)
-  Defect 15060 Special Chars in Plaintext Connection Strings Throw Errors
-  Defect 15062 Legends Don't Respect Alternative Text settings for field data
-  Defect 15063 Page freezes when moving from copy management to any other page
-  Defect 15064 All dynamic Grids are displayed blank
-  Defect 15072 Scheduler/Subscription DateTime Time Pickers Not Working in IE
-  Defect 15120 System does not hide invisible Field on Dashboard for Pivot, Drilldown, Chart, Gauge, Map
-  Defect 15122 Change notification for Provision Map Data to "The system is importing Map data into the configuration database. Please wait for the process to complete before using Maps"
-  Defect 15127 Filters do not properly align when some are set to not visible in the viewer
-  Defect 15128 Only ONE form shows if embedded multiple similar forms
-  Defect 15129 When creating Map, cities are showing in the wrong countries
-  Defect 15154 Column group is not working in some reports
-  Defect 15155 Report is broken when user unchecks on a datasource in Report Designer and then navigates to another page without saving
-  Defect 15160 Draft saved version of existing Report is loaded to Report Designer, not the actual saved version
-  Defect 15175 Tool tip of DateTime data type is different from the original data in Grid reports
-  Defect 15176 Relationship and Key Join is missing when user navigate from Field to Data Source
-  Defect 15179 Separator expand and collapse icons are Hidden In Dashboards
-  Defect 15181 In Time Period Filter is not showing values in scheduled instance filter dropdowns
-  Defect 15186 Embedded reports only show the icon when there is repeater in form
-  Defect 15194 Export Fails for Form stating invalid field but data is returned in the UI
-  Defect 15202 Missing scrollbar for checkbox type and not limit number of items to show
-  Defect 15209 Unable to set subtotal/grand total for the second similar field
-  Defect 15219 All property panels are at More state on entry when user is in simple data source mode
-  Defect 15222 System shows no record in Preview when user saves report having Additional join (>=) and Filter. Relationship is reset to blank on some fields in Data Sources page
-  Defect 15223 System returns incorrect Total data before and after saving when user saves report have Additional joins
-  Defect 15224 Toggle link is disable when selecting any item in dropdown list
-  Defect 15228 System shows incorrect data when user use Operator Different (<>) on Key Join
-  Defect 15229 User can not navigate to Data Source page on existing report which has Key Join
-  Defect 15232 System shows error msg "application has unknown error" when user set negative data for Key Join value
-  Defect 15234 No value displays in filter popup and page is freezing after closing the popup
-  Defect 15251 The Subtotal/Grand Total setting aren't removed when user clicks on their red X icon to remove
-  Defect 15255 Printed page is blank when printing report or printing a dashboard tile in dashboard
-  Defect 15258 Column Deleted after changing format in Property Panel
-  Defect 15262 Error states relationship does not exist when attempting to edit report and system will not allow user back to data source tab
-  Defect 15264 Field Positions are duplicated causing report to error
-  Defect 15265 Text color and Cell color don't show green check-box and red X icon after user added setting with Percentage Range
-  Defect 15274 Page doesn't work and the green check-box and red X icon still show after user removed settings
-  Defect 15282 Save As 1 existing report which as Key Join, the system shows the blank data on Foreign Data Object and mask with dot symbol on Field. Some other datasources are disabled.
-  Defect 15287 Incorrect Data is returned on report when user uses LEFT Join or RIGHT Join on Relationship when using key join
-  Defect 15289 System errors scheduling with Attachment in Standalone Frontend and Embedded BackEnd
-  Defect 15342 Default Access rights are not populated correctly when user does not have access to the access tab in the report designer
-  Defect 15365 Relationship of the new added data source is removed after user saves report
-  Defect 15366 Key Join does not work when using multi datasources in PostgreSQL
-  Defect 15379 When using new Key Join Filter Operators is reset to blank. Data Object, Foreign Data Object, Join Field, Field are changed to disable field when user saves report on Data Source page
-  Defect 15415 Collation Issues, Invalid object name 'SYS.FOREIGN_KEY_COLUMNS'. When using case sensitive collation
-  Defect 15416 When the physical database names are different for source and destination the copy fails.

v1.24.5
~~~~~~~

FIXES
^^^^^
-  Defect 15310   Copy Process from Copy Console duplicating sharing permissions on reports after tenant copy
-  Defect 15341   Custom Tree Filter values appear in report designer but not in the report viewer

v1.24.4
~~~~~~~

FIXES
^^^^^
-  Defect 15183   Charts fail to email in integrated instances. The following method needs to be added in the IzendaConfig.cs class

.. code-block:: csharp

        public static void RegisterLoginLogic()
        {
            UserIntegrationConfig.GetAccessToken = (args) =>
            {
                return IzendaBoundary.IzendaTokenAuthorization.GetToken(new Models.UserInfo()
                {
                    UserName = args.UserName,
                    TenantUniqueName = args.TenantId
                });
            }
        }

-  Defect 15245   Error Thrown in PostgreSQL when attempting to create Izenda config database
-  Defect 15261   Data from Query is incorrect when using Left join

v1.24.3
~~~~~~~

FIXES
^^^^^
-  Defect 15130   Multiple joins in model between two tables not creating and relationship between both relationships
-  Defect 15140   Dashboard performance improvements
-  Defect 15142   Updated assembly references in the Izenda.BI.Framework

v1.24.2
~~~~~~~

FIXES
^^^^^

-  Defect 15061    After making a field not visible in the data model the field is still shown in existing reports
-  Defect 15124    Hidden Filters are showing as actual filters in subreport when filter inheritance is turned on
-  Defect 15126    Filter aliases not shown under the report filter descriptions
-  Defect 15123    System is adding joins from the tenant model to report after copy
-  Defect 15074    User can still access and design a report they are given No Access to report if it resides in a Visible Category for their role, and there is a higher scope access set (ie Everyone - Full Access)
-  Defect 15177    Hidden Filter fails if the user enters join alias for item in report designer. Documentation Updated (See IAdhocExtension, Hidden report filters)

v1.24.1
~~~~~~~

FIXES
^^^^^

-  Defect 15001 Report Render is taking a long time in the Report Viewer
-  Defect 15023 AVG function on field is truncating all decimals
-  Defect 15032 API POST request to trigger export with filter values
   not working properly. This resolves the initial issue but please note
   all values are case sensitive and GUID values for filter key must be
   lower case. Example request body below for route /api/export/pdf::

    {
     "reportID":"ff1b105c-fffc-407e-98c4-2fc17c3d79b1",
     "filters":[{
      "key" : "0d01fe9f-10ff-4b42-a8f3-b7e4f8983817",
      "value":"800"
     },
     {
      "key":"dea8ee0e-08bf-4a8f-9158-240837b26e2f",
      "value":"10250;#10248"
     }]}


-  Defect 15046 Updated insert process for new datasources. This is now
   batched into multiple insert statements to avoid timeout errors. A
   new setting has been added to IzendaSystemSetting table with this
   release to allow control over the number of items in each batch.
   Setting value is InsertBatchSize and default is 10000. Added setting
   to configure Command Timeout in IzendaSystemSetting table, this
   timeout is for the insert and update statements to the Configuration
   Database.
-  Defect 15024 Custom Functions defined JSON are not working, they
   require use of [] around function name which are not added in the
   expression builder. These should be auto added when selected.

v1.24.0
~~~~~~~

FEATURES
^^^^^^^^

-  Added the ability for subreports to inherit filters and their values
   from parent reports

   -  The datasources for the parent/subreport must be exactly the same
   -  The inherit filter checkbox must be checked when setting up
      subreports
   -  These filters will not have to be present on the subreport ahead
      of time

-  Added ability to create Custom In Time Period values for filters
-  Updated support for mapping fields to subreports when values are
   datetime and numeric fields
-  Extended ability for customer to add custom formats for field
   properties
-  Added setting at tenant level to add logo by tenant for header image.
   Setting is located in System Configuration > Report
-  Moved Filter Operator just under Source in Filter Property Panel for
   ease of use and visibility in the property panel
-  Added Default Filter Operators for each Datatype

   -  Date: Equivalence Equals Calendar
   -  Text: Equivalence Manual Entry
   -  Number: Equivalence Manual Entry
   -  Money: Equivalence Manual Entry
   -  Subtotal Auto Add name for subtotal so user is not required to configure a name

-  Change Filter Descriptions default should be set to off
-  Removed extra white space on back of Dashboard Tiles
-  Enhanced search feature for Reports for dashboard and subreport so
   more report results are shown on independent screen
-  Add button on Repoirt List to Navigate to Quick Edit Mode
-  In Report Viewer Hide the View mode button until the user is in quick
   edit mode
-  When navigating to edit a report in report designer user is brought
   to Fields tab not Datasource tab
-  In Role Permissions added option to select all items in each section
-  In Tenant Permissions added option to select all items in each
   section
-  Change Update Results Behavior in report designer, user is not
   required to update results for saving and when navigating to fields
   tab with proper configuration
-  Data Setup > Advanced Settings > Others: Added settings to define Common Filters for Dashboard

   -  Same field of the same data object from the same Database Schema
   -  Same field name regardless of the Database Schema or connection string
   -  Same alias name in Data Model regardless of Database Schema or connection
      string

-  Added support for Export API to accept filter and filter values
-  Remove Copy icon from the backside of report part tile and dashboard
   tile to reduce accidental copy of report part when attempting to flip
   tile. It is now only available on the front side.
-  For Charts and Gauges the items per row and pagination items can now
   be used independently
-  Changed the default size for the filter panel in all areas to default
   2 rows high instead of 3
-  Reports broken from data model changes can now be edited to remove
   fields no longer available in report designer
-  Access limits for sharing will now maintain the parent node so any
   new users to a role will be added to that sharing group by default
   when entire role is selected
-  Increased width of Tenant dropdown in the setting level to ease
   viewing the tenant being selected

FIXES
^^^^^

-  Defect 13990 Label height is inconsistent for filter control boxes in
   the report viewer based in filter control type
-  Defect 14006 When using $/100 format in the sub/grand total the
   preview of the sub/grand total is not displaying properly even when
   actual total is formatted
-  Defect 14020 System missing validated indicator on Connection String
   level when user does not create mapping for these connection strings
-  Defect 14024 Grand Total value for a separator is calculated
   differently in the preview section compared to the preview result in
   the popup for the Grand Total Field
-  Defect 14029 Roles with no access to Functions (not moved to visible
   for this role) can use them in the report designer field function
   dropdown
-  Defect 14031 If report or dashboard was saved with sharing access for
   a role or user will not save change to share with everyone
-  Defect 14035 Missing background color for fields added into Visual
   tab of form designer
-  Defect 14042 Some date time formats are not displaying correctly for
   Grand totals
-  Defect 14124 Subscribe option should not be shown to users with Save
   As access to dashboard, as user has permissions to schedule
-  Defect 14125 View Mode button in the report viewer is showing
   progress bar when clicked and still disabled
-  Defect 14176 Settings Level should be disabled when user is in my
   profile area of application
-  Defect 14177 Source and Destination trees are hidden after clicking
   Validate in Data Advanced Options screen
-  Defect 14186 When using alternating row colors, PDF export is
   different than what is on the screen
-  Defect 14203 Need space between radio button and labels 'Linear' /
   'Value'
-  Defect 14207 Intervals are not presented when user switches back old
   X-axis Type
-  Defect 13501 Currently the system is missing Help indicator in
   following places in Copy Management Mapping areas (In All Mappings,
   in Merge Duplicated Mappings, and in Object Label of To area)
-  Defect 13504 Mapping area in Main page: System variable TenantName
   does not work
-  Defect 13505 The system does not have the checkbox "Merge Duplicate
   Mappings" in Advanced Copy Options page of Copy Management
-  Defect 13523 In Role Setup Tenant Setup anchor link still displays in
   Permissions page for setting level = tenant
-  Defect 13599 In Dashboard list the subcategory does not remain
   expanded when user opens report from list
-  Defect 13655 "There are no records returned" error raised when
   configuring subtotal for a field of a table having data
-  Defect 13775 Link and icons should be removed from report if
   subreport is not copied with report in destination.
-  Defect 13859 Suggested data type is not changed when user changes the
   field in the calculated field expression text box
-  Defect 13868 Fields of newly added stored procedures are not selected
   by default while the Advanced Settings> Set Additive Field Auto
   Visible/Filterable are checked
-  Defect 13876 Subcategory is not displaying when added again after
   deleting
-  Defect 13908 Tool tip error message for Query Limit, Field Limit and
   Pivot Column Limit still show reference to Data Source Limit when set
   to an unsupported number like -1
-  Defect 14216 Missing horizontal scrollbar on popup of subreport when
   needed
-  Defect 14224 X-Axis updates incorrectly when user changes value of
   Interval in XY-Plane settings
-  Defect 14233 After building a report with one report part and saving,
   if deleted without save and moving to the viewer will cause error
-  Defect 14234 General error message shows when copying a
   report/dashboard with deleted report part.
-  Defect 14306 Null value on chart X axis takes name of total label
-  Defect 14761 Using Oracle error message is shown when user selects
   Function = Group Days Old for Date field in Report Container
-  Defect 14774 General error message shows when changing a UserID
-  Defect 14802 Sub report data fails to load when using popup and form
-  Defect 14807 Close button does not work when user clicks on Report
   Name in Report List then clicks on Open button to open the Report
   Viewer
-  Defect 14808 The "Link/this icon was configured to show in other
   settings (Sub-report/Custom URL/ Embedded Javascript). Please select
   the other ones" warning is displayed when user sets both Custom URL
   and Embedded Javascript
-  Defect 14812 Page continues to load if ENTER is clicked to close the
   generate password successful popup.
-  Defect 14815 Sharing record temporarily dismisses when saving then
   updating result.
-  Defect 14867 The "There is no relationship(s) among the following
   data objects. Please manually unselect them or creat relationship for
   them...." message is displayed when user clicks Data Source icon from
   Field tab page
-  Defect 14890 Responsive - Change mobile mode from 1280 to 1024
-  Defect 14933 Unable to go to fields page when selecting another data
   objects from Datasource page
-  Defect 14938 Function for applying Format on DateTime Field does not
   works with Group or without Group function
-  Defect 14940 Unable to export pivot grid
-  Defect 14961 System shows error msg when user open Sub Report while
   Master = Data of Week, Sub Report = Group Date & Time
-  Defect 14963 System shows "No record found" when user opens Sub
   Report while Master = M/d/yy or Week Number, Sub Report = Date of
   Week
-  Defect 14967 System returns incorrect "Day of Week" on Sub Report
   while Master and Sub Report is build from the same table in the same
   Connection String
-  Defect 14978 System shows error msg when user updates Report
   Properties/Field Properties and then changes the report from Front
   side to Back side
-  Defect 14242 Page continues to load when deleting a CF then turning
   to front side of Form
-  Defect 14277 In Oracle cannot add SP to Visible Data Sources
-  Defect 14295 Clicking report name expands report info and should not,
   should take the user to the report viewer directly without this step
-  Defect 14894 Format for page numbers in header and footer do not
   change
-  Defect 14659 PDF Exports are scaling smaller even when printed
   columns per page on.
-  Defect 14672 When export types are disabled at the tenant level
   giving user full report and dashboard access is still showing these
   options
-  Defect 14674 Filter Operator In Time Period showing "Undefined" on
   Dashboard when not a common filter
-  Defect 14679 Gauge pagination is showing when turned off after any
   configuration change to the gauge. It can be turned on and off again
   and will be removed but it must be done after each change.
-  Defect 14228 ReactJS loads twice when integrating with another
   ReactJS app
-  Defect 13925 Out of memory errors occurring when validating many
   tenants using copy function for data model or reports.
-  Defect 14215 Pivot grids do not render columns where all values are 0

v1.23.2
~~~~~~~

FIXES
^^^^^

-  Defect 14771 Cross-Database Issues with Izenda configuration Database
-  Defect 14724 When grouping a date field and changing the format some
   dates are appearing out of order
-  Defect 14727 Setting up the custom tree filter when parent node is
   checked all child elements should be selected
-  Defect 14737 In Time period filter causing errors and report & query
   will not export
-  Defect 14751 MySQL errors logged in accessing report & dashboard
   categories
-  Defect 14794 Tree Filter is adding each list multiple times in
   dashboard when common filter
-  Defect 14698 Error is shown when attempting to use a between date
   filter for any date values in Oracle

v1.23.1
~~~~~~~

FIXES
^^^^^

-  Defect 14690 Simple style gauge is not exporting from standalone
   environments.
-  Defect 14682 Oracle 12c giving errors on inconsistent datatypes of
   CLOB.
-  Defect 14671 Filter aliases not being displayed in the report viewer.
-  Defect 14680 Filter query fails in some cases where certain special
   characters are used in the field name. Fields with aliases in the
   data model may fail in expressions when used with an expression and
   field in the same report.
-  Defect 14685 Authorization error preventing exporting in integrated
   environments.

v1.23.0 (GA)
~~~~~~~~~~~~

FEATURES
^^^^^^^^

-  The Copy Console Utility is now available. This utility can copy
   reports, dashboards, etc to separate API instances

FIXES
^^^^^

-  Defect 14297 Tenants and Roles with access to all report part types
   could only see grids in integrated modes.
-  Defect 14296 A report's QuerySourceId as set to 0 after being copied
   via the copy management console application
-  Defect 14240 Javascript API was unable to set a new locale in a
   standalone deployment
-  Defect 14238 Stored Procedure Lookup Key/Value Inputs did not
   Properly Convert Int Input to Text
-  Defect 14229 Using Calculated Fields as a Filter would return no data
-  Defect 14214 Pivot Grids would not allow for the same field to be
   used as a row and value
-  Defect 14210 Fields with an image data type would not render
-  Defect 14209 Drilldown grids would expand shortly after closing when
   subtotals were applied; subtotals would lose their aggregate metric
   when collapsed
-  Defect 14208 Platform crashes when pulling back reports with large
   record sets (10K/30K)
-  Defect 14109 PostgreSQL input arguments do not carry through to the
   Function area of the data model
-  Defect 14319 Revised UI Grammatical and Spelling Errors
-  Defect 14317 Calculated field queries would identify the wrong field
   to be used for grouping
-  Defect 14318 Users with Full Report and Dashboard Access could not
   save reports that contained report part types they weren't explicity
   granted access to.
