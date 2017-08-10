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
    public partial class TheoryPodPosl : Form
    {
        Form1 frm1;
        public TheoryPodPosl(Form1 frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;
        }

        private void TheoryPodPosl_Load(object sender, EventArgs e)
        {

        }

        private void TheoryPodPosl_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frm1.Show();
            e.Cancel = true;
        }
    }
}
