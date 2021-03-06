# CustomConfigSectionPOC

## Reading Custom 'Section' config from App.config file using C#.NET

### Reading a Custom Configuration which is deep in hierarchy.

#### Configuration File (App.config)
```
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <configSections>
    <!--<section name="<Name of section>" type="<PackagenameIfAny.NameOfYourClassWhichInheritsFromConfigurationSectionClass>, <AssemblyNameWhereThisClassIsPresent>" />-->
    <section name="QAQCConfigSection" type="QA_QC_GIS_Config.Config.QAQCConfigSection, QA_QC_GIS_Config"/>
  </configSections>

  <QAQCConfigSection>
    <bundles>
      <bundle name="bundle1" alias="Wells and Flowlines">
        <layers>
          <layer name="Wells">
            <fields>
              <field key="wells_Fld_Uwi" value="UWI"/>
              <field key="wells_Fld_Type" value="Type"/>
              <field key="wells_Fld_Status" value="Status"/>
              <field key="wells_Fld_Product" value="Product"/>
              <field key="wells_Fld_ConceptName" value="ConceptName"/>
            </fields>
          </layer>
          <layer name="WellFence"/>
          <layer name="WellPad" />
          <layer name="Flowlines">
            <fields>
              <field key="flowLines_Fld_Uwi" value="UWI"/>
              <field key="flowLines_Fld_Type" value="Type"/>
              <field key="flowLines_Fld_Status" value="Status"/>
              <field key="flowLines_Fld_Product" value="Product"/>
              <field key="flowLines_Fld_From2" value="From2"/>
              <field key="flowLines_Fld_To" value="TO_"/>
              <field key="flowLines_Fld_Via" value="VIA"/>
              <field key="flowLines_Fld_Slot" value="Slot"/>
              <field key="flowLines_Fld_SurveyDate" value="SurveyDate"/>
              <field key="flowLines_Fld_Diameter" value="Diameter"/>
            </fields>
          </layer>
          <layer name="BOPBurnPits" />
          <layer name="FLFittings" />
        </layers>
      </bundle>

      <bundle name="bundle2" alias="Pipeline Data">
        <layers>
          <layer name="PLFittings">
            <fields>
              <field key="plFittings_Fld_Type" value="Type"/>
              <field key="plFittings_Fld_Facility" value="Facility"/>
              <field key="plFittings_Fld_Status" value="Status"/>
              <field key="plFittings_Fld_OperationalAreas" value="OperationalArea"/>
            </fields>
          </layer>
          <layer name="GroundBed">
            <fields>
              <field key="groundBed_Fld_Name" value="Name"/>
              <field key="groundBed_Fld_Status" value="Status"/>
              <field key="groundBed_Fld_OperationalAreas" value="OperationalAreas"/>
            </fields>
          </layer>
          <layer name="Flare">
            <fields>
              <field key="flare_Fld_Facility" value="Facility"/>
              <field key="flare_Fld_Status" value="Status"/>
              <field key="flare_Fld_OperationalAreas" value="OperationalArea"/>
            </fields>
          </layer>
          <layer name="CPCable">
            <fields>
              <field key="cpCable_Fld_Status" value="Status"/>
              <field key="cpCable_Fld_OperationalAreas" value="OperationalArea"/>
            </fields>
          </layer>
          <layer name="TransitLines">
            <fields>
              <field key="transitLines_Fld_FromFacility" value="FromFacility"/>
              <field key="transitLines_Fld_ToFacility" value="ToFacility"/>
              <field key="transitLines_Fld_Name" value="Name"/>
              <field key="transitLines_Fld_Facility" value="Facility"/>
              <field key="transitLines_Fld_Status" value="Status"/>
              <field key="transitLines_Fld_Product" value="Product"/>
              <field key="transitLines_Fld_Diameter" value="Diameter"/>
              <field key="transitLines_Fld_OperationalAreas" value="OperationalAreas"/>
            </fields>
          </layer>
          <layer name="Pipelines">
            <fields>
              <field key="pipeLines_Fld_Type" value="Type"/>
              <field key="pipeLines_Fld_Status" value="Status"/>
              <field key="pipeLines_Fld_To" value="To_"/>
              <field key="pipeLines_Fld_Uwi" value="UWI"/>
              <field key="pipeLines_Fld_Diameter" value="Diameter"/>
              <field key="pipeLines_Fld_PipeLineType" value="PipelineType"/>
              <field key="pipeLines_Fld_Facility" value="Facility"/>
              <field key="pipeLines_Fld_OperationalAreas" value="OperationalArea"/>
            </fields>
          </layer>
          <layer name="PiggingFacility">
            <fields>
              <field key="piggingFacility_Fld_Status" value="Status"/>
              <field key="piggingFacility_Fld_Type" value="Type"/>
              <field key="piggingFacility_Fld_Product" value="Product"/>
              <field key="piggingFacility_Fld_Facility" value="Facility"/>
              <field key="piggingFacility_Fld_OperationalAreas" value="OperationalArea"/>
            </fields>
          </layer>
          <layer name="Manhole">
            <fields>
              <field key="manHole_Fld_Status" value="Status"/>
              <field key="manHole_Fld_Type" value="Type"/>
              <field key="manHole_Fld_Facility" value="Facility"/>
              <field key="manHole_Fld_OperationalAreas" value="OperationalArea"/>
            </fields>
          </layer>
          <layer name="Pits">
            <fields>
              <field key="pits_Fld_Status" value="Status"/>
              <field key="pits_Fld_Type" value="Type"/>
              <field key="pits_Fld_Facility" value="Facility"/>
              <field key="pits_Fld_OperationalAreas" value="OperationalArea"/>
            </fields>
          </layer>
          <layer name="Manifolds">
            <fields>
              <field key="maniFolds_Fld_Status" value="Status"/>
              <field key="maniFolds_Fld_Type" value="Type"/>
              <field key="maniFolds_Fld_Facility" value="Facility"/>
              <field key="maniFolds_Fld_Name" value="Name"/>
              <field key="maniFolds_Fld_Product" value="Product"/>
              <field key="maniFolds_Fld_OperationalAreas" value="OperationalArea"/>
            </fields>
          </layer>
          <layer name="FlareLines">
            <fields>
              <field key="flareLines_Fld_Status" value="Status"/>
              <field key="flareLines_Fld_Type" value="Type"/>
              <field key="flareLines_Fld_Diameter" value="Diameter"/>
              <field key="flareLines_Fld_OperationalAreas" value="OperationalArea"/>
            </fields>
          </layer>
        </layers>
      </bundle>
      
    </bundles>
  </QAQCConfigSection>
<startup><supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.5"/></startup>
</configuration>
```
#### Reading the Above configuration's 'section' named as 'QAQCConfigSection'
```
QAQCConfigSection section = ConfigurationManager.GetSection("QAQCConfigSection") as QAQCConfigSection;

// Printing whatever is there in the section
Console.WriteLine("Printing whatever is there in the section...");
for (int i = 0; i < section.Bundles.Count; i++)
{
    Console.WriteLine("{0} - {1}", section.Bundles[i].Name, section.Bundles[i].Alias);
    Console.WriteLine("Layers ::");
    for (int j = 0; j < section.Bundles[i].Layers.Count; j++)
    {
        LayerElement lyr = section.Bundles[i].Layers[j];
        Console.WriteLine($"{lyr.Name}");

        Console.WriteLine("Fields ::");
        for (int k = 0; k < lyr.Fields.Count; k++)
        {
            FieldElement fld = lyr.Fields[k];
            Console.WriteLine($"Key: {fld.Key} => Value: {fld.Value}");
        }
        Console.WriteLine("---------------");
    }
    Console.WriteLine("------------------------------------------------------");
}
```
#### Pre-requisite
1. Add Reference of *'System.configuration'* library in your projects.
