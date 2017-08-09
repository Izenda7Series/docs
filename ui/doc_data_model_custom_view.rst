:orphan:

==========================
Custom View Setup Guide
==========================

.. tip::

   Custom View is available from release.........

The Custom View allows user to add user-defined views using SQL SELECT query.

In the Custom View, user can limit :term:`data source fields <data source field>`, combine fields from multiple :term:`data sources <data source>` or aggregate data into the result view.

.. container:: toggle

   .. container:: header

      Sample Custom View to pre-pivot data:

   .. code-block:: sql

      SELECT *
      FROM  (
               SELECT customerID,employeeID
               FROM Orders ) o
      PIVOT (
               COUNT(employeeID)
               FOR employeeID IN ([1],[2],[3],[4],[5],[6],[7],[8],[9] ) ) p

   The above query uses SQL Server's native function PIVOT, which is faster to set up than using a Pivot Grid.

Add Custom View
--------------------
#. In browser, log in to Izenda as a user with Custom View permission.
#. Click **Settings**, then **Data Setup** then **Data Model** in the left menu.
#. Select the Setting Level: either System or a specific tenant.
#. Click **Views** in the Middle Panel.
#. Click on **Add Custom View** button to open the **Add Custom View** popup.
#. Input all required information.|br|
   - Input Custom View Name |br|
   - Select one Database Name.  |br|
   - Select one Schema Name |br|
   - Input select statements to optimize the query |br|

   .. warning::
   
      Existing hidden filters are not added to this query. Thus, user must add SQL WHERE conditions to make sure that ? data is filtered by the correct tenant or any other criteria.
   
   (native to the connection like Oracle, mssql, mysql, postgresql, etc) |br|
   
#. Click on **Excute & Save** button.


Edit Custom View
-------------------
#. In browser, log in to Izenda as a user with Data Model permission.
#. Click **Settings**, then **Data Setup** then **Data Model** in the left menu.
#. Select the Setting Level: either System or a specific tenant.
#. Click **Views** in the Middle Panel.
#. Click on the link of existing custom view name to open the **Edit Custom View** popup
#. Modify some fields.
#. Click on **Excute & Save** button.