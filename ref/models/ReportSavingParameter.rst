

=========================================
ReportSavingParameter
=========================================

.. list-table::
   :header-rows: 1
   :widths: 25 5 65 5

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **saveAs** |br|
         boolean
      -
      -  Is this saved as new report
      -
   *  -  **report** |br|
         object
      -
      -  A :doc:`ReportDefinition` object
      -
   *  -  **section** |br|
         integer
      -
      -  The report section

         -  0 = All
         -  1 = DataSource
         -  2 = Fields
         -  3 = CalculatedField
      -
   *  -  **tenantId** |br|
         string (GUID)
      -  Y
      -  The id of the tenant
      -
   *  -  **ignoreCheckChange** |br|
         boolean
      -
      -  Is the check for report changes ignored
      -
   *  -  **ignoreCheckName** |br|
         boolean
      -
      -  Is the check for report name ignored
      -




Inherited fields:

.. include:: ReportParameter.rst
