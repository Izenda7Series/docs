
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

.. container:: toggle

   .. container:: header

      **Sample**:

   .. code-block:: json

      {
        "id" : "e4c784eb-3e41-4849-925c-a9094b73dfb7",
        "tenantID" : "acme",
        "name" : "ACME Corporation",
        "description" : null,
        "active" : true,
        "deleted" : false,
        "modules" : "Report Template/ Component; Scheduling",
        "modified" : "2016-05-22T03:27:13.5070000+07:00",
        "tenantModules" : ["Report Template/ Component", "Scheduling"]
     }
