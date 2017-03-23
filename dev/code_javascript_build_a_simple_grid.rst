=========================================================
Build a simple Grid
=========================================================

Steps:

#. Follow :doc:`code_javascript_build_a_generic_report` until the step to add report parts.
#. Prepare an empty :doc:`/ref/models/ReportPartGrid` object.
#. For each selected data source fields, populate a :doc:`/ref/models/ReportPartElement` object.
#. Add the :doc:`/ref/models/ReportPartElement` objects into ``columns.elements`` in :doc:`/ref/models/ReportPartGrid` object.
#. Update the default properties of the grid in ``properties`` field (See :doc:`/ref/models/ReportPartGridProperties`).
#. Back to the steps in :doc:`code_javascript_build_a_generic_report`.

Prepare an empty ReportPartGrid object
----------------------------------------

.. container:: toggle

   .. container:: header

      Empty ReportPartGrid object

   |br|

   *  The highlighted ``columns.elements`` is where the selected data source fields will be added
   *  The highlighted ``properties`` is where the properties will be updated

   .. code-block:: json
      :linenos:
      :emphasize-lines: 4,19

      {
         "type": 3,
         "columns": {
            "elements": [],
            "name": "columns"
         },
         "rows": {
            "elements": [],
            "name": "rows"
         },
         "values": {
            "elements": [],
            "name": "values"
         },
         "separators": {
            "elements": [],
            "name": "separators"
         },
         "properties": {},
         "settings": {},
         "title": {},
         "description": {}
      }

Populate selected data sources fields
---------------------------------------

#. Get the list of available data sources fields from :ref:`POST_report/availableQuerySourceFields` with this payload:

   .. code-block:: json

      {
         "reportKey": {
            "key": "<the id of the report>"
         }
      }

   The response is an array containing exactly one :doc:`/ref/models/ReportDataSourceCategory` object, with ``querySource`` field containing an array of selected data sources (:doc:`/ref/models/ReportQuerySource` objects), with ``fields`` field containing an array of available data source fields. For example:

   .. code-block:: json

      [
         {
            "id": null,
            "name": "Selected Data Source",
            "querySource": [
               {
                  "id": "af773c7b-878e-461b-9345-27ee6592db1a",
                  "name": "Orders",
                  "originalName": "Orders",
                  "type": "Table",
                  "selected": true,
                  "visible": true,
                  "querySourceCategoryName": "dbo",
                  "connectionName": "test",
                  "isAlias": false,
                  "isDynamic": false,
                  "fields": [
                     {
                        "name": "CustomerID",
                        "remaining items": "have been omitted"
                     },
                     {
                        "name": "OrderID",
                        "remaining items": "have been omitted"
                     }
                  ]
               }
            ]
         }
      ]

#. For each selected data source field (:doc:`/ref/models/QuerySourceField` object), build a corresponding :doc:`/ref/models/ReportPartElement` object

   .. code-block:: json

      {
         "name": "<User-defined Field Name Alias of the selected QuerySourceField>",
         "properties": {},
         "position": "<position in the list of selected fields>",
         "field": {
            "fieldId": "<id of the selected QuerySourceField>",
            "fieldName": "<name of the selected QuerySourceField>",
            "fieldNameAlias": "User-defined Field Name Alias of the selected QuerySourceField",
            "dataFieldType": "<Izenda data type of the selected QuerySourceField>",
            "querySourceId": "<id of the parent QuerySource>",
            "querySourceType": "<Table, View or Stored Procedure>",
            "sourceAlias": "",
            "relationshipId": null,
            "visible": true,
            "calculatedTree": null,
            "schemaName": "dbo",
            "querySourceName": "<name of the parent QuerySource>",
            "databaseName": "test",
            "isCalculated": false,
            "hasAggregatedFunction": false
         }
      }

   .. list-table::
      :header-rows: 1

      * - :download:`Sample QuerySourceField <included_samples/QuerySourceField_OrderID.json>`
        - :download:`Sample ReportPartElement  <included_samples/ReportPartElement_OrderID.json>`
      * - .. literalinclude:: included_samples/QuerySourceField_OrderID.json
             :lines: 1-2
        - .. literalinclude:: included_samples/ReportPartElement_OrderID.json
              :lines: 1-2
      * -
        - .. literalinclude:: included_samples/ReportPartElement_OrderID.json
              :lines: 3
      * - .. literalinclude:: included_samples/QuerySourceField_OrderID.json
             :lines: 37
        - .. literalinclude:: included_samples/ReportPartElement_OrderID.json
              :lines: 5
      * - .. literalinclude:: included_samples/QuerySourceField_OrderID.json
             :lines: 2
        - .. literalinclude:: included_samples/ReportPartElement_OrderID.json
              :lines: 6
      * - User entered "OID"
        - .. literalinclude:: included_samples/ReportPartElement_OrderID.json
              :lines: 7
      * - .. literalinclude:: included_samples/QuerySourceField_OrderID.json
             :lines: 5
        - .. literalinclude:: included_samples/ReportPartElement_OrderID.json
              :lines: 8
      * - .. literalinclude:: included_samples/QuerySourceField_OrderID.json
             :lines: 9
        - .. literalinclude:: included_samples/ReportPartElement_OrderID.json
              :lines: 9
      * - .. literalinclude:: included_samples/QuerySourceField_OrderID.json
             :lines: 13
        - .. literalinclude:: included_samples/ReportPartElement_OrderID.json
              :lines: 10
