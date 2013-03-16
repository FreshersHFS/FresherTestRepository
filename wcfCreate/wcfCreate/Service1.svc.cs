using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;

namespace wcfCreate
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
        
    public class Service1 : IService1
    {
        SqlConnection con = new SqlConnection(@"Data Source=HFSTRSRV2\SQLEXPRESS;Initial Catalog=Sushama;User ID=sa;Password=p@ssw0rd000");
        SqlCommand cmd = new SqlCommand();
        Employee Emp = new Employee();
              [WebInvoke(Method = "POST", UriTemplate = "CreateEmployee", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]

        public string CreateEmployee(Employee Emp)
        {
            string msg;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Employee values(" + Emp.Empid + ",'" + Emp.Fname + "','" + Emp.Lname + "','" + Emp.Dob + "','" + Emp.Sex + "')", con);
             cmd.ExecuteNonQuery();

              msg = " Details inserted successfully";
           

            return msg;
        }

    }
}
