

=========================================
PasswordOption
=========================================

.. list-table::
   :header-rows: 1
   :widths: 25 5 65 5

   *  -  Field
      -  Null
      -  Description
      -  Note
   *  -  **passwordLink** |br|
         string
      -
      -  The password link
      -
   *  -  **user** |br|
         object
      -
      -  A :doc:`UserDetail` object
      -
   *  -  **sendEmail** |br|
         boolean
      -
      -  Send password link via email or not
      -
   *  -  **clearSecurityQuestion** |br|
         boolean
      -
      -  Clear all security questions or not
      -
   *  -  **emailAddresses** |br|
         array of strings
      -
      -  The list of email addresses to send password link
      -


Inherited fields:

.. include:: Expiration.rst
