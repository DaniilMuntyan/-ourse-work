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
    public partial class Begin : Form
    {
        Form1 frm1;
        public Begin()
        {
            InitializeComponent();
            frm1 = new Form1(this);
        }
       static void exitFromBegin()
        {
            Application.Exit();
        }
        private void Begin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*frm1.Show();
            this.Hide();*/
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        static public bool g = false;
        private void Begin_FormClosing(object sender, FormClosingEventArgs e)
        {
            g = true;
            Application.Exit(null);
        }

        private void Begin_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            g = true;
            Application.Exit(null);
        }

        private void label8_Click(object sender, EventArgs e)
        {

            frm1.Show();
            this.Hide();
        }
    }
}
