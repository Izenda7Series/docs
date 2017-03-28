=========================================================
Build a simple Chart
=========================================================

Steps:

#. Follow :doc:`code_javascript_build_a_generic_report` until the step to add report parts.
#. Prepare an empty :doc:`/ref/models/ReportPartChart` object with default properties.
#. For each selected data source fields, populate a :doc:`/ref/models/ReportPartElement` object with default properties.
#. Add the :doc:`/ref/models/ReportPartElement` objects into either ``labels.elements``, ``values.elements``, ``valuesLabels.elements``, ``separators.elements`` or ``bubbleSize.elements`` in :doc:`/ref/models/ReportPartChart` object.
#. Update the properties of the chart in ``properties`` field per user selection (See :doc:`/ref/models/ReportPartChartProperties`).
#. Back to the steps in :doc:`code_javascript_build_a_generic_report`.

Prepare an empty ReportPartChart object
----------------------------------------

.. container:: toggle

   .. container:: header

      Empty ReportPartChart object

   |br|

   *  The highlighted ``labels.elements``, ``values.elements``, ``valuesLabels.elements``, ``separators.elements`` and ``bubbleSize.elements`` are where the selected data source fields will be added
   *  The highlighted ``properties`` contains the default properties

   .. code-block:: json
      :linenos:
      :emphasize-lines: 0

      {
         "type": 0,
         "title": {
            "text": "",
            "properties": {},
            "settings": {
               "font": {
                  "family": "",
                  "size": 14,
                  "bold": true,
                  "italic": false,
                  "underline": false,
                  "color": "",
                  "highlightColor": ""
               },
               "alignment": {
                  "alignment": ""
               }
            },
            "elements": []
         },
         "description": {
            "text": "",
            "properties": {},
            "settings": {
               "font": {
                  "family": "",
                  "size": 14,
                  "bold": false,
                  "italic": false,
                  "underline": false,
                  "color": "",
                  "highlightColor": ""
               },
               "alignment": {
                  "alignment": ""
               }
            },
            "elements": []
         },
         "labels": {
            "elements": [],
            "name": "labels"
         },
         "values": {
            "elements": [],
            "name": "values"
         },
         "valuesLabels": {
            "elements": [],
            "name": "valuesLabels"
         },
         "separators": {
            "elements": [],
            "name": "separators"
         },
         "bubbleSize": {
            "elements": [],
            "name": "bubbleSize"
         },
         "properties": {
            "staticProperties": {},
            "chartType": "Line",
            "commonOptions": {
               "izHoverLabels": true,
               "izLegend.visibility": false,
               "izLegend.horizontalAlign": "izRight",
               "izLegend.verticalAlign": "izBottom",
               "izLegend.borderWidth": 0,
               "izChartStyle": {},
               "izendaHiddenAllAxis": false
            },
            "optionByType": {
               "izTotalLabel": "",
               "izUseSeparator": true,
               "izInverted": false,
               "izSpline": false,
               "izValueLabel": false,
               "legendSettings": true
            },
            "view": {
               "dataRefreshInterval": {
                  "enable": false,
                  "updateInterval": 0,
                  "isAll": true,
                  "latestRecord": 0
               }
            },
            "commonXYAxis": {},
            "printing": {
               "izPageBreakAfterSeparator": false
            }
         }
      }

Populate selected data sources fields
---------------------------------------

#. Refer to the :ref:`similar step in Building a Grid guide <Grid_Populate_selected_data_sources_fields>` to:

   *  Get the list of available data sources fields from :ref:`POST_report/availableQuerySourceFields`
   *  Build a corresponding ReportPartElement object for each selected data source field
   *  Populate a default ReportPartElementProperties for ``properties`` field in each ReportPartElement object

#. Add the :doc:`/ref/models/ReportPartElement` objects into ``labels.elements``, ``values.elements``, ``valuesLabels.elements``, ``separators.elements`` or ``bubbleSize.elements`` in :doc:`/ref/models/ReportPartChart` object.

   .. _Sample_full_ReportPartChart_object:

   .. container:: toggle

      .. container:: header

         Sample full ReportPartChart object

      .. code-block:: json

         {
            "type": 0,
            "title": {
               "text": "",
               "properties": {},
               "settings": {
                  "font": {
                     "family": "",
                     "size": 14,
                     "bold": true,
                     "italic": false,
                     "underline": false,
                     "color": "",
                     "highlightColor": ""
                  },
                  "alignment": {
                     "alignment": ""
                  }
               },
               "elements": []
            },
            "description": {
               "text": "",
               "properties": {},
               "settings": {
                  "font": {
                     "family": "",
                     "size": 14,
                     "bold": false,
                     "italic": false,
                     "underline": false,
                     "color": "",
                     "highlightColor": ""
                  },
                  "alignment": {
                     "alignment": ""
                  }
               },
               "elements": []
            },
            "activeSerie": {
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
                     "format": {},
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
                  "relationshipId": null,
                  "visible": true,
                  "calculatedTree": null,
                  "schemaName": "dbo",
                  "querySourceName": "Orders",
                  "databaseName": "test",
                  "isCalculated": false,
                  "hasAggregatedFunction": false
               },
               "isDeleted": false,
               "isSelected": false,
               "offset": {
                  "top": 597,
                  "right": 456,
                  "bottom": 619,
                  "left": 337,
                  "width": 119,
                  "height": 22
               }
            },
            "inconsitentFunction": false,
            "labels": {
               "elements": [
                  {
                     "reportPartContent": null,
                     "isDirty": false,
                     "name": "OrderDate",
                     "properties": {
                        "isDirty": false,
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
                              "formatDataType": null
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
                     },
                     "position": 1,
                     "field": {
                        "fieldId": "fbf031a0-3e2d-49e7-972e-fffc98b634e5",
                        "fieldName": "OrderDate",
                        "fieldNameAlias": "OrderDate",
                        "dataFieldType": "Datetime",
                        "querySourceId": "af773c7b-878e-461b-9345-27ee6592db1a",
                        "querySourceType": "Table",
                        "sourceAlias": "Orders",
                        "relationshipId": null,
                        "visible": true,
                        "calculatedTree": null,
                        "schemaName": "dbo",
                        "querySourceName": "Orders",
                        "databaseName": "test",
                        "isCalculated": false,
                        "hasAggregatedFunction": false
                     },
                     "isDeleted": false,
                     "isSelected": false,
                     "offset": {
                        "top": 500,
                        "right": 436.671875,
                        "bottom": 522,
                        "left": 337,
                        "width": 99.671875,
                        "height": 22
                     }
                  }
               ],
               "name": "labels"
            },
            "values": {
               "elements": [
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
                           "format": {},
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
                        "relationshipId": null,
                        "visible": true,
                        "calculatedTree": null,
                        "schemaName": "dbo",
                        "querySourceName": "Orders",
                        "databaseName": "test",
                        "isCalculated": false,
                        "hasAggregatedFunction": false
                     },
                     "isDeleted": false,
                     "isSelected": false,
                     "offset": {
                        "top": 597,
                        "right": 456,
                        "bottom": 619,
                        "left": 337,
                        "width": 119,
                        "height": 22
                     }
                  }
               ],
               "name": "values"
            },
            "valuesLabels": {
               "elements": [],
               "name": "valuesLabels"
            },
            "separators": {
               "elements": [],
               "name": "separators"
            },
            "bubbleSize": {
               "elements": [],
               "name": "bubbleSize"
            },
            "properties": {
               "staticProperties": {},
               "chartType": "Line",
               "commonOptions": {
                  "izHoverLabels": true,
                  "izLegend.visibility": false,
                  "izLegend.horizontalAlign": "izRight",
                  "izLegend.verticalAlign": "izBottom",
                  "izLegend.borderWidth": 0,
                  "izChartStyle": {},
                  "izendaHiddenAllAxis": false
               },
               "optionByType": {
                  "izTotalLabel": "",
                  "izUseSeparator": true,
                  "izInverted": false,
                  "izSpline": false,
                  "izValueLabel": false,
                  "legendSettings": true
               },
               "view": {
                  "dataRefreshInterval": {
                     "enable": false,
                     "updateInterval": 0,
                     "isAll": true,
                     "latestRecord": 0
                  }
               },
               "commonXYAxis": {},
               "printing": {
                  "izPageBreakAfterSeparator": false
               }
            }
         }

Update the properties of each field per user selection
------------------------------------------------------------------------------

See :doc:`code_javascript_sample_properties_for_a_reportpartelement` 

Update the properties of the Chart in "properties" field per user selection
------------------------------------------------------------------------------

Please see :doc:`/ref/models/ReportPartChartProperties` for the purpose of each field.

Back to the step in :ref:`Build a Generic Report <Populate_the_report_parts>`
------------------------------------------------------------------------------
