=================================
HTTP
=================================
|

405 Method Not Allowed 
--------------------------------

If you encounter errors stating that certain HTTP methods are not allowed, please ensure that you have set the headers required by Izenda for your API instance. The current values are below:

.. code-block:: xml
	
	<add name="Access-Control-Allow-Headers" value="Accept, Origin, Content-Type, access_token, current_tenant" />
	<add name="Access-Control-Allow-Methods" value="GET, POST, PUT, DELETE, OPTIONS" />

.. Note::

   These values may change in a future release, please be sure to review the release notes before upgrading.