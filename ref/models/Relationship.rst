=============
Relationship
=============


.. list-table::
   :header-rows: 1
   :widths: 25 5 65 5

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **joinConnectionId** |br|
         string (GUID)
      -  Y
      -  The id of the connection containing the relationship
      -
   *  -  **foreignConnectionId** |br|
         string (GUID)
      -  Y
      -  The id of the connection of the query source referenced by the relationship
      -
   *  -  **joinQuerySourceAlias** |br|
         string
      -
      -  The alias of the query source containing the relationship
      -
   *  -  **foreignQuerySourceAlias** |br|
         string
      -
      -  The alias of the query source referenced by the relationship
      -
   *  -  **joinFieldAlias** |br|
         string
      -
      -  The alias of the join field
      -
   *  -  **specifictJoinFieldAlias** |br|
         string
      -
      -  The alias to be used in query without generating a new one
      -
   *  -  **foreignFieldAlias** |br|
         string
      -
      -  The alias of the foreign field
      -
   *  -  **specifictForeignFieldAlias** |br|
         string
      -
      -  The alias to be used in query without generating a new one
      -
   *  -  **alias** |br|
         string
      -
      -  The alias of the join query soure in relationship
      -
   *  -  **alias** |br|
         boolean
      -
      -  Is this relationship from physical database (cannot be deleted)
      -
   *  -  **joinType** |br|
         string
      -
      -  Either 'Inner', 'Left', 'Right', 'Full' or 'Cross'
      -
   *  -  **parentRelationshipId** |br|
         string (GUID)
      -  Y
      -  The id of the parent relationship - in case this is cloned from a physical relationship
      -
   *  -  **position** |br|
         string
      -
      -  Place-holder
      -
   *  -  **relationshipPosition** |br|
         integer
      -
      -  The ordinal position of this relationship inside a list of relationships
      -
   *  -  **relationshipKeyJoins** |br|
         array of objects
      -  Y
      -  An array of :doc:`RelationshipKeyJoin` objects
      -
   *  -  **reportId** |br|
         string (GUID)
      -  Y
      -  The id of the parent report, in case this is a relationship in a report
      -
   *  -  **tempId** |br|
         string
      -
      -  The temporary id
      -
   *  -  **aliasTempId** |br|
         string
      -
      -  Place-holder
      -
   *  -  **originalId** |br|
         string (GUID)
      -
      -  The original id of the relationship - in case this is cloned from a physical relationship
      -
   *  -  **selectedForeignAlias** |br|
         string
      -
      -  ``<foreignQuerySourceId>_[<foreignAlias>|<foreignQuerySourceName>]``
      -


Inherited fields:

.. include:: RelationshipBase.rst
