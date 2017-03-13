=========================================
ReportFilterField
=========================================

.. list-table::
   :header-rows: 1
   :widths: 25 5 65 5

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **connectionName** |br|
         string
      -
      -  The name of the connection
      -
   *  -  **querySourceCategoryName** |br|
         string
      -
      -  The name of the category of the data source
      -
   *  -  **sourceFieldName** |br|
         string
      -
      -  The name of the data source field
      -
   *  -  **sourceFieldVisible** |br|
         boolean
      -
      -  Is the data source field selected to be visible in Data Model
      -
   *  -  **sourceFieldFilterable** |br|
         boolean
      -
      -  Is the data source field selected to be filterable in Data Model
      -
   *  -  **sourceDataObjectName** |br|
         string
      -
      -  The name of the data source
      -
   *  -  **sourceDataObjectFullName** |br|
         string
      -
      -  The fully-qualified name of the data source
      -
   *  -  **dataType** |br|
         string
      -
      -  The data type of the data source field
      -
   *  -  **isParameter** |br|
         boolean
      -
      -  Is the filter field a stored procedure parameter
      -
   *  -  **isCalculated** |br|
         boolean
      -
      -  Is this a calculated field
      -
   *  -  **calculatedTree** |br|
         string
      -
      -  The calculated tree
      -
   *  -  **compareFieldCalculatedTree** |br|
         string
      -
      -  The compare field calculated tree used for filter field comparison
      -
   *  -  **compareField** |br|
         string (GUID)
      -
      -  The compare field - used for filter field comparison
      -
   *  -  **selected** |br|
         boolean
      -
      -  Is the filter field selected
      -
   *  -  **dataFormat** |br|
         object
      -
      -  A :doc:`DataFormat` object
      -
   *  -  **reportId** |br|
         string (GUID)
      -  Y
      -  The id of the report
      -
   *  -  **useMappedFieldAlias** |br|
         boolean
      -  Y
      -  Internal use: whether filter uses mapped field alias, if yes, it will not be re-calculated to generate expression.
      -
   *  -  **uniqueId** |br|
         string (GUID)
      -
      -  The unique id for Front-end to show specific error messages
      -
   *  -  **comparisonValue** |br|
         string
      -
      -  The comparison value
      -




Inherited fields:

.. include:: FilterField.rst
