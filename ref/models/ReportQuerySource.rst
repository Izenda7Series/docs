

=========================================
ReportQuerySource
=========================================

.. list-table::
   :header-rows: 1
   :widths: 25 5 65 5

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **id** |br|
         string (GUID)
      -
      -  The id of the query source
      -
   *  -  **name** |br|
         string
      -
      -  The name of the query source
      -
   *  -  **originalName** |br|
         string
      -
      -  The orignal name of the query source
      -
   *  -  **type** |br|
         string
      -
      -  Either "Table", "View", "Function" or "Stored Procedure"
      -
   *  -  **selected** |br|
         boolean
      -
      -  Is the query source selected
      -
   *  -  **visible** |br|
         boolean
      -
      -  Is the query source visible
      -
   *  -  **querySourceCategoryName** |br|
         string
      -
      -  The name of the category of the query source if available
      -
   *  -  **connectionName** |br|
         string
      -
      -  The name of the connection of the query source
      -
   *  -  **isAlias** |br|
         boolean
      -
      -  Is the query source an alias
      -
   *  -  **isDynamic** |br|
         boolean
      -
      -  Is the query source a dynamic stored procedure
      -
   *  -  **fields** |br|
         array of objects
      -
      -  An array of :doc:`QuerySourceField` objects
      -
