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
    public partial class CodeOfPodPosl : Form
    {
        Form1 frn1;
        public CodeOfPodPosl(Form1 frm1)
        {
            InitializeComponent();
            this.frn1 = frm1;
        }

        private void CodeOfPodPosl_Load(object sender, EventArgs e)
        {

        }

        private void CodeOfPodPosl_FormClosing(object sender, FormClosingEventArgs e)
        {
            frn1.Show();
            this.Hide();
            e.Cancel = true;
        }
    }
}
