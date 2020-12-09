// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.18239 Microsoft Reciprocal License (Ms-RL) 
//    <NameSpace>Mim.V3109</NameSpace><Collection>Array</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>False</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace Mim.V3109 {
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="REPC_MT400101UK07.PertinentInformation14", Namespace="urn:hl7-org:v3")]
    [System.Xml.Serialization.XmlRootAttribute("REPC_MT400101UK07.PertinentInformation14", Namespace="urn:hl7-org:v3")]
    public partial class REPC_MT400101UK07PertinentInformation14 {
        
        private INT sequenceNumberField;
        
        private BL seperatableIndField;
        
        private REPC_MT400101UK07PertinentInformation14TemplateId templateIdField;
        
        private object itemField;
        
        private string typeField;
        
        private string typeCodeField;
        
        private bool inversionIndField;
        
        private bool contextConductionIndField;
        
        private bool negationIndField;
        
        private string[] typeIDField;
        
        private string[] realmCodeField;
        
        private string nullFlavorField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public REPC_MT400101UK07PertinentInformation14() {
            this.typeField = "ActRelationship";
            this.typeCodeField = "PERT";
            this.inversionIndField = false;
            this.contextConductionIndField = true;
            this.negationIndField = false;
        }
        
        public INT sequenceNumber {
            get {
                return this.sequenceNumberField;
            }
            set {
                this.sequenceNumberField = value;
            }
        }
        
        public BL seperatableInd {
            get {
                return this.seperatableIndField;
            }
            set {
                this.seperatableIndField = value;
            }
        }
        
        public REPC_MT400101UK07PertinentInformation14TemplateId templateId {
            get {
                return this.templateIdField;
            }
            set {
                this.templateIdField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CareEvent", typeof(UKCT_MT140901UK01CareEvent))]
        [System.Xml.Serialization.XmlElementAttribute("Consent", typeof(UKCT_MT140901UK01Consent))]
        [System.Xml.Serialization.XmlElementAttribute("Observation", typeof(UKCT_MT140901UK01Observation))]
        [System.Xml.Serialization.XmlElementAttribute("Organizer", typeof(UKCT_MT140901UK01Organizer))]
        [System.Xml.Serialization.XmlElementAttribute("Procedure", typeof(UKCT_MT140901UK01Procedure))]
        [System.Xml.Serialization.XmlElementAttribute("StatementRelationship", typeof(UKCT_MT140901UK01StatementRelationship))]
        [System.Xml.Serialization.XmlElementAttribute("SubstanceAdministration", typeof(UKCT_MT140901UK01SubstanceAdministration))]
        [System.Xml.Serialization.XmlElementAttribute("Supply", typeof(UKCT_MT140901UK01Supply))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
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
        public string typeCode {
            get {
                return this.typeCodeField;
            }
            set {
                this.typeCodeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool inversionInd {
            get {
                return this.inversionIndField;
            }
            set {
                this.inversionIndField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool contextConductionInd {
            get {
                return this.contextConductionIndField;
            }
            set {
                this.contextConductionIndField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool negationInd {
            get {
                return this.negationIndField;
            }
            set {
                this.negationIndField = value;
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
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(REPC_MT400101UK07PertinentInformation14));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current REPC_MT400101UK07PertinentInformation14 object into an XML document
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
        /// Deserializes workflow markup into an REPC_MT400101UK07PertinentInformation14 object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output REPC_MT400101UK07PertinentInformation14 object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out REPC_MT400101UK07PertinentInformation14 obj, out System.Exception exception) {
            exception = null;
            obj = default(REPC_MT400101UK07PertinentInformation14);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out REPC_MT400101UK07PertinentInformation14 obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static REPC_MT400101UK07PertinentInformation14 Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((REPC_MT400101UK07PertinentInformation14)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current REPC_MT400101UK07PertinentInformation14 object into file
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
        /// Deserializes xml markup from file into an REPC_MT400101UK07PertinentInformation14 object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output REPC_MT400101UK07PertinentInformation14 object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out REPC_MT400101UK07PertinentInformation14 obj, out System.Exception exception) {
            exception = null;
            obj = default(REPC_MT400101UK07PertinentInformation14);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out REPC_MT400101UK07PertinentInformation14 obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static REPC_MT400101UK07PertinentInformation14 LoadFromFile(string fileName) {
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
        /// Create a clone of this REPC_MT400101UK07PertinentInformation14 object
        /// </summary>
        public virtual REPC_MT400101UK07PertinentInformation14 Clone() {
            return ((REPC_MT400101UK07PertinentInformation14)(this.MemberwiseClone()));
        }
        #endregion
    }
}
