==========================
Setting up Permissions
==========================

.. contents:: Table of Contents
      :depth: 2

|br|

What are Permissions? 
--------------------------------
Permissions are how you grant functionality to users in your instance of Izenda. These include several areas like:
    - Controlling what types of report parts they can create
    - Setting who they can share their reports with
    - Determining if they can access and manipulate their tenant's data model

In a multi-tenant instance you can set permission at both the tenant and role level. In this scenario, the tenant will act like a ceiling for a role's permissions.


Permissions Overview
--------------------------------
A permissions object is comprised of several areas

    .. container:: toggle

        .. container:: header 

                **System Configuration**

        * Scheduled Instances
            * This permission determines if a tenant/role has access to a master search dialogue to audit all scheduled/subscribed instances
                * The search dialogue is located in the Settings > System Configuration > Scheduling tab
            * ADD A PICTURE OF THE DIALOGUE


    .. container:: toggle

        .. container:: header 

                **Data Setup**:

        * Data Model
            * This permission grants access for the tenant/role to edit and interact with the data model
                * Note that this permission is all or nothing. There is no way to limit if they can add relationships or not, alias data sources, etc.
            * Custom Views
                * Create
                    * This permission grants access for the tenant/role to create custom views within their data model
                * Edit
                    * This permission grants access for the tenant/role to edit any existing custom views within their data model
                * Delete
                    * This permission grants access for the tenant/role to delete any existing custom views within their data model
        * Advanced Settings
            * Category
                * This permission grants access to the Data Model > Advanced Settings > Category tab for the tenant/role
                    * This tab is used to create, edit, or delete any data source categories used in the data model
            * Others
                * This permission grants access to the Data Model > Advanced Settings > Others tab for the tenant/role
                    * This tab is used to set various behavior for the tenant such as sorting column names, determining common filter criteria for dashboards, etc.


    .. container:: toggle

        .. container:: header 

                **User Setup**:

        * Actions
            * Create
                * This permission grants access for the tenant/role to create new users
                    * NOTE: Users cannot be added through the UI in an integrated instance
            * Edit 
                * This permission grants access for the tenant/role to edit existing users
            * Delete
                * This permission grants access for the tenant/role to delete existing users
                    * NOTE: Users cannot be deleted through the UI in an integrated instance
            * Configure Password Option
                * This permission grants acces for the tenant/role to set up/reset passwords for new and existing users
        * User Role Association

    .. container:: toggle

        .. container:: header 

                **Role Setup**:

        * Actions
            * Create 
                * This permission grants access for the tenant/role to create new roles
            * Edit
                * This permission grants access for the tenant/role to edit existing roles
            * Delete 
                * This permission grants access for the tenant/role to delete existing roles
        * Data Model Access
            * This permission grants the tenant/role the ability to interact with a role's data model access on the Role Setup page
        * Permissions
            * This permission grants the tenant/role the ability to interact with a role's permission set on the Role Setup page
        * Grant Role with Full Report and Dashboard Access
            * This permission grants the tenant/role the ability to set the 'Full Report and Dashboard Access' permission in the Permission tab of the Role Setup page

    .. container:: toggle

        .. container:: header 

                **Reports**:

        * Can create new report?
            * This permission allows a tenant/role to create new reports
        * Data Sources
            * Simple Data Sources
                * This setting will prevent a user from seeing and editing joins on the Data Sources tab of the report designer
                    * NOTE: Roles with Simple Data Sources can only choose datasources with relationships between them that are defined in the data model. If a relationship does not exist between these data sources, they cannot choose those to build a report off of. 
                * This setting will also collapse the right-hand properties panel in the designer tab 
            * Advanced Data Sources
                * This setting will allow a user to edit and create joins in the Data Sources tab of the report designer
                * This setting will auto-expand the right-hand properties panel in the designer tab
        * Report Part Types 
            * Chart
            * Form
            * Gauge
            * Maps
        * Report Categories/Subcategories
            * Can Create New Category?
        * Filter Properties
            * Filter Logic 
            * Cross Filtering
        * Field Properties
            * Custom URL
            * Embedded Javascript
            * Subreport
        *Actions
            * Schedule
            * Register to Alerts
            * Subscribe
            * Configure Access Rights
            * Email
            * Print
            * Exporting
            * View Report History
            * Unarchive Report Version
            * Delete
            * Overwrite Existing Report


    .. container:: toggle

        .. container:: header 

                **Dashboards**:

        * Can create new dashboard?
        * Dashboard Categories/Subcategories
            * Can create new category?
        *Actions    
            * Schedule
            * Subscribe
            * Configure Access Rights
            * Email
            * Print
            * Export
            * Delete
            * Overwrite Existing Report

    .. container:: toggle

        .. container:: header 

                **Access**:

        * Access Limits
            * Roles/Users allowed to share with
        * Access Defaults
            *


    .. container:: toggle

        .. container:: header 

                **Scheduling**:

        * Scheduling Limits
            * Roles/Users allowed to share with
        * Scheduling Scope
            * System Users
            * External Users


    .. container:: toggle

        .. container:: header 

                **Emailing**:

        * Delivery Method
            * Link
            * Embedded HTML
            * Attachment
        * Attachment Type 
            * Word
            * Excel
            * PDF
            * CSV
            * XML
            * JSON


    .. container:: toggle

        .. container:: header 

                **Exporting**:  

        * Exporting Format
            * Word
            * Excel
            * PDF
            * CSV
            * XML
            * JSON
            * Query Execution
          

    .. container:: toggle

        .. container:: header 

                **System-wide**:

        * Can see system messages?



----------------------------------------------------------------


Additional Reference
--------------------------------