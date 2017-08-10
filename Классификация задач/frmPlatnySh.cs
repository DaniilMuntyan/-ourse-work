using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Классификация_задач
{
    public partial class frmPlatnySh : Form
    {
        public frmPlatnySh()
        {
            InitializeComponent();
        }
        int[] d,a, p;
        bool f = false;
        int N,i,j;
        int count = 0;
        int check = 0;
        List<int> ans = new List<int>();
        Regex rxNums = new Regex(@"^\d+$"); //Создаем регулярные выражения

        private void frmPlatnySh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Begin.g)
                Application.Exit(null);
            else
            {
                button2_Click(new object(), new EventArgs());
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSearchOptKilAndSum OptKS = new frmSearchOptKilAndSum();
            OptKS.Show();
            this.Hide();
        }


        private void button3_Click(object sender, EventArgs e)// "Ввести випадково"
        {
            radioButton1.Checked = true;
            Random z = new Random();
            radioButton2.Enabled = true;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            N = Convert.ToInt32(txtN.Text);
            p = new int[N];
            a = new int[N];
            d = new int[N];
            dataGridView2.RowCount = 1;
            dataGridView2.ColumnCount = N;
            dataGridView1.RowCount = N + 1;
            dataGridView1.ColumnCount = N + 1;
            for (int i = 1; i <= N; i++)
            {
                dataGridView1.Rows[N - i + 1].Cells[i].Value = z.Next(100);
                a[i - 1] = Convert.ToInt32(dataGridView1.Rows[N - i + 1].Cells[i].Value);
                dataGridView1.Rows[N - i + 1].Cells[i].Style.Font = new Font("Times New Roman", 28);
                dataGridView1.Rows[N - i + 1].Cells[i].Style.ForeColor = Color.White;
                for (int j = i; j <= N; j++)
                    dataGridView1.Rows[N - i + 1].Cells[j].Style.BackColor = Color.DarkCyan;

            }
            for (int i = 0; i < N; i++)
            {
                dataGridView2[i, 0].Style.Font = new Font("Times New Roman", 32);
                dataGridView2[i, 0].Style.BackColor = Color.AliceBlue;
                dataGridView2[i, 0].Style.ForeColor = Color.Black;
            }
            if (N != 1)
            {
                d[0] = a[0];
                d[1] = a[1];
                p[1] = 0;
                p[0] = 0;
                dataGridView2[0, 0].Value = d[0] + "";
                dataGridView2[1, 0].Value = d[1] + "";
                dataGridView2.Height = dataGridView2.Rows[0].Height;
                for (int i = 2; i < N; i++)
                {
                    d[i] = Math.Min(d[i - 1], d[i - 2]) + a[i];
                    dataGridView2[i, 0].Value = d[i] + "";

                    if (d[i] == d[i - 1] + a[i])
                        p[i] = i;
                    else
                        p[i] = i - 1;
                }
            }
            else
            {
                d[0] = a[0];
                lblAns.Text = "Відповідь: " + d[N - 1];
                p[0] = 0;
                dataGridView2[0, 0].Value = d[0] + "";
                dataGridView2.Height = dataGridView2.Rows[0].Height;
            }
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();

        }

       

        private void button1_Click(object sender, EventArgs e) //"Ввести власноруч"
        {
            radioButton1.Checked = true;
            radioButton2.Enabled = true;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            N = Convert.ToInt32(txtN.Text);
            p = new int[N];
            a = new int[N];
            d = new int[N];
            dataGridView2.RowCount = 1;
            dataGridView2.ColumnCount = N;
            dataGridView1.RowCount = N+1;
            dataGridView1.ColumnCount = N + 1;
            for (int i = 1; i <= N; i++)
            {
                dataGridView1.Rows[N-i+1].Cells[i].Value = Microsoft.VisualBasic.Interaction.InputBox("Введіть " + (i) + "-й елемент");
                if (!rxNums.IsMatch(dataGridView1.Rows[N - i + 1].Cells[i].Value + ""))
                {
                    a[i-1] = 0;
                    dataGridView1.Rows[N - i + 1].Cells[i].Value = "0";
                }
                else
                    a[i-1] = Convert.ToInt32(dataGridView1.Rows[N - i + 1].Cells[i].Value);
                dataGridView1.Rows[N - i + 1].Cells[i].Style.Font = new Font("Times New Roman", 28);
                dataGridView1.Rows[N - i + 1].Cells[i].Style.ForeColor = Color.White;
                dataGridView1[i, N - i + 1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                for (int j = i; j<= N; j++)
                    dataGridView1.Rows[N - i + 1].Cells[j].Style.BackColor = Color.DarkCyan;

            }
            for (int i = 0; i < N; i++)
            {
                dataGridView2[i, 0].Style.Font = new Font("Times New Roman", 32);
                dataGridView2[i, 0].Style.BackColor = Color.AliceBlue;
                dataGridView2[i, 0].Style.ForeColor = Color.Black;
                dataGridView2[i, 0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (N != 1)
            {
                d[0] = a[0];
                d[1] = a[1];
                p[0] = 0;
                p[1] = 0;
                dataGridView2[0, 0].Value = d[0] + "";
                dataGridView2[1, 0].Value = d[1] + "";
                dataGridView2.Height = dataGridView2.Rows[0].Height;
                for (int i = 2; i < N; i++)
                {
                    d[i] = Math.Min(d[i - 1], d[i - 2]) + a[i];
                    dataGridView2[i, 0].Value = d[i] + "";
                    if (d[i] == d[i - 1] + a[i])
                        p[i] = i;
                    else
                        p[i] = i - 1;
                }
            }
            else
            {
                    d[0] = a[0];
                    lblAns.Text = "Відповідь: " + d[N - 1];
                    p[0] = 0;
                    dataGridView2[0, 0].Value = d[0] + "";
                    dataGridView2.Height = dataGridView2.Rows[0].Height;
                
            }
            lblAns.Text = "Відповідь: " + d[N-1];
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            int j = N;
            for (int i = 0; i <= N; i++, j--)
            {
                dataGridView1[j, i].Value = "";
            }
        }
        private void radioButton2_Click(object sender, EventArgs e)
        {
                // "☺" "☹"
                int k = p[N - 1];
                ans.Add(k);
                while (k != 0)
                {
                    k = p[k - 1];
                    ans.Add(k);
                }
                ans.Reverse();
                i = N;
                j = 0;
                f = false;
                count = 0;
                timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
                count++;
                j = ans[count - 1];
                i = N - j;
                dataGridView1[j, i].Value = "↓";
                dataGridView1[j, i].Style.Font = new Font("Times New Roman", 28);

            if (count == ans.Count)
            {
                dataGridView1[N, 0].Value = "☺";
                dataGridView1[N, 0].Style.Font = new Font("Times New Roman", 28);
                ans.Clear();
                timer1.Stop();
            }

        }
    }
}
