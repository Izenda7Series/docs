

=========================================
QuerySourceFieldPagedRequest
=========================================

.. list-table::
   :header-rows: 1
   :widths: 25 5 60 10

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **querySource** |br|
         object
      -
      -  The parent :doc:`QuerySource` object
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

.. container:: toggle

   .. container:: header

      **Sample**:

   .. code-block:: json

      {
        "querySource" : {
           "id" : "9fa90af2-5329-44ac-a753-50c27f9d6fd5",
           "type" : "Table"
        },
        "criteria" : [],
        "tenantId" : null,
        "pageIndex" : 1,
        "pageSize" : 1,
        "sortOrders" : [{
              "key" : "Alias",
              "descending" : true
           }
        ]
      }
