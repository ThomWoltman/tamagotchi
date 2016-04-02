﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TamagotchiMVC.TamagotchiServiceClient {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TamagotchiDTO", Namespace="http://schemas.datacontract.org/2004/07/Tama.Contract")]
    [System.SerializableAttribute()]
    public partial class TamagotchiDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BoredomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CooldownTillField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreationDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HealthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HungerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsAliveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SleepField;
        
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
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Boredom {
            get {
                return this.BoredomField;
            }
            set {
                if ((this.BoredomField.Equals(value) != true)) {
                    this.BoredomField = value;
                    this.RaisePropertyChanged("Boredom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CooldownTill {
            get {
                return this.CooldownTillField;
            }
            set {
                if ((this.CooldownTillField.Equals(value) != true)) {
                    this.CooldownTillField = value;
                    this.RaisePropertyChanged("CooldownTill");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreationDate {
            get {
                return this.CreationDateField;
            }
            set {
                if ((this.CreationDateField.Equals(value) != true)) {
                    this.CreationDateField = value;
                    this.RaisePropertyChanged("CreationDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Health {
            get {
                return this.HealthField;
            }
            set {
                if ((this.HealthField.Equals(value) != true)) {
                    this.HealthField = value;
                    this.RaisePropertyChanged("Health");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Hunger {
            get {
                return this.HungerField;
            }
            set {
                if ((this.HungerField.Equals(value) != true)) {
                    this.HungerField = value;
                    this.RaisePropertyChanged("Hunger");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsAlive {
            get {
                return this.IsAliveField;
            }
            set {
                if ((this.IsAliveField.Equals(value) != true)) {
                    this.IsAliveField = value;
                    this.RaisePropertyChanged("IsAlive");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Sleep {
            get {
                return this.SleepField;
            }
            set {
                if ((this.SleepField.Equals(value) != true)) {
                    this.SleepField = value;
                    this.RaisePropertyChanged("Sleep");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TamagotchiItemDTO", Namespace="http://schemas.datacontract.org/2004/07/Tama.Contract")]
    [System.SerializableAttribute()]
    public partial class TamagotchiItemDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TamagotchiServiceClient.ITamagotchiService")]
    public interface ITamagotchiService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/GetTamagotchiDTO", ReplyAction="http://tempuri.org/ITamagotchiService/GetTamagotchiDTOResponse")]
        TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO GetTamagotchiDTO(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/GetTamagotchiDTO", ReplyAction="http://tempuri.org/ITamagotchiService/GetTamagotchiDTOResponse")]
        System.Threading.Tasks.Task<TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO> GetTamagotchiDTOAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/Rest", ReplyAction="http://tempuri.org/ITamagotchiService/RestResponse")]
        TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO Rest(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/Rest", ReplyAction="http://tempuri.org/ITamagotchiService/RestResponse")]
        System.Threading.Tasks.Task<TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO> RestAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/Eat", ReplyAction="http://tempuri.org/ITamagotchiService/EatResponse")]
        TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO Eat(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/Eat", ReplyAction="http://tempuri.org/ITamagotchiService/EatResponse")]
        System.Threading.Tasks.Task<TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO> EatAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/Play", ReplyAction="http://tempuri.org/ITamagotchiService/PlayResponse")]
        TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO Play(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/Play", ReplyAction="http://tempuri.org/ITamagotchiService/PlayResponse")]
        System.Threading.Tasks.Task<TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO> PlayAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/Workout", ReplyAction="http://tempuri.org/ITamagotchiService/WorkoutResponse")]
        TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO Workout(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/Workout", ReplyAction="http://tempuri.org/ITamagotchiService/WorkoutResponse")]
        System.Threading.Tasks.Task<TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO> WorkoutAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/Hug", ReplyAction="http://tempuri.org/ITamagotchiService/HugResponse")]
        TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO Hug(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/Hug", ReplyAction="http://tempuri.org/ITamagotchiService/HugResponse")]
        System.Threading.Tasks.Task<TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO> HugAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/AddTamagotchi", ReplyAction="http://tempuri.org/ITamagotchiService/AddTamagotchiResponse")]
        TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO AddTamagotchi(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/AddTamagotchi", ReplyAction="http://tempuri.org/ITamagotchiService/AddTamagotchiResponse")]
        System.Threading.Tasks.Task<TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO> AddTamagotchiAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/GetAll", ReplyAction="http://tempuri.org/ITamagotchiService/GetAllResponse")]
        TamagotchiMVC.TamagotchiServiceClient.TamagotchiItemDTO[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/GetAll", ReplyAction="http://tempuri.org/ITamagotchiService/GetAllResponse")]
        System.Threading.Tasks.Task<TamagotchiMVC.TamagotchiServiceClient.TamagotchiItemDTO[]> GetAllAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITamagotchiServiceChannel : TamagotchiMVC.TamagotchiServiceClient.ITamagotchiService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TamagotchiServiceClient : System.ServiceModel.ClientBase<TamagotchiMVC.TamagotchiServiceClient.ITamagotchiService>, TamagotchiMVC.TamagotchiServiceClient.ITamagotchiService {
        
        public TamagotchiServiceClient() {
        }
        
        public TamagotchiServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TamagotchiServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TamagotchiServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TamagotchiServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO GetTamagotchiDTO(int id) {
            return base.Channel.GetTamagotchiDTO(id);
        }
        
        public System.Threading.Tasks.Task<TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO> GetTamagotchiDTOAsync(int id) {
            return base.Channel.GetTamagotchiDTOAsync(id);
        }
        
        public TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO Rest(int id) {
            return base.Channel.Rest(id);
        }
        
        public System.Threading.Tasks.Task<TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO> RestAsync(int id) {
            return base.Channel.RestAsync(id);
        }
        
        public TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO Eat(int id) {
            return base.Channel.Eat(id);
        }
        
        public System.Threading.Tasks.Task<TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO> EatAsync(int id) {
            return base.Channel.EatAsync(id);
        }
        
        public TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO Play(int id) {
            return base.Channel.Play(id);
        }
        
        public System.Threading.Tasks.Task<TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO> PlayAsync(int id) {
            return base.Channel.PlayAsync(id);
        }
        
        public TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO Workout(int id) {
            return base.Channel.Workout(id);
        }
        
        public System.Threading.Tasks.Task<TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO> WorkoutAsync(int id) {
            return base.Channel.WorkoutAsync(id);
        }
        
        public TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO Hug(int id) {
            return base.Channel.Hug(id);
        }
        
        public System.Threading.Tasks.Task<TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO> HugAsync(int id) {
            return base.Channel.HugAsync(id);
        }
        
        public TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO AddTamagotchi(string name) {
            return base.Channel.AddTamagotchi(name);
        }
        
        public System.Threading.Tasks.Task<TamagotchiMVC.TamagotchiServiceClient.TamagotchiDTO> AddTamagotchiAsync(string name) {
            return base.Channel.AddTamagotchiAsync(name);
        }
        
        public TamagotchiMVC.TamagotchiServiceClient.TamagotchiItemDTO[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<TamagotchiMVC.TamagotchiServiceClient.TamagotchiItemDTO[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
    }
}
