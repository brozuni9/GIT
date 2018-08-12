﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18033.
// 
#pragma warning disable 1591

namespace HLP.GeraXml.WebService.NFSE_Campinas {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="LoteRpsSoapBinding", Namespace="http://issdigital.campinas.sp.gov.br/WsNFe2/LoteRps.jws")]
    public partial class LoteRpsService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback enviarOperationCompleted;
        
        private System.Threading.SendOrPostCallback consultarSequencialRpsOperationCompleted;
        
        private System.Threading.SendOrPostCallback enviarSincronoOperationCompleted;
        
        private System.Threading.SendOrPostCallback testeEnviarOperationCompleted;
        
        private System.Threading.SendOrPostCallback consultarLoteOperationCompleted;
        
        private System.Threading.SendOrPostCallback consultarNotaOperationCompleted;
        
        private System.Threading.SendOrPostCallback cancelarOperationCompleted;
        
        private System.Threading.SendOrPostCallback consultarNFSeRpsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public LoteRpsService() {
            this.Url = global::HLP.GeraXml.WebService.Properties.Settings.Default.HLP_GeraXml_WebService_NFSE_Campinas_LoteRpsService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event enviarCompletedEventHandler enviarCompleted;
        
        /// <remarks/>
        public event consultarSequencialRpsCompletedEventHandler consultarSequencialRpsCompleted;
        
        /// <remarks/>
        public event enviarSincronoCompletedEventHandler enviarSincronoCompleted;
        
        /// <remarks/>
        public event testeEnviarCompletedEventHandler testeEnviarCompleted;
        
        /// <remarks/>
        public event consultarLoteCompletedEventHandler consultarLoteCompleted;
        
        /// <remarks/>
        public event consultarNotaCompletedEventHandler consultarNotaCompleted;
        
        /// <remarks/>
        public event cancelarCompletedEventHandler cancelarCompleted;
        
        /// <remarks/>
        public event consultarNFSeRpsCompletedEventHandler consultarNFSeRpsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://proces.wsnfe2.dsfnet.com.br", ResponseNamespace="http://issdigital.campinas.sp.gov.br/WsNFe2/LoteRps.jws")]
        [return: System.Xml.Serialization.SoapElementAttribute("enviarReturn")]
        public string enviar(string mensagemXml) {
            object[] results = this.Invoke("enviar", new object[] {
                        mensagemXml});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void enviarAsync(string mensagemXml) {
            this.enviarAsync(mensagemXml, null);
        }
        
        /// <remarks/>
        public void enviarAsync(string mensagemXml, object userState) {
            if ((this.enviarOperationCompleted == null)) {
                this.enviarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnenviarOperationCompleted);
            }
            this.InvokeAsync("enviar", new object[] {
                        mensagemXml}, this.enviarOperationCompleted, userState);
        }
        
        private void OnenviarOperationCompleted(object arg) {
            if ((this.enviarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.enviarCompleted(this, new enviarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://proces.wsnfe2.dsfnet.com.br", ResponseNamespace="http://issdigital.campinas.sp.gov.br/WsNFe2/LoteRps.jws")]
        [return: System.Xml.Serialization.SoapElementAttribute("consultarSequencialRpsReturn")]
        public string consultarSequencialRps(string mensagemXml) {
            object[] results = this.Invoke("consultarSequencialRps", new object[] {
                        mensagemXml});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void consultarSequencialRpsAsync(string mensagemXml) {
            this.consultarSequencialRpsAsync(mensagemXml, null);
        }
        
        /// <remarks/>
        public void consultarSequencialRpsAsync(string mensagemXml, object userState) {
            if ((this.consultarSequencialRpsOperationCompleted == null)) {
                this.consultarSequencialRpsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnconsultarSequencialRpsOperationCompleted);
            }
            this.InvokeAsync("consultarSequencialRps", new object[] {
                        mensagemXml}, this.consultarSequencialRpsOperationCompleted, userState);
        }
        
        private void OnconsultarSequencialRpsOperationCompleted(object arg) {
            if ((this.consultarSequencialRpsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.consultarSequencialRpsCompleted(this, new consultarSequencialRpsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://proces.wsnfe2.dsfnet.com.br", ResponseNamespace="http://issdigital.campinas.sp.gov.br/WsNFe2/LoteRps.jws")]
        [return: System.Xml.Serialization.SoapElementAttribute("enviarSincronoReturn")]
        public string enviarSincrono(string mensagemXml) {
            object[] results = this.Invoke("enviarSincrono", new object[] {
                        mensagemXml});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void enviarSincronoAsync(string mensagemXml) {
            this.enviarSincronoAsync(mensagemXml, null);
        }
        
        /// <remarks/>
        public void enviarSincronoAsync(string mensagemXml, object userState) {
            if ((this.enviarSincronoOperationCompleted == null)) {
                this.enviarSincronoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnenviarSincronoOperationCompleted);
            }
            this.InvokeAsync("enviarSincrono", new object[] {
                        mensagemXml}, this.enviarSincronoOperationCompleted, userState);
        }
        
        private void OnenviarSincronoOperationCompleted(object arg) {
            if ((this.enviarSincronoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.enviarSincronoCompleted(this, new enviarSincronoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://proces.wsnfe2.dsfnet.com.br", ResponseNamespace="http://issdigital.campinas.sp.gov.br/WsNFe2/LoteRps.jws")]
        [return: System.Xml.Serialization.SoapElementAttribute("testeEnviarReturn")]
        public string testeEnviar(string mensagemXml) {
            object[] results = this.Invoke("testeEnviar", new object[] {
                        mensagemXml});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void testeEnviarAsync(string mensagemXml) {
            this.testeEnviarAsync(mensagemXml, null);
        }
        
        /// <remarks/>
        public void testeEnviarAsync(string mensagemXml, object userState) {
            if ((this.testeEnviarOperationCompleted == null)) {
                this.testeEnviarOperationCompleted = new System.Threading.SendOrPostCallback(this.OntesteEnviarOperationCompleted);
            }
            this.InvokeAsync("testeEnviar", new object[] {
                        mensagemXml}, this.testeEnviarOperationCompleted, userState);
        }
        
        private void OntesteEnviarOperationCompleted(object arg) {
            if ((this.testeEnviarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.testeEnviarCompleted(this, new testeEnviarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://proces.wsnfe2.dsfnet.com.br", ResponseNamespace="http://issdigital.campinas.sp.gov.br/WsNFe2/LoteRps.jws")]
        [return: System.Xml.Serialization.SoapElementAttribute("consultarLoteReturn")]
        public string consultarLote(string mensagemXml) {
            object[] results = this.Invoke("consultarLote", new object[] {
                        mensagemXml});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void consultarLoteAsync(string mensagemXml) {
            this.consultarLoteAsync(mensagemXml, null);
        }
        
        /// <remarks/>
        public void consultarLoteAsync(string mensagemXml, object userState) {
            if ((this.consultarLoteOperationCompleted == null)) {
                this.consultarLoteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnconsultarLoteOperationCompleted);
            }
            this.InvokeAsync("consultarLote", new object[] {
                        mensagemXml}, this.consultarLoteOperationCompleted, userState);
        }
        
        private void OnconsultarLoteOperationCompleted(object arg) {
            if ((this.consultarLoteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.consultarLoteCompleted(this, new consultarLoteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://proces.wsnfe2.dsfnet.com.br", ResponseNamespace="http://issdigital.campinas.sp.gov.br/WsNFe2/LoteRps.jws")]
        [return: System.Xml.Serialization.SoapElementAttribute("consultarNotaReturn")]
        public string consultarNota(string mensagemXml) {
            object[] results = this.Invoke("consultarNota", new object[] {
                        mensagemXml});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void consultarNotaAsync(string mensagemXml) {
            this.consultarNotaAsync(mensagemXml, null);
        }
        
        /// <remarks/>
        public void consultarNotaAsync(string mensagemXml, object userState) {
            if ((this.consultarNotaOperationCompleted == null)) {
                this.consultarNotaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnconsultarNotaOperationCompleted);
            }
            this.InvokeAsync("consultarNota", new object[] {
                        mensagemXml}, this.consultarNotaOperationCompleted, userState);
        }
        
        private void OnconsultarNotaOperationCompleted(object arg) {
            if ((this.consultarNotaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.consultarNotaCompleted(this, new consultarNotaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://proces.wsnfe2.dsfnet.com.br", ResponseNamespace="http://issdigital.campinas.sp.gov.br/WsNFe2/LoteRps.jws")]
        [return: System.Xml.Serialization.SoapElementAttribute("cancelarReturn")]
        public string cancelar(string mensagemXml) {
            object[] results = this.Invoke("cancelar", new object[] {
                        mensagemXml});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void cancelarAsync(string mensagemXml) {
            this.cancelarAsync(mensagemXml, null);
        }
        
        /// <remarks/>
        public void cancelarAsync(string mensagemXml, object userState) {
            if ((this.cancelarOperationCompleted == null)) {
                this.cancelarOperationCompleted = new System.Threading.SendOrPostCallback(this.OncancelarOperationCompleted);
            }
            this.InvokeAsync("cancelar", new object[] {
                        mensagemXml}, this.cancelarOperationCompleted, userState);
        }
        
        private void OncancelarOperationCompleted(object arg) {
            if ((this.cancelarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.cancelarCompleted(this, new cancelarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://proces.wsnfe2.dsfnet.com.br", ResponseNamespace="http://issdigital.campinas.sp.gov.br/WsNFe2/LoteRps.jws")]
        [return: System.Xml.Serialization.SoapElementAttribute("consultarNFSeRpsReturn")]
        public string consultarNFSeRps(string mensagemXml) {
            object[] results = this.Invoke("consultarNFSeRps", new object[] {
                        mensagemXml});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void consultarNFSeRpsAsync(string mensagemXml) {
            this.consultarNFSeRpsAsync(mensagemXml, null);
        }
        
        /// <remarks/>
        public void consultarNFSeRpsAsync(string mensagemXml, object userState) {
            if ((this.consultarNFSeRpsOperationCompleted == null)) {
                this.consultarNFSeRpsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnconsultarNFSeRpsOperationCompleted);
            }
            this.InvokeAsync("consultarNFSeRps", new object[] {
                        mensagemXml}, this.consultarNFSeRpsOperationCompleted, userState);
        }
        
        private void OnconsultarNFSeRpsOperationCompleted(object arg) {
            if ((this.consultarNFSeRpsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.consultarNFSeRpsCompleted(this, new consultarNFSeRpsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void enviarCompletedEventHandler(object sender, enviarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class enviarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal enviarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void consultarSequencialRpsCompletedEventHandler(object sender, consultarSequencialRpsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class consultarSequencialRpsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal consultarSequencialRpsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void enviarSincronoCompletedEventHandler(object sender, enviarSincronoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class enviarSincronoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal enviarSincronoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void testeEnviarCompletedEventHandler(object sender, testeEnviarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class testeEnviarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal testeEnviarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void consultarLoteCompletedEventHandler(object sender, consultarLoteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class consultarLoteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal consultarLoteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void consultarNotaCompletedEventHandler(object sender, consultarNotaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class consultarNotaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal consultarNotaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void cancelarCompletedEventHandler(object sender, cancelarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class cancelarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal cancelarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void consultarNFSeRpsCompletedEventHandler(object sender, consultarNFSeRpsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class consultarNFSeRpsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal consultarNFSeRpsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591