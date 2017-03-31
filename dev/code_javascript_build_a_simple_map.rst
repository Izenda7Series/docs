=========================================================
Build a simple Map (In Progress)
=========================================================

Steps:

#. Follow :doc:`code_javascript_build_a_generic_report` until the step to add report parts.
#. Prepare an empty :doc:`/ref/models/ReportPartMap` object with default properties.
#. For each selected data source fields, populate a :doc:`/ref/models/ReportPartElement` object with default properties.
#. Add the :doc:`/ref/models/ReportPartElement` objects into either ``pointOptions.elements``, ``shadingMetric.elements`` or ``bubbleMetrics.elements`` in :doc:`/ref/models/ReportPartMap` object.
#. Update the properties of the map in ``properties`` field per user selection (See :doc:`/ref/models/ReportPartMapProperties`).
#. Back to the steps in :doc:`code_javascript_build_a_generic_report`.

Prepare an empty ReportPartMap object
----------------------------------------

.. container:: toggle

   .. container:: header

      Empty ReportPartMap object

   |br|

   *  The highlighted ``pointOptions.elements``, ``shadingMetric.elements`` and ``bubbleMetrics.elements`` are where the selected data source fields will be added
   *  The highlighted ``properties`` contains the default properties

   .. code-block:: json
      :linenos:
      :emphasize-lines: 42,77,84,88

      {
         "type": 4,
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
         "properties": {
            "chartType": "World",
            "continentInfo": {},
            "countryInfo": {},
            "stateInfo": {},
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
               "izValueLabel": false,
               "izShowTooltip": true,
               "izMapLabel": false,
               "izMapNavigation.enabled": false,
               "legendSettings": true
            },
            "view": {
               "showLabels": false,
               "dataRefreshInterval": {
                  "enable": false,
                  "updateInterval": 0,
                  "isAll": true,
                  "latestRecord": 0
               }
            }
         },
         "shadingMetric": {
            "text": null,
            "properties": {},
            "settings": {},
            "name": "shadingMetric",
            "elements": []
         },
         "bubbleMetrics": {
            "text": null,
            "properties": {},
            "settings": {},
            "name": "bubbleMetrics",
            "elements": []
         },
         "settings": {},
         "pointOptions": {
            "elements": [],
            "name": "pointOptions"
         }
      }

Populate selected data sources fields
---------------------------------------

#. Refer to the :ref:`similar step in Building a Grid guide <Grid_Populate_selected_data_sources_fields>` to:

   #. Get the list of available data sources fields from :ref:`POST_report/availableQuerySourceFields`
   #. Build a corresponding ReportPartElement object for each selected data source field
   #. Populate a default ReportPartElementProperties for ``properties`` field in each ReportPartElement object

   See :doc:`code_javascript_sample_properties_for_a_reportpartelement` for some samples.

#. Add the :doc:`/ref/models/ReportPartElement` objects into ``pointOptions.elements``, ``shadingMetric.elements`` and ``bubbleMetrics.elements`` in :doc:`/ref/models/ReportPartMap` object.

.. _Sample_full_ReportPartMap_object:

.. container:: toggle

   .. container:: header

      Sample full ReportPartMap object

   *  Highlighted in ``pointOptions.elements`` are the ReportPartElement objects for ``GROUP(ShipCountry)`` and ``GROUP(ShipCity)``
   *  Highlighted in ``bubbleMetrics.elements`` is the ReportPartElement for ``SUM(Freight)``
   *  Highlighted in ``properties.chartType`` is the chart type (World)

   |br|

   .. code-block:: json
      :linenos:
      :emphasize-lines: 42,79,84,86,210-211,213,336

      {
         "type": 4,
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
         "properties": {
            "chartType": "World",
            "continentInfo": {},
            "countryInfo": {},
            "stateInfo": {},
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
               "izValueLabel": false,
               "izShowTooltip": true,
               "izMapLabel": false,
               "izMapNavigation.enabled": false,
               "legendSettings": true
            },
            "view": {
               "showLabels": false,
               "dataRefreshInterval": {
                  "enable": false,
                  "updateInterval": 0,
                  "isAll": true,
                  "latestRecord": 0
               }
            }
         },
         "shadingMetric": {
            "text": null,
            "properties": {},
            "settings": {},
            "name": "shadingMetric",
            "elements": []
         },
         "bubbleMetrics": {
            "text": null,
            "properties": {},
            "settings": {},
            "name": "bubbleMetrics",
            "elements": [
               {
                  "name": "Sum (Freight)",
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
                  }
               }
            ]
         },
         "settings": {},
         "pointOptions": {
            "elements": [
               {
                  "name": "ShipCountry",
                  "properties": {
                     "fieldItemVisible": true,
                     "dataFormattings": {
                        "function": "7f942ac7-08d8-41fa-9e89-bad96f07f102",
                        "functionInfo": {
                           "id": "7f942ac7-08d8-41fa-9e89-bad96f07f102",
                           "name": "Group",
                           "expression": null,
                           "dataType": "Text",
                           "formatDataType": "Text",
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
                     "pointOptionType": "country"
                  },
                  "position": 1,
                  "field": {
                     "fieldId": "500f4309-beb3-4af2-892b-dcec65bf8604",
                     "fieldName": "ShipCountry",
                     "fieldNameAlias": "ShipCountry",
                     "dataFieldType": "Text",
                     "querySourceId": "af773c7b-878e-461b-9345-27ee6592db1a",
                     "querySourceType": "Table",
                     "sourceAlias": "Orders",
                     "relationshipId": "00000000-0000-0000-0000-000000000000",
                     "visible": true,
                     "calculatedTree": null,
                     "isCalculated": false,
                     "hasAggregatedFunction": false
                  }
               },
               {
                  "name": "ShipCity",
                  "properties": {
                     "fieldItemVisible": true,
                     "dataFormattings": {
                        "function": "7f942ac7-08d8-41fa-9e89-bad96f07f102",
                        "functionInfo": {
                           "id": "7f942ac7-08d8-41fa-9e89-bad96f07f102",
                           "name": "Group",
                           "expression": null,
                           "dataType": "Text",
                           "formatDataType": "Text",
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
                     "otherProps": {},
                     "pointOptionType": "city"
                  },
                  "position": 1,
                  "field": {
                     "fieldId": "b0554a37-b744-4db8-b1b0-95b029d8cae2",
                     "fieldName": "ShipCity",
                     "fieldNameAlias": "ShipCity",
                     "dataFieldType": "Text",
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
                  }
               }
            ],
            "name": "pointOptions"
         }
      }

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

      
