using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Materiel : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public Materiel()
        {
            InitializeComponent();
            displayEmployeeData();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayEmployeeData();
        }

        public void displayEmployeeData()
        {
            try
            {
                // Récupérer la liste des données
                MaterielData md = new MaterielData();
                List<MaterielData> listData = md.employeeListData();

                // Vider d'abord le DataGridView
                dataGridView1.DataSource = null;

                // Vérifier si des données sont disponibles
                if (listData != null && listData.Count > 0)
                {
                    // Lier les données au DataGridView
                    dataGridView1.DataSource = listData;

                    // Rafraîchir l'affichage
                    dataGridView1.Refresh();
                }
                else
                {
                    MessageBox.Show("Aucune donnée disponible à afficher.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'affichage des données: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void addEmployee_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addEmployee_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addEmployee_addBtn_Click(object sender, EventArgs e)
        {
            if (txtIdMat.Text == ""
               || txtnomMat.Text == ""
               || txtprixMat.Text == ""
               || txtdescMat.Text == ""
               || txtetatMat.Text == ""
               || addEmployee_picture.Image == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkEmID = "SELECT COUNT(*) FROM materiel WHERE IdMat = @emID";

                        using (SqlCommand checkEm = new SqlCommand(checkEmID, connect))
                        {
                            checkEm.Parameters.AddWithValue("@emID", txtIdMat.Text.Trim());
                            int count = (int)checkEm.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(txtIdMat.Text.Trim() + " is already taken"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO materiel " +
                                    "(IdMat, nomMat, descMat, prixMat " +
                                    ",etatMat, qteMat,image) " +
                                    " VALUES (@IdMat, @nomMat, @descMat, @prixMat" +
                                    ", @etatMat, @qteMat, @image)";

                                string path = Path.Combine(@"D:\pro\Employee-Management-System-in-CSharp-main(2)\Employee-Management-System-in-CSharp-main\EmployeeManagementSystem\EmployeeManagementSystem\"
                                    + txtIdMat.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }
                                File.Copy(addEmployee_picture.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@IdMat", txtIdMat.Text.Trim());
                                    cmd.Parameters.AddWithValue("@nomMat", txtnomMat.Text.Trim());
                                    cmd.Parameters.AddWithValue("@descMat", txtdescMat.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prixMat", txtprixMat.Text.Trim());
                                    cmd.Parameters.AddWithValue("@etatMat", txtetatMat.Text.Trim());
                                    cmd.Parameters.AddWithValue("@qteMat", int.Parse(txtqteMat.Text.Trim()));
                                    cmd.Parameters.AddWithValue("@image", path);
                                    

                                    cmd.ExecuteNonQuery();

                                    displayEmployeeData();

                                    MessageBox.Show("Added successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void clearFields()
        {
            txtIdMat.Text = "";
            txtnomMat.Text = "";
            txtdescMat.Text = "";
            txtprixMat.Text = "";
            txtqteMat.Text = "";
            txtetatMat.SelectedIndex = -1;
            addEmployee_picture.Image = null;
        }

        private void addEmployee_updateBtn_Click(object sender, EventArgs e)
        {
            if (txtIdMat.Text == ""
               || txtnomMat.Text == ""
               || txtprixMat.Text == ""
               || txtdescMat.Text == ""
               || txtetatMat.Text == ""
               || addEmployee_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Voulez vous modifier " +
                    "Materiel Numero: " + txtIdMat.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE materiel SET nomMat = @nomMat" +
                            ", descMat = @descMat, prixMat = @prixMat" +
                            ", etatMat = @etatMat" +
                            "WHERE IdMat = @IdMat";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@nomMat", txtnomMat.Text.Trim());
                            cmd.Parameters.AddWithValue("@descMat", txtdescMat.Text.Trim());
                            cmd.Parameters.AddWithValue("@prixMat", txtprixMat.Text.Trim());
                            cmd.Parameters.AddWithValue("@etatMat", txtetatMat.Text.Trim());
                            //cmd.Parameters.AddWithValue("@updateDate", today);
                            cmd.Parameters.AddWithValue("@qteMat", txtqteMat.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();

                            MessageBox.Show("Mise à jour avec succès!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void addEmployee_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addEmployee_deleteBtn_Click(object sender, EventArgs e)
        {
            if (txtIdMat.Text == ""
               || txtnomMat.Text == ""
               || txtprixMat.Text == ""
               || txtdescMat.Text == ""
               || txtetatMat.Text == ""
               || addEmployee_picture.Image == null)
            {
                MessageBox.Show("Veuillez verifiez les information a supprimer!"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                    "Materiel Id: " + txtIdMat.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE materiel SET delete_date = @deleteDate " +
                            "WHERE IdMat = @IdMat";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@deleteDate", today);
                            cmd.Parameters.AddWithValue("@IdMat", txtIdMat.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();

                            MessageBox.Show("Mise a jour avec succes!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void addEmployee_picture_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtIdMat.Text = row.Cells["IdMat"].Value.ToString();
                txtnomMat.Text = row.Cells["nomMat"].Value.ToString();
                txtdescMat.Text = row.Cells["descMat"].Value.ToString();
                txtqteMat.Text = row.Cells["qteMat"].Value.ToString();

                // Gestion de prixMat
                if (row.Cells["prix"].Value != null)
                {
                    txtprixMat.Text = row.Cells["prix"].Value.ToString();
                }

                // Gestion de etatMat
                if (row.Cells["etatMat"].Value != null)
                {
                    txtetatMat.Text = row.Cells["etatMat"].Value.ToString();
                }

                // Gestion de l'image
                string imagePath = row.Cells["image"].Value.ToString();
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    addEmployee_picture.Image = Image.FromFile(imagePath);
                }
                else
                {
                    addEmployee_picture.Image = null;
                }
            }
        }


    }
}

