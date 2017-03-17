

=================
FilterSyntax
=================

.. list-table::
   :header-rows: 1
   :widths: 25 5 65 5

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **syntax** |br|
         string
      -
      -  The filter syntax
      -
   *  -  **availableFilter** |br|
         array of integers
      -
      -  The list of filters index number, from 1 up to n
      -

.. container:: toggle

   .. container:: header

      **Sample**:

   .. code-block:: json

      {
        "availableFilter" : [1, 2, 3, 4],
        "syntax" : "(1 OR 2) AND (3 OR 4)"
      }
