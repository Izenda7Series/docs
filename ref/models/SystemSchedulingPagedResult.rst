

=========================================
SystemSchedulingPagedResult
=========================================

.. list-table::
   :header-rows: 1
   :widths: 25 5 60 10

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **result** |br|
         array of objects
      -
      -  An array of :doc:`Subscription` objects
      -
   *  -  **tenantId** |br|
         string (GUID)
      -  Y
      -  The id of the tenant if available
      -
   *  -  **tenantName** |br|
         string
      -
      -  The name of the tenant
      -
   *  -  **pageIndex** |br|
         integer
      -
      -  The index of the page
      -  Inherited from :doc:`PagedResult`
   *  -  **pageSize** |br|
         integer
      -
      -  The size of the page
      -  Inherited from :doc:`PagedResult`
   *  -  **total** |br|
         integer
      -
      -  The total number of rows
      -  Inherited from :doc:`PagedResult`
