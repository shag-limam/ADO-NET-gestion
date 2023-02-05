using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lmitp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void btndashbaord_Click(object sender, EventArgs e)
        {
            loadform(new tab_de_bord());
        }

        private void btnemp_Click(object sender, EventArgs e)
        {
            loadform(new employeeform());
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            loadform(new departement());
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelside_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
