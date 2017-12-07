namespace Inchcape.YourISS.Integration.DataLoy.PortCallSchedule {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Inchcape.YourISS.Integration.DataLoy.PortCallSchedule.DataLoyInput",@"root")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"root"})]
    public sealed class DataLoyInput : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Inchcape.YourISS.Integration.DataLoy.PortCallSchedule.DataLoyInput"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Inchcape.YourISS.Integration.DataLoy.PortCallSchedule.DataLoyInput"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""root"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""key"" type=""xs:int"" />
        <xs:element name=""self"" type=""xs:anyURI"" />
        <xs:element name=""eventLogs"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""key"" type=""xs:int"" />
              <xs:element name=""self"" type=""xs:anyURI"" />
              <xs:element name=""event"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""key"" type=""xs:int"" />
                    <xs:element name=""self"" type=""xs:anyURI"" />
                    <xs:element name=""eventCode"" type=""xs:string"" />
                    <xs:element name=""eventDesc"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""eventLogDate"" type=""xs:dateTime"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""quantity"" type=""xs:byte"" />
        <xs:element name=""handlingCost"" type=""xs:byte"" />
        <xs:element name=""bunkerHedgeLine"" type=""xs:string"" />
        <xs:element name=""voyage"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""self"" type=""xs:anyURI"" />
              <xs:element name=""key"" type=""xs:int"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""commodity"" type=""xs:string"" />
        <xs:element name=""agent"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""businessPartnerName"" type=""xs:string"" />
              <xs:element name=""businessPartnerSort"" type=""xs:string"" />
              <xs:element name=""businessPartnerCode"" type=""xs:byte"" />
              <xs:element name=""businessPartnerType"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""businessPartnerType"" type=""xs:string"" />
                    <xs:element name=""businessPartnerTypeDesc"" type=""xs:string"" />
                    <xs:element name=""key"" type=""xs:int"" />
                    <xs:element name=""self"" type=""xs:anyURI"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""self"" type=""xs:anyURI"" />
              <xs:element name=""key"" type=""xs:int"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""modifiedDate"" type=""xs:dateTime"" />
        <xs:element name=""portCost"" type=""xs:short"" />
        <xs:element name=""portCostCurrency"" type=""xs:short"" />
        <xs:element name=""speed"" type=""xs:float"" />
        <xs:element name=""doAtSea"" type=""xs:float"" />
        <xs:element name=""doInPort"" type=""xs:float"" />
        <xs:element name=""foInPort"" type=""xs:float"" />
        <xs:element name=""portCallSequence"" type=""xs:byte"" />
        <xs:element name=""daysExtraInPort"" type=""xs:float"" />
        <xs:element name=""hasTransshipment"" type=""xs:string"" />
        <xs:element name=""reasonForCall"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""reasonForCall"" type=""xs:string"" />
              <xs:element name=""reasonForCallDesc"" type=""xs:string"" />
              <xs:element name=""key"" type=""xs:int"" />
              <xs:element name=""self"" type=""xs:anyURI"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""laytimeUsed"" type=""xs:byte"" />
        <xs:element name=""variousRevenue"" type=""xs:byte"" />
        <xs:element name=""variousCost"" type=""xs:byte"" />
        <xs:element name=""agencySystemRef"" type=""xs:string"" />
        <xs:element name=""arrivalFixed"" type=""xs:string"" />
        <xs:element name=""berthedFixed"" type=""xs:string"" />
        <xs:element name=""boActual"" type=""xs:byte"" />
        <xs:element name=""boAllowed"" type=""xs:byte"" />
        <xs:element name=""boExcessCredit"" type=""xs:byte"" />
        <xs:element name=""boNitrogenContent"" type=""xs:byte"" />
        <xs:element name=""boOnPassage"" type=""xs:byte"" />
        <xs:element name=""boUsedAsFuel"" type=""xs:byte"" />
        <xs:element name=""bunkerExtraCost"" type=""xs:byte"" />
        <xs:element name=""daysAtSea"" type=""xs:float"" />
        <xs:element name=""daysInPort"" type=""xs:float"" />
        <xs:element name=""departureFixed"" type=""xs:string"" />
        <xs:element name=""distance"" type=""xs:short"" />
        <xs:element name=""distanceActual"" type=""xs:byte"" />
        <xs:element name=""dlAtSea"" type=""xs:byte"" />
        <xs:element name=""dlBunkerPrice"" type=""xs:byte"" />
        <xs:element name=""dlBunkerPriceNet"" type=""xs:byte"" />
        <xs:element name=""dlBunkered"" type=""xs:byte"" />
        <xs:element name=""dlBunkeredDate"" type=""xs:string"" />
        <xs:element name=""dlInPort"" type=""xs:byte"" />
        <xs:element name=""dlRobArrival"" type=""xs:short"" />
        <xs:element name=""dlRobArrivalFixed"" type=""xs:string"" />
        <xs:element name=""dlRobDeparture"" type=""xs:short"" />
        <xs:element name=""dlRobDepartureFixed"" type=""xs:string"" />
        <xs:element name=""dlSulphurPercent"" type=""xs:byte"" />
        <xs:element name=""doBunkerPrice"" type=""xs:byte"" />
        <xs:element name=""doBunkerPriceNet"" type=""xs:byte"" />
        <xs:element name=""doBunkered"" type=""xs:byte"" />
        <xs:element name=""doBunkeredDate"" type=""xs:string"" />
        <xs:element name=""doRobArrival"" type=""xs:float"" />
        <xs:element name=""doRobArrivalFixed"" type=""xs:string"" />
        <xs:element name=""doRobDeparture"" type=""xs:float"" />
        <xs:element name=""doRobDepartureFixed"" type=""xs:string"" />
        <xs:element name=""doSulphurPercent"" type=""xs:byte"" />
        <xs:element name=""flAtSea"" type=""xs:byte"" />
        <xs:element name=""flBunkerPrice"" type=""xs:byte"" />
        <xs:element name=""flBunkerPriceNet"" type=""xs:byte"" />
        <xs:element name=""flBunkered"" type=""xs:byte"" />
        <xs:element name=""flBunkeredDate"" type=""xs:string"" />
        <xs:element name=""flInPort"" type=""xs:byte"" />
        <xs:element name=""flRobArrival"" type=""xs:short"" />
        <xs:element name=""flRobArrivalFixed"" type=""xs:string"" />
        <xs:element name=""flRobDeparture"" type=""xs:short"" />
        <xs:element name=""flRobDepartureFixed"" type=""xs:string"" />
        <xs:element name=""flSulphurPercent"" type=""xs:byte"" />
        <xs:element name=""foAtSea"" type=""xs:float"" />
        <xs:element name=""foBunkerPrice"" type=""xs:short"" />
        <xs:element name=""foBunkerPriceNet"" type=""xs:short"" />
        <xs:element name=""foBunkered"" type=""xs:short"" />
        <xs:element name=""foBunkeredDate"" type=""xs:string"" />
        <xs:element name=""foRobArrival"" type=""xs:float"" />
        <xs:element name=""foRobArrivalFixed"" type=""xs:string"" />
        <xs:element name=""foRobDeparture"" type=""xs:float"" />
        <xs:element name=""foRobDepartureFixed"" type=""xs:string"" />
        <xs:element name=""foSulphurPercent"" type=""xs:byte"" />
        <xs:element name=""gaugedNitrogenFactor"" type=""xs:byte"" />
        <xs:element name=""gaugedQuantityAfter"" type=""xs:byte"" />
        <xs:element name=""gaugedQuantityBefore"" type=""xs:byte"" />
        <xs:element name=""gaugedTimeAfter"" type=""xs:string"" />
        <xs:element name=""gaugedTimeBefore"" type=""xs:string"" />
        <xs:element name=""isDlPurchaseFinal"" type=""xs:string"" />
        <xs:element name=""isDoPurchaseFinal"" type=""xs:string"" />
        <xs:element name=""isFlPurchaseFinal"" type=""xs:string"" />
        <xs:element name=""isFoPurchaseFinal"" type=""xs:string"" />
        <xs:element name=""isHcFixed"" type=""xs:string"" />
        <xs:element name=""isHcTsFixed"" type=""xs:string"" />
        <xs:element name=""isPcFixed"" type=""xs:string"" />
        <xs:element name=""lngFoConsumptionActual"" type=""xs:byte"" />
        <xs:element name=""lngFoConsumptionAllowed"" type=""xs:byte"" />
        <xs:element name=""lngFoConsumptionDebit"" type=""xs:byte"" />
        <xs:element name=""lngFoEquivalent"" type=""xs:byte"" />
        <xs:element name=""numberOfBerths"" type=""xs:byte"" />
        <xs:element name=""pctBoActual"" type=""xs:byte"" />
        <xs:element name=""pctBoAllowed"" type=""xs:byte"" />
        <xs:element name=""tcSequence"" type=""xs:byte"" />
        <xs:element name=""timezoneOffset"" type=""xs:byte"" />
        <xs:element name=""agencyAppointmentStatus"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""key"" type=""xs:int"" />
              <xs:element name=""self"" type=""xs:anyURI"" />
              <xs:element name=""statusTypeCode"" type=""xs:string"" />
              <xs:element name=""statusTypeDesc"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""bunkerAccountOf"" type=""xs:string"" />
        <xs:element name=""bunkerBroker"" type=""xs:string"" />
        <xs:element name=""bunkerPayedBy"" type=""xs:string"" />
        <xs:element name=""bunkerSupplier"" type=""xs:string"" />
        <xs:element name=""distanceRef"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""key"" type=""xs:int"" />
              <xs:element name=""self"" type=""xs:anyURI"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""master"" type=""xs:string"" />
        <xs:element name=""ownedByVoyage"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""self"" type=""xs:anyURI"" />
              <xs:element name=""key"" type=""xs:int"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""speedRef"" type=""xs:string"" />
        <xs:element name=""terminal"" type=""xs:string"" />
        <xs:element name=""comments"" type=""xs:string"" />
        <xs:element name=""createdDate"" type=""xs:dateTime"" />
        <xs:element name=""createdById"" type=""xs:int"" />
        <xs:element name=""port"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""portName"" type=""xs:string"" />
              <xs:element name=""unLoCode"" type=""xs:string"" />
              <xs:element name=""country"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""countryCode"" type=""xs:string"" />
                    <xs:element name=""countryName"" type=""xs:string"" />
                    <xs:element name=""key"" type=""xs:int"" />
                    <xs:element name=""self"" type=""xs:anyURI"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""isCanal"" type=""xs:string"" />
              <xs:element name=""self"" type=""xs:anyURI"" />
              <xs:element name=""key"" type=""xs:int"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""currency"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""currencyCode"" type=""xs:string"" />
              <xs:element name=""currencyName"" type=""xs:string"" />
              <xs:element name=""key"" type=""xs:int"" />
              <xs:element name=""self"" type=""xs:anyURI"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public DataLoyInput() {
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
