﻿<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="WebServiceBuscoChoza" generation="1" functional="0" release="0" Id="588a564a-1282-4af6-bc05-0dd51449c259" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="WebServiceBuscoChozaGroup" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="BackEndBuscoChoza:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/WebServiceBuscoChoza/WebServiceBuscoChozaGroup/LB:BackEndBuscoChoza:Endpoint1" />
          </inToChannel>
        </inPort>
        <inPort name="FrontEndBuscoChoza:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/WebServiceBuscoChoza/WebServiceBuscoChozaGroup/LB:FrontEndBuscoChoza:Endpoint1" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="BackEndBuscoChoza:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/WebServiceBuscoChoza/WebServiceBuscoChozaGroup/MapBackEndBuscoChoza:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="BackEndBuscoChozaInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/WebServiceBuscoChoza/WebServiceBuscoChozaGroup/MapBackEndBuscoChozaInstances" />
          </maps>
        </aCS>
        <aCS name="FrontEndBuscoChoza:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/WebServiceBuscoChoza/WebServiceBuscoChozaGroup/MapFrontEndBuscoChoza:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="FrontEndBuscoChozaInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/WebServiceBuscoChoza/WebServiceBuscoChozaGroup/MapFrontEndBuscoChozaInstances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:BackEndBuscoChoza:Endpoint1">
          <toPorts>
            <inPortMoniker name="/WebServiceBuscoChoza/WebServiceBuscoChozaGroup/BackEndBuscoChoza/Endpoint1" />
          </toPorts>
        </lBChannel>
        <lBChannel name="LB:FrontEndBuscoChoza:Endpoint1">
          <toPorts>
            <inPortMoniker name="/WebServiceBuscoChoza/WebServiceBuscoChozaGroup/FrontEndBuscoChoza/Endpoint1" />
          </toPorts>
        </lBChannel>
      </channels>
      <maps>
        <map name="MapBackEndBuscoChoza:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/WebServiceBuscoChoza/WebServiceBuscoChozaGroup/BackEndBuscoChoza/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapBackEndBuscoChozaInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/WebServiceBuscoChoza/WebServiceBuscoChozaGroup/BackEndBuscoChozaInstances" />
          </setting>
        </map>
        <map name="MapFrontEndBuscoChoza:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/WebServiceBuscoChoza/WebServiceBuscoChozaGroup/FrontEndBuscoChoza/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapFrontEndBuscoChozaInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/WebServiceBuscoChoza/WebServiceBuscoChozaGroup/FrontEndBuscoChozaInstances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="BackEndBuscoChoza" generation="1" functional="0" release="0" software="D:\DS-BuscoChoza\WebServiceBuscoChoza\WebServiceBuscoChoza\csx\Debug\roles\BackEndBuscoChoza" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="1792" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="8080" />
            </componentports>
            <settings>
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;BackEndBuscoChoza&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;BackEndBuscoChoza&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;r name=&quot;FrontEndBuscoChoza&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="BackEndBuscoChoza.svclog" defaultAmount="[1000,1000,1000]" defaultSticky="true" kind="Directory" />
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/WebServiceBuscoChoza/WebServiceBuscoChozaGroup/BackEndBuscoChozaInstances" />
            <sCSPolicyUpdateDomainMoniker name="/WebServiceBuscoChoza/WebServiceBuscoChozaGroup/BackEndBuscoChozaUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/WebServiceBuscoChoza/WebServiceBuscoChozaGroup/BackEndBuscoChozaFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
        <groupHascomponents>
          <role name="FrontEndBuscoChoza" generation="1" functional="0" release="0" software="D:\DS-BuscoChoza\WebServiceBuscoChoza\WebServiceBuscoChoza\csx\Debug\roles\FrontEndBuscoChoza" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="1792" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="80" />
            </componentports>
            <settings>
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;FrontEndBuscoChoza&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;BackEndBuscoChoza&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;r name=&quot;FrontEndBuscoChoza&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/WebServiceBuscoChoza/WebServiceBuscoChozaGroup/FrontEndBuscoChozaInstances" />
            <sCSPolicyUpdateDomainMoniker name="/WebServiceBuscoChoza/WebServiceBuscoChozaGroup/FrontEndBuscoChozaUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/WebServiceBuscoChoza/WebServiceBuscoChozaGroup/FrontEndBuscoChozaFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyUpdateDomain name="FrontEndBuscoChozaUpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyUpdateDomain name="BackEndBuscoChozaUpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyFaultDomain name="BackEndBuscoChozaFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyFaultDomain name="FrontEndBuscoChozaFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="BackEndBuscoChozaInstances" defaultPolicy="[1,1,1]" />
        <sCSPolicyID name="FrontEndBuscoChozaInstances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="12bd42ca-b227-4015-b335-c206c75e53db" ref="Microsoft.RedDog.Contract\ServiceContract\WebServiceBuscoChozaContract@ServiceDefinition">
      <interfacereferences>
        <interfaceReference Id="75d95251-ac60-4f02-8af7-3f9bf3b78c34" ref="Microsoft.RedDog.Contract\Interface\BackEndBuscoChoza:Endpoint1@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/WebServiceBuscoChoza/WebServiceBuscoChozaGroup/BackEndBuscoChoza:Endpoint1" />
          </inPort>
        </interfaceReference>
        <interfaceReference Id="2c40bc03-56e9-41e9-98e4-a14e52ec963c" ref="Microsoft.RedDog.Contract\Interface\FrontEndBuscoChoza:Endpoint1@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/WebServiceBuscoChoza/WebServiceBuscoChozaGroup/FrontEndBuscoChoza:Endpoint1" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>