// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

// 
//This source code was auto-generated by MonoXSD
//
namespace TagDataTranslation {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:epcglobal:tdt:xsd:1")]
    [System.Xml.Serialization.XmlRootAttribute("epcTagDataTranslation", Namespace="urn:epcglobal:tdt:xsd:1", IsNullable=false)]
    public partial class EpcTagDataTranslation {
        
        private Scheme[] schemeField;
        
        private string versionField;
        
        private System.DateTime dateField;
        
        private string epcTDSVersionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("scheme", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Scheme[] scheme {
            get {
                return this.schemeField;
            }
            set {
                this.schemeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string epcTDSVersion {
            get {
                return this.epcTDSVersionField;
            }
            set {
                this.epcTDSVersionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:epcglobal:tdt:xsd:1")]
    public partial class Scheme {
        
        private Level[] levelField;
        
        private string nameField;
        
        private string optionKeyField;
        
        private string tagLengthField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("level", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Level[] level {
            get {
                return this.levelField;
            }
            set {
                this.levelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string optionKey {
            get {
                return this.optionKeyField;
            }
            set {
                this.optionKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string tagLength {
            get {
                return this.tagLengthField;
            }
            set {
                this.tagLengthField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:epcglobal:tdt:xsd:1")]
    public partial class Level {
        
        private Option[] optionField;
        
        private Rule[] ruleField;
        
        private LevelTypeList typeField;
        
        private string prefixMatchField;
        
        private string requiredParsingParametersField;
        
        private string requiredFormattingParametersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("option", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Option[] option {
            get {
                return this.optionField;
            }
            set {
                this.optionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rule", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Rule[] rule {
            get {
                return this.ruleField;
            }
            set {
                this.ruleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public LevelTypeList type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string prefixMatch {
            get {
                return this.prefixMatchField;
            }
            set {
                this.prefixMatchField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requiredParsingParameters {
            get {
                return this.requiredParsingParametersField;
            }
            set {
                this.requiredParsingParametersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requiredFormattingParameters {
            get {
                return this.requiredFormattingParametersField;
            }
            set {
                this.requiredFormattingParametersField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:epcglobal:tdt:xsd:1")]
    public partial class Option {
        
        private Field[] fieldField;
        
        private string optionKeyField;
        
        private string patternField;
        
        private string grammarField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("field", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Field[] field {
            get {
                return this.fieldField;
            }
            set {
                this.fieldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string optionKey {
            get {
                return this.optionKeyField;
            }
            set {
                this.optionKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pattern {
            get {
                return this.patternField;
            }
            set {
                this.patternField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string grammar {
            get {
                return this.grammarField;
            }
            set {
                this.grammarField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:epcglobal:tdt:xsd:1")]
    public partial class Field {
        
        private string seqField;
        
        private string nameField;
        
        private string bitLengthField;
        
        private string characterSetField;
        
        private CompactionMethodList compactionField;
        
        private bool compactionFieldSpecified;
        
        private string compressionField;
        
        private string padCharField;
        
        private PadDirectionList padDirField;
        
        private bool padDirFieldSpecified;
        
        private PadDirectionList bitPadDirField;
        
        private bool bitPadDirFieldSpecified;
        
        private string decimalMinimumField;
        
        private string decimalMaximumField;
        
        private string lengthField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string seq {
            get {
                return this.seqField;
            }
            set {
                this.seqField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string bitLength {
            get {
                return this.bitLengthField;
            }
            set {
                this.bitLengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string characterSet {
            get {
                return this.characterSetField;
            }
            set {
                this.characterSetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CompactionMethodList compaction {
            get {
                return this.compactionField;
            }
            set {
                this.compactionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool compactionSpecified {
            get {
                return this.compactionFieldSpecified;
            }
            set {
                this.compactionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string compression {
            get {
                return this.compressionField;
            }
            set {
                this.compressionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string padChar {
            get {
                return this.padCharField;
            }
            set {
                this.padCharField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PadDirectionList padDir {
            get {
                return this.padDirField;
            }
            set {
                this.padDirField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool padDirSpecified {
            get {
                return this.padDirFieldSpecified;
            }
            set {
                this.padDirFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PadDirectionList bitPadDir {
            get {
                return this.bitPadDirField;
            }
            set {
                this.bitPadDirField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bitPadDirSpecified {
            get {
                return this.bitPadDirFieldSpecified;
            }
            set {
                this.bitPadDirFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string decimalMinimum {
            get {
                return this.decimalMinimumField;
            }
            set {
                this.decimalMinimumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string decimalMaximum {
            get {
                return this.decimalMaximumField;
            }
            set {
                this.decimalMaximumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string length {
            get {
                return this.lengthField;
            }
            set {
                this.lengthField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:epcglobal:tdt:xsd:1")]
    public enum CompactionMethodList {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("32-bit")]
        Item32bit,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16-bit")]
        Item16bit,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8-bit")]
        Item8bit,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7-bit")]
        Item7bit,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6-bit")]
        Item6bit,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5-bit")]
        Item5bit,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:epcglobal:tdt:xsd:1")]
    public enum PadDirectionList {
        
        /// <remarks/>
        LEFT,
        
        /// <remarks/>
        RIGHT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:epcglobal:tdt:xsd:1")]
    public partial class GEPC64Entry {
        
        private string indexField;
        
        private string companyPrefixField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string index {
            get {
                return this.indexField;
            }
            set {
                this.indexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string companyPrefix {
            get {
                return this.companyPrefixField;
            }
            set {
                this.companyPrefixField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:epcglobal:tdt:xsd:1")]
    public partial class Rule {
        
        private ModeList typeField;
        
        private InputFormatList inputFormatField;
        
        private string seqField;
        
        private string newFieldNameField;
        
        private string characterSetField;
        
        private string padCharField;
        
        private PadDirectionList padDirField;
        
        private bool padDirFieldSpecified;
        
        private PadDirectionList bitPadDirField;
        
        private bool bitPadDirFieldSpecified;
        
        private string bitLengthField;
        
        private string decimalMinimumField;
        
        private string decimalMaximumField;
        
        private string lengthField;
        
        private string functionField;
        
        private string tableURLField;
        
        private string tableParamsField;
        
        private string tableXPathField;
        
        private string tableSQLField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ModeList type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InputFormatList inputFormat {
            get {
                return this.inputFormatField;
            }
            set {
                this.inputFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string seq {
            get {
                return this.seqField;
            }
            set {
                this.seqField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string newFieldName {
            get {
                return this.newFieldNameField;
            }
            set {
                this.newFieldNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string characterSet {
            get {
                return this.characterSetField;
            }
            set {
                this.characterSetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string padChar {
            get {
                return this.padCharField;
            }
            set {
                this.padCharField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PadDirectionList padDir {
            get {
                return this.padDirField;
            }
            set {
                this.padDirField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool padDirSpecified {
            get {
                return this.padDirFieldSpecified;
            }
            set {
                this.padDirFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PadDirectionList bitPadDir {
            get {
                return this.bitPadDirField;
            }
            set {
                this.bitPadDirField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bitPadDirSpecified {
            get {
                return this.bitPadDirFieldSpecified;
            }
            set {
                this.bitPadDirFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string bitLength {
            get {
                return this.bitLengthField;
            }
            set {
                this.bitLengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string decimalMinimum {
            get {
                return this.decimalMinimumField;
            }
            set {
                this.decimalMinimumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string decimalMaximum {
            get {
                return this.decimalMaximumField;
            }
            set {
                this.decimalMaximumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string length {
            get {
                return this.lengthField;
            }
            set {
                this.lengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string function {
            get {
                return this.functionField;
            }
            set {
                this.functionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tableURL {
            get {
                return this.tableURLField;
            }
            set {
                this.tableURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tableParams {
            get {
                return this.tableParamsField;
            }
            set {
                this.tableParamsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tableXPath {
            get {
                return this.tableXPathField;
            }
            set {
                this.tableXPathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tableSQL {
            get {
                return this.tableSQLField;
            }
            set {
                this.tableSQLField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:epcglobal:tdt:xsd:1")]
    public enum ModeList {
        
        /// <remarks/>
        EXTRACT,
        
        /// <remarks/>
        FORMAT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:epcglobal:tdt:xsd:1")]
    public enum InputFormatList {
        
        /// <remarks/>
        BINARY,
        
        /// <remarks/>
        STRING,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:epcglobal:tdt:xsd:1")]
    public enum LevelTypeList {
        
        /// <remarks/>
        BINARY,
        
        /// <remarks/>
        TAG_ENCODING,
        
        /// <remarks/>
        PURE_IDENTITY,
        
        /// <remarks/>
        LEGACY,
        
        /// <remarks/>
        LEGACY_ALT,
        
        /// <remarks/>
        LEGACY_AI,
        
        /// <remarks/>
        ELEMENT_STRING,
        
        /// <remarks/>
        TEI,
        
        /// <remarks/>
        ONS_HOSTNAME,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:epcglobal:tdt:xsd:1")]
    [System.Xml.Serialization.XmlRootAttribute("GEPC64Table", Namespace="urn:epcglobal:tdt:xsd:1", IsNullable=false)]
    public partial class GEPC64 {
        
        private GEPC64Entry[] entryField;
        
        private System.DateTime dateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("entry", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GEPC64Entry[] entry {
            get {
                return this.entryField;
            }
            set {
                this.entryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
            }
        }
    }
}
