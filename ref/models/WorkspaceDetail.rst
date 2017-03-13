

=================
WorkspaceDetail
=================

.. list-table::
   :header-rows: 1
   :widths: 25 5 65 5

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **workspaceTenants** |br|
         array of objects
      -
      -  An array of :doc:`WorkspaceTenantDetail` objects.
      -
   *  -  **workspaceMappings** |br|
         array of objects
      -
      -  An array of :doc:`WorkspaceMappingDetail` objects.
      -
   *  -  **copyOption** |br|
         object
      -
      -  A dynamic object
      -
   *  -  **copyAdvancedSettingOption** |br|
         object
      -
      -  A dynamic object
      -
   *  -  **copyTenantPermissionOption** |br|
         object
      -
      -  A dynamic object
      -
   *  -  **copyRolePermissionOption** |br|
         object
      -
      -  A dynamic object
      -
   *  -  **copyReportOption** |br|
         object
      -
      -  A dynamic object
      -
   *  -  **copyDashboardOption** |br|
         object
      -
      -  A dynamic object
      -
   *  -  **copyTemplateOption** |br|
         object
      -
      -  A dynamic object
      -
   *  -  **sourceConnections** |br|
         array of objects
      -
      -  An array of :doc:`Connection` objects.
      -
   *  -  **sourceReports** |br|
         array of objects
      -
      -  An array of :doc:`Category` objects.
      -
   *  -  **sourceTemplates** |br|
         array of objects
      -
      -  An array of :doc:`Category` objects.
      -
   *  -  **sourceDashboards** |br|
         array of objects
      -
      -  An array of :doc:`Category` objects.
      -
   *  -  **copiedRoles** |br|
         array of strings (GUIDs)
      -
      -  The list of ids of copied roles
      -
   *  -  **copiedRolePermissions** |br|
         array of strings (GUIDs)
      -
      -  The list of ids of copied roles
      -
   *  -  **allHashcodes** |br|
         dynamic object
      -
      -  Each field contains the hashcode for each copied section, e.g. advancedSettings, tenantPermission, etc.
      -




Inherited fields:

.. include:: Workspace.rst
