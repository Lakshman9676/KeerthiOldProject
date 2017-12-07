namespace Inchcape.YourISS.Integration.DataLoy.PortCallSchedule {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Inchcape.YourISS.Integration.Schema.Portcall.Dataloy",@"root")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"root"})]
    public sealed class DataLoyMultipleInputSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Inchcape.YourISS.Integration.Schema.Portcall.Dataloy"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Inchcape.YourISS.Integration.Schema.Portcall.Dataloy"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""root"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Portcalls"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""eventLogs"">
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
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public DataLoyMultipleInputSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "root";
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
