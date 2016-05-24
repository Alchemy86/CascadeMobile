﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRServiceCalls.LoginService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OperationOutcome", Namespace="http://schemas.datacontract.org/2004/07/Cascade.HR.BLL.DataContracts")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HRServiceCalls.LoginService.CascadeSession))]
    public partial class OperationOutcome : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HRServiceCalls.LoginService.OutcomeDetails OutcomeDetailsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HRServiceCalls.LoginService.OutcomeDetails OutcomeDetails {
            get {
                return this.OutcomeDetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.OutcomeDetailsField, value) != true)) {
                    this.OutcomeDetailsField = value;
                    this.RaisePropertyChanged("OutcomeDetails");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OutcomeDetails", Namespace="http://schemas.datacontract.org/2004/07/Cascade.HR.BLL.DataContracts")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HRServiceCalls.LoginService.InvalidCredentials))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HRServiceCalls.LoginService.PinNumberLockout))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HRServiceCalls.LoginService.TaskAlreadyComplete))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HRServiceCalls.LoginService.LoginLockout))]
    public partial class OutcomeDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HRServiceCalls.LoginService.OperationOutcomeStatus StatusField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HRServiceCalls.LoginService.OperationOutcomeStatus Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CascadeSession", Namespace="http://schemas.datacontract.org/2004/07/Cascade.HR.BLL.DataContracts")]
    [System.SerializableAttribute()]
    public partial class CascadeSession : HRServiceCalls.LoginService.OperationOutcome {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CascadeSessionStateStringField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SessionTokenField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CascadeSessionStateString {
            get {
                return this.CascadeSessionStateStringField;
            }
            set {
                if ((object.ReferenceEquals(this.CascadeSessionStateStringField, value) != true)) {
                    this.CascadeSessionStateStringField = value;
                    this.RaisePropertyChanged("CascadeSessionStateString");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SessionToken {
            get {
                return this.SessionTokenField;
            }
            set {
                if ((object.ReferenceEquals(this.SessionTokenField, value) != true)) {
                    this.SessionTokenField = value;
                    this.RaisePropertyChanged("SessionToken");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InvalidCredentials", Namespace="http://schemas.datacontract.org/2004/07/Cascade.HR.BLL.DataContracts")]
    [System.SerializableAttribute()]
    public partial class InvalidCredentials : HRServiceCalls.LoginService.OutcomeDetails {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PinNumberLockout", Namespace="http://schemas.datacontract.org/2004/07/Cascade.HR.BLL.DataContracts")]
    [System.SerializableAttribute()]
    public partial class PinNumberLockout : HRServiceCalls.LoginService.OutcomeDetails {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TaskAlreadyComplete", Namespace="http://schemas.datacontract.org/2004/07/Cascade.HR.BLL.DataContracts")]
    [System.SerializableAttribute()]
    public partial class TaskAlreadyComplete : HRServiceCalls.LoginService.OutcomeDetails {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoginLockout", Namespace="http://schemas.datacontract.org/2004/07/Cascade.HR.BLL.DataContracts")]
    [System.SerializableAttribute()]
    public partial class LoginLockout : HRServiceCalls.LoginService.OutcomeDetails {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OperationOutcomeStatus", Namespace="http://schemas.datacontract.org/2004/07/Cascade.HR.BLL.DataContracts")]
    public enum OperationOutcomeStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Success = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Failure = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SystemException = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LoginService.ILoginService", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface ILoginService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/PinNoLoginIsAllowed", ReplyAction="http://tempuri.org/ILoginService/PinNoLoginIsAllowedResponse")]
        bool PinNoLoginIsAllowed();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/PinNoLoginIsAllowed", ReplyAction="http://tempuri.org/ILoginService/PinNoLoginIsAllowedResponse")]
        System.Threading.Tasks.Task<bool> PinNoLoginIsAllowedAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/IsHosted", ReplyAction="http://tempuri.org/ILoginService/IsHostedResponse")]
        bool IsHosted();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/IsHosted", ReplyAction="http://tempuri.org/ILoginService/IsHostedResponse")]
        System.Threading.Tasks.Task<bool> IsHostedAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/GetCascadeSession", ReplyAction="http://tempuri.org/ILoginService/GetCascadeSessionResponse")]
        HRServiceCalls.LoginService.CascadeSession GetCascadeSession(string username, string password, string mobilepin, string companyname, string ipaddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/GetCascadeSession", ReplyAction="http://tempuri.org/ILoginService/GetCascadeSessionResponse")]
        System.Threading.Tasks.Task<HRServiceCalls.LoginService.CascadeSession> GetCascadeSessionAsync(string username, string password, string mobilepin, string companyname, string ipaddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/ClearCascadeSession", ReplyAction="http://tempuri.org/ILoginService/ClearCascadeSessionResponse")]
        void ClearCascadeSession(System.Guid cascadeSessionToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/ClearCascadeSession", ReplyAction="http://tempuri.org/ILoginService/ClearCascadeSessionResponse")]
        System.Threading.Tasks.Task ClearCascadeSessionAsync(System.Guid cascadeSessionToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/CheckSession", ReplyAction="http://tempuri.org/ILoginService/CheckSessionResponse")]
        bool CheckSession(System.Guid cascadeSessionToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/CheckSession", ReplyAction="http://tempuri.org/ILoginService/CheckSessionResponse")]
        System.Threading.Tasks.Task<bool> CheckSessionAsync(System.Guid cascadeSessionToken);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILoginServiceChannel : HRServiceCalls.LoginService.ILoginService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoginServiceClient : System.ServiceModel.ClientBase<HRServiceCalls.LoginService.ILoginService>, HRServiceCalls.LoginService.ILoginService {
        
        public LoginServiceClient() {
        }
        
        public LoginServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoginServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool PinNoLoginIsAllowed() {
            return base.Channel.PinNoLoginIsAllowed();
        }
        
        public System.Threading.Tasks.Task<bool> PinNoLoginIsAllowedAsync() {
            return base.Channel.PinNoLoginIsAllowedAsync();
        }
        
        public bool IsHosted() {
            return base.Channel.IsHosted();
        }
        
        public System.Threading.Tasks.Task<bool> IsHostedAsync() {
            return base.Channel.IsHostedAsync();
        }
        
        public HRServiceCalls.LoginService.CascadeSession GetCascadeSession(string username, string password, string mobilepin, string companyname, string ipaddress) {
            return base.Channel.GetCascadeSession(username, password, mobilepin, companyname, ipaddress);
        }
        
        public System.Threading.Tasks.Task<HRServiceCalls.LoginService.CascadeSession> GetCascadeSessionAsync(string username, string password, string mobilepin, string companyname, string ipaddress) {
            return base.Channel.GetCascadeSessionAsync(username, password, mobilepin, companyname, ipaddress);
        }
        
        public void ClearCascadeSession(System.Guid cascadeSessionToken) {
            base.Channel.ClearCascadeSession(cascadeSessionToken);
        }
        
        public System.Threading.Tasks.Task ClearCascadeSessionAsync(System.Guid cascadeSessionToken) {
            return base.Channel.ClearCascadeSessionAsync(cascadeSessionToken);
        }
        
        public bool CheckSession(System.Guid cascadeSessionToken) {
            return base.Channel.CheckSession(cascadeSessionToken);
        }
        
        public System.Threading.Tasks.Task<bool> CheckSessionAsync(System.Guid cascadeSessionToken) {
            return base.Channel.CheckSessionAsync(cascadeSessionToken);
        }
    }
}
