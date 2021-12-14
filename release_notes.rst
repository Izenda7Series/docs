
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
 
For the release notes for Izenda vesrion 1.0.0 - 2.0.0, please see :ref:`Release_Notes_v1.0`
For the release notes for Izenda vesrion 2.0.0 - 3.0.0, please see :ref:`Release_Notes_v2.0`

v4.2.0 Major Release - December 14th, 2021
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
FEATURES
^^^^^^^^^
- New Report Designer Improvements - Visualization Additions
   - Charts: Heat map, TreeMap, Bubble, Sparkline, Scatter, Bubble, Waterfall
   - Gauges: Simple, Solid, and Liner
- New Report Designer - Layout Designer
   - Mobile Layout
   - Print and Export Layout: A3, A4, US Letter, Legal, Ledger, and Tabloid
- New Report Designer - End User Filter Modification
   - End-user now all to create and modify filter(s)
- Oracle reporting database connection pulling is allowed now for web-farm deployments
- Import API for Dashboard and Reports now support batch upload.
- Frontend Library Updated - TinyMEC 5.0
FIXES
^^^^^
- Defect 30070  Scheduler process hangs on malformed subscriptions
- Defect 23853  Quick Edit Fullscreen is not working on Report Parts
- Defect 24092  Centering in Exports Not Working as Expected
- Defect 25088  Copy Management - The copied report is failed to load in the destination if it contains the join alias and filter.
- Defect 27396  Wrong subtotals when exporting if expanders are enabled
- Defect 27924  Unable to save copied dashboard schedule instance
- Defect 28885  Unable to Remove Data Sources when creating a report with Simple Data Source Permission
- Defect 29660  Data Model Import breaks the Stored Procedure access due to Output parameter not copying
- Defect 30025  Report with multiple parts unusable on mobile
- Defect 30050  Send EHLO process throws error when saving SMTP configuration
- Defect 30051  Validate syntax button allows joining a string field to a guid
- Defect 30148  Copy Management - duplicate workspace gets created upon clicking save button several times.
- Defect 30161  Send to disk Scheduler always creates PDF.
- Defect 30173  "Show Filter" for In Time Period Filter on Dashboard Displays "undefined"
- Defect 30191  Cannot load report history if current report version throws error
- Defect 30217  CurrentAccessToken from UserContext not populated in CustomWebUrlResolver
- Defect 30268  Unable to edit copied dashboard schedule instance
- Defect 30329  Created, CreatedBy, Modified, and ModifiedBy columns left as null in IzendaConnection table
- Defect 30330  POST api/connection endpoint not showing in API logs
- Defect 30341  Login issue in Integration Mode because of last_time_accessed cookie
- Defect 18848  [Report Designer][MAP] Unable to config Color setting shading metric if selecting containers are NOT country
- Defect 22647  [Dashboard - Common Filter] The Invisible/Unalterable filter still appearing on the Common Filter
- Defect 24622  [Chart] System gets error when drawing Chart with Calculated Fields and Range Only
- Defect 25674  [Chart/Gauge] The exported data with Null separator is missing when checking on Page Break After Separator
- Defect 25690  Undefined values when opening collapsed groups with NULLs in Drilldowns and Pivots
- Defect 25902  Empty total rows and collapsed results in Drilldown grid after changing grid style
- Defect 26130  Grand Total does not work for collapsed group fields in Drilldown grid
- Defect 26161  Subtotals are incorrect when printing Drilldown grid with Logical separator when groups are collapsed by default
- Defect 27425  Border style applies partially to collapsed state for pivot header
- Defect 27992  Not able to make filter selections when viewing a report on an iphone or seemingly any other mobile device.
- Defect 28731  Unwanted white space in pivot grid Report
- Defect 28824  Unable to Reset Password if "No. of Security Questions per User Profile" and "No. of Security Questions to Reset Password" is unmatched.
- Defect 28940  Role Permissions: Category moving from allow savings to Visible shows error when user and saves when user under users tab is unchecked.
- Defect 29086  Image dimensions always consider original values and not updating with the customized values in design mode and viewer mode of the Forms report
- Defect 29443  Position of The Sort options in sub-report are at wrong location if we use the popup window for sub reports.
- Defect 29548  Between Date & Time filter throws error when using Oracle reporting database
- Defect 29697  Unable to see Original Report Name when Overriding Report
- Defect 29713  Exception when trying to save the dashboard after granting the access with Role.
- Defect 29737  Filter with user-defined filter values and set to [BLANK] reverted to empty with Error and Non-required DATE filters returned an error when empty
- Defect 29832  Tab character not rendering in PDF export
- Defect 29873  Aggregated value is not showing correctly and shows same values in all different columns and the sum is also not coming correctly in pivot grid type.
- Defect 29936  Implementation of the optimal user autocompletion method for classic pages
- Defect 30012  'Proxima Nova' font type on the Report title is not getting applied in the exported file.
- Defect 30023  Legacy and RD2: Styling - Table: Border does not get applied.
- Defect 30045  'Day of Week' format are always showing current day of week in export , schedule or email.
- Defect 30075  Actual subscription last run date and time does not match what is in the UI
- Defect 30117  Excel Export Error For Report With Non-visible Field
- Defect 30118  Report separator is not visible in exported word documents with 'Multi Level With' separator style
- Defect 30149  Changes made to the report name on M3 is not saved
- Defect 30175  Disable removing filters capability from mobile view
- Defect 30188  Dashboard | Uncategorized list is getting blank when user clicks on Uncategorized under the Global Category
- Defect 30206  Unexpected results with Report Subscriptions
- Defect 30263  Label on scatter chart shows separator field name as y-axis field name
- Defect 30267  All fields are displayed on M1S3 when the fields are modified by the user.
- Defect 30291  Html text in sub report not rendering properly when main report exporting to excel
- Defect 30292  Print Layout options doesn't appear for exports and print from the report list
- Defect 30293  Print Layout - Grid report part keeps loading until refresh in layout designer
- Defect 30294  Order of report parts changes after saving report and refreshing page
- Defect 30321  Print Layout option shows for XML and JSON exports
- Defect 30332  Do not make request for layouts for reports created in Legacy Designer.
- Defect 30347  [RD2.0] Average Rendering Time is not calculated for reports created in RD2.0
- Defect 30349  In Dashboard Text tile, body text section is not appearing
- Defect 30351  Getting blank page for dashboards when reports are broken
- Defect 30363  Incorrect error message for blank mandatory fields in asynchronous exporting and Email.
- Defect 30368  Dashboard section UI is broken on schedule page of dashboard
- Defect 30369  Print layouts : Getting error while printing after selecting print layout
- Defect 30371  M2 - User is able to create multiple mobile layout
- Defect 30380  Syntax error when trying to use Postgres as config database
- Defect 30382  Print layouts : Character length beyond 18 chars is not properly displayed in print tile.
- Defect 30383  [NLQ]: Query results are not getting populated for NLQ
- Defect 30384  [Grid]: Scrolling is not working properly for grid enhancement options
- Defect 30386  Print layouts : Print preview is broken when data length is not as per column width
- Defect 30389  Print & Export View UI distorted for report and Dashboard view
- Defect 29154  M1S2 - properties should be labeled as "Fields "
- Defect 29707  Unable to easily close out of popup modal from lightbulb icon
- Defect 29728  Sort button does not stay in the grid header
- Defect 29813  After refreshing the report part, visual tab shows all the report part types for few seconds.
- Defect 30098  Access Rights disappears for few seconds when the user edits and saves.
- Defect 30146  Report name with some character throws validation error


v3.13.1 Service Pack Release -- October 12th, 2021
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- When selecting the Adv. Report Creator role type, the KPI report parts permission will be selected by default.
- When deleting a user via the API, a secondary UserID can be specified to transfer ownership of reports and dashboards to that secondary user
- Connections to Oracle sources will now leverage connection pooling for improved performance and reliability. 

FIXES
^^^^^
- Defect 30217  The CurrentAccessToken value for the UserContext object was not populated within CustomWebUrlResolver extension class.
- Defect 30191  When the current report version throws an error, the report history popup would fail to load. 
- Defect 30161  The send to disk scheduler option always creates a PDF regardless of selection.
- Defect 30075  Actual subscription last run date and time does not match what is shown within the UI.
- Defect 30070  The Scheduler process would hang indefinitely on any malformed subscriptions.
- Defect 30050  Send EHLO process throws error when saving SMTP configuration for an Izenda instance.
- Defect 30045  The 'Day of Week' format would always show the current day of week in exports, schedules, or emails.
- Defect 30003  The allow nulls checkbox in the report designer doesn't reflect values from the underlying definition.
- Defect 29960  Switching the preview record to more than 100 throw an error when reporting on PGSQL sources.
- Defect 29906  The preventReportSharing permission missing from permission builder within the external role APIs.
- Defect 29748  Filters Aren't Displaying in Exports done through the API when using the UseLegacyMhtExcelExport option.
- Defect 29743  Schedules configured before Daylight Saving time would fail to send at the adjusted times.
- Defect 29703  The API crashes when viewing or exporting reports with certain amount of columns as a result of DeepCloner v1.0.3.
- Defect 29670  Errors would be thrown within the  NlQ Service When Creating Relationships in the Data Model.
- Defect 29551  Attempting to download an exported report to PDF would throw errors due to the underlying export service failing.
- Defect 28524  Selecting the 'Clear Filter' option would clear all filters even if they are non-visible and/or hidden


v4.1.0 Core Release -- August 17th, 2021
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- Improved Category Management
  - Categories can be created, deleted, and re-named from the left-hand category list on the report list page
- New Report Designer Improvements
  - Visualization Additions
    - More chart and grid types added to the new design experience
  - Report Header/Footers
    - Header and footer settings can now be configured for reports designed with the new experience
  - New Loading State 
    - There is a new Izenda aperture loading image that will be displayed when the application is loading
- Hiding Subreports from Report List
  - A new permission is added to roles that will hide any report that is leveraged as a subreport from their report list
- Custom ID field added to RoleDetail object
  - The RoleDetail object now contains a RoleID field which only exists during code interactions

FIXES
^^^^^
- Defect 30154  Schedule is not getting updated for custom recurrence.
- Defect 30145  On cache page, after enabling /disabling system or data cache, the setting is not retained.
- Defect 30142  [RD2.0] Blank page after saving report on M1S3
- Defect 30134  RD2 - Report Part keeps loading infinitely when saved on M1S2 page
- Defect 30132  [RD2.0] Duplicate relationships after saving reports
- Defect 30123  [Role Setup] Popup appears to save changes even when changes are saved.
- Defect 30122  [M2] Report part is empty when switching to Layout Designer
- Defect 30120  Copy Management : Application feature not working as expected
- Defect 30119  Getting 'No records found' when we remove a column from report part.
- Defect 30113  Changing filter values are not acknowledged in email and schedule
- Defect 30112  Dashboard : Issue with Report loading at first attempt
- Defect 30089  [RD2] [Report] Save button is not working on Permission Page, If I update the access rights
- Defect 30084  Adding a report part in M2 and saving the report throws error
- Defect 30083  Empty Categories gets auto-deleted if we import a report in different Category.
- Defect 30079  [M3] If edit the sharing of report and use different delivery method then it's showing notification email is required
- Defect 30078  After refreshing any page of RD2.0, the first step shows for few seconds
- Defect 30066  JS error when populating filters on M3
- Defect 30037  [MAP] Map is not working accurately
- Defect 30024   Legacy and RD2: Conditional Formatting; Value range for digits >=4 gets empty but the value is retained.
- Defect 30022  Fields are not retained in M1S3 when added from M1S2 step
- Defect 30008  [RD2]Unwanted pop up is showing when click on edit/close/cancel button of report from report List
- Defect 30003  Allow nulls checkbox in report designer doesn't reflect value from definition
- Defect 29976  Improvements to the functionality of starting and configuring workers
- Defect 29973  [RD2]Global Report is not accessible at tenant users
- Defect 29969  Reports are not shown in Uncategorized if 'Allow Reports and Dashboards to inherit Category Access Rights' is enabled
- Defect 29963  Clear filter from report designer also resets filter operator
- Defect 29961  Self-Join relationship cannot be selected in the classic report designer
- Defect 29960  Switching to preview record to more than 100 gives 'There is an error when querying data’  error in PGSQL.
- Defect 29939  [M3] Subscription filters are not populated with correct values after saving
- Defect 29938  Export with microservice has some cutoff in PDF export
- Defect 29935  Validation Issue while switching between Tenants & System
- Defect 29934  [M3] User search freezes the page on lazy loading
- Defect 29932  Access Rights Permission not working correctly.
- Defect 29931  [RD-2][All Report-Parts] Blank display in report designer on removing fields from Values container.
- Defect 29928  [M3] Link is generated without filters when sending report by email for the second time
- Defect 29927  [RD-2][All Report-Parts][Styling-Tab] UI breaks for report designer when "Item(s) Per Row" is reduced to 1.
- Defect 29926  Defect List for Category Permission access
- Defect 29921  [RD2.0 and classic designer] It is not possible to apply 'End by' if 'End after' has been previously selected
- Defect 29920  [RD2.0] Layouts are not copied when copying reports from Report List
- Defect 29919  [M1S1] Fields are not marked as checked, although they are added to report parts
- Defect 29916  [M2]: Issues with Header Properties
- Defect 29915  [M2] Header and footer Title Issues.
- Defect 29914  [Report]Not able to save a relationship report
- Defect 29913  [All Report-Parts][Properties-Tab][RD-2] Extra option(Blank) in Functions drop-down, breaking the rendering of reports
- Defect 29911  Izenda v4.0.1 - Access Rights saving/updating UI issue
- Defect 29910  Email subscription input displaying blank values.
- Defect 29908  [M3] Warning message appears even if there is no any changes when try to email the report
- Defect 29906  [External Role API] preventReportSharing permission missing from permission builder
- Defect 29904  [M2][Layout Designer page] Grid Enhancement feature breaks on UI front
- Defect 29903  When clicked on 'Schedule' button without filling all the mandatory fields; email sent message notification appears.
- Defect 29899  Pie/Funnel Chart with Separator fails to Export.
- Defect 29893  Zero State image of all charts not in Centre for middle panel in qasql1 env
- Defect 29890  [M2] Layout Designer - Re-Adding Removed Visualizations
- Defect 29888  Relationship between data sources is not getting reset after removing report part
- Defect 29885  [All Charts]: Issue with chart rendering for following scenarios.
- Defect 29882  [Pie: Styling] : Bottom x% is missing in ‘Grouping’ section.
- Defect 29877  [Schedule][Delivery] Not able to click Recipient plus icon
- Defect 29875  [ReportPart] Not able to save report part name
- Defect 29872  [Filters] Page showing blank after select Equal(Popup) option from filters
- Defect 29869  [M3] 'Grant permission' button still clickable even when looks like disabled
- Defect 29866  [All Charts][RD-2] Modal closes by itself for Static and Dynamic Type Thresholds setting
- Defect 29864  [M3][Time Format][Schedule] Invalid format takes in time field text box
- Defect 29862  Recurring Schedule throws error with unsaved filter
- Defect 29861  Filters are not applied when email delivery type is link
- Defect 29856  [RD2] Custom Recurrence reports not being received
- Defect 29853  Incorrect Default zero state image is displayed for Horizontal Grid
- Defect 29852  No default image is displayed when moving from Drilldown to Vertical grid
- Defect 29851  [All Charts][RD-2] Some Validations missing for Datatype in Visualizations
- Defect 29834  M1S3: Image size is not proper for zero state Combination charts in qasql1 env
- Defect 29821  [RD2.0 and classic designer] Pivot bugs
- Defect 29819  [M3] Internal server error when sending emails with unsaved filters
- Defect 29818  [M3] Internal server error when validating schedule item with unsaved filters
- Defect 29807  [M1S3]: When any report is saved on Zero state, the default image is changed to circle.
- Defect 29805  M1S3- Adding field property and function to a horizontal grid displays a default blank grid
- Defect 29804  M1S2 - Adding function to a field is not displaying any records.
- Defect 29803  RD2- No Records are found when the user clicks on Next button quickly from M1S1
- Defect 29802  [M3] : When clicked on Schedule multiple times, multiple blank entry for schedule is created in Sharing tab.
- Defect 29801  [M3] : While Sending email, email body shows HTML content of email.
- Defect 29780  Triple dot loading indicator showing in report list indefinitely
- Defect 29778  [M3] Unable to add sharing instance for a saved report
- Defect 29777  Report Created in RD2 does not redirect to new RD2 UI from the report list (Quick Edit)
- Defect 29775  [M3] Invalid Date Format appears for sharing instances
- Defect 29770  [M3] Email Settings validation missing in Share & Schedule
- Defect 29753  RD2-M1S3 - Applying visualization to the field with functions shows no records found
- Defect 29748  Show Filters Aren't Displaying in Export through API when using UseLegacyMhtExcelExport
- Defect 29747  Global reports fail to validate on tenant level with v3.11.4.2
- Defect 29743  Issue with Schedules set up prior before Daylight Savings
- Defect 29742  [M3] RD2- Tenant option is not appearing in the dropdown when selecting permissions for Global Report like in Legacy flow.
- Defect 29735  Facing issue in exporting with Pivot grid report type which causes memory leakage problem.
- Defect 29733  Setting stored procedure parameter as non-visible in Data Model causes report to be invalid
- Defect 29703  API crashes when viewing or exporting some reports with certain amount of columns
- Defect 29670  Getting Error at Nlq Service When Creating Relationships in the Data Model
- Defect 29635  Error on 4.0 resources with Fresh Oracle DB
- Defect 29591  Add Loading states in RD 2.0
- Defect 29590  Some of the Report Part takes very long time to load in Design layout
- Defect 29589  Categories not carried to new tenant when using data model import/export
- Defect 29586  Category Permissions - Issue in pre-populating roles
- Defect 29570  [RD2 M1S2] Two scroll bars on filter panel
- Defect 29569  [RD2 M1S1] Search icon incorrect positioning - Edge
- Defect 29553  Caching Issues for Category Permissions Scenarios
- Defect 29551  Unable to download the particular report in Izenda
- Defect 29536  Border thickness is not getting updated for KPI reports
- Defect 29535  [Report] [Dashboard] Category permission default access rights not working accurately
- Defect 29534  Retaining the setting of M1S2 page movement
- Defect 29533  Renaming a report part to same name it was before in M1S2 page is successful as per below scenario.
- Defect 29530  Investigate Permission Error seen in calling the API for categories.
- Defect 29517  M1S2 and M1S3 navigation link to be green after editing the saved report
- Defect 29472  Grid/visualiztion is reloading every time you swap your field selection in the Field Properties panel in M1S3
- Defect 29444  Facing issue with Global categories duplicate categories are created
- Defect 29322  System/Tenant toggle remains enabled in the report designer process
- Defect 29321  Autofill in Email/Scheduler is not working
- Defect 29255  Microsoft Edge - function drop down from grid headers is misaligned
- Defect 29254  Microsoft Edge - M1S2 There is a space between table header and table body
- Defect 29176  Improve performance of /user/load endpoint (continuation of ticket ICS-13088)
- Defect 29128  Adjust the font size on the warning message to match the UI
- Defect 29101  Responsive issue for lower screen resolution
- Defect 28949  Subreports are not working
- Defect 28947  Sub and Grand Total Properties are not working
- Defect 28575  'Distinct' expression used in subtotal function is throwing incorrect value on exporting
- Defect 28524  [Report Viewer] Clear Filter clears all filters even if they are non-visible and hidden
- Defect 28428  Date format on Excel and CSV export does not match with the user profile's date format.
- Defect 28093  Convert Null to Empty String does not work for Calculated Fields in Fusion Engine
- Defect 28009  Duplicate Entry of User in same tenant
- Defect 27895  Font defaults to Times Roman when editing XY Plane for charts


v3.13.0 Core Release -- April 13th, 2021
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

FIXES
^^^^^
 - Defect 29779  Async export throws permission error when global report exported from tenant level
 - Defect 29773  Issue with print and Exports
 - Defect 29761  Async Exporting is not working showing always be in pending state
 - Defect 29756  Not able to type email in the email field
 - Defect 29754  Image report parts are not getting exported in DM1 and DM3
 - Defect 29752  Generic application error when exporting data-model.
 - Defect 29744  Prevent Report Sharing Based on Category Accessibility is Adding Categories by Default
 - Defect 29735  Facing issue in exporting with Pivot grid report type which causes memory leakage problem.
 - Defect 29703  API crashes when viewing or exporting some reports with a certain amount of columns
 - Defect 29702  Unable to Save Workspace
 - Defect 29695  Not able to configure PGSQL config db on qa env
 - Defect 29693  Image Orientation Changes When Exporting
 - Defect 29682  Some values in the In Time Period filter throws error when using Snowflake connection
 - Defect 29675  Issue with getting workers from worker pool
 - Defect 29664  Report search does not work for some languages
 - Defect 29663  Update Async exporting worker jobs with new internal values after change and additional logging
 - Defect 29643  Error when saving new report using Azure MySQL as config database
 - Defect 29633  Error on Fresh Oracle Config DB while provisioning DB on 3.12
 - Defect 29629  Not able to create dashboard, getting generic error
 - Defect 29605  Emails/Schedule is not working with Oracle Config DB
 - Defect 29604  No Exporting Queue seen in Export Manager using Oracle Config DB
 - Defect 29595  Apply Filter Button is not working in the Reports (MVCStarterKit DM1 Mode)
 - Defect 29592  Error when saving report with PGSQL config database and v3.12.0.3
 - Defect 29583  Some Queries not working for Natural Search
 - Defect 29531  Embedded Subreports Not Displayed in Exports
 - Defect 29522  Functionality breaks For % of Subtotal and Grand total for Date/Time field
 - Defect 29499  Compatibility issue for QueueWorkers class in Izenda with the npgsql driver: “Job QueueWorkers"
 - Defect 29498  Issue with Load balanced for task queue job in  Quartz/ADO Job Store is used
 - Defect 29489  Form report export as Excel format does not preserve values
 - Defect 29469  Dashboard Loading is too slow
 - Defect 29440  Data Source Name set incorrectly when join has an alias
 - Defect 29429  Filter values are not applied for async exporting if export runs from Report Viewer
 - Defect 29367  Copy Management - Stored Procedure's Filter Value Mapping Not Copied Correctly
 - Defect 29360  Field Comparison Filter Breaks On Comparing Calculated Fields
 - Defect 29332  Visibility of SubReport in Report Viewer and in PDF is not consistent.
 - Defect 29285  Date field in a Snowflake-based custom view produces an error on the view create / edit.
 - Defect 29250  "izenda-root" ID on the main container for the embedded Izenda UI is not dynamic starting from 3.11
 - Defect 29226  Modal for Configure Password Option never Resets.
 - Defect 29225  Report with pivot table and boolean filter fails
 - Defect 29192  Export Manager does not display any results and error in log 'Cannot perform runtime binding on a null reference ' with PGSQL.
 - Defect 29180  Dashboard list reports are not visible to other Users except admin user.
 - Defect 29135  Add Predicted Field Button is not working
 - Defect 29134  State does not change after saving the function
 - Defect 29038  Font is not bold by default on Subtotals
 - Defect 28983  Reports Filter are not working properly while using Postgres DB
 - Defect 28982  Emailing Link type with filter values containing space character doesn't get URL encoded correctly
 - Defect 28967  Background image and added Image-Tile not visible in PDF export
 - Defect 28963  Reports and Sub Reports Created Via Copy Management Does Not Work Correctly
 - Defect 28950  OnExecuting IAdHocExtension not picking up SP param value with filter lookup applied
 - Defect 28944  SQL Query Error for the Turkish Language
 - Defect 28936  Issue rendering data for Maps
 - Defect 28924  Autofill in E-mail(Report/Dashboard) is not working
 - Defect 28915  Cascading filters don't reset when value is updated in cascading filter for some scenarios.
 - Defect 28902  Dashboard filter not loading all filter values if report filter pre-populated
 - Defect 28897  Lazy loading of filter values hangs on scroll
 - Defect 28895  freezing issue while scrolling lookup based filter
 - Defect 28873  Filters autocomplete does not work correctly for dates in fusion and fusion based connectors
 - Defect 28853  Viewer and Designer do not match when utilizing Japanese and specific filter type
 - Defect 28849  Copy Management clears the filter values.
 - Defect 28845  Date Formats with the month name are displayed in the user's language correctly in export but not the report viewer/designer
 - Defect 28838  Opening sub-report configured with Link (same window) having issues
 - Defect 28729  Excel exports taking longer to complete from version 3.2 to latest
 - Defect 28679  Izenda 3.10.5 throws data source validation error while editing the report
 - Defect 28644  ModifiedBy is not updated in the IzendaSubscription table when adjusting a user's schedule as an Admin
 - Defect 28551  Asynchronous Exporting - when report is modified (report part added/removed) the modified report doesn't go through asynchronous process
 - Defect 28550  Asynchronous Exports: Same report with same exporting type is exported multiple times
 - Defect 28243  Autofill in E-mail Scheduler no longer working
 - Defect 27230  Grid Report Part has layout issues when null values in the entire row
 - Defect 25101  UI issue with 'Show Filters' in Edge
 - Defect 22544  Length of the Current Date Time input box different from others.


v4.0.1 Minor Preview Release -- April 6th, 2021
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- Filter Logic Added to Beta Report Designer 
   - A new option is added to the filter panel that opens a modal for users to input a string for their filter logic
   - The expressions for this string of text are the same as the legacy report designer
- Zero States Added to Beta Report Designer
   - Placeholder images are added to visualizations when users select them before adding fields to their visualization
- Warning Messages Added to Beta Report Designer
   - Warning messages will be shown in the report designer/viewer when a layout for the report is not created

FIXES
^^^^^
- Defect 29487  Format function dropdown was not appearing for string datatypes 
- Defect 29675  Process fails to gets workers from the worker Polynomial


v4.0.0 (Beta) Major Release – March 24th, 2021
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Breaking Changes
^^^^^^^^^^^^^^^^^^^^^^^^^^^

- Front-end Updates
   - Izenda Front-end is updated to React 16.2 and other dependencies 
- .Net Core 3.1 Update
   - Izneda API framework is updated from .netcore 2.2 to .netcore 3.1, also the .net full framework is no longer supported for the 4.x.x version  
- Exporting Engine 
   - Izenda has updated the exporting process from WebKit to the Blink Engine
- Map Provisioning Changes
   - The Izenda data structure for mapping data points has been updated for better performance, so map data must be re-provisioned within your Izenda instance
- Encryption Changes
   - Izenda's encryption algorithm has been updated from 128 bit to 256 bit to support FIPS compliance
- Excel Driver
   - Izenda has internalized the Excel driver and as a result, some pre-existing reports may be impacted by this change

FEATURES
^^^^^^^^^
- New Report Designer (Beta)
   - A new report designer can be enabled/disabled with the Report Designer 2.0 permission at the tenant or role level
   - Functional Limitations of the new designer include:
      - Report header/footer is not currently supported
      - Opening legacy reports in the new designer is not currently supported
      - It only supports the following visualizations:
         - Vertical Grids, Horizontal Grids, Line Charts, and Column Charts
   - For more overview information on the new designer, see our :ref:`Docs_2.0` page
- Exporting Microservice (Beta)
   - Exporting functionalities can now leverage the new web engine and a scalable node-based solution
   - For more information, please see the :ref:`Export_Micero_Service` page
- Scheduled Task Queue
   - A new scalable solution is present to handle alerts and subscriptions that start at the same time so they may be performed sequentially and avoid overloading the server
   - For information on this process, please see our :ref:`Heavy_Load_Queue_` page

FIXES
^^^^^
- Defect 23619  Unhandled Exception Error is thrown when the report part width is not set
- Defect 27386  Drilldown to city level in maps takes a very long time to load
- Defect 28131  Blink - Exporting Chart report parts to Word and Excel looks stretched
- Defect 28548  Asynchronous Exporting fails with Azure File Services storage option
- Defect 28639  Checkboxes in Forms overlap when Exported to PDF 
- Defect 28729  Excel exports taking longer to complete from version 3.2 to latest
- Defect 29017  Pdf export issue in embedded report
- Defect 29021  Role dropdown not appearing when user is set as System Admin
- Defect 29042  Internal server error is thrown while registering a user.
- Defect 29043  Unable to Create/Save Grid Report part
- Defect 29044  Environment freezes when any data source is selected
- Defect 29045  Blank page is appearing after selecting data source.
- Defect 29046  Unable to Edit the Report and/or Navigate to other application pages
- Defect 29047  Logs missing from Izenda log file in linux environments
- Defect 29048  Not able to edit Dashboard Name
- Defect 29050  UI is unresponsive on Tenant Setup Page
- Defect 29054  Notification bell not clickable
- Defect 29056  Unable to add Excel and REST Connectors
- Defect 29058  Join Field and Field dropdowns not working
- Defect 29066  Not able to configure NLQ
- Defect 29067  Data/Map not populating the records and fails to render the Map when saving the report
- Defect 29070  Generate Password link not getting populated during user setup
- Defect 29071  Charts are not working for TreeMap D3/Column Donut/3D Scatter visualizations
- Defect 29072  Issue with Data Connector Page and Add Connector Functionality not loading properly
- Defect 29074  Subreport functionality is not working
- Defect 29076  Copy Management is not copying settings options
- Defect 29077  Creating report as tenant causes page to go blank
- Defect 29082  Not able to apply online licenses form settings page
- Defect 29087  Export functionality not working in Full Framework
- Defect 29088  Not getting save notification on data model page after clicking on Save Button.
- Defect 29089  Blank page appears after clicking on system variables while adding schedules.
- Defect 29090  UI is not proper when we open edit dropdown in a dashboard.
- Defect 29091  Getting system admin error on saving dashboard after making changes to filter
- Defect 29092  Dashboard report filter is not showing all values.
- Defect 29093  UI issue with quick edit mode of report part
- Defect 29094  Getting error after editing the query limit in advanced settings.
- Defect 29095  After activating the user from deactivation, the text still shows 'Activate' despite being an active user account.
- Defect 29096  Blank page appears when configuring within the border cog in Report Part Properties.
- Defect 29097  Not able to use border properties on Form report
- Defect 29098  Applying text or background color to field values breaks form reports
- Defect 29111  Getting Custom report part types in dropdown of report parts while creating a new report
- Defect 29112  Page is blank after adding add calculated field from report designer
- Defect 29113  Page is Blank after clicking on Border setting icon from report part properties
- Defect 29115  Blank page appears after quick edit mode selection
- Defect 29116  Getting error messages when creating a Gauge report.
- Defect 29136  Table selection checkbox is not checked when all the columns are selected
- Defect 29137  Conditional formatting breaks for prints and exports when blank values are present 
- Defect 29138  Blank page appears when we search data source in middle panel on report designer page
- Defect 29141  Not able to create a report at the tenant level as a system admin
- Defect 29142  While Saving a KPI report, save pop up takes too long to disappear.
- Defect 29151  Bell Notification appears but does not populate records when clicked during the NLQ process
- Defect 29159  Getting system admin error for changing passwords
- Defect 29160  Blank page appears after clicking on Search on Scheduling page
- Defect 29164  After clicking on Report viewer, page goes blank.
- Defect 29165  Reports in Dashboard from NLQ are not getting saved in Linux environments
- Defect 29178  Getting Application error while saving the report
- Defect 29181  Items missing on explore page of NLQ.
- Defect 29183  Page is blank after searching any column name from report designer
- Defect 29192  Export Manager does not display any results and error in log 'Cannot perform runtime binding on a null reference' with PGSQL.
- Defect 29209  'Any unsaved changes will be lost' pop-up never appears if navigating without saving a report
- Defect 29226  Modal for Configure Password Option never Resets during the user setup process.
- Defect 29240  Popup subreport is blank
- Defect 29272  Copy Management crashes when switching workspaces
- Defect 29275  Import Functionality not working properly.
- Defect 29276  Application Error when sending email through Report Viewer/Dashboard
- Defect 29277  Emails for both Subscribe and Schedule are not getting received/sent
- Defect 29299  Able to save template under tenant without template access
- Defect 29303  Unable to create Map other than Google Map on Linux environments
- Defect 29304  Alternative Text is not applied to the field
- Defect 29315  Changed Value for Eviction Interval at System Cache Configuration is not persisting
- Defect 29316  "Are you sure? All your changes will be lost." pop-up appears without having any changes in the data model
- Defect 29324  Some areas remain unchanged with having language packs enabled
- Defect 29329  Screen goes blank when "Show only my workspaces" is checked on the copy management page.
- Defect 29330  Getting pop up while moving from Report viewer to designer with no changes made to the report on Linux environments.
- Defect 29331  Filter values gets appended with Column names when any filter is applied on Linux environments.
- Defect 29342  Unable to create any report, getting System Admin error as we click design tab
- Defect 29344  Pop up for successful email delivery is displayed for Unsaved dashboards.
- Defect 29346  Extra/Duplicate Checkbox for Remove Extra Side Total Column(s) is appearing on UI.
- Defect 29347  Exporting fails for reports with Headers & footer enabled from exporting tab
- Defect 29348  Embedded Report preview is not visible in Form report part
- Defect 29377  Country map never renders in print and exports
- Defect 29386  Screen goes to blank state if we drill-down over maps
- Defect 29403  Notification pop up is not proper.
- Defect 29404  Reports in NLQ are not getting saved.
- Defect 29405  Header and Footer if added to report should be visible by default on Report viewer.
- Defect 29422  Calculated html is not rendering correctly on forms
- Defect 29429  Filter values are not applied for async exporting if export runs from Report Viewer
- Defect 29431  White background on an image tile is not getting covered up in report viewer
- Defect 29435  Cannot edit calculated fields in legacy Report Designer
- Defect 29437  Getting 500 Internal Server error on Report list page
- Defect 29438  Able to add some text values after decimal in thickness text box while applying borders.
- Defect 29439  Lazy loading of filter values does not work
- Defect 29445  Screen goes Blank on adding filters to a recently created report.
- Defect 29446  Extra/duplicate entry for Google map is listed in Map Type
- Defect 29447  Application error appear on UI when creating any report part with Mongo datasources
- Defect 29448  Unable to add Salesforce connector
- Defect 29463  Settings page loads with Advanced Settings for user who does not have access
- Defect 29469  Dashboard Loading is too slow
- Defect 29494  Page showing blank when adding same excel data Connector again
- Defect 29496  Not able to create a report from form Report part.
- Defect 29499  Compatibility issue for QueueWorkers class in Izenda with the npgsql driver: “Job QueueWorkers"
- Defect 29503  API for create schema is failing
- Defect 29515  Export deployment issues
- Defect 29521  ave Notification pop up not appears next time, if I click on Save button.
- Defect 29544  IzendaCoreCustomBootstrapper is not working with .NetCore31 updates
- Defect 29561  Missing functionality for deleting export items in Export Manager
- Defect 29563  Unable to create any report, getting System Admin error as we click design tab
- Defect 29565  Not able to login on qa2 env
- Defect 29575  Unable to create Map other than Google Map
- Defect 29585  Settings copy from system to tenant throws error on UI
- Defect 29592  Error when saving report with PGSQL config database and v3.12.0.3
- Defect 29597  Map Always keeps loading in case of World/Continent/Country map
- Defect 29600  Disabling License status doesn't block the Reports and Dashboard
- Defect 29601  Supervisor service fails to start dotnet process
- Defect 29679  Options other than System DB & License are not accessible.
- Defect 29680  Issues with Exporting for all report parts


v3.12.0 Core Release -- January 15th, 2021
~~~~~~~~~~~~~~~~~~~~~~~~~~~


FEATURES
^^^^^^^^^

- Subtotal and Grand Total formatting for Grids 
   - When configuring either a subtotal or a grand total, additional options are shown in the configuration modal
   - These options allow a user to configure basic font settings for these totals:
      - Font Family
      - Font Size
      - Bold, Italics, and Underlining
      - Font Color
      - Text Highlight Color
- Which day marks the beginning of the week can now be configured per tenant
   - Under Settings > Data Setup > Advanced Settings > Others a new section 'Configure Period' has been created
   - This dropdown will let users mark which day is the beginning of the week for that tenant.
- Improvements to error messaging during role deletion
   - When deleting a role that would result in a category access conflict for any users, a new error message will outline the conflict areas
   - The modal will display the category name and report name for any reports which must be deleted or moved to allow the role to be deleted or removed from a user
- Pie, donut, and funnel charts can now display value field names under the visualization 
   - A new checkbox is added to the Report Part Properties of these charts 'Show Value Field Names'
   - When checked, the underlying field name(s) used in the values container will be displayed below the chart (ex. Count(Ship_Country))
   

FIXES
^^^^^
- Defect 25083  Exporting in PDF formats caused a webpage conversion error
- Defect 25526  TEXT and NTEXT fields (SQL SERVER) are not being queried correctly when there is a repeater in a form.
- Defect 26493  Excel/word exports on certain azure windows instances fail to print angled labels
- Defect 26501  Exporting dashboard to PDF fails with a certain number of charts
- Defect 27395  Izenda Report Design space falls out of the root container
- Defect 27798  Dashboard background image or color disrupts buttons
- Defect 28011  [KPI] Text in Text-Tile doesn't adjust when reducing font size from already exceeding value
- Defect 28016  [KPI][Image-Tile] Number of Rows/Columns show incorrectly in Preview Mode for KPI Grid
- Defect 28017  [KPI][Text-Tile] Number of Rows/Columns show incorrectly in Preview Mode for KPI Grid
- Defect 28020  Data Model Search button not working
- Defect 28094  [KPI][Metric-Tile] 'Can't draw chart' appears in Metric-Tile when changing No. of Rows/Columns/Cell-size(px)
- Defect 28096  [KPI][Metric-Tile] Added Field text does not adjust for some Font-Type and/or Text Formatting
- Defect 28112  [KPI][All-Tiles][Re-sizing] Number of Rows/Columns show incorrectly in Preview Mode for KPI Grid
- Defect 28130  Angular framework does not allow Izenda BI front-end to render Google maps after 3.8.2 update
- Defect 28146  [KPI][Metric-Tile] Metric-Tile is getting cut-off/not visible completely in Report Viewer.
- Defect 28155  [KPI][Field Properties] Metric-Tile/App Functionality breaks when applying Custom Formats
- Defect 28156  [KPI][Report Designer Context Menu] Context Menu options/Drop-down gets hidden when adding another Tile with having any existing Tile
- Defect 28185  [Role Setup] Permissions are not inherited from Tenant when creating new Role
- Defect 28189  The system would fail to find the file path for disk cache configurations
- Defect 28207  Disable access rights controls of global reports for tenant users
- Defect 28208  Dashboard Edit>"Set Background Color" button is not working, JS failure and a console error when using Oracle Db.
- Defect 28239  Chart exporting does not work in modern component based web framework applications
- Defect 28244  Dimensions of Logo images imported from old version are not properly set but fixed as 1 by 1
- Defect 28256  Embedded Report preview is not visible in Form Report Designer and Report Viewer
- Defect 28258  Filter auto-complete does not show narrowed results when filter lookup is applied
- Defect 28270  Users with Access to Report Designer But Not Create New Report Are Unable to Add Stored Procedures
- Defect 28271  CSS Overrides Main Body and Tags for Embedded instances of Izenda
- Defect 28296  [KPI][Metric-Tile] Metric-Tile becomes un-responsive when changing/applying any option under Data Formatting.
- Defect 28303  IAdHoc extension doesn't affect on Report definition(Title, Description and Report Name) in email when sending an email from Report list.
- Defect 28310  [KPI][Background-Images] Background Image does not show up in Report Designer Configuration Mode.
- Defect 28317  Applying Conditional Formatting hangs in a certain condition
- Defect 28410  No Error Displayed When Importing Converted Izenda 6 Reports If View Doesn't Exist in Environment
- Defect 28412  Error when importing data model bidm file to system level
- Defect 28417  Some areas of application do not change with language packs enabled
- Defect 28469  X-Frame-Options Response Header Prevents visualizations to display in PDF Exports
- Defect 28492  Custom format is not applied in chart / gauge type
- Defect 28521  [PII] PII/Data Security - Stack Overflow issue in code for applying rules to calculated fields
- Defect 28522  [PII] PII/Data Security rules are not getting applied if report contains subtotal, grand total
- Defect 28523  [PII] PII/Data Security rules do not apply to Side Totals
- Defect 28542  Visual Tab in Form Designer is not using the entire space to render elements
- Defect 28557  SyncFusion taking too much memory
- Defect 28569  Adding new Dashboard part gives exception "ERROR: Conversion failed when converting from a character string to uniqueidentifier" in log and unable to save the report
- Defect 28571  [Copy-Management] UI breaks and application hangs when "Show only my workspaces" is checked.
- Defect 28578  Excel/Word Export Error with Report Headers
- Defect 28617  Another user Modified Data Error occurs when updating Advanced Setting in Tenant
- Defect 28624  Unable to import reports from 6 Series
- Defect 28625  Unable to import reports from 6 Series that have a dot (.) character in column names
- Defect 28640  Key join operator not selected after import
- Defect 28649  Full Report & Dashboard Access Not Set if Grant Full Report & Dashboard Access is enabled
- Defect 28660  Filter Equivalence - Equals(tree) select [All] chart type export from report list bug
- Defect 28671  Syncfusion Memory leak due to failing exports [Syncfusion 304080 ]
- Defect 28718  Unable to scroll down in certain situations on a filter
- Defect 28733  [Drilldown report/ dashboard]: Printing and PDF Exporting giving error with all rows shown as in viewer for Drilldown
- Defect 28739  [KPI-Reports] Any unsaved Changes Confirmation message pop-up always appears to confirm and save modifications even if all changes are applied and saved
- Defect 28740  [EXPORTs] Issue with Exports Reports, failing for PDF and for other report parts including KPI "The Picture can't be displayed" is being displayed.
- Defect 28741  [KPI][Preview-Grid] KPI Preview Grid shrinks beyond the minimum area required to showcase added tile(s)
- Defect 28747  [KPI][Dashboard] UI issue in Metric-Tile and in Placement of Title and Description.
- Defect 28772  Non-cascading filters clear out the following filters
- Defect 28778  Unable to print two report on tenant level
- Defect 28785  Dashboard error with filtered report parts
- Defect 28790  Filter selection - values are not populated out of PostgreSQL in Iz3.11.2
- Defect 28835  [KPI]: Report part properties text is trimming
- Defect 28839  Oracle and Excel adapter are broken in  - Defect 27680
- Defect 28844  [KPI][Exports] Issue with placement of Title & Description when performing Exports.
- Defect 28851  Cannot import reports with calculated fields
- Defect 28853  Viewer and Designer do not match when utilizing Japanese language resources with specific filter types
- Defect 28857  [KPI][Transparency] Metric Tile does not follow the transparency flow and fails for Print and Exports
- Defect 28895  UI freezes when scrolling with a filter using a configured lookup value 
- Defect 28969  [KPI][Text-Tile] Applied settings under Format are not getting respected upon saving a report
- Defect 28977  Grand total and Sub total formatting not getting respected in Print and Exports
- Defect 28978  Unable to access BI application in IE browser.
- Defect 28985  Issues with Asynchronous Export: not working properly
- Defect 28986  Server showing blank after changing a language in hindi/arabic
- Defect 29001  Eviction Interval at System Cache Configuration is not saved
- Defect 29007  Blank pop up warning modal is displayed when navigating away from Import page
- Defect 29014  Grand Total Label Position is not getting changed as mentioned in settings.
- Defect 29016  UI breaks when we scroll the right panel of configuartion settings.
- Defect 29020  [Export] Pivot Report Side Total value is not reflected correctly while exporting in WORD/CSV
- Defect 29022  'Bold' font style is automatically selected even after removing it in Subtotals
- Defect 29049  Email clients do not support SVG images
- Defect 29068  Subscription email is not being delivered to end user
- Defect 29099  Dashboard PDF export results in error on 3.12



v3.11.4 Preview Release -- December 24th, 2020
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- Displaying Form CSS in Exports
- Display Field Names Under Pie Charts
- Remove extra Side/Sub Total columns in Pivot Grids
- Asynchronous Exporting Improvements 
    - Node-based Deployment Support
- Show grid headers at the top of the report for exports 
- Routine data deletion frequency can be configured
- Dashboards will only display the current slide in Full-Screen Mode
- Remove Inactive/Deleted Users from Email events
- Exporting no longer leverages Iframes for image generation
- Improved filter query performance 
- Allow conditional formatting against null/blank values
- Improvements to Category and Report Sharing/Accessibility 


v3.11.3 Preview Release -- December 8th, 2020
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- KPI Report Parts Added as Unique Visualization Type
   - KPIs are now built as a separate report part type
   - This report part type allows for users to input metric, text, and image tiles in a unique layout editor
   - For more information please see the :ref:`KPI_User_Guide` 

v3.11.2 Preview Release -- November 11th, 2020
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- PostgreSQL support for NLQ 
   - NLQ services can now be configured against PostgreSQL data sources
- NLQ Supports Multi-Tenancy
   - NLQ services can be configured on a per-tenant basis 
   - This configuration can be manipulated by the administrator on a tenant's behalf
   - Note that the Explore tab does not support changing tenancy, as mutli-tenancy is only at the configuration level
- NLQ Grid Enhancements 
   - Column headers can now be used to apply formats and functions to each column
   - This will allow users to sum, count, etc. directly on the grid 
- For more information on NLQ please see our :ref:`NLQ_User_Guide`


v3.11.1 Preview Release -- October 30th, 2020
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- NancyFX Update
   - Our NancyFx dlls are updated to remove potential security threats. 
   - Both AspNet and AspNetCore versions will contain these updates. 

v3.11.0 Core Release -- October 23rd, 2020
~~~~~~~~~~~~~~~~~~~~~~~~~~~

.. warning::

   There are known CSS issues that may impact the main and body tags of integrated environments. These issues are being addressed in upcoming hotfix releases. Please contact support@izenda.com if you experience any 


FEATURES
^^^^^^^^^
- PII Security Options
   - A new dialogue can be found in the Data Setup > Advanced Settings > Security
   - This dialogue will allow administrators to restrict how data is viewed internally and externally within the platform
   - Information on configuring these rules can be found on the :ref:`Advanced_Settings` page
- Configuring Temporary Export Files
   - A new value, ExportingTempPath, has been added to the IzendaSystemSetting table
   - This value will dictate the location where Izenda temporarily stores files during the export process
   - The default value can be changed to store these files in a different file path
   - By default, these files will be stored within the Export folder of the Izenda API resources
- Combination Chart Selective Axis
   - When creating a combination chart, users can now dictate which metrics should share an axis to avoid Apply_Cross_Filtering_to_Multiple_Report_Parts
   - This is configured within the advanced options of each metric independently

FIXES
^^^^^
- Defect 21496  Form smart tags use the wrong format when exporting/printing Date Time 
- Defect 21752  Email To and CC fields do not close when user hits tab
- Defect 23160  Izenda query taking long time to run against Azure DBs
- Defect 24222  Can not search in Dashboard when navigating to parent categories
- Defect 24601  Switching Filter Options Does not persist the filter value
- Defect 25486  Subtotals do not work in IE
- Defect 25692  Subreport(link) disabled when user changes column width through report viewer and can't save it
- Defect 25862  Subtotals do not work for Rows in pivots if there is more than one column
- Defect 25904  [Role Setup] Full Report and Dashboard Access permission is still true when tenant user does not have this permission
- Defect 25918  Invisible filters can be addressed by pN on a report, but not on a dashboard
- Defect 26086  [object Object] displays when an error occurs during emailing unsaved dashboards
- Defect 26087  Export url is not displayed in logs like in previous versions
- Defect 26464  Large filter lists requiring multiple API requests with duplicate values freezes report designer/viewer
- Defect 26537  Report Header Items Missing in Excel Exports (multiple versions)
- Defect 26560  Report header appears twice when exporting
- Defect 26580  Point Options dropdown in maps is empty when using IAdHoc extensions
- Defect 26850  "Next Scheduled Run" is not accurate
- Defect 26894  Calculated Field expression text font not applying as Proxima Nova
- Defect 27068  Unable to remove second metric for solid gauges
- Defect 27070  TCP connect to smtp server sends HELO command and EHLO command
- Defect 27377  AMI EC2 clr process crashes when running 3.7.0 or higher standalone
- Defect 27404  Grid size is flickering when rendering
- Defect 27408  Report Designer Glitches when zooming in Google Chrome
- Defect 27410  hasReportUseRelationship endpoint does not work
- Defect 27424  Subtotal for collapsed All item of drilldown grid is wrong in exported reports
- Defect 27428  Deleting a schedule shows no changes found in UI when paginated
- Defect 27482  Translating the RoleType values in the dropdown
- Defect 27489  Less than Days Old Filter Option returns future dates
- Defect 27507  Global reports no longer showing in report list after upgrade to 3.9.0.9
- Defect 27551  Heat Map Hover Values Displayed Incorrectly
- Defect 27562  Issue Displaying Filter values in filter drop-down
- Defect 27563  Issue with Excel Data Connector when uploading files
- Defect 27569  MongoDB adapter fails when trying to execute a query with more than 100 conditions
- Defect 27583  Unable to edit subtotal when there is a syntax error
- Defect 27620  User should be redirected to the 1st page instead of 'no record found' page for schedules and subscriptions.
- Defect 27628  Filter value in the property section on the string field is throwing exceptions when we use '/' in the Column name.
- Defect 27647  Total sum is not appearing on exporting drilldown report to Pdf/Word/Excel
- Defect 27648  Suspicious side totals values for AVG cells function
- Defect 27658  On the Report viewer, the Donut chart is not appearing unless the item per row is modified from its default value.
- Defect 27673  Existing logo images are not adjusted to their dimension after upgrade to 3.9.X
- Defect 27676  Dashboard save and save as category selection not working in 3.9.0
- Defect 27681  Connector creation popup does not work in IE11
- Defect 27683  Missing detailed errors in logs
- Defect 27685  Issue with Join Aliases and Subkey joins causing query errors
- Defect 27702  Incorrect fonts for buttons in Connection String and License settings
- Defect 27703  Boolean Types field in Materialized Views is missing
- Defect 27735  Selected data sources not maintained when re-navigating to data source tab
- Defect 27775  Email Templates for Different Languages aren't displaying in Subscriptions
- Defect 27785  Date Picker Selects Previous Day
- Defect 27786  Report Filter Info "Display Value" does not show correctly when exported as Excel
- Defect 27803  Excel Exports issue while report created by parameterized SP
- Defect 27804  Subreport ID does not update in Form's HTML after importing
- Defect 27811  Chart legend settings not visible under the certain condition of monitor display settings
- Defect 27812  Access token included in HTML when emailing as Embedded HTML type
- Defect 27819  Subcategory List does not populate when using 'Save As'
- Defect 27821  Different Result Sets When Query Should Be the Same using Key Join Filter Values in a Report
- Defect 27827  Simple gauge word export does not show all content
- Defect 27835  Issue with using DateAdd in a specific calculated field of a report
- Defect 27837  User's list is not populated correctly when using the Email function
- Defect 27887  Saving a subscription with Link delivery type disabled in tenant permissions causes user to be kicked off
- Defect 27890  Filters not applying on the renderReportViewerPage function on v3.10
- Defect 27896  Exporting goes through Asynchronous process when Export Service toggle is disabled
- Defect 27898  Data Model Export API doesn't work after UI implementation
- Defect 27900  Report Logo appears different in exported files than it does from the viewer
- Defect 27902  Frequent 404 errors in 3.10.2
- Defect 27905  CSS Overflow not set for border grid selection popup
- Defect 27918  Pipe '|' symbol in report title prevents search.
- Defect 27926  Exporting Interval set to zero does not display error message
- Defect 27927  Export File Refresh Job Interval time set to zero doesn't display error
- Defect 27936  Izenda passing sql function to Snowflake that don't exist
- Defect 27953  Column are not populated as expected in Grid Report Part of Drill-down type
- Defect 27954  Changes to the query source capitalization do not trigger a data model update
- Defect 27955  Sub report not filtering by the field mapping specified
- Defect 27971  When export fails notification doesn't show failed message
- Defect 27982  Drop-down isn't working for Certain Field Comparison filter types
- Defect 27989  Calculated fields broken after 3.10 upgrade
- Defect 27991  Save As a Report does not remove the pop after save as process is complete
- Defect 27996  Recently exported report should appear on the top of the list in export manager
- Defect 27997  When report fails to export user cannot export the same report again
- Defect 27999  Creating custom views does not work with Snowflake data sources
- Defect 28004  Dashboard error not being displayed
- Defect 28005  Materialized View Mapping Error during Custom View import process
- Defect 28010  Date format not same as showing in Report viewer with excel (after changing the date format from User Setup)
- Defect 28013  Bold toggle button at Header Formatting does not work
- Defect 28015  Form report part PDF/Word export does not preserve font family
- Defect 28027  Items per page is not working in Gauges - when the user edits and saves it says "No changes found"
- Defect 28055  getting error during custom time period filters
- Defect 28057  Eviction Interval at System Cache Configuration is not saved
- Defect 28108  Issue with using datetime fields in calculated fields among with having filters
- Defect 28110  Cannot add Calculated Field if report has filters using aggregated values
- Defect 28117  Missing TenantId field in IzendaNLQSchema table when upgrading the configuration database
- Defect 28132  Applying code modifications from  - Defect 27683 to Snowflake adapter
- Defect 28139  Calculated Field Error: Due to using old NGSQL.dll v4.0.4 
- Defect 28148  Incorrect role permission checkbox state
- Defect 28151  Unable to Adjust Settings in Tenant Roles
- Defect 28166  Custom data format not applied to side total if more than one field in Rows container
- Defect 28167  Role UI issue when switching between System and Tenant context
- Defect 28229  The filter value set up for SP does not work as expected when one value is selected in a filter using a lookup.
- Defect 28244  Dimensions of Logo images imported from old version are not properly set but fixed as 1 by 1
- Defect 28297  Search text box is not working accurately for dashboards
- Defect 28422  IZENDAEXPORTQUEUESETTING table colums throws ORA-00972
- Defect 28482  Print/Export button is not working on the report list.
- Defect 28490  Email is not able to send in Embedded HTML(Delivery Method) Format
- Defect 28494  Query execution is not yielding any results.
- Defect 28512  Function is not able to remove from column after removing it from field properties
- Defect 28516  Getting application encountered an error message on exporting stored procedures
- Defect 28530  [Short Hour/Long Hour] Date Format is not working accurately
- Defect 28537  Snowflake Adapter: filter values are not populated, it only shows Null and Blank in the dropdown.
- Defect 28540  Exported forms do not contain tables in excel
- Defect 28547  Schedule Instance is not saved when created from Dashboard List.
- Defect 28552  When Filter is applied to a report part, it shows 'iteam' as an option.


v3.10.5 Preview Release -- September 25th, 2020
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- Tenant Grouping
   - Tenants have a new value, Tenant Group, that can be applied on the Tenant Setup page
   - Multiple tenants can belong to the same group, but a tenant can only have one tenant group value
   - Tenant Groups can be used to distribute Global Reports in a more streamlined fashion
- Tenant Report Import Functionality
   - Tenant users can now import report definitions into their instance of Izenda
- Required Filter Expansion
   - A new value in our config.json will allow Izenda to automatically expand filter sections if required filters are present
   - This is mused in conjunction with the ReportFilterSectionExpanded value


v3.10.4 Preview Release -- September 8th, 2020
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- Introduced new Asynchronous Export Functionality
    - Izenda will be able to leverage an asynchronous process in order to generate and deliver exported files
    - This setting can be configured on the Settings > System Configuration > Exporting page
    - The Izenda application must be restarted once toggled on in order for the service to be activated
- Export Manager has been added to use profiles
    - This page is under the user profile dropdown list
    - The Export Manager can be rendered via a javascript API
    - The Export Manager will allow a user to easily access their recently exported files
- New Notification Functionality
    - When a user's export is complete, the notification bell at the top-right of the screen will display a notification
    - This will replace the current functionality of the bell icon

v3.10.3 Preview Release -- August 11th, 2020
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- Set Alternative Text against NULL and BLANK values
   - [NULL] and [BLANK] can be set as target values when creating rules
- Combination Charts can display multiple metrics on one shared axis
   - Opening the 'Settings' wheel for any metric will let a user choose which y-axis to use for display purposes
   - Users can choose from any other metric that is currently displayed on the chart
- UserContext can now be set without reloading Izenda components
   - IzendaSynergy.setCurrentUserContext() now accepts a second argument, which will be passed as true/false
   - This parameter, if set to true, will cause the items to be reloaded once the context is set
   - This new value does not have to be set. If not explicitly stated, it is assumed to be false.
   - Please see our - :ref:`Front-end Integration APIs <Frontend_Integration_API>` page for examples
- Snowflake can now be selected as a reporting data source
   - Example connection string: account=xxxx;user=xxxx;password=xxxx;db=xxxx;host=xxxx.east-us-2.azure.snowflakecomputing.com

v3.10.2 Preview Release -- August 3rd, 2020
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- Data Model Import/Export Phase 2
    - UI elements have been added to compliment the APIs release in v3.9.5
    - An 'Export' button is visible to System Admins on the Data Model Page
    - The Import page can be used to import the new data model files

v3.10.1 Preview Release -- July 27th, 2020
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- CustomBootstrapper added for .NET Core Environments
    - The CustomerBootstrapper functionality has been added for .NET Core resources
    - This implementation can be found here: https://github.com/Izenda7Series/CoreIzendaCustomBootstrapper
- New IAdHocExtension Method Added for REST API requests
    - A new method, OnPreRestApiRequest, has been added to the IAdHocExtension class
    - This can be used to modify the request parameters for the REST request before it is sent
- New IAdHocExtension Method Added for Query Optimizations
    - A new method, ModifyQuery, has been added to the IAdHocExtension class
    - This can be used to modify SQL queries run by Izenda to improve performance or meet specific needs
- Configuration Database References Added to the API's appSettings
    - Users can configure these values to allow Izenda to read the configuration database's connection without using the izendadb.config file



v3.10.0 Core Release -- July 16th, 2020
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FIXES
^^^^^
- Defect 23656 International characters not displaying correctly after exporting to CSV
- Defect 23679 Unable to view empty form columns with text header in excel exports
- Defect 24625 Dashboard designer overlay flickers and disappears in DM1 for SPA
- Defect 24784 Extra blank space is present on top of dashboard tiles 
- Defect 24852 Cross filtering is not working on multiple report parts when drilling down on a map
- Defect 25781 Replacing report part on a dashboard causes an error if there is an empty filter
- Defect 25919 Access Defaults duplicates in UI during role setup
- Defect 26158 License key/token accessible from UI when license is in offline mode
- Defect 26261 Izenda standalone API server crashing
- Defect 26269 Charts in Reports and Dashboards when viewed on mobile do not display in a friendly manner
- Defect 26315 Dashboard full screen mode configuration not centered
- Defect 26373 Subscribing with a limited role not consistent between Report List and Report Viewer
- Defect 26445 HTML tags in calculated fields of Form Report Part do not export/print (word)
- Defect 26459 Ajax Settings do not affect api/importManagement/file?batchId request
- Defect 26479 Word wrap in forms shows inconsistent behavior between report viewer and export
- Defect 26535 Changing filter visibility in first filter removes filter values in second filter
- Defect 26547 loadDashboard requested twice when using EmbeddedUI resources
- Defect 26548 Report list/viewer on smaller screens does not contain print or export options
- Defect 26556 Tenant selection dropdown and report/dashboard selection not available on some tablets
- Defect 26561 Dynamic stored procedure fails to move to the design view after updating filters
- Defect 26573 The "No permission" message displayed on dashboard is not sourced from language text file
- Defect 26605 Side total for pivot grid does not reflect the conditional format setting
- Defect 26607 Date isn't kept in filter when manually typing in date values
- Defect 26608 Using custom format with alternative text breaks side totaling
- Defect 26609 Issue with Date Formatting in Excel Exports
- Defect 26639 Values from forms are overlapping when exported. 
- Defect 26640 Exporting empty pivot grid to csv throws error
- Defect 26677 Reports would error when field names contained commas and were used with multi-value inputs
- Defect 26705 IzendaUserRole CreatedBy field doesn't match IzendaUser CreatedBy field
- Defect 26713 Pdf Report content is not fully exported.
- Defect 26715 Filter Value doesn't appear on the report viewer when the "show filter" option is checked.
- Defect 26724 Reports with Stored Procs are invalid if another parameter is added
- Defect 26727 Unsorting a subtotal field causes a query error
- Defect 26730 Custom data formats are not exporting to Excel
- Defect 26807 Maps throwing sql error when city values contain a single quote
- Defect 26842 System Configuration > Report settings are not consistent when switching tenants
- Defect 26849 FIPS issue in 2.18.3 hotfix
- Defect 26851 I-Frames are not displaying report parts when exported.
- Defect 26870 Maps do not drill down or display hover items when using Firefox. 
- Defect 26873 No security check is made for the systemSetting/reset api
- Defect 26874 Custom View Defintions appear in cleartext in responses related to them
- Defect 26879 Users with no data model privileges can delete datasource fields via api
- Defect 26886 Custom Data Format is not applied to Side Total cells in Pivot grid
- Defect 26902 Email attachment type defaults to blank if PDF permissions are missing.
- Defect 26921 Save As category selection displays global after switching between reports and templates
- Defect 26923 Selecting Roboto font shows as Times New Roman
- Defect 26944 Saving connection string with different database users fails and reports a duplicate connection
- Defect 26947 Timezone offsets would influence time values in DateTime fields
- Defect 26971 Custom view fields query not using query timeout advanced setting
- Defect 26975 Issue removing role from user that has created reports
- Defect 26977 Pivot grid does not project well if trying to total the column being pivoted on
- Defect 26983 Exporting through API with filter values in payload not applying for charts
- Defect 26986 Calculated field CASE or IF statement with string literal END throws syntax error
- Defect 27006 Custom Functions not appearing in Subtotal or Grand total
- Defect 27007 Remove extra resources from API resources
- Defect 27021 Drop-down trimming in Forms and Misaligned Boxes in all Report Part Types
- Defect 27039 UI Issues related to copyright text at the left-bottom of the page
- Defect 27044 Alternative Text not working in certain scenarios with grid report parts
- Defect 27051 loadDashboard requested twice when using EmbeddedUI
- Defect 27061 Common filters do not resolve due to outdated operator setting
- Defect 27065 Mongo adapter is broken
- Defect 27088 Displaying GUID and Wrong x,y axis value in the Chart Report
- Defect 27089 System admin subject to tenant-level scheduling limits
- Defect 27090 Filter value on main report isn't passed to required filters on subreport
- Defect 27092 Full Report and Dashboard Access permission does not save as true when saving role
- Defect 27100 Cannot set property 'range' of undefined when using date pickers
- Defect 27111 Required Filters do not display dropdown values when configuring subscriptions.
- Defect 27130 Reports cannot be saved using oracle configuration database
- Defect 27131 Cannot save Postgres connections when stored procedures without parameters are present. 
- Defect 27174 Creating Calculated Field on report designer is cutting off under the list of columns
- Defect 27175 Copying individual reports does not work due to hashing error.
- Defect 27176 Copy Only Settings does not work if source tenant has disabled connections
- Defect 27193 Scroll Bar shifts to left when creating relationship from Data-source page
- Defect 27211 Filter Values Aren't Displayed in Report Viewer when 'Show Filters' is enabled
- Defect 27219 Notification missing when adding, editing, copying or deleting subscriptions/schedules in reports and dashboards
- Defect 27229 Headers Not Displayed with Embedded Subreport
- Defect 27250 Tenants names are displayed outside of the container in Tenant Setup when many Tenants exist
- Defect 27255 Deleted Relationships Not Getting Removed from the ConfigDb
- Defect 27257 Query to get lookup filter key/value pairs does not respect hidden filters
- Defect 27277 Dashboard does not have correct filter type if the underlying report filters are changed.
- Defect 27282 Errors when running the schema migration upgrade scripts for Oracle
- Defect 27283 Using drilldown grid with subtotals in postgres breaks grid
- Defect 27306 Applying filters to a form report that contains an embedded subreport errors in Internet Explorer. 
- Defect 27346 Izenda Exporting logs all cookies from a browser session
- Defect 27353 Connection string builder: improve security.
- Defect 27360 Clear Filter button on Dashboard does not clear filter values in request
- Defect 27361 Export to CSV exports partial data for pivot grids with separator
- Defect 27378 Export throws error if grid report part column width is not set
- Defect 27388 Adding a numeric separator breaks reports built from REST data sources
- Defect 27389 Subtotals return no records on reports built from REST data sources
- Defect 27394 Error querying data with Custom Views and Fields that contain the @ symbol
- Defect 27403 Query filter field name generation produces overflow when using numeric field and multiple values
- Defect 27412 Login page hangs indefinitely when Izenda is deployed as a virtual directory
- Defect 27413 Horizontal grid borders are not rounded in new styles
- Defect 27414 Comma separated filter values cause the report to error
- Defect 27421 Cross filtering causes report errors after query optiomizations
- Defect 27427 Collapse Expanders by Default feature does not work correctly in pivot grids when using Separators
- Defect 27443 Unable to add/edit join alias when there are multiple joins
- Defect 27457 Performance impact from CONVERT_IMPLICIT on varchar field in generated query plan
- Defect 27481 Inefficient regex for multiline value in export causes timeout
- Defect 27486 No Permission is shown for tenants when NLQ module is not enableed
- Defect 27506 Report list does not refresh when changing tenants
- Defect 27513 Clear Filter and Apply Filter do not work in reports and dashboards
- Defect 27526 Forms with wide formats and page breaks would not export properly to PDF
- Defect 27572 Maps (World) are not loading on Linux Environments
- Defect 27573 Exports are not working on Linux Environments
- Defect 27579 Blank page is appearing while redirecting from Report designer to the Report Viewer on existing reports.
- Defect 27580 Report and Dashboard viewer does not contain Refresh button.
- Defect 27668 Unable to search the report list in Copy Management because the cursor keeps flipping to the start of the text field.
- Defect 27682 HTML text is not displaying in Grid report part when exporting to word.


v3.9.5 Preview Release -- June 25th, 2020
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- Data Model Import Export Phase 1
    - New functionality has been added to allow the exporting of Data Model information
    - This information will be exported as a .bidm file
    - The resulting .bidm file can be imported into any instance of Izenda that has this functionality to populate the data model


v3.9.4 Preview Release -- June 2nd, 2020
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- REST API Connectors have been Added
    - Connections to REST API sources can now be added on the Data Connectors pages
		- REST connections can include multiple endpoints to act as a collection of responses
- Improved Data Connector Dialogue
		- When adding a new connector, there is now a more dialogue-based approach to guide Users

v3.9.3 Preview Release -- May 18th, 2020
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- Tenant Templates functionality is released
    - This is an improvement to the existing Copy Management functionality
    - This allows an administrator to easy push values within a tenant out to other tenants.

v3.9.2 Preview Release -- May 14th, 2020
~~~~~~~~~~~~~~~~~~~~~~~~~~~
- Added improvements for Form to Excel exporting
    - We have improved how forms with and without tables export to Excel
    - Table structures should be respected within the resulting Excel file
- Added new web.config value, izendaNewFormExportFeature
    - This value is set to true by default
    - If this value is set to false, forms will export to Excel as they did prior to this release


v3.9.1 Preview Release -- April 30th, 2020
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- Natural Language Query Functionality Introduced
    - User will be able to see a new default landing page labeled the 'Explore' tab
    - This functionality can be enabled/disabled through tenant modules and permissions
    - NLQ can only be currently leveraged against a single MSSQL data source.
- Grid Style Changes
    - Izenda's grids have been updated with a new modern styling
- Improved Datasource Selection
    - When choosing data sources in the report designer, they are displayed in a list to quickly identify any selected items

v3.9.0 Core Release -- April 14th, 2020
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- Users can now add/delete subscriptions from the Report Viewer without Edit access to the report
- A New Button, 'Clear Filter' is added to the Filter container of the Report Designer/Viewer
    - When clicked, this will remove all currently selected values for the filters on that report.
- Images in the Report Header/Footer will scale down/up to fit the container

FIXES
^^^^^
- Defect 19700 Schedule times were not updating after Daylight Savings Time
- Defect 22057 Aliased data sources would display their default name in the report designer
- Defect 23081 Importing Global Report and source access rights fails
- Defect 23110 Next and Previous icons in pagination are not the same.
- Defect 23719 Run Copy and Validate buttons for Copy Management would not work in Internet Explorer
- Defect 24497 Report Designer exporting tab would inconsistently render report content
- Defect 24538 Large chart legend causes overlap with legend text and pagination text
- Defect 25309 Axis Label not reflecting correct information/duplicated labels for column and bar charts
- Defect 25621 Tenant field would still display on reports when Hide Tenant Field was set to true.
- Defect 25638 Pivot grid sorting would not carry over into exports.
- Defect 25652 Pivot grid side total would not export when aggregated functions were used within the rows.
- Defect 25678 Calls to /api/report/list2 shows inconsistent responses on subsequent requests.
- Defect 25696 PDF exports would fail when applying Page Break After Separator on Chart/Gauge
- Defect 25782 Dashboards mobile responsiveness breaks for tenant users without full report/dashboard access
- Defect 25800 Date Format not recognized of the file while exporting to Excel
- Defect 25818 "Register for Alerts" permission is not automatically removed when the "Schedule" permission is also removed
- Defect 25830 Opening a subreport would cause a filter logic notification to display for users
- Defect 25903 "Full Report And Dashboard Access" permission is still checked when Grant Role with "Full Report and Dashboard Access" is removed from the tenant
- Defect 25911 Creating a custom view with a leading space in the alias name throws query error
- Defect 25963 Querying data on an aliased join that also contains a subkey join would throw an error.
- Defect 26074 Scheduling: Changing the filter value for multi-select changes the filter to single select
- Defect 26083 NOT NULL filter operator was being applied as a NULL operator with required filters
- Defect 26106 Calls to loadDashboard were being redundantly made when opening a dashboard with many filtered tiles.
- Defect 26131 Report part title and description fields are being shown as altered after the default application font is changed.
- Defect 26159 Exporting/Printing fails on Oracle Retail DB
- Defect 26167 During the email process, the existing access_token would not be used
- Defect 26180 Gauges would fail to render values when dragging an in-use field between containers.
- Defect 26185 Fields used for dynamic scale values in Gauges would incorrectly use the same alias values.
- Defect 26187 Dashboards containing map report parts could not be saved.
- Defect 26233 Report Category Visibility cannot be moved even when report owner is changed
- Defect 26234 Page break on a separated grid can be inserted between header and content of the separated object
- Defect 26236 Formatting does not apply on Y-axis
- Defect 26242 Export definition file fails when the name contains pipe character
- Defect 26249 Report designer print preview grows infinitely for grid report parts.
- Defect 26254 PageSize setting in IzendaSystemSetting table was not being respected for exports.
- Defect 26263 Equivalence filters would randomly default to an empty Equals(tree) filler
- Defect 26281 Filter Data is requested twice in Report Designer
- Defect 26311 Filter components are not rendering correctly on mobile devices.
- Defect 26313 Highchart map value field color options do not apply.
- Defect 26314 County Option for Highcharts maps would throw an error during a drilldown event.
- Defect 26329 Filter value dropdown (report/loadPartialFilterFieldData) does not paginate at data source level
- Defect 26358 "Save Template" would still be shown for users that did not have access to Templates
- Defect 26359 Printing with WebUrl pointing to remote domain fails
- Defect 26364 Aggregate function on date fields throws an error when Convert Null to Empty String setting is on
- Defect 26365 Reports built before 3.8 would have font changes to Times New Roman
- Defect 26366 Editing a form would throw an error after reloading a report.
- Defect 26369 Importing template definition results in an invalid template
- Defect 26370 Access Rights randomly disappear in the UI
- Defect 26392 Emailing section in Permissions cannot be collapsed
- Defect 26411 Subtotals would be incorrectly calculated on PostgreSQL data when filters and aggregate functions were used.
- Defect 26430 Aggregate functions in a calculated field don't show in drilldown grids
- Defect 26438 Join alias breaks exporting citing invalid column name when join order is changed to include aliased join
- Defect 26446 Save changes popup shows when no changes are made
- Defect 26458 Minor improvements in paging control
- Defect 26496 Report fails to save when cross-filtering is applied and drilldown report part is deleted
- Defect 26536 Exporting chart that takes some time to retrieve data renders an image with an error message
- Defect 26559 SMTP fails when using Amazon SES in Linux hosted API
- Defect 26630 Cannot create a custom gauge using IzendaCustomVisualizations
- Defect 26654 Performance impact from CONVERT_IMPLICIT on bigint field in the generated query plan for MSSQL
- Defect 26801 Cannot use custom containers in custom visualizations
- Defect 26803 UI - Search bar is not aligned on Report and Dashboard list and Data Source Selection page
- Defect 26825 Unable to create a report using Excel Data Source

v3.8.4 Preview Release -- March 17th, 2020
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- Postgres Driver Supports Materialized Views
    - Any materialized views inside of Postgres databases are now displayed as Views for that data connector.
    - These are managed and edited alongside any standard database views.

v3.8.3 Preview Release -- February 28th, 2020
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- System Cache can be disabled under Settings > System Configuration > Cache > System Cache Configuration
    - This toggle behaves the same as the Data Cache toggle, and is enabled by default.

v3.8.2 Preview Release -- February 27th, 2020
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- Google API Key Allows HTTP Referrer Application Restriction


v3.8.1 Preview Release -- February 10th, 2020
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- New IzendaSystemSetting Values for Chrome 80 Cookie Changes
    - Two new values, CookieSameSite and CookieSecurity, were added to this table to impact cookies generated by the application

FIXES
^^^^^
- Data Model creation would fail for Postgres systems in a Linux environment.

v3.8.0 Core Release -- January 15th, 2020
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- Izenda's Default Font Changed from Roboto to Proxima Nova Semibold
- Reports can be Exported as Iframes from the Report Viewer
    - A new option will exist under the export dropdown of a report
    - This value can be controlled with permissions
- Filter Logic is now Applied to Cascading Logic
    - When cascading is enabled, Izenda will take any custom filter logic into account when determining appropriate filter values for dropdowns.
- Gauge Scale Inputs Accept Aggregated Fields
    - The scale setting for gauges now accepts both text and fields.
    - Feilds will be aggregated to create a consistent maximum or minimum scale value for all gauges
- Filters can Influence Subkey Conditions in Joins
    - When defining subkey conditions for report joins, distinct filter objects can be created.
    - These filter objects, when values are set, pass this value into the join condition of the report
- New Role API
    - A new external API for role creation has been added to Izenda
    - This API allows for a new method of permission management
- Drillown Grid supports Grouping on Value Fields

FIXES
^^^^^
- Defect 19195 Error message appears when setting Average Days Old or Sum Days Old function for a date field while Convert Null to Empty is enabled.
- Defect 23213 Calculated fields using CONVERT on MYSQL date fields would fail with a syntax error.
- Defect 23615 Pivot Grid column expanders were only present when side totals were enabled.
- Defect 24117 Applying a custom field alias via OnPreExecute would make the field invalid.
- Defect 24424 Pivot grids would sort A->Z on grouping fields even when marked as unsorted.
- Defect 25167 Join section of datasource tab breaks calculated fields when using French Language Pack.
- Defect 25260 Tree maps would not display the message "No data to show" when the Multi-Level setting is checked and no data is present.
- Defect 25271 Field values were not properly encoded in query parameters of a custom url when exporting to PDF.
- Defect 25399 Custom Views did not work in SQL Server 2017 due to the default compatibility level.
- Defect 25444 Cache would prevent data model update icons from displaying on data sources with updated content.
- Defect 25485 Global dashboard filters would be blank when viewed from the tenant level.
- Defect 25494 Cross Filtering functionality not working when aliases are applied to calculated fields in a report part.
- Defect 25510 Inline css of forms are not overriding Izenda stylings.
- Defect 25528 Performance of API application startup was slow.
- Defect 25557 Cannot open Custom URL/Sub Report on Line/Column/Bar/Area/Combination/WaterFall when a custom field format is applied.
- Defect 25567 Oracle configuration databases would cause errors when saving reports with various calculated fields.
- Defect 25575 Using the in-process hosting model of asp.net core prevents Izenda from generating logs.
- Defect 25626 Filter values are not accurate populating when creating E-mails.
- Defect 25648 Passing delimited filter values to the report render functions in an Angular Kit throws an error.
- Defect 25691 Required filters do not require a user to click the Apply Results button before viewing data.
- Defect 25784 PermissionData element of a role would store duplicate values and increase in size.
- Defect 25793 Drilldown grids would fail to export if the report contained datetime fields and filters.
- Defect 25906 IzendaCustomVisualizations is not compatible with 3.7.1
- Defect 25953 .Net Core APIs would encounter 502.5 errors upon re-starting.
- Defect 26075 Filters on the Database Mapping page would not display updated results.
- Defect 26093 After removing a subkey join option, the filter would still be present in the report designer.
- Defect 26159 Exporting/Printing would fail against an Oracle data source.


v3.7.2 December 4th, 2019
~~~~~~~~~~~~~~~~~~~~~~~~~~~

.. warning::

   Enabling the settings to render HTML content can create a security risk for your application. Please talk with your development and security resources before toggling this setting.


FEATURES
^^^^^^^^^
- Conditional Formatting Dialogue Expanded to Pivot and Drilldown Grids
    - The conditional formatting improvements from v3.7.0 can now be used within pivot and drilldown grids
- HTML Rendering for Report Viewers and Exporting
    - New settings are added to render HTML elements within data for Grid and Form report parts

FIXES
^^^^^
- Defect 25421 Grids would export for incorrect aggregate values when rows were collapsed
- Defect 25665 Collapsed Pivot grid rows would be blank when exported
- Defect 25788 Conditional Formatting would be incorrectly applied when rows were collapsed
- Defect 25780 Text Format options would not properly apply in pivot grids
- Defect 25865 Browsers consoles would display a warning when configuring report emails
- Defect 25900 Running the migration script for MSSQL databases would produce an error

v3.7.1 November 26th, 2019
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- D3 Library Implemented
    - The D3 charting library is now implemented into the platform by default.
    - A new Tree Map visualization is now available for all Chart report parts.
- Configurable Front-end AJAX Settings
    - A new parameter is added to our configJson element that allows for AJAX requests to be customized

FIXES
^^^^^
- Defect 23789 Cascading filters were not applied for Equals Tree/Checkbox filters
- Defect 25253 TreeMap would fail to render with duplicated label values
- Defect 25259 Field Color settings were not properly applied with Percentage Ranges when enabling Multi-Level display.
- Defect 25499 Alternative Text settings were not properly applied with Percentage Ranges in Pie/Funnel/Donut/TreeMaps.

v3.7.0 November 13th, 2019
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- Salesforce Connector Preview
- Continued Grid Enhancements
    - Blank rows can be added to pivot grid expanders for better visual spacing.
    - Conditional formatting options were added to support bold, italics, and underline formatting for grids.
    - A new conditional formatting option exists for Horizontal and Vertical Grids
        - This allows for conditional formatting to impact entire columns or entire rows
        - This will be expanded to impact pivot and drilldown grids at a later date.
- Calculated Fields support New Line character
- Expanded API response behavior for error handling

FIXES
^^^^^
- Defect 15497 Pivot grid field text color does not change.
- Defect 19052 Unexpected empty space beneathe collapsed Pivot headers.
- Defect 19288 System users cannot copy global reports to local categories.
- Defect 19470 Changing the chart type to Waterfall after adding a separator corrupts data.
- Defect 20815 Field comparison filter values are not copied if built against a calculated field.
- Defect 22467 Form fields positioned outside of a repeater would appear as links if CustomURLs were set in the repeater.
- Defect 22658 CustomURLs inconsistently encode characters in integrated modes on some browsers.
- Defect 22847 Calculated fields that return aggregates would not display filter values.
- Defect 23686 Postgres Bytea data type would not display as an image.
- Defect 23737 Tenant users without scheduling permissions see a failed loadSchedules request when saving a report.
- Defect 24195 Creating tenant with fullReportAndDashboardAccess = true in Permission object removes some permissions from the object.
- Defect 24281 Convert Null To Empty causes an error when the report contains a calculated field using user defined function.
- Defect 24333 Dashboard buttons flicker momentarily when loading.
- Defect 24473 Value labels on maps do not display when Show Map Labels and Show Value Labels are enabled when a shading metric is not configured.
- Defect 24682 Reports could not be renamed or moved when using an Oracle configuration database.
- Defect 24711 Global maps would error when dynamic shading was set while multiple point options were present.
- Defect 24750 PostgreSQL procedures would not display fields in the data model.
- Defect 24871 Filter values were rounding automatically in the value dropdown.
- Defect 24939 Exporting to Excel would fail when special ASCII characters were present.
- Defect 24973 Emailing would fail when a tenant email server was set up using a custom configuration.
- Defect 25069 Filters based on a calculated field would display no values if that field was built from a user defined function.
- Defect 25091 Emailed Chart/Gauge/Map data was not filtered appropriately based on the user's value selection.
- Defect 25100 Cannot save dashboard into a category when the category name resembles a GUID.
- Defect 25154 Error message would display when the HH:mm:ss format is applied to a date time field if data cache is enabled.
- Defect 25161 Arrow navigation did not work when dashboards were in presentation mode.
- Defect 25185 Using calculated fields and PostgreSQL reporting DB caused a query syntax error in some cases.
- Defect 25262 Printing does not render charts in Deployment Mode 1 because the access token is missing.
- Defect 25284 Calculated fields are shown as invalid filters when they are built from other calculated fields.
- Defect 25308 Common Filters were not accurately determined when Single/Multiple selections existed for the same field.
- Defect 25311 Missing dashboard background color and background image in exports/prints.
- Defect 25393 Embedded HTML grids do not keep styling when emailed.
- Defect 25420 Email Body default text is missing when adding a new subscription/schedule in v3.6.0.
- Defect 25445 Schedules use default filter values from the report definition instead of the values set in the schedule designer.
- Defect 25483 When exporting, only rows that were visible in the viewer would be collapsed.
- Defect 25501 PDF and Word exporting/printing would fail for pivot grids.
- Defect 25505 Forms were not consistently rendered in the UI.
- Defect 25517 Maps failed to render when applying a color formatting.
- Defect 25532 The popup grid for charts would load forever in Internet Explorer.
- Defect 25577 Blank spaces were added between records in PDF Exporting.
- Defect 25615 Users could not search for report parts in the dashboard designer when using Firefox.
- Defect 25636 Column groups would not be applied in Pivot grids.
- Defect 25667 Grid/Form loads forever after adding any field in Internet Explorer.
- Defect 25672 Report parts would load indefinitely when adding a subtotal in Internet Explorer.





v3.6.0 October 10, 2019
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- New User Load API
    - We are introducing a new external user endpoint: GET api/external/user/loadUser
    - This endpoint is meant to return user information for a single user at a time, as opposed to a bulk load.
- Additive Field Auto Visible/Auto Filterable
    - The security settings Set Additive Field Auto Visible and Set Additive Field Auto Filterable are now set to True by default.
- Excel Export DateTime Formatting
    - Previously, date columns were being exported as Text in Excel exports.
    - These have been adjusted to be exported as a custom data type to enable date filtering options in the Excel sheet.
- New Separator Option for Pivot Grids
    - We have introduced a new separator type, Logical, for pivot grids.
    - This separator will block out data within the pivot without creating a new grid instance, keeping all of the data in-line.
- Visibility Toggle for User ID and User Profile
    - Two new options exist under System Configuration > Security Policies
    - These items will let a user specify if the UserID value should be shown in the profile, or if the profile page as a whole is accessible.
- Logging Improvement for TenantID and ReportID values
    - Two new parameters are present in our logs for both of these items to separate them from the larger message content.
    - This will make it easier to search logs for tenant-specific or report-specific entires.
- Excel Adapter Improvements and Release
    - The Excel adapter now handles updating and replacing sheets for connections more reliably.
    - The UI updates for non-database connectors have been finished.

FIXES
^^^^^
- Defect 19030 System would show "This Field name alias already exists in [xxx] report part" despite only having one field.
- Defect 21124 Grouping datetime field in Bubble/Scatter chart throws an error.
- Defect 23232 The "Others" value was not displayed on legends for Pie Charts.
- Defect 23614 API call report/tenants/(tenant_id)/categories/(category_id)/reports returns all reports regardless of the user token provided.
- Defect 23838 TreeMap would fail to render when negative values were present.
- Defect 23905 API call user/active and user/deactive returns User object regardless of success or failure.
- Defect 24069 Data source change warning icons would not clear even when changes are saved.
- Defect 24079 Header & Footer were still displayed when they were set to be hidden by default.
- Defect 24105 Filters would error when searching for a data source in the report designer.
- Defect 24116 Reports exported to Word were not scaling correctly.
- Defect 24171 Convert null to empty string option causes invalid column name when using an aggregate function
- Defect 24270 No warning message is getting displayed when navigating to the report viewer.
- Defect 24274 No confirmation message is displayed when closing a modified dashboard.
- Defect 24327 Freeze button is still shown in the dashboard viewer.
- Defect 24381 Users would be unable to save reports into a new category despite having permissions for it.
- Defect 24426 Cannot use stored procedures with a '-' in the name.
- Defect 24436 Heatmap shades incorrect color for some countries.
- Defect 24439 Subtotals were not properly formatted for drilldown grids.
- Defect 24463 PDF export fails when a report has a footer and no header.
- Defect 24561 Refresh button displayed when data caching layer is not enabled.
- Defect 24623 System throws an error message when filtering on a calculated field.
- Defect 24683 Drilldowns do not work when passing in a Guid that uses all uppercase letters to renderReportPart.
- Defect 24687 Color settings are not applied when a Form contains repeaters and a custom data format.
- Defect 24688 `Add Schedule` button in the report designer creates a console error with the .NET Core API.
- Defect 24691 Pivot headers would be misaligned when one or more headers were marked as non-visible.
- Defect 24708 Filters are applied incorrectly after saving a dashboard if a report contains subreports.
- Defect 24752 Field values are not encoded when using Custom URL in the Report Designer.
- Defect 24783 Field names and values are not encoded in Forms.
- Defect 24850 Extra space in field names in forms could be used to enter information, breaking the form.
- Defect 24867 Adding repeater tag to Form report doesn't trigger a change notification when saving the report.
- Defect 24889 Current Tenant Header in role/all/(tenantID) would allow users to see information for other tenants.
- Defect 24920 "data:image/jpeg;base64," was being appended to Lob fields.
- Defect 24925 UI and behavior adjustments of Excel adapter in Connector tab.
- Defect 24938 IsSubscriptionTimeZoneUsed field added in v3.3.1 incorrectly alters IzendaConnection table in PGSQL scripts.
- Defect 24972 Inconsistent behavior would arise when uploading files with the Excel Connector.
- Defect 25082 Grids would only export the Preview Records set, not all records.
- Defect 25162 Exporting does not work if running .NET Core API on Linux OS due to QtBinaries.
- Defect 25174 Bubble Chart cannot be built after adding multiple columns at once to value field.
- Defect 25261 Subreports would not inherit filters from the parent report in DeploymentMode 1 environments.
- Defect 25281 All local categories are loaded when a user selects Global Categories when saving a report.
- Defect 25288 No data is returned when you alias a join between two data sources from two different database types.
- Defect 25289 System caching would make it impossible to open any report if the current user isn't a system admin.
- Defect 25290 The prefix of a temp file isn't deleted when a connector name is generated.
- Defect 25296 Excel exports would fail when a grid report contained separators.
- Defect 25320 Datetime fields would export in unexpected formats when exporting to PDF/Word.
- Defect 25321 Datetime fields were not set as datetimes in Excel when functions and formats were applied.

v3.5.0 September 10, 2019
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- (Beta) Excel data sources can now be added as reporting data sources.
- Google Maps can now be selected when creating a map report part.
- Ability to hide grid headers from the report viewer.

FIXES
^^^^^
- Defect 22644 IsReportValid API Call is cached to help improve performance.
- Defect 23229 Info icon near the provision map data button is not working.
- Defect 23302 Adding fields to a report in an Angular environment would show console errors.
- Defect 23558 Copy Management workspace against a new tenant shows "Another user has recently modified this data".
- Defect 23626 $0,000 custom format displays $0,000$ when used in a report.
- Defect 23776 State indicators for buttons were not displayed.
- Defect 23928 Map legends would create inaccurate ranges when displaying.
- Defect 23978 No license expiration message displays in 3.x versions.
- Defect 24285 Email Report using Embedded HTML option would download a 0KB HTML file.
- Defect 24428 Imported report with a filter against an aggregated field crashes when viewing.
- Defect 24611 MySQL schema migration scripts would cause errors when running.
- Defect 24664 GetToken should not be called for exports using an access_token is already set.
- Defect 24694 Tables in form report parts show white space differently between the viewer and exporting.
- Defect 24695 Full column drilldown functionality was disabled.
- Defect 24882 Loading the dashboard list by a category fails against a PostgreSQL config database.
- Defect 24893 Chart/Gauge/Map exports would fail when exporting to PDF/Word format.
- Defect 24918 Navigating to a subreport for global reports at the tenant level returns a blank report.
- Defect 24933 Point options and metrics dropdown are hidden by the report part header in report designer in responsive layouts.
- Defect 25067 Tenant Field would not be applied consistently.
- Defect 25087 The browser page would crash when changing a report's property and then changing the chart type.



v3.4.2 August 29, 2019
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- Conditional Formatting on Grids can be Applied Regardless of Value
    - When setting conditional formatting, instead of specifying a Value, Value Range, or Percentage Range grids can apply this setting to all values for that field.

FIXES
^^^^^
- Defect 22598 ElasitcSearch timezone offsets would occasionally be applied twice.
- Defect 22742 Alternative Text was not applied to X/Y Axis labels in charts.
- Defect 23240 Users with Full Report and Dashboard Access could not edit category names.
- Defect 23834 Fullscreen Mode would not be applied in Dashboards.
- Defect 24174 Dialogue Boxes would not render the delete option.
- Defect 24609 HTML was not converted to plain text when exporting to non-PDF formats.
- Defect 24666 Embedded subreports using the Between (Date) filter would show different results when exporting.
- Defect 24678 Dashboards leveraging filters with multiple filter values separated by delimiters would fail to filter data.


v3.4.1 August 23, 2019
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- Introduced CORS Policy Configuration for the .NET Core API resources for Izenda


v3.4.0 August 16, 2019
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- Machine Learning Infrastructure
- System Cache Beta Implementation
    - Caching can be leveraged through a Disk Cache or a Memory Cache
    - This cache manages objects for system validation (roles, report list, data model access, etc.)
- Drilldown Grids can be Exported at the Current Expansion Level
- Join Logic can be Toggled Between Behavior before 2.18.1 and after 2.18.1

FIXES
^^^^^
- Defect 19260 In responsive modes of dashboards, grid headers overlaps dashboard tile names.
- Defect 20248 Report viewer is not scrollable in landscape mode for mobile phones.
- Defect 21501 Forms would lack the border, background color, and inserted items when exported.
- Defect 22502 Conditional formatting in forms would break when repeaters were used.
- Defect 22846 Dashboard viewer would display an additional, 13th tile when users would move a tile.
- Defect 23189 Front-end warnings would be logged in the browser after updating the UI.
- Defect 23206 Chart Static Threshold labels were partially visible if Filter Dialogue was collapsed.
- Defect 23243 Loading Schedules list in UI would return a 500 error when using SQL Server 2008.
- Defect 23644 Setting level dropdown is partially visible in mobile layouts.
- Defect 23817 Reports would fail when using both an aliased join and a composite key in the relationships.
- Defect 23839 GUID was displayed in chart tooltip instead of the threshold name.
- Defect 23840 Metric formats would not apply to the Y-axis.
- Defect 23929 Standalone users would not save and activate properly.
- Defect 23936 Pivot grid export would fail when more than 5000 records were used.
- Defect 23976 Filter values were saved without notification when selected in the Viewer and navigating to the designer.
- Defect 24078 Drilldowns would not work as expected when using the renderReportPart function with a chart.
- Defect 24107 Setting Level and Tenant dropdown are not rendered in Ipad/Ipad Pro layouts.
- Defect 24128 Metric Dropdown does not appear on embedded reports in v3.x
- Defect 24175 Calculated fields throw an error when using Tenant Field configuration and Report Filters.
- Defect 24215 Required filter indicator (*) would not appear for required filters in dashboards.
- Defect 24221 Drill-down grid exports would not mirror the data in the designer.
- Defect 24261 Report headers and footers would not render appropriately on mobile layouts.
- Defect 24266 Point option dropdown on Maps is misaligned on mobile layouts.
- Defect 24283 MySQL Connections would error when stored procedures were present in the database.
- Defect 24286 MongoDB adapter returns 101 records when grouping.
- Defect 24325 Copy Management would fail when copying to multiple tenants.
- Defect 24385 Encryption algorithm for disk cache objects was updated.
- Defect 24445 Filters made against calculated fields would error out.
- Defect 24450 Unsigned Int Fields would not display from a MySQL database.
- Defect 24456 Null objects in the internal cache caused performance degradation.
- Defect 24589 MySQL/PostgreSQL/Oracle update scripts were incorrect.
- Defect 24592 Changes in the Relationships page would not be saved.
- Defect 24597 When sorting on a custom format the system would throw an error.
- Defect 24608 No record was found in exported files when exporting Charts/Gauges/Maps with delimiters in the filters.
- Defect 24616 Report Owner would occasionally be set to NULL.
- Defect 24663 Custom Formats would not be applied to negative numeric values.


v3.3.1 July 23, 2019
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- InTimePeriod filters reflect more accurate timezones
- Multiple Selection filters now support delimited lists.
- Izenda can load on pages with pre-existing Highcharts references.

FIXES
^^^^^
- Defect 23242 Preview Dashboard Triggered Query when Required Filters were Set
- Defect 23975 Unhandled Exception in Pivot Grids with Non-sum Aggregations in Rows
- Defect 24077 Report Imports Fail with a Postgres Configuration Database
- Defect 24326 Passing Multiple Date Filter Values to renderDashboardViewerPage caused Front-end Error with Date Pickers
- Defect 23842 General Info Values Failed to Populate for Logo Images
- Defect 24427 System Job Implementation Polled System Inefficiently

v3.3.0 July 15, 2019
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- Data Caching Beta is now Implemented
    - Caching can be leveraged through a Disk Cache or a Memory Cache.
    - Data for Reports and Dashboards will be cached after the initial load.
    - A new UI button, 'Refresh' will be present which will allow users to update the cache.
    - 'Update Results' has been renamed 'Apply Filters' and will always prioritize pulling from the cached data.
- Sorting can now be changed on fields with subtotals.

FIXES
^^^^^
- Defect 17160 System/Tenant Dropdown on Mobile Resolutions Isn't Responsive
- Defect 19005 Export and print actions do not work on mobile devices
- Defect 19040 Dashboard Background Color Picker Is Cut Off in a Portrait Layout on Mobile Devices
- Defect 20253 Mobile Dashboard Map Point Options Selector Not Scaling
- Defect 20254 Mobile Dashboard Map Navigation for Drilldowns Covered
- Defect 21139 Integration and external endpoint for save/update user does not change Active property
- Defect 22368 Non-visible fields are being displayed in exports.
- Defect 22683 Days Old function in chart values
- Defect 22811 Filter error when using tinyint(1) data type with mysql database
- Defect 22866 Scatter chart Y-axis labels overlapping on small chart sizes
- Defect 22916 Word Wrap Not Being Carried Over to Excel Export
- Defect 23124 Join relationship using aliased join gets reordered when not listed at the bottom
- Defect 23241 When a user creates a Chart type report using Range only Option from Report Part properties Error is displayed
- Defect 23272 Issue Rendering Embedded Report Part when trying to drill-down into a report
- Defect 23315 Add field button doesn't respond
- Defect 23398 Alternative Text Value Displays as Blank When Using Separators
- Defect 23513 Responsiveness with dashboard and report tiles in mobile design
- Defect 23546 Whitelisted functions not recognized in calculated field IF or CASE statements
- Defect 23552 Quality Issue for Exporting Chart/Gauge/Map using Syncfusion on .NET Core
- Defect 23556 Tenant User with Full Report and Dashboard Access gets logged out when saving a dashboard
- Defect 23717 When moving an existing report to a new category, the category is put under Available Categories
- Defect 23730 Value displayed incorrectly for forms in Microsoft Edge and Internet Explorer
- Defect 23731 Access rights drop-down does not populate and locks the report designer
- Defect 23739 Wrong colors in maps when using dynamic High and Low values
- Defect 23777 Incorrect tooltip is displayed when using pivots and Custom URL
- Defect 23801 Unexpected behaviors when using the OnPreLoadFilterDataTree IAdHocExtension method
- Defect 23833 Cannot view a Gauge report in Dashboard on Mobile
- Defect 23924 Fields with null values in forms displays incorrectly
- Defect 24076 Scheduling limit not being set by default
- Defect 24251 Map background is cut off in report designer
- Defect 24298 Can not navigate to report when setup Email link in Dashboard/Report

v3.2.1 June 21, 2019
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FIXES
^^^^^
- Defect 21677 Subtotals resulting in 0 were displayed as null in Horizontal Grids.
- Defect 23691 Values on Map Legends would not Display.

v3.2.0 June 4, 2019
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^
- Report Headers Scale to Reduce Whitespace
- New Filter Interactions
    - Filters properties are now managed through a pop-up
    - 'Between' filter operators have a new interface
- GetAccessToken is expanded for Grid and Form Exports
- Subreports Allow Users to Pass Field Values into Input Parameters of a Report

FIXES
^^^^^
- Defect 22976 The 'To' value of a Between Date operator is not committed when saving a dashboard.
- Defect 23239 OnPostLoadFilterData is no longer called for stored procedure parameters.
- Defect 23578 API-STRONGNAME resources were not available for v3.0.0
- Defect 23637 Connecting to an existing Postgres configuration database through the Standalone UI throws a duplicate key error.
- Defect 23685 Filters would fail to load their values after saving a report.
- Defect 23689 Report visibility is cached when creating a report within a new category.
- Defect 23701 Visible data sources are moved back to available after updating the data model tab.
- Defect 23713 The same aggregate field in a separate report part would not be displayed within the 'Add new filter' popup.
- Defect 23735 RenderReportViewerPage function with AngularJS 1.x front-end causes infinite URL reloading.
- Defect 23847 Report body grid lines would not display after adding a new report part.


v3.1.1 May 16, 2019
~~~~~~~~~~~~~~~~~~~~~~~~~~~


FIXES
^^^^^
- Defect 23378 Right clicking on report sends user to incorrect route in integrated applications.
- Defect 23654 Quartz ADOJobStore required additional configuration for schedules to run.
- Defect 23680 Unable to export forms to Excel in 3.1.0.

v3.1.0 May 9, 2019
~~~~~~~~~~~~~~~~~~~~~~~~~~~


FEATURES
^^^^^^^^^

-  MongoDB Available as a Reporting Datasource
-  Key Joins Support Multiple Values
    -  = and <> operators now support multiple input values
-  Pie Charts Support Drilldown Actions on the 'Others' slice
    - If you are using the 'Bottom X%' function on pie charts, you can drill down on the 'Others' slice.
    - When drilling down, a pop-up will let you select which underlying value you wish to drill down to.
-  New DateTime Picker
    - Implemented Blueprint.js to leverage a new DateTime picker for filters
    - Further enhancements for this will be released alongside v3.2.0
-  Update Results Button Relocated
    - The Update Results button is now located alongside the filter panel
-  Filter Panel - Space Consolidation
    - To prepare for further updates in v3.2.0, the filter box has been adjusted to save space in the report designer.
-  Close Button in Viewer Methods is Removed
-  Bottom Row of Dashboard Tiles is Situationally Removed
    - When viewing a dashboard that a user cannot edit, the bottom row of empty dashboard tiles will be removed.
-  Additional IntegrationStyle Flags for Front-End Render Functions
    - renderReportViewerPage allows you to hide the report name and the preview records dropdown.
    - renderDashboardViewerPage allows you to hide the dashboard name and global dashboard checkbox.
-  New Dashboard Tile Header Permission
    - Added a new dashboard permission titled 'Display tile header in uneditable dashboard'
    - When unselected, the blue dropdown tile header will not be presented in dashboards. Please note this is intended for roles that only view, and not design, dashboard.

FIXES
^^^^^
- Defect 22210 Cannot use Equals-No Auto Complete on Stored Procedures if the lookup field's data type is different than the parameter.
- Defect 22211 Invalid datatype fields should not be shown in the dropdown lists for setting lookups.
- Defect 22285 System displays an error message when a user uses the "Between Date & Time" filter on Oracle datasources.
- Defect 22488 QuerySourceId payload is missing when the field is added to report for the first time after the designer page loads.
- Defect 22543 Link Location Being Adjusted Upon Altering Form Contents.
- Defect 22650 Tenant Users are unable to view Global Gauge Reports when there is a Dynamic Threshold.
- Defect 22732 Potential erroneous hashing increases chance of collision.
- Defect 22767 User-defined aggregate functions could not be grouped at the field level.
- Defect 22835 Number of Records does not work for charts and gauges when exporting from dashboards.
- Defect 22838 Username field in header is inconsistent between report viewer and exports.
- Defect 22841 Category values are not filled automatically when trying to use Save As.
- Defect 22843 Focus on Report Name when saving a report.
- Defect 22844 Focus on Report Name input in Subreport Settings when selecting reports.
- Defect 22850 Filter values were re-requested each time the dropdown was expanded.
- Defect 22937 Executing SPs in the Data Model resets field properties.
- Defect 22947 Using [BLANK] for stored procedure parameter value passes NULL instead of empty string.
- Defect 22962 Gauge Metrics could not be deleted in IE.
- Defect 22969 'No. of Columns Per Exported Page' setting is not impacting Excel exports.
- Defect 22979 Report Part Name could not be easily set when using IE.
- Defect 23094 Column widths would reset in the Data Model after making changes.
- Defect 23188 Gauge previews are not impacted by removing metrics from the gauge.
- Defect 23205 Dashboards Initially Load a Blank Dashboard with 'Example Dashboard Name'.
- Defect 23248 Pagination of embedded subreports is not scaled properly when extending the Grid's width.
- Defect 23249 Cannot create report from Oracle data sources if a Date field is used as a key join.
- Defect 23281 Failed to load Default landing page in a .Net 4.6.1 site.
- Defect 23283 Quality Issue for Exporting Chart/Gauge/Map using Syncfusion on Framework 4.6.1
- Defect 23301 Timestamp without time zone date/time type in PostgreSQL shows incorrect time with data offset setting
- Defect 23314 Invisible UTF symbols removed from class/variable names.
- Defect 23443 Updated unit tests for current dev branch.
- Defect 23476 Unable to Provision Map Data on 3.0.0.
- Defect 23477 User API duplicates database call to get the user's roles.
- Defect 23478 Tenant users cannot export dashboard tiles made from grids/forms.
- Defect 23516 IAdHocExtension Methods Not Hit in 3.0.0.

v3.0.0 April 2, 2019
~~~~~~~~~~~~~~~~~~~~~~~~~~~

FEATURES
^^^^^^^^^

-  UI Re-skin
    -  The v3.0.0 release features a new themed application that is easier to whitelabel.
-  .NET Core Compliance
    -  Our libraries have been updated to support .NET Core
    -  Izenda can now be deployed in Linux environments
-  Export Provider Change
    -  We have changed our export provider from EvoPDF to Syncfusion
-  Default API Route
    -  Navigating to http://[YourIP]/api/ will now provide a default Izenda landing page.
    -  If you make an application/json request to this endpoint it will return 'The system is online' upon a successful response.
-  Improved Import/Export Error Messaging
    -  While importing report/dashboard definitions, the pop-up will now contain file names, field names, and data types of all conflicting objects.
    -  The content of this pop-up is now copyable so it can be viewed outside of the application.
-  Improved Export Error Messaging
    -  Log messages will show if the system ran out of memory while exports, or if a navigation timeout occurred.
    -  If a navigation timeout caused the export to fail, it will mention the values for export configuration currently set in the IzendaSystemSetting table.
-  Improved Emailed Report URLs
    -  When emailing the report URL, the filter values are now included so the opened report is filtered appropriately.
-  Improved Install Error Messages
    -  An error message is thrown during installation if the IIS users don't have sufficient permissions to the application files.

.. warning::

   If you currently have additional Azure resources configured for an EvoPDF exporting provider, this is no longer necessary. Syncfusion works in Azure environments without the need of a specific service. You will need to adjust your exporting configurations accordingly.

FIXES
^^^^^
-  Defect  21853  Month In Time Period filters do not return the expected results using Oracle reporting database.
-  Defect  21862  Sorting the x-axis did not work when a separator was in use.
-  Defect  22258  Map drilldowns would break when using the % of Group format.
-  Defect  22284  Using lookups with special characters would return all data.
-  Defect  22339  Labels on a static threshold would not display.
-  Defect  22687  Using AngularJS front end causes infinite URL redirecting.
-  Defect  22816  Unable to edit Report Name on Report Viewer in Multi-Tenant mode.
-  Defect  22821  Embedded subreports would not show data when field mappings were used.
-  Defect  22832  Top y-axis label on Heat Maps would be null without enough height.
-  Defect  22851  Some dropdowns did not have triange animation.
-  Defect  22859  Maps would not render when using the City field.
-  Defect  22918  Filter values would not updated when scheduling a Dashboard.
-  Defect  22919  Filter values would not update when scheduling a chart, gauge, or map.
-  Defect  22920  Filter values in report schedules would not display properly if one or more filters were not marked as visible.