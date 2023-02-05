using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Runtime.InteropServices;

namespace lmitp
{
    public partial class departement : Form
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
        public departement()
        {
            InitializeComponent();
        }
        bool check = false;
        int inde = -1, Idepm;
        String N;
        private void dgvdep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            inde = this.dgvdep.CurrentRow.Index;
            Idepm = int.Parse(this.dgvdep.Rows[inde].Cells[0].Value.ToString());
            N = this.dgvdep.Rows[inde].Cells[1].Value.ToString();

            //modi

            this.inputid.Text = this.dgvdep.Rows[inde].Cells[0].Value.ToString();
            this.inputnom.Text = this.dgvdep.Rows[inde].Cells[1].Value.ToString();
          

            this.inputid.Enabled = false;
            check = true;
        }

        private void reportsform_Load(object sender, EventArgs e)
        {
            StyleDatagridview();
            btnemp_Click(sender, e);
            this.dgvdep.ReadOnly = true;
            this.dgvdep.AllowUserToAddRows = false;
            int nbrlignes = this.dgvdep.Rows.Count - 1;
            this.inputid.Text = (Convert.ToInt32(this.dgvdep.Rows[nbrlignes].Cells[0].Value.ToString()) + 1).ToString();
            this.inputnom.Focus();
            btnemp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnemp.Width, btnemp.Height, 30, 30));
            btnajouter.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnajouter.Width, btnajouter.Height, 30, 30));
            btnsup.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnsup.Width, btnsup.Height, 30, 30));
            btnmodi.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnmodi.Width, btnmodi.Height, 30, 30));
            btnNew.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnNew.Width, btnNew.Height, 30, 30));
        }

        private void btnemp_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            //cnx.ConnectionString =@"Data Source=DESKTOP-BQB1CKT\SQLEXPRESS;Initial Catalog=B1;Integrated Security=True";
            cnx.ConnectionString = connextionString;
            String req = "SELECT * FROM dept";
            SqlCommand cmd = new SqlCommand(req, cnx);
            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows == true)
            {
                this.dgvdep.Rows.Clear();
                while (rd.Read())
                {
                    this.dgvdep.Rows.Add(rd[0], rd[1]);
                }
                cnx.Close();
            }
            else
                MessageBox.Show("la table departement est vide");
        }
        void StyleDatagridview()
        {

            dgvdep.BorderStyle = BorderStyle.None;
            dgvdep.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvdep.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvdep.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgvdep.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvdep.BackgroundColor = Color.FromArgb(105, 105, 105);
            dgvdep.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dgvdep.EnableHeadersVisualStyles = false;
            dgvdep.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvdep.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dgvdep.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(177, 177, 177);
            dgvdep.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (check == true)
                    return;
                if (!CheckInfo())
                {
                    MessageBox.Show("veuillez saisie tous les informations de département");
                    return;
                }
                using (SqlConnection cnx = new SqlConnection(connextionString))
                {
                 
                   
                    String req = "INSERT INTO dept VALUES (@id,@nom)";
                    SqlCommand cmd = new SqlCommand(req, cnx);
                    cmd.Parameters.AddWithValue("@id", inputid.Text);
                    cmd.Parameters.AddWithValue("@nom", inputnom.Text);
                    if (cnx.State == ConnectionState.Open)
                        cnx.Close();
                    cnx.Open();
                    int a = cmd.ExecuteNonQuery();
                    btnemp_Click(sender, e);
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
                this.inputnom.Text.Trim().Equals(string.Empty))
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
                cmd.CommandText = "DELETE FROM dept WHERE dept_id= @id";
                cmd.Parameters.AddWithValue("@id", Idepm);
                cnx.Open();
                cmd.ExecuteNonQuery();
                this.dgvdep.Rows.RemoveAt(inde);
                MessageBox.Show("département est bien supprimé");
                cnx.Close();
            }
        }

        private void btnmodi_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("hamk Tmodifi : " + N, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
                return;//stop
            String Query = "UPDATE dept SET dept_nom = @p1  where dept_id = @p6";
            using (SqlConnection cnx = new SqlConnection(connextionString))
            {
                SqlCommand cmd = new SqlCommand(Query, cnx);
                cmd.Parameters.AddWithValue("@p1", this.inputnom.Text.Trim());
                cmd.Parameters.AddWithValue("@p6", this.inputid.Text.Trim());
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                btnemp_Click(sender, e);
                MessageBox.Show("département est bien modifié");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            check = false;
            this.inputid.Text = string.Empty;
            this.inputnom.Text = string.Empty;
          

            this.inputid.Enabled = true;

            int nbrlignes = this.dgvdep.Rows.Count - 1;
            this.inputid.Text = (Convert.ToInt32(this.dgvdep.Rows[nbrlignes].Cells[0].Value.ToString()) + 1).ToString();
            this.inputnom.Focus();
        }
    }
}
