=========================================================
Build a Generic Report
=========================================================

#. Prepare an empty :doc:`/ref/models/ReportDefinition` object.
#. Populate report name and categories.
#. Populate selected data sources.
#. Call :ref:`Save report as draft <POST_report/draft>` API, then receive back the :doc:`/ref/models/ReportSavingResult` object. |br|
   (Prepare a :doc:`/ref/models/ReportSavingParameter` object as input for that API)
#. Extract the ``report`` field from the :doc:`/ref/models/ReportSavingResult` object. This is a :doc:`/ref/models/ReportDefinition` object which has been assigned a report id.
#. Populate the report parts:

   *  :doc:`code_javascript_build_a_simple_grid`
   *  To be updated for Chart, Gauge, Map and Form |br|

#. Call :ref:`Save report <POST_report>` API. |br|
   (Prepare a :doc:`/ref/models/ReportSavingParameter` object as input for that API)

Prepare an Empty Report Object
------------------------------

.. container:: toggle

   .. container:: header

      Empty ReportDefinition object:

   |br|
   
   *  The highlighted ``name``  is where the report name will be inserted
   *  The highlighted ``categoryId``, ``category``, ``subCategoryId`` and ``subCategory``  is where the categories and sub-categories will be updated
   *  The highlighted ``reportDataSource``  is where the selected data source will be added

   .. code-block:: json
      :linenos:
      :emphasize-lines: 2,8-21,22

      {
         "name": "",
         "type": 0,
         "previewRecord": 10,
         "advancedMode": true,
         "allowNulls": false,
         "isDistinct": false,
         "categoryId": null,
         "category": {
            "id": null,
            "name": "",
            "type": 0,
            "tenantId": null
         },
         "subCategory": {
            "id": null,
            "name": "",
            "type": 0,
            "tenantId": null
         },
         "subCategoryId": null,
         "reportDataSource": [],
         "reportRelationship": [],
         "reportFilter": {
            "logic": "",
            "visible": true,
            "filterFields": [],
            "id": null,
            "reportId": null
         },
         "reportPart": [],
         "header": null,
         "footer": null,
         "titleDescription": null,
         "version": 0,
         "schedules": [],
         "ownerId": "",
         "accesses": [],
         "exportFormatSetting": null,
         "createdById": null,
         "dynamicQuerySourceFields": [],
         "snapToGrid": false,
         "excludedRelationships": null
      }

Populate Report Name and Categories
------------------------------------

Populate the fields:

*  ``name`` with the actual report name
*  ``category`` and ``subCategory`` with the actual categories |br|
   Get the list of categories from :ref:`GET_report/allCategories/{type}/(tenant_id)`


.. container:: toggle

   .. container:: header

      Sample populated ReportDefinition object:

   .. code-block:: json
      :emphasize-lines: 2,8-14
      :linenos:

      {
         "name": "Example Report Name",
         "type": 0,
         "previewRecord": 10,
         "advancedMode": true,
         "allowNulls": false,
         "isDistinct": false,
         "categoryId": "0ecf1821-dc37-43dd-8b4c-654961b37038",
         "category": {
            "id": "0ecf1821-dc37-43dd-8b4c-654961b37038",
            "name": "TestCategory",
            "type": 0,
            "tenantId": null
         },
         "subCategory": {
            "id": null,
            "name": "",
            "type": 0,
            "tenantId": null
         },
         "subCategoryId": null,
         "reportDataSource": [],
         "reportRelationship": [],
         "reportFilter": {
            "logic": "",
            "visible": true,
            "filterFields": [],
            "id": null,
            "reportId": null
         },
         "reportPart": [],
         "header": null,
         "footer": null,
         "titleDescription": null,
         "version": 0,
         "schedules": [],
         "ownerId": "",
         "accesses": [],
         "exportFormatSetting": null,
         "createdById": null,
         "dynamicQuerySourceFields": [],
         "snapToGrid": false,
         "excludedRelationships": null
      }

Populate selected data sources
------------------------------

#. Get the list of available data sources grouped by data source categories from :ref:`POST_report/loadDataSourceCategory` with this payload:

   .. code-block:: json

      {
         "tenantId": null,
         "reportKey": {
            "key": null
         }
      }

#. For each selected data source (:doc:`/ref/models/ReportQuerySource` object), build a corresponding :doc:`/ref/models/ReportDataSource` object

   .. code-block:: json

      {
         "querySourceId": "<id of the selected ReportQuerySource>",
         "querySourceName": "<name of the selected ReportQuerySource>",
         "aliasId": "<querySourceId>_<querySourceName>",
         "selected": true,
         "categoryId": "00000000-0000-0000-0000-000000000000",
         "primaryFields": ["<populated by an array of only primary key fields>"]
      }

   .. list-table::
      :header-rows: 1

      * - :download:`Sample ReportQuerySource <included_samples/ReportQuerySource_Orders.json>`
        - :download:`Sample ReportDataSource  <included_samples/ReportDataSource_Orders.json>`
      * - .. literalinclude:: included_samples/ReportQuerySource_Orders.json
             :lines: 1-3
        - .. literalinclude:: included_samples/ReportDataSource_Orders.json
              :lines: 1-4
      * - .. literalinclude:: included_samples/ReportQuerySource_Orders.json
             :lines: 6
        - .. literalinclude:: included_samples/ReportDataSource_Orders.json
              :lines: 5
      * -
        - .. literalinclude:: included_samples/ReportDataSource_Orders.json
              :lines: 6
      * - .. literalinclude:: included_samples/ReportQuerySource_Orders.json
             :lines: 12
        - .. literalinclude:: included_samples/ReportDataSource_Orders.json
              :lines: 7
      * - .. literalinclude:: included_samples/ReportQuerySource_Orders.json
             :lines: 197-242
        - .. literalinclude:: included_samples/ReportDataSource_Orders.json
              :lines: 8-53
      * - .. literalinclude:: included_samples/ReportQuerySource_Orders.json
             :lines: 657-
        - .. literalinclude:: included_samples/ReportDataSource_Orders.json
              :lines: 54-

#. Populate the field ``reportDataSource`` with the array of :doc:`/ref/models/ReportDataSource` objects. 

   .. container:: toggle

      .. container:: header

          Populated ReportDefinition object:

      .. code-block:: json
         :linenos:
         :emphasize-lines: 22-78

         {
            "name": "Example Report Name",
            "type": 0,
            "previewRecord": 10,
            "advancedMode": true,
            "allowNulls": false,
            "isDistinct": false,
            "categoryId": "0ecf1821-dc37-43dd-8b4c-654961b37038",
            "category": {
               "id": "0ecf1821-dc37-43dd-8b4c-654961b37038",
               "name": "TestCategory",
               "type": 0,
               "tenantId": null
            },
            "subCategory": {
               "id": null,
               "name": "",
               "type": 0,
               "tenantId": null
            },
            "subCategoryId": null,
            "reportDataSource": [
               {
                  "querySourceId": "af773c7b-878e-461b-9345-27ee6592db1a",
                  "querySourceName": "Orders",
                  "aliasId": "af773c7b-878e-461b-9345-27ee6592db1a_Orders",
                  "selected": true,
                  "categoryId": "00000000-0000-0000-0000-000000000000",
                  "primaryFields": [
                     {
                        "name": "OrderID",
                        "alias": "",
                        "dataType": "int",
                        "izendaDataType": "Numeric",
                        "allowDistinct": false,
                        "visible": true,
                        "filterable": true,
                        "querySourceId": "00000000-0000-0000-0000-000000000000",
                        "parentId": null,
                        "expressionFields": [],
                        "filteredValue": "",
                        "type": 0,
                        "groupPosition": 0,
                        "position": 0,
                        "extendedProperties": "{\"PrimaryKey\":true}",
                        "physicalChange": 0,
                        "approval": 0,
                        "existed": false,
                        "matchedTenant": false,
                        "functionName": null,
                        "expression": null,
                        "fullName": null,
                        "calculatedTree": null,
                        "reportId": null,
                        "originalName": "OrderID",
                        "originalId": "00000000-0000-0000-0000-000000000000",
                        "isParameter": false,
                        "isCalculated": false,
                        "hasAggregatedFunction": false,
                        "querySource": null,
                        "querySourceName": null,
                        "categoryName": null,
                        "inaccessible": false,
                        "originalAlias": null,
                        "fullPath": null,
                        "id": "b648344c-526e-4984-bfc3-7be462b800fe",
                        "state": 0,
                        "deleted": false,
                        "inserted": true,
                        "version": null,
                        "created": null,
                        "createdBy": null,
                        "modified": "0001-01-01T00:00:00.0000000+07:00",
                        "modifiedBy": null
                     }
                  ]
               }
            ],
            "reportRelationship": [],
            "reportFilter": {
               "logic": "",
               "visible": true,
               "filterFields": [],
               "id": null,
               "reportId": null
            },
            "reportPart": [],
            "header": null,
            "footer": null,
            "titleDescription": null,
            "version": 0,
            "schedules": [],
            "ownerId": "",
            "accesses": [],
            "exportFormatSetting": null,
            "createdById": null,
            "dynamicQuerySourceFields": [],
            "snapToGrid": false,
            "excludedRelationships": null
         }

Call Save report as draft API
------------------------------

#. Prepare the :doc:`/ref/models/ReportSavingParameter` object

   .. container:: toggle

      .. container:: header

         Sample object:

      |br|
      
      The highlighted ``report``  is where the ReportDefinition object will be inserted

      .. code-block:: json
         :linenos:
         :emphasize-lines: 10

         {
            "reportKey": {
               "key": null,
               "modified": null,
               "tenantId": null
            },
            "section": 0,
            "saveAs": false,
            "ignoreCheckChange": false,
            "report": {},
            "expandedLevel": 0
         }

#. Populate the ReportSavingParameter object with the ReportDefinition then call the :ref:`Save report as draft <POST_report/draft>` API
#. Receive back the :doc:`/ref/models/ReportSavingResult` object

   .. container:: toggle

      .. container:: header

         Sample object

      |br|
      ReportSavingResult object with the **success** field true and report id assigned and **report** field populated:

      .. code-block:: json
         :linenos:
         :emphasize-lines: 3,185

         {
           "reportKey": {
             "key": "90ab0d69-be94-4fb0-965f-b398c7af2ba6",
             "tenantId": null
           },
           "report": {
             "inaccessible": false,
             "category": {
               "name": "TestCategory",
               "type": 0,
               "parentId": null,
               "tenantId": null,
               "canDelete": false,
               "editable": false,
               "savable": false,
               "subCategories": [],
               "checked": false,
               "reports": null,
               "dashboards": null,
               "id": "0ecf1821-dc37-43dd-8b4c-654961b37038",
               "state": 0,
               "deleted": false,
               "inserted": true,
               "version": null,
               "created": null,
               "createdBy": "John Doe",
               "modified": null,
               "modifiedBy": null
             },
             "subCategory": {
               "name": "",
               "type": 0,
               "parentId": null,
               "tenantId": null,
               "canDelete": false,
               "editable": false,
               "savable": false,
               "subCategories": [],
               "checked": false,
               "reports": null,
               "dashboards": null,
               "id": null,
               "state": 0,
               "deleted": false,
               "inserted": true,
               "version": null,
               "created": null,
               "createdBy": "John Doe",
               "modified": null,
               "modifiedBy": null
             },
             "reportRelationship": [],
             "reportPart": [],
             "reportFilter": {
               "filterFields": [],
               "logic": "",
               "visible": true,
               "reportId": "90ab0d69-be94-4fb0-965f-b398c7af2ba6",
               "id": "bc13be15-de1d-4931-af5b-ba30617eded3",
               "state": 0,
               "deleted": false,
               "inserted": true,
               "version": null,
               "created": null,
               "createdBy": "John Doe",
               "modified": null,
               "modifiedBy": null
             },
             "calculatedFields": [],
             "accesses": [],
             "schedules": [],
             "dynamicQuerySourceFields": [],
             "name": "Example Report Name",
             "reportDataSource": [
               {
                 "reportId": "90ab0d69-be94-4fb0-965f-b398c7af2ba6",
                 "querySourceId": "af773c7b-878e-461b-9345-27ee6592db1a",
                 "querySourceCategoryId": null,
                 "connectionId": null,
                 "selected": true,
                 "id": "c49cf4b8-10ad-44d4-a467-ced932b08739",
                 "state": 1,
                 "deleted": false,
                 "inserted": false,
                 "version": null,
                 "created": null,
                 "createdBy": "John Doe",
                 "modified": null,
                 "modifiedBy": null
               }
             ],
             "type": 0,
             "previewRecord": 10,
             "advancedMode": true,
             "allowNulls": false,
             "isDistinct": false,
             "categoryId": "0ecf1821-dc37-43dd-8b4c-654961b37038",
             "categoryName": null,
             "subCategoryId": null,
             "subCategoryName": null,
             "tenantId": null,
             "tenantName": null,
             "description": null,
             "title": null,
             "lastViewed": null,
             "owner": "John Doe",
             "ownerId": "9fc0f5c2-decf-4d65-9344-c59a1704ea0c",
             "excludedRelationships": null,
             "numberOfView": 0,
             "renderingTime": 0,
             "createdById": "9fc0f5c2-decf-4d65-9344-c59a1704ea0c",
             "modifiedById": "9fc0f5c2-decf-4d65-9344-c59a1704ea0c",
             "snapToGrid": false,
             "usingFields": null,
             "hasDeletedObjects": false,
             "header": null,
             "footer": null,
             "titleDescription": null,
             "sourceId": null,
             "checked": false,
             "copyDashboard": false,
             "exportFormatSetting": {
               "orientation": 0,
               "margins": 0,
               "centerOnPage": {
                 "horizontally": false,
                 "vertically": false
               },
               "pageBreakAfterReportPart": false,
               "marginSettings": [
                 {
                   "type": 0,
                   "topValue": 0.75,
                   "bottomValue": 0.75,
                   "leftValue": 0.7,
                   "rightValue": 0.7,
                   "headerValue": 0.3,
                   "footerValue": 0.3
                 },
                 {
                   "type": 1,
                   "topValue": 0.75,
                   "bottomValue": 0.75,
                   "leftValue": 0.25,
                   "rightValue": 0.25,
                   "headerValue": 0.3,
                   "footerValue": 0.3
                 },
                 {
                   "type": 2,
                   "topValue": 1,
                   "bottomValue": 1,
                   "leftValue": 1,
                   "rightValue": 1,
                   "headerValue": 0.5,
                   "footerValue": 0.5
                 },
                 {
                   "type": 3,
                   "topValue": 0.75,
                   "bottomValue": 0.75,
                   "leftValue": 0.7,
                   "rightValue": 0.7,
                   "headerValue": 0.3,
                   "footerValue": 0.3
                 }
               ]
             },
             "deletable": false,
             "editable": false,
             "movable": false,
             "copyable": false,
             "accessPriority": 0,
             "active": false,
             "id": "90ab0d69-be94-4fb0-965f-b398c7af2ba6",
             "state": 1,
             "deleted": false,
             "inserted": false,
             "version": 0,
             "created": null,
             "createdBy": "John Doe",
             "modified": null,
             "modifiedBy": "John Doe"
           },
           "success": true,
           "messages": null,
           "data": null
         }

Populate the report parts
-------------------------------------

#. Extract the populated ReportDefinition from ``report`` field.
#. Prepare the report part objects:

   *  :doc:`code_javascript_build_a_simple_grid`
   *  To be updated for Chart, Gauge, Map and Form |br|
#. Populate its ``reportPart`` field with the report part objects.

Call Save report API
------------------------------

#. Prepare the :doc:`/ref/models/ReportSavingParameter` object and call :ref:`Save report <POST_report>` API similarly to `Call Save report as draft API`_ step.
#. Receive back the :doc:`/ref/models/OperationResult` object and check that ``success`` field is true.
