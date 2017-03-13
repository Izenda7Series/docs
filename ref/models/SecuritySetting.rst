

===================
SecuritySetting
===================

.. list-table::
   :header-rows: 1
   :widths: 25 65 10

   *  -  Field
      -  Description
      -  Note
   *  -  **tenantFieldValue** |br|
         string
      -  Names of tenant fields, separated by semi-colon |br| |br|
         Example: ``TenantID;UserID``
      -
   *  -  **tenantFieldDefaultValue** |br|
         string
      -  The default value for tenantFieldValue
      -
   *  -  **showTenantFieldValue** |br|
         boolean
      -  Show Tenant Field - when false, this hides the fields identified in the TenantField property from being selected or viewed by users. Any filters based on the tenant fields will still affect the results.
      -
   *  -  **showTenantFieldDefaultValue** |br|
         boolean
      -  The default value for Show Tenant Field (``true``)
      -
   *  -  **setAdditiveFieldAutoVisibleValue** |br|
         boolean
      -  Additive Fields Auto Visible - if checked then additive fields when physical data model changes will be set as Visible automatically.
      -
   *  -  **setAdditiveFieldAutoVisibleDefaultValue** |br|
         boolean
      -  The default value for Additive Fields Auto Visible (``false``)
      -
   *  -  **setAdditiveFieldAutoFilterableValue** |br|
         boolean
      -  Additive Fields Auto Filterable - if checked then additive fields when physical data model changes will be set as Filterable automatically.
      -
   *  -  **setAdditiveFieldAutoFilterableDefaultValue** |br|
         boolean
      -  The default value for Additive Fields Auto Filterable (``false``)
      -
   *  -  **tenantFields** |br|
         array of objects
      -  An array of :doc:`TenantField` objects
      -
   *  -  **allowShowTenant** |br|
         boolean
      -  Is Show Tenant Field disabled
      -
   *  -  **tenantId** |br|
         string (GUID)
      -  The id of the tenant |br|
         null if the setting belongs to system
      -
