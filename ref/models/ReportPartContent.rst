

=========================================
ReportPartContent
=========================================

.. list-table::
   :header-rows: 1
   :widths: 25 5 65 5

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **type** |br|
         integer
      -
      -  The type of the report part

         -  0 = Chart
         -  1 = Form
         -  2 = Gauge
         -  3 = Grid
         -  4 = Map
      -
   *  -  **properties** |br|
         object
      -
      -  A dynamic object to keep the properties in Report Part Properties box, can be user-defined
      -
   *  -  **settings** |br|
         object
      -
      -  A dynamic object to keep the properties in Report Part Configuration, can be user-defined
      -
   *  -  **title** |br|
         object
      -
      -  A :doc:`ContentContainer` object
      -
   *  -  **description** |br|
         object
      -
      -  A :doc:`ContentContainer` object
      -
   *  -  **expandedLevel** |br|
         integer
      -
      -  The expand level of the report part
      -
