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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="QUPA_IN000016UK02.QUQI_MT050000UK01.ControlActEvent", Namespace="urn:hl7-org:v3")]
    [System.Xml.Serialization.XmlRootAttribute("QUPA_IN000016UK02.QUQI_MT050000UK01.ControlActEvent", Namespace="urn:hl7-org:v3")]
    public partial class QUPA_IN000016UK02QUQI_MT050000UK01ControlActEvent {
        
        private QUQI_MT050000UK01Author authorField;
        
        private QUQI_MT050000UK01Author2[] author1Field;
        
        private QUPA_MT000004UK01Query queryField;
        
        private string nullFlavorField;
        
        private cs_UpdateMode updateModeField;
        
        private bool updateModeFieldSpecified;
        
        private string classCodeField;
        
        private string moodCodeField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        [System.Xml.Serialization.XmlElementAttribute()]
        public QUQI_MT050000UK01Author author {
            get {
                return this.authorField;
            }
            set {
                this.authorField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("author1")]
        public QUQI_MT050000UK01Author2[] author1 {
            get {
                return this.author1Field;
            }
            set {
                this.author1Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute()]
        public QUPA_MT000004UK01Query query {
            get {
                return this.queryField;
            }
            set {
                this.queryField = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string moodCode {
            get {
                return this.moodCodeField;
            }
            set {
                this.moodCodeField = value;
            }
        }
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(QUPA_IN000016UK02QUQI_MT050000UK01ControlActEvent));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current QUPA_IN000016UK02QUQI_MT050000UK01ControlActEvent object into an XML document
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
        /// Deserializes workflow markup into an QUPA_IN000016UK02QUQI_MT050000UK01ControlActEvent object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output QUPA_IN000016UK02QUQI_MT050000UK01ControlActEvent object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out QUPA_IN000016UK02QUQI_MT050000UK01ControlActEvent obj, out System.Exception exception) {
            exception = null;
            obj = default(QUPA_IN000016UK02QUQI_MT050000UK01ControlActEvent);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out QUPA_IN000016UK02QUQI_MT050000UK01ControlActEvent obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static QUPA_IN000016UK02QUQI_MT050000UK01ControlActEvent Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((QUPA_IN000016UK02QUQI_MT050000UK01ControlActEvent)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current QUPA_IN000016UK02QUQI_MT050000UK01ControlActEvent object into file
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
        /// Deserializes xml markup from file into an QUPA_IN000016UK02QUQI_MT050000UK01ControlActEvent object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output QUPA_IN000016UK02QUQI_MT050000UK01ControlActEvent object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out QUPA_IN000016UK02QUQI_MT050000UK01ControlActEvent obj, out System.Exception exception) {
            exception = null;
            obj = default(QUPA_IN000016UK02QUQI_MT050000UK01ControlActEvent);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out QUPA_IN000016UK02QUQI_MT050000UK01ControlActEvent obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static QUPA_IN000016UK02QUQI_MT050000UK01ControlActEvent LoadFromFile(string fileName) {
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
        /// Create a clone of this QUPA_IN000016UK02QUQI_MT050000UK01ControlActEvent object
        /// </summary>
        public virtual QUPA_IN000016UK02QUQI_MT050000UK01ControlActEvent Clone() {
            return ((QUPA_IN000016UK02QUQI_MT050000UK01ControlActEvent)(this.MemberwiseClone()));
        }
        #endregion
    }
}
