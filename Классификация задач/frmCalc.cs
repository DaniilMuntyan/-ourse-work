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
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }
        int N;
        int[] a,ans;
        List<int> res = new List<int> { };
        private void frmCalc_Load(object sender, EventArgs e)
        {

        }

        private void frmCalc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Begin.g)
                Application.Exit();
            else
            {
                frmSearchOptKilAndSum s = new frmSearchOptKilAndSum();
                s.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSearchOptKilAndSum s = new frmSearchOptKilAndSum();
            s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            listBox1.Items.Clear();
            res.Clear();
            N = Convert.ToInt32(txtN.Text);
            dataGridView1.RowCount = 2;
            dataGridView1.ColumnCount = N;
            for (int i = 0; i < N; i++)
            {
                dataGridView1[i, 0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1[i, 0].Style.BackColor = Color.LavenderBlush;
                dataGridView1[i, 0].Style.Font = new Font("Times New Roman",24);
                dataGridView1[i, 0].Value = (i + 1) + "";
            }
            a = new int[N + 1];
            ans = new int[N + 1];
            for (int i = 1; i <= N; i++)
                a[i] = 1999999999;
            a[1] = 0;
            ans[1] = 0;
            dataGridView1[0, 1].Style.Font = new Font("Times New Roman",30);
            dataGridView1[0, 1].Value = "0";
            dataGridView1[0, 1].Style.BackColor = Color.Purple;
            dataGridView1[0, 1].Style.ForeColor = Color.White;
            for (int i = 2; i <= N; i++)
            {
                a[i] = a[i - 1] + 1;
                ans[i] = i - 1;
                dataGridView1[i - 1, 1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (i % 2 == 0 && a[i] > a[i / 2] + 1)
                {
                    a[i] = a[i / 2] + 1;
                    ans[i] = i / 2;
                }
                if (i % 3 == 0 && a[i] > a[i / 3] + 1)
                {
                    a[i] = a[i / 3] + 1;
                    ans[i] = i / 3;
                }
                dataGridView1[i - 1, 1].Value = a[i] + "";
                dataGridView1[i-1, 1].Style.Font = new Font("Times New Roman", 30);
                dataGridView1[i - 1, 1].Style.BackColor = Color.Purple;
                dataGridView1[i-1, 1].Style.ForeColor = Color.White;
            }
            dataGridView1[N - 1, 1].Style.BackColor = Color.Indigo;
            dataGridView1[N - 1, 1].Style.ForeColor = Color.White;
            int p = ans[N];
            lblAns.Text = "Найменша кількість операцій: " + a[N];
            listBox1.Items.Add("Для мінімізації операцій:");
            int r = 1;
            res.Add(N);
            res.Add(p);
            while (p != 0)
            {
                p = ans[p];
                if (p != 0)
                    res.Add(p);
            }
            if (a[N] == 0)
            {
                listBox1.Items.Add("Нічого не робимо");
            }
            else
            {
                r = 1;
                res.Reverse();
                for (int i = 1; i < res.Count; i++)
                    if (res[i] % res[i - 1] == 0)
                        if (res[i] / res[i - 1] == 2)
                        {
                            listBox1.Items.Add("Множимо " + r + " на 2 (" + r*2 + ")");
                            r *= 2;
                        }
                        else
                        {
                            listBox1.Items.Add("Множимо " + r + " на 3 (" + r*3 + ")");
                            r *= 3;
                        }
                    else
                    {
                        listBox1.Items.Add("Додаємо до " + r + " одиницю (" + (r+1) + ")");
                        r++;
                    }
                }
            dataGridView1.ClearSelection();
            }
        }
    }

