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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="POCD_IN160003UK06.MCAI_MT040101UK03.Subject", Namespace="urn:hl7-org:v3")]
    [System.Xml.Serialization.XmlRootAttribute("POCD_IN160003UK06.MCAI_MT040101UK03.Subject", Namespace="urn:hl7-org:v3")]
    public partial class POCD_IN160003UK06MCAI_MT040101UK03Subject {
        
        private POCD_MT000001UK04ClinicalDocument clinicalDocumentField;
        
        private string nullFlavorField;
        
        private cs_UpdateMode updateModeField;
        
        private bool updateModeFieldSpecified;
        
        private string typeCodeField;
        
        private bool contextConductionIndField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public POCD_IN160003UK06MCAI_MT040101UK03Subject() {
            this.typeCodeField = "SUBJ";
            this.contextConductionIndField = false;
        }
        
        [System.Xml.Serialization.XmlElementAttribute()]
        public POCD_MT000001UK04ClinicalDocument ClinicalDocument {
            get {
                return this.clinicalDocumentField;
            }
            set {
                this.clinicalDocumentField = value;
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
        public string typeCode {
            get {
                return this.typeCodeField;
            }
            set {
                this.typeCodeField = value;
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
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(POCD_IN160003UK06MCAI_MT040101UK03Subject));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current POCD_IN160003UK06MCAI_MT040101UK03Subject object into an XML document
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
        /// Deserializes workflow markup into an POCD_IN160003UK06MCAI_MT040101UK03Subject object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output POCD_IN160003UK06MCAI_MT040101UK03Subject object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out POCD_IN160003UK06MCAI_MT040101UK03Subject obj, out System.Exception exception) {
            exception = null;
            obj = default(POCD_IN160003UK06MCAI_MT040101UK03Subject);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out POCD_IN160003UK06MCAI_MT040101UK03Subject obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static POCD_IN160003UK06MCAI_MT040101UK03Subject Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((POCD_IN160003UK06MCAI_MT040101UK03Subject)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current POCD_IN160003UK06MCAI_MT040101UK03Subject object into file
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
        /// Deserializes xml markup from file into an POCD_IN160003UK06MCAI_MT040101UK03Subject object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output POCD_IN160003UK06MCAI_MT040101UK03Subject object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out POCD_IN160003UK06MCAI_MT040101UK03Subject obj, out System.Exception exception) {
            exception = null;
            obj = default(POCD_IN160003UK06MCAI_MT040101UK03Subject);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out POCD_IN160003UK06MCAI_MT040101UK03Subject obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static POCD_IN160003UK06MCAI_MT040101UK03Subject LoadFromFile(string fileName) {
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
        /// Create a clone of this POCD_IN160003UK06MCAI_MT040101UK03Subject object
        /// </summary>
        public virtual POCD_IN160003UK06MCAI_MT040101UK03Subject Clone() {
            return ((POCD_IN160003UK06MCAI_MT040101UK03Subject)(this.MemberwiseClone()));
        }
        #endregion
    }
}
