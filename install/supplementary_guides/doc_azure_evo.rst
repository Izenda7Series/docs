=================================
Pdf Exports in Azure Websites
=================================
|
|

Introduction
------------------------------------------

Izenda utilizes the EVO HTML to PDF Converter for Azure to provide pdf exporting in Azure websites. This feature requires the use of an Azure Cloud Service. The high-level flow is illustrated below.

.. figure:: images/evo_azure_architecture.png


Installing and Configuring the Azure Service
----------------------------------------------------
|

Required Components
###############

There are two components needed for the Azure cloud service. 

| *EvoHtmlToPdfAzureService.cspkg*
| *ServiceConfiguration.Cloud.cscfg*
|

These components as well as the installation guide this document is based on can be downloaded freely at the link below: 
| http://www.evopdf.com/azure-html-to-pdf-converter.aspx

Installation
########

#. Login into your Microsoft Azure portal and create a new Cloud Service choosing the **Custom Create** option. 
#. In the first screen select a URL for your cloud service and enable the **Deploy a cloud service package** option. 
#. In the next screen choose a name for the deployment and browse to **Azure** local folder to choose the **EvoHtmlToPdfAzureService.cspkg** file for package option and **ServiceConfiguration.Cloud.cscfg** file for configuration option. Enable the **Deploy even if one or more roles contain a single instance** option and finish the wizard. The deployment process may take several minutes. 
#. When the deployment has completed, navigate to the cloud service dashboard. Under the input endpoints section, you can find the service IP address and port number. You will use this information configure Azure exporting in Izenda.

|

Configuring the Izenda instance
----------------------------------------------------
After the service has been configured, you must configure the Izenda application to use the service. The settings below are in the web.config file.

.. code-block:: xml

	<configuration>
	  <configSections>
	    <section name="evoPdfSettings" type="Izenda.BI.Framework.Models.Exporting.EvopdfConfiguration" /> 
	  </configSections>
	  <evoPdfSettings cloudEnable="true">
	    <azureCloudService server="120.0.0.1" port="40001" servicePassword="" />
	  </evoPdfSettings>
	</configuration>


