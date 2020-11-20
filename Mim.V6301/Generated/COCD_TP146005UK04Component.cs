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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="COCD_TP146005UK04.Component", Namespace="urn:hl7-org:v3")]
    public partial class COCD_TP146005UK04Component {
        
        private TemplateContent contentIdField;
        
        private COCD_TP146005UK04ComponentSeperatableInd seperatableIndField;
        
        private COCD_TP146005UK04ComponentTemplateId templateIdField;
        
        private object itemField;
        
        private string nullFlavorField;
        
        private cs_UpdateMode updateModeField;
        
        private bool updateModeFieldSpecified;
        
        private string typeCodeField;
        
        private bool contextConductionIndField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public COCD_TP146005UK04Component() {
            this.typeCodeField = "COMP";
            this.contextConductionIndField = false;
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="NPFIT:HL7:Localisation")]
        public TemplateContent contentId {
            get {
                return this.contentIdField;
            }
            set {
                this.contentIdField = value;
            }
        }
        
        public COCD_TP146005UK04ComponentSeperatableInd seperatableInd {
            get {
                return this.seperatableIndField;
            }
            set {
                this.seperatableIndField = value;
            }
        }
        
        public COCD_TP146005UK04ComponentTemplateId templateId {
            get {
                return this.templateIdField;
            }
            set {
                this.templateIdField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147001UK03.LifeStyleRef", typeof(COCD_TP147001UK03LifeStyleRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147002UK03.SmokingRef", typeof(COCD_TP147002UK03SmokingRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147003UK03.AlcoholIntakeRef", typeof(COCD_TP147003UK03AlcoholIntakeRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147004UK03.SocialOrPersonalCircumstanceRef", typeof(COCD_TP147004UK03SocialOrPersonalCircumstanceRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147010UK03.RiskToPersonRef", typeof(COCD_TP147010UK03RiskToPersonRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147011UK03.DiagnosisRef", typeof(COCD_TP147011UK03DiagnosisRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147012UK03.FindingRef", typeof(COCD_TP147012UK03FindingRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147013UK03.BloodPressureRef", typeof(COCD_TP147013UK03BloodPressureRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147014UK03.WeightRef", typeof(COCD_TP147014UK03WeightRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147015UK03.HeightRef", typeof(COCD_TP147015UK03HeightRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147016UK03.TemperatureRef", typeof(COCD_TP147016UK03TemperatureRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147017UK03.FindingOrganizerRef", typeof(COCD_TP147017UK03FindingOrganizerRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147018UK03.FamilyHistoryRef", typeof(COCD_TP147018UK03FamilyHistoryRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147019UK03.InvestigationRef", typeof(COCD_TP147019UK03InvestigationRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147020UK03.PersonalPreferenceRef", typeof(COCD_TP147020UK03PersonalPreferenceRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147021UK03.ServiceRef", typeof(COCD_TP147021UK03ServiceRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147022UK03.AllergicOrAdverseReactionEventRef", typeof(COCD_TP147022UK03AllergicOrAdverseReactionEventRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147023UK03.ProvisionOfAdviceAndInformationRef", typeof(COCD_TP147023UK03ProvisionOfAdviceAndInformationRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147024UK03.AdministrativeProcedureRef", typeof(COCD_TP147024UK03AdministrativeProcedureRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147025UK03.AllergyPropensityRef", typeof(COCD_TP147025UK03AllergyPropensityRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147026UK03.RiskToPatientRef", typeof(COCD_TP147026UK03RiskToPatientRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147027UK03.TreatmentRef", typeof(COCD_TP147027UK03TreatmentRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147029UK04.MedicationAdministrationDoseRef", typeof(COCD_TP147029UK04MedicationAdministrationDoseRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147030UK04.MedicationAdministrationCourseRef", typeof(COCD_TP147030UK04MedicationAdministrationCourseRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147031UK04.PlanMedicationAdministrationRef", typeof(COCD_TP147031UK04PlanMedicationAdministrationRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147032UK03.RequestMedicationSupplyRef", typeof(COCD_TP147032UK03RequestMedicationSupplyRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147033UK03.SupplyMedicationRef", typeof(COCD_TP147033UK03SupplyMedicationRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147034UK03.RequestMedicationAdministrationRef", typeof(COCD_TP147034UK03RequestMedicationAdministrationRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147037UK03.PatientMovementRef", typeof(COCD_TP147037UK03PatientMovementRef))]
        [System.Xml.Serialization.XmlElementAttribute("COCD_TP147038UK03.DischargeRef", typeof(COCD_TP147038UK03DischargeRef))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
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
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(COCD_TP146005UK04Component));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current COCD_TP146005UK04Component object into an XML document
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
        /// Deserializes workflow markup into an COCD_TP146005UK04Component object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output COCD_TP146005UK04Component object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out COCD_TP146005UK04Component obj, out System.Exception exception) {
            exception = null;
            obj = default(COCD_TP146005UK04Component);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out COCD_TP146005UK04Component obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static COCD_TP146005UK04Component Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((COCD_TP146005UK04Component)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current COCD_TP146005UK04Component object into file
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
        /// Deserializes xml markup from file into an COCD_TP146005UK04Component object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output COCD_TP146005UK04Component object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out COCD_TP146005UK04Component obj, out System.Exception exception) {
            exception = null;
            obj = default(COCD_TP146005UK04Component);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out COCD_TP146005UK04Component obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static COCD_TP146005UK04Component LoadFromFile(string fileName) {
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
        /// Create a clone of this COCD_TP146005UK04Component object
        /// </summary>
        public virtual COCD_TP146005UK04Component Clone() {
            return ((COCD_TP146005UK04Component)(this.MemberwiseClone()));
        }
        #endregion
    }
}
