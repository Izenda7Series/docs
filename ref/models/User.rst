

User
--------

.. list-table::
   :header-rows: 1
   :widths: 25 5 65 5

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **userName** |br|
         string
      -
      -  The name of the user
      -
   *  -  **emailAddress** |br|
         string
      -
      -  The email address of the user
      -
   *  -  **firstName** |br|
         string
      -
      -  The first name of the user
      -
   *  -  **lastName** |br|
         string
      -
      -  The last name of the user
      -
   *  -  **passwordHash** |br|
         string
      -
      -  The password hash
      -
   *  -  **passwordSalt** |br|
         string
      -
      -  The password salt
      -
   *  -  **currentTokenHash** |br|
         string
      -
      -  The hash of the current token
      -
   *  -  **tenantId** |br|
         string (GUID)
      -  Y
      -  The id of the tenant if available
      -
   *  -  **tenantName** |br|
         string (GUID)
      -
      -  The name of the tenant if available
      -
   *  -  **dataOffset** |br|
         integer
      -
      -  The time shift to be applied to datetime data from client database connections to match user's local time
      -
   *  -  **timestampOffset** |br|
         integer
      -
      -  The time shift to be applied to timestamp data (created date time, last updated date time) from Izenda system database to match user's local time zone
      -
   *  -  **initPassword** |br|
         boolean
      -
      -  Has the password been initialized for a new user
      -
   *  -  **active** |br|
         boolean
      -
      -  Is the user activated
      -
   *  -  **retryLoginTime** |br|
         integer
      -  Y
      -  The number of consecutive times that user fails to log in
      -
   *  -  **lastTimeAccessed** |br|
         datetime
      -  Y
      -  The time when user last accessed the system
      -
   *  -  **passwordLastChanged** |br|
         datetime
      -  Y
      -  The time when user last changed the password
      -
   *  -  **locked** |br|
         boolean
      -
      -  Is the user locked
      -
   *  -  **lockedDate** |br|
         datetime
      -  Y
      -  The time when user was locked
      -
   *  -  **cultureName** |br|
         string
      -
      -  The culture name
      -
   *  -  **securityQuestionLastChanged** |br|
         datetime
      -  Y
      -  The time when user last changed security questions
      -
   *  -  **dateFormat** |br|
         string
      -
      -  The user-selected date format
      -
   *  -  **systemAdmin** |br|
         boolean
      -
      -  Whether user is a system admin
      -
   *  -  **notAllowSharing** |br|
         boolean
      -
      -  Is sharing not allowed
      -
   *  -  **numberOfFailedSecurityQuestion** |br|
         integer
      -
      -  The number of security questions that user failed to answer
      -
   *  -  **fullName** |br|
         string
      -
      -  The full name
      -
   *  -  **currentModules** |br|
         array of strings
      -
      -  The list of assigned modules
      -



Inherited fields:

.. include:: Entity.rst
