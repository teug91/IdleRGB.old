﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IdleRGB.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:05:00")]
        public global::System.TimeSpan idleTime {
            get {
                return ((global::System.TimeSpan)(this["idleTime"]));
            }
            set {
                this["idleTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color idleColor {
            get {
                return ((global::System.Drawing.Color)(this["idleColor"]));
            }
            set {
                this["idleColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255, 109, 63")]
        public global::System.Drawing.Color capsColor {
            get {
                return ((global::System.Drawing.Color)(this["capsColor"]));
            }
            set {
                this["capsColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255, 17, 45")]
        public global::System.Drawing.Color stopColor {
            get {
                return ((global::System.Drawing.Color)(this["stopColor"]));
            }
            set {
                this["stopColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("55, 171, 255")]
        public global::System.Drawing.Color prevColor {
            get {
                return ((global::System.Drawing.Color)(this["prevColor"]));
            }
            set {
                this["prevColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 255, 126")]
        public global::System.Drawing.Color playPauseColor {
            get {
                return ((global::System.Drawing.Color)(this["playPauseColor"]));
            }
            set {
                this["playPauseColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("55, 171, 255")]
        public global::System.Drawing.Color nextColor {
            get {
                return ((global::System.Drawing.Color)(this["nextColor"]));
            }
            set {
                this["nextColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255, 174, 70")]
        public global::System.Drawing.Color muteColor {
            get {
                return ((global::System.Drawing.Color)(this["muteColor"]));
            }
            set {
                this["muteColor"] = value;
            }
        }
    }
}
