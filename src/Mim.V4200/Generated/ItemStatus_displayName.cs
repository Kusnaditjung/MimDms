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
    public enum ItemStatus_displayName {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Item fully dispensed")]
        Itemfullydispensed,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Item not dispensed")]
        Itemnotdispensed,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Item dispensed - partial")]
        Itemdispensedpartial,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Item not dispensed owing")]
        Itemnotdispensedowing,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Item cancelled")]
        Itemcancelled,
        
        /// <remarks/>
        Expired,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Item to be dispensed")]
        Itemtobedispensed,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Item with dispenser")]
        Itemwithdispenser,
    }
}
