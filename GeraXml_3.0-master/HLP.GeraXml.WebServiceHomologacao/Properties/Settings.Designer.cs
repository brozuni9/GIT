﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HLP.GeraXml.WebServiceHomologacao.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("https://mdfe-hml.sefaz.rs.gov.br/ws/MDFerecepcao/MDFeRecepcao.asmx")]
        public string HLP_GeraXml_WebServiceHomologacao_MDFe_Homologacao_Recepcao_MDFeRecepcao {
            get {
                return ((string)(this["HLP_GeraXml_WebServiceHomologacao_MDFe_Homologacao_Recepcao_MDFeRecepcao"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("https://mdfe-hml.sefaz.rs.gov.br/ws/MDFeRetRecepcao/MDFeRetRecepcao.asmx")]
        public string HLP_GeraXml_WebServiceHomologacao_MDFe_Homologacao_RetRecepcao_MDFeRetRecepcao {
            get {
                return ((string)(this["HLP_GeraXml_WebServiceHomologacao_MDFe_Homologacao_RetRecepcao_MDFeRetRecepcao"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("https://mdfe-hml.sefaz.rs.gov.br/ws/MDFeRecepcaoEvento/MDFeRecepcaoEvento.asmx")]
        public string HLP_GeraXml_WebServiceHomologacao_MDFe_Homologacao_RecepcaoEvento_MDFeRecepcaoEvento {
            get {
                return ((string)(this["HLP_GeraXml_WebServiceHomologacao_MDFe_Homologacao_RecepcaoEvento_MDFeRecepcaoEve" +
                    "nto"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("https://mdfe-hml.sefaz.rs.gov.br/ws/MDFeConsulta/MDFeConsulta.asmx")]
        public string HLP_GeraXml_WebServiceHomologacao_MDFe_Homologacao_Consulta_MDFeConsulta {
            get {
                return ((string)(this["HLP_GeraXml_WebServiceHomologacao_MDFe_Homologacao_Consulta_MDFeConsulta"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("https://mdfe-hml.sefaz.rs.gov.br/ws/MDFeStatusServico/MDFeStatusServico.asmx")]
        public string HLP_GeraXml_WebServiceHomologacao_MDFe_Homologacao_StatusServico_MDFeStatusServico {
            get {
                return ((string)(this["HLP_GeraXml_WebServiceHomologacao_MDFe_Homologacao_StatusServico_MDFeStatusServic" +
                    "o"]));
            }
        }
    }
}