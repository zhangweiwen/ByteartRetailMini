﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34003
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ByteartRetailMini.Web.PostbackService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PostbackDataObject", Namespace="http://schemas.datacontract.org/2004/07/ByteartRetailMini.Application.DataObjects" +
        "")]
    [System.SerializableAttribute()]
    public partial class PostbackDataObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CLRVersionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MachineNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServerArchitectureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ServerDateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServerOSField;
        
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
        public string CLRVersion {
            get {
                return this.CLRVersionField;
            }
            set {
                if ((object.ReferenceEquals(this.CLRVersionField, value) != true)) {
                    this.CLRVersionField = value;
                    this.RaisePropertyChanged("CLRVersion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ID {
            get {
                return this.IDField;
            }
            set {
                if ((object.ReferenceEquals(this.IDField, value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MachineName {
            get {
                return this.MachineNameField;
            }
            set {
                if ((object.ReferenceEquals(this.MachineNameField, value) != true)) {
                    this.MachineNameField = value;
                    this.RaisePropertyChanged("MachineName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServerArchitecture {
            get {
                return this.ServerArchitectureField;
            }
            set {
                if ((object.ReferenceEquals(this.ServerArchitectureField, value) != true)) {
                    this.ServerArchitectureField = value;
                    this.RaisePropertyChanged("ServerArchitecture");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ServerDateTime {
            get {
                return this.ServerDateTimeField;
            }
            set {
                if ((this.ServerDateTimeField.Equals(value) != true)) {
                    this.ServerDateTimeField = value;
                    this.RaisePropertyChanged("ServerDateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServerOS {
            get {
                return this.ServerOSField;
            }
            set {
                if ((object.ReferenceEquals(this.ServerOSField, value) != true)) {
                    this.ServerOSField = value;
                    this.RaisePropertyChanged("ServerOS");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="zhww@outlook.com", ConfigurationName="PostbackService.PostbackService")]
    public interface PostbackService {
        
        [System.ServiceModel.OperationContractAttribute(Action="zhww@outlook.com/PostbackService/GetPostback", ReplyAction="zhww@outlook.com/PostbackService/GetPostbackResponse")]
        ByteartRetailMini.Web.PostbackService.PostbackDataObject GetPostback();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PostbackServiceChannel : ByteartRetailMini.Web.PostbackService.PostbackService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PostbackServiceClient : System.ServiceModel.ClientBase<ByteartRetailMini.Web.PostbackService.PostbackService>, ByteartRetailMini.Web.PostbackService.PostbackService {
        
        public PostbackServiceClient() {
        }
        
        public PostbackServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PostbackServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PostbackServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PostbackServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ByteartRetailMini.Web.PostbackService.PostbackDataObject GetPostback() {
            return base.Channel.GetPostback();
        }
    }
}