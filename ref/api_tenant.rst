

============================
Tenant APIs
============================

The **Tenant Setup** page allows user to

* manage tenants
* manage tenants' modules
* manage tenants' users and roles

List of APIs
------------

.. list-table::
   :class: apitable
   :widths: 35 65
   :header-rows: 1

   * - API
     - Purpose
   * - GET tenant/allTenants
     - Returns an array of all tenants.
   * - GET tenant/{tenant_id}
     - Returns the tenant specified by tenant_id.
   * - POST tenant
     - Saves a tenant.
   * - POST tenant/active/{tenant_id}
     - Sets active for the tenant specified by tenant_id.
   * - POST tenant/deactive/{tenant_id}
     - Sets inactive for the tenant specified by tenant_id.
   * - DELETE tenant/{tenant_id}
     - Deletes the tenant specified by tenant_id.
   * - GET tenant/activeTenants
     - Returns an array of active tenants.
   * - GET tenant/availableCategory/{type}
     - Returns an array of available categories for report/template (type=0) or dashboard (type=1).
   * - POST tenant/intergration/saveTenant
     - Adds or updates external tenant.
     
       .. note::
          
          To be renamed to "integration"



GET tenant/allTenants
--------------------------------------------------------------

Returns an array of all tenants.

**Request**

    No payload

**Response**

    An array of :doc:`models/Tenants` objects

**Samples**

   .. code-block:: http

      GET /api/tenant/allTenants HTTP/1.1

   Sample response::

      [{
           "id" : "e4c784eb-3e41-4849-925c-a9094b73dfb7",
           "tenantID" : "acme",
           "name" : "ACME Corporation",
           "description" : null,
           "active" : true,
           "deleted" : false,
           "modules" : "Report Template/ Component; Scheduling",
           "modified" : "2016-05-22T03:27:13.5070000+07:00",
           "tenantModules" : ["Report Template/ Component", "Scheduling"]
        }, {
           "id" : "811e2d3b-c656-46fa-b70e-7fe95bc6529f",
           "tenantID" : "doe",
           "name" : "John Doe",
           "description" : null,
           "active" : true,
           "deleted" : false,
           "modules" : "Report Template/ Component; Scheduling",
           "modified" : "2016-05-22T03:26:32.0000000+07:00",
           "tenantModules" : ["Report Template/ Component", "Scheduling"]
        }
      ]


GET tenant/{tenant_id}
--------------------------------------------------------------

Returns the tenant specified by tenant_id.

**Request**

    No payload

**Response**

    A :doc:`models/Tenants` object

**Samples**

   .. code-block:: http

      POST /api/tenant/e4c784eb-3e41-4849-925c-a9094b73dfb7 HTTP/1.1

   Sample response::

      {
         "id": "e4c784eb-3e41-4849-925c-a9094b73dfb7",
         "tenantID": "acme",
         "name": "ACME Corporation",
         "description": null,
         "active": false,
         "deleted": false,
         "modules": "Report Template/ Component; Scheduling",
         "modified": "2016-05-22T03:27:13.5070000+07:00",
         "tenantModules": ["Report Template/ Component", "Scheduling"]
      }


POST tenant
--------------------------------------------------------------

Saves a tenant.

**Request**

    Payload: a :doc:`models/Tenants` object

**Response**

    .. list-table::
       :header-rows: 1

       *  -  Field
          -  Description
          -  Note
       *  -  **success** |br|
             boolean
          -  Should be true
          -
       *  -  **tenant** |br|
             object
          -  The saved :doc:`models/Tenants` object
          -

**Samples**

   .. code-block:: http

      POST /api/tenant HTTP/1.1

   Request payload::

      {
        "tenantID" : "doe",
        "name" : "DOE",
        "tenantModules" : ["Report Template/ Component", "Scheduling"]
      }

POST tenant/active/{tenant_id}
--------------------------------------------------------------

Sets active for the tenant specified by tenant_id.

**Request**

    No payload

**Response**

    An :doc:`models/OperationResult` object with **success** field true if the update is successful

**Samples**

   .. code-block:: http

      POST /api/tenant/active/e2bae114-11d6-4c29-ab2b-2c3d3f6ba751 HTTP/1.1

   Sample response::

      {
        "success" : true,
        "messages" : null
      }


POST tenant/deactive/{tenant_id}
--------------------------------------------------------------

Sets inactive for the tenant specified by tenant_id.

**Request**

    No payload

**Response**

    An :doc:`models/OperationResult` object with **success** field true if the update is successful

**Samples**

   .. code-block:: http

      POST /api/tenant/deactive/e2bae114-11d6-4c29-ab2b-2c3d3f6ba751 HTTP/1.1

   Sample response::

      {
        "success" : true,
        "messages" : null
      }


DELETE tenant/{tenant_id}
--------------------------------------------------------------

Deletes the tenant specified by tenant_id.

**Request**

    No payload

**Response**

    An :doc:`models/OperationResult` object with **success** field true if the deletion is successful

**Samples**

   .. code-block:: http

      DELETE /api/tenant/811e2d3b-c656-46fa-b70e-7fe95bc6529f HTTP/1.1

   Sample response::

      {
        "success" : true,
        "messages" : null
      }


GET tenant/activeTenants
--------------------------------------------------------------

Returns an array of active tenants.

**Request**

    No payload

**Response**

    An array of :doc:`models/Tenants` objects

**Samples**

   .. code-block:: http

      GET /api/tenant/activeTenants HTTP/1.1

   Sample response::

      [{
         "id": "e4c784eb-3e41-4849-925c-a9094b73dfb7",
         "tenantID": "acme",
         "name": "ACME Corporation",
         "description": null,
         "active": true,
         "deleted": false,
         "modules": "Report Template/ Component; Scheduling",
         "modified": "2016-04-22T03:27:13.5070000+07:00",
         "tenantModules": ["Report Template/ Component", "Scheduling"]
      }]


GET tenant/availableCategory/{type}
--------------------------------------------------------------

Returns an array of available categories for report/template (type=0) or dashboard (type=1).

**Request**

    No payload

**Response**

    An array of :doc:`models/Category` objects

**Samples**

   .. code-block:: http

      GET /api/tenant/availableCategory/0 HTTP/1.1

   Sample response::

      [{
           "reports" : null,
           "name" : "Sample",
           "type" : 0,
           "parentId" : null,
           "tenantId" : null,
           "canDelete" : true,
           "savable" : false,
           "subCategories" : [],
           "status" : 2,
           "id" : "7b604d85-83b6-4c55-8392-eb517f30b75a",
           "state" : 0,
           "inserted" : true,
           "version" : null,
           "created" : null,
           "createdBy" : null,
           "modified" : null,
           "modifiedBy" : null
        }, {
           "reports" : null,
           "name" : "Sample",
           "type" : 0,
           "parentId" : null,
           "tenantId" : null,
           "canDelete" : true,
           "savable" : false,
           "subCategories" : [{
                 "reports" : null,
                 "name" : "Sub",
                 "type" : 0,
                 "parentId" : "8f966b73-bf1d-4c03-87ca-a946898a91db",
                 "tenantId" : null,
                 "canDelete" : true,
                 "savable" : false,
                 "subCategories" : [],
                 "status" : 2,
                 "id" : "ac4219e1-91a7-4c2d-b42c-e27b12681c3c",
                 "state" : 0,
                 "inserted" : true,
                 "version" : null,
                 "created" : null,
                 "createdBy" : null,
                 "modified" : null,
                 "modifiedBy" : null
              }
           ],
           "status" : 2,
           "id" : "8f966b73-bf1d-4c03-87ca-a946898a91db",
           "state" : 0,
           "inserted" : true,
           "version" : null,
           "created" : null,
           "createdBy" : null,
           "modified" : null,
           "modifiedBy" : null
        }, {
           "name" : "Uncategorized",
           "type" : 0,
           "parentId" : null,
           "tenantId" : null,
           "canDelete" : false,
           "savable" : false,
           "subCategories" : [],
           "status" : 1,
           "id" : "00000000-0000-0000-0000-000000000000",
           "state" : 0,
           "inserted" : true,
           "version" : null,
           "created" : null,
           "createdBy" : null,
           "modified" : null,
           "modifiedBy" : null
        }
      ]


POST tenant/intergration/saveTenant
--------------------------------------------------------------

Adds or updates external tenant.

**Request**

    Payload: a :doc:`models/Tenants` object

**Response**

    Should be true

**Samples**

   To be updated
