﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34003
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ByteartRetailMini.Web.UserService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserDataObject", Namespace="http://schemas.datacontract.org/2004/07/ByteartRetailMini.Application.DataObjects" +
        "")]
    [System.SerializableAttribute()]
    public partial class UserDataObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ByteartRetailMini.Web.UserService.AddressDataObject ContactAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DateLastLogonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DateRegisteredField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ByteartRetailMini.Web.UserService.AddressDataObject DeliveryAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> IsDisabledField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ByteartRetailMini.Web.UserService.RoleDataObject RoleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public string Contact {
            get {
                return this.ContactField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactField, value) != true)) {
                    this.ContactField = value;
                    this.RaisePropertyChanged("Contact");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ByteartRetailMini.Web.UserService.AddressDataObject ContactAddress {
            get {
                return this.ContactAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactAddressField, value) != true)) {
                    this.ContactAddressField = value;
                    this.RaisePropertyChanged("ContactAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DateLastLogon {
            get {
                return this.DateLastLogonField;
            }
            set {
                if ((this.DateLastLogonField.Equals(value) != true)) {
                    this.DateLastLogonField = value;
                    this.RaisePropertyChanged("DateLastLogon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DateRegistered {
            get {
                return this.DateRegisteredField;
            }
            set {
                if ((this.DateRegisteredField.Equals(value) != true)) {
                    this.DateRegisteredField = value;
                    this.RaisePropertyChanged("DateRegistered");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ByteartRetailMini.Web.UserService.AddressDataObject DeliveryAddress {
            get {
                return this.DeliveryAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.DeliveryAddressField, value) != true)) {
                    this.DeliveryAddressField = value;
                    this.RaisePropertyChanged("DeliveryAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
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
        public System.Nullable<bool> IsDisabled {
            get {
                return this.IsDisabledField;
            }
            set {
                if ((this.IsDisabledField.Equals(value) != true)) {
                    this.IsDisabledField = value;
                    this.RaisePropertyChanged("IsDisabled");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ByteartRetailMini.Web.UserService.RoleDataObject Role {
            get {
                return this.RoleField;
            }
            set {
                if ((object.ReferenceEquals(this.RoleField, value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AddressDataObject", Namespace="http://schemas.datacontract.org/2004/07/ByteartRetailMini.Application.DataObjects" +
        "")]
    [System.SerializableAttribute()]
    public partial class AddressDataObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StreetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ZipField;
        
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
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Street {
            get {
                return this.StreetField;
            }
            set {
                if ((object.ReferenceEquals(this.StreetField, value) != true)) {
                    this.StreetField = value;
                    this.RaisePropertyChanged("Street");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Zip {
            get {
                return this.ZipField;
            }
            set {
                if ((object.ReferenceEquals(this.ZipField, value) != true)) {
                    this.ZipField = value;
                    this.RaisePropertyChanged("Zip");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RoleDataObject", Namespace="http://schemas.datacontract.org/2004/07/ByteartRetailMini.Application.DataObjects" +
        "")]
    [System.SerializableAttribute()]
    public partial class RoleDataObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="zhww@outlook.com", ConfigurationName="UserService.UserService")]
    public interface UserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="zhww@outlook.com/UserService/CreateUsers", ReplyAction="zhww@outlook.com/UserService/CreateUsersResponse")]
        System.Collections.Generic.List<ByteartRetailMini.Web.UserService.UserDataObject> CreateUsers(System.Collections.Generic.List<ByteartRetailMini.Web.UserService.UserDataObject> userDataObjects);
        
        [System.ServiceModel.OperationContractAttribute(Action="zhww@outlook.com/UserService/ValidateUser", ReplyAction="zhww@outlook.com/UserService/ValidateUserResponse")]
        bool ValidateUser(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="zhww@outlook.com/UserService/DisableUser", ReplyAction="zhww@outlook.com/UserService/DisableUserResponse")]
        bool DisableUser(System.Guid userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="zhww@outlook.com/UserService/EnableUser", ReplyAction="zhww@outlook.com/UserService/EnableUserResponse")]
        bool EnableUser(System.Guid userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="zhww@outlook.com/UserService/UpdateUsers", ReplyAction="zhww@outlook.com/UserService/UpdateUsersResponse")]
        System.Collections.Generic.List<ByteartRetailMini.Web.UserService.UserDataObject> UpdateUsers(System.Collections.Generic.List<ByteartRetailMini.Web.UserService.UserDataObject> userDataObjects);
        
        [System.ServiceModel.OperationContractAttribute(Action="zhww@outlook.com/UserService/DeleteUsers", ReplyAction="zhww@outlook.com/UserService/DeleteUsersResponse")]
        void DeleteUsers(System.Collections.Generic.List<System.Guid> userIDs);
        
        [System.ServiceModel.OperationContractAttribute(Action="zhww@outlook.com/UserService/GetUserByKey", ReplyAction="zhww@outlook.com/UserService/GetUserByKeyResponse")]
        ByteartRetailMini.Web.UserService.UserDataObject GetUserByKey(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="zhww@outlook.com/UserService/GetUserByEmail", ReplyAction="zhww@outlook.com/UserService/GetUserByEmailResponse")]
        ByteartRetailMini.Web.UserService.UserDataObject GetUserByEmail(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="zhww@outlook.com/UserService/GetUserByName", ReplyAction="zhww@outlook.com/UserService/GetUserByNameResponse")]
        ByteartRetailMini.Web.UserService.UserDataObject GetUserByName(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="zhww@outlook.com/UserService/GetUsers", ReplyAction="zhww@outlook.com/UserService/GetUsersResponse")]
        System.Collections.Generic.List<ByteartRetailMini.Web.UserService.UserDataObject> GetUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="zhww@outlook.com/UserService/GetRoles", ReplyAction="zhww@outlook.com/UserService/GetRolesResponse")]
        System.Collections.Generic.List<ByteartRetailMini.Web.UserService.RoleDataObject> GetRoles();
        
        [System.ServiceModel.OperationContractAttribute(Action="zhww@outlook.com/UserService/GetRoleByKey", ReplyAction="zhww@outlook.com/UserService/GetRoleByKeyResponse")]
        ByteartRetailMini.Web.UserService.RoleDataObject GetRoleByKey(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="zhww@outlook.com/UserService/CreateRoles", ReplyAction="zhww@outlook.com/UserService/CreateRolesResponse")]
        System.Collections.Generic.List<ByteartRetailMini.Web.UserService.RoleDataObject> CreateRoles(System.Collections.Generic.List<ByteartRetailMini.Web.UserService.RoleDataObject> roleDataObjects);
        
        [System.ServiceModel.OperationContractAttribute(Action="zhww@outlook.com/UserService/UpdateRoles", ReplyAction="zhww@outlook.com/UserService/UpdateRolesResponse")]
        System.Collections.Generic.List<ByteartRetailMini.Web.UserService.RoleDataObject> UpdateRoles(System.Collections.Generic.List<ByteartRetailMini.Web.UserService.RoleDataObject> roleDataObjects);
        
        [System.ServiceModel.OperationContractAttribute(Action="zhww@outlook.com/UserService/DeleteRoles", ReplyAction="zhww@outlook.com/UserService/DeleteRolesResponse")]
        void DeleteRoles(System.Collections.Generic.List<System.Guid> roleIDs);
        
        [System.ServiceModel.OperationContractAttribute(Action="zhww@outlook.com/UserService/AssignRole", ReplyAction="zhww@outlook.com/UserService/AssignRoleResponse")]
        void AssignRole(System.Guid userID, System.Guid roleID);
        
        [System.ServiceModel.OperationContractAttribute(Action="zhww@outlook.com/UserService/UnassignRole", ReplyAction="zhww@outlook.com/UserService/UnassignRoleResponse")]
        void UnassignRole(System.Guid userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="zhww@outlook.com/UserService/GetUserRole", ReplyAction="zhww@outlook.com/UserService/GetUserRoleResponse")]
        ByteartRetailMini.Web.UserService.RoleDataObject GetUserRole(System.Guid userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UserServiceChannel : ByteartRetailMini.Web.UserService.UserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<ByteartRetailMini.Web.UserService.UserService>, ByteartRetailMini.Web.UserService.UserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<ByteartRetailMini.Web.UserService.UserDataObject> CreateUsers(System.Collections.Generic.List<ByteartRetailMini.Web.UserService.UserDataObject> userDataObjects) {
            return base.Channel.CreateUsers(userDataObjects);
        }
        
        public bool ValidateUser(string userName, string password) {
            return base.Channel.ValidateUser(userName, password);
        }
        
        public bool DisableUser(System.Guid userID) {
            return base.Channel.DisableUser(userID);
        }
        
        public bool EnableUser(System.Guid userID) {
            return base.Channel.EnableUser(userID);
        }
        
        public System.Collections.Generic.List<ByteartRetailMini.Web.UserService.UserDataObject> UpdateUsers(System.Collections.Generic.List<ByteartRetailMini.Web.UserService.UserDataObject> userDataObjects) {
            return base.Channel.UpdateUsers(userDataObjects);
        }
        
        public void DeleteUsers(System.Collections.Generic.List<System.Guid> userIDs) {
            base.Channel.DeleteUsers(userIDs);
        }
        
        public ByteartRetailMini.Web.UserService.UserDataObject GetUserByKey(System.Guid id) {
            return base.Channel.GetUserByKey(id);
        }
        
        public ByteartRetailMini.Web.UserService.UserDataObject GetUserByEmail(string email) {
            return base.Channel.GetUserByEmail(email);
        }
        
        public ByteartRetailMini.Web.UserService.UserDataObject GetUserByName(string userName) {
            return base.Channel.GetUserByName(userName);
        }
        
        public System.Collections.Generic.List<ByteartRetailMini.Web.UserService.UserDataObject> GetUsers() {
            return base.Channel.GetUsers();
        }
        
        public System.Collections.Generic.List<ByteartRetailMini.Web.UserService.RoleDataObject> GetRoles() {
            return base.Channel.GetRoles();
        }
        
        public ByteartRetailMini.Web.UserService.RoleDataObject GetRoleByKey(System.Guid id) {
            return base.Channel.GetRoleByKey(id);
        }
        
        public System.Collections.Generic.List<ByteartRetailMini.Web.UserService.RoleDataObject> CreateRoles(System.Collections.Generic.List<ByteartRetailMini.Web.UserService.RoleDataObject> roleDataObjects) {
            return base.Channel.CreateRoles(roleDataObjects);
        }
        
        public System.Collections.Generic.List<ByteartRetailMini.Web.UserService.RoleDataObject> UpdateRoles(System.Collections.Generic.List<ByteartRetailMini.Web.UserService.RoleDataObject> roleDataObjects) {
            return base.Channel.UpdateRoles(roleDataObjects);
        }
        
        public void DeleteRoles(System.Collections.Generic.List<System.Guid> roleIDs) {
            base.Channel.DeleteRoles(roleIDs);
        }
        
        public void AssignRole(System.Guid userID, System.Guid roleID) {
            base.Channel.AssignRole(userID, roleID);
        }
        
        public void UnassignRole(System.Guid userID) {
            base.Channel.UnassignRole(userID);
        }
        
        public ByteartRetailMini.Web.UserService.RoleDataObject GetUserRole(System.Guid userId) {
            return base.Channel.GetUserRole(userId);
        }
    }
}