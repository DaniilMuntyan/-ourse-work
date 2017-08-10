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
    public partial class Theory : Form
    {
        public Theory()
        {
            InitializeComponent();
        }
        private void Theory_Load(object sender, EventArgs e)
        {

        }

        private void Theory_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            frmMenu m = new frmMenu();
            m.Show();
            this.Hide();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string s = treeView1.SelectedNode.Name;
            richTextBox1.LoadFile("Теория\\" + s + ".rtf");
        }
    }
}
