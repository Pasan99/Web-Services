﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _2019410clientapp.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int Student_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Student_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        private System.Nullable<int> AgeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Student_ID {
            get {
                return this.Student_IDField;
            }
            set {
                if ((this.Student_IDField.Equals(value) != true)) {
                    this.Student_IDField = value;
                    this.RaisePropertyChanged("Student_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Student_Name {
            get {
                return this.Student_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.Student_NameField, value) != true)) {
                    this.Student_NameField = value;
                    this.RaisePropertyChanged("Student_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.Nullable<int> Age {
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name GetStudentResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetStudent", ReplyAction="*")]
        _2019410clientapp.ServiceReference1.GetStudentResponse GetStudent(_2019410clientapp.ServiceReference1.GetStudentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetStudent", ReplyAction="*")]
        System.Threading.Tasks.Task<_2019410clientapp.ServiceReference1.GetStudentResponse> GetStudentAsync(_2019410clientapp.ServiceReference1.GetStudentRequest request);
        
        // CODEGEN: Generating message contract since element name s from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddStudent", ReplyAction="*")]
        _2019410clientapp.ServiceReference1.AddStudentResponse AddStudent(_2019410clientapp.ServiceReference1.AddStudentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddStudent", ReplyAction="*")]
        System.Threading.Tasks.Task<_2019410clientapp.ServiceReference1.AddStudentResponse> AddStudentAsync(_2019410clientapp.ServiceReference1.AddStudentRequest request);
        
        // CODEGEN: Generating message contract since element name s from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateStudent", ReplyAction="*")]
        _2019410clientapp.ServiceReference1.UpdateStudentResponse UpdateStudent(_2019410clientapp.ServiceReference1.UpdateStudentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateStudent", ReplyAction="*")]
        System.Threading.Tasks.Task<_2019410clientapp.ServiceReference1.UpdateStudentResponse> UpdateStudentAsync(_2019410clientapp.ServiceReference1.UpdateStudentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteStudent", ReplyAction="*")]
        bool DeleteStudent(int studentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteStudent", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> DeleteStudentAsync(int studentID);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStudentRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStudent", Namespace="http://tempuri.org/", Order=0)]
        public _2019410clientapp.ServiceReference1.GetStudentRequestBody Body;
        
        public GetStudentRequest() {
        }
        
        public GetStudentRequest(_2019410clientapp.ServiceReference1.GetStudentRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetStudentRequestBody {
        
        public GetStudentRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStudentResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStudentResponse", Namespace="http://tempuri.org/", Order=0)]
        public _2019410clientapp.ServiceReference1.GetStudentResponseBody Body;
        
        public GetStudentResponse() {
        }
        
        public GetStudentResponse(_2019410clientapp.ServiceReference1.GetStudentResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetStudentResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public _2019410clientapp.ServiceReference1.Student[] GetStudentResult;
        
        public GetStudentResponseBody() {
        }
        
        public GetStudentResponseBody(_2019410clientapp.ServiceReference1.Student[] GetStudentResult) {
            this.GetStudentResult = GetStudentResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddStudentRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddStudent", Namespace="http://tempuri.org/", Order=0)]
        public _2019410clientapp.ServiceReference1.AddStudentRequestBody Body;
        
        public AddStudentRequest() {
        }
        
        public AddStudentRequest(_2019410clientapp.ServiceReference1.AddStudentRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddStudentRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public _2019410clientapp.ServiceReference1.Student s;
        
        public AddStudentRequestBody() {
        }
        
        public AddStudentRequestBody(_2019410clientapp.ServiceReference1.Student s) {
            this.s = s;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddStudentResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddStudentResponse", Namespace="http://tempuri.org/", Order=0)]
        public _2019410clientapp.ServiceReference1.AddStudentResponseBody Body;
        
        public AddStudentResponse() {
        }
        
        public AddStudentResponse(_2019410clientapp.ServiceReference1.AddStudentResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddStudentResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool AddStudentResult;
        
        public AddStudentResponseBody() {
        }
        
        public AddStudentResponseBody(bool AddStudentResult) {
            this.AddStudentResult = AddStudentResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateStudentRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateStudent", Namespace="http://tempuri.org/", Order=0)]
        public _2019410clientapp.ServiceReference1.UpdateStudentRequestBody Body;
        
        public UpdateStudentRequest() {
        }
        
        public UpdateStudentRequest(_2019410clientapp.ServiceReference1.UpdateStudentRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateStudentRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public _2019410clientapp.ServiceReference1.Student s;
        
        public UpdateStudentRequestBody() {
        }
        
        public UpdateStudentRequestBody(_2019410clientapp.ServiceReference1.Student s) {
            this.s = s;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateStudentResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateStudentResponse", Namespace="http://tempuri.org/", Order=0)]
        public _2019410clientapp.ServiceReference1.UpdateStudentResponseBody Body;
        
        public UpdateStudentResponse() {
        }
        
        public UpdateStudentResponse(_2019410clientapp.ServiceReference1.UpdateStudentResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateStudentResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool UpdateStudentResult;
        
        public UpdateStudentResponseBody() {
        }
        
        public UpdateStudentResponseBody(bool UpdateStudentResult) {
            this.UpdateStudentResult = UpdateStudentResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : _2019410clientapp.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<_2019410clientapp.ServiceReference1.WebService1Soap>, _2019410clientapp.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        _2019410clientapp.ServiceReference1.GetStudentResponse _2019410clientapp.ServiceReference1.WebService1Soap.GetStudent(_2019410clientapp.ServiceReference1.GetStudentRequest request) {
            return base.Channel.GetStudent(request);
        }
        
        public _2019410clientapp.ServiceReference1.Student[] GetStudent() {
            _2019410clientapp.ServiceReference1.GetStudentRequest inValue = new _2019410clientapp.ServiceReference1.GetStudentRequest();
            inValue.Body = new _2019410clientapp.ServiceReference1.GetStudentRequestBody();
            _2019410clientapp.ServiceReference1.GetStudentResponse retVal = ((_2019410clientapp.ServiceReference1.WebService1Soap)(this)).GetStudent(inValue);
            return retVal.Body.GetStudentResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<_2019410clientapp.ServiceReference1.GetStudentResponse> _2019410clientapp.ServiceReference1.WebService1Soap.GetStudentAsync(_2019410clientapp.ServiceReference1.GetStudentRequest request) {
            return base.Channel.GetStudentAsync(request);
        }
        
        public System.Threading.Tasks.Task<_2019410clientapp.ServiceReference1.GetStudentResponse> GetStudentAsync() {
            _2019410clientapp.ServiceReference1.GetStudentRequest inValue = new _2019410clientapp.ServiceReference1.GetStudentRequest();
            inValue.Body = new _2019410clientapp.ServiceReference1.GetStudentRequestBody();
            return ((_2019410clientapp.ServiceReference1.WebService1Soap)(this)).GetStudentAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        _2019410clientapp.ServiceReference1.AddStudentResponse _2019410clientapp.ServiceReference1.WebService1Soap.AddStudent(_2019410clientapp.ServiceReference1.AddStudentRequest request) {
            return base.Channel.AddStudent(request);
        }
        
        public bool AddStudent(_2019410clientapp.ServiceReference1.Student s) {
            _2019410clientapp.ServiceReference1.AddStudentRequest inValue = new _2019410clientapp.ServiceReference1.AddStudentRequest();
            inValue.Body = new _2019410clientapp.ServiceReference1.AddStudentRequestBody();
            inValue.Body.s = s;
            _2019410clientapp.ServiceReference1.AddStudentResponse retVal = ((_2019410clientapp.ServiceReference1.WebService1Soap)(this)).AddStudent(inValue);
            return retVal.Body.AddStudentResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<_2019410clientapp.ServiceReference1.AddStudentResponse> _2019410clientapp.ServiceReference1.WebService1Soap.AddStudentAsync(_2019410clientapp.ServiceReference1.AddStudentRequest request) {
            return base.Channel.AddStudentAsync(request);
        }
        
        public System.Threading.Tasks.Task<_2019410clientapp.ServiceReference1.AddStudentResponse> AddStudentAsync(_2019410clientapp.ServiceReference1.Student s) {
            _2019410clientapp.ServiceReference1.AddStudentRequest inValue = new _2019410clientapp.ServiceReference1.AddStudentRequest();
            inValue.Body = new _2019410clientapp.ServiceReference1.AddStudentRequestBody();
            inValue.Body.s = s;
            return ((_2019410clientapp.ServiceReference1.WebService1Soap)(this)).AddStudentAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        _2019410clientapp.ServiceReference1.UpdateStudentResponse _2019410clientapp.ServiceReference1.WebService1Soap.UpdateStudent(_2019410clientapp.ServiceReference1.UpdateStudentRequest request) {
            return base.Channel.UpdateStudent(request);
        }
        
        public bool UpdateStudent(_2019410clientapp.ServiceReference1.Student s) {
            _2019410clientapp.ServiceReference1.UpdateStudentRequest inValue = new _2019410clientapp.ServiceReference1.UpdateStudentRequest();
            inValue.Body = new _2019410clientapp.ServiceReference1.UpdateStudentRequestBody();
            inValue.Body.s = s;
            _2019410clientapp.ServiceReference1.UpdateStudentResponse retVal = ((_2019410clientapp.ServiceReference1.WebService1Soap)(this)).UpdateStudent(inValue);
            return retVal.Body.UpdateStudentResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<_2019410clientapp.ServiceReference1.UpdateStudentResponse> _2019410clientapp.ServiceReference1.WebService1Soap.UpdateStudentAsync(_2019410clientapp.ServiceReference1.UpdateStudentRequest request) {
            return base.Channel.UpdateStudentAsync(request);
        }
        
        public System.Threading.Tasks.Task<_2019410clientapp.ServiceReference1.UpdateStudentResponse> UpdateStudentAsync(_2019410clientapp.ServiceReference1.Student s) {
            _2019410clientapp.ServiceReference1.UpdateStudentRequest inValue = new _2019410clientapp.ServiceReference1.UpdateStudentRequest();
            inValue.Body = new _2019410clientapp.ServiceReference1.UpdateStudentRequestBody();
            inValue.Body.s = s;
            return ((_2019410clientapp.ServiceReference1.WebService1Soap)(this)).UpdateStudentAsync(inValue);
        }
        
        public bool DeleteStudent(int studentID) {
            return base.Channel.DeleteStudent(studentID);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteStudentAsync(int studentID) {
            return base.Channel.DeleteStudentAsync(studentID);
        }
    }
}
