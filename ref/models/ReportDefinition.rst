

=========================================
ReportDefinition
=========================================

.. list-table::
   :header-rows: 1
   :widths: 25 5 65 5

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **inaccessible** |br|
         boolean
      -
      -  True if report is inaccessible for user
      -
   *  -  **category** |br|
         object
      -
      -  A :doc:`Category` object
      -
   *  -  **subCategory** |br|
         object
      -
      -  A :doc:`Category` object
      -
   *  -  **reportRelationship** |br|
         array of objects
      -
      -  An array of :doc:`Relationship` objects
      -
   *  -  **reportPart** |br|
         array of objects
      -
      -  An array of :doc:`ReportPartDefinition` objects
      -
   *  -  **reportFilter** |br|
         object
      -
      -  A :doc:`ReportFilterSetting` object
      -
   *  -  **calculatedFields** |br|
         array of objects
      -
      -  An array of :doc:`QuerySourceField` objects
      -
   *  -  **accesses** |br|
         array of objects
      -
      -  An array of :doc:`UserPermission` objects
      -
   *  -  **schedules** |br|
         array of objects
      -
      -  An array of :doc:`Subscription` objects
      -
   *  -  **getAllFields** |br|
         array of objects
      -
      -  An array of :doc:`ReportField` objects
      -
   *  -  **getUsingFieldIds** |br|
         array of strings (GUIDs)
      -
      -  The list of ids of fields used by report
      -
   *  -  **dynamicQuerySourceFields** |br|
         array of objects
      -
      -  An array of :doc:`QuerySourceField` objects
      -








Inherited fields:

.. include:: Report.rst
