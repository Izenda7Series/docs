

====================
ValidateTokenResult
====================

.. list-table::
   :header-rows: 1
   :widths: 25 5 65 5

   *  -  Field
      -  NULL
      -  Description
      -  Note
   *  -  **Success** |br|
         boolean
      -
      -  The action result
      -
   *  -  **Messages** |br|
         array of strings
      -
      -  An array of error messages in case the action failed
      -
   *  -  **LicenseKey** |br|
         string
      -
      -  The license key
      -
   *  -  **TokenKey** |br|
         string
      -
      -  The token
      -
   *  -  **StartDate** |br|
         datetime in ISO 8601 extended format
      -
      -  The start date of the token
      -
   *  -  **EndDate** |br|
         datetime in ISO 8601 extended format
      -
      -  The expiration datetime of the token |br| |br|
         In Online mode, the token lives much shorter than the license, so token's ``endDate`` is different from ``licenseEndDate``
      -
   *  -  **Modules** |br|
         array of objects
      -
      -  An array of Module objects with **Id** and **Name** fields
      -
   *  -  **CompanyId** |br|
         string (GUID)
      -
      -  The id of the company
      -
   *  -  **PreviousStartDate** |br|
         datetime in ISO 8601 extended format
      -
      -  The previous start date in case this license was re-newed
      -
   *  -  **PreviousModules** |br|
         array of objects
      -
      -  An array of previous Module objects with **Id** and **Name** fields
      -
   *  -  **LicenseOnlineMode** |br|
         boolean
      -
      -  true means online and false means offline
      -
   *  -  **LicenseTrial** |br|
         boolean
      -
      -  Is this a trial license
      -
   *  -  **LicenseEnable** |br|
         boolean
      -
      -  Is the license enabled (for Offline mode) |br| |br|
         In online mode it is always enabled.
      -
   *  -  **LicenseEndDate** |br|
         datetime in ISO 8601 extended format
      -
      -  The end date of the license
      -
   *  -  **NumberOfDayToValid** |br|
         integer
      -
      -  The number of days until the token starts |br| |br|
         0 if the token has already started
      -

.. container:: toggle

   .. container:: header

      **Sample**:

   .. code-block:: json

      {
         "tokenKey":"1aBcD+=",
         "licenseKey":"1aBcD+=",
         "startDate":"2016-03-01T00:00:00",
         "endDate":"2017-03-01T23:59:59",
         "modules":[
            {
                 "id":"256b555f-58ef-4418-be6c-048d2fc1f691",
                 "name":"Alerting"
            }
         ],
         "companyId":"70d1037a-401a-446b-ae10-a5bb0144c611",
         "previousStartDate":null,
         "previousEndDate":null,
         "previousModules":null,
         "licenseOnlineMode":false,
         "licenseTrial":false,
         "licenseEnable":true,
         "licenseEndDate":"2017-03-01T23:59:59",
         "numberOfDayToValid":0,
         "success":true,
         "messages":null
      }
