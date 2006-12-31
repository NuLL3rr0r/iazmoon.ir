﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.42.
// 
#pragma warning disable 1591

namespace iazmoon.adminManage {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ManagementSoap", Namespace="http://tempuri.org/")]
    public partial class Management : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getAdminPwOperationCompleted;
        
        private System.Threading.SendOrPostCallback setAdminPwOperationCompleted;
        
        private System.Threading.SendOrPostCallback setStudentsResultOperationCompleted;
        
        private System.Threading.SendOrPostCallback getStudentsResultOperationCompleted;
        
        private System.Threading.SendOrPostCallback eraseStudentsResultOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Management() {
            this.Url = global::iazmoon.Properties.Settings.Default.iazmoon_adminManage_management;
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
        public event getAdminPwCompletedEventHandler getAdminPwCompleted;
        
        /// <remarks/>
        public event setAdminPwCompletedEventHandler setAdminPwCompleted;
        
        /// <remarks/>
        public event setStudentsResultCompletedEventHandler setStudentsResultCompleted;
        
        /// <remarks/>
        public event getStudentsResultCompletedEventHandler getStudentsResultCompleted;
        
        /// <remarks/>
        public event eraseStudentsResultCompletedEventHandler eraseStudentsResultCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getAdminPw", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getAdminPw(string legal) {
            object[] results = this.Invoke("getAdminPw", new object[] {
                        legal});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getAdminPwAsync(string legal) {
            this.getAdminPwAsync(legal, null);
        }
        
        /// <remarks/>
        public void getAdminPwAsync(string legal, object userState) {
            if ((this.getAdminPwOperationCompleted == null)) {
                this.getAdminPwOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAdminPwOperationCompleted);
            }
            this.InvokeAsync("getAdminPw", new object[] {
                        legal}, this.getAdminPwOperationCompleted, userState);
        }
        
        private void OngetAdminPwOperationCompleted(object arg) {
            if ((this.getAdminPwCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAdminPwCompleted(this, new getAdminPwCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/setAdminPw", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string setAdminPw(string pw, string npw, string legal) {
            object[] results = this.Invoke("setAdminPw", new object[] {
                        pw,
                        npw,
                        legal});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void setAdminPwAsync(string pw, string npw, string legal) {
            this.setAdminPwAsync(pw, npw, legal, null);
        }
        
        /// <remarks/>
        public void setAdminPwAsync(string pw, string npw, string legal, object userState) {
            if ((this.setAdminPwOperationCompleted == null)) {
                this.setAdminPwOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsetAdminPwOperationCompleted);
            }
            this.InvokeAsync("setAdminPw", new object[] {
                        pw,
                        npw,
                        legal}, this.setAdminPwOperationCompleted, userState);
        }
        
        private void OnsetAdminPwOperationCompleted(object arg) {
            if ((this.setAdminPwCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.setAdminPwCompleted(this, new setAdminPwCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/setStudentsResult", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string setStudentsResult(System.Data.DataSet dsSR, string legal) {
            object[] results = this.Invoke("setStudentsResult", new object[] {
                        dsSR,
                        legal});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void setStudentsResultAsync(System.Data.DataSet dsSR, string legal) {
            this.setStudentsResultAsync(dsSR, legal, null);
        }
        
        /// <remarks/>
        public void setStudentsResultAsync(System.Data.DataSet dsSR, string legal, object userState) {
            if ((this.setStudentsResultOperationCompleted == null)) {
                this.setStudentsResultOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsetStudentsResultOperationCompleted);
            }
            this.InvokeAsync("setStudentsResult", new object[] {
                        dsSR,
                        legal}, this.setStudentsResultOperationCompleted, userState);
        }
        
        private void OnsetStudentsResultOperationCompleted(object arg) {
            if ((this.setStudentsResultCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.setStudentsResultCompleted(this, new setStudentsResultCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getStudentsResult", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getStudentsResult(string legal) {
            object[] results = this.Invoke("getStudentsResult", new object[] {
                        legal});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getStudentsResultAsync(string legal) {
            this.getStudentsResultAsync(legal, null);
        }
        
        /// <remarks/>
        public void getStudentsResultAsync(string legal, object userState) {
            if ((this.getStudentsResultOperationCompleted == null)) {
                this.getStudentsResultOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetStudentsResultOperationCompleted);
            }
            this.InvokeAsync("getStudentsResult", new object[] {
                        legal}, this.getStudentsResultOperationCompleted, userState);
        }
        
        private void OngetStudentsResultOperationCompleted(object arg) {
            if ((this.getStudentsResultCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getStudentsResultCompleted(this, new getStudentsResultCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/eraseStudentsResult", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string eraseStudentsResult(int from, int to, string legal) {
            object[] results = this.Invoke("eraseStudentsResult", new object[] {
                        from,
                        to,
                        legal});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void eraseStudentsResultAsync(int from, int to, string legal) {
            this.eraseStudentsResultAsync(from, to, legal, null);
        }
        
        /// <remarks/>
        public void eraseStudentsResultAsync(int from, int to, string legal, object userState) {
            if ((this.eraseStudentsResultOperationCompleted == null)) {
                this.eraseStudentsResultOperationCompleted = new System.Threading.SendOrPostCallback(this.OneraseStudentsResultOperationCompleted);
            }
            this.InvokeAsync("eraseStudentsResult", new object[] {
                        from,
                        to,
                        legal}, this.eraseStudentsResultOperationCompleted, userState);
        }
        
        private void OneraseStudentsResultOperationCompleted(object arg) {
            if ((this.eraseStudentsResultCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.eraseStudentsResultCompleted(this, new eraseStudentsResultCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void getAdminPwCompletedEventHandler(object sender, getAdminPwCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAdminPwCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAdminPwCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void setAdminPwCompletedEventHandler(object sender, setAdminPwCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class setAdminPwCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal setAdminPwCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void setStudentsResultCompletedEventHandler(object sender, setStudentsResultCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class setStudentsResultCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal setStudentsResultCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void getStudentsResultCompletedEventHandler(object sender, getStudentsResultCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getStudentsResultCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getStudentsResultCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void eraseStudentsResultCompletedEventHandler(object sender, eraseStudentsResultCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eraseStudentsResultCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal eraseStudentsResultCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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