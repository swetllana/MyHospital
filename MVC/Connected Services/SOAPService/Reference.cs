//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC.SOAPService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SOAPService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        MVC.SOAPService.CompositeType GetDataUsingDataContract(MVC.SOAPService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<MVC.SOAPService.CompositeType> GetDataUsingDataContractAsync(MVC.SOAPService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDoctors", ReplyAction="http://tempuri.org/IService1/GetDoctorsResponse")]
        ApplicationService.DTOs.DoctorDTO[] GetDoctors(string search);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDoctors", ReplyAction="http://tempuri.org/IService1/GetDoctorsResponse")]
        System.Threading.Tasks.Task<ApplicationService.DTOs.DoctorDTO[]> GetDoctorsAsync(string search);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDoctorByID", ReplyAction="http://tempuri.org/IService1/GetDoctorByIDResponse")]
        ApplicationService.DTOs.DoctorDTO GetDoctorByID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDoctorByID", ReplyAction="http://tempuri.org/IService1/GetDoctorByIDResponse")]
        System.Threading.Tasks.Task<ApplicationService.DTOs.DoctorDTO> GetDoctorByIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostDoctors", ReplyAction="http://tempuri.org/IService1/PostDoctorsResponse")]
        string PostDoctors(ApplicationService.DTOs.DoctorDTO doctorDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostDoctors", ReplyAction="http://tempuri.org/IService1/PostDoctorsResponse")]
        System.Threading.Tasks.Task<string> PostDoctorsAsync(ApplicationService.DTOs.DoctorDTO doctorDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutDoctor", ReplyAction="http://tempuri.org/IService1/PutDoctorResponse")]
        string PutDoctor(ApplicationService.DTOs.DoctorDTO doctorDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutDoctor", ReplyAction="http://tempuri.org/IService1/PutDoctorResponse")]
        System.Threading.Tasks.Task<string> PutDoctorAsync(ApplicationService.DTOs.DoctorDTO doctorDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteDoctor", ReplyAction="http://tempuri.org/IService1/DeleteDoctorResponse")]
        string DeleteDoctor(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteDoctor", ReplyAction="http://tempuri.org/IService1/DeleteDoctorResponse")]
        System.Threading.Tasks.Task<string> DeleteDoctorAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPatients", ReplyAction="http://tempuri.org/IService1/GetPatientsResponse")]
        ApplicationService.DTOs.PatientDTO[] GetPatients(string search);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPatients", ReplyAction="http://tempuri.org/IService1/GetPatientsResponse")]
        System.Threading.Tasks.Task<ApplicationService.DTOs.PatientDTO[]> GetPatientsAsync(string search);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPatientByID", ReplyAction="http://tempuri.org/IService1/GetPatientByIDResponse")]
        ApplicationService.DTOs.PatientDTO GetPatientByID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPatientByID", ReplyAction="http://tempuri.org/IService1/GetPatientByIDResponse")]
        System.Threading.Tasks.Task<ApplicationService.DTOs.PatientDTO> GetPatientByIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostPatients", ReplyAction="http://tempuri.org/IService1/PostPatientsResponse")]
        string PostPatients(ApplicationService.DTOs.PatientDTO patientDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostPatients", ReplyAction="http://tempuri.org/IService1/PostPatientsResponse")]
        System.Threading.Tasks.Task<string> PostPatientsAsync(ApplicationService.DTOs.PatientDTO patientDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutPatient", ReplyAction="http://tempuri.org/IService1/PutPatientResponse")]
        string PutPatient(ApplicationService.DTOs.PatientDTO patientDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutPatient", ReplyAction="http://tempuri.org/IService1/PutPatientResponse")]
        System.Threading.Tasks.Task<string> PutPatientAsync(ApplicationService.DTOs.PatientDTO patientDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeletePatient", ReplyAction="http://tempuri.org/IService1/DeletePatientResponse")]
        string DeletePatient(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeletePatient", ReplyAction="http://tempuri.org/IService1/DeletePatientResponse")]
        System.Threading.Tasks.Task<string> DeletePatientAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTests", ReplyAction="http://tempuri.org/IService1/GetTestsResponse")]
        ApplicationService.DTOs.TestDTO[] GetTests(string search);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTests", ReplyAction="http://tempuri.org/IService1/GetTestsResponse")]
        System.Threading.Tasks.Task<ApplicationService.DTOs.TestDTO[]> GetTestsAsync(string search);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTestByID", ReplyAction="http://tempuri.org/IService1/GetTestByIDResponse")]
        ApplicationService.DTOs.TestDTO GetTestByID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTestByID", ReplyAction="http://tempuri.org/IService1/GetTestByIDResponse")]
        System.Threading.Tasks.Task<ApplicationService.DTOs.TestDTO> GetTestByIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostTests", ReplyAction="http://tempuri.org/IService1/PostTestsResponse")]
        string PostTests(ApplicationService.DTOs.TestDTO testDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostTests", ReplyAction="http://tempuri.org/IService1/PostTestsResponse")]
        System.Threading.Tasks.Task<string> PostTestsAsync(ApplicationService.DTOs.TestDTO testDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutTest", ReplyAction="http://tempuri.org/IService1/PutTestResponse")]
        string PutTest(ApplicationService.DTOs.TestDTO testDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutTest", ReplyAction="http://tempuri.org/IService1/PutTestResponse")]
        System.Threading.Tasks.Task<string> PutTestAsync(ApplicationService.DTOs.TestDTO testDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteTest", ReplyAction="http://tempuri.org/IService1/DeleteTestResponse")]
        string DeleteTest(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteTest", ReplyAction="http://tempuri.org/IService1/DeleteTestResponse")]
        System.Threading.Tasks.Task<string> DeleteTestAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUsers", ReplyAction="http://tempuri.org/IService1/GetUsersResponse")]
        ApplicationService.DTOs.UserDTO[] GetUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUsers", ReplyAction="http://tempuri.org/IService1/GetUsersResponse")]
        System.Threading.Tasks.Task<ApplicationService.DTOs.UserDTO[]> GetUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUserByID", ReplyAction="http://tempuri.org/IService1/GetUserByIDResponse")]
        ApplicationService.DTOs.UserDTO GetUserByID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUserByID", ReplyAction="http://tempuri.org/IService1/GetUserByIDResponse")]
        System.Threading.Tasks.Task<ApplicationService.DTOs.UserDTO> GetUserByIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostUsers", ReplyAction="http://tempuri.org/IService1/PostUsersResponse")]
        string PostUsers(ApplicationService.DTOs.UserDTO userDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostUsers", ReplyAction="http://tempuri.org/IService1/PostUsersResponse")]
        System.Threading.Tasks.Task<string> PostUsersAsync(ApplicationService.DTOs.UserDTO userDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteUser", ReplyAction="http://tempuri.org/IService1/DeleteUserResponse")]
        string DeleteUser(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteUser", ReplyAction="http://tempuri.org/IService1/DeleteUserResponse")]
        System.Threading.Tasks.Task<string> DeleteUserAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : MVC.SOAPService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<MVC.SOAPService.IService1>, MVC.SOAPService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public MVC.SOAPService.CompositeType GetDataUsingDataContract(MVC.SOAPService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<MVC.SOAPService.CompositeType> GetDataUsingDataContractAsync(MVC.SOAPService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public ApplicationService.DTOs.DoctorDTO[] GetDoctors(string search) {
            return base.Channel.GetDoctors(search);
        }
        
        public System.Threading.Tasks.Task<ApplicationService.DTOs.DoctorDTO[]> GetDoctorsAsync(string search) {
            return base.Channel.GetDoctorsAsync(search);
        }
        
        public ApplicationService.DTOs.DoctorDTO GetDoctorByID(int id) {
            return base.Channel.GetDoctorByID(id);
        }
        
        public System.Threading.Tasks.Task<ApplicationService.DTOs.DoctorDTO> GetDoctorByIDAsync(int id) {
            return base.Channel.GetDoctorByIDAsync(id);
        }
        
        public string PostDoctors(ApplicationService.DTOs.DoctorDTO doctorDTO) {
            return base.Channel.PostDoctors(doctorDTO);
        }
        
        public System.Threading.Tasks.Task<string> PostDoctorsAsync(ApplicationService.DTOs.DoctorDTO doctorDTO) {
            return base.Channel.PostDoctorsAsync(doctorDTO);
        }
        
        public string PutDoctor(ApplicationService.DTOs.DoctorDTO doctorDTO) {
            return base.Channel.PutDoctor(doctorDTO);
        }
        
        public System.Threading.Tasks.Task<string> PutDoctorAsync(ApplicationService.DTOs.DoctorDTO doctorDTO) {
            return base.Channel.PutDoctorAsync(doctorDTO);
        }
        
        public string DeleteDoctor(int id) {
            return base.Channel.DeleteDoctor(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteDoctorAsync(int id) {
            return base.Channel.DeleteDoctorAsync(id);
        }
        
        public ApplicationService.DTOs.PatientDTO[] GetPatients(string search) {
            return base.Channel.GetPatients(search);
        }
        
        public System.Threading.Tasks.Task<ApplicationService.DTOs.PatientDTO[]> GetPatientsAsync(string search) {
            return base.Channel.GetPatientsAsync(search);
        }
        
        public ApplicationService.DTOs.PatientDTO GetPatientByID(int id) {
            return base.Channel.GetPatientByID(id);
        }
        
        public System.Threading.Tasks.Task<ApplicationService.DTOs.PatientDTO> GetPatientByIDAsync(int id) {
            return base.Channel.GetPatientByIDAsync(id);
        }
        
        public string PostPatients(ApplicationService.DTOs.PatientDTO patientDTO) {
            return base.Channel.PostPatients(patientDTO);
        }
        
        public System.Threading.Tasks.Task<string> PostPatientsAsync(ApplicationService.DTOs.PatientDTO patientDTO) {
            return base.Channel.PostPatientsAsync(patientDTO);
        }
        
        public string PutPatient(ApplicationService.DTOs.PatientDTO patientDTO) {
            return base.Channel.PutPatient(patientDTO);
        }
        
        public System.Threading.Tasks.Task<string> PutPatientAsync(ApplicationService.DTOs.PatientDTO patientDTO) {
            return base.Channel.PutPatientAsync(patientDTO);
        }
        
        public string DeletePatient(int id) {
            return base.Channel.DeletePatient(id);
        }
        
        public System.Threading.Tasks.Task<string> DeletePatientAsync(int id) {
            return base.Channel.DeletePatientAsync(id);
        }
        
        public ApplicationService.DTOs.TestDTO[] GetTests(string search) {
            return base.Channel.GetTests(search);
        }
        
        public System.Threading.Tasks.Task<ApplicationService.DTOs.TestDTO[]> GetTestsAsync(string search) {
            return base.Channel.GetTestsAsync(search);
        }
        
        public ApplicationService.DTOs.TestDTO GetTestByID(int id) {
            return base.Channel.GetTestByID(id);
        }
        
        public System.Threading.Tasks.Task<ApplicationService.DTOs.TestDTO> GetTestByIDAsync(int id) {
            return base.Channel.GetTestByIDAsync(id);
        }
        
        public string PostTests(ApplicationService.DTOs.TestDTO testDTO) {
            return base.Channel.PostTests(testDTO);
        }
        
        public System.Threading.Tasks.Task<string> PostTestsAsync(ApplicationService.DTOs.TestDTO testDTO) {
            return base.Channel.PostTestsAsync(testDTO);
        }
        
        public string PutTest(ApplicationService.DTOs.TestDTO testDto) {
            return base.Channel.PutTest(testDto);
        }
        
        public System.Threading.Tasks.Task<string> PutTestAsync(ApplicationService.DTOs.TestDTO testDto) {
            return base.Channel.PutTestAsync(testDto);
        }
        
        public string DeleteTest(int id) {
            return base.Channel.DeleteTest(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteTestAsync(int id) {
            return base.Channel.DeleteTestAsync(id);
        }
        
        public ApplicationService.DTOs.UserDTO[] GetUsers() {
            return base.Channel.GetUsers();
        }
        
        public System.Threading.Tasks.Task<ApplicationService.DTOs.UserDTO[]> GetUsersAsync() {
            return base.Channel.GetUsersAsync();
        }
        
        public ApplicationService.DTOs.UserDTO GetUserByID(int id) {
            return base.Channel.GetUserByID(id);
        }
        
        public System.Threading.Tasks.Task<ApplicationService.DTOs.UserDTO> GetUserByIDAsync(int id) {
            return base.Channel.GetUserByIDAsync(id);
        }
        
        public string PostUsers(ApplicationService.DTOs.UserDTO userDTO) {
            return base.Channel.PostUsers(userDTO);
        }
        
        public System.Threading.Tasks.Task<string> PostUsersAsync(ApplicationService.DTOs.UserDTO userDTO) {
            return base.Channel.PostUsersAsync(userDTO);
        }
        
        public string DeleteUser(int id) {
            return base.Channel.DeleteUser(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteUserAsync(int id) {
            return base.Channel.DeleteUserAsync(id);
        }
    }
}
