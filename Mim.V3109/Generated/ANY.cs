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
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EN))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TN))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ON))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PN))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AD))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(II))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CD))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CE))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CV))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PQR))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CR))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QTY))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RTO_QTY_QTY))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(REAL))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(INT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVXB_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SXCM_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVL_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(URL))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TEL))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BIN))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ED))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ST))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ENXP))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ensuffix))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(enprefix))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(engiven))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(enfamily))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(endelimiter))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ADXP))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SC))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(thumbnail))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BN))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BL))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.18239")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
    public abstract partial class ANY {
        
        private cs_NullFlavor nullFlavorField;
        
        private bool nullFlavorFieldSpecified;
        
        private cs_UpdateMode updateModeField;
        
        private bool updateModeFieldSpecified;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public cs_NullFlavor nullFlavor {
            get {
                return this.nullFlavorField;
            }
            set {
                this.nullFlavorField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nullFlavorSpecified {
            get {
                return this.nullFlavorFieldSpecified;
            }
            set {
                this.nullFlavorFieldSpecified = value;
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
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(ANY));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current ANY object into an XML document
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
        /// Deserializes workflow markup into an ANY object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output ANY object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out ANY obj, out System.Exception exception) {
            exception = null;
            obj = default(ANY);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out ANY obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static ANY Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((ANY)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current ANY object into file
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
        /// Deserializes xml markup from file into an ANY object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output ANY object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out ANY obj, out System.Exception exception) {
            exception = null;
            obj = default(ANY);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out ANY obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static ANY LoadFromFile(string fileName) {
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
        /// Create a clone of this ANY object
        /// </summary>
        public virtual ANY Clone() {
            return ((ANY)(this.MemberwiseClone()));
        }
        #endregion
    }
}
