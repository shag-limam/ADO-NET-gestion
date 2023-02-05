using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Runtime.InteropServices;
namespace lmitp
{
    public partial class employeeform : Form
    {
        String connextionString = ConfigurationManager.ConnectionStrings["cnxsql"].ConnectionString;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        ( 
           int nLeft,
           int nTop,
           int nRight,
           int nBottom,
           int nWidthEllipse,
           int nHeightEllipse
           

        );
        public employeeform()
        {
            InitializeComponent();
        }

        private void employeeform_Load(object sender, EventArgs e)
        {
            StyleDatagridview();
            button1_Click(sender, e);
            this.dgvemp.ReadOnly = true;
            this.dgvemp.AllowUserToAddRows = false;
            int nbrlignes = this.dgvemp.Rows.Count - 1;
           // this.inputid.Text = (Convert.ToInt32(this.dgvemp.Rows[nbrlignes].Cells[0].Value.ToString()) + 1).ToString();
            this.inputnom.Focus();
            btnemp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnemp.Width, btnemp.Height, 30, 30));
            btnajouter.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnajouter.Width, btnajouter.Height, 30, 30));
            btnsup.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnsup.Width, btnsup.Height, 30, 30));
            btnmodi.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnmodi.Width, btnmodi.Height, 30, 30));
            btnNew.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnNew.Width, btnNew.Height, 30, 30));
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connextionString;
            String req = "SELECT * FROM dept";
            SqlDataAdapter da = new SqlDataAdapter(req, cnx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string a;
            inputdepartement.DataSource = dt;
            inputdepartement.DisplayMember = "dept_nom";
            inputdepartement.ValueMember = "dept_id";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //list de var
        bool check = false;
        int inde = -1, Idepm;
        String N;
        private void dgvemp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            inde = this.dgvemp.CurrentRow.Index;
            Idepm = int.Parse(this.dgvemp.Rows[inde].Cells[0].Value.ToString());
            N = this.dgvemp.Rows[inde].Cells[1].Value.ToString();

            //modi

            this.inputid.Text = this.dgvemp.Rows[inde].Cells[0].Value.ToString();
            this.inputnom.Text = this.dgvemp.Rows[inde].Cells[1].Value.ToString();
            this.inputprenom.Text = this.dgvemp.Rows[inde].Cells[2].Value.ToString();
            this.inputage.Text = this.dgvemp.Rows[inde].Cells[3].Value.ToString();
            this.inputdepartement.DisplayMember = this.dgvemp.Rows[inde].Cells[4].ToString();
            this.inputsalaire.Text = this.dgvemp.Rows[inde].Cells[5].Value.ToString();

            this.inputid.Enabled = false;
            check = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            //cnx.ConnectionString =@"Data Source=DESKTOP-BQB1CKT\SQLEXPRESS;Initial Catalog=B1;Integrated Security=True";
            cnx.ConnectionString = connextionString;
            String req = "select emp_id,emp_nom,emp_prenom,emp_age ,dept_nom,emp_salaire from emp,dept where emp.dept_id=dept.dept_id;";
            SqlCommand cmd = new SqlCommand(req, cnx);
            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows == true)
            {
                this.dgvemp.Rows.Clear();
                while (rd.Read())
                {
                    this.dgvemp.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5]);

                }
                cnx.Close();
            }
            else
                MessageBox.Show("la table employé est vide");
        }
        void StyleDatagridview()
        {

            dgvemp.BorderStyle = BorderStyle.None;
            dgvemp.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(105, 105, 105);
            dgvemp.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvemp.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgvemp.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvemp.BackgroundColor = Color.FromArgb(105, 105, 105);
            dgvemp.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dgvemp.EnableHeadersVisualStyles = false;
            dgvemp.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvemp.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dgvemp.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(177, 177, 177);
            dgvemp.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
         //btn ajou
        private void btnajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (check == true)
                    return;
                if (!CheckInfo())
                {
                    MessageBox.Show("veuillez saisie tous les informations d'employé");
                    return;
                }
                using (SqlConnection cnx = new SqlConnection(connextionString))
                {
                    String req = "INSERT INTO emp VALUES (@id,@nom,@prenom,@age,@departememnt,@salaire)";
                    SqlCommand cmd = new SqlCommand(req, cnx);
                    cmd.Parameters.AddWithValue("@id", inputid.Text);
                    cmd.Parameters.AddWithValue("@nom", inputnom.Text.Trim());
                    cmd.Parameters.AddWithValue("@prenom", inputprenom.Text);
                    cmd.Parameters.AddWithValue("@age", inputage.Text);
                    cmd.Parameters.AddWithValue("@departememnt", inputdepartement.SelectedValue);
                    cmd.Parameters.AddWithValue("@salaire", inputsalaire.Text);
                     

                      if (cnx.State == ConnectionState.Open)
                          cnx.Close();
                          cnx.Open();
                          int a = cmd.ExecuteNonQuery();
                           button1_Click(sender, e);
                           MessageBox.Show(a + " Ligne(s) affectèe");
                           cnx.Close();
               }
            }
            catch (SqlException ex)
            {
                // if (ex.Number == 2627)
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckInfo()
        {
            if (this.inputid.Text.Trim().Equals(string.Empty) ||
                this.inputnom.Text.Trim().Equals(string.Empty)||
                this.inputprenom.Text.Trim().Equals(string.Empty)||
                this.inputage.Text.Trim().Equals(string.Empty)||
                this.inputdepartement.Text.Trim().Equals(string.Empty)||
                this.inputsalaire.Text.Trim().Equals(string.Empty))
                return false;
            return true;

        }

        private void btnsup_Click(object sender, EventArgs e)
        {
            if (inde == -1)
            {
                MessageBox.Show("veullez SVP selectionner une ligne !!");
                return;
            }

            using (SqlConnection cnx = new SqlConnection(connextionString))
            {
                DialogResult dialog = MessageBox.Show("hamk Tm7i : " + N, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                    return;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "DELETE FROM emp WHERE emp_id= @id";
                cmd.Parameters.AddWithValue("@id", Idepm);
                cnx.Open();
                cmd.ExecuteNonQuery();
                this.dgvemp.Rows.RemoveAt(inde);
                MessageBox.Show("l'employé est bien supprimé");
                cnx.Close();
            }
        }

        private void btnmodi_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("hamk Tmodifi : " + N, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
                return;//stop
            String Query = "UPDATE emp SET emp_nom = @p1 ,emp_prenom = @p2 ,emp_age = @p3 ,dept_id = @p4 ,emp_salaire = @p5 where emp_id = @p6";
            using (SqlConnection cnx = new SqlConnection(connextionString))
            {
                SqlCommand cmd = new SqlCommand(Query, cnx);
                cmd.Parameters.AddWithValue("@p1", this.inputnom.Text.Trim());
                cmd.Parameters.AddWithValue("@p2", this.inputprenom.Text.Trim());
                cmd.Parameters.AddWithValue("@p3", this.inputage.Text.Trim());
                cmd.Parameters.AddWithValue("@p4", this.inputdepartement.SelectedValue);
                cmd.Parameters.AddWithValue("@p5", this.inputsalaire.Text.Trim());
                cmd.Parameters.AddWithValue("@p6", this.inputid.Text.Trim());
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                button1_Click(sender, e);
                MessageBox.Show("l'employé est bien modifié");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            check = false;
            this.inputid.Text = string.Empty;
            this.inputnom.Text = string.Empty;
            this.inputprenom.Text = string.Empty;
            this.inputage.Text = string.Empty;
            this.inputdepartement.Text = string.Empty;
            this.inputsalaire.Text = string.Empty;

            this.inputid.Enabled = true;

            int nbrlignes = this.dgvemp.Rows.Count - 1;
            this.inputid.Text = (Convert.ToInt32(this.dgvemp.Rows[nbrlignes].Cells[0].Value.ToString()) + 1).ToString();
            this.inputnom.Focus();
        }

        private void inputdepartement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

    }
}
