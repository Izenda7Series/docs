================================================
Understanding The Tenant-Role-User Relationship
================================================

Tenants, Roles, and Users
-------------------------

Within Izenda, users fit into categories that define their relationships
with other users. Izenda utilizes these relationships to define access
rights of features, data, reports, and dashboards.

.. figure:: /_static/images/Tenant-role-user6.jpg

   Tenant-Role-User Relationship

Tenants
-------

Tenants are the largest user classification available. A tenant is
generally used to define one definite entity with a broad access to
features, data, reports, and dashboards.

System Modes
~~~~~~~~~~~~

-  Izenda is built to support two main system configuration modes:

   -  Single Tenant: Single tenant allows you to set up Izenda for a
      single client scenario.
   -  Multi-Tenant: Multi-Tenant provides an easy management of multiple
      clients on the same instance of Izenda.

      -  If you use multi-tenant mode, you can choose to allow
         duplicated User IDs where an ID can be used in multiple
         tenants.

For more on Multi-Tenant Setup, please see the :doc:`/ui/doc_tenant_setup`.

Roles
-----

A role is a classification within a tenant and are used to define
natural distinctions between users. For instance, your company man have
an IT Department that is interested in bug reports and a Sales
Department that is interested in quarterly sales. Roles will allow you
to filter the data available for each role so that they only see
relevant information.

For more on Role Setup, please see the :doc:`/ui/doc_role_setup`.

Users
-----

A user is the elemental classification of an entity within Izenda.

-  Users have a user name and token to grant access to various parts of
   Izenda
-  A user does not have to have a defined tenant or a defined role

   -  A user either has a tenant/role or the user is a System
      Administrator. Within your User Setup, you will able to toggle a
      user to be an Administrator.
   -  System Administrators can impersonate tenant views to navigate the
      platform with a tenant's access.

For more on User Setup, please see the :doc:`/ui/doc_user_setup`.
