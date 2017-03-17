

===================
PerformanceSetting
===================

.. list-table::
   :header-rows: 1
   :widths: 25 65 10

   *  -  Field
      -  Description
      -  Note
   *  -  **queryTimeoutValue** |br|
         integer
      -  An array of child ValueTreeNode objects.
      -
   *  -  **queryTimeoutDefaultValue** |br|
         integer
      -  The default value for Query Timeout (``3600`` s)
      -
   *  -  **useNoLockValue** |br|
         boolean
      -  Use NOLOCK setting - whether the NOLOCK or equivalent clauses will be used in SQL queries.
      -
   *  -  **useNoLockDefaultValue** |br|
         boolean
      -  The default value for Use NOLOCK (``true``)
      -
   *  -  **dataSourceLimitValue** |br|
         integer
      -  Data Source Limit - the number of data sources allowed to be used in a single report.
      -
   *  -  **dataSourceLimitDefaultValue** |br|
         integer
      -  The default value for Data Source Limit (``1000``)
      -
   *  -  **tenantId** |br|
         string (GUID)
      -  The id of the tenant |br|
         null if the setting belongs to system
      -

.. container:: toggle

   .. container:: header

      **Sample**:

   .. code-block:: json

      {
        "queryTimeoutValue" : 3600,
        "queryTimeoutDefaultValue" : 3600,
        "useNoLockValue" : true,
        "useNoLockDefaultValue" : true,
        "dataSourceLimitValue" : 1000,
        "dataSourceLimitDefaultValue" : 1000,
        "tenantId" : null
      }
