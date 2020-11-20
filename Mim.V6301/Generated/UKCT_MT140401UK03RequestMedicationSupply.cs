// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.18239 Microsoft Reciprocal License (Ms-RL) 
//    <NameSpace>Mim.V6301</NameSpace><Collection>Array</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>False</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace Mim.V6301 {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.IO;
    using System.Text;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.18239")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="UKCT_MT140401UK03.RequestMedicationSupply", Namespace="urn:hl7-org:v3")]
    public partial class UKCT_MT140401UK03RequestMedicationSupply {
        
        private II[] idField;
        
        private CD codeField;
        
        private CS statusCodeField;
        
        private IVL_TS effectiveTimeField;
        
        private TS availabilityTimeField;
        
        private PQ quantityField;
        
        private UKCT_MT140401UK03Author authorField;
        
        private UKCT_MT140401UK03Location locationField;
        
        private UKCT_MT140401UK03PrimaryInformationRecipient primaryInformationRecipientField;
        
        private UKCT_MT140401UK03Product productField;
        
        private UKCT_MT140401UK03Receiver receiverField;
        
        private UKCT_MT140401UK03Tracker[] trackerField;
        
        private UKCT_MT140401UK03PertinentInformation2 pertinentInformation2Field;
        
        private UKCT_MT140401UK03PertinentInformation3 pertinentInformation1Field;
        
        private UKCT_MT140401UK03InFulfillmentOf inFulfillmentOfField;
        
        private UKCT_MT140401UK03SourceOf[] sourceOfField;
        
        private string typeField;
        
        private string classCodeField;
        
        private string moodCodeField;
        
        private string[] typeIDField;
        
        private string[] realmCodeField;
        
        private string nullFlavorField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public UKCT_MT140401UK03RequestMedicationSupply() {
            this.typeField = "Supply";
            this.classCodeField = "SPLY";
            this.moodCodeField = "RQO";
        }
        
        [System.Xml.Serialization.XmlElementAttribute("id")]
        public II[] id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        public CD code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        public CS statusCode {
            get {
                return this.statusCodeField;
            }
            set {
                this.statusCodeField = value;
            }
        }
        
        public IVL_TS effectiveTime {
            get {
                return this.effectiveTimeField;
            }
            set {
                this.effectiveTimeField = value;
            }
        }
        
        public TS availabilityTime {
            get {
                return this.availabilityTimeField;
            }
            set {
                this.availabilityTimeField = value;
            }
        }
        
        public PQ quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        public UKCT_MT140401UK03Author author {
            get {
                return this.authorField;
            }
            set {
                this.authorField = value;
            }
        }
        
        public UKCT_MT140401UK03Location location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
        
        public UKCT_MT140401UK03PrimaryInformationRecipient primaryInformationRecipient {
            get {
                return this.primaryInformationRecipientField;
            }
            set {
                this.primaryInformationRecipientField = value;
            }
        }
        
        public UKCT_MT140401UK03Product product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
            }
        }
        
        public UKCT_MT140401UK03Receiver receiver {
            get {
                return this.receiverField;
            }
            set {
                this.receiverField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("tracker")]
        public UKCT_MT140401UK03Tracker[] tracker {
            get {
                return this.trackerField;
            }
            set {
                this.trackerField = value;
            }
        }
        
        public UKCT_MT140401UK03PertinentInformation2 pertinentInformation2 {
            get {
                return this.pertinentInformation2Field;
            }
            set {
                this.pertinentInformation2Field = value;
            }
        }
        
        public UKCT_MT140401UK03PertinentInformation3 pertinentInformation1 {
            get {
                return this.pertinentInformation1Field;
            }
            set {
                this.pertinentInformation1Field = value;
            }
        }
        
        public UKCT_MT140401UK03InFulfillmentOf inFulfillmentOf {
            get {
                return this.inFulfillmentOfField;
            }
            set {
                this.inFulfillmentOfField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("sourceOf")]
        public UKCT_MT140401UK03SourceOf[] sourceOf {
            get {
                return this.sourceOfField;
            }
            set {
                this.sourceOfField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string classCode {
            get {
                return this.classCodeField;
            }
            set {
                this.classCodeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string moodCode {
            get {
                return this.moodCodeField;
            }
            set {
                this.moodCodeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] typeID {
            get {
                return this.typeIDField;
            }
            set {
                this.typeIDField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string[] realmCode {
            get {
                return this.realmCodeField;
            }
            set {
                this.realmCodeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string nullFlavor {
            get {
                return this.nullFlavorField;
            }
            set {
                this.nullFlavorField = value;
            }
        }
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(UKCT_MT140401UK03RequestMedicationSupply));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current UKCT_MT140401UK03RequestMedicationSupply object into an XML document
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize() {
            System.IO.StreamReader streamReader = null;
            System.IO.MemoryStream memoryStream = null;
            try {
                memoryStream = new System.IO.MemoryStream();
                Serializer.Serialize(memoryStream, this);
                memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
                streamReader = new System.IO.StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally {
                if ((streamReader != null)) {
                    streamReader.Dispose();
                }
                if ((memoryStream != null)) {
                    memoryStream.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Deserializes workflow markup into an UKCT_MT140401UK03RequestMedicationSupply object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output UKCT_MT140401UK03RequestMedicationSupply object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out UKCT_MT140401UK03RequestMedicationSupply obj, out System.Exception exception) {
            exception = null;
            obj = default(UKCT_MT140401UK03RequestMedicationSupply);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out UKCT_MT140401UK03RequestMedicationSupply obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static UKCT_MT140401UK03RequestMedicationSupply Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((UKCT_MT140401UK03RequestMedicationSupply)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current UKCT_MT140401UK03RequestMedicationSupply object into file
        /// </summary>
        /// <param name="fileName">full path of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool SaveToFile(string fileName, out System.Exception exception) {
            exception = null;
            try {
                SaveToFile(fileName);
                return true;
            }
            catch (System.Exception e) {
                exception = e;
                return false;
            }
        }
        
        public virtual void SaveToFile(string fileName) {
            System.IO.StreamWriter streamWriter = null;
            try {
                string xmlString = Serialize();
                System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
                streamWriter = xmlFile.CreateText();
                streamWriter.WriteLine(xmlString);
                streamWriter.Close();
            }
            finally {
                if ((streamWriter != null)) {
                    streamWriter.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Deserializes xml markup from file into an UKCT_MT140401UK03RequestMedicationSupply object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output UKCT_MT140401UK03RequestMedicationSupply object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out UKCT_MT140401UK03RequestMedicationSupply obj, out System.Exception exception) {
            exception = null;
            obj = default(UKCT_MT140401UK03RequestMedicationSupply);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out UKCT_MT140401UK03RequestMedicationSupply obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static UKCT_MT140401UK03RequestMedicationSupply LoadFromFile(string fileName) {
            System.IO.FileStream file = null;
            System.IO.StreamReader sr = null;
            try {
                file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new System.IO.StreamReader(file);
                string xmlString = sr.ReadToEnd();
                sr.Close();
                file.Close();
                return Deserialize(xmlString);
            }
            finally {
                if ((file != null)) {
                    file.Dispose();
                }
                if ((sr != null)) {
                    sr.Dispose();
                }
            }
        }
        #endregion
        
        #region Clone method
        /// <summary>
        /// Create a clone of this UKCT_MT140401UK03RequestMedicationSupply object
        /// </summary>
        public virtual UKCT_MT140401UK03RequestMedicationSupply Clone() {
            return ((UKCT_MT140401UK03RequestMedicationSupply)(this.MemberwiseClone()));
        }
        #endregion
    }
}
