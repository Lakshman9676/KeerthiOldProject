namespace Inchcape.DL.BT.PortCallSchedule.Pipeline
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class DLSingelMsgSplitReceivePipeline : Microsoft.BizTalk.PipelineOM.ReceivePipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>f66b9f5e-43ff-4f5f-ba46-885348ae1b4e</CategoryId>  <FriendlyName>Receive</FriendlyName>"+
"  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Decode\" minOccurs=\""+
"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4103-4cce-4536-83fa-4a5040674ad6\" />      <Component"+
"s />    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Disassemble\" "+
"minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"FirstMatch\" stageId=\"9d0e4105-4cce-4536-83fa-4a5040674ad6\" "+
"/>      <Components>        <Component>          <Name>Microsoft.BizTalk.Component.XmlDasmComp,Micro"+
"soft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35<"+
"/Name>          <ComponentName>XML disassembler</ComponentName>          <Description>Streaming XML "+
"disassembler</Description>          <Version>1.0</Version>          <Properties>            <Propert"+
"y Name=\"EnvelopeSpecNames\">              <Value xsi:type=\"xsd:string\">Inchcape.DL.BT.PortCallSchedul"+
"e.Schema.DataLoyMultipleInputSchema</Value>            </Property>            <Property Name=\"Envelo"+
"peSpecTargetNamespaces\">              <Value xsi:type=\"xsd:string\">http://Inchcape.DL.BT.PortCallSch"+
"edule.Schema.DataLoyMultipleInputSchema</Value>            </Property>            <Property Name=\"Do"+
"cumentSpecNames\">              <Value xsi:type=\"xsd:string\">Inchcape.DL.BT.PortCallSchedule.Schema.D"+
"ataLoyPortCall</Value>            </Property>            <Property Name=\"DocumentSpecTargetNamespace"+
"s\">              <Value xsi:type=\"xsd:string\">http://Inchcape.DL.BT.PortCallSchedule.Schema.DataLoyP"+
"ortcall</Value>            </Property>            <Property Name=\"AllowUnrecognizedMessage\">        "+
"      <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>            <Property Name=\""+
"ValidateDocument\">              <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>  "+
"          <Property Name=\"RecoverableInterchangeProcessing\">              <Value xsi:type=\"xsd:boole"+
"an\">false</Value>            </Property>            <Property Name=\"HiddenProperties\">              "+
"<Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,DocumentSpecTargetNamespaces</Value>      "+
"      </Property>          </Properties>          <CachedDisplayName>XML disassembler</CachedDisplay"+
"Name>          <CachedIsManaged>true</CachedIsManaged>        </Component>      </Components>    </S"+
"tage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"3\" Name=\"Validate\" minOccurs=\"0\" "+
"maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410d-4cce-4536-83fa-4a5040674ad6\" />      <Components /"+
">    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"4\" Name=\"ResolveParty\" mi"+
"nOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410e-4cce-4536-83fa-4a5040674ad6\" />      <"+
"Components />    </Stage>  </Stages></Document>";
        
        private const string _versionDependentGuid = "860db546-3f10-46e6-b364-897de58c4bdd";
        
        public DLSingelMsgSplitReceivePipeline()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4105-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.firstRecognized);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.XmlDasmComp,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"EnvelopeSpecNam"+
"es\">      <Value xsi:type=\"xsd:string\">Inchcape.DL.BT.PortCallSchedule.Schema.DataLoyMultipleInputSc"+
"hema</Value>    </Property>    <Property Name=\"EnvelopeSpecTargetNamespaces\">      <Value xsi:type=\""+
"xsd:string\">http://Inchcape.DL.BT.PortCallSchedule.Schema.DataLoyMultipleInputSchema</Value>    </Pr"+
"operty>    <Property Name=\"DocumentSpecNames\">      <Value xsi:type=\"xsd:string\">Inchcape.DL.BT.Port"+
"CallSchedule.Schema.DataLoyPortCall</Value>    </Property>    <Property Name=\"DocumentSpecTargetName"+
"spaces\">      <Value xsi:type=\"xsd:string\">http://Inchcape.DL.BT.PortCallSchedule.Schema.DataLoyPort"+
"call</Value>    </Property>    <Property Name=\"AllowUnrecognizedMessage\">      <Value xsi:type=\"xsd:"+
"boolean\">false</Value>    </Property>    <Property Name=\"ValidateDocument\">      <Value xsi:type=\"xs"+
"d:boolean\">false</Value>    </Property>    <Property Name=\"RecoverableInterchangeProcessing\">      <"+
"Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"HiddenProperties\">     "+
" <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,DocumentSpecTargetNamespaces</Value>    <"+
"/Property>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
        }
        
        public override string XmlContent
        {
            get
            {
                return _strPipeline;
            }
        }
        
        public override System.Guid VersionDependentGuid
        {
            get
            {
                return new System.Guid(_versionDependentGuid);
            }
        }
    }
}
