using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace EmployeeManagementSystem
{
    public partial class Salary : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public Salary()
        {
            InitializeComponent();

            displayEmployees();
            loadMaterialIds(); 
            disableFields();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            displayEmployees();
            disableFields();
        }

        public void disableFields()
        {
            salary_employeeID.Enabled = false;
            salary_name.Enabled = false;
            salary_position.Enabled = false;
        }

        public void displayEmployees()
        {
            SalaryData ed = new SalaryData();
            List<SalaryData> listData = ed.salaryEmployeeListData();

            dataGridView1.DataSource = listData;
        }

        // Nouvelle méthode pour charger les IdMat dans la ComboBox
        public void loadMaterialIds()
        {
            try
            {
                connect.Open();
                string query = "SELECT IdMat FROM materiel";
                SqlCommand cmd = new SqlCommand(query, connect);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    txtIdMat.Items.Add(reader["IdMat"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void salary_updateBtn_Click(object sender, EventArgs e)
        {
            if (salary_employeeID.Text == "" || salary_name.Text == "" || salary_position.Text == "" || salary_salary.Text == "" || txtIdMat.Text == "")
            {
                MessageBox.Show("Veuillez remplier toutes les informations!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to Valider l'achat du Client ID: " + salary_employeeID.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                                
                            string updateData = "INSERT INTO achat (dateAchat, IdMat, id, payement) " +
                                                 "VALUES (@dateAchat, @IdMat, @employeeID, @payement)";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                // Conversion correcte pour les types
                                cmd.Parameters.AddWithValue("@payement", salary_salary.Text.Trim());  // VARCHAR
                                cmd.Parameters.AddWithValue("@IdMat", txtIdMat.Text.Trim());          // VARCHAR
                                cmd.Parameters.AddWithValue("@employeeID", int.Parse(salary_employeeID.Text.Trim()));  // Conversion en int pour l'ID
                                cmd.Parameters.AddWithValue("@dateAchat", DateTime.Parse(dateAchat.Text.Trim()));  // Conversion en DateTime pour la date d'achat

                                cmd.ExecuteNonQuery();
                                clearFields();
                            }


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void clearFields()
        {
            salary_employeeID.Text = "";
            salary_name.Text = "";
            salary_position.Text = "";
            salary_salary.Text = "";
            dateAchat.Text = "";
            txtIdMat.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                salary_employeeID.Text = row.Cells[2].Value.ToString();  // ID de l'employé
                salary_name.Text = row.Cells[3].Value.ToString();        // Nom
                salary_position.Text = row.Cells[5].Value.ToString();    // Position
                salary_salary.Text = row.Cells[7].Value.ToString();      // Payement
                dateAchat.Text = row.Cells[6].Value.ToString();          // Date d'achat
                txtIdMat.Text = row.Cells[0].Value.ToString();           // ID matériel
            }
        }

        private void salary_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
