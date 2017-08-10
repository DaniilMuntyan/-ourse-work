using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Классификация_задач
{
    public partial class Mer1 : Form
    {
        Form1 frm1;
        public Mer1(Form1 frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;
        }

        int N;
        List <int> g;
        private void combo1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Mer1_Load(object sender, EventArgs e)
        {
        }
        private void exit2_Click(object sender, EventArgs e)
        {
            frm1.Show();
            this.Hide();
        }

        private void Mer1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblAns.Text = "Числа:";

            try {
                int i;
                N = Convert.ToInt32(txtN.Text);
                int[] f = new int[N + 1];
                if (radioButton1.Checked)
                {
                    f[1] = 1;
                    f[2] = 1;
                    lblAns.Text += " 1 1 ";
                    for (i = 3; i <= N; i++)
                    {
                        f[i] = f[i - 1] + f[i - 2];
                        lblAns.Text += f[i] + " ";
                    }
                }
                if (radioButton2.Checked)
                {
                    f[1] = 1;
                    for (i = 1; i < N - 1; i++)
                    {
                        f[i + 1] += f[i];
                        f[i + 2] += f[i];
                        lblAns.Text += " " + f[i];
                    }
                    lblAns.Text += " " + f[N - 1] + " " + (f[N - 1] + f[N - 2]);
                }
                if (radioButton3.Checked)
                    for (i = 1; i <= N; i++)
                        lblAns.Text += " " + get_fib(i);
            
            }catch
            {
                MessageBox.Show("Ви ввели не коректне N", "Помилка");
            }
        }
        int get_fib(int i)
        {
            if(i <= 2)
                return 1;
            else
                return get_fib(i - 1) + get_fib(i - 2);
            
        }
        

        private void Mer1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //OnFormClosing(e);
            this.Hide();
            frm1.Show();
            e.Cancel = true;
        }
        
    }
}
