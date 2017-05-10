

============================
User APIs
============================

The User APIs are used in the log in, log out, user setup and migration features.

List of APIs
------------

.. list-table::
   :class: apitable
   :widths: 35 65
   :header-rows: 1

   * - API
     - Purpose
   * - `GET user/all/(tenant_id)`_
     - Returns an array of users, filtered by tenant_id if available.
   * - `POST user/load`_
     - Returns an array of users, with paging.
   * - `POST user/login`_
     - Performs login.
   * - `POST user/logout`_
     - Performs logout.
   * - `POST user`_
     - Saves a user.
   * - `POST user/userProfile`_
     - Saves a user profile.
   * - `POST user/passwordProfile`_
     - Saves a password profile.
   * - `POST user/securityQuesitions`_
     - Saves security questions for a user.

       .. note::

          Will be renamed to securityQuestions
   * - POST user/password
     - Saves password for a user.

       .. note::

          Obsolete, use `POST user/passwordAndSecurityQuestion`_ instead
   * - `POST user/active`_
     - Activates a user.
   * - `POST user/deactive`_
     - Deactivates a user.
   * - `DELETE user/{user_id}`_
     - Deletes a user.
   * - `POST user/passwordAndSecurityQuestion`_
     - Saves a user password and security question.
   * - `GET user/securityQuestion/{user_name}/(tenant_display_id)`_
     - Returns security question for a user and tenant.
   * - `POST user/generatePasswordLink`_
     - Generates :term:`password link`.
   * - `POST user/validatePasswordLink`_
     - Validates :term:`password link`.
   * - `POST user/validateSecurityQuestion`_
     - Validates security questions.
   * - `POST user/validateUserInfo`_
     - Validates user information.
   * - `POST user/validateExpirationPasswordLink`_
     - Validates password expiration link.
   * - `POST user/sendPasswordLink`_
     - Sends :term:`password link` via email to user.
   * - `POST user/integration/saveUser`_
     - Adds or updates external user.

       .. versionchanged:: 1.25

          Used to be named "intergration"
   * - `POST user/validateUserRoleAssociation`_
     - Validates user and role association after some roles are removed.
   * - `POST user/allowedSharingUsers/(tenant_id)`_
     - Returns a list of users allowed to be selected in report/dashboard access.
   * - `GET user/isLastSystemAdmin`_
     - Checks if the number of not deleted system admins equals 1.

GET user/all/(tenant_id)
--------------------------------------------------------------

Returns an array of users, filtered by tenant_id if available.

**Request**

    No payload

**Response**

    An array of :doc:`models/UserDetail` objects

**Samples**

   .. code-block:: http

      GET /api/user/all HTTP/1.1

   Sample response::

      [{
           "password" : null,
           "roles" : [],
           "userName" : "Anna",
           "emailAddress" : null,
           "firstName" : "An",
           "lastName" : "Na",
           "passwordHash" : null,
           "passwordSalt" : null,
           "currentTokenHash" : null,
           "tenantId" : null,
           "active" : false,
           "deleted" : false,
           "dataOffset" : 0,
           "timestampOffset" : 0,
           "fullName" : "An Na",
           "id" : "9f58703e-0dff-4690-9dc6-c595a6fd84e5",
           "state" : 0,
           "inserted" : true,
           "version" : 1,
           "created" : null,
           "createdBy" : null,
           "modified" : null,
           "modifiedBy" : null
        }, {
           "password" : null,
           "roles" : [{
                 "name" : "Singer",
                 "tenantId" : null,
                 "active" : false,
                 "deleted" : false,
                 "permissionData" : "",
                 "querySourceFields" : "",
                 "id" : "0d030b1a-9568-4c98-8b1e-5dcc94dbd283",
                 "state" : 0,
                 "inserted" : true,
                 "version" : 1,
                 "created" : null,
                 "createdBy" : null,
                 "modified" : null,
                 "modifiedBy" : null
              }
           ],
           "userName" : "Member1",
           "emailAddress" : "justin@thisispopstart.com",
           "firstName" : "Justin",
           "lastName" : "Timber",
           "passwordHash" : null,
           "passwordSalt" : null,
           "currentTokenHash" : null,
           "tenantId" : null,
           "active" : false,
           "deleted" : false,
           "dataOffset" : 0,
           "timestampOffset" : 0,
           "fullName" : "Justin Timber",
           "id" : "9f58703e-0dff-4690-9dc6-c595a6fd84e3",
           "state" : 0,
           "inserted" : true,
           "version" : 1,
           "created" : null,
           "createdBy" : null,
           "modified" : null,
           "modifiedBy" : null
        }, {
           "password" : null,
           "roles" : [{
                 "name" : "Analyst",
                 "tenantId" : null,
                 "active" : false,
                 "deleted" : false,
                 "permissionData" : "",
                 "querySourceFields" : "",
                 "id" : "0d030b1a-9568-4c98-8b1e-5dcc94dbd281",
                 "state" : 0,
                 "inserted" : true,
                 "version" : 1,
                 "created" : null,
                 "createdBy" : null,
                 "modified" : null,
                 "modifiedBy" : null
              }
           ],
           "userName" : "User1",
           "emailAddress" : "katty@email.com",
           "firstName" : "Katty",
           "lastName" : "Doe",
           "passwordHash" : null,
           "passwordSalt" : null,
           "currentTokenHash" : null,
           "tenantId" : null,
           "active" : false,
           "deleted" : false,
           "dataOffset" : 0,
           "timestampOffset" : 0,
           "fullName" : "Katty Doe",
           "id" : "9f58703e-0dff-4690-9dc6-c595a6fd84e1",
           "state" : 0,
           "inserted" : true,
           "version" : 1,
           "created" : null,
           "createdBy" : null,
           "modified" : null,
           "modifiedBy" : null
        }
      ]


POST user/load
--------------------------------------------------------------

Returns an array of users, with paging.

**Request**

    A :doc:`models/UserPagedRequest` object

**Response**

    A :doc:`models/PagedResult` object with **result** field containing an array of :doc:`models/UserDetail` objects

**Samples**

   .. code-block:: http

      POST /api/user/load HTTP/1.1

   Request payload::

      {
        "tenantId" : null,
        "criteria" : [{
              "key" : "All",
              "value" : "",
              "operation" : 1
           }
        ],
        "pageIndex" : 1,
        "pageSize" : 10,
        "sortOrders" : [{
              "key" : "userName",
              "descending" : true
           }
        ]
      }

   Sample response::

      {
        "result" : [{
              "password" : null,
              "roles" : [],
              "userName" : "Anna",
              "emailAddress" : null,
              "firstName" : "An",
              "lastName" : "Na",
              "tenantId" : null,
              "active" : false,
              "deleted" : false,
              "dataOffset" : 0,
              "timestampOffset" : 0,
              "fullName" : "An Na",
              "id" : "9f58703e-0dff-4690-9dc6-c595a6fd84e5",
              "state" : 0,
              "inserted" : true,
              "version" : null,
              "created" : null,
              "createdBy" : null,
              "modified" : null,
              "modifiedBy" : null
           }, {
              "password" : null,
              "roles" : [{
                    "name" : "Singer",
                    "tenantId" : null,
                    "active" : false,
                    "deleted" : false,
                    "id" : "0d030b1a-9568-4c98-8b1e-5dcc94dbd283",
                    "state" : 0,
                    "inserted" : true,
                    "version" : 1,
                    "created" : null,
                    "createdBy" : null,
                    "modified" : null,
                    "modifiedBy" : null
                 }
              ],
              "userName" : "Member1",
              "emailAddress" : "justin@thisispopstart.com",
              "firstName" : "Justin",
              "lastName" : "Timber",
              "tenantId" : null,
              "active" : false,
              "deleted" : false,
              "dataOffset" : 0,
              "timestampOffset" : 0,
              "fullName" : "Justin Timber",
              "id" : "9f58703e-0dff-4690-9dc6-c595a6fd84e3",
              "state" : 0,
              "inserted" : true,
              "version" : null,
              "created" : null,
              "createdBy" : null,
              "modified" : null,
              "modifiedBy" : null
           }, {
              "password" : null,
              "roles" : [{
                    "name" : "Analyst",
                    "tenantId" : null,
                    "active" : false,
                    "deleted" : false,
                    "id" : "0d030b1a-9568-4c98-8b1e-5dcc94dbd281",
                    "state" : 0,
                    "inserted" : true,
                    "version" : 1,
                    "created" : null,
                    "createdBy" : null,
                    "modified" : null,
                    "modifiedBy" : null
                 }
              ],
              "userName" : "User1",
              "emailAddress" : "katty@email.com",
              "firstName" : "Katty",
              "lastName" : "Doe",
              "tenantId" : null,
              "active" : false,
              "deleted" : false,
              "dataOffset" : 0,
              "timestampOffset" : 0,
              "fullName" : "Katty Doe",
              "id" : "9f58703e-0dff-4690-9dc6-c595a6fd84e1",
              "state" : 0,
              "inserted" : true,
              "version" : null,
              "created" : null,
              "createdBy" : null,
              "modified" : null,
              "modifiedBy" : null
           }
        ],
        "pageIndex" : 1,
        "pageSize" : 10,
        "total" : 3
      }


POST user/login
--------------------------------------------------------------

Performs login.

**Request**

    A :doc:`models/Credential` object

**Response**

    An :doc:`models/OperationResult` object with **success** field true and **data** field containing an :doc:`models/AccessToken` object

**Samples**

   .. code-block:: http

      POST /api/user/login HTTP/1.1

   Request payload::

      {
        "userName" : "johndoe",
        "password" : "secret"
      }

   Sample response::

      {
        "success" : true,
        "messages" : null,
        "data" : {
           "token" : "UWmQLI13sORSrN5VLodTxqO9e/yElV4RwRb2K6PzW6l4tYtw7kkbHH2Im9oQNxToVBHCihEIophicrWyCf6J7w==",
           "tenant" : null,
           "isExpired" : false,
           "notifyDuringDay" : null
        }
      }


POST user/logout
--------------------------------------------------------------

Performs logout.

**Request**

    No payload

**Response**

    * true if successful
    * false if not

**Samples**

   .. code-block:: http

      POST /api/user/logout HTTP/1.1

   Sample response::

      true

.. _POST_user:

POST user
--------------------------------------------------------------

Saves a user.

**Request**

    A :doc:`models/UserDetail` object

**Response**

     An :doc:`models/OperationResult` object with **success** field true and **data** field containing a :doc:`models/User` object

**Samples**

   .. code-block:: http

      POST /api/user HTTP/1.1

   Request payload::

      {
        "id" : null,
        "userName" : "jdoe",
        "tenantId" : null,
        "emailAddress" : "jdoe@acme.com",
        "roles" : [{
              "id" : "b992c772-6cb1-4103-b6b1-0da581368862"
           }
        ],
        "state" : null,
        "inserted" : null,
        "version" : null,
        "created" : null,
        "createdBy" : null,
        "modified" : null,
        "modifiedBy" : null,
        "lastName" : "Doe",
        "firstName" : "John",
        "fullName" : null,
        "active" : false,
        "password" : null,
        "passwordHash" : null,
        "passwordSalt" : null,
        "currentTokenHash" : null,
        "deleted" : false,
        "userSecurityQuestions" : null,
        "userRoles" : null,
        "dataOffset" : 0,
        "timestampOffset" : 0,
        "initPassword" : false,
        "status" : null
      }

   Sample response::

      {
        "success" : true,
        "messages" : null,
        "data" : {
           "password" : null,
           "roles" : [{
                 "name" : null,
                 "tenantId" : null,
                 "active" : false,
                 "id" : "b992c772-6cb1-4103-b6b1-0da581368862",
                 "state" : 0,
                 "deleted" : false,
                 "inserted" : true,
                 "version" : null,
                 "created" : null,
                 "createdBy" : "e5dabf75-c5b7-4877-86cc-b3afd83eed62",
                 "modified" : null,
                 "modifiedBy" : null
              }
           ],
           "userRoles" : [{
                 "userId" : "6c447061-8f1d-4ff4-803c-b6b15695b8c3",
                 "roleId" : "b992c772-6cb1-4103-b6b1-0da581368862",
                 "id" : "b15da0f4-d97d-4c78-bd52-22af0e02aae0",
                 "state" : 0,
                 "deleted" : false,
                 "inserted" : true,
                 "version" : 1,
                 "created" : "2016-10-10T07:50:26.2366983",
                 "createdBy" : "e5dabf75-c5b7-4877-86cc-b3afd83eed62",
                 "modified" : "2016-10-10T07:50:26.2366983",
                 "modifiedBy" : "e5dabf75-c5b7-4877-86cc-b3afd83eed62"
              }
           ],
           "userSecurityQuestions" : null,
           "status" : 3,
           "issueDate" : "0001-01-01T00:00:00",
           "autoLogin" : false,
           "newPassword" : null,
           "userName" : "jdoe",
           "emailAddress" : "jdoe@acme.com",
           "firstName" : "John",
           "lastName" : "Doe",
           "tenantId" : null,
           "tenantDisplayId" : null,
           "dataOffset" : 0,
           "timestampOffset" : 0,
           "initPassword" : false,
           "active" : false,
           "retryLoginTime" : null,
           "lastTimeAccessed" : null,
           "passwordActiveDate" : null,
           "locked" : null,
           "lockedDate" : null,
           "fullName" : "John Doe",
           "id" : "6c447061-8f1d-4ff4-803c-b6b15695b8c3",
           "state" : 0,
           "deleted" : false,
           "inserted" : false,
           "version" : 1,
           "created" : "2016-10-10T07:50:26.2366983",
           "createdBy" : "e5dabf75-c5b7-4877-86cc-b3afd83eed62",
           "modified" : "2016-10-10T07:50:26.2366983",
           "modifiedBy" : "e5dabf75-c5b7-4877-86cc-b3afd83eed62"
        }
      }


POST user/userProfile
--------------------------------------------------------------

Saves a user profile.

**Request**

    A :doc:`models/UserDetail` object

**Response**

    An :doc:`models/OperationResult` object with **success** field true and **data** field containing the saved :doc:`models/User` object

**Samples**

   .. code-block:: http

      POST /api/userProfile HTTP/1.1

   Request payload::

      {
        "id": "9fc0f5c2-decf-4d65-9344-c59a1704ea0c",
        "systemAdmin": true,
        "userName": "jdoe",
        "firstName": "John",
        "lastName": "Doe",
        "cultureName": "en-US",
        "dateFormat": "MM/DD/YYYY",
        "tenantId": null,
        "emailAddress": "jdoe@acme.com",
        "roles": [],
        "dataOffset": 0,
        "timestampOffset": 0,
        "tenantName": null,
        "hasChangeLanguage": false
      }

   Sample response::

      {
        "success": true,
        "messages": null,
        "data": {
          "password": "",
          "roles": [],
          "userRoles": null,
          "userSecurityQuestions": null,
          "status": 3,
          "issueDate": "0001-01-01T00:00:00",
          "autoLogin": false,
          "newPassword": null,
          "userName": "jdoe",
          "emailAddress": "jdoe@acme.com",
          "firstName": "John",
          "lastName": "Doe",
          "tenantId": null,
          "tenantDisplayId": null,
          "tenantName": null,
          "dataOffset": 0,
          "timestampOffset": 0,
          "initPassword": false,
          "active": false,
          "retryLoginTime": null,
          "lastTimeAccessed": null,
          "passwordLastChanged": null,
          "locked": null,
          "lockedDate": null,
          "cultureName": "en-US",
          "securityQuestionLastChanged": null,
          "dateFormat": "MM/DD/YYYY",
          "systemAdmin": true,
          "notAllowSharing": false,
          "numberOfFailedSecurityQuestion": null,
          "fullName": "John Doe",
          "currentModules": null,
          "id": "9fc0f5c2-decf-4d65-9344-c59a1704ea0c",
          "state": 0,
          "deleted": false,
          "inserted": true,
          "version": null,
          "created": null,
          "createdBy": "John Doe",
          "modified": null,
          "modifiedBy": null
        }
      }


POST user/passwordProfile
--------------------------------------------------------------

Saves a password profile.

**Request**

    A :doc:`models/UserDetail` object

**Response**

    An :doc:`models/OperationResult` object with **success** field true and **data** field containing an :doc:`models/AccessToken` object

**Samples**

   .. code-block:: http

      POST /api/user/passwordProfile HTTP/1.1

   Request payload::

      {
        "newPassword": "secret",
        "password": "secret",
        "userName": "jdoe",
        "id": "9fc0f5c2-decf-4d65-9344-c59a1704ea0c"
      }

   Sample response::

      {
        "success": true,
        "messages": null,
        "data": {
          "token": "123Abc..=",
          "tenant": null,
          "cultureName": "en-US",
          "dateFormat": "MM/DD/YYYY",
          "isExpired": false,
          "notifyDuringDay": null
        }
      }


POST user/securityQuesitions
--------------------------------------------------------------

Saves security questions for a user.

**Request**

    A :doc:`models/UserDetail` object

**Response**

    An :doc:`models/OperationResult` object with **success** field true and **data** field containing the updated :doc:`models/UserDetail` object

**Samples**

   .. code-block:: http

      POST /api/user/securityQuestions HTTP/1.1

   Request payload::

      {
        "userSecurityQuestions": [
          {
            "securityQuestionId": "5784ece5-d2e7-42b1-89bb-859737b7b2a9",
            "answer": "Jenny Doe"
          },
          {
            "securityQuestionId": "3771bdc2-1add-481a-9649-18a7e494860b",
            "answer": "911"
          }
        ],
        "userName": "jdoe",
        "id": "9fc0f5c2-decf-4d65-9344-c59a1704ea0c"
      }

   Sample response::

      {
        "success": true,
        "messages": null,
        "data": {
          "password": null,
          "roles": [],
          "userRoles": null,
          "userSecurityQuestions": [
            {
              "userId": "9fc0f5c2-decf-4d65-9344-c59a1704ea0c",
              "securityQuestionId": "5784ece5-d2e7-42b1-89bb-859737b7b2a9",
              "question": null,
              "id": "b3131be9-e39a-46b2-aa59-dc112fcff5f0",
              "state": 0,
              "deleted": false,
              "inserted": true,
              "version": 1,
              "created": "2017-01-06T07:48:13.281359",
              "createdBy": "John Doe",
              "modified": "2017-01-06T07:48:13.281359",
              "modifiedBy": "John Doe"
            },
            {
              "userId": "9fc0f5c2-decf-4d65-9344-c59a1704ea0c",
              "securityQuestionId": "3771bdc2-1add-481a-9649-18a7e494860b",
              "question": null,
              "id": "c50a5b68-20b2-4c0d-b8f0-20072104ac51",
              "state": 0,
              "deleted": false,
              "inserted": true,
              "version": 1,
              "created": "2017-01-06T07:48:13.281359",
              "createdBy": "John Doe",
              "modified": "2017-01-06T07:48:13.281359",
              "modifiedBy": "John Doe"
            }
          ],
          "status": 3,
          "issueDate": "0001-01-01T00:00:00",
          "autoLogin": false,
          "newPassword": null,
          "userName": "jdoe",
          "emailAddress": null,
          "firstName": null,
          "lastName": null,
          "tenantId": null,
          "tenantDisplayId": null,
          "tenantName": null,
          "dataOffset": 0,
          "timestampOffset": 0,
          "initPassword": false,
          "active": false,
          "retryLoginTime": null,
          "lastTimeAccessed": null,
          "passwordLastChanged": null,
          "locked": null,
          "lockedDate": null,
          "cultureName": null,
          "securityQuestionLastChanged": "2017-01-06T07:48:13.2387372",
          "dateFormat": null,
          "systemAdmin": false,
          "notAllowSharing": false,
          "numberOfFailedSecurityQuestion": null,
          "fullName": "jdoe",
          "currentModules": null,
          "id": "9fc0f5c2-decf-4d65-9344-c59a1704ea0c",
          "state": 0,
          "deleted": false,
          "inserted": true,
          "version": null,
          "created": null,
          "createdBy": "John Doe",
          "modified": null,
          "modifiedBy": null
        }
      }


POST user/active
--------------------------------------------------------------

Activates a user.

**Request**

    A :doc:`models/UserDetail` object

**Response**

    The updated :doc:`models/UserDetail` object

**Samples**

   .. code-block:: http

      POST /api/user/active HTTP/1.1

   Request payload::

      {
        "isDirty" : false,
        "id" : "6c447061-8f1d-4ff4-803c-b6b15695b8c3",
        "userName" : "jdoe",
        "password" : null,
        "tenantId" : null,
        "emailAddress" : "jdoe@acme.com",
        "roles" : [{
              "name" : "CreateUserRole",
              "tenantId" : null,
              "active" : true,
              "id" : "b992c772-6cb1-4103-b6b1-0da581368862",
              "state" : 0,
              "deleted" : false,
              "inserted" : true,
              "version" : 1,
              "created" : "2016-10-10T07:25:55.653",
              "createdBy" : "9d2f1d51-0e3d-44db-bfc7-da94a7581bfe",
              "modified" : "2016-10-10T07:25:55.653",
              "modifiedBy" : "9d2f1d51-0e3d-44db-bfc7-da94a7581bfe"
           }
        ],
        "state" : 0,
        "inserted" : true,
        "version" : 2,
        "created" : "2016-10-10T07:50:26.237",
        "createdBy" : "e5dabf75-c5b7-4877-86cc-b3afd83eed62",
        "modified" : "2016-10-10T08:31:13.89",
        "modifiedBy" : "e5dabf75-c5b7-4877-86cc-b3afd83eed62",
        "selected" : true,
        "lastName" : "Doe",
        "firstName" : "John",
        "fullName" : "John Doe",
        "active" : false,
        "initPassword" : true,
        "deleted" : false,
        "userSecurityQuestions" : null,
        "userRoles" : null,
        "dataOffset" : 0,
        "timestampOffset" : 0,
        "passwordLink" : null,
        "failedlogin" : false,
        "status" : 2,
        "rolesValue" : "b992c772-6cb1-4103-b6b1-0da581368862",
        "recipientValue" : [],
        "clearSercurityQuestion" : false,
        "sendEmail" : false
      }

   Sample response::

      {
        "password" : null,
        "roles" : [{
              "name" : "CreateUserRole",
              "tenantId" : null,
              "active" : true,
              "id" : "b992c772-6cb1-4103-b6b1-0da581368862",
              "state" : 0,
              "deleted" : false,
              "inserted" : true,
              "version" : 1,
              "created" : "2016-10-10T07:25:55.653",
              "createdBy" : "9d2f1d51-0e3d-44db-bfc7-da94a7581bfe",
              "modified" : "2016-10-10T07:25:55.653",
              "modifiedBy" : "9d2f1d51-0e3d-44db-bfc7-da94a7581bfe"
           }
        ],
        "userRoles" : null,
        "userSecurityQuestions" : null,
        "status" : 1,
        "issueDate" : "0001-01-01T00:00:00",
        "autoLogin" : false,
        "newPassword" : null,
        "userName" : "jdoe",
        "emailAddress" : "jdoe@acme.com",
        "firstName" : "John",
        "lastName" : "Doe",
        "tenantId" : null,
        "tenantDisplayId" : null,
        "dataOffset" : 0,
        "timestampOffset" : 0,
        "initPassword" : true,
        "active" : true,
        "retryLoginTime" : null,
        "lastTimeAccessed" : null,
        "passwordActiveDate" : null,
        "locked" : null,
        "lockedDate" : null,
        "fullName" : "John Doe",
        "id" : "6c447061-8f1d-4ff4-803c-b6b15695b8c3",
        "state" : 0,
        "deleted" : false,
        "inserted" : true,
        "version" : 2,
        "created" : "2016-10-10T07:50:26.237",
        "createdBy" : "e5dabf75-c5b7-4877-86cc-b3afd83eed62",
        "modified" : "2016-10-10T08:31:13.89",
        "modifiedBy" : "e5dabf75-c5b7-4877-86cc-b3afd83eed62"
      }


POST user/deactive
--------------------------------------------------------------

Deactivates a user.

**Request**

    A :doc:`models/UserDetail` object

**Response**

    The updated :doc:`models/UserDetail` object

**Samples**

   .. code-block:: http

      POST /api/user/deactive HTTP/1.1

   Request payload::

      {
        "isDirty" : false,
        "id" : "6c447061-8f1d-4ff4-803c-b6b15695b8c3",
        "userName" : "jdoe",
        "password" : null,
        "tenantId" : null,
        "emailAddress" : "jdoe@acme.com",
        "roles" : [{
              "name" : "CreateUserRole",
              "tenantId" : null,
              "active" : true,
              "id" : "b992c772-6cb1-4103-b6b1-0da581368862",
              "state" : 0,
              "deleted" : false,
              "inserted" : true,
              "version" : 1,
              "created" : "2016-10-10T07:25:55.653",
              "createdBy" : "9d2f1d51-0e3d-44db-bfc7-da94a7581bfe",
              "modified" : "2016-10-10T07:25:55.653",
              "modifiedBy" : "9d2f1d51-0e3d-44db-bfc7-da94a7581bfe"
           }
        ],
        "state" : 0,
        "inserted" : true,
        "version" : 2,
        "created" : "2016-10-10T07:50:26.237",
        "createdBy" : "e5dabf75-c5b7-4877-86cc-b3afd83eed62",
        "modified" : "2016-10-10T08:31:13.89",
        "modifiedBy" : "e5dabf75-c5b7-4877-86cc-b3afd83eed62",
        "selected" : true,
        "lastName" : "Doe",
        "firstName" : "John",
        "fullName" : "John Doe",
        "active" : true,
        "initPassword" : true,
        "deleted" : false,
        "userSecurityQuestions" : null,
        "userRoles" : null,
        "dataOffset" : 0,
        "timestampOffset" : 0,
        "passwordLink" : null,
        "failedlogin" : false,
        "status" : 1,
        "rolesValue" : "b992c772-6cb1-4103-b6b1-0da581368862",
        "recipientValue" : [],
        "clearSercurityQuestion" : false,
        "sendEmail" : false
      }

   Sample response::

      {
        "password" : null,
        "roles" : [{
              "name" : "CreateUserRole",
              "tenantId" : null,
              "active" : true,
              "id" : "b992c772-6cb1-4103-b6b1-0da581368862",
              "state" : 0,
              "deleted" : false,
              "inserted" : true,
              "version" : 1,
              "created" : "2016-10-10T07:25:55.653",
              "createdBy" : "9d2f1d51-0e3d-44db-bfc7-da94a7581bfe",
              "modified" : "2016-10-10T07:25:55.653",
              "modifiedBy" : "9d2f1d51-0e3d-44db-bfc7-da94a7581bfe"
           }
        ],
        "userRoles" : null,
        "userSecurityQuestions" : null,
        "status" : 2,
        "issueDate" : "0001-01-01T00:00:00",
        "autoLogin" : false,
        "newPassword" : null,
        "userName" : "jdoe",
        "emailAddress" : "jdoe@acme.com",
        "firstName" : "John",
        "lastName" : "Doe",
        "tenantId" : null,
        "tenantDisplayId" : null,
        "dataOffset" : 0,
        "timestampOffset" : 0,
        "initPassword" : true,
        "active" : false,
        "retryLoginTime" : null,
        "lastTimeAccessed" : null,
        "passwordActiveDate" : null,
        "locked" : null,
        "lockedDate" : null,
        "fullName" : "John Doe",
        "id" : "6c447061-8f1d-4ff4-803c-b6b15695b8c3",
        "state" : 0,
        "deleted" : false,
        "inserted" : true,
        "version" : 2,
        "created" : "2016-10-10T07:50:26.237",
        "createdBy" : "e5dabf75-c5b7-4877-86cc-b3afd83eed62",
        "modified" : "2016-10-10T08:31:13.89",
        "modifiedBy" : "e5dabf75-c5b7-4877-86cc-b3afd83eed62"
      }


DELETE user/{user_id}
--------------------------------------------------------------

Deletes a user.

**Request**

    No payload

**Response**

    * true if user was successfully deleted
    * false if not

**Samples**

   .. code-block:: http

      DELETE /api/user/2727bb4a-ee5c-4f55-8ec3-dd73f4ffd440 HTTP/1.1

   Sample response::

      true

.. _POST_user/passwordAndSecurityQuestion:

POST user/passwordAndSecurityQuestion
--------------------------------------------------------------

Saves a user password and security question.

**Request**

    A :doc:`models/UserDetail` object

**Response**

    An :doc:`models/OperationResult` object with **success** field true and **data** field containing an :doc:`models/AccessToken` object

**Samples**

   .. code-block:: http

      POST /api/user/passwordAndSecurityQuestion HTTP/1.1

   Request payload::

      {
        "tenantDisplayID" : null,
        "password" : "secret",
        "verification" : "H8K...swUc=",
        "userName" : "jdoe",
        "firstName" : "John",
        "lastName" : "Doe",
        "emailAddress" : "jdoe@acme.com",
        "userSecurityQuestions" : [],
        "autoLogin" : true
      }

   Sample response::

      {
        "success" : true,
        "messages" : null,
        "data" : {
           "token" : "3AfY....yKg==",
           "tenant" : null,
           "isExpired" : false,
           "notifyDuringDay" : null
        }
      }


GET user/securityQuestion/{user_name}/(tenant_display_id)
--------------------------------------------------------------

Returns security question for a user and tenant.

**Request**

    No payload

**Response**

    An :doc:`models/OperationResult` object with **success** field true and **data** field containing an :doc:`models/AccessToken` object

**Samples**

   .. code-block:: http

      GET /api/user/securityQuestion/jdoe HTTP/1.1

   Sample response::

      {
       "success": true,
       "messages": null,
       "data": [
         {
           "userId": "9fc0f5c2-decf-4d65-9344-c59a1704ea0c",
           "securityQuestionId": "3771bdc2-1add-481a-9649-18a7e494860b",
           "question": "Which phone number do you remember most from your childhood?",
           "id": "c50a5b68-20b2-4c0d-b8f0-20072104ac51",
           "state": 0,
           "deleted": false,
           "inserted": true,
           "version": 1,
           "created": "2017-01-06T07:48:13.28",
           "createdBy": "John Doe",
           "modified": "2017-01-06T07:48:13.28",
           "modifiedBy": "John Doe"
         }
       ]
      }

.. _POST_user/generatePasswordLink:

POST user/generatePasswordLink
--------------------------------------------------------------

Generates :term:`password link`.

**Request**

    A :doc:`models/UserDetail` object

**Response**

    An :doc:`models/OperationResult` object with **success** field true and **data** field containing a hash value from the user details.

**Samples**

   .. code-block:: http

      POST /api/user/generatePasswordLink HTTP/1.1

   Request payload::

      {
        "id" : "6c447061-8f1d-4ff4-803c-b6b15695b8c3",
        "username" : "jdoe",
        "firstname" : "John",
        "lastname" : "Doe",
        "emailaddress" : "jdoe@acme.com"
      }

   Sample response::

      {
         "success": true,
         "messages": null,
         "data": "Abc/Def/..=="
      }


POST user/validatePasswordLink
--------------------------------------------------------------

Validates :term:`password link`.

**Request**

    A :doc:`models/UserVerification` object

**Response**

    An :doc:`models/OperationResult` object with **success** field true and **data** field containing the :doc:`models/UserVerification` object

**Samples**

   .. code-block:: http

      POST /api/user/validatePasswordLink HTTP/1.1

   Request payload::

      {
        "tenantDisplayID" : null,
        "userName" : "jdoe",
        "firstName" : "John",
        "lastName" : "Doe",
        "emailAddress" : "jdoe@acme.com",
        "verification" : "H8K....RU="
      }


POST user/validateSecurityQuestion
--------------------------------------------------------------

Validates security questions.

**Request**

    A :doc:`models/UserDetail` object

**Response**

    An :doc:`models/OperationResult` object with **success** field true if the question and answers are valid

**Samples**

   .. code-block:: http

      POST /api/user/validateSecurityQuestion HTTP/1.1

   Request payload::

      {
        "tenantDisplayID": null,
        "userName": "jdoe",
        "userSecurityQuestions": [
          {
            "userId": "9fc0f5c2-decf-4d65-9344-c59a1704ea0c",
            "securityQuestionId": "5784ece5-d2e7-42b1-89bb-859737b7b2a9",
            "answer": "Jenny Doe"
          }
        ]
      }

   Sample response::

      {
        "success": true,
        "messages": null,
        "data": null
      }


POST user/validateUserInfo
--------------------------------------------------------------

Validates user information.

**Request**

    A :doc:`models/UserDetail` object

**Response**

    An :doc:`models/OperationResult` object with **success** field true and **data** field containing a :doc:`models/User` object

**Samples**

   .. code-block:: http

      POST /api/user/validateUserInfo HTTP/1.1

   Request payload::

      {
        "tenantName": "",
        "userName": "jdoe",
        "firstName": "John",
        "lastName": "Doe",
        "emailAddress": "jdoe@acme.com",
        "verification": ""
      }

   Sample response::

      {
        "success": true,
        "messages": null,
        "data": {
          "userName": "jdoe",
          "emailAddress": "jdoe@acme.com",
          "firstName": "John",
          "lastName": "Doe",
          "tenantId": null,
          "tenantDisplayId": null,
          "tenantName": null,
          "dataOffset": 0,
          "timestampOffset": 0,
          "initPassword": true,
          "active": true,
          "retryLoginTime": 0,
          "lastTimeAccessed": "2017-01-06T08:18:22.393",
          "passwordLastChanged": "2017-01-06T07:45:58.813",
          "locked": false,
          "lockedDate": null,
          "cultureName": "en-US",
          "securityQuestionLastChanged": "2017-01-06T07:48:13.24",
          "dateFormat": "MM/DD/YYYY",
          "systemAdmin": true,
          "notAllowSharing": false,
          "numberOfFailedSecurityQuestion": 0,
          "fullName": "John Doe",
          "currentModules": null,
          "id": "9fc0f5c2-decf-4d65-9344-c59a1704ea0c",
          "state": 0,
          "deleted": false,
          "inserted": true,
          "version": 14,
          "created": "2016-11-21T06:58:27.203",
          "createdBy": "9d2f1d51-0e3d-44db-bfc7-da94a7581bfe",
          "modified": "2017-01-06T08:18:26.077",
          "modifiedBy": "9d2f1d51-0e3d-44db-bfc7-da94a7581bfe"
        }
      }


POST user/validateExpirationPasswordLink
--------------------------------------------------------------

Validates password expiration link.

**Request**

    A :doc:`models/UserDetail` object

**Response**

    An :doc:`models/OperationResult` object with **success** field true and **data** field containing a :doc:`models/ValidateExpiration` object

**Samples**

   .. code-block:: http

      POST /api/user/validateExpirationPasswordLink HTTP/1.1

   Request payload::

      {
        "verification" : "H8K....Uc="
      }

   Sample response::

      {
        "success" : true,
        "messages" : null,
        "data" : {
           "tenantId" : null,
           "isExpired" : false,
           "notifyDuringDay" : null
        }
      }


POST user/sendPasswordLink
--------------------------------------------------------------

Sends :term:`password link` via email to user.

**Request**

    Payload: a :doc:`models/PasswordOption` object

**Response**

    * true if the action was successful
    * false if not

**Samples**

   .. code-block:: http

      POST /api/user/sendPasswordLink HTTP/1.1

   Request payload::

      {
        "passwordLink" : "http://127.0.0.1:8888/account/activation?verification=H8K....RU%3D",
        "user" : {
           "userName" : "jdoe",
           "id" : "6c447061-8f1d-4ff4-803c-b6b15695b8c3"
        },
        "sendEmail" : false,
        "clearSercurityQuestion" : false,
        "emailAddresses" : ["jdoe@acme.com"]
      }

   Sample response::

      true


POST user/integration/saveUser
--------------------------------------------------------------

Adds or updates external user.

**Request**

    A :doc:`models/UserDetail` object

**Response**

    * true if the operation is successful
    * an error if not

**Samples**

   To be updated


POST user/validateUserRoleAssociation
--------------------------------------------------------------

Validates user and role association after some roles are removed.

**Request**

    A :doc:`models/ValidateUserRoleAssociationParam` object

**Response**

    * true if valid
    * false if not

**Samples**

   To be updated

POST user/allowedSharingUsers/(tenant_id)
--------------------------------------------------------------

Returns a list of users allowed to be selected in report/dashboard access.

**Request**

    Payload: a :doc:`models/SharingRoleUserParameter` object

**Response**

    An array of :doc:`models/UserDetail` objects

**Samples**

   .. code-block:: http

      POST /api/user/allowedSharingUsers HTTP/1.1

   Request payload::

      {
         "reportId":"45f17b8a-3708-4f36-80ef-9178b7124841"
      }

   Sample response::

      [
       {
         "password": null,
         "roles": [],
         "userRoles": null,
         "userSecurityQuestions": null,
         "status": 1,
         "issueDate": "0001-01-01T00:00:00",
         "autoLogin": false,
         "newPassword": null,
         "userName": "jdoe",
         "emailAddress": "jdoe@acme.com",
         "firstName": "John",
         "lastName": "Doe",
         "tenantId": null,
         "tenantDisplayId": null,
         "tenantName": null,
         "dataOffset": 0,
         "timestampOffset": 0,
         "initPassword": true,
         "active": true,
         "retryLoginTime": 0,
         "lastTimeAccessed": "2017-01-06T08:16:21.593",
         "passwordLastChanged": "2017-01-06T07:45:58.813",
         "locked": false,
         "lockedDate": null,
         "cultureName": "en-US",
         "securityQuestionLastChanged": "2017-01-06T07:48:13.24",
         "dateFormat": "MM/DD/YYYY",
         "systemAdmin": true,
         "notAllowSharing": false,
         "numberOfFailedSecurityQuestion": 0,
         "fullName": "John Doe",
         "currentModules": null,
         "id": "9fc0f5c2-decf-4d65-9344-c59a1704ea0c",
         "state": 0,
         "deleted": false,
         "inserted": true,
         "version": 14,
         "created": "2016-11-21T06:58:27.203",
         "createdBy": "9d2f1d51-0e3d-44db-bfc7-da94a7581bfe",
         "modified": "2017-01-06T08:14:42.863",
         "modifiedBy": "9d2f1d51-0e3d-44db-bfc7-da94a7581bfe"
       },
       {
         "password": null,
         "roles": [],
         "userRoles": null,
         "userSecurityQuestions": null,
         "status": 1,
         "issueDate": "0001-01-01T00:00:00",
         "autoLogin": false,
         "newPassword": null,
         "userName": "IzendaAdmin",
         "emailAddress": null,
         "firstName": "System",
         "lastName": "Admin",
         "tenantId": null,
         "tenantDisplayId": null,
         "tenantName": null,
         "dataOffset": 0,
         "timestampOffset": 0,
         "initPassword": true,
         "active": true,
         "retryLoginTime": 0,
         "lastTimeAccessed": "2017-01-05T03:58:35.073",
         "passwordLastChanged": null,
         "locked": null,
         "lockedDate": null,
         "cultureName": null,
         "securityQuestionLastChanged": null,
         "dateFormat": "MM/DD/YYYY",
         "systemAdmin": true,
         "notAllowSharing": false,
         "numberOfFailedSecurityQuestion": 0,
         "fullName": "System Admin",
         "currentModules": null,
         "id": "9d2f1d51-0e3d-44db-bfc7-da94a7581bfe",
         "state": 0,
         "deleted": false,
         "inserted": true,
         "version": 1,
         "created": null,
         "createdBy": "John Doe",
         "modified": "2017-01-05T03:58:49.12",
         "modifiedBy": null
       }
      ]


GET user/isLastSystemAdmin
--------------------------------------------------------------

Checks if the number of not deleted system admins equals 1.

**Request**

    No payload

**Response**

    An :doc:`models/OperationResult` object with **success** field true and **data** field true if the number of not deleted system admins equals 1

**Samples**

   .. code-block:: http

      GET /api/user/isLastSystemAdmin HTTP/1.1

   Sample response::

      {
        "success" : true,
        "data" : false
      }
