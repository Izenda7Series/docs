==============
Known Issues
==============

.. list-table::
   :header-rows: 1
   :widths: 10 15 75

   * - Type
     - Item No
     - Description
   * - Defect
     - 12447
     - When reviewing the permissions summary in the role no scroll bar is present and only 12 items can be displayed
   * - Defect
     - 12999
     - CONCAT must be used in instead of + when combining two string values in some databases.
   * - Defect
     - 13082
     - Due to loading race conditions some reports are displayed with no results until the user clicks update results after initial load of report
   * - Defect
     - 13170
     - In Calculated Field the preview result field is displayed incorrectly after user selects a different data type
   * - Defect
     - 13247
     - When creating a form the drag and drop for fields will not work once an item is deleted unless the cursor is placed in the form report part
   * - Defect
     - 13510
     - Some drop downs are not searchable and all should be combo search and select
   * - Defect
     - 13534
     - Field name is not unique error displayed when using a calculated field created in data model in the calculated field created in report
   * - Defect
     - 13554
     - Chart Zoom feature not working properly with Stacked Percentage property
   * - Defect
     - 13728
     - Percent of group is not working properly with drill down grids
   * - Defect
     - 13736
     - Success message displays even after clicking Cancel button on Overwrite popup when copying reports
   * - Defect
     - 13745
     - No record returned is displayed the first time the user clicks to preview results for sub and grand totals
   * - Defect
     - 13757
     - User must log out and back in if permissions are changed on role to reduce the report part types available.
   * - Defect
     - 13761
     - When user collapses data model tree in copy management and navigates to advanced copy screen, all trees are expanded again when returning to the main screen
   * - Defect
     - 13762
     - Calculated field fail to load after changing the database name for the connection string
   * - Defect
     - 13782
     - When using a report part, render report or render dashboard if item ID is not found system should return message stating item is not found
   * - Defect
     - 13794
     - Performance on MS Edge is slow, nearly frozen
   * - Defect
     - 13802
     - Vertical Scroll bar position is reset to top of the list although user select the last item on left navigation.
   * - Defect
     - 13899
     - Freeze option not working in Quick Edit mode for filter panel
   * - Defect
     - 13912
     - When setting a role to Full Report and Dashboard Access defaults for each area are not correct. Example, user should always be able to create a report but if it is not the default for tenant this is not checked and is hidden when using this setting.
   * - Defect
     - 13919
     - After changing the name of a calculated field sub/grand total show error "this field is invalid"
   * - Defect
     - 13956
     - Concurrency updated msg is not displayed when user clicks on Save button on a new workspace without clicking on Validate button first
   * - Defect
     - 13984
     - User with create report permissions but lacking permission to Overwrite Existing Report cannot get back to the report designer
   * - Defect
     - 13989
     - When using required filters the system is still executing query prior to user clicking update results when there are more than one required filters
   * - Defect
     - 13992
     - Filter description does not display in dashboard tile after adding new filter into report
   * - Defect
     - 14010
     - Known issue with Oracle .net driver any repeating decimals will cause an error to resolve in the Application use ROUND(field/field,3) to round the decimal
   * - Defect
     - 14019
     - System loads all Functions in calculated field and function dropdown and should only load items from currently used connection string
   * - Defect
     - 14054
     - Copy Dashboard function showing error when recopying a dashboard where the reports were deleted in the destination prior.
   * - Defect
     - 14074
     - Scroll bar needed in dashboard tile for gauges and charts which contain multiple items as they are too small to see until the tile is made larger.
   * - Defect
     - 14090
     - System should prevent duplicate threshold values on the same axis
   * - Defect
     - 14100
     - Responsive Screen Issues
   * - Defect
     - 14101
     - Percentage of Group Subtotals are not correct they show the subtotal value with a %
   * - Defect
     - 14110
     - SASS styles issue some elements are not pointing to a global variable
   * - Defect
     - 14114
     - Simple gauge is not sizing properly within the container, at some sizes the gauge is too large and and cuts off the data
   * - Defect
     - 14115
     - License Expiration Notification Reports Negative Days
   * - Defect
     - 14174
     - Query execution is not available for stored procedures in MySQL
   * - Defect
     - 14201
     - Position of tick mark is incorrect on linear gauge when metric value returns a negative number
   * - Defect
     - 14219
     - Browser does not respond when loading the large schema in Internet Explorer
   * - Defect
     - 14223
     - Missing some configurations on sorting feature for pivot and drill down grids
   * - Defect
     - 14225
     - The copied report having sharing info is not available for the user in the destination when using copy console
   * - Defect
     - 14232
     - Suggested Data Type is not displayed in calculated field created in data model
   * - Defect
     - 14286
     - Money field type shows no decimals by default without a format applied
   * - Defect
     - 14293
     - Default sorting function is removed when user returns to visual tab from HTML tab
   * - Defect
     - 14299
     - Grid lines disappear in form table after formatting a field
   * - Defect
     - 14315
     - Stored Procedures in MSSQL which contain aggregate fields without as indicator show blank field name in model
   * - Defect
     - 14605
     - Permissions summary data is showing Global and Local category names not the actual category names
   * - Defect
     - 14677
     - Checkbox and Popup style filters are not inheriting the values of top level report
   * - Defect
     - 14694
     - Application detects incorrect data type of Aggregated Function so it throws incorrect error msg: "Value should be valid compared with filter data type"
   * - Defect
     - 14754
     - Using any of the RUNNING totals as calculated field functions do not work
   * - Defect
     - 14763
     - Notification for adding a new table/view/stored procedure is incorrect, states that all data will be overridden in the model
   * - Defect
     - 14775
     - Function dropdown list carries over from one field to another field in forms
   * - Defect
     - 14797
     - In some cases when using separator on Column Chart the columns are overlapping
   * - Defect
     - 14806
     - Duplicate workspaces display in middle panel after clicking Save button many times
   * - Defect
     - 14891
     - In Edge Browser Data is not displayed when user changes from back side to front side, system shows error msg when creating form
   * - Defect
     - 14893
     - List category on left nav is displaying the list of Reports instead of list of Templates when user views a template
   * - Defect
     - 14914
     - Suggested Data Type is incorrect when user changes the Field in Expression text box for Calculated Field
   * - Defect
     - 14928
     - In Subtotal/Grand Total Data Type changes to Money when using Average/Sum/Sum Distinct for numeric field.
   * - Defect
     - 14939
     - FireFox is showing slow load times for Permissions tab to Data Model Access tab
   * - Defect
     - 14949
     - Report Part should be displayed in the report when error is shown that fields are not visible
   * - Defect
     - 14954
     - Incorrect error message displayed  Should be shown error message "Invalid filter(s): ..." instead of "The application has encountered..."
   * - Defect
     - 14957
     - Error message is displayed incorrectly after calculated field contains a field that is no longer available
   * - Defect
     - 14959
     - Image from relative path does not display in exported file for Tenant Logo
   * - Defect
     - 14960
     - Incorrect Error message displayed when report is missing fields in data model "This report is no longer valid..." & the Design button in reportviewer
   * - Defect
     - 14962
     - System shows the list full data on Sub Report before it scale the exactly data base with the selection on master report
   * - Defect
     - 14973
     - Save External Tenant API only updates name deletion, active and description only. Should update all items available.
   * - Defect
     - 14976
     - MS Edge browser has slight spacing issues in report designer and Copy Management.
   * - Defect
     - 14990
     - System shows incorrect value for "Week Number" format
   * - Defect
     - 15073
     -  Subreports on Date Fields showing error, Multiple Values for Fields
   * - Defect
     - 15094
     - System Parameters used in sp params are not correct when using @UserID the report loads with the initial stored value not the current user id
   * - Defect
     - 15132
     - Filter doesn't apply to second tile in dashboard (even after "Update" is clicked) until the filter is modified.
   * - Defect
     - 15141
     - Error received when grouping fields in a grid, "The given key was not present in the dictionary."
   * - Defect
     - 15152
     - Performance issue occurs when adding some fields to ROWS container
   * - Defect
     - 15174
     - Advance Settings page displays missing a part of "Determine common filter for the same field based on" content on laptop
   * - Defect
     - 15178
     - Connection Builder Syntax is incorrect for some supported databases
   * - Defect
     - 15182
     - Charts do not display resized properly in mobile mode, user must scroll horizontally to see entire chart
   * - Defect
     - 15190
     - System shows 2 progress bar on Report Viewer page when user click on Field Header to Sort data
   * - Defect
     - 15207
     - Updated User Name is not displayed on Report List - Report Owner, Create By, Last Edited field
   * - Defect
     - 15231
     - Rule swap 2 DS is not applied when user creates relationship with Key Join
   * - Defect
     - 15236
     - Unable to select the field with suffix in field selection popup.
   * - Defect
     - 15242
     - System should allow user back to data source tab, instead of display the information message when distinct is not valid
   * - Defect
     - 15244
     - Horizontal Grids: column widths settings don't work the same way as Vertical Grid column widths
   * - Defect
     - 15271
     - Relationships additional Key Join Field's Length is too short to show data value
   * - Defect
     - 15277
     - SP set up for date values will not accept blank inputs
   * - Defect
     - 15285
     - The Preview does not reload page when changed setting from Link to Icon or vice versa on custom url/or js
   * - Defect
     - 15292
     - Field Name alias change is lost in some scenarios
   * - Defect
     - 15298
     - System shows error msg when user creates Key Join which has Time value in comparison
   * - Defect
     - 15305
     - When Printing A Form, Only the Content in Viewport is Rendered, Page Breaks don't work
   * - Defect
     - 15309
     - System does not set default Filter Operator for Time data type
   * - Defect
     - 15327
     - Expand/Collapse icon is not on the same line with the owner data sources which were truncated text
   * - Defect
     - 15334
     - The green check-box and red X icon appear then disappear when user clicks Preview button in Subtotal Settings pop-up
   * - Defect
     - 15335
     - The green check-box and red X icon is displayed when user open Subtotal Settings popup then click OK button
   * - Defect
     - 15340
     - Copied reports when edited in designer show a small blank error with no details and no log errors
   * - Defect
     - 15355
     - Field name alias is duplicated if coming out Field Property panel without focusing any field before.
   * - Defect
     - 15367
     - The page continues to load without data while system joins 3 tables with operators <> equals
   * - Defect
     - 15369
     - In Oracle After changing operator in relationship, results do not update when navigating to Fields page
   * - Defect
     - 15391
     - User with Full Report and Dashboard Access is Shown with Simple Data Sources In Role Summary
   * - Defect
     - 15392
     - Custom function from CustomFunction.config file should not displayed on list functions of Grand Total/SubTotal
   * - Defect
     - 15396
     - Bar Chart X/Y Labels Correspond with Opposite Axis
   * - Defect
     - 15398
     - Subtotals on Drill Down Grid Inaccurate When Collapsed
   * - Defect
     - 15418
     - Using Azure System does not update the data in Preivew section when the Join Operator of Relationship is changed
   * - Defect
     - 15430
     - Inaccurate sorting on text fields containing letters and numbers
   * - Defect
     - 15435
     - User can not drag and drop the Key Join in data source tab of report designer
   * - Defect
     - 15437
     - System shows Detect change icon on all stored procedure Fields after user re-assigns this item from Available to Visible on Connection String page
   * - Defect
     - 15438
     - General error message shows when copying a report using a field with alias as filter.
   * - Defect
     - 15439
     - Sorting still applies on special data type (ex: photo)
   * - Defect
     - 15441
     - Missing progress bar when user update relationship/key join and navigate to Fields and view the updated data
   * - Defect
     - 15455
     - Filter is still available in the list even it is deleted from filter container
   * - Defect
     - 15468
     - For Simple Datasource Mode Subtotal/Grand total preview does not show when having at least 1 relationship
   * - Defect
     - 15469
     - No tooltip displays when hovering over Column Group text field
   * - Defect
     - 15470
     - No record found if both master and sub reports' datetime fields are not formatted
   * - Defect
     - 15472
     - Datetime fields Between function, the TO date/time should be restricted to be after the FROM datetime
   * - Defect
     - 15479
     - Background color is limited by the initial report part's right border
   * - Defect
     - 15480
     - Calculated Field in Postgres System shows error msg when user use DateDiff function in Expression field of Calculated Field
   * - Defect
     - 15481
     - System does not overwrite the custom define function with the system function
   * - Defect
     - 15483
     -  Collation Issues, Invalid object name 'SYS.FOREIGN_KEY_COLUMNS'.
   * - Defect
     - 15494
     - Some values fail to appear on Chart Legend
   * - Defect
     - 15497
     - Pivot Grid Column Field Text Color Does Not Change
   * - Defect
     - 15505
     - When editing a calculated field, system shows itself on the list CF drop down list when user edit Expression
   * - Defect
     - 15508
     - System always show dirty form msg while user does not do any action on SP page then navigate to another page
   * - Defect
     - 15522
     - When altering the browser resolution after initial page load the filter's lazy loading feature stops working
   * - Defect
     - 15544
     - Error message displays incorrectly when add an invalid expression for Calculated Field
   * - Defect
     - 15596
     - Field Formatting is not Respected when Switching Grid Types
   * - Defect
     - 15622
     - Refresh on Tenant Report Viewer, the list category of System level is displayed on left navigation instead of the list items of selected Tenant
   * - Defect
     - 15645
     - [Equals (Tree)] Order in Filter drop down list is incorrect
   * - Defect
     - 15652
     - System loads the grey content below Reconnect button after user saving a first new connection string
   * - Defect
     - 15661
     - Forms: External Stylesheets Can Be Referenced In Forms, Styles Removed If The Visual Content is Modified.
   * - Defect
     - 15662
     - Modifications to CSS in project do not take effect on exports (tested in standalone)
   * - Defect
     - 15698
     - Embedded data on Form is not displayed again when user update Filter value and then remove all Filter value on Dashboard
   * - Defect
     - 15700
     - Data in drop down list of Field Comparison is displayed incorrectly
   * - Defect
     - 15701
     - Drop down list of Filter is not loaded smoothly
   * - Defect
     - 15703
     - When Copy Reports with Form having more than 1 part in Embedded Sub-report, Run Copy fails
   * - Defect
     - 15708
     - Shouldn't check license validity when using invalid connection string to setup config database initially
   * - Defect
     - 15743
     - In Key join value when user uses Home/End key in text field the value changes to -number
   * - Defect
     - 15747
     - Database Mapping, Merge duplicate mapping checkbox only displays for All Mapping option
   * - Defect
     - 15754
     - For charts Hover Label Checkbox Does Not Remove Hover Labels
   * - Defect
     - 15763
     - Missing progress bar on Report List for Tenant level when user navigates from other page to the Report List
   * - Defect
     - 15771
     - For tenant users  following icons in the report card should not be shown on global reports, rename Delete, and Move
   * - Defect
     - 15777
     - Copied report is broken when user update Relationship Join Alias and run copy again
   * - Defect
     - 15787
     - When creating a Form, some added Fields can be deleted when user press backsapce on keyboard
   * - Defect
     - 15789
     - For system users in tenant level the following icons in the report card should not be shown on global reports, rename Delete, and Move
   * - Defect
     - 15803
     - Report list is temporarily blank when changing the search from subcategory to category on subreport popup selection screen
   * - Defect
     - 15817
     - In Copy Console Sub Report setting is removed after user run Copy Dashboard & Report
   * - Defect
     - 15818
     - On Global Dashboard Missing the tooltip "Enter to create new category/sub-category" when set value into category/subcategory dropdown
   * - Defect
     - 15820
     - Current report should not be displayed on list of sub-report selection list
   * - Defect
     - 15821
     - Database mapping is Missing error message when mapping 1 schema/DB to 2 different schema/DB
   * - Defect
     - 15822
     - For System Admins Setting level is still available at FIELDS page when opening an existing report
   * - Defect
     - 15823
     - Remove loading all data of filters on report rendering as it is lazy load
   * - Defect
     - 15824
     - Expand arrow in data source tree flow off when resizing the middle panel
   * - Defect
     - 15861
     - When saving Global report system should not show message M23/M24 in save popup without sharing with role/user
   * - Defect
     - 15870
     - In Copy Management, data in Content panel is displayed incorrectly in search result
   * - Defect
     - 15886
     - Category/Subcategory drop-down does not show data value in TenantLevel/SystemUser/TenantUser
   * - Defect
     - 15902
     - System lost the mapping Field for Sub report in Destination Report when copying Dashboard and Report.
   * - Defect
     - 15903
     - Report List is missing highlight state on selected category
   * - Defect
     - 15904
     - Destination category/subcategory should be selected with newly moved report in it
   * - Defect
     - 15912
     - In User Setup, When You Input Non Decimals, Timezone Data Offset Breaks Datetime Filters In Reports 
   * - Defect
     - 15925
     - In Global Report Role list is not sorted by AZ for access rights dropdown
   * - Defect
     - 15945
     - No roles/users are displayed when tenant user with Full Report and Dashboard access shares their reports to role/user
   * - Defect
     - 15962
     - On Database Mapping save button is not functioning after deleting a tenant then the whole row
   * - Defect
     - 15966
     - In Oracle Error displays when report contains at least 1 calculated field filter and aggregated field in container
   * - Defect
     - 15967
     - After unchecking some data sources in data model copy, the confirmation for overwrite shows items not expected 
   * - Defect
     - 15968
     - Copy Management Global reports/dashboards display in copy management's UI
   * - Defect
     - 15970
     - Filtered connection list shows sources not used in copy management database name dropdown based on selected report/dashboard
   * - Defect
     - 15971
     - Search function works incorrectly in some cases on Report List
   * - Defect
     - 15981
     - When saving form, some fields loose format for a moment on screen, but appear properly after save completed
   * - Defect
     - 15996
     - Report Designer > Report Body > 'Reset Zoom' Dialogue Causes Drilldown
   * - Defect
     - 16040
     - The message displays "The template....." wrong, instead of "The report...." when user Copies/Moves a report
   * - Defect
     - 16043
     - The Created Date value isn't updated correctly after user copies/moves a report
   * - Defect
     - 16059
     - Pie/donut/funnel chart does not render properly on dashboard when using separator and many records present until user resizes tile
   * - Defect
     - 16237
     - Chart is not show when using a CF created in the data model with an alias when used in chart
   * - Defect
     - 16246
     -  Global reports containing Embedded settings subreports are not able to share
   * - Defect
     - 16250
     - Stored Procedure Schema Incorrect When Changed
   * - Defect
     - 16252
     - Lookup values set in the data model are not available in the dashboard filters
   * - Defect
     - 16260
     - Fields list fails to load when turning the report part to back side right before it finishes loading.
   * - Defect
     - 16262
     - The default date format should be updated when its data formatting is ...
   * - Defect
     - 16278
     - Unit label not displayed on Linear Gauge report
   * - Defect
     - 16290
     - Saving Reports in Firefox results in Unresponsive Script error
   * - Defect
     - 16291
     - Filters created on Numeric Calculated Field Break Cascading
   * - Defect
     - 16293
     - Placeholder data shown in form Border Settings
   * - Defect
     - 16296
     - When using a Mac and Chrome browser Hover area is incorrect when using drop down box Setting level
   * - Defect
     - 16318
     - Empty error message displays when editing a report and selecting a value for filter and then saving the report
   * - Defect
     - 16324
     - Report part links do not properly redirect users to the report viewer in integrated modes.
   * - Defect
     - 16354
     - Maps seems to have difficulty with US Maps without territories, if data for a US territory is available.
   * - Defect
     - 16377
     - In Report Viewer and Dashboard Warning message does not display when physical table is deleted on database
   * - Defect
     - 16380
     - Data model's connection string Lost highlight focus after saving a connection string
   * - Defect
     - 16394
     - In Copy Management user cannot un-check the "Show only my workspaces" checkbox
   * - Defect
     - 16395
     - Filter Operator list of stored procedure only shows the selected value after moving to Fields tab
   * - Defect
     - 16411
     - Grammar issue in popup message while deactivating role
   * - Defect
     - 16413
     - In Data Model Invisible database still displays in Database Name list in Filter Value pop-up
   * - Defect
     - 16414
     - Dashboard Text tile type the Body Text is not displayed and disappears while switching to Preview and Config modes
   * - Defect
     - 16420
     - In report designer 'X' button shows a redundant dot and is not horizontally aligned
   * - Defect
     - 16431
     - Delete filter and Information filter icons are overlapped in report designer
   * - Defect
     - 16444
     - Json node createdBy and modified are incorrect when saving a new category
   * - Defect
     - 16449
     - User can view report in dashboard that has column of Data Source that has been changed to be not visible in Data Model
   * - Defect
     - 16450
     - Edit Report button exists when user has been shared report with "View only" mode
   * - Defect
     - 16501
     - User can not use mouse to drag the scroll bar of the drop down list of Time picker in schedule/subscription/key join operator for time fields.
   * - Defect
     - 16505
     - System shows error msg when Key Join has Time with Time comparison operator group
   * - Defect
     - 16512
     - The filter set on the calculated field is not inherited in subreports even though both reports have the same calculated fields and datasources
   * - Defect
     - 16513
     - Subreport's existing filters are Ignored When Inheriting from Parent
   * - Defect
     - 16517
     - Sub total and Grand total are not exported on CSV on Export
   * - Defect
     - 16530
     - Concurrency error message appears when updating and saving any changes on Security tab of data model after the second change
   * - Defect
     - 16531
     - No message appears in the report when clicking Update Result with required filter has no value
   * - Defect
     - 16534
     - When deleting current version of report is history screen deleted report & category are not removed from Report List
   * - Defect
     - 16538
     - Error displayed when user attempts to sort values for input parameters of stored procedures in report designer.
   * - Defect
     - 16541
     - The "Configure Password Options" is disabled when adding new users although user has checked "Configure Password Options" permission on role
   * - Defect
     - 16549
     - Map presents Postal Code in incorrect location/Country when zip code is duplciated
   * - Defect
     - 16550
     - Missing highlight of the focus item in middle panel of integrated kit example on MVC
   * - Defect
     - 16551
     - In Form report part user cannot uncheck "Visible" of fields on Field Properties -> Data Source
   * - Defect
     - 16552
     - For map report part Bubble does not show for USA while drilling down into North America area
   * - Defect
     - 16564
     - User should not be able to navigate to other screens while pop-up is opening by pressing Back or Alt+Left key
   * - Defect
     - 16566
     - In IE child popup of Add Calculated Field does not appear in the proper position to parent popup
   * - Defect
     - 16576
     - Grand Total columns are out of alignment with the field columns when user changes field width
   * - Defect
     - 16579
     - Date formats in "Long Date & Long Hour" style export incorrectly in XML, JSON and CSV
   * - Defect
     - 16587
     - When using Oracle error displays when drilled down on a chart/gauge with datetime field in X-axis
   * - Defect
     - 16597
     - In Quick Edit mode filters Inherited from a Parent Report to a Sub Report are not retained after pressing "Update Result"
   * - Defect
     - 16601
     - Tables are overlapped with long name when viewing in schema view of data model
   * - Defect
     - 16602
     - Tenant Access label is cut off in the Tenant Permission screen in MVC kit
   * - Defect
     - 16603
     - In Schema Diagram large models are unable to fully display
   * - Defect
     - 16651
     - Failed to execute Oracle and Postgres Stored Procedures when input param is Ref Cursor
   * - Defect
     - 16660
     - Relationship connector in Schema diagram is not properly aligned on some tables
   * - Defect
     - 16661
     - Query execution is blank if report part uses calculated fields
   * - Defect
     - 16691
     - PDF exports are scaling some reports on export where font is smaller than anticipated
   * - Defect
     - 16718
     - Template/Report name in Save popup is always 'Example Template/Report Name' although the name edited in Report Design
   * - Defect
     - 16720
     - City's metric is not shown in Country Map
   * - Defect
     - 16723
     - Only popup header displays after clicking Search then clicking Reset button immediately after
   * - Defect
     - 16741
     - Values list of filter 2 is not updated based on the selected value of filter 1 when 'Cascading' is checked
   * - Defect
     - 16750
     - Cross filtering is not properly applying to dashboard when user is in presentation mode.
   * - Defect
     - 16751
     - User is able to edit the email's content while system is sending email
   * - Defect
     - 16761
     - Using Round function in a calculated field is not returning the proper results
   * - Defect
     - 16768
     - User is getting error message 'The application has encountered an unknown error..' instead of kicking out to the Login page after the session is expired.
   * - Defect
     - 16771
     - Mouse cursor is not released when resizing the grid columns columns in report designer
   * - Defect
     - 16774
     - Created Date, Number of Views and Average Rendering Time of copied report still keep values of the old report.
   * - Defect
     - 16777
     - I report designer info of deleted filter still displays in Filter Properties drop down when un-selecting its associated data source.
   * - Defect
     - 16798
     - An error is shown when User saves a report without image on header.
   * - Defect
     - 16799
     - Close button on report viewer and dashboard does not work in some integrated environments
   * - Defect
     - 16801
     - Filter values in drop downs are sorted A->Z when sorting Z-A
   * - Defect
     - 16803
     - When editing a form report and saving the field names and variables for global mappings show in the UI.
   * - Defect
     - 16804
     - Cannot save. Message "Join Alias cannot be duplicated with the Data Object or Foreign Data Object" should display
   * - Defect
     - 16813
     - Report's format properties are missing in Printed version of report (Footer/Logo/Generated/User/Tenant)
   * - Defect
     - 16848
     - In Horizontal Grids Text of columns should be left-justified for consistency
   * - Defect
     - 16849
     - In Angular2 integration kit form report parts are not working for both Visual and HTML panes
   * - Defect
     - 16850
     - Min & Max of Gauge report have 14 decimal digits while value has only 2 decimal digits in db
   * - Defect
     - 16855
     - System can draw the gauge report part with incorrect min & max when Scale To = the min data value returned from database
   * - Defect
     - 16856
     - Filter Alias displays name incorrectly after changing aggregated function in Configuration section of field from something like Sum(Field) to Count(Field)
   * - Defect
     - 16858
     - In Report Designer using gauge system displayed text [UNDEFINED VALUE] as label for value "0", "null" when drilldown is used on a report
   * - Defect
     - 16860
     - When Cross Filtering of Calculated Fields as Filter, system shows no record found after query filter using with calculated field
   * - Defect
     - 16864
     - In copy management UI when user updates workspace's name, System shows "No changes found"
   * - Defect
     - 16867
     - Cross Filter section and Delete icon is displayed when user does not set config for Cross Filtering
   * - Defect
     - 16868
     - System shows unknown error when user creates a map using a stored procedure
   * - Defect
     - 16872
     - In Report Designer grids, user is unable to set Color Settings with 'Value Range' or Percentage Range' type after setting color with 'Value' type
   * - Defect
     - 16873
     - In scheduled instances the same emails are sent to cc-list more than one time (in case more than one email recipient put in to-list)
   * - Defect
     - 16876
     - In Report Designer with aggregated field as filter, error message displays "The application has encountered an unknown error.." after removing aggregated field in Configuration section
   * - Defect
     - 16877
     - Error message 'No result found' appears when clicking on Custom URL link on Chart after adding Separators
   * - Defect
     - 16880
     - System is not properly updating from custom field formats to standard one when changed
   * - Defect
     - 16881
     - Using stored procedures decimal Accuracy Is Not Being Respected
   * - Defect
     - 16882
     - Forms do not render image data types
   * - Defect
     - 16885
     - Postgres SQL issue with saving Connection String when input parameters exceed field length.
   * - Defect
     - 16888
     - Dirty Form validation is missing when user changes list Tennant in connection string mapping for global report setup.
   * - Defect
     - 16891
     - The second metric gauge of the first group is not properly spaced from the first one when Item(s) Per Row is not a multiple of number of metrics
   * - Defect
     - 16892
     - When using custom formats as field mapping values for subreports, the values do not match. System is passing formatted values, instead of the raw data for field mapping.	
   * - Defect
     - 16893
     - Chart/Gauge tile is blank after closing the presentation mode on dashboard until user clicks update results
   * - Defect
     - 16918
     - Report freezing in design mode when users tries to edit charts by editing the field aliases and other settings on chart and field properties.
   * - Defect
     - 16932
     - In Report Designer Field Properties system is missing validation for Value Range/Percentage Range type in Color/Alternative Text
   * - Defect
     - 16956
     - System failed to generate the gauge report when Label (X-axis) is a DateTime field with Function as 'Average Days Old'
   * - Defect
     - 16961
     - Popup subreport headers should show Sub report's name instead of fixed label 'Subreport'
   * - Defect
     - 16967
     - Runningsum function in calculated fields is not displaying the proper values
   * - Defect
     - 16981
     - The wording for the license expiry is incorrect. It states now "The license expired 6 number of days ago"
   * - Defect
     - 16990
     - Mouse cursor is not released when resizing the grid columns columns in report designer
   * - Defect
     - 17006
     - Missing records in printing
   * - Defect
     - 2972
     - Relationships are not arranged well in the schema tab of the data model and difficult to read as the tables overlay the connectors
   * - Defect
     - 9200
     - Between values are not validated in filters to ensure beginning value is less than ending value
