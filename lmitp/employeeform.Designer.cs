namespace lmitp
{
    partial class employeeform
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvemp = new System.Windows.Forms.DataGridView();
            this.emp_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_salaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnemp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnmodi = new System.Windows.Forms.Button();
            this.btnsup = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputid = new System.Windows.Forms.TextBox();
            this.inputnom = new System.Windows.Forms.TextBox();
            this.inputprenom = new System.Windows.Forms.TextBox();
            this.inputage = new System.Windows.Forms.TextBox();
            this.inputsalaire = new System.Windows.Forms.TextBox();
            this.inputdepartement = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvemp
            // 
            this.dgvemp.AllowUserToAddRows = false;
            this.dgvemp.AllowUserToDeleteRows = false;
            this.dgvemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvemp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emp_id,
            this.emp_nom,
            this.emp_prenom,
            this.emp_age,
            this.dept_id,
            this.emp_salaire});
            this.dgvemp.Location = new System.Drawing.Point(-1, 139);
            this.dgvemp.Name = "dgvemp";
            this.dgvemp.ReadOnly = true;
            this.dgvemp.Size = new System.Drawing.Size(589, 285);
            this.dgvemp.TabIndex = 0;
            this.dgvemp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvemp_CellContentClick);
            // 
            // emp_id
            // 
            this.emp_id.FillWeight = 110F;
            this.emp_id.Frozen = true;
            this.emp_id.HeaderText = "ID";
            this.emp_id.Name = "emp_id";
            this.emp_id.ReadOnly = true;
            this.emp_id.Width = 92;
            // 
            // emp_nom
            // 
            this.emp_nom.Frozen = true;
            this.emp_nom.HeaderText = "Nom";
            this.emp_nom.Name = "emp_nom";
            this.emp_nom.ReadOnly = true;
            this.emp_nom.Width = 93;
            // 
            // emp_prenom
            // 
            this.emp_prenom.Frozen = true;
            this.emp_prenom.HeaderText = "Prenom";
            this.emp_prenom.Name = "emp_prenom";
            this.emp_prenom.ReadOnly = true;
            this.emp_prenom.Width = 93;
            // 
            // emp_age
            // 
            this.emp_age.Frozen = true;
            this.emp_age.HeaderText = "Age";
            this.emp_age.Name = "emp_age";
            this.emp_age.ReadOnly = true;
            this.emp_age.Width = 93;
            // 
            // dept_id
            // 
            this.dept_id.Frozen = true;
            this.dept_id.HeaderText = "Département";
            this.dept_id.Name = "dept_id";
            this.dept_id.ReadOnly = true;
            this.dept_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dept_id.Width = 94;
            // 
            // emp_salaire
            // 
            this.emp_salaire.Frozen = true;
            this.emp_salaire.HeaderText = "Salaire";
            this.emp_salaire.Name = "emp_salaire";
            this.emp_salaire.ReadOnly = true;
            this.emp_salaire.Width = 94;
            // 
            // btnemp
            // 
            this.btnemp.BackColor = System.Drawing.Color.Gray;
            this.btnemp.FlatAppearance.BorderSize = 0;
            this.btnemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemp.Location = new System.Drawing.Point(103, 79);
            this.btnemp.Name = "btnemp";
            this.btnemp.Size = new System.Drawing.Size(91, 23);
            this.btnemp.TabIndex = 1;
            this.btnemp.Text = "Liste d\'employé";
            this.btnemp.UseVisualStyleBackColor = false;
            this.btnemp.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnmodi);
            this.groupBox1.Controls.Add(this.btnsup);
            this.groupBox1.Controls.Add(this.btnajouter);
            this.groupBox1.Controls.Add(this.btnemp);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(388, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 106);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opérations :";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Gray;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(6, 48);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(91, 23);
            this.btnNew.TabIndex = 18;
            this.btnNew.Text = "Nouveau";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnmodi
            // 
            this.btnmodi.BackColor = System.Drawing.Color.Gray;
            this.btnmodi.FlatAppearance.BorderSize = 0;
            this.btnmodi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodi.Location = new System.Drawing.Point(103, 48);
            this.btnmodi.Name = "btnmodi";
            this.btnmodi.Size = new System.Drawing.Size(91, 23);
            this.btnmodi.TabIndex = 17;
            this.btnmodi.Text = "Modifier";
            this.btnmodi.UseVisualStyleBackColor = false;
            this.btnmodi.Click += new System.EventHandler(this.btnmodi_Click);
            // 
            // btnsup
            // 
            this.btnsup.BackColor = System.Drawing.Color.Gray;
            this.btnsup.FlatAppearance.BorderSize = 0;
            this.btnsup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsup.Location = new System.Drawing.Point(103, 19);
            this.btnsup.Name = "btnsup";
            this.btnsup.Size = new System.Drawing.Size(91, 23);
            this.btnsup.TabIndex = 16;
            this.btnsup.Text = "Supprimer";
            this.btnsup.UseVisualStyleBackColor = false;
            this.btnsup.Click += new System.EventHandler(this.btnsup_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.Gray;
            this.btnajouter.FlatAppearance.BorderSize = 0;
            this.btnajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.Location = new System.Drawing.Point(6, 19);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(91, 23);
            this.btnajouter.TabIndex = 15;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(166, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-1, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prenom :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(166, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Salaire :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(166, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Département :";
            // 
            // inputid
            // 
            this.inputid.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputid.ForeColor = System.Drawing.Color.DimGray;
            this.inputid.Location = new System.Drawing.Point(54, 5);
            this.inputid.Name = "inputid";
            this.inputid.Size = new System.Drawing.Size(100, 21);
            this.inputid.TabIndex = 9;
            this.inputid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // inputnom
            // 
            this.inputnom.Location = new System.Drawing.Point(54, 36);
            this.inputnom.Name = "inputnom";
            this.inputnom.Size = new System.Drawing.Size(100, 20);
            this.inputnom.TabIndex = 10;
            // 
            // inputprenom
            // 
            this.inputprenom.Location = new System.Drawing.Point(54, 77);
            this.inputprenom.Name = "inputprenom";
            this.inputprenom.Size = new System.Drawing.Size(100, 20);
            this.inputprenom.TabIndex = 11;
            // 
            // inputage
            // 
            this.inputage.Location = new System.Drawing.Point(250, 6);
            this.inputage.Name = "inputage";
            this.inputage.Size = new System.Drawing.Size(100, 20);
            this.inputage.TabIndex = 12;
            // 
            // inputsalaire
            // 
            this.inputsalaire.Location = new System.Drawing.Point(250, 77);
            this.inputsalaire.Name = "inputsalaire";
            this.inputsalaire.Size = new System.Drawing.Size(100, 20);
            this.inputsalaire.TabIndex = 14;
            // 
            // inputdepartement
            // 
            this.inputdepartement.FormattingEnabled = true;
            this.inputdepartement.Location = new System.Drawing.Point(250, 40);
            this.inputdepartement.Name = "inputdepartement";
            this.inputdepartement.Size = new System.Drawing.Size(100, 21);
            this.inputdepartement.TabIndex = 15;
            this.inputdepartement.SelectedIndexChanged += new System.EventHandler(this.inputdepartement_SelectedIndexChanged);
            // 
            // employeeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputdepartement);
            this.Controls.Add(this.inputsalaire);
            this.Controls.Add(this.inputage);
            this.Controls.Add(this.inputprenom);
            this.Controls.Add(this.inputnom);
            this.Controls.Add(this.inputid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employeeform";
            this.Text = "employeeform";
            this.Load += new System.EventHandler(this.employeeform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvemp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvemp;
        private System.Windows.Forms.Button btnemp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputid;
        private System.Windows.Forms.TextBox inputnom;
        private System.Windows.Forms.TextBox inputprenom;
        private System.Windows.Forms.TextBox inputage;
        private System.Windows.Forms.TextBox inputsalaire;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnsup;
        private System.Windows.Forms.Button btnmodi;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox inputdepartement;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_salaire;

    }
}