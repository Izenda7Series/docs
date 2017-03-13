

=========================================
DashboardPart
=========================================

.. list-table::
   :header-rows: 1
   :widths: 25 5 65 5

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **dashboardId** |br|
         string (GUID)
      -  Y
      -  The id of the dashboard
      -
   *  -  **reportName** |br|
         string
      -
      -  The name of the parent report of the report part
      -
   *  -  **type** |br|
         string
      -
      -  The type of the dashboard part
      -
   *  -  **title** |br|
         string
      -
      -  The title of the dashboard part
      -
   *  -  **reportId** |br|
         string (GUID)
      -  Y
      -  The id of the report containing the report part
      -
   *  -  **reportPartId** |br|
         string (GUID)
      -  Y
      -  The id of the report part being used
      -
   *  -  **content** |br|
         string
      -
      -  The content of the report part
      -
   *  -  **filterDescription** |br|
         string
      -
      -  The filter description for display
      -
   *  -  **numberOfRecord** |br|
         integer
      -  Y
      -  The number of records
      -
   *  -  **positionX** |br|
         integer
      -
      -  The row number position
      -
   *  -  **positionY** |br|
         integer
      -
      -  The column number position
      -
   *  -  **width** |br|
         integer
      -
      -  The width of dashboard part
      -
   *  -  **height** |br|
         integer
      -
      -  The height of dashboard part
      -
   *  -  **filters** |br|
         array of objects
      -
      -  An array of :doc:`DashboardPartFilterField` objects
      -
   *  -  **reportDataSource** |br|
         array of objects
      -
      -  An array of :doc:`ReportDataSource` objects
      -


Inherited fields:

.. include:: Entity.rst
