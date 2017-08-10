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
    public partial class TheoryOfKvitki : Form
    {
        Form1 frm1;
        public TheoryOfKvitki(Form1 frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;
        }

        private void TheoryOfKvitki_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText("Теорія Квитки.txt");
        }

        private void TheoryOfKvitki_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
