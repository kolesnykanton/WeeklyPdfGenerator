﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace weekly_namespace.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\test\\source\\repos\\WeeklyP" +
            "dfGenerator\\Dependecies\\Packaging.accdb\"")]
        public string PackagingDBString {
            get {
                return ((string)(this["PackagingDBString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\test\\source\\repos\\WeeklyPdfGenerator\\Dependecies\\xml\\AAAA.xml")]
        public string XmlPath {
            get {
                return ((string)(this["XmlPath"]));
            }
            set {
                this["XmlPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\test\\source\\repos\\WeeklyPdfGenerator\\Dependecies\\Packaging Summary.mrt")]
        public string mrtPath {
            get {
                return ((string)(this["mrtPath"]));
            }
            set {
                this["mrtPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\test\\source\\repos\\WeeklyPdfGenerator\\Friday Report")]
        public string reportDirPath {
            get {
                return ((string)(this["reportDirPath"]));
            }
            set {
                this["reportDirPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("d:\\Friday Report\\#TEMPLATES\\template.oft")]
        public string mailTemplatePath {
            get {
                return ((string)(this["mailTemplatePath"]));
            }
            set {
                this["mailTemplatePath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string mailSubject {
            get {
                return ((string)(this["mailSubject"]));
            }
            set {
                this["mailSubject"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string mailSender {
            get {
                return ((string)(this["mailSender"]));
            }
            set {
                this["mailSender"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string mailReceiver {
            get {
                return ((string)(this["mailReceiver"]));
            }
            set {
                this["mailReceiver"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool isFirstRun {
            get {
                return ((bool)(this["isFirstRun"]));
            }
            set {
                this["isFirstRun"] = value;
            }
        }
    }
}
