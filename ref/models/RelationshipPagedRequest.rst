

=========================================
RelationshipPagedRequest
=========================================

.. list-table::
   :header-rows: 1
   :widths: 25 5 60 10

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **querySourceId** |br|
         string (GUID)
      -  Y
      -  The id of the query source
      -
   *  -  **objectId** |br|
         string (GUID)
      -  Y
      -  The id of the object in draft to load from |br| |br|
         Put null here to load from the database
      -
   *  -  **relationshipOrders** |br|
         array of objects
      -
      -  An array of :doc:`RelationshipOrder` objects
      -
   *  -  **querySources** |br|
         array of objects
      -
      -  An array of :doc:`ReportSelectedQuerySource` objects
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
        "querySourceId" : null,
        "tenentId" : "",
        "criteria" : [{
              "key" : "All",
              "value" : "",
              "operation" : 1
           }
        ],
        "pageIndex" : 1,
        "pageSize" : 1,
        "sortOrders" : [{
              "key" : "DatabaseName",
              "descending" : true
           }
        ]
      }
