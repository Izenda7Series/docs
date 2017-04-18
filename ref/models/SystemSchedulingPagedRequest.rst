

=========================================
SystemSchedulingPagedRequest
=========================================

.. list-table::
   :header-rows: 1
   :widths: 25 5 60 10

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **systemLevel** |br|
         boolean
      -
      -  Is the search at System level.
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
        "systemLevel" : true,
        "tenantId" : null,
        "pageIndex" : 1,
        "pageSize" : 10,
        "sortOrders" : [{
              "key" : "name",
              "descending" : true
           }
        ],
        "criteria" : [{
              "key" : "ReportingType",
              "value" : ""
           }, {
              "key" : "ReportDashboardName",
              "value" : ""
           }, {
              "key" : "DeliveryType",
              "value" : ""
           }, {
              "key" : "DeliveryMethod",
              "value" : ""
           }, {
              "key" : "Recipients",
              "value" : ""
           }, {
              "key" : "Type",
              "value" : ""
           }, {
              "key" : "LastSuccessfulRun",
              "value" : ""
           }, {
              "key" : "NextScheduledRun",
              "value" : ""
           }, {
              "key" : "NextScheduledRunFrom",
              "value" : ""
           }, {
              "key" : "NextScheduledRunTo",
              "value" : ""
           }, {
              "key" : "LastSuccessfulRunFrom",
              "value" : ""
           }, {
              "key" : "LastSuccessfulRunTo",
              "value" : ""
           }, {
              "key" : "RecurrenceType",
              "value" : ""
           }, {
              "key" : "ExportFileType",
              "value" : ""
           }, {
              "key" : "CreatedBy",
              "value" : ""
           }
        ]
      }
