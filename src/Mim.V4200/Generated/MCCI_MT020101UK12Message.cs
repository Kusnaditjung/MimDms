// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.18239 Microsoft Reciprocal License (Ms-RL) 
//    <NameSpace>Mim.V4200</NameSpace><Collection>Array</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>False</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace Mim.V4200 {
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="MCCI_MT020101UK12.Message", Namespace="urn:hl7-org:v3")]
    [System.Xml.Serialization.XmlRootAttribute("Message", Namespace="urn:hl7-org:v3", IsNullable=false)]
    public partial class MCCI_MT020101UK12Message {
        
        private II idField;
        
        private TS creationTimeField;
        
        private CS versionCodeField;
        
        private II interactionIdField;
        
        private CS processingCodeField;
        
        private CS processingModeCodeField;
        
        private CS acceptAckCodeField;
        
        private MCCI_MT020101UK12Acknowledgement acknowledgementField;
        
        private MCCI_MT020101UK12CommunicationFunctionRcv[] communicationFunctionRcvField;
        
        private MCCI_MT020101UK12CommunicationFunctionSnd communicationFunctionSndField;
        
        private System.Xml.XmlElement anyField;
        
        private string typeField;
        
        private string[] typeIDField;
        
        private string[] realmCodeField;
        
        private string nullFlavorField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public MCCI_MT020101UK12Message() {
            this.typeField = "Message";
        }
        
        public II id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        public TS creationTime {
            get {
                return this.creationTimeField;
            }
            set {
                this.creationTimeField = value;
            }
        }
        
        public CS versionCode {
            get {
                return this.versionCodeField;
            }
            set {
                this.versionCodeField = value;
            }
        }
        
        public II interactionId {
            get {
                return this.interactionIdField;
            }
            set {
                this.interactionIdField = value;
            }
        }
        
        public CS processingCode {
            get {
                return this.processingCodeField;
            }
            set {
                this.processingCodeField = value;
            }
        }
        
        public CS processingModeCode {
            get {
                return this.processingModeCodeField;
            }
            set {
                this.processingModeCodeField = value;
            }
        }
        
        public CS acceptAckCode {
            get {
                return this.acceptAckCodeField;
            }
            set {
                this.acceptAckCodeField = value;
            }
        }
        
        public MCCI_MT020101UK12Acknowledgement acknowledgement {
            get {
                return this.acknowledgementField;
            }
            set {
                this.acknowledgementField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("communicationFunctionRcv")]
        public MCCI_MT020101UK12CommunicationFunctionRcv[] communicationFunctionRcv {
            get {
                return this.communicationFunctionRcvField;
            }
            set {
                this.communicationFunctionRcvField = value;
            }
        }
        
        public MCCI_MT020101UK12CommunicationFunctionSnd communicationFunctionSnd {
            get {
                return this.communicationFunctionSndField;
            }
            set {
                this.communicationFunctionSndField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
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
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(MCCI_MT020101UK12Message));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current MCCI_MT020101UK12Message object into an XML document
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
        /// Deserializes workflow markup into an MCCI_MT020101UK12Message object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output MCCI_MT020101UK12Message object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out MCCI_MT020101UK12Message obj, out System.Exception exception) {
            exception = null;
            obj = default(MCCI_MT020101UK12Message);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out MCCI_MT020101UK12Message obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static MCCI_MT020101UK12Message Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((MCCI_MT020101UK12Message)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current MCCI_MT020101UK12Message object into file
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
        /// Deserializes xml markup from file into an MCCI_MT020101UK12Message object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output MCCI_MT020101UK12Message object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out MCCI_MT020101UK12Message obj, out System.Exception exception) {
            exception = null;
            obj = default(MCCI_MT020101UK12Message);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out MCCI_MT020101UK12Message obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static MCCI_MT020101UK12Message LoadFromFile(string fileName) {
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
        /// Create a clone of this MCCI_MT020101UK12Message object
        /// </summary>
        public virtual MCCI_MT020101UK12Message Clone() {
            return ((MCCI_MT020101UK12Message)(this.MemberwiseClone()));
        }
        #endregion
    }
}
