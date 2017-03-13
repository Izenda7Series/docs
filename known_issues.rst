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
     - 13919
     - After changing the name of a calculated field sub/grand total show error "this field is invalid"
   * - Defect
     - 13858
     - After saving a report containing subreport with icon style selected, system is reverting to link style
   * - Defect
     - 13981
     - Blank error message shows after moving some joins containing additional key joins in report designer
   * - Defect
     - 14115
     - License Expiration Notification Reports Negative Days
   * - Defect
     - 13300
     - Null and Blank values are displayed as Undefined Value in Charts and Gauges
   * - Defect
     - 13745
     - No record returned is displayed the first time the user clicks to preview results for sub and grand totals
   * - Defect
     - 14101
     - Percentage of Group Subtotals are not correct they show the subtotal value with a % 
   * - Defect
     - 14225
     - The copied report having sharing info is not available for the user in the destination when using copy console
   * - Defect
     - 14929
     - The format of Grand Total value for a separator in the preview section is different from the preview result in the popup
   * - Defect
     - 14798
     - Typing in dates for between calendar filter when user is in dd/mm/yyyy format alters date
   * - Defect
     - 14656
     - Save notification showing when user has just saved and clicked on Report Viewer
   * - Defect
     - 14074
     - Scroll bar needed in dashboard tile for gauges and charts which contain multiple items as they are too small to see until the tile is made larger.
   * - Defect
     - 14657
     - Separator used in chart showing incorrect data on hover, shows all items not just the one grouping being hovered on.
   * - Defect
     - 14018
     - Separators for Funnel charts are still allowing an unsorted view and should always be sorted
   * - Defect
     - 15047
     - Roboto Font is not properly exporting in PDF
   * - Defect
     - 14110
     - SASS styles issue some elements are not pointing to a global variable
   * - Defect
     - 14973
     - Save External Tenant API only updates name deletion, active and description only. Should update all items available.
   * - Defect
     - 14914
     - Suggested Data Type is incorrect when user changes the Field in Expression text box for Calculated Field
   * - Defect
     - 14232
     - Suggested Data Type is not displayed in calculated field created in data model
   * - Defect
     - 13510
     - Some drop downs are not searchable and all should be combo search and select
   * - Defect
     - 14974
     - Some users may experience issues when inputting dates / times in scheduler and subscriptions. 
   * - Defect
     - 14014
     - Sort icons are still appearing on some chart when the value should not be sortable
   * - Defect
     - 14738
     - Stored Procedure Parameter Filters do not show up in the Scheduled instance Filters
   * - Defect
     - 14315
     - Stored Procedures in MSSQL which contain aggregate fields without as indicator show blank field name in model 
   * - Defect
     - 15058
     - Subtotal/ Grand total inherits the format of column above it instead of using its own format
   * - Defect
     - 13736
     - Success message displays even after clicking Cancel button on Overwrite popup when copying reports
   * - Defect
     - 13794
     - Performance on MS Edge is slow, nearly frozen
   * - Defect
     - 14605
     - Permissions summary data is showing Global and Local category names not the actual category names
   * - Defect
     - 14763
     - Notification for adding a new table/view/stored procedure is incorrect, states that all data will be overridden in the model
   * - Defect
     - 14965
     - Pagination doesn't update after user have just created new report and changed Preview Records value
   * - Defect
     - 13728
     - Percent of group is not working properly with drill down grids
   * - Defect
     - 14945
     - Position Index does not work for either Custom Javascript or Custom URL
   * - Defect
     - 14201
     - Position of tick mark is incorrect on linear gauge when metric value returns a negative number
   * - Defect
     - 14174
     - Query execution is not available for stored procedures in MySQL
   * - Defect
     - 2972
     - Relationships are not arranged well in the schema tab of the data model and difficult to read as the tables overlay the connectors
   * - Defect
     - 14012
     - User cannot un-sort the Funnel chart labels
   * - Defect
     - 13757
     - User must log out and back in if permissions are changed on role to reduce the report part types available. 
   * - Defect
     - 13079
     - User must scroll to the bottom of the report body to get to the horizontal scroll bar due to extra vertical scroll bar
   * - Defect
     - 13984
     - User with create report permissions but lacking permission to Overwrite Existing Report cannot get back to the report designer
   * - Defect
     - 14754
     - Using any of the RUNNING totals as calculated field functions do not work
   * - Defect
     - 13802
     - Vertical Scroll bar position is reset to top of the list although user select the last item on left navigation.
   * - Defect
     - 13247
     - When creating a form the drag and drop for fields will not work once an item is deleted unless the cursor is placed in the form report part
   * - Defect
     - 12447
     - When reviewing the permissions summary in the role no scroll bar is present and only 12 items can be displayed
   * - Defect
     - 14309
     - When rotating X axis labels to the 'Angle Clockwise' the values are cut off on the right side of the charts 
   * - Defect
     - 13912
     - When setting a role to Full Report and Dashboard Access defaults for each area are not correct. Example, user should always be able to create a report but if it is not the default for tenant this is not checked and is hidden when using this setting.
   * - Defect
     - 14943
     - When two grids are side by side even with enough sapce to print they are not exporting
   * - Defect
     - 13761
     - When user collapses data model tree in copy management and navigates to advanced copy screen, all trees are expanded again when returning to the main screen
   * - Defect
     - 13935
     - When user selects home or end key in some input text fields a numeric is displaying in the text box
   * - Defect
     - 13782
     - When using a report part, render report or render dashboard if item ID is not found system should return message stating item is not found
   * - Defect
     - 13575
     - The list of fields of a data source is sorted incorrectly when "Sort Column Name" flag is turned on in data model
   * - Defect
     - 14002
     - When using multiple Grand total lines some lines display a "0" where there should be no value
   * - Defect
     - 13989
     - When using required filters the system is still executing query prior to user clicking update results when there are more than one required filters
   * - Defect
     - 14090
     - System should prevent duplicate threshold values on the same axis
   * - Defect
     - 14056
     - System shows error msg when copying existing Dashboards which include old reports having sub-reports
   * - Defect
     - 14288
     - System shows error msg: "At least one grouping field is required due to filter has aggreated function." when user creates 1 aggregated CF and adds it to filter and report container
   * - Defect
     - 14962
     - System shows the list full data on Sub Report before it scale the exactly data base with the selection on master report
   * - Defect
     - 14958
     - Tenant Setup section is still displayed on Role Setup page in single Tenant mode
   * - Defect
     - 15025
     - Oceania Continent map needs to be added for Australia and surrounding islands 
   * - Defect
     - 15057
     - Oracle showing errors when gradually moving more than 1000 data sources to Available Data Sources 
   * - Defect
     - 14298
     - Missing Loading progress bar when user changes Preview Records in View Mode/Quick Edit Mode
   * - Defect
     - 14223
     - Missing some configurations on sorting feature for pivot and drill down grids
   * - Defect
     - 14286
     - Money field type shows no decimals by default without a format applied
   * - Defect
     - 14976
     - MS Edge browser has slight spacing issues in report designer and Copy Management.
   * - Defect
     - 14773
     - Newly created user is not logged in automatically after closing generate password browser tab
   * - Defect
     - 14893
     - List category on left nav is displaying the list of Reports instead of list of Templates when user views a template
   * - Defect
     - 13554
     - Chart Zoom feature not working properly with Stacked Percentage property
   * - Defect
     - 14677
     - Checkbox and Popup style filters are not inheriting the values of top level report
   * - Defect
     - 14809
     - If user date format is not set there are errors in the users ability to see all date formats and when executing sp with date inputs
   * - Defect
     - 13170
     - In Calculated Field the preview eesult field is displayed incorrectly after user selects a different data type
   * - Defect
     - 14011
     - In Charts the X-axis and Y-axis are sorted incorrectly when the Separator field is sorted
   * - Defect
     - 14307
     - In Dashboard common filters, filter value does not show all data without cascading filters
   * - Defect
     - 14891
     - In Edge Browser Data is not displayed when user changes from back side to front side, system shows error msg when creating form
   * - Defect
     - 14926
     - In forms the first field changes its alias when grouping one of the 2 same fields
   * - Defect
     - 14824
     - In forms when user adds a sub total/grand total generates a new smart tag
   * - Defect
     - 14899
     - In MS Edge Only User can not create new subscription, the information is not displayed after entry and OK is clicked in subscription
   * - Defect
     - 14797
     - In some cases when using separator on Column Chart the columns are overlapping
   * - Defect
     - 13239
     - In stand alone mode if Admin user deactivates user they may remain active until the token is inactive
   * - Defect
     - 14928
     - In Subtotal/Grand Total Data Type changes to Money when using Average/Sum/Sum Distinct for numeric field.
   * - Defect
     - 14935
     - In Tenant Permissions Access section of Role Setup permission doesn't display although it is checked in Tenant Setup permission
   * - Defect
     - 14681
     - In Time Period Filter Displays as Undefined in Filter Description
   * - Defect
     - 14960
     - Incorrect Error message displayed when report is missing fields in data model "This report is no longer valid..." & the Design button in reportviewer
   * - Defect
     - 14087
     - Input parameters for stored procedures used in reports are not copied when copied using dashboard copy
   * - Defect
     - 15055
     - Introduction text does not display correctly when changing settings level.
   * - Defect
     - 14010
     - Known issue with Oracle .net driver any repeating decimals will cause an error to resolve in the Application use ROUND(field/field,3) to round the decimal
   * - Defect
     - 13524
     - Calcuated fields are missing in report design when "Field Comparison" operator is used for filter
   * - Defect
     - 15059
     - API request for filtered reports requiring case sensitive information (keys and guid values must be lower case)
   * - Defect
     - 14694
     - Application detects incorrect data type of Aggregated Function so it throws incorrect error msg: "Value should be valid compared with filter data type"
   * - Defect
     - 15048
     - Between Calendar Date filter errors when only one date is used, system should validate that both dates are entered. Also error thrown when both values are removed.
   * - Defect
     - 9200
     - Between values are not validated in filters to ensure beginning value is less than ending value
   * - Defect
     - 5146
     - After Editing the suggested Join Alias for self join Relationships, all values on selected Foreign Data Object and Field are reset to Blank
   * - Defect
     - 14660
     - Advanced Settings Data Model Query Limit will not accept more than 100K. 
   * - Defect
     - 14219
     -  Browser does not respond when loading the large schema in Internet Explorer
   * - Defect
     - 13956
     -  Concurrency updated msg is not displayed when user clicks on Save button on a new workspace without clicking on Validate button first
   * - Defect
     - 15054
     -  Icon for configured Tenant Field is displayed incorrectly on Data Model page
   * - Defect
     - 13808
     - Dashboard reloads each time user goes to schedule or access tabs
   * - Defect
     - 14796
     - Date formats in dd/mm/yyyy style export with mm/dd/yyyy format
   * - Defect
     - 15026
     - Default bubble size on map is too large causing many data points to over lap.
   * - Defect
     - 14293
     - Default sorting function is removed when user returns to visual tab from HTML tab
   * - Defect
     - 14799
     - Deleted columns from physical db are not added back when recreated after reconnecting to the database
   * - Defect
     - 13082
     - Due to loading race conditions some reports are displayed with no results until the user clicks update results after initial load of report
   * - Defect
     - 14806
     - Duplicate workspaces display in middle panel after clicking Save button many times
   * - Defect
     - 13727
     - Embedded grid within a form does not properly fit within the column in the form 
   * - Defect
     - 14975
     - Embedded pages using margins throw off dropdown calculations and dropdowns appear out of alignment with the container
   * - Defect
     - 14957
     - Error message is displayed incorrectly after calculated field contains a field that is no longer available
   * - Defect
     - 14979
     - Field name alias duplicates when moving to another page from report part properties
   * - Defect
     - 13534
     - Field name is not unique error displayed when using a calculated field created in data model in the calculated field created in report
   * - Defect
     - 13992
     - Filter description does not display in dashboard tile after adding new filter into report
   * - Defect
     - 14795
     - Filter ignored on report after adding one filter saving and adding another filter. Filter logic is set by system on save and should not be.
   * - Defect
     - 13807
     - Column sort on report search for Subreport and Dashboard is only sorting by column header on name
   * - Defect
     - 12999
     - CONCAT must be used in instead of + when combining two string values in some databases. 
   * - Defect
     - 14054
     - Copy Dashboard function showing error when recopying a dashboard where the reports were deleted in the destination prior.
   * - Defect
     - 15045
     - Custom Functions in JSON should not require [] around function name
   * - Defect
     - 14085
     - Filter Value of an existing Filter is reset to blank after user adds a Field to Filter section and after removing it from this section
   * - Defect
     - 14939
     - FireFox is showing slow load times for Permissions tab to Data Model Access tab
   * - Defect
     - 13899
     - Freeze option not working in Quick Edit mode for filter panel
   * - Defect
     - 14775
     - Function dropdown list carries over from one field to another field in forms
   * - Defect
     - 14299
     - Grid lines disappear in form table after formatting a field
   * - Defect
     - 14302
     - Header format color changes the sort arrow color 
   * - Defect
     - 14287
     - If user clicks update results after adding a filter and prior to adding an operator, error message is shown for filter logic.
   * - Defect
     - 14039
     - Add new Field indicator is not removed on Data Model page when user clicks on save button for newly added stored procedures
   * - Defect
     - 14670
     - If you click and drag within the color spectrum of the background color picker, the color picker does not move with the cursor.
   * - Defect
     - 14959
     - Image from relative path does not display in exported file for Tenant Logo
   * - Defect
     - 14901
     - List user in User pop up is blank when user creates 1 schedule/Email in Report Designer or in Dashboard 
   * - Defect
     - 14956
     - Success message does not display after clicking Save button in System Config > Report
   * - Defect
     - 14114
     - Simple gauge is not sizing properly within the container, at some sizes the gauge is too large and and cuts off the data
   * - Defect
     - 14944
     - Report with Required Filters are executing a query prior to required filters being set
   * - Defect
     - 14228
     - ReactJS loads twice when integrating with another ReactJS app
   * - Defect
     - 14215
     - Pivot grids do not render columns where all values are 0
   * - Defect
     - 15021
     - Category highlight status fails to update after saving as
   * - Defect
     - 14762
     - When using Equals Tree filter child nodes are not unchecked when deleting parent node
   * - Defect
     - 14855
     - When changing setting level in New Dashboard, page redirect to Dashboard List
   * - Defect
     - 13255
     - Missing line breaks after {dashboard Link} text in schedule's email body.
   * - Defect
     - 14295
     - Clicking report name expands report info and should not, should take the user to the report viewer directly without this step
   * - Defect
     - 13925
     - Out of memory errors occurring when validating many tenants using copy function for data model or reports.
   * - Defect
     - 14303
     - After adding a format to a field if the user selects none, the data remains formatted
   * - Defect
     - 14946
     - Alternating background colors (rows and columns) not working on pivots
   * - Defect
     - 14235
     - Filter Sorting Does Not Work for Pop up and Checkbox & Tool Tip Is Wrong on sort icon
   * - Defect
     - 14676
     - Custom URL will not work in some cases, the field value is not passed in the url only the reference as {fieldname}
   * - Defect
     - 13762
     - Calculated field fail to load after changing the database name for the connection string 
   * - Defect
     - 14316
     - Adding additional error messages to issues with Connection String
   * - Defect
     - 14100
     - Responsive Screen Issues
   * - Defect
     - 14019
     - System loads all Functions in calculated field and function dropdown and should only load items from currently used connection string 
