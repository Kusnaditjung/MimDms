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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="UKCT_MT120201UK04.Organization", Namespace="urn:hl7-org:v3")]
    [System.Xml.Serialization.XmlRootAttribute("UKCT_MT120201UK04.Organization", Namespace="urn:hl7-org:v3")]
    public partial class UKCT_MT120201UK04Organization {
        
        private II idField;
        
        private CS codeField;
        
        private ON nameField;
        
        private ST descField;
        
        private TEL telecomField;
        
        private AD addrField;
        
        private UKCT_MT120201UK04HealthCareProvider[] healthCareProviderLicenseField;
        
        private string typeField;
        
        private string classCodeField;
        
        private string determinerCodeField;
        
        private string[] typeIDField;
        
        private string[] realmCodeField;
        
        private string nullFlavorField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public UKCT_MT120201UK04Organization() {
            this.typeField = "Organization";
            this.classCodeField = "ORG";
            this.determinerCodeField = "INSTANCE";
        }
        
        public II id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        public CS code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        public ON name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        public ST desc {
            get {
                return this.descField;
            }
            set {
                this.descField = value;
            }
        }
        
        public TEL telecom {
            get {
                return this.telecomField;
            }
            set {
                this.telecomField = value;
            }
        }
        
        public AD addr {
            get {
                return this.addrField;
            }
            set {
                this.addrField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("healthCareProviderLicense")]
        public UKCT_MT120201UK04HealthCareProvider[] healthCareProviderLicense {
            get {
                return this.healthCareProviderLicenseField;
            }
            set {
                this.healthCareProviderLicenseField = value;
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
        public string determinerCode {
            get {
                return this.determinerCodeField;
            }
            set {
                this.determinerCodeField = value;
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
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(UKCT_MT120201UK04Organization));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current UKCT_MT120201UK04Organization object into an XML document
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
        /// Deserializes workflow markup into an UKCT_MT120201UK04Organization object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output UKCT_MT120201UK04Organization object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out UKCT_MT120201UK04Organization obj, out System.Exception exception) {
            exception = null;
            obj = default(UKCT_MT120201UK04Organization);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out UKCT_MT120201UK04Organization obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static UKCT_MT120201UK04Organization Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((UKCT_MT120201UK04Organization)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current UKCT_MT120201UK04Organization object into file
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
        /// Deserializes xml markup from file into an UKCT_MT120201UK04Organization object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output UKCT_MT120201UK04Organization object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out UKCT_MT120201UK04Organization obj, out System.Exception exception) {
            exception = null;
            obj = default(UKCT_MT120201UK04Organization);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out UKCT_MT120201UK04Organization obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static UKCT_MT120201UK04Organization LoadFromFile(string fileName) {
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
        /// Create a clone of this UKCT_MT120201UK04Organization object
        /// </summary>
        public virtual UKCT_MT120201UK04Organization Clone() {
            return ((UKCT_MT120201UK04Organization)(this.MemberwiseClone()));
        }
        #endregion
    }
}
