

=======================
QuerySource
=======================

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
      -  The query source name qualified with schema name |br|
         Example: ``dbo.Table1``
      -
   *  -  **realName** |br|
         string
      -
      -  The name of the query source
      -
   *  -  **type** |br|
         string
      -
      -  Either "Table", "View", "Stored Procedure" or "Function"
      -
   *  -  **parentQuerySourceId** |br|
         string (GUID)
      -  Y
      -  Place-holder
      -
   *  -  **categoryId** |br|
         string (GUID)
      -  Y
      -  The id of the category (user schema)
      -
   *  -  **selected** |br|
         boolean
      -
      -  Is this query source selected in data model
      -
   *  -  **deleted** |br|
         boolean
      -
      -  Is this query source removed from data model
      -
   *  -  **connectionId** |br|
         string (GUID)
      -
      -  The id of the connection containing the query source
      -
   *  -  **connectionName** |br|
         string
      -
      -  The name of the connection containing the query source
      -
   *  -  **childs** |br|
         array of objects
      -  Y
      -  An array of children QuerySource objects if available
      -
   *  -  **dataSourceCategoryId** |br|
         string (GUID)
      -  Y
      -  The id of the data source category containing the query source
      -
   *  -  **dataSourceCategoryName** |br|
         string
      -
      -  The name of the data source category containing the query source
      -
   *  -  **alias** |br|
         string
      -
      -  The alias entered by user
      -
   *  -  **originalAlias** |br|
         string
      -
      -  The original alias
      -
   *  -  **querySourceFields** |br|
         array of objects
      -
      -  An array of :doc:`QuerySourceField` objects
      -
   *  -  **querySourceCategoryName** |br|
         string
      -
      -  The schema name
      -
   *  -  **querySourceCategory** |br|
         object
      -
      -  A :doc:`QuerySourceCategory` object (schema)
      -
   *  -  **modified** |br|
         datetime in ISO 8601 format
      -  Y
      -  The modification time
      -
   *  -  **extendedProperties** |br|
         string
      -
      -  The extended properties if available  (for stored procedures)
      -
   *  -  **physicalChange** |br|
         integer
      -
      -  Has the query source changed

         -  0 = None
         -  1 = Added
         -  2 = Modified
         -  3 = Deleted
      -
   *  -  **approval** |br|
         boolean
      -
      -  Is the change approved
      -
   *  -  **existed** |br|
         boolean
      -
      -  Place-holder
      -
   *  -  **checked** |br|
         boolean
      -
      -  Is selected for copy in Copy Management
      -
   *  -  **belongToCopiedReport** |br|
         boolean
      -
      -  Whether this query source belongs to a copied report
      -
