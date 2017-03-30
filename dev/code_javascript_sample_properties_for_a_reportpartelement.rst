=========================================================
Sample Properties for a ReportPartElement
=========================================================

.. note::

   See :doc:`/ref/models/ReportPartElementProperties` for the purpose of each field.

.. container:: toggle

   .. container:: header

      Sample for ``GROUP(OrderDate)``

   |br|

   *  "7f942ac7-08d8-41fa-9e89-bad96f07f102" is the id for GROUP function
   *  Get the list of functions from :ref:`GET_report/function/{function_mode}/{data_type}/(tenant_id)`
   *  "76875180-32c1-4180-b92f-03bdb14c4f6a" is the id for Year format
   *  Get the list of formats from :ref:`GET_report/field/dataFormat/{dataType}`

   .. code-block:: json
      :linenos:
      :emphasize-lines: 9,21

      {
         "name": "OrderDate",
         "other fields": "are not included in this sample",
         "properties": {
            "fieldItemVisible": true,
            "dataFormattings": {
               "function": "7f942ac7-08d8-41fa-9e89-bad96f07f102",
               "functionInfo": {
                  "id": "7f942ac7-08d8-41fa-9e89-bad96f07f102",
                  "name": "Group",
                  "expression": null,
                  "dataType": "Datetime",
                  "formatDataType": "Datetime",
                  "syntax": null,
                  "expressionSyntax": null,
                  "isOperator": false,
                  "userDefined": false,
                  "extendedProperties": {}
               },
               "format": {
                  "formatId": "76875180-32c1-4180-b92f-03bdb14c4f6a",
                  "format": "Year",
                  "groupBy": "year",
                  "formatDataType": null,
                  "createNewHiddenPercenOfGroupField": false
               },
               "font": {
                  "family": "Roboto",
                  "size": 14,
                  "bold": false,
                  "italic": false,
                  "underline": false,
                  "color": "",
                  "backgroundColor": ""
               },
               "width": {
                  "value": null
               },
               "alignment": "alignLeft",
               "sort": "ASC",
               "color": {
                  "textColor": {
                     "rangePercent": null,
                     "rangeValue": null,
                     "value": null
                  },
                  "cellColor": {
                     "rangePercent": null,
                     "rangeValue": null,
                     "value": null
                  }
               },
               "alternativeText": {
                  "rangePercent": null,
                  "rangeValue": null,
                  "value": null
               },
               "customURL": {
                  "url": "",
                  "option": "LINK_NEW_WINDOW"
               },
               "embeddedJavascript": {
                  "script": ""
               },
               "subTotal": {
                  "label": "",
                  "function": "",
                  "expression": "",
                  "dataType": "",
                  "format": {},
                  "previewResult": ""
               },
               "grandTotal": {
                  "label": "",
                  "function": "",
                  "expression": "",
                  "dataType": "",
                  "format": {},
                  "previewResult": ""
               }
            },
            "headerFormating": {
               "font": {
                  "family": null,
                  "size": null,
                  "bold": null,
                  "italic": null,
                  "underline": null,
                  "color": null,
                  "backgroundColor": null
               },
               "alignment": null,
               "wordWrap": null,
               "columnGroup": ""
            },
            "drillDown": {
               "subReport": {
                  "selectedReport": null,
                  "style": null,
                  "reportPartUsed": null,
                  "reportFilter": true,
                  "mappingFields": [],
                  "selectedIconValue": {
                     "icon": null,
                     "value": null
                  },
                  "viewSettingByLink": null
               }
            },
            "otherProps": {}
         }
      }

.. container:: toggle

   .. container:: header

      Sample for ``SUM(Freight)``

   |br|

   *  "902a9168-fc01-4a35-92fb-ea67942d099d" is the id for SUM function
   *  Get the list of functions from :ref:`GET_report/function/{function_mode}/{data_type}/(tenant_id)`

   .. code-block:: json
      :linenos:
      :emphasize-lines: 9

      {
         "name": "Sum (Freight)",
         "other fields": "are not included in this sample",
         "properties": {
            "fieldItemVisible": true,
            "dataFormattings": {
               "function": "902a9168-fc01-4a35-92fb-ea67942d099d",
               "functionInfo": {
                  "id": "902a9168-fc01-4a35-92fb-ea67942d099d",
                  "name": "Sum",
                  "expression": null,
                  "dataType": "Money",
                  "formatDataType": "Money",
                  "syntax": null,
                  "expressionSyntax": null,
                  "isOperator": false,
                  "userDefined": false,
                  "extendedProperties": {}
               },
               "format": {
                  "createNewHiddenPercenOfGroupField": false
               },
               "font": {
                  "family": "Roboto",
                  "size": 14,
                  "bold": false,
                  "italic": false,
                  "underline": false,
                  "color": "",
                  "backgroundColor": ""
               },
               "width": {
                  "value": null
               },
               "alignment": "alignLeft",
               "sort": "ASC",
               "color": {
                  "textColor": {
                     "rangePercent": null,
                     "rangeValue": null,
                     "value": null
                  },
                  "cellColor": {
                     "rangePercent": null,
                     "rangeValue": null,
                     "value": null
                  }
               },
               "alternativeText": {
                  "rangePercent": null,
                  "rangeValue": null,
                  "value": null
               },
               "customURL": {
                  "url": "",
                  "option": "LINK_NEW_WINDOW"
               },
               "embeddedJavascript": {
                  "script": ""
               },
               "subTotal": {
                  "label": "",
                  "function": "",
                  "expression": "",
                  "dataType": "",
                  "format": {},
                  "previewResult": ""
               },
               "grandTotal": {
                  "label": "",
                  "function": "",
                  "expression": "",
                  "dataType": "",
                  "format": {},
                  "previewResult": ""
               }
            },
            "headerFormating": {
               "font": {
                  "family": null,
                  "size": null,
                  "bold": null,
                  "italic": null,
                  "underline": null,
                  "color": null,
                  "backgroundColor": null
               },
               "alignment": null,
               "wordWrap": null,
               "columnGroup": ""
            },
            "drillDown": {
               "subReport": {
                  "selectedReport": null,
                  "style": null,
                  "reportPartUsed": null,
                  "reportFilter": true,
                  "mappingFields": [],
                  "selectedIconValue": {
                     "icon": null,
                     "value": null
                  },
                  "viewSettingByLink": null
               }
            },
            "otherProps": {}
         }
      }

.. container:: toggle

   .. container:: header

      Sample for ``SUM(Freight)`` with Gauge metric settings

   |br|

   *  "902a9168-fc01-4a35-92fb-ea67942d099d" is the id for SUM function
   *  Get the list of functions from :ref:`GET_report/function/{function_mode}/{data_type}/(tenant_id)`
   *  The Gauge metric settings are also highlighted:

      -  Scale from 4000 to 8000
      -  Unit label shows "USD"
      -  Static threshold levels: less than 5000, between 5000 and 7000, greater than 7000

   .. code-block:: json
      :linenos:
      :emphasize-lines: 11,111-113,115,122,124,131-133,140,141

      {
         "reportPartContent": null,
         "isDirty": false,
         "name": "Sum (Freight)",
         "properties": {
            "isDirty": false,
            "fieldItemVisible": true,
            "dataFormattings": {
               "function": "902a9168-fc01-4a35-92fb-ea67942d099d",
               "functionInfo": {
                  "id": "902a9168-fc01-4a35-92fb-ea67942d099d",
                  "name": "Sum",
                  "expression": null,
                  "dataType": "Money",
                  "formatDataType": "Money",
                  "syntax": null,
                  "expressionSyntax": null,
                  "isOperator": false,
                  "userDefined": false,
                  "extendedProperties": {}
               },
               "format": {
                  "createNewHiddenPercenOfGroupField": false
               },
               "font": {
                  "family": "Roboto",
                  "size": 14,
                  "bold": false,
                  "italic": false,
                  "underline": false,
                  "color": "",
                  "backgroundColor": ""
               },
               "width": {
                  "value": null
               },
               "alignment": "alignLeft",
               "sort": "ASC",
               "color": {
                  "textColor": {
                     "rangePercent": null,
                     "rangeValue": null,
                     "value": null
                  },
                  "cellColor": {
                     "rangePercent": null,
                     "rangeValue": null,
                     "value": null
                  }
               },
               "alternativeText": {
                  "rangePercent": null,
                  "rangeValue": null,
                  "value": null
               },
               "customURL": {
                  "url": "",
                  "option": "LINK_NEW_WINDOW"
               },
               "embeddedJavascript": {
                  "script": ""
               },
               "subTotal": {
                  "label": "",
                  "function": "",
                  "expression": "",
                  "dataType": "",
                  "format": {},
                  "previewResult": ""
               },
               "grandTotal": {
                  "label": "",
                  "function": "",
                  "expression": "",
                  "dataType": "",
                  "format": {},
                  "previewResult": ""
               }
            },
            "headerFormating": {
               "font": {
                  "family": null,
                  "size": null,
                  "bold": null,
                  "italic": null,
                  "underline": null,
                  "color": null,
                  "backgroundColor": null
               },
               "alignment": null,
               "wordWrap": null,
               "columnGroup": ""
            },
            "drillDown": {
               "subReport": {
                  "selectedReport": null,
                  "style": null,
                  "reportPartUsed": null,
                  "reportFilter": true,
                  "mappingFields": [],
                  "selectedIconValue": {
                     "icon": null,
                     "value": null
                  },
                  "viewSettingByLink": null
               }
            },
            "otherProps": {},
            "metric": {
               "isDirty": true,
               "scale": {
                  "from": 4000,
                  "to": 8000
               },
               "unitLabel": "USD",
               "thresholds": {
                  "setting": "static",
                  "levels": [
                     {
                        "name": "low",
                        "color": "#55BF3B",
                        "operator": "less than",
                        "value": null,
                        "valueUpper": 5000,
                        "element": null,
                        "elementUpper": null
                     },
                     {
                        "name": "target",
                        "color": "#DDDF0D",
                        "operator": "between",
                        "value": 5000,
                        "valueUpper": 7000,
                        "element": null,
                        "elementUpper": null
                     },
                     {
                        "name": "high",
                        "color": "#DF5353",
                        "operator": "greater than",
                        "value": 7000,
                        "valueUpper": null,
                        "element": null,
                        "elementUpper": null
                     }
                  ]
               },
               "supplementaryKPI": {
                  "valueType": "",
                  "unitLabel": "",
                  "value": null,
                  "element": null
               }
            }
         },
         "position": 1,
         "field": {
            "fieldId": "61b3c4ad-cbd4-49b0-9385-540568397e05",
            "fieldName": "Freight",
            "fieldNameAlias": "Sum (Freight)",
            "dataFieldType": "Money",
            "querySourceId": "af773c7b-878e-461b-9345-27ee6592db1a",
            "querySourceType": "Table",
            "sourceAlias": "Orders",
            "relationshipId": "00000000-0000-0000-0000-000000000000",
            "visible": true,
            "calculatedTree": null,
            "isCalculated": false,
            "hasAggregatedFunction": false
         },
         "isDeleted": false,
         "isSelected": false,
         "offset": {
            "top": 359,
            "right": 592.25,
            "bottom": 381,
            "left": 473.25,
            "width": 119,
            "height": 22
         }
      }
