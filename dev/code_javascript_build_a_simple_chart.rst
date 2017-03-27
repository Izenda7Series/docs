=========================================================
Build a simple Chart
=========================================================

Steps:

#. Follow :doc:`code_javascript_build_a_generic_report` until the step to add report parts.
#. Prepare an empty :doc:`/ref/models/ReportPartChart` object with default properties.
#. For each selected data source fields, populate a :doc:`/ref/models/ReportPartElement` object with default properties.
#. Add the :doc:`/ref/models/ReportPartElement` objects into ``columns.elements`` in :doc:`/ref/models/ReportPartChart` object.
#. Update the properties of the grid in ``properties`` field per user selection (See :doc:`/ref/models/ReportPartChartProperties`).
#. Back to the steps in :doc:`code_javascript_build_a_generic_report`.

Prepare an empty ReportPartChart object
----------------------------------------

.. container:: toggle

   .. container:: header

      Empty ReportPartChart object

   |br|

   *  The highlighted ``columns.elements`` is where the selected data source fields will be added
   *  The highlighted ``properties`` contains the default properties

   .. code-block:: json
      :linenos:
      :emphasize-lines: 0



Populate selected data sources fields
---------------------------------------

#.  Refer to the :ref:`similar step in Building a Grid guide <Grid_Populate_selected_data_sources_fields>` to:

   *  Get the list of available data sources fields from :ref:`POST_report/availableQuerySourceFields`
   *  Build a corresponding ReportPartElement object for each selected data source field
   *  Populate a default ReportPartElementProperties for ``properties`` field in each ReportPartElement object

#. Add the :doc:`/ref/models/ReportPartElement` objects into ``columns.elements`` in :doc:`/ref/models/ReportPartChart` object.

   .. _Sample_full_ReportPartChart_object:

   .. container:: toggle

      .. container:: header

         Sample full ReportPartChart object

      .. code-block:: json

         {}

Update the properties of each field per user selection
------------------------------------------------------------------------------

Please see :doc:`/ref/models/ReportPartElementProperties` for the purpose of each field.

Update the properties of the Chart in "properties" field per user selection
------------------------------------------------------------------------------

Please see :doc:`/ref/models/ReportPartChartProperties` for the purpose of each field.

Back to the step in :ref:`Build a Generic Report <Populate_the_report_parts>`
------------------------------------------------------------------------------
