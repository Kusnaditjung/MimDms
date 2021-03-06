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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:hl7-org:v3", IsNullable=false)]
    public enum PrescriptionAnnotation_displayName {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Description (and related table name)")]
        Descriptionandrelatedtablename,
        
        /// <remarks/>
        PrescriptionStatus,
        
        /// <remarks/>
        ItemStatus,
        
        /// <remarks/>
        NotDispensedReason,
        
        /// <remarks/>
        DispenserEndorsement,
        
        /// <remarks/>
        PrescriberEndorsement,
        
        /// <remarks/>
        PrescriptionChargeExemption,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Supply Instructions")]
        SupplyInstructions,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Evidence Seen")]
        EvidenceSeen,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Running Total")]
        RunningTotal,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Dose Instructions")]
        DoseInstructions,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Additional Instructions")]
        AdditionalInstructions,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Justification for Use")]
        JustificationforUse,
        
        /// <remarks/>
        DispenseReturnReason,
        
        /// <remarks/>
        ReimbursementRejectionReason,
        
        /// <remarks/>
        PrescriptionReleaseRejectionReason,
        
        /// <remarks/>
        ETPSpineRejectionReasons,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("ETPSpineRejectionReasons")]
        ETPSpineRejectionReasons1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Charge Paid")]
        ChargePaid,
        
        /// <remarks/>
        CancellationResponseReason,
        
        /// <remarks/>
        CancellationReason,
        
        /// <remarks/>
        ETPSPineRejectionReasons,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Prescription Type")]
        PrescriptionType,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Dispensing Site Preference")]
        DispensingSitePreference,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Prescription Treatment Type")]
        PrescriptionTreatmentType,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Review Date")]
        ReviewDate,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Parent Prescription Rejection Reason")]
        ParentPrescriptionRejectionReason,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Protocol Condition")]
        ProtocolCondition,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Medication administration Instructions")]
        MedicationadministrationInstructions,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Medication administration type")]
        Medicationadministrationtype,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("When to discontinue a medication administration")]
        Whentodiscontinueamedicationadministration,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Repeat Prescription Instance")]
        RepeatPrescriptionInstance,
        
        /// <remarks/>
        PrescriptionWithdrawType,
        
        /// <remarks/>
        PrescriptionWithdrawReason,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Token Issued")]
        TokenIssued,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Prescription Identifier")]
        PrescriptionIdentifier,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Replacement Information")]
        ReplacementInformation,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Previous Issue Identifier")]
        PreviousIssueIdentifier,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Previous Issue Date")]
        PreviousIssueDate,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Withdraw Statement Identifier")]
        WithdrawStatementIdentifier,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Issue Date")]
        IssueDate,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Last Activity Date")]
        LastActivityDate,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Cancellation Pending")]
        CancellationPending,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("PrescriptionWithdrawType")]
        PrescriptionWithdrawType1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("PrescriptionWithdrawReason")]
        PrescriptionWithdrawReason1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Prescription Supporting Information")]
        PrescriptionSupportingInformation,
    }
}
