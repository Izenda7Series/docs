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
      :emphasize-lines: 0

      {
         "name": "OrderDate",
         "other fields": "are not included in this sample",
         "properties": {
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
      :emphasize-lines: 0

      {
         "name": "Sum (Freight)",
         "other fields": "are not included in this sample",
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
         }
      }
