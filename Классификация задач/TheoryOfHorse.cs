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
    public partial class TheoryOfHorse : Form
    {
        Form frm1;
        public TheoryOfHorse(Form frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;
        }

        private void TheoryOfHorse_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText("Теорія Хід Конем.txt");
        }

        private void TheoryOfHorse_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
