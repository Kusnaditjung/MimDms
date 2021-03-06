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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="RCMR_MT030101UK04.LinkSet", Namespace="urn:hl7-org:v3")]
    [System.Xml.Serialization.XmlRootAttribute("RCMR_MT030101UK04.LinkSet", Namespace="urn:hl7-org:v3")]
    public partial class RCMR_MT030101UK04LinkSet {
        
        private II idField;
        
        private CD codeField;
        
        private CS statusCodeField;
        
        private IVL_TS effectiveTimeField;
        
        private TS availabilityTimeField;
        
        private RCMR_MT030101UK04Component6[] componentField;
        
        private RCMR_MT030101UK04ConditionNamed conditionNamedField;
        
        private RCMR_MT030101UK04Informant[] informantField;
        
        private RCMR_MT030101UK04Participant[] participantField;
        
        private RCMR_MT030101UK04ReplacementOf[] replacementOfField;
        
        private RCMR_MT030101UK04Reason[] reasonField;
        
        private RCMR_MT030101UK04Reference[] referenceField;
        
        private RCMR_MT030101UK04SequelTo[] sequelToField;
        
        private string typeField;
        
        private string classCodeField;
        
        private string moodCodeField;
        
        private string[] typeIDField;
        
        private string[] realmCodeField;
        
        private string nullFlavorField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public RCMR_MT030101UK04LinkSet() {
            this.typeField = "Observation";
            this.classCodeField = "OBS";
            this.moodCodeField = "EVN";
        }
        
        public II id {
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
        
        [System.Xml.Serialization.XmlElementAttribute("component")]
        public RCMR_MT030101UK04Component6[] component {
            get {
                return this.componentField;
            }
            set {
                this.componentField = value;
            }
        }
        
        public RCMR_MT030101UK04ConditionNamed conditionNamed {
            get {
                return this.conditionNamedField;
            }
            set {
                this.conditionNamedField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("informant")]
        public RCMR_MT030101UK04Informant[] informant {
            get {
                return this.informantField;
            }
            set {
                this.informantField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Participant")]
        public RCMR_MT030101UK04Participant[] Participant {
            get {
                return this.participantField;
            }
            set {
                this.participantField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("replacementOf")]
        public RCMR_MT030101UK04ReplacementOf[] replacementOf {
            get {
                return this.replacementOfField;
            }
            set {
                this.replacementOfField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("reason")]
        public RCMR_MT030101UK04Reason[] reason {
            get {
                return this.reasonField;
            }
            set {
                this.reasonField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("reference")]
        public RCMR_MT030101UK04Reference[] reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("sequelTo")]
        public RCMR_MT030101UK04SequelTo[] sequelTo {
            get {
                return this.sequelToField;
            }
            set {
                this.sequelToField = value;
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
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(RCMR_MT030101UK04LinkSet));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current RCMR_MT030101UK04LinkSet object into an XML document
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
        /// Deserializes workflow markup into an RCMR_MT030101UK04LinkSet object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output RCMR_MT030101UK04LinkSet object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out RCMR_MT030101UK04LinkSet obj, out System.Exception exception) {
            exception = null;
            obj = default(RCMR_MT030101UK04LinkSet);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out RCMR_MT030101UK04LinkSet obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static RCMR_MT030101UK04LinkSet Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((RCMR_MT030101UK04LinkSet)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current RCMR_MT030101UK04LinkSet object into file
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
        /// Deserializes xml markup from file into an RCMR_MT030101UK04LinkSet object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output RCMR_MT030101UK04LinkSet object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out RCMR_MT030101UK04LinkSet obj, out System.Exception exception) {
            exception = null;
            obj = default(RCMR_MT030101UK04LinkSet);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out RCMR_MT030101UK04LinkSet obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static RCMR_MT030101UK04LinkSet LoadFromFile(string fileName) {
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
        /// Create a clone of this RCMR_MT030101UK04LinkSet object
        /// </summary>
        public virtual RCMR_MT030101UK04LinkSet Clone() {
            return ((RCMR_MT030101UK04LinkSet)(this.MemberwiseClone()));
        }
        #endregion
    }
}
