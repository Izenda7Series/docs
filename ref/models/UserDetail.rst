

=========================================
UserDetail
=========================================

.. list-table::
   :header-rows: 1
   :widths: 25 5 65 5

   *  -  Field
      -  Null
      -  Description
      -  Note
   *  -  **password** |br|
         string
      -
      -  The password
      -
   *  -  **roles** |br|
         array of objects
      -
      -  An array of :doc:`Role` objects
      -
   *  -  **userRoles** |br|
         array of objects
      -
      -  An array of :doc:`UserRole` objects
      -
   *  -  **userSecurityQuestions** |br|
         array of objects
      -
      -  An array of :doc:`UserSecurityQuestion` objects
      -
   *  -  **status** |br|
         integer
      -
      -  The status

         -  1 = Active
         -  2 = Deactive
         -  3 = PasswordNotSet
         -  4 = LoginAttemptFailed
         -  5 = AnswerAttempFailed
      -
   *  -  **issueDate** |br|
         datetime
      -
      -  The time when token was generated
      -
   *  -  **autoLogin** |br|
         boolean
      -
      -  Whether system will auto login this user
      -
   *  -  **newPassword** |br|
         string
      -
      -  The new password
      -

Inherited fields:

.. include:: User.rst
