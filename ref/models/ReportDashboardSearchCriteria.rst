

=========================================
ReportDashboardSearchCriteria
=========================================

.. list-table::
   :header-rows: 1
   :widths: 25 5 65 5

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **criterias** |br|
         array of objects
      -
      -  An array of :doc:`SearchCriteria` objects
      -
   *  -  **sortCriteria** |br|
         object
      -
      -  A :doc:`SortOrder` object
      -
   *  -  **tenantId** |br|
         string (GUID)
      -  Y
      -  The id of the tenant if available
      -
   *  -  **type** |br|
         integer
      -
      -  The type

         - 0 = Report
         - 1 = Template
         - 2 = Dashboard
      -
   *  -  **isUncategorized** |br|
         boolean
      -
      -  Searches uncategorized rows or not
      -
   *  -  **visibleCategoryIds** |br|
         array of strings (GUID)
      -
      -  List of visible category ids
      -
   *  -  **visibleSubCategoryIds** |br|
         array of strings (GUID)
      -
      -  List of visible sub-category ids
      -
   *  -  **defaultChecked** |br|
         boolean
      -
      -  Default checked setting
      -
   *  -  **includeHascode** |br|
         boolean
      -
      -  Whether to compute hashcode
      -
   *  -  **timestampOffset** |br|
         real number
      -
      -  The timestamp offset
      -

.. container:: toggle

   .. container:: header

      **Sample**:

   .. code-block:: json

      {
        "tenantId" : null,
        "isUncategorized" : false,
        "criterias" : [{
              "key" : "CategoryId"
           }
        ]
      }
