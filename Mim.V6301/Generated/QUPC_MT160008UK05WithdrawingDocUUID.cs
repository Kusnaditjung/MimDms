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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="QUPC_MT160008UK05.WithdrawingDocUUID", Namespace="urn:hl7-org:v3")]
    [System.Xml.Serialization.XmlRootAttribute("QUPC_MT160008UK05.WithdrawingDocUUID", Namespace="urn:hl7-org:v3")]
    public partial class QUPC_MT160008UK05WithdrawingDocUUID {
        
        private QUPC_MT160008UK05WithdrawingDocUUIDCode codeField;
        
        private IINPfITuuidmandatory valueField;
        
        private string nullFlavorField;
        
        private cs_UpdateMode updateModeField;
        
        private bool updateModeFieldSpecified;
        
        private string classCodeField;
        
        private string moodCodeField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public QUPC_MT160008UK05WithdrawingDocUUID() {
            this.classCodeField = "OBS";
            this.moodCodeField = "EVN";
        }
        
        public QUPC_MT160008UK05WithdrawingDocUUIDCode code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        public IINPfITuuidmandatory value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
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
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(QUPC_MT160008UK05WithdrawingDocUUID));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current QUPC_MT160008UK05WithdrawingDocUUID object into an XML document
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
        /// Deserializes workflow markup into an QUPC_MT160008UK05WithdrawingDocUUID object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output QUPC_MT160008UK05WithdrawingDocUUID object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out QUPC_MT160008UK05WithdrawingDocUUID obj, out System.Exception exception) {
            exception = null;
            obj = default(QUPC_MT160008UK05WithdrawingDocUUID);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out QUPC_MT160008UK05WithdrawingDocUUID obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static QUPC_MT160008UK05WithdrawingDocUUID Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((QUPC_MT160008UK05WithdrawingDocUUID)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current QUPC_MT160008UK05WithdrawingDocUUID object into file
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
        /// Deserializes xml markup from file into an QUPC_MT160008UK05WithdrawingDocUUID object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output QUPC_MT160008UK05WithdrawingDocUUID object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out QUPC_MT160008UK05WithdrawingDocUUID obj, out System.Exception exception) {
            exception = null;
            obj = default(QUPC_MT160008UK05WithdrawingDocUUID);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out QUPC_MT160008UK05WithdrawingDocUUID obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static QUPC_MT160008UK05WithdrawingDocUUID LoadFromFile(string fileName) {
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
        /// Create a clone of this QUPC_MT160008UK05WithdrawingDocUUID object
        /// </summary>
        public virtual QUPC_MT160008UK05WithdrawingDocUUID Clone() {
            return ((QUPC_MT160008UK05WithdrawingDocUUID)(this.MemberwiseClone()));
        }
        #endregion
    }
}
