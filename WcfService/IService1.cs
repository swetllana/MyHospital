using ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        /* Doctors */
        [OperationContract]
        List<DoctorDTO> GetDoctors(string search);

        [OperationContract]
        DoctorDTO GetDoctorByID(int id);

        [OperationContract]
        string PostDoctors(DoctorDTO doctorDTO);

        [OperationContract]
        string PutDoctor(DoctorDTO doctorDTO);

        [OperationContract]
        string DeleteDoctor(int id);

        /* Patients */
        [OperationContract]
        List<PatientDTO> GetPatients(string search);

        [OperationContract]
        PatientDTO GetPatientByID(int id);

        [OperationContract]
        string PostPatients(PatientDTO patientDTO);

        [OperationContract]
        string PutPatient(PatientDTO patientDTO);

        [OperationContract]
        string DeletePatient(int id);

        /* Tests */
        [OperationContract]
        List<TestDTO> GetTests(string search);

        [OperationContract]
        TestDTO GetTestByID(int id);

        [OperationContract]
        string PostTests(TestDTO testDTO);

        [OperationContract]
        string PutTest(TestDTO testDto);

        [OperationContract]
        string DeleteTest(int id);
        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfService.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
