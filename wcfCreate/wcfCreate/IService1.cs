using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcfCreate
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string CreateEmployee(Employee Emp);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
   
    [DataContract]
     public class Employee
    {
        int empid;
        string fname, lname, dob, sex;


        [DataMember]
        public int Empid
        {
            get { return empid; }
            set { empid = value; }
        }

        [DataMember]
        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }

        [DataMember]
        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        [DataMember]
        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        [DataMember]
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
    }
}
