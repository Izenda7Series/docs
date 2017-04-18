

=========================================
UserPagedRequest
=========================================

.. list-table::
   :header-rows: 1
   :widths: 25 5 60 10

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **searchByRole** |br|
         arrray of objects
      -
      -  An array of :doc:`RoleDetail` objects
      -
   *  -  **visibleUserIds** |br|
         array of string (GUID)
      -
      -  The list of visible users' ids that the current user can view, search, sort
      -
   *  -  **userModeType** |br|
         integer
      -
      -  |br|

         *  0 = All
         *  1 = Access
         *  2 = Schedule
      -
   *  -  **includeRootAdminIfMatch** |br|
         boolean
      -
      -  Whether to include root admin if matching
      -
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
        "tenantId" : null,
        "criteria" : [{
              "key" : "All",
              "value" : "",
              "operation" : 1
           }
        ],
        "pageIndex" : 1,
        "pageSize" : 10,
        "sortOrders" : [{
              "key" : "userName",
              "descending" : true
           }
        ]
      }
