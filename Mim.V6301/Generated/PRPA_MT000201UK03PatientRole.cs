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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="PRPA_MT000201UK03.PatientRole", Namespace="urn:hl7-org:v3")]
    public partial class PRPA_MT000201UK03PatientRole {
        
        private PRPA_MT000201UK03PatientRoleConfidentialityCode confidentialityCodeField;
        
        private IINPfIToidmandatory idField;
        
        private PRPA_MT000201UK03Person patientPersonField;
        
        private PRPA_MT000201UK03RecordTarget[] recordTargetOfField;
        
        private PRPA_MT000201UK03ReplacementOf[] replacementOfField;
        
        private PRPA_MT000201UK03Subject7 subjectOf1Field;
        
        private PRPA_MT000201UK03Subject4 subjectOf2Field;
        
        private PRPA_MT000201UK03Subject3[] subjectOf3Field;
        
        private PRPA_MT000201UK03Subject13 subjectOf4Field;
        
        private PRPA_MT000201UK03Subject6 subjectOf5Field;
        
        private PRPA_MT000201UK03Subject11 subjectOf6Field;
        
        private PRPA_MT000201UK03Subject16 subjectOf7Field;
        
        private PRPA_MT000201UK03Subject2 subjectOf8Field;
        
        private PRPA_MT000201UK03Subject19 subjectOf9Field;
        
        private string nullFlavorField;
        
        private cs_UpdateMode updateModeField;
        
        private bool updateModeFieldSpecified;
        
        private string classCodeField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public PRPA_MT000201UK03PatientRole() {
            this.classCodeField = "PAT";
        }
        
        public PRPA_MT000201UK03PatientRoleConfidentialityCode confidentialityCode {
            get {
                return this.confidentialityCodeField;
            }
            set {
                this.confidentialityCodeField = value;
            }
        }
        
        public IINPfIToidmandatory id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute()]
        public PRPA_MT000201UK03Person patientPerson {
            get {
                return this.patientPersonField;
            }
            set {
                this.patientPersonField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("recordTargetOf")]
        public PRPA_MT000201UK03RecordTarget[] recordTargetOf {
            get {
                return this.recordTargetOfField;
            }
            set {
                this.recordTargetOfField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("replacementOf")]
        public PRPA_MT000201UK03ReplacementOf[] replacementOf {
            get {
                return this.replacementOfField;
            }
            set {
                this.replacementOfField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute()]
        public PRPA_MT000201UK03Subject7 subjectOf1 {
            get {
                return this.subjectOf1Field;
            }
            set {
                this.subjectOf1Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute()]
        public PRPA_MT000201UK03Subject4 subjectOf2 {
            get {
                return this.subjectOf2Field;
            }
            set {
                this.subjectOf2Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("subjectOf3")]
        public PRPA_MT000201UK03Subject3[] subjectOf3 {
            get {
                return this.subjectOf3Field;
            }
            set {
                this.subjectOf3Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute()]
        public PRPA_MT000201UK03Subject13 subjectOf4 {
            get {
                return this.subjectOf4Field;
            }
            set {
                this.subjectOf4Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute()]
        public PRPA_MT000201UK03Subject6 subjectOf5 {
            get {
                return this.subjectOf5Field;
            }
            set {
                this.subjectOf5Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute()]
        public PRPA_MT000201UK03Subject11 subjectOf6 {
            get {
                return this.subjectOf6Field;
            }
            set {
                this.subjectOf6Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute()]
        public PRPA_MT000201UK03Subject16 subjectOf7 {
            get {
                return this.subjectOf7Field;
            }
            set {
                this.subjectOf7Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute()]
        public PRPA_MT000201UK03Subject2 subjectOf8 {
            get {
                return this.subjectOf8Field;
            }
            set {
                this.subjectOf8Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute()]
        public PRPA_MT000201UK03Subject19 subjectOf9 {
            get {
                return this.subjectOf9Field;
            }
            set {
                this.subjectOf9Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nullFlavor {
            get {
                return this.nullFlavorField;
            }
            set {
                this.nullFlavorField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public cs_UpdateMode updateMode {
            get {
                return this.updateModeField;
            }
            set {
                this.updateModeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool updateModeSpecified {
            get {
                return this.updateModeFieldSpecified;
            }
            set {
                this.updateModeFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string classCode {
            get {
                return this.classCodeField;
            }
            set {
                this.classCodeField = value;
            }
        }
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(PRPA_MT000201UK03PatientRole));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current PRPA_MT000201UK03PatientRole object into an XML document
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
        /// Deserializes workflow markup into an PRPA_MT000201UK03PatientRole object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output PRPA_MT000201UK03PatientRole object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out PRPA_MT000201UK03PatientRole obj, out System.Exception exception) {
            exception = null;
            obj = default(PRPA_MT000201UK03PatientRole);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out PRPA_MT000201UK03PatientRole obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static PRPA_MT000201UK03PatientRole Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((PRPA_MT000201UK03PatientRole)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current PRPA_MT000201UK03PatientRole object into file
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
        /// Deserializes xml markup from file into an PRPA_MT000201UK03PatientRole object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output PRPA_MT000201UK03PatientRole object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out PRPA_MT000201UK03PatientRole obj, out System.Exception exception) {
            exception = null;
            obj = default(PRPA_MT000201UK03PatientRole);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out PRPA_MT000201UK03PatientRole obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static PRPA_MT000201UK03PatientRole LoadFromFile(string fileName) {
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
        /// Create a clone of this PRPA_MT000201UK03PatientRole object
        /// </summary>
        public virtual PRPA_MT000201UK03PatientRole Clone() {
            return ((PRPA_MT000201UK03PatientRole)(this.MemberwiseClone()));
        }
        #endregion
    }
}
