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
    public partial class frmWaySearch : Form
    {
        public frmWaySearch()
        {
            InitializeComponent();
        }

        private void frmWaySearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Begin.g)
                Application.Exit();
            else
            {
                frmMenu frm = new frmMenu();
                frm.Show();
                this.Hide();
            }
        }

        private void lblWay_MouseEnter(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void lblWay_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmMarshrut m = new frmMarshrut();
            m.Show();
            this.Hide();
        }

        private void lblCherep_MouseEnter(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmMouse mou = new frmMouse();
            mou.Show();
            this.Hide();
        }
    }
}
