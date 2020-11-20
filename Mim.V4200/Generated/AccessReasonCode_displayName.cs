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
    public enum AccessReasonCode_displayName {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Public interest")]
        Publicinterest,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Required by statute")]
        Requiredbystatute,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Court order")]
        Courtorder,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Best interests of patient")]
        Bestinterestsofpatient,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Justified through Health & Social Care Act regulations")]
        JustifiedthroughHealthSocialCareActregulations,
        
        /// <remarks/>
        Other,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Express consent to research given")]
        Expressconsenttoresearchgiven,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Express consent to clinical audit given")]
        Expressconsenttoclinicalauditgiven,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Express consent to financial audit given")]
        Expressconsenttofinancialauditgiven,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Express consent to other audit given")]
        Expressconsenttootherauditgiven,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Express consent to public health investigation given")]
        Expressconsenttopublichealthinvestigationgiven,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Express consent given for the purposes of service management")]
        Expressconsentgivenforthepurposesofservicemanagement,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Express consent given in order to respond to patient enquiry")]
        Expressconsentgiveninordertorespondtopatientenquiry,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Express consent given for other purpose(s)")]
        Expressconsentgivenforotherpurposes,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("A colleague outside the team is responding to a patient referral")]
        Acolleagueoutsidetheteamisrespondingtoapatientreferral,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("patient self-referral")]
        patientselfreferral,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("registered patient")]
        registeredpatient,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("express patient consent to access")]
        expresspatientconsenttoaccess,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("subject access request")]
        subjectaccessrequest,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("court order or other legal demand")]
        courtorderorotherlegaldemand,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("patient complaint / litigation")]
        patientcomplaintlitigation,
    }
}
