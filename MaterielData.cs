using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class MaterielData
    {

        public string IdMat { set; get; } // 1
        public string NomMat { set; get; } // 2
        public string DescMat { set; get; } // 3
        public string Prix { set; get; } // 4
        public string Image { set; get; } // 6
        public int QteMat { set; get; } // 7
        public string EtatMat { set; get; } // 8

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public List<MaterielData> employeeListData()
        {
            List<MaterielData> listdata = new List<MaterielData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT IdMat, nomMat, descMat, prixMat, etatMat, qteMat, image FROM materiel WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            MaterielData ed = new MaterielData();
                            ed.IdMat = reader["IdMat"].ToString();
                            ed.NomMat = reader["nomMat"].ToString();
                            ed.DescMat = reader["descMat"].ToString();
                            ed.Prix = reader["prixMat"].ToString();
                            ed.EtatMat = reader["etatMat"].ToString();
                            ed.QteMat = reader["qteMat"] != DBNull.Value ? (int)reader["qteMat"] : 0;
                            ed.Image = reader["image"].ToString();

                            listdata.Add(ed);
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

        public List<MaterielData> salaryEmployeeListData()
        {
            List<MaterielData> listdata = new List<MaterielData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM materiel ";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            MaterielData ed = new MaterielData();
                            ed.IdMat = reader["IdMat"].ToString();
                            ed.NomMat = reader["nomMat"].ToString();
                            ed.DescMat = reader["descMat"].ToString();
                            ed.Prix = reader["prixMat"].ToString();
                           // ed.DateAchat = reader["dataAchat"].ToString();

                            listdata.Add(ed);
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
