

=========================================
UserPermission
=========================================

.. list-table::
   :header-rows: 1
   :widths: 25 5 65 5

   *  -  Field
      -  Null
      -  Description
      -  Note
   *  -  **reportId** |br|
         string (GUID)
      -  Y
      -  The id of the report
      -
   *  -  **dashboardId** |br|
         string (GUID)
      -  Y
      -  The id of the dashboard
      -
   *  -  **assignedType** |br|
         integer
      -
      -  The assign type

         -  1 = Everyone
         -  2 = Role
         -  3 = User
      -
   *  -  **accessRightId** |br|
         string (GUID)
      -  Y
      -  The id of the access right
      -
   *  -  **accessRight** |br|
         string
      -
      -  The access right
      -
   *  -  **sharedWith** |br|
         string
      -  Y
      -  The name of the user or role or "Everyone"
      -
   *  -  **position** |br|
         integer
      -
      -  The position
      -
   *  -  **accessors** |br|
         array of strings (GUID)
      -
      -  The ids of users or roles
      -


Inherited fields:

.. include:: Entity.rst
