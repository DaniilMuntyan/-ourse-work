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
    public partial class frmSearchOptKilAndSum : Form
    {
        public frmSearchOptKilAndSum()
        {
            InitializeComponent();
        }
        #region LabelsAndLoad
        private void frmSearchOptKilAndSum_Load(object sender, EventArgs e)
        {

        }

        private void lblTrian_MouseEnter(object sender, EventArgs e)
        {
            lblTri1.Visible = true;
        }
        
        private void lblTri1_MouseLeave(object sender, EventArgs e)
        {
            lblTri1.Visible = false;
        }
        
        private void lblKvitki1_MouseLeave(object sender, EventArgs e)
        {
            lblKvitki1.Visible = false;
        }

        private void lblKvitki_MouseEnter(object sender, EventArgs e)
        {
            lblKvitki1.Visible = true;
        }

        private void lblPodpalindrom_MouseEnter(object sender, EventArgs e)
        {
            lblPodpalindrom1.Visible = true;
        }

        private void lblPodpalindrom1_MouseLeave(object sender, EventArgs e)
        {
            lblPodpalindrom1.Visible = false;
        }

        private void lblPlSh1_MouseLeave(object sender, EventArgs e)
        {
            lblPlSh1.Visible = false;
        }

        private void lblPlSh_MouseEnter(object sender, EventArgs e)
        {

            lblPlSh1.Visible = true;
        }

        private void lblPodstroka_MouseEnter(object sender, EventArgs e)
        {
            lblPodstroka1.Visible = true;
        }

        private void lblPodstroka1_MouseLeave(object sender, EventArgs e)
        {
            lblPodstroka1.Visible = false;
        }

        private void lblMaxPodposl_MouseEnter(object sender, EventArgs e)
        {
            lblMaxPodposl1.Visible = true;
        }

        private void lblMaxPodposl1_MouseLeave(object sender, EventArgs e)
        {
            lblMaxPodposl1.Visible = false;
        }

        private void lblKnapsack_MouseEnter(object sender, EventArgs e)
        {
            lblKnapsack1.Visible = true;
        }

        private void lblKnapsack1_MouseLeave(object sender, EventArgs e)
        {
            lblKnapsack1.Visible = false;
        }

        private void lblCalc_MouseEnter(object sender, EventArgs e)
        {
            lblCalc1.Visible = true;
        }

        private void lblCalc1_MouseLeave(object sender, EventArgs e)
        {
            lblCalc1.Visible = false;
        }
        #endregion
        private void lblTrian_Click(object sender, EventArgs e)
        {

        }

        private void lblPlSh_Click(object sender, EventArgs e)
        {

        }

        private void lblKvitki_Click(object sender, EventArgs e)
        {

        }

        private void lblPodpalindrom_Click(object sender, EventArgs e)
        {

        }

        private void lblPodstroka_Click(object sender, EventArgs e)
        {

        }

        private void lblMaxPodposl_Click(object sender, EventArgs e)
        {

        }

        private void lblKnapsack_Click(object sender, EventArgs e)
        {

        }

        private void lblCalc_Click(object sender, EventArgs e)
        {

        }
        private void lblTri1_Click(object sender, EventArgs e)
        {
            frmTri tri = new frmTri();
            tri.Show();
            this.Hide();
        }
        public void frmSearchOptKilAndSum_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Begin.g)
            {
                this.Hide();
                Application.Exit(null);
            }
            else
            {
                frmMenu menu = new frmMenu();
                menu.Show();
                this.Hide();
            }

        }

        private void lblPlSh1_Click(object sender, EventArgs e)
        {
            frmPlatnySh plsh = new frmPlatnySh();
            plsh.Show();
            this.Hide();
        }

        private void lblKvitki1_Click(object sender, EventArgs e)
        {
            frmKvitki kv = new frmKvitki();
            kv.Show();
            this.Hide();
        }

        private void lblPodstroka1_Click(object sender, EventArgs e)
        {
            frmMaxPodstroka newF = new frmMaxPodstroka();
            newF.Show();
            this.Hide();
        }

        private void lblPodpalindrom1_Click(object sender, EventArgs e)
        {
            frmMaxPodpalindrom max = new frmMaxPodpalindrom();
            max.Show();
            this.Hide();
        }

        private void lblMaxPodposl1_Click(object sender, EventArgs e)
        {
            frmPodposl p = new frmPodposl();
            p.Show();
            this.Hide();
        }

        private void lblKnapsack1_Click(object sender, EventArgs e)
        {
            frmKnapsack kn = new frmKnapsack();
            kn.Show();
            this.Hide();
        }

        private void lblCalc1_Click(object sender, EventArgs e)
        {
            frmCalc calc = new frmCalc();
            calc.Show();
            this.Hide();
        }
    }
}
