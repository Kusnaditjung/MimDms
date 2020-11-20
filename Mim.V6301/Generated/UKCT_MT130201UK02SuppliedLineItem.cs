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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="UKCT_MT130201UK02.SuppliedLineItem", Namespace="urn:hl7-org:v3")]
    [System.Xml.Serialization.XmlRootAttribute("UKCT_MT130201UK02.SuppliedLineItem", Namespace="urn:hl7-org:v3")]
    public partial class UKCT_MT130201UK02SuppliedLineItem {
        
        private II idField;
        
        private CD codeField;
        
        private SXCM_TS effectiveTimeField;
        
        private IVL_INT repeatNumberField;
        
        private IVL_PQ doseQuantityField;
        
        private IVL_PQ rateQuantityField;
        
        private UKCT_MT130201UK02Consumable consumableField;
        
        private UKCT_MT130201UK02PertinentInformation31 pertinentInformation1Field;
        
        private UKCT_MT130201UK02PertinentInformation32 pertinentInformation2Field;
        
        private UKCT_MT130201UK02PertinentInformation33 pertinentInformation3Field;
        
        private UKCT_MT130201UK02PertinentInformation34[] pertinentInformation4Field;
        
        private UKCT_MT130201UK02PertinentInformation35 pertinentInformation5Field;
        
        private UKCT_MT130201UK02InFulfillmentOf1 inFulfillmentOfField;
        
        private UKCT_MT130201UK02Predecessor1 predecessorField;
        
        private string typeField;
        
        private string classCodeField;
        
        private string moodCodeField;
        
        private string[] typeIDField;
        
        private string[] realmCodeField;
        
        private string nullFlavorField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public UKCT_MT130201UK02SuppliedLineItem() {
            this.typeField = "SubstanceAdministration";
            this.classCodeField = "SBADM";
            this.moodCodeField = "PRMS";
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
        
        public SXCM_TS effectiveTime {
            get {
                return this.effectiveTimeField;
            }
            set {
                this.effectiveTimeField = value;
            }
        }
        
        public IVL_INT repeatNumber {
            get {
                return this.repeatNumberField;
            }
            set {
                this.repeatNumberField = value;
            }
        }
        
        public IVL_PQ doseQuantity {
            get {
                return this.doseQuantityField;
            }
            set {
                this.doseQuantityField = value;
            }
        }
        
        public IVL_PQ rateQuantity {
            get {
                return this.rateQuantityField;
            }
            set {
                this.rateQuantityField = value;
            }
        }
        
        public UKCT_MT130201UK02Consumable consumable {
            get {
                return this.consumableField;
            }
            set {
                this.consumableField = value;
            }
        }
        
        public UKCT_MT130201UK02PertinentInformation31 pertinentInformation1 {
            get {
                return this.pertinentInformation1Field;
            }
            set {
                this.pertinentInformation1Field = value;
            }
        }
        
        public UKCT_MT130201UK02PertinentInformation32 pertinentInformation2 {
            get {
                return this.pertinentInformation2Field;
            }
            set {
                this.pertinentInformation2Field = value;
            }
        }
        
        public UKCT_MT130201UK02PertinentInformation33 pertinentInformation3 {
            get {
                return this.pertinentInformation3Field;
            }
            set {
                this.pertinentInformation3Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("pertinentInformation4")]
        public UKCT_MT130201UK02PertinentInformation34[] pertinentInformation4 {
            get {
                return this.pertinentInformation4Field;
            }
            set {
                this.pertinentInformation4Field = value;
            }
        }
        
        public UKCT_MT130201UK02PertinentInformation35 pertinentInformation5 {
            get {
                return this.pertinentInformation5Field;
            }
            set {
                this.pertinentInformation5Field = value;
            }
        }
        
        public UKCT_MT130201UK02InFulfillmentOf1 inFulfillmentOf {
            get {
                return this.inFulfillmentOfField;
            }
            set {
                this.inFulfillmentOfField = value;
            }
        }
        
        public UKCT_MT130201UK02Predecessor1 predecessor {
            get {
                return this.predecessorField;
            }
            set {
                this.predecessorField = value;
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
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(UKCT_MT130201UK02SuppliedLineItem));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current UKCT_MT130201UK02SuppliedLineItem object into an XML document
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
        /// Deserializes workflow markup into an UKCT_MT130201UK02SuppliedLineItem object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output UKCT_MT130201UK02SuppliedLineItem object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out UKCT_MT130201UK02SuppliedLineItem obj, out System.Exception exception) {
            exception = null;
            obj = default(UKCT_MT130201UK02SuppliedLineItem);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out UKCT_MT130201UK02SuppliedLineItem obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static UKCT_MT130201UK02SuppliedLineItem Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((UKCT_MT130201UK02SuppliedLineItem)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current UKCT_MT130201UK02SuppliedLineItem object into file
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
        /// Deserializes xml markup from file into an UKCT_MT130201UK02SuppliedLineItem object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output UKCT_MT130201UK02SuppliedLineItem object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out UKCT_MT130201UK02SuppliedLineItem obj, out System.Exception exception) {
            exception = null;
            obj = default(UKCT_MT130201UK02SuppliedLineItem);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out UKCT_MT130201UK02SuppliedLineItem obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static UKCT_MT130201UK02SuppliedLineItem LoadFromFile(string fileName) {
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
        /// Create a clone of this UKCT_MT130201UK02SuppliedLineItem object
        /// </summary>
        public virtual UKCT_MT130201UK02SuppliedLineItem Clone() {
            return ((UKCT_MT130201UK02SuppliedLineItem)(this.MemberwiseClone()));
        }
        #endregion
    }
}
