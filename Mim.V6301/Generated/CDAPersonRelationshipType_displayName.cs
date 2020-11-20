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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:hl7-org:v3", IsNullable=false)]
    public enum CDAPersonRelationshipType_displayName {
        
        /// <remarks/>
        Spouse,
        
        /// <remarks/>
        Partner,
        
        /// <remarks/>
        Parent,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Next of kin")]
        Nextofkin,
        
        /// <remarks/>
        Guardian,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Foster parent")]
        Fosterparent,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Step parent")]
        Stepparent,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Polygamous partner")]
        Polygamouspartner,
        
        /// <remarks/>
        Child,
        
        /// <remarks/>
        Dependant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Non-dependant")]
        Nondependant,
        
        /// <remarks/>
        Mother,
        
        /// <remarks/>
        Father,
        
        /// <remarks/>
        Sister,
        
        /// <remarks/>
        Brother,
        
        /// <remarks/>
        Relative,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Proxy - Contact")]
        ProxyContact,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Proxy - Communication")]
        ProxyCommunication,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Proxy -- Contact and Communication")]
        ProxyContactandCommunication,
        
        /// <remarks/>
        Carer,
        
        /// <remarks/>
        Self,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Not Known")]
        NotKnown,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Not specified")]
        Notspecified,
    }
}
