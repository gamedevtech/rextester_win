﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34014.
// 
#pragma warning disable 1591

namespace Service.linux {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiceSoap", Namespace="http://rextester.com/")]
    public partial class Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback DoWorkOperationCompleted;
        
        private System.Threading.SendOrPostCallback SumOperationCompleted;
        
        private System.Threading.SendOrPostCallback DiffOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetPythonDotCompletionsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetPythonParenCompletionsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service() {
            this.Url = global::Service.Properties.Settings.Default.Service_linux_Service;
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
        public event DoWorkCompletedEventHandler DoWorkCompleted;
        
        /// <remarks/>
        public event SumCompletedEventHandler SumCompleted;
        
        /// <remarks/>
        public event DiffCompletedEventHandler DiffCompleted;
        
        /// <remarks/>
        public event GetPythonDotCompletionsCompletedEventHandler GetPythonDotCompletionsCompleted;
        
        /// <remarks/>
        public event GetPythonParenCompletionsCompletedEventHandler GetPythonParenCompletionsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://rextester.com/DoWork", RequestNamespace="http://rextester.com/", ResponseNamespace="http://rextester.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Result DoWork(string Program, string Input, Languages Language, string user, string pass, string compiler_args, bool bytes, bool programCompressed, bool inputCompressed) {
            object[] results = this.Invoke("DoWork", new object[] {
                        Program,
                        Input,
                        Language,
                        user,
                        pass,
                        compiler_args,
                        bytes,
                        programCompressed,
                        inputCompressed});
            return ((Result)(results[0]));
        }
        
        /// <remarks/>
        public void DoWorkAsync(string Program, string Input, Languages Language, string user, string pass, string compiler_args, bool bytes, bool programCompressed, bool inputCompressed) {
            this.DoWorkAsync(Program, Input, Language, user, pass, compiler_args, bytes, programCompressed, inputCompressed, null);
        }
        
        /// <remarks/>
        public void DoWorkAsync(string Program, string Input, Languages Language, string user, string pass, string compiler_args, bool bytes, bool programCompressed, bool inputCompressed, object userState) {
            if ((this.DoWorkOperationCompleted == null)) {
                this.DoWorkOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDoWorkOperationCompleted);
            }
            this.InvokeAsync("DoWork", new object[] {
                        Program,
                        Input,
                        Language,
                        user,
                        pass,
                        compiler_args,
                        bytes,
                        programCompressed,
                        inputCompressed}, this.DoWorkOperationCompleted, userState);
        }
        
        private void OnDoWorkOperationCompleted(object arg) {
            if ((this.DoWorkCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DoWorkCompleted(this, new DoWorkCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://rextester.com/Sum", RequestNamespace="http://rextester.com/", ResponseNamespace="http://rextester.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int Sum(int a, int b) {
            object[] results = this.Invoke("Sum", new object[] {
                        a,
                        b});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void SumAsync(int a, int b) {
            this.SumAsync(a, b, null);
        }
        
        /// <remarks/>
        public void SumAsync(int a, int b, object userState) {
            if ((this.SumOperationCompleted == null)) {
                this.SumOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSumOperationCompleted);
            }
            this.InvokeAsync("Sum", new object[] {
                        a,
                        b}, this.SumOperationCompleted, userState);
        }
        
        private void OnSumOperationCompleted(object arg) {
            if ((this.SumCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SumCompleted(this, new SumCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://rextester.com/Diff", RequestNamespace="http://rextester.com/", ResponseNamespace="http://rextester.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public DiffResult Diff(string left, string right, string user, string pass) {
            object[] results = this.Invoke("Diff", new object[] {
                        left,
                        right,
                        user,
                        pass});
            return ((DiffResult)(results[0]));
        }
        
        /// <remarks/>
        public void DiffAsync(string left, string right, string user, string pass) {
            this.DiffAsync(left, right, user, pass, null);
        }
        
        /// <remarks/>
        public void DiffAsync(string left, string right, string user, string pass, object userState) {
            if ((this.DiffOperationCompleted == null)) {
                this.DiffOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDiffOperationCompleted);
            }
            this.InvokeAsync("Diff", new object[] {
                        left,
                        right,
                        user,
                        pass}, this.DiffOperationCompleted, userState);
        }
        
        private void OnDiffOperationCompleted(object arg) {
            if ((this.DiffCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DiffCompleted(this, new DiffCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://rextester.com/GetPythonDotCompletions", RequestNamespace="http://rextester.com/", ResponseNamespace="http://rextester.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void GetPythonDotCompletions(string source, int line, int column) {
            this.Invoke("GetPythonDotCompletions", new object[] {
                        source,
                        line,
                        column});
        }
        
        /// <remarks/>
        public void GetPythonDotCompletionsAsync(string source, int line, int column) {
            this.GetPythonDotCompletionsAsync(source, line, column, null);
        }
        
        /// <remarks/>
        public void GetPythonDotCompletionsAsync(string source, int line, int column, object userState) {
            if ((this.GetPythonDotCompletionsOperationCompleted == null)) {
                this.GetPythonDotCompletionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPythonDotCompletionsOperationCompleted);
            }
            this.InvokeAsync("GetPythonDotCompletions", new object[] {
                        source,
                        line,
                        column}, this.GetPythonDotCompletionsOperationCompleted, userState);
        }
        
        private void OnGetPythonDotCompletionsOperationCompleted(object arg) {
            if ((this.GetPythonDotCompletionsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPythonDotCompletionsCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://rextester.com/GetPythonParenCompletions", RequestNamespace="http://rextester.com/", ResponseNamespace="http://rextester.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void GetPythonParenCompletions(string source, int line, int column) {
            this.Invoke("GetPythonParenCompletions", new object[] {
                        source,
                        line,
                        column});
        }
        
        /// <remarks/>
        public void GetPythonParenCompletionsAsync(string source, int line, int column) {
            this.GetPythonParenCompletionsAsync(source, line, column, null);
        }
        
        /// <remarks/>
        public void GetPythonParenCompletionsAsync(string source, int line, int column, object userState) {
            if ((this.GetPythonParenCompletionsOperationCompleted == null)) {
                this.GetPythonParenCompletionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPythonParenCompletionsOperationCompleted);
            }
            this.InvokeAsync("GetPythonParenCompletions", new object[] {
                        source,
                        line,
                        column}, this.GetPythonParenCompletionsOperationCompleted, userState);
        }
        
        private void OnGetPythonParenCompletionsOperationCompleted(object arg) {
            if ((this.GetPythonParenCompletionsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPythonParenCompletionsCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://rextester.com/")]
    public enum Languages {
        
        /// <remarks/>
        Java,
        
        /// <remarks/>
        Python,
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        CPP,
        
        /// <remarks/>
        Php,
        
        /// <remarks/>
        Pascal,
        
        /// <remarks/>
        ObjectiveC,
        
        /// <remarks/>
        Haskell,
        
        /// <remarks/>
        Ruby,
        
        /// <remarks/>
        Perl,
        
        /// <remarks/>
        Lua,
        
        /// <remarks/>
        Nasm,
        
        /// <remarks/>
        Javascript,
        
        /// <remarks/>
        Lisp,
        
        /// <remarks/>
        Prolog,
        
        /// <remarks/>
        Go,
        
        /// <remarks/>
        Scala,
        
        /// <remarks/>
        Scheme,
        
        /// <remarks/>
        Nodejs,
        
        /// <remarks/>
        Python3,
        
        /// <remarks/>
        Octave,
        
        /// <remarks/>
        CClang,
        
        /// <remarks/>
        CppClang,
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        R,
        
        /// <remarks/>
        Tcl,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://rextester.com/")]
    public partial class Result {
        
        private string errorsField;
        
        private byte[] errors_BytesField;
        
        private string warningsField;
        
        private byte[] warnings_BytesField;
        
        private string outputField;
        
        private bool isOutputCompressedField;
        
        private byte[] output_BytesField;
        
        private string statsField;
        
        private string exit_StatusField;
        
        private System.Nullable<int> exit_CodeField;
        
        private string system_ErrorField;
        
        private byte[][] filesField;
        
        /// <remarks/>
        public string Errors {
            get {
                return this.errorsField;
            }
            set {
                this.errorsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Errors_Bytes {
            get {
                return this.errors_BytesField;
            }
            set {
                this.errors_BytesField = value;
            }
        }
        
        /// <remarks/>
        public string Warnings {
            get {
                return this.warningsField;
            }
            set {
                this.warningsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Warnings_Bytes {
            get {
                return this.warnings_BytesField;
            }
            set {
                this.warnings_BytesField = value;
            }
        }
        
        /// <remarks/>
        public string Output {
            get {
                return this.outputField;
            }
            set {
                this.outputField = value;
            }
        }
        
        /// <remarks/>
        public bool IsOutputCompressed {
            get {
                return this.isOutputCompressedField;
            }
            set {
                this.isOutputCompressedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Output_Bytes {
            get {
                return this.output_BytesField;
            }
            set {
                this.output_BytesField = value;
            }
        }
        
        /// <remarks/>
        public string Stats {
            get {
                return this.statsField;
            }
            set {
                this.statsField = value;
            }
        }
        
        /// <remarks/>
        public string Exit_Status {
            get {
                return this.exit_StatusField;
            }
            set {
                this.exit_StatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> Exit_Code {
            get {
                return this.exit_CodeField;
            }
            set {
                this.exit_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string System_Error {
            get {
                return this.system_ErrorField;
            }
            set {
                this.system_ErrorField = value;
            }
        }
        
        /// <remarks/>
        public byte[][] Files {
            get {
                return this.filesField;
            }
            set {
                this.filesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://rextester.com/")]
    public partial class DiffResult {
        
        private bool isErrorField;
        
        private string resultField;
        
        /// <remarks/>
        public bool IsError {
            get {
                return this.isErrorField;
            }
            set {
                this.isErrorField = value;
            }
        }
        
        /// <remarks/>
        public string Result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void DoWorkCompletedEventHandler(object sender, DoWorkCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DoWorkCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DoWorkCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Result Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Result)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void SumCompletedEventHandler(object sender, SumCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SumCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SumCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void DiffCompletedEventHandler(object sender, DiffCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DiffCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DiffCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DiffResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DiffResult)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void GetPythonDotCompletionsCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void GetPythonParenCompletionsCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591