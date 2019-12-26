.. _External_Role:

============================
External Role
============================

.. _RoleExternal:

.. raw:: html
   :file: ./external-role.html


Permission and string value mapping
-----------------------------------

.. list-table::
   :header-rows: 1
   :widths: 25 5 65 5

   *  -  Permission
      -  String Value
      -  Note
   *  -  **systemAdmin** |br|
         boolean
      -
      -
   *  -  **fullReportAndDashboardAccess** |br|
         boolean
      -
      -
   *  -  **systemConfiguration** |br|
         object
      -
      -
   *  -  .. container:: lpad2
   
            **scheduledInstances** |br|
            object
      -
      - 
   *  -  .. container:: lpad4
   
            **value** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  **dataSetup** |br|
         object
      -
      -
   *  -  .. container:: lpad2
   
            **dataModel** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **value** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **customView** |br|
            object
      -
      -
   *  -  .. container:: lpad6
   
            **create** |br|
            boolean
      -
      -
   *  -  .. container:: lpad6
   
            **edit** |br|
            boolean
      -
      -
   *  -  .. container:: lpad6
   
            **delete** |br|
            boolean
      -
      -
   *  -  .. container:: lpad6
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **advancedSettings** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **category** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **others** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  **userSetup** |br|
         object
      -
      -
   *  -  .. container:: lpad2
   
            **userRoleAssociation** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **value** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **actions** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **create** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **edit** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **del** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **configureSecurityOptions** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  **roleSetup** |br|
         object
      -
      -
   *  -  .. container:: lpad2
   
            **actions** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **create** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **edit** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **del** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **dataModelAccess** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **value** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **permissions** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **value** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **grantRoleWithFullReportAndDashboardAccess** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **value** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  **reports** |br|
         object
      -
      -
   *  -  .. container:: lpad2
   
            **canCreateNewReport** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **value** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **dataSources** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **simpleDataSources** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **advancedDataSources** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **reportPartTypes** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **chart** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **form** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **gauge** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **map** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **reportCategoriesSubcategories** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **canCreateNewCategory** |br|
            object
      -
      -
   *  -  .. container:: lpad6
   
            **value** |br|
            boolean
      -
      -
   *  -  .. container:: lpad6
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad4
   
            **categoryAccessibility** |br|
            object
      -
      -
   *  -  .. container:: lpad6
   
            **categories** |br|
            array of objects
      -
      -
   *  -  .. container:: lpad6
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **filterProperties** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **filterLogic** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **CrossFiltering** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **fieldProperties** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **customURL** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **embeddedJavaScript** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **subreport** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **actions** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **schedule** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **email** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **viewReportHistory** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **del** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **registerForAlerts** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **print** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **unarchiveReportVersions** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **overwriteExistingReport** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **subscribe** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **exporting** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **configureAccessRights** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  **tenantSetup** |br|
         object
      -
      -
   *  -  .. container:: lpad2
   
            **actions** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **create** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **edit** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **del** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **permissions** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **value** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  **dashboards** |br|
         object
      -
      -
   *  -  .. container:: lpad2
   
            **canCreateNewDashboard** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **value** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **displayDashboardTileHeader** |br|
            object

             .. versionadded:: 3.1.0
      -
      -
   *  -  .. container:: lpad4

            **value** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4

            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **dashboardCategoriesSubcategories** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **canCreateNewCategory** |br|
            object
      -
      -
   *  -  .. container:: lpad6
   
            **value** |br|
            boolean
      -
      -
   *  -  .. container:: lpad6
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad4
   
            **categoryAccessibility** |br|
            object
      -
      -
   *  -  .. container:: lpad6
   
            **categories** |br|
            array of objects
      -
      -
   *  -  .. container:: lpad6
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **actions** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **schedule** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **email** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **del** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **subscribe** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **print** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **overwriteExistingDashboard** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **configureAccessRights** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  **access** |br|
         object
      -
      -
   *  -  .. container:: lpad2
   
            **accessLimits** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **value** |br|
            array of objects
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **accessDefaults** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **value** |br|
            array of objects
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  **scheduling** |br|
         object
      -
      -
   *  -  .. container:: lpad2
   
            **schedulingLimits** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **value** |br|
            array of objects
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **schedulingScope** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **systemUsers** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **externalUsers** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  **emailing** |br|
         object
      -
      -
   *  -  .. container:: lpad2
   
            **deliveryMethod** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **link** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **embeddedHTML** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **attachment** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **attachmentType** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **word** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **excel** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **pdf** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **csv** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **xml** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **json** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  **exporting** |br|
         object
      -
      -
   *  -  .. container:: lpad2
   
            **exportingFormat** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **word** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **excel** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **pdf** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **csv** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **xml** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **json** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **queryExecution** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  **systemWide** |br|
         object
      -
      -
   *  -  .. container:: lpad2
   
            **canSeeSystemMessages** |br|
            object
      -
      -
   *  -  .. container:: lpad4
   
            **value** |br|
            boolean
      -
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **tenantAccess** |br|
            integer
      -
      -
   *  -  .. container:: lpad2
   
            **accessLimitsTree** |br|
            an array of objects

            .. versionadded:: 2.9.0
      -
      -
   *  -  .. container:: lpad2
   
            **schedulingLimitsTree** |br|
            an array of objects

            .. versionadded:: 2.9.0
      -
      -  