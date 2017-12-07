namespace Inchcape.YourISS.Integration.DataLoy.PortCallSchedule {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Inchcape.YourISS.Integration.Schema.Portcall.Dataloy",@"Portcalls")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Inchcape.YourISS.Integration.DataLoy.PortCallSchedule.PropertySchema.key), XPath = @"/*[local-name()='Portcalls' and namespace-uri()='http://Inchcape.YourISS.Integration.Schema.Portcall.Dataloy']/*[local-name()='key' and namespace-uri()='http://Inchcape.YourISS.Integration.Schema.Portcall.Dataloy']", XsdType = @"int")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Portcalls"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Inchcape.YourISS.Integration.DataLoy.PortCallSchedule.PropertySchema.PropertySchema", typeof(global::Inchcape.YourISS.Integration.DataLoy.PortCallSchedule.PropertySchema.PropertySchema))]
    public sealed class DataLoyPortCall : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Inchcape.DL.BT.PortCallSchedule.Schema.DataLoyPortCall"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns1=""https://Inchcape.YourISS.Integration.DataLoy.PortCallSchedule.PropertySchema"" xmlns:ns0=""http://Inchcape.YourISS.Integration.Schema.Portcall.Dataloy"" elementFormDefault=""qualified"" targetNamespace=""http://Inchcape.YourISS.Integration.Schema.Portcall.Dataloy"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns1"" uri=""https://Inchcape.YourISS.Integration.DataLoy.PortCallSchedule.PropertySchema"" location=""Inchcape.YourISS.Integration.DataLoy.PortCallSchedule.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Portcalls"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns1:key"" xpath=""/*[local-name()='Portcalls' and namespace-uri()='http://Inchcape.YourISS.Integration.Schema.Portcall.Dataloy']/*[local-name()='key' and namespace-uri()='http://Inchcape.YourISS.Integration.Schema.Portcall.Dataloy']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""eventLogs"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""event"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""eventCode"" type=""xs:string"" />
                    <xs:element name=""eventDesc"" type=""xs:string"" />
                    <xs:element name=""key"" type=""xs:int"" />
                    <xs:element name=""self"" type=""xs:anyURI"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""eventLogDate"" type=""xs:dateTime"" />
              <xs:element name=""key"" type=""xs:int"" />
              <xs:element name=""self"" type=""xs:anyURI"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""key"" type=""xs:int"" />
        <xs:element minOccurs=""0"" name=""remarks"" type=""xs:string"" />
        <xs:element name=""self"" type=""xs:anyURI"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public DataLoyPortCall() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Portcalls";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
