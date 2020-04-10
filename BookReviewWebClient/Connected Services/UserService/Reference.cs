﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookReviewWebClient.UserService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/BookReviewService.Models")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserEmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserPasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserTypeField;
        
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
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserEmail {
            get {
                return this.UserEmailField;
            }
            set {
                if ((object.ReferenceEquals(this.UserEmailField, value) != true)) {
                    this.UserEmailField = value;
                    this.RaisePropertyChanged("UserEmail");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserPassword {
            get {
                return this.UserPasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.UserPasswordField, value) != true)) {
                    this.UserPasswordField = value;
                    this.RaisePropertyChanged("UserPassword");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserType {
            get {
                return this.UserTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.UserTypeField, value) != true)) {
                    this.UserTypeField = value;
                    this.RaisePropertyChanged("UserType");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserService.IUserService")]
    public interface IUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/RegisterUser", ReplyAction="http://tempuri.org/IUserService/RegisterUserResponse")]
        BookReviewWebClient.UserService.User RegisterUser(BookReviewWebClient.UserService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/RegisterUser", ReplyAction="http://tempuri.org/IUserService/RegisterUserResponse")]
        System.Threading.Tasks.Task<BookReviewWebClient.UserService.User> RegisterUserAsync(BookReviewWebClient.UserService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/LoginUser", ReplyAction="http://tempuri.org/IUserService/LoginUserResponse")]
        BookReviewWebClient.UserService.User LoginUser(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/LoginUser", ReplyAction="http://tempuri.org/IUserService/LoginUserResponse")]
        System.Threading.Tasks.Task<BookReviewWebClient.UserService.User> LoginUserAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/DoesUserNameExists", ReplyAction="http://tempuri.org/IUserService/DoesUserNameExistsResponse")]
        bool DoesUserNameExists(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/DoesUserNameExists", ReplyAction="http://tempuri.org/IUserService/DoesUserNameExistsResponse")]
        System.Threading.Tasks.Task<bool> DoesUserNameExistsAsync(string userName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : BookReviewWebClient.UserService.IUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<BookReviewWebClient.UserService.IUserService>, BookReviewWebClient.UserService.IUserService {
        
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
        
        public BookReviewWebClient.UserService.User RegisterUser(BookReviewWebClient.UserService.User user) {
            return base.Channel.RegisterUser(user);
        }
        
        public System.Threading.Tasks.Task<BookReviewWebClient.UserService.User> RegisterUserAsync(BookReviewWebClient.UserService.User user) {
            return base.Channel.RegisterUserAsync(user);
        }
        
        public BookReviewWebClient.UserService.User LoginUser(string email, string password) {
            return base.Channel.LoginUser(email, password);
        }
        
        public System.Threading.Tasks.Task<BookReviewWebClient.UserService.User> LoginUserAsync(string email, string password) {
            return base.Channel.LoginUserAsync(email, password);
        }
        
        public bool DoesUserNameExists(string userName) {
            return base.Channel.DoesUserNameExists(userName);
        }
        
        public System.Threading.Tasks.Task<bool> DoesUserNameExistsAsync(string userName) {
            return base.Channel.DoesUserNameExistsAsync(userName);
        }
    }
}
