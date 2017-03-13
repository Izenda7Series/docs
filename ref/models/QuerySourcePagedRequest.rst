

=========================================
QuerySourcePagedRequest
=========================================

.. list-table::
   :header-rows: 1
   :widths: 25 5 60 10

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **querySourceType** |br|
         string
      -
      -  The query source type (Table, View, or Stored Procedure)
      -
   *  -  **tenantId** |br|
         string (GUID)
      -  Y
      -  The total number of rows
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
