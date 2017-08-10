using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Классификация_задач
{
    public partial class TheoryOfKnapsack : Form
    {
        Form1 frm1;
        public TheoryOfKnapsack(Form1 frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;
        }

        private void TheoryOfKnapsack_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText("Теорія Рюкзак.txt");
        }

        private void TheoryOfKnapsack_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
