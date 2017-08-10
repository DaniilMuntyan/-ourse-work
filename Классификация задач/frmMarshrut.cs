using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Классификация_задач
{
    public partial class frmMarshrut : Form
    {
        public frmMarshrut()
        {
            InitializeComponent();
        }
        Regex rxNums = new Regex(@"^\d+$"); //Создаем регулярные выражения
        int N;
        bool check = false;
        int x = 1, y = 1,count=0,sum=0;
        int[,] a,d;
        char[,] h;

        private void frmMarshrut_Load(object sender, EventArgs e)
        {
            N = Convert.ToInt32(textBox1.Text);
            dataGridView2.RowCount = N + 1;
            dataGridView2.ColumnCount = N + 1;
            dataGridView1.RowCount = N + 1;
            dataGridView1.ColumnCount = N + 1;
            for (int i = 1; i <= N; i++)
            {
                dataGridView1[i, 0].Style.BackColor = Color.LightCyan;
                dataGridView1[i, 0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1[i, 0].Style.Font = new Font("Timew New Roman", 20);
                dataGridView1[i, 0].Value = i + "";
                dataGridView1[0, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1[0, i].Style.BackColor = Color.LightCyan;
                dataGridView1[0, i].Style.Font = new Font("Timew New Roman", 20);
                dataGridView1[0, i].Value = i + "";

                dataGridView2[i, 0].Style.BackColor = Color.LightCyan;
                dataGridView2[0, i].Style.BackColor = Color.LightCyan;
                dataGridView2[i, 0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView2[i, 0].Style.Font = new Font("Timew New Roman", 20);
                dataGridView2[i, 0].Value = i + "";
                dataGridView2[0, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView2[0, i].Style.Font = new Font("Timew New Roman", 20);
                dataGridView2[0, i].Value = i + "";
            }
            
            dataGridView1[1, 1].Value = "9";
            dataGridView1[2, 1].Value = "4";
            dataGridView1[3, 1].Value = "3";
            dataGridView1[1, 2].Value = "2";
            dataGridView1[2, 2].Value = "1";
            dataGridView1[3, 2].Value = "6";
            dataGridView1[1,3].Value = "0";
            dataGridView1[2, 3].Value = "9";
            dataGridView1[3, 3].Value = "1";
            
        }

        private void frmMarshrut_FormClosing(object sender, FormClosingEventArgs e)
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

        private void radioButton1_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button3.Enabled = true;
            for (int i = 1; i <= N; i++)
                for (int j = 1; j <= N; j++)
                {
                    dataGridView1[j, i].Style.BackColor = Color.White;
                    dataGridView1[j, i].Style.ForeColor = Color.Black;
                    dataGridView1[j, i].Value = "" + a[i, j];

                }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            /*  for(int i = 1; i <= N; i++)
              {
                  for(int j = 1; j <= N; j++)
                  {
                      if (h[i, j] == '#')
                          dataGridView1[j, i].Value = "*";
                  }
              }*/
            sum = 0;
            count = 0;
            button1.Enabled = false;
            button3.Enabled = false;
            x = 1; y = 1;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmWaySearch sW = new frmWaySearch();
            sW.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random z = new Random();
            radioButton2.Enabled = true;
            radioButton2.Enabled = true;
            N = Convert.ToInt32(textBox1.Text);
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView2.RowCount = N + 1;
            dataGridView2.ColumnCount = N + 1;
            dataGridView1.RowCount = N + 1;
            dataGridView1.ColumnCount = N + 1;
            N++;
            a = new int[N, N];
            d = new int[N, N];
            h = new char[N, N];
            N--;
            for (int i = 1; i <= N; i++)
            {
                dataGridView1[i, 0].Style.BackColor = Color.LightCyan;
                dataGridView1[i, 0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1[i, 0].Style.Font = new Font("Timew New Roman", 20);
                dataGridView1[i, 0].Value = i + "";
                dataGridView1[0, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1[0, i].Style.BackColor = Color.LightCyan;
                dataGridView1[0, i].Style.Font = new Font("Timew New Roman", 20);
                dataGridView1[0, i].Value = i + "";

                dataGridView2[i, 0].Style.BackColor = Color.LightCyan;
                dataGridView2[0, i].Style.BackColor = Color.LightCyan;
                dataGridView2[i, 0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView2[i, 0].Style.Font = new Font("Timew New Roman", 20);
                dataGridView2[i, 0].Value = i + "";
                dataGridView2[0, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView2[0, i].Style.Font = new Font("Timew New Roman", 20);
                dataGridView2[0, i].Value = i + "";
            }
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    dataGridView1[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView2[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    a[i, j] = z.Next(0,60);
                    dataGridView1[j, i].Value = "" + a[i, j];
                }
            }
            int sum1 = 0, sum2 = 0;
            for (int i = 1; i <= N; i++)
            {
                sum1 += a[i, 1];
                sum2 += a[1, i];
                d[i, 1] = sum1;
                d[1, i] = sum2;
            }
            for (int i = 2; i <= N; i++)
                for (int j = 2; j <= N; j++)
                    d[i, j] = Math.Min(d[i - 1, j], d[i, j - 1]) + a[i, j];
            int x = N, y = N;
            while (true)
            {
                h[x, y] = '#';
                if (x == 1 && y == 1)
                    break;
                if (x == 1)
                {
                    y--;
                    continue;
                }
                if (y == 1)
                {
                    x--;
                    continue;
                }
                if (d[x - 1, y] <= d[x, y - 1])
                    x--;
                else
                    y--;

            }
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    dataGridView2[j, i].Value = d[i, j] + "";
                }
            }
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridView1[y, x].Style.BackColor = Color.DarkOrange;
            dataGridView1[y, x].Style.ForeColor = Color.Snow;
            if (x == N || y == N)
                if (x == N)
                {
                    // listBox1.Items.Add(x + " " + y + " → (x==N)");
                    dataGridView1[y, x].Value = "→";
                    //279, 466
                    lblNumbers.Location = new Point(279, 466);
                    lblNumbers.Visible = true;
                    sum += a[x, y];
                    timer2.Start();
                    y++;
                }
                else
                {
                    if (y == N)
                    {
                        // listBox1.Items.Add(x + " " + y + " ↓(y==N)");
                        dataGridView1[y, x].Value = "↓";
                        lblNumbers.Location = new Point(279, 466);
                        lblNumbers.Visible = true;
                        sum += a[x, y];
                        timer2.Start();
                        x++;
                    }
                }
            else
            {
                if (h[x + 1, y] == '#' && x < N)
                {
                    // listBox1.Items.Add(x + " " + y + " ↓(#)");
                    dataGridView1[y, x].Value = "↓";
                    lblNumbers.Location = new Point(279, 466);
                    lblNumbers.Visible = true;
                    sum += a[x, y];
                    timer2.Start();
                    x++;
                }
                else
                  if (y < N)
                {
                    // listBox1.Items.Add(x + " " + y + " →(#)");
                    dataGridView1[y, x].Value = "→";
                    lblNumbers.Location = new Point(279, 466);
                    lblNumbers.Visible = true;
                    sum += a[x, y];
                    timer2.Start();
                    y++;
                }
            }
            if (x == N && y == N)
            {
                dataGridView1[y, x].Style.BackColor = Color.Violet;
                dataGridView1[y, x].Style.ForeColor = Color.Snow;
                dataGridView1[y, x].Value = "⭙";
                check = true;
                sum += a[x, y];
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //if (check) {
            //    check = false;
            //    lblNumbers.Visible = false;
            //    timer2.Stop();
            //}
            count++;
            lblNumbers.Text = a[x,y] + "";
            
           lblNumbers.Location = new Point(lblNumbers.Location.X, lblNumbers.Location.Y + 3);
            lblAns.Text = "Оптимальна сума: " + sum;
            if (lblNumbers.Location.Y > lblAns.Location.Y)
            {
                lblNumbers.Visible = false;
                timer2.Stop();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            radioButton2.Enabled = true;
            N = Convert.ToInt32(textBox1.Text);
            dataGridView2.RowCount = N + 1;
            dataGridView2.ColumnCount = N + 1;
            dataGridView1.RowCount = N + 1;
            dataGridView1.ColumnCount = N + 1;
            N++;
            a = new int[N, N];
            d = new int[N, N];
            h = new char[N, N];
            N--;
            for (int i = 1; i <= N; i++)
            {
                dataGridView1[i, 0].Style.BackColor = Color.LightCyan;
                dataGridView1[i, 0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1[i, 0].Style.Font = new Font("Timew New Roman", 20);
                dataGridView1[i, 0].Value = i + "";
                dataGridView1[0, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1[0, i].Style.BackColor = Color.LightCyan;
                dataGridView1[0, i].Style.Font = new Font("Timew New Roman", 20);
                dataGridView1[0, i].Value = i + "";

                dataGridView2[i, 0].Style.BackColor = Color.LightCyan;
                dataGridView2[0, i].Style.BackColor = Color.LightCyan;
                dataGridView2[i, 0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView2[i, 0].Style.Font = new Font("Timew New Roman", 20);
                dataGridView2[i, 0].Value = i + "";
                dataGridView2[0, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView2[0, i].Style.Font = new Font("Timew New Roman", 20);
                dataGridView2[0, i].Value = i + "";
            }
            for (int i = 1; i <= N; i++)
            {
                for(int j = 1; j <= N; j++)
                {
                    dataGridView1[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView2[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    if (dataGridView1[j, i].Value != null)
                        a[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);
                    else
                    {
                        dataGridView1[j, i].Value = "0";
                        a[i, j] = 0;
                    }
                }
            }
            int sum1 = 0, sum2 = 0;
            for(int i = 1; i<= N; i++)
            {
                sum1 += a[i, 1];
                sum2 += a[1, i];
                d[i, 1] = sum1;
                d[1, i] = sum2;
            }
            for (int i = 2; i <= N; i++)
                for (int j = 2; j <= N; j++)
                    d[i, j] = Math.Min(d[i-1,j],d[i,j-1]) + a[i,j];
            int x = N, y = N;
            while(true)
            {
                h[x, y] = '#';
                if (x == 1 && y == 1)
                    break;
                if(x==1)
                {
                    y--;
                    continue;
                }
                if(y == 1)
                {
                    x--;
                    continue;
                }
                if (d[x - 1, y] <= d[x, y - 1])
                    x--;
                else
                    y--;

            }
            for(int i = 1; i <= N; i++)
            {
                for(int j = 1; j <= N; j++)
                {
                    dataGridView2[j, i].Value = d[i, j] + "";
                }
            }
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        } //"Власноруч"
    }
}
