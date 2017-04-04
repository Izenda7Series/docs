=========================================================
Build a simple Form
=========================================================

Steps:

#. Follow :doc:`code_javascript_build_a_generic_report` until the step to add report parts.
#. Prepare an empty :doc:`/ref/models/ReportPartForm` object with default properties.
#. For each selected data source fields, populate a :doc:`/ref/models/ReportPartElement` object with default properties.
#. Add the :doc:`/ref/models/ReportPartElement` objects into either ``pointOptions.elements``, ``shadingMetric.elements`` or ``bubbleMetrics.elements`` in :doc:`/ref/models/ReportPartForm` object.
#. Update the properties of the map in ``properties`` field per user selection (See :doc:`/ref/models/ReportPartFormProperties`).
#. Back to the steps in :doc:`code_javascript_build_a_generic_report`.

Prepare an empty ReportPartForm object
----------------------------------------

.. container:: toggle

   .. container:: header

      Empty ReportPartForm object

   |br|

   *  The highlighted ``properties`` contains the default properties

   .. code-block:: json
      :linenos:
      :emphasize-lines: 0

      {}

Populate selected data sources fields
---------------------------------------

#. Refer to the :ref:`similar step in Building a Grid guide <Grid_Populate_selected_data_sources_fields>` to:

   #. Get the list of available data sources fields from :ref:`POST_report/availableQuerySourceFields`
   #. Build a corresponding ReportPartElement object for each selected data source field
   #. Populate a default ReportPartElementProperties for ``properties`` field in each ReportPartElement object

   See :doc:`code_javascript_sample_properties_for_a_reportpartelement` for some samples.

#. Add the :doc:`/ref/models/ReportPartElement` objects into ``columns.elements`` in :doc:`/ref/models/ReportPartForm` object.
#. Build the HTML to display selected data source fields in ``htmlContent``. |br|
   The quotes must be escaped since the code will be put inside a string in json, e.g. ``"htmlContent": "<div><field class=\"field-wrapper\" ..."``

   .. code-block:: html

      <div>Order #
          <field class=\"field-wrapper\" field-name=\"[Northwind].[dbo].[Orders].[OrderID]\">
              <field-prop key=\"subTotalFieldDataType\" value=\"Numeric\"></field-prop>
              <field-prop key=\"grandTotalFieldDataType\" value=\"Numeric\"></field-prop>
              <field-prop key=\"fieldId\" value=\"07ed1f4c-f30d-4759-bfc5-0e4636d446cd\"></field-prop>
              <field-prop key=\"dataFieldType\" value=\"Numeric\"></field-prop>
              <field-prop key=\"querySourceId\" value=\"f4ae63fc-4c10-4672-9cd2-4a9d40434a4c\"></field-prop>OrderID<span class=\"icon-cancel\"></span>
          </field> for Customer#
          <field class=\"field-wrapper\" field-name=\"[Northwind].[dbo].[Orders].[CustomerID]\">
              <field-prop key=\"fieldId\" value=\"ab4e3871-76ba-4604-8a8d-97fbfbca7144\"></field-prop>
              <field-prop key=\"querySourceId\" value=\"f4ae63fc-4c10-4672-9cd2-4a9d40434a4c\"></field-prop>
              <field-prop key=\"dataFieldType\" value=\"Text\"></field-prop>CustomerID<span class=\"icon-cancel\"></span>
          </field> by Employee#&nbsp;
          <field class=\"field-wrapper\" field-name=\"[Northwind].[dbo].[Orders].[EmployeeID]\">
              <field-prop key=\"fieldId\" value=\"2bc3a102-6621-4713-a167-3579b664dd3e\"></field-prop>
              <field-prop key=\"querySourceId\" value=\"f4ae63fc-4c10-4672-9cd2-4a9d40434a4c\"></field-prop>
              <field-prop key=\"dataFieldType\" value=\"Numeric\"></field-prop>EmployeeID<span class=\"icon-cancel\"></span>
          </field>
      </div>

.. _Sample_full_ReportPartForm_object:

.. container:: toggle

   .. container:: header

      Sample full ReportPartForm object

   *  

   |br|

   .. code-block:: json
      :linenos:
      :emphasize-lines: 0

      {}

Update the properties of each field per user selection
------------------------------------------------------------------------------

Please see :doc:`/ref/models/ReportPartElementProperties` for the purpose of each field.

See :doc:`code_javascript_sample_properties_for_a_reportpartelement` for more samples.

Update the properties of the Map in "properties" field per user selection
------------------------------------------------------------------------------

Please see :doc:`/ref/models/ReportPartMapProperties` for the purpose of each field.

Back to the Save step in :ref:`Build a Generic Report <Populate_the_report_parts>`
----------------------------------------------------------------------------------------

.. container:: toggle

   .. container:: header

      Sample full ReportSavingParameter object for Save report API

   .. code-block:: json

      {}
