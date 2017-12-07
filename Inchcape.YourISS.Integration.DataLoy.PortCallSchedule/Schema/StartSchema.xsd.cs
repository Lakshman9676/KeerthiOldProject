namespace Inchcape.YourISS.Integration.DataLoy.PortCallSchedule {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Inchcape.YourISS.Integration.DataLoy.PortCallSchedule.StartSchema",@"DataLoy")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"DataLoy"})]
    public sealed class StartSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Inchcape.YourISS.Integration.DataLoy.PortCallSchedule.StartSchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Inchcape.YourISS.Integration.DataLoy.PortCallSchedule.StartSchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""DataLoy"">
    <xs:complexType />
  </xs:element>
</xs:schema>";
        
        public StartSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "DataLoy";
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
