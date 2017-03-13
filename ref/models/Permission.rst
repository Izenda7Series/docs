

=========================================
Permission
=========================================

.. list-table::
   :header-rows: 1
   :widths: 25 5 65 5

   *  -  Field
      -  Null
      -  Description
      -  Note
   *  -  **systemAdmin** |br|
         boolean
      -
      -  System admin option
      -
   *  -  **fullReportAndDashboardAccess** |br|
         boolean
      -
      -  Is this a full access permission
      -
   *  -  **systemConfiguration** |br|
         object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad2
   
            **scheduledInstances** |br|
            object
      -
      -  An object with the following fields
      - 
   *  -  .. container:: lpad4
   
            **value** |br|
            boolean
      -
      -  Is permission for Scheduled Instances set
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  **dataSetup** |br|
         object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad2
   
            **dataModel** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **value** |br|
            boolean
      -
      -  Is permission for Data Model set
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **advancedSettings** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **category** |br|
            boolean
      -
      -  Is permission for Category set
      -
   *  -  .. container:: lpad4
   
            **others** |br|
            boolean
      -
      -  Is permission for Others set
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  **userSetup** |br|
         object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad2
   
            **userRoleAssociation** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **value** |br|
            boolean
      -
      -  Permission for User Role Association
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **actions** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **create** |br|
            boolean
      -
      -  Is permission for Create set
      -
   *  -  .. container:: lpad4
   
            **edit** |br|
            boolean
      -
      -  Is permission for Edit set
      -
   *  -  .. container:: lpad4
   
            **del** |br|
            boolean
      -
      -  Is permission for Delete set
      -
   *  -  .. container:: lpad4
   
            **configureSecurityOptions** |br|
            boolean
      -
      -  Is permission for Configure Security Options set
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  **roleSetup** |br|
         object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad2
   
            **actions** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **create** |br|
            boolean
      -
      -  Is permission for Create set
      -
   *  -  .. container:: lpad4
   
            **edit** |br|
            boolean
      -
      -  Is permission for Edit set
      -
   *  -  .. container:: lpad4
   
            **del** |br|
            boolean
      -
      -  Is permission for Delete set
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **dataModelAccess** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **value** |br|
            boolean
      -
      -  Is permission for Data Model set
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **permissions** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **value** |br|
            boolean
      -
      -  Is permission for Permissions set
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **grantRoleWithFullReportAndDashboardAccess** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **value** |br|
            boolean
      -
      -  Is permission for Grant Role With Full Report And Dashboard Access set
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  **reports** |br|
         object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad2
   
            **canCreateNewReport** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **value** |br|
            boolean
      -
      -  Is permission for Can Create New Report set
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **dataSources** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **simpleDataSources** |br|
            boolean
      -
      -  Is permission for Simple Data Sources set
      -
   *  -  .. container:: lpad4
   
            **advancedDataSources** |br|
            boolean
      -
      -  Is permission for Advanced Data Sources set
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **reportPartTypes** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **chart** |br|
            boolean
      -
      -  Is permission for Chart set
      -
   *  -  .. container:: lpad4
   
            **form** |br|
            boolean
      -
      -  Is permission for Form set
      -
   *  -  .. container:: lpad4
   
            **gauge** |br|
            boolean
      -
      -  Is permission for Gauge set
      -
   *  -  .. container:: lpad4
   
            **Map** |br|
            boolean
      -
      -  Is permission for Map set
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **reportCategoriesSubcategories** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **canCreateNewCategory** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad6
   
            **value** |br|
            boolean
      -
      -  Is permission for CanCreateNewCategory set
      -
   *  -  .. container:: lpad6
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad4
   
            **categoryAccessibility** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad6
   
            **categories** |br|
            array of objects
      -
      -  An array of :doc:`Category` objects
      -
   *  -  .. container:: lpad6
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **filterProperties** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **filterLogic** |br|
            boolean
      -
      -  Is permission for Filter Logic set
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **fieldProperties** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **customURL** |br|
            boolean
      -
      -  Is permission for Custom URL set
      -
   *  -  .. container:: lpad4
   
            **embeddedJavaScript** |br|
            boolean
      -
      -  Is permission for Embedded JavaScript set
      -
   *  -  .. container:: lpad4
   
            **subreport** |br|
            boolean
      -
      -  Is permission for Subreport set
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **actions** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **schedule** |br|
            boolean
      -
      -  Is permission for Schedule set
      -
   *  -  .. container:: lpad4
   
            **email** |br|
            boolean
      -
      -  Is permission for Email set
      -
   *  -  .. container:: lpad4
   
            **viewReportHistory** |br|
            boolean
      -
      -  Is permission for View Report History set
      -
   *  -  .. container:: lpad4
   
            **del** |br|
            boolean
      -
      -  Is permission for Delete set
      -
   *  -  .. container:: lpad4
   
            **registerForAlerts** |br|
            boolean
      -
      -  Is permission for Register For Alerts set
      -
   *  -  .. container:: lpad4
   
            **print** |br|
            boolean
      -
      -  Is permission for Print set
      -
   *  -  .. container:: lpad4
   
            **unarchiveReportVersions** |br|
            boolean
      -
      -  Is permission for Unarchive Report Versions set
      -
   *  -  .. container:: lpad4
   
            **overwriteExistingReport** |br|
            boolean
      -
      -  Is permission for Overwrite Existing Report set
      -
   *  -  .. container:: lpad4
   
            **subscribe** |br|
            boolean
      -
      -  Is permission for Subscribe set
      -
   *  -  .. container:: lpad4
   
            **exporting** |br|
            boolean
      -
      -  Is permission for Exporting set
      -
   *  -  .. container:: lpad4
   
            **configureAccessRights** |br|
            boolean
      -
      -  Is permission for Configure Access Rights set
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  **tenantSetup** |br|
         object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad2
   
            **actions** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **create** |br|
            boolean
      -
      -  Is permission for Create set
      -
   *  -  .. container:: lpad4
   
            **edit** |br|
            boolean
      -
      -  Is permission for Edit set
      -
   *  -  .. container:: lpad4
   
            **delete** |br|
            boolean
      -
      -  Is permission for Delete set
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **permissions** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **value** |br|
            boolean
      -
      -  Is permission for Permissions set
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  **dashboards** |br|
         object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad2
   
            **canCreateNewDashboard** |br|
            boolean
      -
      -  Is permission for Can Create New Dashboard set
      -
   *  -  .. container:: lpad2
   
            **dashboardCategoriesSubcategories** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **canCreateNewCategory** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad6
   
            **value** |br|
            boolean
      -
      -  Is permission for CanCreateNewCategory set
      -
   *  -  .. container:: lpad6
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad4
   
            **categoryAccessibility** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad6
   
            **categories** |br|
            array of objects
      -
      -  An array of :doc:`Category` objects
      -
   *  -  .. container:: lpad6
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **actions** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **schedule** |br|
            boolean
      -
      -  Is permission for Schedule set
      -
   *  -  .. container:: lpad4
   
            **email** |br|
            boolean
      -
      -  Is permission for Email set
      -
   *  -  .. container:: lpad4
   
            **del** |br|
            boolean
      -
      -  Is permission for Delete set
      -
   *  -  .. container:: lpad4
   
            **subscribe** |br|
            boolean
      -
      -  Is permission for Subscribe set
      -
   *  -  .. container:: lpad4
   
            **print** |br|
            boolean
      -
      -  Is permission for Print set
      -
   *  -  .. container:: lpad4
   
            **overwriteExistingDashboard** |br|
            boolean
      -
      -  Is permission for Overwrite Existing Dashboard set
      -
   *  -  .. container:: lpad4
   
            **configureAccessRights** |br|
            boolean
      -
      -  Is permission for Configure Access Rights set
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  **access** |br|
         object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad2
   
            **accessLimits** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **value** |br|
            array of objects
      -
      -  An array of :doc:`RoleDetail` objects
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **accessDefaults** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **value** |br|
            array of objects
      -
      -  An array of :doc:`UserPermission` objects
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  **scheduling** |br|
         object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad2
   
            **schedulingLimits** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **value** |br|
            array of objects
      -
      -  An array of :doc:`UserPermission` objects
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **schedulingScope** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **systemUsers** |br|
            boolean
      -
      -  Is permission for System Users set
      -
   *  -  .. container:: lpad4
   
            **externalUsers** |br|
            boolean
      -
      -  Is permission for External Users set
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  **emailing** |br|
         object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad2
   
            **deliveryMethod** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **link** |br|
            boolean
      -
      -  Is permission for Link set
      -
   *  -  .. container:: lpad4
   
            **embeddedHTML** |br|
            boolean
      -
      -  Is permission for EmbeddedHTML set
      -
   *  -  .. container:: lpad4
   
            **attachment** |br|
            boolean
      -
      -  Is permission for Attachment set
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **attachmentType** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **word** |br|
            boolean
      -
      -  Is permission for Word set
      -
   *  -  .. container:: lpad4
   
            **excel** |br|
            boolean
      -
      -  Is permission for Excel set
      -
   *  -  .. container:: lpad4
   
            **pdf** |br|
            boolean
      -
      -  Is permission for Pdf set
      -
   *  -  .. container:: lpad4
   
            **csv** |br|
            boolean
      -
      -  Is permission for CSV set
      -
   *  -  .. container:: lpad4
   
            **xml** |br|
            boolean
      -
      -  Is permission for XML set
      -
   *  -  .. container:: lpad4
   
            **json** |br|
            boolean
      -
      -  Is permission for Json set
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  **exporting** |br|
         object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad2
   
            **exportingFormat** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **word** |br|
            boolean
      -
      -  Is permission for Word set
      -
   *  -  .. container:: lpad4
   
            **excel** |br|
            boolean
      -
      -  Is permission for Excel set
      -
   *  -  .. container:: lpad4
   
            **pdf** |br|
            boolean
      -
      -  Is permission for Pdf set
      -
   *  -  .. container:: lpad4
   
            **csv** |br|
            boolean
      -
      -  Is permission for CSV set
      -
   *  -  .. container:: lpad4
   
            **xml** |br|
            boolean
      -
      -  Is permission for XML set
      -
   *  -  .. container:: lpad4
   
            **json** |br|
            boolean
      -
      -  Is permission for Json set
      -
   *  -  .. container:: lpad4
   
            **queryExecution** |br|
            boolean
      -
      -  Is permission for Query Execution set
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  **systemWide** |br|
         object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad2
   
            **canSeeSystemMessages** |br|
            object
      -
      -  An object with the following fields
      -
   *  -  .. container:: lpad4
   
            **value** |br|
            boolean
      -
      -  Is permission for Can See System Messages set
      -
   *  -  .. container:: lpad4
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
   *  -  .. container:: lpad2
   
            **tenantAccess** |br|
            integer
      -
      -  Permission for Tenant
      -
