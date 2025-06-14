
namespace EmployeeManagementSystem
{
    partial class Salary
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dateAchat = new System.Windows.Forms.TextBox();
            this.txtIdMat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.salary_clearBtn = new System.Windows.Forms.Button();
            this.salary_updateBtn = new System.Windows.Forms.Button();
            this.salary_salary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.salary_position = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.salary_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salary_employeeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_facture = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_facture);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dateAchat);
            this.panel1.Controls.Add(this.txtIdMat);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.salary_clearBtn);
            this.panel1.Controls.Add(this.salary_updateBtn);
            this.panel1.Controls.Add(this.salary_salary);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.salary_position);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.salary_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.salary_employeeID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(16, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 517);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Date d\'achat";
            // 
            // dateAchat
            // 
            this.dateAchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAchat.Location = new System.Drawing.Point(22, 362);
            this.dateAchat.Multiline = true;
            this.dateAchat.Name = "dateAchat";
            this.dateAchat.Size = new System.Drawing.Size(239, 25);
            this.dateAchat.TabIndex = 20;
            // 
            // txtIdMat
            // 
            this.txtIdMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMat.FormattingEnabled = true;
            this.txtIdMat.Items.AddRange(new object[] {
            "Mat01",
            "Mat02",
            "Mat03"});
            this.txtIdMat.Location = new System.Drawing.Point(22, 296);
            this.txtIdMat.Name = "txtIdMat";
            this.txtIdMat.Size = new System.Drawing.Size(227, 23);
            this.txtIdMat.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Code Matériel";
            // 
            // salary_clearBtn
            // 
            this.salary_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.salary_clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salary_clearBtn.FlatAppearance.BorderSize = 0;
            this.salary_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.salary_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.salary_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.salary_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salary_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_clearBtn.ForeColor = System.Drawing.Color.White;
            this.salary_clearBtn.Location = new System.Drawing.Point(153, 424);
            this.salary_clearBtn.Name = "salary_clearBtn";
            this.salary_clearBtn.Size = new System.Drawing.Size(96, 37);
            this.salary_clearBtn.TabIndex = 16;
            this.salary_clearBtn.Text = "Effacer";
            this.salary_clearBtn.UseVisualStyleBackColor = false;
            this.salary_clearBtn.Click += new System.EventHandler(this.salary_clearBtn_Click);
            // 
            // salary_updateBtn
            // 
            this.salary_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.salary_updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salary_updateBtn.FlatAppearance.BorderSize = 0;
            this.salary_updateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.salary_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.salary_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.salary_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salary_updateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_updateBtn.ForeColor = System.Drawing.Color.White;
            this.salary_updateBtn.Location = new System.Drawing.Point(22, 424);
            this.salary_updateBtn.Name = "salary_updateBtn";
            this.salary_updateBtn.Size = new System.Drawing.Size(96, 37);
            this.salary_updateBtn.TabIndex = 15;
            this.salary_updateBtn.Text = "Ajouter";
            this.salary_updateBtn.UseVisualStyleBackColor = false;
            this.salary_updateBtn.Click += new System.EventHandler(this.salary_updateBtn_Click);
            // 
            // salary_salary
            // 
            this.salary_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_salary.Location = new System.Drawing.Point(22, 222);
            this.salary_salary.Multiline = true;
            this.salary_salary.Name = "salary_salary";
            this.salary_salary.Size = new System.Drawing.Size(239, 25);
            this.salary_salary.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Payement";
            // 
            // salary_position
            // 
            this.salary_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_position.Location = new System.Drawing.Point(22, 163);
            this.salary_position.Multiline = true;
            this.salary_position.Name = "salary_position";
            this.salary_position.Size = new System.Drawing.Size(239, 25);
            this.salary_position.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adresse";
            // 
            // salary_name
            // 
            this.salary_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_name.Location = new System.Drawing.Point(22, 103);
            this.salary_name.Multiline = true;
            this.salary_name.Name = "salary_name";
            this.salary_name.Size = new System.Drawing.Size(239, 25);
            this.salary_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name:";
            // 
            // salary_employeeID
            // 
            this.salary_employeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_employeeID.Location = new System.Drawing.Point(22, 41);
            this.salary_employeeID.Multiline = true;
            this.salary_employeeID.Name = "salary_employeeID";
            this.salary_employeeID.Size = new System.Drawing.Size(239, 25);
            this.salary_employeeID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(311, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 517);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(20, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(508, 431);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des achats";
            // 
            // btn_facture
            // 
            this.btn_facture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btn_facture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_facture.FlatAppearance.BorderSize = 0;
            this.btn_facture.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btn_facture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btn_facture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btn_facture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facture.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facture.ForeColor = System.Drawing.Color.White;
            this.btn_facture.Location = new System.Drawing.Point(87, 479);
            this.btn_facture.Name = "btn_facture";
            this.btn_facture.Size = new System.Drawing.Size(96, 25);
            this.btn_facture.TabIndex = 22;
            this.btn_facture.Text = "Facture";
            this.btn_facture.UseVisualStyleBackColor = false;
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Salary";
            this.Size = new System.Drawing.Size(875, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salary_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox salary_employeeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salary_position;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salary_salary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button salary_clearBtn;
        private System.Windows.Forms.Button salary_updateBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox txtIdMat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dateAchat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_facture;
    }
}
