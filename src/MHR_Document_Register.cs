﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.9151
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 
namespace Nehta.VendorLibrary.PCEHR.DocumentRegister {
    using Newtonsoft.Json;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ns.electronichealth.net.au/pcehr/xsd/common/DocumentCoreElements/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ns.electronichealth.net.au/pcehr/xsd/common/DocumentCoreElements/1.0", IsNullable=false)]
    public partial class DocumentRegister {
        
        private System.DateTime creationDateField;
        
        private int versionField;
        
        private Tag[] tagsField;
        
        private DocumentClassCodeType[] documentTypesField;
        
        /// <remarks/>
        public System.DateTime creationDate {
            get {
                return this.creationDateField;
            }
            set {
                this.creationDateField = value;
            }
        }
        
        /// <remarks/>
        public int version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("tag", IsNullable=false)]
        public Tag[] tags {
            get {
                return this.tagsField;
            }
            set {
                this.tagsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("documentType", IsNullable=false)]
        public DocumentClassCodeType[] documentTypes {
            get {
                return this.documentTypesField;
            }
            set {
                this.documentTypesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ns.electronichealth.net.au/pcehr/xsd/common/DocumentCoreElements/1.0")]
    public partial class Tag {
        
        private string nameField;
        
        private string descriptionField;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ns.electronichealth.net.au/pcehr/xsd/common/DocumentCoreElements/1.0")]
    public partial class TagName {
        
        private RelationshipType relationshipField;
        
        private bool relationshipFieldSpecified;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RelationshipType relationship {
            get {
                return this.relationshipField;
            }
            set {
                this.relationshipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [JsonIgnore]
        public bool relationshipSpecified {
            get {
                return this.relationshipFieldSpecified;
            }
            set {
                this.relationshipFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ns.electronichealth.net.au/pcehr/xsd/common/DocumentCoreElements/1.0")]
    public enum RelationshipType {
        
        /// <remarks/>
        Primary,
        
        /// <remarks/>
        Secondary,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ns.electronichealth.net.au/pcehr/xsd/common/DocumentCoreElements/1.0")]
    public partial class DocumentTypeCodeType {
        
        private string codeField;
        
        private string codeSystemField;
        
        private string codeSystemNameField;
        
        private string categoryField;
        
        private string displayNameField;
        
        private string descriptionField;
        
        private System.DateTime activationDateField;
        
        private System.DateTime deprecationDateField;
        
        private bool deprecationDateFieldSpecified;
        
        private System.DateTime retirementDateField;
        
        private bool retirementDateFieldSpecified;
        
        private Actor[] actorsField;
        
        private TagName[] tagsField;
        
        /// <remarks/>
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        public string codeSystem {
            get {
                return this.codeSystemField;
            }
            set {
                this.codeSystemField = value;
            }
        }
        
        /// <remarks/>
        public string codeSystemName {
            get {
                return this.codeSystemNameField;
            }
            set {
                this.codeSystemNameField = value;
            }
        }
        
        /// <remarks/>
        public string category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
        
        /// <remarks/>
        public string displayName {
            get {
                return this.displayNameField;
            }
            set {
                this.displayNameField = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime activationDate {
            get {
                return this.activationDateField;
            }
            set {
                this.activationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime deprecationDate {
            get {
                return this.deprecationDateField;
            }
            set {
                this.deprecationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [JsonIgnore]
        public bool deprecationDateSpecified {
            get {
                return this.deprecationDateFieldSpecified;
            }
            set {
                this.deprecationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime retirementDate {
            get {
                return this.retirementDateField;
            }
            set {
                this.retirementDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [JsonIgnore]
        public bool retirementDateSpecified {
            get {
                return this.retirementDateFieldSpecified;
            }
            set {
                this.retirementDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("actor", IsNullable=false)]
        public Actor[] actors {
            get {
                return this.actorsField;
            }
            set {
                this.actorsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("name", IsNullable=false)]
        public TagName[] tags {
            get {
                return this.tagsField;
            }
            set {
                this.tagsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ns.electronichealth.net.au/pcehr/xsd/common/DocumentCoreElements/1.0")]
    public partial class Actor {
        
        private UploadAction uploadField;
        
        private bool uploadFieldSpecified;
        
        private Download downloadField;
        
        private ActorType typeField;
        
        private bool typeFieldSpecified;
        
        /// <remarks/>
        public UploadAction upload {
            get {
                return this.uploadField;
            }
            set {
                this.uploadField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [JsonIgnore]
        public bool uploadSpecified {
            get {
                return this.uploadFieldSpecified;
            }
            set {
                this.uploadFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Download download {
            get {
                return this.downloadField;
            }
            set {
                this.downloadField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ActorType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [JsonIgnore]
        public bool typeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ns.electronichealth.net.au/pcehr/xsd/common/DocumentCoreElements/1.0")]
    public enum UploadAction {
        
        /// <remarks/>
        Consumer,
        
        /// <remarks/>
        Default,
        
        /// <remarks/>
        Medicare,
        
        /// <remarks/>
        NPDR,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ns.electronichealth.net.au/pcehr/xsd/common/DocumentCoreElements/1.0")]
    public partial class Download {
        
        private bool accessibleField;
        
        private bool accessibleFieldSpecified;
        
        private bool requestableField;
        
        private bool requestableFieldSpecified;
        
        private bool recommendedField;
        
        private bool recommendedFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool accessible {
            get {
                return this.accessibleField;
            }
            set {
                this.accessibleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [JsonIgnore]
        public bool accessibleSpecified {
            get {
                return this.accessibleFieldSpecified;
            }
            set {
                this.accessibleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool requestable {
            get {
                return this.requestableField;
            }
            set {
                this.requestableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [JsonIgnore]
        public bool requestableSpecified {
            get {
                return this.requestableFieldSpecified;
            }
            set {
                this.requestableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool recommended {
            get {
                return this.recommendedField;
            }
            set {
                this.recommendedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [JsonIgnore]
        public bool recommendedSpecified {
            get {
                return this.recommendedFieldSpecified;
            }
            set {
                this.recommendedFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ns.electronichealth.net.au/pcehr/xsd/common/DocumentCoreElements/1.0")]
    public enum ActorType {
        
        /// <remarks/>
        CIS,
        
        /// <remarks/>
        CRP,
        
        /// <remarks/>
        CSP,
        
        /// <remarks/>
        MOS,
        
        /// <remarks/>
        NCP,
        
        /// <remarks/>
        NPP,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ns.electronichealth.net.au/pcehr/xsd/common/DocumentCoreElements/1.0")]
    public partial class DocumentClassCodeType {
        
        private string codeField;
        
        private string codeSystemField;
        
        private string codeSystemNameField;
        
        private string displayNameField;
        
        private DocumentGenerationClassificationType documentGenerationClassificationField;
        
        private Actor[] actorsField;
        
        private string descriptionField;
        
        private DocumentTypeCodeType[] documentSubTypesField;
        
        /// <remarks/>
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        public string codeSystem {
            get {
                return this.codeSystemField;
            }
            set {
                this.codeSystemField = value;
            }
        }
        
        /// <remarks/>
        public string codeSystemName {
            get {
                return this.codeSystemNameField;
            }
            set {
                this.codeSystemNameField = value;
            }
        }
        
        /// <remarks/>
        public string displayName {
            get {
                return this.displayNameField;
            }
            set {
                this.displayNameField = value;
            }
        }
        
        /// <remarks/>
        public DocumentGenerationClassificationType documentGenerationClassification {
            get {
                return this.documentGenerationClassificationField;
            }
            set {
                this.documentGenerationClassificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("actor", IsNullable=false)]
        public Actor[] actors {
            get {
                return this.actorsField;
            }
            set {
                this.actorsField = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("documentSubTypes")]
        public DocumentTypeCodeType[] documentSubTypes {
            get {
                return this.documentSubTypesField;
            }
            set {
                this.documentSubTypesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ns.electronichealth.net.au/pcehr/xsd/common/DocumentCoreElements/1.0")]
    public enum DocumentGenerationClassificationType {
        
        /// <remarks/>
        Document,
        
        /// <remarks/>
        DocumentView,
    }
}
