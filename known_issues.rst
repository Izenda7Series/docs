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
     - 18257
     - Schema query which pulls data to data model should include database name in where clause based on given database from connection string.
   * - Defect
     - 18256
     - Javascript declarations were being deleted upon using the visual tab.
   * - Defect
     - 18249
     - Error in IE/IE Edge with params of datetime used in URL with integrated Angular environment.
   * - Defect
     - 18241
     - When creating a calculated field with physical field, if user attempts to alias this calculated field with the actual field name the system should show duplicate validation message (this should be the same for field or filter alias)
   * - Defect
     - 18237
     - Null values should show blank in pivot/drilldown but showing as 0
   * - Defect
     - 18233
     -  Content section scales after User open "Subscribe" page
   * - Defect
     - 18230
     - Chart with Drill down with date format other than year shows no results when user drillsdown to next level on chart.
   * - Defect
     - 18229
     - When using embedded mode the URL for Custom URL and Custom JS on field values are encoded twice and cause navigation issues to the links.
   * - Defect
     - 18228
     - Change query structure for saving role details to improve performance.
   * - Defect
     - 18227
     - The head and body tag inside form html content is automatically removed when click to save report
   * - Defect
     - 18221
     - Sorting is lost on field that is not visible on drilldown grid.
   * - Defect
     - 18219
     - "No record found" and drilldown breadcrumb text overlap in gauge report part when there are no records in the gauge
   * - Defect
     - 18218
     - Error is received when using "Function" other than Group  for fields in "Labels (X-axis)" of gauge
   * - Defect
     - 18217
     - No record is found when searching relationships of report designer when using  "Uncategorized" in datasource
   * - Defect
     - 18215
     - Required filter warning shows Position and # and should only show # of filter in viewer.
   * - Defect
     - 18213
     - Report header is readable in the report viewer, but the spacing is overlapped in Word export.
   * - Defect
     - 18209
     - Scatter chart labels are shown incorrectly, value label is shown as label and label for y axis
   * - Defect
     - 18204
     - In Edge Browser the HTML of form is shown in visual tab
   * - Defect
     - 18176
     - Hamburger for category shows in report/dashboard view mode for mobile screens
   * - Defect
     - 18174
     - Export to Excel fails when field mapping to subreport is added to pivot
   * - Defect
     - 18170
     - In Report Designer Data source tab, the drop down list of Join Field/Field is not reset/disabled when data in Data Object/Foreign Data Object is blank
   * - Defect
     - 18168
     - Join Alias is still displayed if user adds 1 new relationship and selects the Data Object which is duplicated with Data Object in relationship below
   * - Defect
     - 18167
     - The warning "Share With Everyone" cannot be used multiple times" message is displayed when user add Sharing access and click Save button many times
   * - Defect
     - 18165
     - Cannot render multiple Izenda components in only one Angular 2 component, relate to routing mechanism in Izenda.
   * - Defect
     - 18161
     - Permission Summary shows "Can create new category?" instead of "Can create new report?" under Report Categories/Sub Categories permission
   * - Defect
     - 18159
     - User cannot select System Variables in Delivery tab when add/edit a Schedule
   * - Defect
     - 18158
     - Validation relationship still passes when there is a change to the data type (on physical data base field) of fields that before were the same data type
   * - Defect
     - 18156
     - The "File Location" is shown in "Delivery Type" drop down for subscription and should not
   * - Defect
     - 18151
     - Query results differ from chart to grid 
   * - Defect
     - 18150
     - Tool tip for Query Timeout in Advanced Settings is incorrect.
   * - Defect
     - 18145
     - Database IP address is disclosed when calling "/api/connection"
   * - Defect
     - 18143
     - Dashboard Scrollbars were Difficult to See with Dark Background Colors
   * - Defect
     - 18142
     - Dashboard tiles do not properly resize when user resizes browser to responsive mode in screen. 
   * - Defect
     - 18141
     - Custom Functions could not be Nested in the Expression Builder
   * - Defect
     - 18140
     - Field deleted in the physical database is still shown with field name in form, should show as "..."
   * - Defect
     - 18138
     - Workspace can be saved with duplicate name when clicking on Save button of Save popup many times
   * - Defect
     - 18137
     - Count function on field level settings is incorrect when user turns on convert null to blank. 
   * - Defect
     - 18136
     - Cursor always comes back the left most of Search Report textbox after entering some text in Copy Management UI
   * - Defect
     - 18132
     - No roles/users are displayed when tenant user with Full sharing access in their role
   * - Defect
     - 18129
     - Destination dashboard is empty when copying dashboard without overwrite on second copy
   * - Defect
     - 18126
     - Changing format of Format-bullet List  It's difficult in the Form report part type
   * - Defect
     - 18124
     - Internet Explorer, Right click on report part header does not work
   * - Defect
     - 18123
     - Adding a new field removes Embedded JavaScript from first field (On Field Properties Panel). Clickable link still available on first field.
   * - Defect
     - 18122
     - [Integration] Angular Kit shows circle loading forever when hitting refresh a report viewer page
   * - Defect
     - 18120
     - Users receive repeated emails in Schedule function for some emails, this is sporadic functionality 
   * - Defect
     - 18118
     - In Tenant Setup Standalone only List of existing System Roles are displayed on the Access/Schedule section on new Tenant Permission
   * - Defect
     - 18116
     - Disabled "add key join" icon is able to add a new key join when using cross join in relationship
   * - Defect
     - 18115
     - In Data Model "Duplicate" error appears when alias name has a string that includes schema
   * - Defect
     - 18112
     - When using crossfiltering and chart breadcrumb trail to drill up in the chart the top level of the chart is filtered to the first element drilldown on
   * - Defect
     - 18098
     - Deleted filter Field is still displayed on existing scheduling/subscription after deleting report filter.
   * - Defect
     - 18097
     - Filter description is displayed incorrectly when user uses Field comparison with a Data Source - Field has Join Alias
   * - Defect
     - 18095
     - Using aggregated field as filter with field comparison filter type shows error in report.
   * - Defect
     - 18093
     - System shows dirty form message but no response after that when user config Custom URL on field with option Open Link in Current Window
   * - Defect
     - 18090
     - Remove Dirty Form validation for report viewer page to avoid notification to user that changes will be lost when they have no ability to save a report.
   * - Defect
     - 18089
     - Syntax error in SCSS file Izenda.Common.scss
   * - Defect
     - 18085
     - The Confirm message is not shown when User invisible "Separator" container which have value
   * - Defect
     - 18083
     - Foreign Data Object and Field are not enabled when copying Key join with operators
   * - Defect
     - 18082
     - Border icon is shown as checked after user removes the setting in chart/gauge/map/form
   * - Defect
     - 18080
     - User can save duplicated Report Category by sending "POST Report" request multiple times with non-existing categoryID
   * - Defect
     - 18079
     - Changing Items per page expands redundant spaces of the first row of Data Model Page
   * - Defect
     - 18078
     - Sub Total is counted incorrectly when sorting in grid
   * - Defect
     - 18074
     - Subtotals of side total on Pivot grids is incorrect 
   * - Defect
     - 18073
     - Side Total in Pivot Are not calculating properly
   * - Defect
     - 18072
     - Drag and Drop functionality in the report designer is not working in FireFox browser
   * - Defect
     - 18068
     - Loading bar continues to show after User input character in "Width" text box and save Report
   * - Defect
     - 18066
     - "Reset to Default value" icons for Data Offset and Timestamp Offset work incorrectly and missing tooltips
   * - Defect
     - 18064
     - List of existing Fields are not displayed fully in Field Selection pop up of Report Designer Calculated Field
   * - Defect
     - 18057
     - System shows no record found when user create sub report mapping via calculated field
   * - Defect
     - 18056
     - System works incorrect when sub category is duplicated with another category
   * - Defect
     - 18055
     - System shows incorrect value for Sub Total if date field has format, when user attempts to format the subtotal the data shows no results.
   * - Defect
     - 18054
     - Duplicated Data Object is not automatically swapped at tenant level/ tenant user
   * - Defect
     - 18053
     - Setting levels is enable when refreshing a report in report designer
   * - Defect
     - 18052
     - System level remains if pasting a tenant level dashboard url  into browser while being at system level
   * - Defect
     - 18051
     - User can add/edit a CF in "Calculated Fields" group with "Field Name" which is a duplicate with "Field Name" of a existing actual field
   * - Defect
     - 18042
     - System shows error msg when user creates nested CF with aggregated function
   * - Defect
     - 18041
     - Sort control on report list disappears in responsive mode until screen is refreshed
   * - Defect
     - 18040
     - Dashboard save popup overflows in responsive mode
   * - Defect
     - 18039
     - Name, title and description of dashboard tile part are overlapped in Presentation mode
   * - Defect
     - 18038
     - Hover Text positioning is incorrect on chart with separator and only one value. 
   * - Defect
     - 18035
     - Data is not updated in Report Preview and Report View mode after User replace the invalid CF field to a valid field.
   * - Defect
     - 18032
     - No Error indicator shows when User select style "Embedded" without select "Report Part(s) Used
   * - Defect
     - 18031
     - One of report parts disappears if embedding 2 same type report parts on form report
   * - Defect
     - 18029
     - Percent of group format is showing percent of total on drilldown grids.
   * - Defect
     - 18028
     - Unable to save workspace when select Data Mode and Dashboards items in Copy Management.
   * - Defect
     - 18026
     - User is unable to Unable to delete an invalid report part in dashboard after adding
   * - Defect
     - 18025
     - XY-Plane Settings: Axis's text background color settings does not work
   * - Defect
     - 18023
     - System shows blank value on filter value for parameter of stored procedure on Schedules/Subscriptions after saving
   * - Defect
     - 18018
     - APIs - connection - User can access some function of module "connection" via API
   * - Defect
     - 18013
     - Time and Timestamp data types are not returned from PostgreSql functions when created a stored procedure.
   * - Defect
     - 18008
     - After removing a data source from available in the data model, report still runs in viewer. When editing the report the fields are removed, but the viewer should show the report as needing edits to remove the fields no longer available.
   * - Defect
     - 17999
     - User is returned to specific report category after close from Quick Edit, when they never selected a category from the report list. 
   * - Defect
     - 17998
     - APIs - advancedSetting - User can access some function of module "advancedSetting" via api
   * - Defect
     - 17994
     - When user reloads screen using F5 after removing data source the system errors and data source is lost, even though user has not saved report changes.
   * - Defect
     - 17993
     - GUI - Connection String - User can access IzendaDB by using encrypted connection string pasted into the UI Connection String
   * - Defect
     - 17992
     - APIs - databaseSetup- User can access some function of module "databaseSetup" 
   * - Defect
     - 17991
     - APIs - License - User can get Izenda "License Key and Token" by sending request to "api/License/currenttoken"
   * - Defect
     - 17989
     - APIs - role - User can deactivate role by sending "POST role/deactive/{id}/{tenantId?}" 
   * - Defect
     - 17988
     - APIs - report - User can delete archived version by sending request to "api/report/deleteAllArchiveVersions"
   * - Defect
     - 17984
     - Data source categories sort incorrectly if all data sources are categorized
   * - Defect
     - 17981
     - Date Offset works incorrect on Global Report
   * - Defect
     - 17978
     - The light bulb icon is overlapped with the expression when CF length is too long
   * - Defect
     - 17977
     - Calculated Field Name is not updated on the popup after the second time the user modifies CF name in Field Name under DataSource tab
   * - Defect
     - 17974
     - SubTotal/Grand Total popup is still showing the new updated expression after pressing Cancel when user did not click ok to save
   * - Defect
     - 17973
     - New Filters added in quick edit mode do not show in Report Filter Info (show filters under report description) until user saves the report.
   * - Defect
     - 17971
     - No Error message is shown when User validates syntax pf filter logic when some Filters are selected without  "Filter Operator"
   * - Defect
     - 17970
     - The reports are collapsed when user scrolls down to bottom after clicking expand icon on top right page, when lazy loading is applied
   * - Defect
     - 17969
     - Scheduled and Subscribed reports can be sent without required filter values 
   * - Defect
     - 17966
     - Incorrect Confirmation message popup displays when User change filter Name from property panel and no other changes are made
   * - Defect
     - 17965
     -  the operator drop down list is not update after User change to other filter.
   * - Defect
     - 17960
     - Copy report message says "template" instead of "report"
   * - Defect
     - 17956
     - The colored notification icon doesn't disappear on DataModel/Views after delete field
   * - Defect
     - 17953
     - Category selected in report list looses focus and highlight after user moves mouse off of category
   * - Defect
     - 17952
     - "This filter has duplicate filter alias" displays after deselecting, then selecting a Store Procedure again in datasource tab
   * - Defect
     - 17947
     - PDF scaling is incorrect, the page is not fully utilized.
   * - Defect
     - 17934
     - Data Model change notifications would not disappear upon saving.
   * - Defect
     - 17931
     - Grid Padding when text is right justified is not correct when exporting to word
   * - Defect
     - 17929
     - Sub Total is counted incorrectly when user add 1 Field to separator 2 times
   * - Defect
     - 17927
     - Categories displays categories incorrectly when category and sub category same name
   * - Defect
     - 17925
     - System runs incorrect data for divide function when calculating value in  Memory
   * - Defect
     - 17921
     - The list of filter operator type is NOT updated correctly when filter field is Count(DateTime/Text)
   * - Defect
     - 17917
     - Page unresponsive when Preview Records of Heat Map is more 1000 records
   * - Defect
     - 17915
     - In Form Grand Total/SubTotal Change Function in Sub Total pop up, is not properly changed when user updates, the user must update is again
   * - Defect
     - 17909
     - Filter Operator should be reset to appropriate default value after the filter field is changed
   * - Defect
     - 17908
     - Filter Properties should be updated correctly when the aggregated field is removed from the values container
   * - Defect
     - 17907
     -  Lazy load progress bar does not displays at the bottom of the page in Filters and User setup
   * - Defect
     - 17901
     - Map fails to redraw if adding field to value container after going back from datasource
   * - Defect
     - 17890
     - Header/footer {datetime} field does not display time in the report viewer only date
   * - Defect
     - 17886
     - User cannot change filters on any report/dashboard where pvalues were set in url or by inheriting the values from the master report. The system should accept the new values the user entered once the report is open.
   * - Defect
     - 17878
     - When modifying a field Alias Report shows "This field is invalid" for field with Grand Total/SubTotal if field alias used more than once in calculation
   * - Defect
     - 17875
     - Selected Field of SubTotal/Grand Total is not displayed when user selects a smart tag Subtotal/Grand Total to view it
   * - Defect
     - 17865
     - The system highlights the wrong filter field when User doesn't select Filter Operator when using 2 stored procs with params when setting value for second filter but omits value for first filter
   * - Defect
     - 17851
     - Mapping Field is not updated automatically when user updates Join Alias on both master and subreport
   * - Defect
     - 17849
     - Map report part, State/Province field is overlapped in screen resolution 1366x768
   * - Defect
     - 17848
     - List of Inherited Filter of Master Local report is not displayed on Report Designer of sub report when user clicks design to edit the sub report
   * - Defect
     - 17842
     - Lazy Load does not work when user clicks on any category report to open it then closes it to turn back to Report List
   * - Defect
     - 17831
     - Colors (Text & Cell) should only apply to the values in a grid and not the sub total and grand totals. Rule Fails in Excel Exports.
   * - Defect
     - 17829
     - Print always wait for 60 seconds timeout to open Printing dialogue after page rendered
   * - Defect
     - 17828
     - System shows error msg when navigating to subreport when there is multi selection filter on master report, and subreport is set to inherit filters
   * - Defect
     - 17821
     - 'No record found' does not display for Form report part that has no value
   * - Defect
     - 17819
     - System shows error msg when copying a report using copy management which has an aggregated filter
   * - Defect
     - 17808
     - Border color on gird can be changed but is not reflected in the grid. 
   * - Defect
     - 17807
     - The Edit dropdown on the report list would occasionally render off-screen.
   * - Defect
     - 17803
     - Relationship is autmatically dismissed when going back to datasource page and un-checking and re-checking the datasources
   * - Defect
     - 17800
     - Unable to add another report part next to a blank grid
   * - Defect
     - 17799
     - Some charts are cut-off when user prints a report has many report parts
   * - Defect
     - 17796
     - System should not prevent changing an user's role from [non System Admin] to [System Admin]	
   * - Defect
     - 17795
     - pValue filter in URL does not work for DateTime if this Field is not in a Group
   * - Defect
     - 17793
     - In report/dashboard scheduling selected system variables are not added into the email body
   * - Defect
     - 17791
     -  User is unable to copy local dashboard which contains both local report parts and global report parts
   * - Defect
     - 17790
     - Custom URL will not work with partial URL for internal links (example: /report/view/{GUID}
   * - Defect
     - 17789
     - System shows custom URL in new tab after user configured it to open in New Window
   * - Defect
     - 17788
     - Default URL type of Custom URL is not present once this setting is removed and re-added.
   * - Defect
     - 17786
     -  "Case when...then...else...end" function shows the same syntax when selected as "Case ...when...Then...else....end"
   * - Defect
     - 17785
     - When deleting a relationship in the data model and saving - the system shows "no changes found" but should show Details saved.
   * - Defect
     - 17783
     - Using IAdHoc extension to add custom format for DataType.DateTime, these items are not shown in custom section of field format dropdown of report designer. 
   * - Defect
     - 17782
     - The selected report is un-selected after sorting the report list in Report Part Selection
   * - Defect
     - 17763
     - Validation of parameters in white listed database functions error on items like precision.
   * - Defect
     - 17760
     - REST API returns 500 error as host app cannot resolve user info
   * - Defect
     - 17757
     - Report body is resized after user subscribes then un-subcribes to the report.
   * - Defect
     - 17755
     - Using Post request to add database mapping, type value is  not properly verified and user can post invalid data
   * - Defect
     - 17754
     - dataModel/databaseMapping accepts bad data for fromserver value
   * - Defect
     - 17752
     - Deserialization error in reportByProperty API, using  report/reportByProperty/{id} to get JSON, and using JSON.NET to parse ReportDefinition, exception is returned
   * - Defect
     - 17747
     - When setting Data Setup > Advanced Settings > Show Schema Name at system level, this setting is being used at all tenant levels too.
   * - Defect
     - 17744
     - User is able to add duplicate database mappings and save. System should not allow duplicate mappings.
   * - Defect
     - 17735
     - Y-Axis scales would not adjust properly when using the '% of Group' format in charts 
   * - Defect
     - 17734
     - When formatting the y axis of stacked column chart the y axis labels show with this new format instead of %.
   * - Defect
     - 17732
     - Tree Filters would Drop Values on Fixed Length Fields with Trailing Spaces
   * - Defect
     - 17731
     - Opening Global Subreports in the same window would remove Save functions on the underlying Subreport
   * - Defect
     - 17729
     - Date format MM/dd/yyyy HH:mm:ss tt in Izenda exports to excel and shows tt instead of AM/PM format.
   * - Defect
     - 17725
     - Time only fields are not exported with proper formats in excel.
   * - Defect
     - 17724
     - Grand Total configuration is removed when user sets both sub total & grand total then change to HTML tag or Saves report on form report part
   * - Defect
     - 17723
     - In User Set up, There is a error "Uncaught TypeError: Cannot read property 'apply' of undefined" in console log. This error does not affect saving user info but should not be displaying in the console.
   * - Defect
     - 17722
     - 'Number of records' field on report part doesn't work in Quick Edit Mode
   * - Defect
     - 17721
     - When copying a report part type map, fields are not properly copied to new report part in report designer.
   * - Defect
     - 17720
     - When adding a new dashboard tile while dashboard is in presentation mode, screen is not properly redrawn.
   * - Defect
     - 17718
     - Grid - Data shows incorrectly when sorting the column which has subtotal configured 
   * - Defect
     - 17712
     - Chart is redrawn in preview of XY Settings prior to user clicking ok.
   * - Defect
     - 17708
     - The /api/repost/list2?includeHashCode=true, reports are always contained in null subcategories, instead of its actual subcategory.
   * - Defect
     - 17707
     - BREAKING CHANGE - API User/Integration/saveUser should return the newly generated user ID with success response
   * - Defect
     - 17699
     - Using MS Edge, System loads continuously when user opens SubTotal/Grand Total pop up in repeater on a form report part
   * - Defect
     - 17698
     - When user sets cascading to true on any stored procedure input param, but does not override this in IAdHoc Extension, subsequent filter values are not displayed when configured in the data model. Cascading should not be set on stored procedure input params unless the IAdHoc Extension is used.
   * - Defect
     - 17696
     - Redundant css class "btn-primary" in Update Result and Add Report Part button
   * - Defect
     - 17694
     - In IE/MS Edge browsers clicking on 'Full screen' icon or 'Show Next Slide After' textboxes do not respond
   * - Defect
     - 17689
     - Column Alias is lost when executing stored procedure when there is no change to the field in the physical database
   * - Defect
     - 17682
     - In Form ""The report part [ ] is not found' mesage is displays when editing then restoring id of embedded-report	
   * - Defect
     - 17673
     - System shows ability for user to create sub total/Grand total with Boolean using AVG, SUM and SUM Distinct, this is not allowed by database and these options should be removed for this data type.
   * - Defect
     - 17664
     - Cancel button does not work for New Report, data is still in report designer.
   * - Defect
     - 17660
     - Inconsistent sanitation of text in  chart x/y plane titles
   * - Defect
     - 17652
     - Full screen icon is missing from report part on Quick Edit mode of report viewer.
   * - Defect
     - 17636
     - User cannot update data using results in dashboard prior to saving the dashboard. 
   * - Defect
     - 17631
     - Create hard delete process for the IzendaUserRoll table to remove unneeded records.
   * - Defect
     - 17630
     - Change alternating background color from inline style to css class
   * - Defect
     - 17628
     - System shows not unique Field when user creates a calculated field in the report designer a calculated field created in the Data Model
   * - Defect
     - 17627
     - Front Side of Form is blank when user adds Join Alias in Relationship of report containing form report part
   * - Defect
     - 17626
     - When alias are not matching or do not exist from System to Tenant some fields  are not found when using Global Report
   * - Defect
     - 17625
     - Fields with alias in datamodel are removed from form when saving form
   * - Defect
     - 17624
     - System shows error msg when user creates a  calculated field with Round function
   * - Defect
     - 17615
     - When using a Bit data type as separator on chart legend shows series 1 not false
   * - Defect
     - 17614
     - User name in users profile should not be editable in any embedded modes as it is used to keep application in sync and should not be editable.
   * - Defect
     - 17596
     - Tenant users are still seeing some modules after they have been disabled at the Tenant level.
   * - Defect
     - 17583
     - MySQL - Column Sorting is not Alphabetically in Designer when selected in advanced settings of data model.
   * - Defect
     - 17580
     - Chart Exports in Integrated Scenarios Would Cut Off Several Values
   * - Defect
     - 17577
     - Fields added from Data Source which has Join Alias are removed when user saves form report part.
   * - Defect
     - 17576
     - Gauges are not displaying in print preview of report designer
   * - Defect
     - 17569
     - In permission summary page Categories list appears in Scheduling Limits and Access Limits pop-up instead of roles/users list
   * - Defect
     - 17564
     - No record found message displayed when checking 'Page Break After Report Part' in Exporting page without saving the report
   * - Defect
     - 17556
     - Excel would lose certain DateTime formatting on un-grouped fields.
   * - Defect
     - 17554
     - SubReport link from printed PDF and embedded email shows blank page when clicked by user. 
   * - Defect
     - 17540
     - Grouping is not working properly for Separators when date is used and format is changed
   * - Defect
     - 17537
     - Available Users and Assigned User list in Users tab are incorrect when accessing Role Setup screen with Data Model Access and Permissions tabs are hidden
   * - Defect
     - 17536
     - Archived report with everyone-full access access rights does not show Copy and Save As button
   * - Defect
     - 17527
     - User is not redirected to the report from report links after login.
   * - Defect
     - 17526
     - In Key join system shows incorrect validation msg when Time Field in Key Join has no data
   * - Defect
     - 17524
     - When copying a report created from a dynamic stored procedure system shows error message when report is opened.
   * - Defect
     - 17520
     - System shows error when user creates a calculated field which has the same name as a column in table
   * - Defect
     - 17519
     - System shows (GET http:url/undefined 404 (Not Found)) in browser console when using deployment mode 1
   * - Defect
     - 17506
     - Text 'Roles/Users allowed to share with' displays in Scheduling section instead of 'Roles/Users allowed to schedule for'
   * - Defect
     - 17500
     - Date Format showing in system does not follow User configured 'Date Format' in user set up page.
   * - Defect
     - 17495
     - Caching issue when deleting a report using both "Delete" button and version history
   * - Defect
     - 17491
     - When role has email access in report designer but no available delivery methods selected the system should not allow role to be saved as user has no options for sending email
   * - Defect
     - 17489
     - System shows error msg when user creates Key Join which has Time value in comparison
   * - Defect
     - 17488
     - Text 'Can create new reports?' displays in Dashboards section
   * - Defect
     - 17481
     - The Grid automatically collapses when user clicks on 'Expand All' icon when using drilldown grid as an embedded subreport
   * - Defect
     - 17480
     - The print page is cut-off after user prints a dashboard which has grid report
   * - Defect
     - 17458
     - Save button is still enabled when user has no permission to create a new dashboard, but system will not allow user to save the dashboard. The save button should not be displayed. 
   * - Defect
     - 17452
     - Multiple spaces appears when user clicks on Sort function on Form which has style and repeater
   * - Defect
     - 17437
     - Required filters set to not visible in the report designer cause report to fail copy process.
   * - Defect
     - 17434
     - System can not detect the schema of calculated field if there are 2 Data sources used in the report which have the same calculated field name when used in a form report part
   * - Defect
     - 17433
     - System trims some white space on calculated fields when using concat
   * - Defect
     - 17424
     - After making an active copy of an archived report, when emailing the report, the report name in mail is name of active version
   * - Defect
     - 17423
     - Using save As on an archived version of report to create a new active copy, the new report included report part of active version
   * - Defect
     - 17417
     - The calculated field status is not refreshed in some cases.
   * - Defect
     - 17410
     - When setting up a new instance, create new Report/Dashboard options are missing after adding License
   * - Defect
     - 17408
     - Tiles would remain in Configuration Mode when moving to the Report Viewer
   * - Defect
     - 17398
     - User can make an infinite loop in Expression when some calculated fields call each other
   * - Defect
     - 17397
     - Failed to create-new/save-changes report with 'Data Refresh Interval Settings' is checked on Angular2 integration environment
   * - Defect
     - 17395
     - Delete 1 calculated field which is used in another calculated field, the system does not show error message
   * - Defect
     - 17382
     - From emailed dashboard/report sent, email address shows 'SMTP Login' instead of 'Email From Address'
   * - Defect
     - 17351
     - The export process bar shows process status of report part, not entire report
   * - Defect
     - 17349
     - Empty dashboard tile still displays after clicking on Save button
   * - Defect
     - 17345
     - System show error msg after user confirms Yes on Dirty Form (changes made in current session and not saved) but clicks on Stay in browser's confirmation msg
   * - Defect
     - 17338
     - Color icon is checked when Color setting is Null value
   * - Defect
     - 17313
     - Cell Color is set but icon is not checked to show value is set in report designer
   * - Defect
     - 17312
     - The Custom URL and Embeded Javascript options should not be shown shown on Bubble Metric Field in Map. 
   * - Defect
     - 17311
     - System keeps changes made on data source tab on the report after editing  and then navigating to other screen with Leave option
   * - Defect
     - 17309
     - The save as option of dashboard keeps version number of the original dashboard in the newly created one
   * - Defect
     - 17308
     - Report Part created from relationship still displays although the relationship has been removed.
   * - Defect
     - 17305
     - In Data Model, the wrong confirm message displays when clicking on delete icon of one customized report relationship if there is any report created from the existing relationship
   * - Defect
     - 17300
     - UI of slide show panel on Presentation mode of Dashboard is not aligned on FireFox and IE11
   * - Defect
     - 17298
     - The new report part is not focus if added after a long grid report 
   * - Defect
     - 17292
     - Searching of Report History is not trimmed to show only values matching search
   * - Defect
     - 17286
     - System does not save draft updated data on Item Name in Format area of report designer.
   * - Defect
     - 17283
     - Run Copy button and Validate icon are disabled/enabled incorrectly in Copy Management Page
   * - Defect
     - 17266
     - Some pages in Angular2 kit are unresponsive when navigating between detail page and Report/Dashboard menu bar
   * - Defect
     - 17262
     - System works incorrectly when user add tag <Repeater> instead of <repeater> (case sensitive) in Form report part
   * - Defect
     - 17250
     - "The query syntax is incorrect" error message displays when creating report with "Full" join type relationship
   * - Defect
     - 17240
     - In Oracle data model Fields of 2 tables with same name all show in one table in data model, while the other table has no field.
   * - Defect
     - 17237
     - Two copied reports display with the same name and the same category/sub-category when clicking on OK button of Copy Report popup several times
   * - Defect
     - 17232
     - In Angular2 Kit when emailing a report and adding Recipient: To/Cc Popup is not responsive.
   * - Defect
     - 17224
     - When using cross filtering, some reports are sorting based on unseen data
   * - Defect
     - 17214
     - Filter Values need blank space between 2 values when input in the user defined filter values for input parameters
   * - Defect
     - 17210
     - Text color settings should not be shown on fields of type image
   * - Defect
     - 17203
     - 'Can create new reports?' text displays under Reports > Report Categories/Sub Categories instead of 'Can create new categories?'
   * - Defect
     - 17202
     - Message in Dashboard and message in Report Viewer are inconsistent after deleting a calculated field that is used in report part
   * - Defect
     - 17197
     - Not Equal (Checkbox) filter is not appearing as a common filter in dashboard.
   * - Defect
     - 17195
     - Getdate function returns value incorrectly when combining it with convert function
   * - Defect
     - 17194
     - In Dashboard Common filter value is blank after deleting and re-adding the filter into filter block of report.
   * - Defect
     - 17190
     - Style of Deactivate/Activate hyperlink is inconsistent in Tenant Setup and Role Setup page
   * - Defect
     - 17171
     - Missing plus (+) when mouseover on the first tile of dashboard when creating blank dashoard type
   * - Defect
     - 17161
     - Chart Legend shows incorrect color values when altered in field properties.
   * - Defect
     - 17160
     - Tenant Dropdown wasn't Responsive on Smaller Mobile Resolutions
   * - Defect
     - 17154
     - In Angular2 integration example kit Licence section disappears when switching between Report and Settings pages several times
   * - Defect
     - 17149
     - User is not able to remove Join Alias once added in the data source tab of report designer
   * - Defect
     - 17136
     - In Tenant Permissions page The section in the header section is not auto highlighted when its name hits the bottom of the header section.
   * - Defect
     - 17123
     - Cannot create report type chart on Mac OS Safari
   * - Defect
     - 17117
     - In schedule and subscription  "End by" option is not saved after editing
   * - Defect
     - 17116
     - Can export query execution although there is no report part, so export is blank
   * - Defect
     - 17106
     - Gear icon is displayed with check icon (have setting icon) for alternative text while there is no setting for this attribute
   * - Defect
     - 17105
     - In FF Browser Grid Report is blank when Preview Record = 1000/10000/All & Items per Page = 200
   * - Defect
     - 17103
     - In MVC integration example kit User must select tenant 2 times to change selected tenant in settings level dropdown
   * - Defect
     - 17101
     - Country level map is missing resources for Italy, Hoduras, Hungary, Iran, Vanuata, Uganda, Taiwan, Slovakia, Mauritaria, Norway, Peru, Republic of Serbia, United Replic of Tanzania and shows error when attempting to create these maps
   * - Defect
     - 17087
     - Output parameter of a Stored Procedure is displayed in data model and should not be shown. 
   * - Defect
     - 17069
     - % of Group format would incorrectly display group percentages
   * - Defect
     - 17064
     - Available category is not suggested when user is typing in category box on saving
   * - Defect
     - 17062
     - [Dashboard][Schedule/Subscribe] Filter Value Selection is not showing selected values
   * - Defect
     - 17039
     - In some circumstances, validations for column name and expressions in calculated fields are cleared.
   * - Defect
     - 17038
     - In Report Viewer, close button is not enabled in Report Subscription page
   * - Defect
     - 17032
     - Tool tip is not displayed on the information icon next to provision map data button in Settings page.
   * - Defect
     - 17029
     - In Settings, Schedule, Created By should be <First Name> <Last Name> instead of userId
   * - Defect
     - 17024
     -  When Editing Schedule: a redundant empty recipient shows unexpectedly
   * - Defect
     - 17023
     - Category navigation on left side of page shows edit icons when collapsed
   * - Defect
     - 17007
     - Icons of Report Part Title in Report Body are not aligned
   * - Defect
     - 16987
     - Null value is formatted in gauge separator causing duplicate value in the report part
   * - Defect
     - 16961
     - Popup subreport headers should show Sub report's name instead of fixed label 'Subreport'
   * - Defect
     - 16959
     - Value that has 2 spaces between 2 words (i.e A  B) displays in the report with only one space (i.e A B), report designer is editing one white space
   * - Defect
     - 16892
     - When using custom formats as field mapping values for subreports, the values do not match. System is passing formatted values, instead of the raw data for field mapping.	
   * - Defect
     - 16891
     - The second metric gauge of the first group is not properly spaced from the first one when Item(s) Per Row is not a multiple of number of metrics
   * - Defect
     - 16888
     - Dirty Form validation is missing when user changes list Tennant in connection string mapping for global report setup.
   * - Defect
     - 16886
     - Update 1 new CF, system shows the current calculated field  in the list of select Field Names pop up and should not
   * - Defect
     - 16885
     - Postgres SQL issue with saving Connection String when input parameters exceed field length.
   * - Defect
     - 16880
     - System is not properly updating from custom field formats to standard one when changed
   * - Defect
     - 16867
     - Cross Filter section and Delete icon is displayed when user does not set config for Cross Filtering
   * - Defect
     - 16864
     - In copy management UI when user updates workspace's name, System shows "No changes found"
   * - Defect
     - 16856
     - Filter Alias displays name incorrectly after changing aggregated function in Configuration section of field from something like Sum(Field) to Count(Field)
   * - Defect
     - 16855
     - System can draw the gauge report part with incorrect min & max when Scale To = the min data value returned from database
   * - Defect
     - 16853
     - In MVC integration kit user Can't Activate User Tenant
   * - Defect
     - 16850
     - Min & Max of Gauge report have 14 decimal digits while value has only 2 decimal digits in db
   * - Defect
     - 16848
     - In Horizontal Grids Text of columns should be left-justified for consistency
   * - Defect
     - 16843
     - After changing the option to show/hide tenant field in the data model 2 or more times the field stops displaying in report designer even when set to show.
   * - Defect
     - 16815
     - Version should not be displayed for a template
   * - Defect
     - 16801
     - Filter values in drop downs are sorted A->Z when sorting Z-A
   * - Defect
     - 16777
     - I report designer info of deleted filter still displays in Filter Properties drop down when un-selecting its associated data source.
   * - Defect
     - 16772
     - In IE browsers it is difficult to edit Report part name in Config/Preview mode
   * - Defect
     - 16768
     - User is getting error message 'The application has encountered an unknown error..' instead of kicking out to the Login page after the session is expired.
   * - Defect
     - 16751
     - User is able to edit the email's content while system is sending email
   * - Defect
     - 16750
     - Cross filtering is not properly applying to dashboard when user is in presentation mode.
   * - Defect
     - 16741
     - Values list of filter 2 is not updated based on the selected value of filter 1 when 'Cascading' is checked
   * - Defect
     - 16730
     - When cross filtering report part fails to drill up after updating result
   * - Defect
     - 16723
     - Only popup header displays after clicking Search then clicking Reset button immediately after
   * - Defect
     - 16602
     - Tenant Access label is cut off in the Tenant Permission screen in MVC kit
   * - Defect
     - 16597
     - In Quick Edit mode filters Inherited from a Parent Report to a Sub Report are not retained after pressing "Update Result"
   * - Defect
     - 16579
     - Date formats in "Long Date & Long Hour" style export incorrectly in XML, JSON and CSV
   * - Defect
     - 16576
     - Grand Total columns are out of alignment with the field columns when user changes field width
   * - Defect
     - 16566
     - In IE child popup of Add Calculated Field does not appear in the proper position to parent popup
   * - Defect
     - 16564
     - User should not be able to navigate to other screens while pop-up is opening by pressing Back or Alt+Left key
   * - Defect
     - 16541
     - The "Configure Password Options" is disabled when adding new users although user has checked "Configure Password Options" permission on role
   * - Defect
     - 16538
     - Error displayed when user attempts to sort values for input parameters of stored procedures in report designer.
   * - Defect
     - 16534
     - When deleting current version of report is history screen deleted report & category are not removed from Report List
   * - Defect
     - 16531
     - No message appears in the report when clicking Update Result with required filter has no value
   * - Defect
     - 16517
     - Sub total and Grand total are not exported on CSV on Export
   * - Defect
     - 16512
     - The filter set on the calculated field is not inherited in subreports even though both reports have the same calculated fields and datasources
   * - Defect
     - 16505
     - User can not use scroll bar to pick time in time field dropdowns on key join 
   * - Defect
     - 16501
     - User can not use mouse to drag the scroll bar of the drop down list of Time picker in schedule/subscription/key join operator for time fields.
   * - Defect
     - 16450
     - Edit Report button exists when user has been shared report with "View only" mode
   * - Defect
     - 16444
     - Json node createdBy and modified are incorrect when saving a new category
   * - Defect
     - 16422
     - Workspace name in Copy Management is missing cue to click for expanding information showing owner, created and modified dates. Should show carrot to notify user this can be expanded.
   * - Defect
     - 16413
     - In Data Model Invisible database still displays in Database Name list in Filter Value pop-up
   * - Defect
     - 16411
     - Grammar issue in popup message while deactivating role
   * - Defect
     - 16394
     - In Copy Management user cannot un-check the "Show only my workspaces" checkbox
   * - Defect
     - 16386
     - No successful message appears when editing & saving the report linked to an invisible connection in the data model
   * - Defect
     - 16380
     - Data model's connection string Lost highlight focus after saving a connection string
   * - Defect
     - 16377
     - In Report Viewer and Dashboard Warning message does not display when physical table is deleted on database
   * - Defect
     - 16337
     - Calculated Fields - System displayed error when creating calculated field using distinct.
   * - Defect
     - 16296
     - When using a Mac and Chrome browser Hover area is incorrect when using drop down box Setting level
   * - Defect
     - 16293
     - Placeholder data shown in form Border Settings
   * - Defect
     - 16291
     - Filters created on Numeric Calculated Field Break Cascading
   * - Defect
     - 16278
     - Unit label not displayed on Linear Gauge report
   * - Defect
     - 16262
     - The default date format should be updated when its data formatting is ...
   * - Defect
     - 16237
     - Chart is not show when using a CF created in the data model with an alias when used in chart
   * - Defect
     - 16040
     - The message displays "The template.....", instead of "The report...." when user Copies/Moves a report
   * - Defect
     - 15996
     - Report Designer > Report Body > 'Reset Zoom' Dialogue Causes Drilldown
   * - Defect
     - 15970
     - Filtered connection list shows sources not used in copy management database name dropdown based on selected report/dashboard
   * - Defect
     - 15966
     - In Oracle Error displays when report contains at least 1 calculated field filter and aggregated field in container
   * - Defect
     - 15925
     - In Global Report Role list is not sorted by AZ for access rights dropdown
   * - Defect
     - 15912
     - In User Setup, When You Input Non Decimals, Timezone Data Offset Breaks Datetime Filters In Reports 
   * - Defect
     - 15904
     - Destination category/subcategory should be selected with newly moved report in it
   * - Defect
     - 15870
     - In Copy Management, data in Content panel is displayed incorrectly in search result
   * - Defect
     - 15861
     - When saving Global report system should not show message M23/M24 in save popup without sharing with role/user
   * - Defect
     - 15822
     - For System Admins Setting level is still available at FIELDS page when opening an existing report
   * - Defect
     - 15821
     - Database mapping is Missing error message when mapping 1 schema/DB to 2 different schema/DB
   * - Defect
     - 15818
     - On Global Dashboard Missing the tooltip "Enter to create new category/sub-category" when set value into category/subcategory dropdown
   * - Defect
     - 15787
     - When creating a Form, some added Fields can be deleted when user press backsapce on keyboard
   * - Defect
     - 15763
     - Missing progress bar on Report List for Tenant level when user navigates from other page to the Report List
   * - Defect
     - 15754
     - For charts Hover Label Checkbox Does Not Remove Hover Labels
   * - Defect
     - 15747
     - Database Mapping, Merge duplicate mapping checkbox only displays for All Mapping option
   * - Defect
     - 15743
     - In Key join value when user uses Home/End key in text field the value changes to -number
   * - Defect
     - 15708
     - Shouldn't check license validity when using invalid connection string to setup config database initially
   * - Defect
     - 15700
     - Data in drop down list of Field Comparison is displayed incorrectly
   * - Defect
     - 15698
     - Embedded data on Form is not displayed again when user update Filter value and then remove all Filter value on Dashboard
   * - Defect
     - 15662
     - Modifications to CSS in project do not take effect on exports (tested in standalone)
   * - Defect
     - 15661
     - Forms: External Stylesheets Can Be Referenced In Forms, Styles Removed If The Visual Content is Modified.
   * - Defect
     - 15652
     - System loads the grey content below Reconnect button after user saving a first new connection string
   * - Defect
     - 15645
     - [Equals (Tree)] Order in Filter drop down list is incorrect
   * - Defect
     - 15544
     - Error message displays incorrectly when add an invalid expression for Calculated Field
   * - Defect
     - 15522
     - When altering the browser resolution after initial page load the filter's lazy loading feature stops working
   * - Defect
     - 15505
     - When editing a calculated field, system shows itself on the list CF drop down list when user edit Expression
   * - Defect
     - 15497
     - Pivot Grid Column Field Text Color Does Not Change
   * - Defect
     - 15494
     - Some values fail to appear on Chart Legend
   * - Defect
     - 15483
     -  Collation Issues, Invalid object name 'SYS.FOREIGN_KEY_COLUMNS'.
   * - Defect
     - 15481
     - System does not overwrite the custom define function with the system function
   * - Defect
     - 15480
     - Calculated Field in Postgres System shows error msg when user use DateDiff function in Expression field of Calculated Field
   * - Defect
     - 15479
     - Background color is limited by the initial report part's right border
   * - Defect
     - 15472
     - Datetime fields Between function, the TO date/time should be restricted to be after the FROM datetime
   * - Defect
     - 15435
     - User can not drag and drop the Key Join in data source tab of report designer
   * - Defect
     - 15398
     - Subtotals on Drill Down Grid Inaccurate When Collapsed
   * - Defect
     - 15396
     - Bar Chart X/Y Labels Correspond with Opposite Axis
   * - Defect
     - 15391
     - User with Full Report and Dashboard Access is Shown with Simple Data Sources In Role Summary
   * - Defect
     - 15369
     - In Oracle After changing operator in relationship, results do not update when navigating to Fields page
   * - Defect
     - 15355
     - Field name alias is duplicated if coming out Field Property panel without focusing any field before.
   * - Defect
     - 15340
     - Copied reports when edited in designer show a small blank error with no details and no log errors
   * - Defect
     - 15335
     - The green check-box and red X icon is displayed when user open Subtotal Settings popup then click OK button
   * - Defect
     - 15334
     - The green check-box and red X icon appear then disappear when user clicks Preview button in Subtotal Settings pop-up
   * - Defect
     - 15309
     - System does not set default Filter Operator for Time data type
   * - Defect
     - 15292
     - Field Name alias change is lost in some scenarios
   * - Defect
     - 15285
     - The Preview does not reload page when changed setting from Link to Icon or vice versa on custom url/or js
   * - Defect
     - 15271
     - Relationships additional Key Join Field's Length is too short to show data value
   * - Defect
     - 15244
     - Horizontal Grids: column widths settings don't work the same way as Vertical Grid column widths
   * - Defect
     - 15242
     - System should allow user back to data source tab, instead of display the information message when distinct is not valid
   * - Defect
     - 15231
     - Rule swap 2 DS is not applied when user creates relationship with Key Join
   * - Defect
     - 15094
     - System Parameters used in sp params are not correct when using @UserID the report loads with the initial stored value not the current user id
   * - Defect
     - 14990
     - System shows incorrect value for "Week Number" format
   * - Defect
     - 14976
     - MS Edge browser has slight spacing issues in report designer and Copy Management.
   * - Defect
     - 14973
     - Save External Tenant API only updates name deletion, active and description only. Should update all items available.
   * - Defect
     - 14960
     - Incorrect Error message displayed when report is missing fields in data model "This report is no longer valid..." & the Design button in reportviewer
   * - Defect
     - 14957
     - Error message is displayed incorrectly after calculated field contains a field that is no longer available
   * - Defect
     - 14954
     - Incorrect error message displayed  Should be shown error message "Invalid filter(s): ..." instead of "The application has encountered..."
   * - Defect
     - 14949
     - Report Part should be displayed in the report when error is shown that fields are not visible
   * - Defect
     - 14939
     - FireFox is showing slow load times for Permissions tab to Data Model Access tab
   * - Defect
     - 14928
     - In Subtotal/Grand Total Data Type changes to Money when using Average/Sum/Sum Distinct for numeric field.
   * - Defect
     - 14914
     - Suggested Data Type is incorrect when user changes the Field in Expression text box for Calculated Field
   * - Defect
     - 14891
     - In Edge Browser Data is not displayed when user changes from back side to front side, system shows error msg when creating form
   * - Defect
     - 14806
     - Duplicate workspaces display in middle panel after clicking Save button many times
   * - Defect
     - 14797
     - In some cases when using separator on Column Chart the columns are overlapping
   * - Defect
     - 14763
     - Notification for adding a new table/view/stored procedure is incorrect, states that all data will be overridden in the model
   * - Defect
     - 14694
     - Application detects incorrect data type of Aggregated Function so it throws incorrect error msg: "Value should be valid compared with filter data type"
   * - Defect
     - 14677
     - Checkbox and Popup style filters are not inheriting the values of top level report
   * - Defect
     - 14315
     - Stored Procedures in MSSQL which contain aggregate fields without as indicator show blank field name in model
   * - Defect
     - 14299
     - Grid lines disappear in form table after formatting a field
   * - Defect
     - 14293
     - Default sorting function is removed when user returns to visual tab from HTML tab
   * - Defect
     - 14286
     - Money field type shows no decimals by default without a format applied
   * - Defect
     - 14225
     - The copied report having sharing info is not available for the user in the destination when using copy console
   * - Defect
     - 14223
     - Missing some configurations on sorting feature for pivot and drill down grids
   * - Defect
     - 14174
     - Query execution is not available for stored procedures in MySQL
   * - Defect
     - 14115
     - License Expiration Notification Reports Negative Days
   * - Defect
     - 14110
     - SASS styles issue some elements are not pointing to a global variable
   * - Defect
     - 14101
     - Percentage of Group Subtotals are not correct they show the subtotal value with a %
   * - Defect
     - 14100
     - Responsive Screen Issues
   * - Defect
     - 14090
     - System should prevent duplicate threshold values on the same axis
   * - Defect
     - 14074
     - Scroll bar needed in dashboard tile for gauges and charts which contain multiple items as they are too small to see until the tile is made larger.
   * - Defect
     - 14010
     - Known issue with Oracle .net driver any repeating decimals will cause an error to resolve in the Application use ROUND(field/field,3) to round the decimal
   * - Defect
     - 13956
     - Concurrency updated msg is not displayed when user clicks on Save button on a new workspace without clicking on Validate button first
   * - Defect
     - 13919
     - After changing the name of a calculated field sub/grand total show error "this field is invalid"
   * - Defect
     - 13912
     - When setting a role to Full Report and Dashboard Access defaults for each area are not correct. Example, user should always be able to create a report but if it is not the default for tenant this is not checked and is hidden when using this setting.
   * - Defect
     - 13899
     - Freeze option not working in Quick Edit mode for filter panel
   * - Defect
     - 13802
     - Vertical Scroll bar position is reset to top of the list although user select the last item on left navigation.
   * - Defect
     - 13794
     - Performance on MS Edge is slow, nearly frozen
   * - Defect
     - 13782
     - When using a report part, render report or render dashboard if item ID is not found system should return message stating item is not found
   * - Defect
     - 13762
     - Calculated field fail to load after changing the database name for the connection string
   * - Defect
     - 13761
     - When user collapses data model tree in copy management and navigates to advanced copy screen, all trees are expanded again when returning to the main screen
   * - Defect
     - 13736
     - Success message displays even after clicking Cancel button on Overwrite popup when copying reports
   * - Defect
     - 13728
     - Percent of group is not working properly with drill down grids
   * - Defect
     - 13554
     - Chart Zoom feature not working properly with Stacked Percentage property
   * - Defect
     - 13534
     - Field name is not unique error displayed when using a calculated field created in data model in the calculated field created in report
   * - Defect
     - 13510
     - Some drop downs are not searchable and all should be combo search and select
   * - Defect
     - 12999
     - CONCAT must be used in instead of + when combining two string values in some databases.
   * - Defect
     - 12447
     - When reviewing the permissions summary in the role no scroll bar is present and only 12 items can be displayed
   * - Defect
     - 9200
     - Between values are not validated in filters to ensure beginning value is less than ending value
