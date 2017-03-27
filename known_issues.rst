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
     - 12271
     - When using presentation mode when user gets to last tile system is "rewinding" instead of moving fluidly to first tile again
   * - Defect
     - 12447
     - When reviewing the permissions summary in the role no scroll bar is present and only 12 items can be displayed
   * - Defect
     - 12999
     - CONCAT must be used in instead of + when combining two string values in some databases. 
   * - Defect
     - 13079
     - User must scroll to the bottom of the report body to get to the horizontal scroll bar due to extra vertical scroll bar
   * - Defect
     - 13082
     - Due to loading race conditions some reports are displayed with no results until the user clicks update results after initial load of report
   * - Defect
     - 13170
     - In Calculated Field the preview result field is displayed incorrectly after user selects a different data type
   * - Defect
     - 13239
     - In stand alone mode if Admin user deactivates user they may remain active until the token is inactive
   * - Defect
     - 13247
     - When creating a form the drag and drop for fields will not work once an item is deleted unless the cursor is placed in the form report part
   * - Defect
     - 13510
     - Some drop downs are not searchable and all should be combo search and select
   * - Defect
     - 13524
     - Calcuated fields are missing in report design when "Field Comparison" operator is used for filter
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
     - 13808
     - Dashboard reloads each time user goes to schedule or access tabs
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
     - 13925
     - Out of memory errors occurring when validating many tenants using copy function for data model or reports.
   * - Defect
     - 13956
     -  Concurrency updated msg is not displayed when user clicks on Save button on a new workspace without clicking on Validate button first
   * - Defect
     - 13981
     - Blank error message shows after moving some joins containing additional key joins in report designer
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
     - 14085
     - Filter Value of an existing Filter is reset to blank after user adds a Field to Filter section and after removing it from this section
   * - Defect
     - 14087
     - Input parameters for stored procedures used in reports are not copied when copied using dashboard copy
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
     - 14215
     - Pivot grids do not render columns where all values are 0
   * - Defect
     - 14219
     -  Browser does not respond when loading the large schema in Internet Explorer
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
     - 14235
     - Filter Sorting Does Not Work for Pop up and Checkbox & Tool Tip Is Wrong on sort icon
   * - Defect
     - 14286
     - Money field type shows no decimals by default without a format applied
   * - Defect
     - 14288
     - System shows error msg: "At least one grouping field is required due to filter has aggregated function." when user creates 1 aggregated CF and adds it to filter and report container
   * - Defect
     - 14293
     - Default sorting function is removed when user returns to visual tab from HTML tab
   * - Defect
     - 14295
     - Clicking report name expands report info and should not, should take the user to the report viewer directly without this step
   * - Defect
     - 14299
     - Grid lines disappear in form table after formatting a field
   * - Defect
     - 14307
     - In Dashboard common filters, filter value does not show all data without cascading filters
   * - Defect
     - 14309
     - When rotating X axis labels to the 'Angle Clockwise' the values are cut off on the right side of the charts 
   * - Defect
     - 14315
     - Stored Procedures in MSSQL which contain aggregate fields without as indicator show blank field name in model 
   * - Defect
     - 14316
     - Adding additional error messages to issues with Connection String
   * - Defect
     - 14605
     - Permissions summary data is showing Global and Local category names not the actual category names
   * - Defect
     - 14657
     - Separator used in chart showing incorrect data on hover, shows all items not just the one grouping being hovered on.
   * - Defect
     - 14660
     - Advanced Settings Data Model Query Limit will not accept more than 100K. 
   * - Defect
     - 14670
     - If you click and drag within the color spectrum of the background color picker, the color picker does not move with the cursor.
   * - Defect
     - 14676
     - Custom URL will not work in some cases, the field value is not passed in the url only the reference as {fieldname}
   * - Defect
     - 14677
     - Checkbox and Popup style filters are not inheriting the values of top level report
   * - Defect
     - 14681
     - In Time Period Filter Displays as Undefined in Filter Description
   * - Defect
     - 14694
     - Application detects incorrect data type of Aggregated Function so it throws incorrect error msg: "Value should be valid compared with filter data type"
   * - Defect
     - 14738
     - Stored Procedure Parameter Filters do not show up in the Scheduled instance Filters
   * - Defect
     - 14754
     - Using any of the RUNNING totals as calculated field functions do not work
   * - Defect
     - 14763
     - Notification for adding a new table/view/stored procedure is incorrect, states that all data will be overridden in the model
   * - Defect
     - 14773
     - Newly created user is not logged in automatically after closing generate password browser tab
   * - Defect
     - 14775
     - Function dropdown list carries over from one field to another field in forms
   * - Defect
     - 14795
     - Filter ignored on report after adding one filter saving and adding another filter. Filter logic is set by system on save and should not be.
   * - Defect
     - 14796
     - Date formats in dd/mm/yyyy style export with mm/dd/yyyy format
   * - Defect
     - 14797
     - In some cases when using separator on Column Chart the columns are overlapping
   * - Defect
     - 14798
     - Typing in dates for between calendar filter when user is in dd/mm/yyyy format alters date
   * - Defect
     - 14799
     - Deleted columns from physical db are not added back when recreated after reconnecting to the database
   * - Defect
     - 14806
     - Duplicate workspaces display in middle panel after clicking Save button many times
   * - Defect
     - 14809
     - If user date format is not set there are errors in the users ability to see all date formats and when executing sp with date inputs
   * - Defect
     - 14855
     - When changing setting level in New Dashboard, page redirect to Dashboard List
   * - Defect
     - 14891
     - In Edge Browser Data is not displayed when user changes from back side to front side, system shows error msg when creating form
   * - Defect
     - 14893
     - List category on left nav is displaying the list of Reports instead of list of Templates when user views a template
   * - Defect
     - 14899
     - In MS Edge Only User can not create new subscription, the information is not displayed after entry and OK is clicked in subscription
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
     - 14943
     - When two grids are side by side even with enough space to print they are not exporting
   * - Defect
     - 14944
     - Report with Required Filters are executing a query prior to required filters being set
   * - Defect
     - 14945
     - Position Index does not work for either Custom JavaScript or Custom URL
   * - Defect
     - 14946
     - Alternating background colors (rows and columns) not working on pivots
   * - Defect
     - 14949
     - Report Part should be displayed in the report when error is shown that fields are not visible 
   * - Defect
     - 14957
     - Error message is displayed incorrectly after calculated field contains a field that is no longer available
   * - Defect
     - 14959
     - Image from relative path does not display in exported file for Tenant Logo
   * - Defect
     - 14960
     - Incorrect Error message displayed when report is missing fields in data model "This report is no longer valid..." & the Design button in report viewer
   * - Defect
     - 14962
     - System shows the list full data on Sub Report before it scale the exactly data base with the selection on master report
   * - Defect
     - 14973
     - Save External Tenant API only updates name deletion, active and description only. Should update all items available.
   * - Defect
     - 14974
     - Some users may experience issues when inputting dates / times in scheduler and subscriptions. 
   * - Defect
     - 14975
     - Embedded pages using margins throw off dropdown calculations and dropdowns appear out of alignment with the container
   * - Defect
     - 14976
     - MS Edge browser has slight spacing issues in report designer and Copy Management.
   * - Defect
     - 14979
     - Field name alias duplicates when moving to another page from report part properties
   * - Defect
     - 14982
     - Reformatting at HTML page disables subtotal/grand total setting in Forms
   * - Defect
     - 14983
     - Print preview does not exist until the report is saved. 
   * - Defect
     - 14990
     - System shows incorrect value for "Week Number" format
   * - Defect
     - 15026
     - Default bubble size on map is too large causing many data points to over lap.
   * - Defect
     - 15027
     - Charts with X-Axis and interval setting not allowing decimal Intervals
   * - Defect
     - 15047
     - Roboto Font is not properly exporting in PDF
   * - Defect
     - 15048
     - Between Calendar Date filter errors when only one date is used, system should validate that both dates are entered. Also error thrown when both values are removed.
   * - Defect
     - 15054
     -  Icon for configured Tenant Field is displayed incorrectly on Data Model page
   * - Defect
     - 15057
     - Oracle showing errors when gradually moving more than 1000 data sources to Available Data Sources 
   * - Defect
     - 15059
     - API request for filtered reports requiring case sensitive information (keys and guid values must be lower case)
   * - Defect
     - 15060
     - Special Chars in Plaintext Connection Strings Throw Errors
   * - Defect
     - 15062
     - Legends Don't Respect Alternative Text settings for field data
   * - Defect
     - 15070
     - Dirty form is displaying warning where no changes have been made 
   * - Defect
     - 15071
     - Headers are Overlapped in Exports
   * - Defect
     - 15072
     - Scheduler/Subscription DateTime Time Pickers Not Working in IE
   * - Defect
     - 15073
     -  Subreports on Date Fields showing error, Multiple Values for Fields
   * - Defect
     - 15075
     - Copying Reports with an Aliased Join causes errors in destination when viewing report
   * - Defect
     - 15093
     - Export Load Dialogue Not Deleting in some integrated modes
   * - Defect
     - 15094
     - System Parameters used in sp params are not correct when using @UserID the report loads with the initial stored value not the current user id
   * - Defect
     - 15096
     - Title of Border Settings popup on report designer grid is inconsistent with other report parts 
   * - Defect
     - 15110
     - Invisible Field in Data Model is not displayed as masked data
   * - Defect
     - 15122
     - Change notification for Provision Map Data to "The system is importing Map data into the configuration database. Please wait for the process to complete before using Maps"
   * - Defect
     - 15127
     - Filters do not properly align when some are set to not visible in the viewer
   * - Defect
     - 15141
     - Error received when grouping fields in a grid, "The given key was not present in the dictionary."
   * - Defect
     - 15145
     - When user adds 1 new CS and save it without assign any table from Available to Visible, system shows all DS in Visible Tree then quickly back to Available tree
   * - Defect
     - 15155
     - Report is broken when user unchecks on a data source in Report Designer and then navigates to another page without saving
   * - Defect
     - 15160
     - Draft saved version of existing Report is loaded to Report Designer, not the actual saved version
   * - Defect
     - 15178
     - Connection Builder Syntax is incorrect for some supported databases
   * - Defect
     - 15179
     - Separator expand and collapse icons are Hidden In Dashboards
   * - Defect
     - 15181
     - In Time Period Filter is not showing values in scheduled instance filter dropdowns
   * - Defect
     - 15182
     - Charts do not display resized properly in mobile mode, user must scroll horizontally to see entire chart
   * - Defect
     - 15193
     - Excel Exports Lose sub/grand total formatting and display as text
   * - Defect
     - 15194
     - Export Fails for Form stating invalid field but data is returned in the UI
   * - Defect
     - 15204
     - Layout in Dashboard tiles when turning off Presentation Mode is incorrect
   * - Defect
     - 15206
     - System navigates to Format page, instead of Fields page when design is selected from report list.
   * - Defect
     - 15242
     - System should allow user back to data source tab, instead of display the information message when distinct is not valid
   * - Defect
     - 15244
     - Horizontal Grids: column widths settings don't work the same way as Vertical Grid column widths
   * - Defect
     - 15262
     - Error states relationship does not exist when attempting to edit report and system will not allow user back to data source tab
   * - Defect
     - 15264
     - Field Positions are duplicated causing report to error
   * - Defect
     - 15272
     - Number of item in Filter Value is affected by query limit. These settings should be independent 
   * - Defect
     - 15276
     - Charts with Separators are missing the separator after drilldown
   * - Defect
     - 15277
     - SP set up for date values will not accept blank inputs
   * - Defect
     - 15279
     - Inconsistent field types shown in front end, when user edits field time in database and reconnects. Izenda Data type is not properly updated.
   * - Defect
     - 15280
     - API elements are case sensitive for many elements which should not be case sensitive
   * - Defect
     - 15289
     - System errors scheduling with Attachment in Standalone Frontend and Embedded Backend
   * - Defect
     - 15292
     - Field Name alias change is lost in some scenarios
   * - Defect
     - 15301
     - In Oracle an error is occurring when moving data sources containing some datetime format fields
   * - Defect
     - 15304
     - Custom Formats to not work with charts and gauges
   * - Defect
     - 15306
     - When Printing A Form, Only the Content in Viewport is Rendered, Page Breaks don't work
   * - Defect
     - 15308
     - System does not show the dirty form msg when user creates a new Dashboard and then click on any Report link to go to Report Viewer page
   * - Defect
     - 15309
     - System does not set default Filter Operator for Time data type
   * - Defect
     - 15310
     - Copy Process from Copy Console is duplicating sharing permissions
   * - Defect
     - 15324
     - In Single Tenant Mode System does not show Template/Report in Uncategorized list on LEFT nav or on the content panel
   * - Defect
     - 15340
     - Copied reports when edited in designer show a small blank error with no details and no log errors
   * - Defect
     - 2972
     - Relationships are not arranged well in the schema tab of the data model and difficult to read as the tables overlay the connectors
   * - Defect
     - 9200
     - Between values are not validated in filters to ensure beginning value is less than ending value
