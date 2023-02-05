namespace lmitp
{
    partial class Form3
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
            this.btnregi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtun = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnregi
            // 
            this.btnregi.BackColor = System.Drawing.Color.Gray;
            this.btnregi.FlatAppearance.BorderSize = 0;
            this.btnregi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregi.ForeColor = System.Drawing.Color.White;
            this.btnregi.Location = new System.Drawing.Point(303, 236);
            this.btnregi.Name = "btnregi";
            this.btnregi.Size = new System.Drawing.Size(75, 23);
            this.btnregi.TabIndex = 18;
            this.btnregi.Text = "Enregistré";
            this.btnregi.UseVisualStyleBackColor = false;
            this.btnregi.Click += new System.EventHandler(this.btncxn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(156, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mot de passe :";
            // 
            // txtpw
            // 
            this.txtpw.BackColor = System.Drawing.Color.Gray;
            this.txtpw.ForeColor = System.Drawing.Color.White;
            this.txtpw.Location = new System.Drawing.Point(156, 194);
            this.txtpw.Margin = new System.Windows.Forms.Padding(4);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(191, 20);
            this.txtpw.TabIndex = 14;
            this.txtpw.UseSystemPasswordChar = true;
            this.txtpw.TextChanged += new System.EventHandler(this.txtpw_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(156, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nom d\'utilisateur :";
            // 
            // txtun
            // 
            this.txtun.BackColor = System.Drawing.Color.Gray;
            this.txtun.ForeColor = System.Drawing.Color.White;
            this.txtun.Location = new System.Drawing.Point(156, 140);
            this.txtun.Margin = new System.Windows.Forms.Padding(4);
            this.txtun.Name = "txtun";
            this.txtun.Size = new System.Drawing.Size(191, 20);
            this.txtun.TabIndex = 11;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::lmitp.Properties.Resources.close_102_48;
            this.pictureBox4.Location = new System.Drawing.Point(510, -1);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::lmitp.Properties.Resources.user_24px;
            this.pictureBox3.Location = new System.Drawing.Point(355, 194);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::lmitp.Properties.Resources.user_24px;
            this.pictureBox2.Location = new System.Drawing.Point(355, 140);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lmitp.Properties.Resources.staff_96px;
            this.pictureBox1.Location = new System.Drawing.Point(211, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(534, 369);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnregi);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtun);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnregi;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtun;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}