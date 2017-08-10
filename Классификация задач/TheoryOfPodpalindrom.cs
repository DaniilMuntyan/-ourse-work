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
    public partial class TheoryOfPodpalindrom : Form
    {
        Form frm1;
        public TheoryOfPodpalindrom(Form frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;
        }

        private void TheoryOfPodpalindrom_Load(object sender, EventArgs e)
        {
            string[] s = File.ReadAllLines("Теорія Найбільший підпаліндром.txt");
            bool f = false;
            foreach (string u in s)
            {
                if (!f)
                {
                    richTextBox1.Text += u;
                    f = true;
                }else
                richTextBox1.Text += "\n" + u;

            }
        }
        public bool close = false;
        private void TheoryOfPodpalindrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                frm1.Show();
                this.Hide();
                e.Cancel = true;
            }
            catch
            {
                Application.Exit();
            }
        }
    }
}
