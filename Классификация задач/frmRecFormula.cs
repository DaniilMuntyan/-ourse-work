using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Классификация_задач
{
    public partial class frmRecFormula : Form
    {
        public frmRecFormula()
        {
            InitializeComponent();
        }

        private void frmRecFormula_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Begin.g)
                Application.Exit();
            else
            {
                frmMenu m = new frmMenu();
                m.Show();
                this.Hide();
            }
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            lblWay.Visible = true;
        }

        private void lblWay_MouseLeave(object sender, EventArgs e)
        {
            lblWay.Visible = false;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            lblHorse.Visible = true;
        }

        private void lblHorse_MouseLeave(object sender, EventArgs e)
        {
            lblHorse.Visible = false;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            lblPascal.Visible = true;
        }

        private void lblPascal_MouseLeave(object sender, EventArgs e)
        {
            lblPascal.Visible = false; 
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            lblThreeOd.Visible = true;
        }

        private void lblThreeOd_MouseLeave(object sender, EventArgs e)
        {
            lblThreeOd.Visible = false;
        }

        private void lblWay_Click(object sender, EventArgs e)
        {
            frmStrib str = new frmStrib();
            str.Show();
            this.Hide();
        }

        private void lblHorse_Click(object sender, EventArgs e)
        {
            frmHorse h = new frmHorse();
            h.Show();
            this.Hide();
        }

        private void lblPascal_Click(object sender, EventArgs e)
        {
            frmPascal p = new frmPascal();
            p.Show();
            this.Hide();
        }

        private void frmRecFormula_Load(object sender, EventArgs e)
        {

        }
    }
}
