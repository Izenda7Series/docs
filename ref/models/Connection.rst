

==========================
Connection
==========================

.. list-table::
   :header-rows: 1
   :widths: 25 5 65 5

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **id** |br|
         string (GUID)
      -
      -  The id of the connection
      -
   *  -  **name** |br|
         string
      -
      -  The name of the connection
      -
   *  -  **originalName** |br|
         string
      -
      -  The original name of the connection
      -
   *  -  **serverTypeId** |br|
         string (GUID)
      -
      -  The id of the server type
      -
   *  -  **databaseServer** |br|
         string
      -
      -  The database address
      -
   *  -  **serverTypeName** |br|
         string
      -
      -  The type of the server
      -
   *  -  **connectionString** |br|
         string
      -
      -  The connection string
      -
   *  -  **visible** |br|
         boolean
      -
      -  Whether this is visible in Data Model
      -
   *  -  **deleted** |br|
         boolean
      -
      -  Whether this is deleted
      -
   *  -  **relateToConnectionId** |br|
         string (GUID)
      -  Y
      -  The id of the related connection
      -
   *  -  **tenantId** |br|
         string (GUID)
      -  Y
      -  The id of the tenant if available
      -
   *  -  **dBSource** |br|
         object
      -
      -  A :doc:`DBSource` object
      -
   *  -  **relationships** |br|
         array of objects
      -
      -  An array of :doc:`Relationship` objects
      -
   *  -  **physicalChange** |br|
         integer
      -
      -  The change status
      -
   *  -  **checked** |br|
         boolean
      -
      -  Is selected for copy in Copy Management
      -
   *  -  **databaseName** |br|
         string
      -
      -  The name of the database
      -
