namespace lmitp
{
    partial class departement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnmodi = new System.Windows.Forms.Button();
            this.btnsup = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnemp = new System.Windows.Forms.Button();
            this.dgvdep = new System.Windows.Forms.DataGridView();
            this.inputnom = new System.Windows.Forms.TextBox();
            this.inputid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dept_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdep)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnmodi);
            this.groupBox1.Controls.Add(this.btnsup);
            this.groupBox1.Controls.Add(this.btnajouter);
            this.groupBox1.Controls.Add(this.btnemp);
            this.groupBox1.Location = new System.Drawing.Point(385, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 106);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opérations :";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.White;
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
            this.btnmodi.BackColor = System.Drawing.Color.White;
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
            this.btnsup.BackColor = System.Drawing.Color.White;
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
            this.btnajouter.BackColor = System.Drawing.Color.White;
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
            // btnemp
            // 
            this.btnemp.BackColor = System.Drawing.Color.White;
            this.btnemp.FlatAppearance.BorderSize = 0;
            this.btnemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemp.Location = new System.Drawing.Point(103, 79);
            this.btnemp.Name = "btnemp";
            this.btnemp.Size = new System.Drawing.Size(91, 23);
            this.btnemp.TabIndex = 1;
            this.btnemp.Text = "Liste d\'employé";
            this.btnemp.UseVisualStyleBackColor = false;
            this.btnemp.Click += new System.EventHandler(this.btnemp_Click);
            // 
            // dgvdep
            // 
            this.dgvdep.AllowUserToAddRows = false;
            this.dgvdep.AllowUserToDeleteRows = false;
            this.dgvdep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dept_id,
            this.dept_nom});
            this.dgvdep.Location = new System.Drawing.Point(2, 153);
            this.dgvdep.Name = "dgvdep";
            this.dgvdep.ReadOnly = true;
            this.dgvdep.Size = new System.Drawing.Size(583, 285);
            this.dgvdep.TabIndex = 3;
            this.dgvdep.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdep_CellContentClick);
            // 
            // inputnom
            // 
            this.inputnom.Location = new System.Drawing.Point(232, 98);
            this.inputnom.Name = "inputnom";
            this.inputnom.Size = new System.Drawing.Size(100, 20);
            this.inputnom.TabIndex = 14;
            // 
            // inputid
            // 
            this.inputid.Location = new System.Drawing.Point(66, 97);
            this.inputid.Name = "inputid";
            this.inputid.Size = new System.Drawing.Size(100, 20);
            this.inputid.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id :";
            // 
            // dept_id
            // 
            this.dept_id.FillWeight = 110F;
            this.dept_id.Frozen = true;
            this.dept_id.HeaderText = "ID";
            this.dept_id.Name = "dept_id";
            this.dept_id.ReadOnly = true;
            this.dept_id.Width = 270;
            // 
            // dept_nom
            // 
            this.dept_nom.Frozen = true;
            this.dept_nom.HeaderText = "Nom";
            this.dept_nom.Name = "dept_nom";
            this.dept_nom.ReadOnly = true;
            this.dept_nom.Width = 270;
            // 
            // departement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputnom);
            this.Controls.Add(this.inputid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvdep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "departement";
            this.Text = "reportsform";
            this.Load += new System.EventHandler(this.reportsform_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnmodi;
        private System.Windows.Forms.Button btnsup;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnemp;
        private System.Windows.Forms.DataGridView dgvdep;
        private System.Windows.Forms.TextBox inputnom;
        private System.Windows.Forms.TextBox inputid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_nom;

    }
}