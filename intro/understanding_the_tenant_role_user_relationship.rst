================================================
Understanding The Tenant-Role-User Relationship
================================================

-------------------------
Tenants, Roles, and Users
-------------------------

Within Izenda, users fit into categories that define their relationships
with other users. Izenda utilizes these relationships to define access
rights of features, data, reports, and dashboards. 

.. figure:: /_static/images/Tenant-role-user6.jpg

   Tenant-Role-User Relationship

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
- A user can belong to more than one role

For more on User Setup, please see the :doc:`/ui/doc_user_setup`.


Roles
-----

A role is a classification within a tenant and are used to define
natural distinctions between users. For instance, your company man have
an IT Department that is interested in bug reports and a Sales
Department that is interested in quarterly sales. Roles will allow you
to filter the data available for each role so that they only see
relevant information.
- Roles can overlap each other but roles cannot be subsets of each other (See the Law of Least Restriction below)


For more on Role Setup, please see the :doc:`/ui/doc_role_setup`.

Tenants
-------

Tenants are the largest user classification available. A tenant is
generally used to define one definite entity with a broad access to
features, data, reports, and dashboards.
- Users and roles can only belong to 1 tenant

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


--------------------
The Nature of Izenda
--------------------

Izenda abides by a few simple rules to ensure that resources are properly secure. A resource could be a data source, access right, or report. We will use the following example to display these laws. In this example, we have a tenant with access to resources {A, B, C, D, E}. We have three roles: Role 1 with access to {A,B,C}; Role 2 with accecss to {A,C,D}; Role 3 with access to {A,E}. Finally, we have a User X that we would like to grant access to to certain resources. 


.. figure:: /_static/images/resource_mapping_example.png

   Resource Mapping Example

The Law of Filtered Resources
-----------------------------
- Resources provided to a user is filtered from the broadest indentity to the narrowest. Therefore, when the identity of a user is established, a tenant is created, a role is created, and, finally, a user is created.
   -  Suppose we want User X to have access to Resource A. User X could have either Role 1, Role 2, or Role 3.
   -  Suppose we want User X to have access to Resource E. User x must have Role 3.
   -  Suppose we want User X to have access to Resource F. Since we are only aware of one tenant and that tenant does not have access to Resource F, User X cannot have access to Resource F.


The Law of Least Restriction
----------------------------
- The access for a user is the union of all of it's identities' access. For reports/dashboards, the access for a user is the union of all of it's identities' report/dashboard and all access rights explicitly defined in a report/dashboard.
   -  Users can only belong to one tenant and, therefore, roles defined in a tenant contain subsets of resource access of the tenant. Since users can have multiple roles, the role identity of a user is the union of all it's roles. Therefore, if a user belongs to one role that does not allow access to a resource but it also belongs to a role that does allow access to a resource, the user will have access to the resource.
   - Suppose we want User X to have access to Resources {A, B, C, D, E}. User X must have Role 1, Role 2, Role 3.
   - Suppose we want User X to have access to Resources {A, C, D, E}. User X must have Role 2 and Role 3.
- The Law of Least Restriction makes it impossible to define a user's access to a resource by the instersection of roles with only the use of roles.
   - Suppose we want User X to have access to Resources {A, C, E} but we do not want it to have access to Resources {B, D}. With the roles provided, it is impossible to restrict access with roles alone.
- The Law of Least Restriction makes it impossible to define roles within roles (subsets) with only the use of roles
 

