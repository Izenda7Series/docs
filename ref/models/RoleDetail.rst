
=================
RoleDetail
=================

.. list-table::
   :header-rows: 1
   :widths: 25 5 65 5

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **users** |br|
         array of objects
      -
      -  An array of :doc:`UserDetail` objects
      -
   *  -  **permission** |br|
         object
      -
      -  A :doc:`Permission` object
      -
   *  -  **visibleQuerySourceFields** |br|
         array of strings
      -
      -  An array of strings (GUID) which are ids of visible query source fields.
      -

Inherited fields:

.. include:: Role.rst

.. container:: toggle

   .. container:: header

      **Sample**:

   .. code-block:: json

      {
         "users": [],
         "permission": null,
         "visibleQuerySourceFields": null,
         "name": "Analyst",
         "tenantId": null,
         "active": true,
         "deleted": false,
         "permissionData": "",
         "querySourceFields": "",
         "id": "0d030b1a-9568-4c98-8b1e-5dcc94dbd281",
         "state": 0,
         "inserted": true,
         "version": 1,
         "created": null,
         "createdBy": null,
         "modified": null,
         "modifiedBy": null
      }
