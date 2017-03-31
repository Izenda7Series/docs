
=========================
ReportPartMapProperties
=========================

.. list-table::
   :header-rows: 1
   :widths: 25 5 70

   *  -  Field
      -  NULL
      -  Description
   *  -  **chartType** |br|
         string
      -
      -  The map type: either SolidGauge, LinearGauge or SimpleGauge
   *  -  **continentInfo** |br|
         object
      -
      -  To be updated
   *  -  **countryInfo** |br|
         object
      -
      -  To be updated
   *  -  **stateInfo** |br|
         object
      -
      -  To be updated
   *  -  **commonOptions** |br|
         object
      -
      -  The options that are common for all map types
   *  -  .. container:: lpad2

               **izLegend.visibility** |br|
               boolean
      -
      -  Is the legend visible
   *  -  .. container:: lpad2

               **izLegend.horizontalAlign** |br|
               string
      -
      -  The alignment for horizontal axis, either izRight, izLeft or izCenter
   *  -  .. container:: lpad2

               **izLegend.verticalAlign** |br|
               string
      -
      -  The alignment for vertical axis, either izTop, izBottom or izMiddle
   *  -  .. container:: lpad2

               **izLegend.borderWidth** |br|
               integer
      -
      -  The border width for the legend
   *  -  .. container:: lpad2

               **izChartStyle** |br|
               object
      -
      -  To be updated
   *  -  .. container:: lpad2

               **izendaHiddenAllAxis** |br|
               boolean
      -
      -  Whether to hide all axis
   *  -  **optionByType** |br|
         object
      -
      -  The options that are specific for each map type
   *  -  .. container:: lpad2

               **izValueLabel** |br|
               boolean
      -
      -  Whether to show value labels
   *  -  .. container:: lpad2

               **izShowTooltip** |br|
               boolean
      -
      -  Whether to show tooltips
   *  -  .. container:: lpad2

               **izMapLabel** |br|
               boolean
      -
      -  Whether to show labels for map
   *  -  .. container:: lpad2

               **izMapNavigation.enabled** |br|
               boolean
      -
      -  Whether map navigation is enabled
   *  -  .. container:: lpad2

               **legendSettings** |br|
               boolean
      -
      -  Whether legend settings are set
   *  -  **view** |br|
         object
      -
      -  
   *  -  .. container:: lpad2

               **showLabels** |br|
               boolean
      -
      -  Whether to show labels
   *  -  .. container:: lpad2
   
            **dataRefreshInterval** |br|
            object
      -
      -  An object with the following fields
   *  -  .. container:: lpad4
   
            **enable** |br|
            boolean
      -
      -  Is this feature turned on
   *  -  .. container:: lpad4
   
            **updateInteval** |br|
            integer
      -
      -  The refresh interval
   *  -  .. container:: lpad4
   
            **isAll** |br|
            boolean
      -
      -  View all data (or x latest records)
   *  -  .. container:: lpad4
   
            **latestRecord** |br|
            integer
      -
      -  How many latest records to retrieve
