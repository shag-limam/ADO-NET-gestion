using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;



namespace lmitp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static String connextionString = ConfigurationManager.ConnectionStrings["cnxsql"].ConnectionString;
        public static String ut;
        private void Form2_Load(object sender, EventArgs e)
        {

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

            if(txtun.Text==""||txtpw.Text=="")
            {
                MessageBox.Show("Entrez votre nom d'utilisateur et votre mot de passe");
                return;
            }
            try
            {
                SqlConnection cxn = new SqlConnection(connextionString);
                SqlDataAdapter sda = new System.Data.SqlClient.SqlDataAdapter("select  Mot from Admin where Nom ='"
                 + txtun.Text + "' and Mot ='" + mot + "'", cxn);
                //SqlDataAdapter sda = new SqlDataAdapter("select AdminType from A where AdminNom ='" + txtun.Text + "' and AdminPass =CONVERT(NVARCHAR(32)HashBytes('MD5','" + txtpw.Text + "'),2)", cxn);

               DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                 
                        Form1 f1 = new Form1();
                        f1.Show();
                        this.Hide();
                  
                  
                }
                else 
                {
                    MessageBox.Show("Vérifier le nom d'utilisateur et le mot de passe");
                
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtpw.UseSystemPasswordChar = false;
            }
            else 
            {
                txtpw.UseSystemPasswordChar = true;

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
