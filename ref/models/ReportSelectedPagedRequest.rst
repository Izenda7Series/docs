

=========================================
ReportSelectedPagedRequest
=========================================

.. list-table::
   :header-rows: 1
   :widths: 25 5 60 10

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **querySources** |br|
         array of objects
      -
      -  An array of :doc:`ReportSelectedQuerySource` objects
      -
   *  -  **categoryId** |br|
         string (GUID)
      -  Y
      -  The id of the category if available
      -  Inherited from :doc:`ReportPagedRequest`
   *  -  **subCategoryId** |br|
         string (GUID)
      -  Y
      -  The id of the sub-category if available
      -  Inherited from :doc:`ReportPagedRequest`
   *  -  **timestampOffset** |br|
         real number
      -
      -  The timestamp offset. See :doc:`/ui/doc_user_setup`.
      -  Inherited from :doc:`ReportPagedRequest`
   *  -  **tenantId** |br|
         string (GUID)
      -  Y
      -  The id of the tenant
      -  Inherited from :doc:`PagedRequest`
   *  -  **criteria** |br|
         array of objects
      -
      -  An array of :doc:`SearchCriteria` objects
      -  Inherited from :doc:`PagedRequest`
   *  -  **sortOrders** |br|
         array of objects
      -
      -  An array of :doc:`SortOrder` objects
      -  Inherited from :doc:`PagedRequest`
   *  -  **pageIndex** |br|
         integer
      -
      -  The index of the page
      -  Inherited from :doc:`PagedRequest`
   *  -  **pageSize** |br|
         integer
      -
      -  The size of the page
      -  Inherited from :doc:`PagedRequest`
   *  -  **total** |br|
         integer
      -
      -  The total number of rows
      -  Inherited from :doc:`PagedRequest`
   *  -  **skipItems** |br|
         integer
      -
      -  Skip items
      -  Inherited from :doc:`PagedRequest`
   *  -  **isLastPage** |br|
         boolean
      -
      -  Whether this is the last page
      -  Inherited from :doc:`PagedRequest`

.. container:: toggle

   .. container:: header

      **Sample**:

   .. code-block:: json

       {
         "querySources" : [{
             "querySourceId": "39e2a9b9-3be3-4b8b-ae86-0823ecb3c533",
             "selected": true
          }],
         "tenantId" : null,
         "criteria" : null,
         "pageIndex" : 1,
         "pageSize" : 10,
         "sortOrders" : null
       }
