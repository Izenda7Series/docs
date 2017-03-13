

=========================================
ReportField
=========================================

.. list-table::
   :header-rows: 1
   :widths: 25 5 65 5

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **fieldId** |br|
         string (GUID)
      -
      -  The id of the field
      -
   *  -  **originalName** |br|
         string
      -
      -  The original name of the field
      -
   *  -  **fieldName** |br|
         string
      -
      -  The name of the field
      -
   *  -  **fieldNameAlias** |br|
         string
      -
      -  The alias of the field
      -
   *  -  **dataFieldType** |br|
         string
      -
      -  The data type
      -
   *  -  **querySourceId** |br|
         string (GUID)
      -  Y
      -  The id of the query source
      -
   *  -  **querySourceType** |br|
         string
      -
      -  Either "Table", "View", "Stored Procedure" or "Function"
      -
   *  -  **sourceAlias** |br|
         string
      -
      -  The source alias
      -
   *  -  **querySourceAlias** |br|
         string
      -
      -  The alias of the query source
      -
   *  -  **relationshipId** |br|
         string (GUID)
      -  Y
      -  The id of the relationship if applicable
      -
   *  -  **visible** |br|
         boolean
      -
      -  Is the field visible
      -
   *  -  **filterable** |br|
         boolean
      -
      -  Is the field filterable
      -
   *  -  **reportId** |br|
         string (GUID)
      -  Y
      -  The id of the report of applicable
      -
   *  -  **fieldFunctionExpression** |br|
         string
      -
      -  The expression
      -
   *  -  **grandTotalExpression** |br|
         string
      -
      -  The grand total expression
      -
   *  -  **subTotalExpression** |br|
         string
      -
      -  The sub total expression
      -
   *  -  **sort** |br|
         string
      -
      -  Either "Unsorted", "Ascending" or "Descending"
      -
   *  -  **autoSort** |br|
         boolean
      -
      -  Internal use: whether the field is automatically sorted
      -
   *  -  **function** |br|
         string
      -
      -  The function
      -
   *  -  **formatting** |br|
         object
      -
      -  A :doc:`DataFormating` object
      -
   *  -  **functionDataType** |br|
         string
      -
      -  The result data type of the function
      -
   *  -  **calculatedTree** |br|
         string
      -
      -  The calculated tree
      -
   *  -  **grandTotalTree** |br|
         string
      -
      -  The grand total tree
      -
   *  -  **isCalculated** |br|
         boolean
      -
      -  Is this a calculated field
      -
   *  -  **hasAggregatedFunction** |br|
         boolean
      -
      -  Whether this field uses aggregated function
      -
