

===================
SecurityPolicy
===================

.. list-table::
   :header-rows: 1
   :widths: 25 5 65 5

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **minNumberOfPasswordLenght** |br|
         integer
      -  Y
      -  Password length From setting
      -
   *  -  **maxNumberOfPasswordLenght** |br|
         integer
      -  Y
      -  Password length To setting
      -
   *  -  **minNumberOfSpecialCharacter'''** |br|
         integer
      -  Y
      -  Number of special characters From setting
      -
   *  -  **maxNumberOfSpecialCharacter'''** |br|
         integer
      -  Y
      -  Number of special characters To setting
      -
   *  -  **minNumberOfUppercaseCharacter'''** |br|
         integer
      -  Y
      -  Number of uppercase characters From setting
      -
   *  -  **maxNumberOfUppercaseCharacter'''** |br|
         integer
      -  Y
      -  Number of uppercase characters To setting
      -
   *  -  **minNumberOfLowercaseCharacter'''** |br|
         integer
      -  Y
      -  Number of lowercase characters From setting
      -
   *  -  **maxNumberOfLowercaseCharacter'''** |br|
         integer
      -  Y
      -  Number of lowercase characters To setting
      -
   *  -  **minNumberOfNumericCharacter'''** |br|
         integer
      -  Y
      -  Number of numeric characters From setting
      -
   *  -  **maxNumberOfNumericCharacter'''** |br|
         integer
      -  Y
      -  Number of numeric characters To setting
      -
   *  -  **maxNumberOfRepeatSequential'''** |br|
         integer
      -  Y
      -  Max number of sequential repeated characters setting
      -
   *  -  **minNumberOfPasswordAge'''** |br|
         integer
      -  Y
      -  Password age From setting
      -
   *  -  **maxNumberOfPasswordAge'''** |br|
         integer
      -  Y
      -  Password age To setting
      -
   *  -  **notifyUseDuring'''** |br|
         integer
      -  Y
      -  Notify user during x days to password expiry setting
      -
   *  -  **NumberOfPasswordToKeep'''** |br|
         integer
      -  Y
      -  Number of passwords to keep setting
      -
   *  -  **passwordLinkValidity'''** |br|
         integer
      -  Y
      -  Password link validity x hour(s) setting
      -
   *  -  **numberOfQuestionProfile'''** |br|
         integer
      -  Y
      -  Number of security questions per user profile setting
      -
   *  -  **numberOfQuestionResetPassword'''** |br|
         integer
      -  Y
      -  Number of security questions to reset password setting
      -
   *  -  **numberOfFailedLogonAllowed'''** |br|
         integer
      -  Y
      -  Number of failed logon attempts allowed setting
      -
   *  -  **numberOfFailedAnswerAllowed'''** |br|
         integer
      -  Y
      -  Number of failed security question attempts allowed setting
      -
   *  -  **tenantId'''** |br|
         string (GUID)
      -  Y
      -  The id of the tenant if available
      -
   *  -  **lockoutPeriod'''** |br|
         integer
      -  Y
      -  Number of failed security question attempts allowed setting
      -



Inherited fields:

.. include:: Entity.rst
