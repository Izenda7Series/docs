
==================
Tenants
==================

.. list-table::
   :header-rows: 1
   :widths: 25 5 65 5

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **tenantId** |br|
         string
      -
      -  The user-selected id of the tenant
      -
   *  -  **name** |br|
         string
      -
      -  The name of the tenant
      -
   *  -  **description** |br|
         string
      -
      -  The description of the tenant
      -
   *  -  **active** |br|
         boolean
      -
      -  Is the tenant active
      -
   *  -  **modules** |br|
         string
      -
      -  The selected modules for the tenant, separated by semi-colon
      -
   *  -  **tenantModules** |br|
         array of strings
      -
      -  An array of selected module names for the tenant
      -

Inherited fields:

.. include:: Entity.rst
