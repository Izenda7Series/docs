

=================
ValueTreeNode
=================

.. list-table::
   :header-rows: 1
   :widths: 25 5 65 5

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **nodes** |br|
         array of objects
      -
      -  An array of child ValueTreeNode objects.
      -
   *  -  **text** |br|
         string
      -
      -  The display text of the object
      -
   *  -  **value** |br|
         string
      -
      -  The value of the object
      -

.. container:: toggle

   .. container:: header

      **Sample**:

   .. code-block:: json

      {
        "nodes" : [{
              "nodes" : [],
              "text" : "[Blank]",
              "value" : "[Blank]"
           }, {
              "nodes" : [],
              "text" : "Finland",
              "value" : "Finland"
           }, {
              "nodes" : [],
              "text" : "USA",
              "value" : "USA"
           }
        ],
        "text" : "[All]",
        "value" : "[All]"
      }
