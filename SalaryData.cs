using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    class SalaryData
    {

        public string IdMat { get; set; }
        public string NomMat { get; set; }
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        //public string Gender { get; set; }
        public string Contact { get; set; }
        public string Position { get; set; }
        public string DateAchat { get; set; }
        public string Payement { get; set; } 

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public List<SalaryData> salaryEmployeeListData()
        {
            List<SalaryData> listdata = new List<SalaryData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT C.id, C.full_name, C.contact_number, C.position, A.dateAchat, A.payement, M.IdMat, M.nomMat " +
                     "FROM employees C " +
                     "LEFT JOIN achat A ON C.id = A.id " +
                     "LEFT JOIN materiel M ON A.IdMat = M.IdMat";


                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            SalaryData sd = new SalaryData();
                            sd.EmployeeID = reader["id"].ToString();
                            sd.Name = reader["full_name"].ToString();
                            sd.Contact = reader["contact_number"].ToString();  
                            sd.Position = reader["position"].ToString();
                            sd.Payement = reader["payement"] != DBNull.Value ? reader["payement"].ToString() : "";  
                            sd.DateAchat = reader["dateAchat"] != DBNull.Value ? reader["dateAchat"].ToString() : "";  
                            sd.IdMat = reader["IdMat"] != DBNull.Value ? reader["IdMat"].ToString() : "";  
                            sd.NomMat = reader["nomMat"] != DBNull.Value ? reader["nomMat"].ToString() : "";  

                            listdata.Add(sd);
                        }


                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }

    }
}
