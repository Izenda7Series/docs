


Report
------

.. list-table::
   :header-rows: 1
   :widths: 25 5 65 5

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **name** |br|
         string
      -
      -  The name of the report
      -
   *  -  **reportDataSource** |br|
         array of objects
      -
      -  An array of :doc:`ReportDataSource` objects
      -
   *  -  **type** |br|
         integer
      -
      -  The report type

         - 0 = Reports
         - 1 = Templates
      -
   *  -  **previewRecord** |br|
         integer
      -
      -  The number of records to preview
      -
   *  -  **advancedMode** |br|
         boolean
      -
      -  Is the report in advanced mode
      -
   *  -  **allowNulls** |br|
         boolean
      -
      -  Does the report display null values in left join
      -
   *  -  **isDistinct** |br|
         boolean
      -
      -  Does the report allow duplicated data
      -
   *  -  **categoryId** |br|
         string (GUID)
      -
      -  The id of the report category
      -
   *  -  **categoryName** |br|
         string
      -
      -  The name of the report category
      -
   *  -  **subCategoryId** |br|
         string (GUID)
      -
      -  The id of the report sub-category
      -
   *  -  **subCategoryName** |br|
         string
      -
      -  The name of the report sub-category
      -
   *  -  **tenantName** |br|
         string
      -
      -  The name of the tenant if available
      -
   *  -  **description** |br|
         string
      -
      -  The report description
      -
   *  -  **title** |br|
         string
      -
      -  The report title
      -
   *  -  **lastViewed** |br|
         datetime
      -  Y
      -  The report's last view date and time
      -
   *  -  **owner** |br|
         string
      -
      -  The name of report's owner
      -
   *  -  **ownerId** |br|
         string (GUID)
      -
      -  The id of report's owner
      -
   *  -  **headerContent** |br|
         string
      -
      -  The content of the header in json format
      -
   *  -  **footerContent** |br|
         string
      -
      -  The content of the footer in json format
      -
   *  -  **excludedRelationships** |br|
         string
      -
      -  The deleted relationships, which should not be displayed again
      -
   *  -  **numberOfView** |br|
         integer
      -
      -  The number of view
      -
   *  -  **renderingTIme** |br|
         real number
      -
      -  The report rendering time
      -
   *  -  **createdById** |br|
         string (GUID)
      -  Y
      -  Id of user who created this report
      -
   *  -  **modifiedById** |br|
         string (GUID)
      -  Y
      -  Id of user who last modified this report
      -
   *  -  **snapToGrid** |br|
         boolean
      -
      -  Snap to Grid option
      -
   *  -  **usingFields** |br|
         string
      -
      -  The ids of the fields used in report, separated by comma
      -
   *  -  **hasDeletedObjects** |br|
         boolean
      -
      -  True if using objects in deleted connections
      -
   *  -  **header** |br|
         object
      -
      -  Header content in a dynamic object
      -
   *  -  **footer** |br|
         object
      -
      -  Footer content in a dynamic object
      -
   *  -  **titleDescription** |br|
         object
      -
      -  Title description content in a dynamic object
      -
   *  -  **sourceId** |br|
         string (GUID)
      -  Y
      -  The id of the source report in case this was copied from that report
      -
   *  -  **checked** |br|
         boolean
      -
      -  Is selected for copy in Copy Management
      -
   *  -  **copyDashboard** |br|
         boolean
      -
      -  Whether this is copied because dashboard was copied
      -
   *  -  **exportFormatSetting** |br|
         object
      -
      -  An :doc:`ExportFormatSetting` object
      -
   *  -  **deletable** |br|
         boolean
      -
      -  True if report can be deleted
      -
   *  -  **editable** |br|
         boolean
      -
      -  True if report can be edited
      -
   *  -  **movable** |br|
         boolean
      -
      -  True if report can be moved
      -
   *  -  **copyable** |br|
         boolean
      -
      -  True if report can be copied
      -
   *  -  **accessPriority** |br|
         integer
      -
      -  The access priority
      -
   *  -  **active** |br|
         boolean
      -
      -  True if this is the latest version
      -

Inherited fields:

.. include:: Entity.rst
