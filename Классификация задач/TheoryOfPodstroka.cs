using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Классификация_задач
{
    public partial class TheoryOfPodstroka : Form
    {
        Form frm1;
        public TheoryOfPodstroka(Form frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;
        }

        private void TheoryOfPodstroka_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText("Теорія та код підрядок.txt");
        }

        private void TheoryOfPodstroka_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
