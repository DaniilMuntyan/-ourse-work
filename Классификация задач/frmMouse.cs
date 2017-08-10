using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Классификация_задач
{
    public partial class frmMouse : Form
    {
        public frmMouse()
        {
            InitializeComponent();
        }
        bool end = false;
        Regex rxNums = new Regex(@"^\d+$"); //Создаем регулярные выражения
        int N,M;
        bool check = false;
        int x = 1, y = 1, count = 0, sum = 0,count1=0;
        List<char> ans = new List<char> { };
        int[,] a, d, g;

        private void radioButton1_Click(object sender, EventArgs e)
        {
            end = false;
            button1.Enabled = true;
            button3.Enabled = true;
            for (int i = 1; i <= N; i++)
                for (int j = 1; j <= M; j++)
                {
                    dataGridView1[j, i].Style.BackColor = Color.White;
                    dataGridView1[j, i].Style.ForeColor = Color.Black;
                    dataGridView1[j, i].Value = "" + a[i, j];

                }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            end = false;
            sum = 0;
            count = 0;
            button1.Enabled = false;
            button3.Enabled = false;
            x = N; y = 1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ans.Count == 0)
            {
                lblAns.Text = "Оптимальна сума: " + a[x, y];
                dataGridView1[y, x].Style.BackColor = Color.Violet;
                dataGridView1[y, x].Style.ForeColor = Color.Snow;
                dataGridView1[y, x].Value = "⭙";
                timer1.Stop();
            }
            else
            {
                dataGridView1[y, x].Style.BackColor = Color.DarkOrange;
                dataGridView1[y, x].Style.ForeColor = Color.Snow;
                lblNumbers.Location = new Point(260, 494);
                lblNumbers.Visible = true;
                timer2.Start();
                sum += a[x, y];
                if (ans[count] == 'F')
                {
                    dataGridView1[y, x].Value = "↑";
                    x--;
                }
                else
                {
                    dataGridView1[y, x].Value = "→";
                    y++;
                }
                count++;
                if (count == ans.Count)
                {
                    dataGridView1[y, x].Style.BackColor = Color.Violet;
                    dataGridView1[y, x].Style.ForeColor = Color.Snow;
                    dataGridView1[y, x].Value = "⭙";
                    lblAns.Text = "Оптимальна сума: " + sum;
                    sum += a[x, y];
                    lblNumbers.Location = new Point(261, 494);
                    lblNumbers.Visible = true;
                    timer2.Start();
                    end = true;
                    timer1.Stop();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblNumbers.Text = a[x, y] + "";
            lblAns.Text = "Оптимальна сума: " + sum;
            lblNumbers.Location = new Point(lblNumbers.Location.X, lblNumbers.Location.Y + 3);
            if (lblNumbers.Location.Y > lblAns.Location.Y)
            {
                if(end)
                {
                    timer1.Stop();
                    timer2.Stop();
                }
                lblNumbers.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ans.Clear();
            Random z = new Random();
            radioButton2.Enabled = true;
            N = Convert.ToInt32(textBox1.Text);
            M = Convert.ToInt32(textBox2.Text);
            dataGridView2.RowCount = N + 1;
            dataGridView2.ColumnCount = M + 1;
            dataGridView1.RowCount = N + 1;
            dataGridView1.ColumnCount = M + 1;
            N++; M++;
            a = new int[N, M];
            d = new int[N, M];
            h = new char[N, M];
            g = new int[N, M];
            N--; M--;
            for (int i = 1; i <= N; i++)
            {
                dataGridView1[0, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1[0, i].Style.BackColor = Color.LightCyan;
                dataGridView1[0, i].Style.Font = new Font("Timew New Roman", 20);
                dataGridView1[0, i].Value = i + "";
                dataGridView2[0, i].Style.BackColor = Color.LightCyan;
                dataGridView2[0, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView2[0, i].Style.Font = new Font("Timew New Roman", 20);
                dataGridView2[0, i].Value = i + "";
            }
            for (int i = 1; i <= M; i++)
            {
                dataGridView1[i, 0].Style.BackColor = Color.LightCyan;
                dataGridView1[i, 0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1[i, 0].Style.Font = new Font("Timew New Roman", 20);
                dataGridView1[i, 0].Value = i + "";
                dataGridView2[i, 0].Style.BackColor = Color.LightCyan;
                dataGridView2[i, 0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView2[i, 0].Style.Font = new Font("Timew New Roman", 20);
                dataGridView2[i, 0].Value = i + "";
            }
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= M; j++)
                {
                    dataGridView1[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView2[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1[j, i].Style.Font = new Font("Times New Roman", 23);
                    a[i, j] = z.Next(0,80);
                    dataGridView1[j, i].Value = "" + a[i, j];
                }
            }
            for (int i = 1; i <= N; i++)
                for (int j = 1; j <= M; j++)
                    g[N - i + 1, j] = a[i, j];

            int sum1 = 0, sum2 = 0;
            for (int i = 1; i <= N; i++)
            {
                sum1 += g[i, 1];
                d[i, 1] = sum1;
            }
            for (int j = 1; j <= M; j++)
            {
                sum2 += g[1, j];
                d[1, j] = sum2;
            }
            for (int i = 2; i <= N; i++)
                for (int j = 2; j <= M; j++)
                    d[i, j] = Math.Max(d[i, j - 1], d[i - 1, j]) + g[i, j];
            for (int i = 1; i <= N; i++)
                for (int j = 1; j <= M; j++)
                {
                    dataGridView2[j, N-i + 1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView2[j, N-i + 1].Style.Font = dataGridView1[j, i].Style.Font;
                    dataGridView2[j, N-i + 1].Value = d[i, j] + "";
                }
            for (int i = 1; i <= M; i++)
                d[0, i] = -1;
            for (int i = 1; i <= N; i++)
                d[i, 0] = -1;
            x = N; //i
            y = M; //j
            while (x >= 1 && y >= 1)
            {
                if (x == 1 && y == 1)
                    break;
                if (d[x - 1, y] > d[x, y - 1])
                {
                    ans.Add('F');
                    x--;
                }
                else
                {
                    ans.Add('R');
                    y--;
                }
            }
            ans.Reverse();

            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }

        char[,] h;

        private void frmMouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Begin.g)
                Application.Exit();
            else
            {
                frmWaySearch w = new frmWaySearch();
                w.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmWaySearch w = new frmWaySearch();
            w.Show();
            this.Hide();
        }

        private void frmMouse_Load(object sender, EventArgs e)
        {
            N = Convert.ToInt32(textBox1.Text);
            M = Convert.ToInt32(textBox2.Text);
            dataGridView2.RowCount = N + 1;
            dataGridView2.ColumnCount = M + 1;
            dataGridView1.RowCount = N + 1;
            dataGridView1.ColumnCount = M + 1;
            for (int i = 1; i <= N; i++)
            {
                dataGridView1[0, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1[0, i].Style.BackColor = Color.LightCyan;
                dataGridView1[0, i].Style.Font = new Font("Timew New Roman", 20);
                dataGridView1[0, i].Value = i + "";
                dataGridView2[0, i].Style.BackColor = Color.LightCyan;
                dataGridView2[0, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView2[0, i].Style.Font = new Font("Timew New Roman", 20);
                dataGridView2[0, i].Value = i + "";
            }
            for (int i = 1; i <= M; i++)
            {
                dataGridView1[i, 0].Style.BackColor = Color.LightCyan;
                dataGridView1[i, 0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1[i, 0].Style.Font = new Font("Timew New Roman", 20);
                dataGridView1[i, 0].Value = i + "";
                dataGridView2[i, 0].Style.BackColor = Color.LightCyan;
                dataGridView2[i, 0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView2[i, 0].Style.Font = new Font("Timew New Roman", 20);
                dataGridView2[i, 0].Value = i + "";
            }
            for(int i = 1; i <= N; i++)
            {
                for(int j = 1; j <= M; j++)
                {
                    dataGridView1[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView2[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1[j, i].Style.Font = new Font("Times New Roman",23);
                }
            }
            dataGridView1[1, 1].Value = "3";
            dataGridView1[2, 1].Value = "2";
            dataGridView1[3, 1].Value = "4";
            dataGridView1[1, 2].Value = "1";
            dataGridView1[2, 2].Value = "5";
            dataGridView1[3, 2].Value = "1";
            /*
            dataGridView1[1, 1].Value = "9";
            dataGridView1[2, 1].Value = "4";
            dataGridView1[3, 1].Value = "3";
            dataGridView1[1, 2].Value = "2";
            dataGridView1[2, 2].Value = "1";
            dataGridView1[3, 2].Value = "6";
            dataGridView1[1, 3].Value = "0";
            dataGridView1[2, 3].Value = "9";
            dataGridView1[3, 3].Value = "1";*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ans.Clear();
            radioButton2.Enabled = true;
            N = Convert.ToInt32(textBox1.Text);
            M = Convert.ToInt32(textBox2.Text);
            dataGridView2.RowCount = N + 1;
            dataGridView2.ColumnCount = M + 1;
            dataGridView1.RowCount = N + 1;
            dataGridView1.ColumnCount = M + 1;
            N++;M++;
            a = new int[N, M];
            d = new int[N, M];
            h = new char[N, M];
            g = new int[N, M];
            N--;M--;
            for (int i = 1; i <= N; i++)
            {
                dataGridView1[0, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1[0, i].Style.BackColor = Color.LightCyan;
                dataGridView1[0, i].Style.Font = new Font("Timew New Roman", 20);
                dataGridView1[0, i].Value = i + "";
                dataGridView2[0, i].Style.BackColor = Color.LightCyan;
                dataGridView2[0, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView2[0, i].Style.Font = new Font("Timew New Roman", 20);
                dataGridView2[0, i].Value = i + "";
            }
            for(int i = 1; i <= M; i++)
            {
                dataGridView1[i, 0].Style.BackColor = Color.LightCyan;
                dataGridView1[i, 0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1[i, 0].Style.Font = new Font("Timew New Roman", 20);
                dataGridView1[i, 0].Value = i + "";
                dataGridView2[i, 0].Style.BackColor = Color.LightCyan;
                dataGridView2[i, 0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView2[i, 0].Style.Font = new Font("Timew New Roman", 20);
                dataGridView2[i, 0].Value = i + "";
            }
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= M; j++)
                {
                    dataGridView1[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView2[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1[j, i].Style.Font = new Font("Times New Roman", 23);
                    if (dataGridView1[j, i].Value != null)
                        a[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);
                    else
                    {
                        dataGridView1[j, i].Value = "0";
                        a[i, j] = 0;
                    }
                }
            }
            for(int i = 1; i <= N;i++)
                for(int j = 1; j<= M;j++)
                    g[N - i + 1, j] = a[i, j];

            int sum1 = 0, sum2 = 0;
            for(int i = 1; i <= N; i++)
            {
                sum1 += g[i, 1];
                d[i, 1] = sum1;
            }
            for(int j = 1; j <= M; j++)
            {
                sum2 += g[1, j];
                d[1, j] = sum2;
            }
            for(int i = 2; i <= N;i++)
                for (int j = 2; j <= M; j++)
                    d[i, j] = Math.Max(d[i,j-1],d[i-1,j]) + g[i,j];
            for (int i = 1; i <= N; i++)
                for (int j = 1; j <= M; j++)
                {
                    dataGridView2[j, N - i + 1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView2[j, N - i + 1].Style.Font = dataGridView1[j, i].Style.Font;
                    dataGridView2[j, N - i + 1].Value = d[i, j] + "";
                }


            for (int i = 1; i <= M; i++)
                d[0, i] = -1;
            for (int i = 1; i <= N; i++)
                d[i, 0] = -1;
            x = N; //i
            y = M; //j
            while(x>=1 && y >= 1)
            {
                if (x == 1 && y == 1)
                    break;
                if(d[x-1,y] > d[x,y-1])
                {
                    ans.Add('F');
                    x--;
                }else
                {
                    ans.Add('R');
                    y--;
                }
            }
            ans.Reverse();
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }
    }
}
