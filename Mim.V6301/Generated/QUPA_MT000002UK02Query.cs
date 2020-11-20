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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="QUPA_MT000002UK02.Query", Namespace="urn:hl7-org:v3")]
    [System.Xml.Serialization.XmlRootAttribute("query", Namespace="urn:hl7-org:v3", IsNullable=false)]
    public partial class QUPA_MT000002UK02Query {
        
        private QUPA_MT000002UK02HistoricDataIndicator historicDataIndicatorField;
        
        private QUPA_MT000002UK02IgnoreHistoryIndicator ignoreHistoryIndicatorField;
        
        private QUPA_MT000002UK02Personaddress personaddressField;
        
        private QUPA_MT000002UK02PersonadministrativeGenderCode personadministrativeGenderCodeField;
        
        private QUPA_MT000002UK02PersonbirthTime personbirthTimeField;
        
        private QUPA_MT000002UK02PersondeceasedTime persondeceasedTimeField;
        
        private QUPA_MT000002UK02Personid personidField;
        
        private QUPA_MT000002UK02Personname personnameField;
        
        private QUPA_MT000002UK02PrimaryCareid primaryCareidField;
        
        private QUPA_MT000002UK02SearchParameter searchParameterField;
        
        private string nullFlavorField;
        
        private cs_UpdateMode updateModeField;
        
        private bool updateModeFieldSpecified;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public QUPA_MT000002UK02HistoricDataIndicator historicDataIndicator {
            get {
                return this.historicDataIndicatorField;
            }
            set {
                this.historicDataIndicatorField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute()]
        public QUPA_MT000002UK02IgnoreHistoryIndicator ignoreHistoryIndicator {
            get {
                return this.ignoreHistoryIndicatorField;
            }
            set {
                this.ignoreHistoryIndicatorField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("person.address")]
        public QUPA_MT000002UK02Personaddress personaddress {
            get {
                return this.personaddressField;
            }
            set {
                this.personaddressField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("person.administrativeGenderCode")]
        public QUPA_MT000002UK02PersonadministrativeGenderCode personadministrativeGenderCode {
            get {
                return this.personadministrativeGenderCodeField;
            }
            set {
                this.personadministrativeGenderCodeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("person.birthTime")]
        public QUPA_MT000002UK02PersonbirthTime personbirthTime {
            get {
                return this.personbirthTimeField;
            }
            set {
                this.personbirthTimeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("person.deceasedTime")]
        public QUPA_MT000002UK02PersondeceasedTime persondeceasedTime {
            get {
                return this.persondeceasedTimeField;
            }
            set {
                this.persondeceasedTimeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("person.id")]
        public QUPA_MT000002UK02Personid personid {
            get {
                return this.personidField;
            }
            set {
                this.personidField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("person.name")]
        public QUPA_MT000002UK02Personname personname {
            get {
                return this.personnameField;
            }
            set {
                this.personnameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("primaryCare.id")]
        public QUPA_MT000002UK02PrimaryCareid primaryCareid {
            get {
                return this.primaryCareidField;
            }
            set {
                this.primaryCareidField = value;
            }
        }
        
        public QUPA_MT000002UK02SearchParameter searchParameter {
            get {
                return this.searchParameterField;
            }
            set {
                this.searchParameterField = value;
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
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(QUPA_MT000002UK02Query));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current QUPA_MT000002UK02Query object into an XML document
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
        /// Deserializes workflow markup into an QUPA_MT000002UK02Query object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output QUPA_MT000002UK02Query object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out QUPA_MT000002UK02Query obj, out System.Exception exception) {
            exception = null;
            obj = default(QUPA_MT000002UK02Query);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out QUPA_MT000002UK02Query obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static QUPA_MT000002UK02Query Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((QUPA_MT000002UK02Query)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current QUPA_MT000002UK02Query object into file
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
        /// Deserializes xml markup from file into an QUPA_MT000002UK02Query object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output QUPA_MT000002UK02Query object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out QUPA_MT000002UK02Query obj, out System.Exception exception) {
            exception = null;
            obj = default(QUPA_MT000002UK02Query);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out QUPA_MT000002UK02Query obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static QUPA_MT000002UK02Query LoadFromFile(string fileName) {
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
        /// Create a clone of this QUPA_MT000002UK02Query object
        /// </summary>
        public virtual QUPA_MT000002UK02Query Clone() {
            return ((QUPA_MT000002UK02Query)(this.MemberwiseClone()));
        }
        #endregion
    }
}
