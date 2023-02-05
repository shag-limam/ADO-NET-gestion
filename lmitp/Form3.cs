using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace lmitp
{
    public partial class Form3 : Form
    {
      SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-BQB1CKT\SQLEXPRESS;Initial Catalog=B1;Integrated Security=True");
      SqlCommand sc;
         
        public Form3()
        {
            InitializeComponent();
        }

        private void btncxn_Click(object sender, EventArgs e)
        {
            MD5 md = MD5.Create();
            byte[] byts = System.Text.ASCIIEncoding.ASCII.GetBytes(txtpw.Text);
            byte[] hash = md.ComputeHash(byts);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++) 
            {
                sb.Append(hash[i].ToString("x2"));
            }
            var mot = sb.ToString();
            sc = new SqlCommand("insert into Admin (Nom,Mot) values ('" +
             txtun.Text + "','" + mot + "')", sql);
            sql.Open();
            sc.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Enregistré avec succés");
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void txtpw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
