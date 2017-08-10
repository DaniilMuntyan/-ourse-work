using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Классификация_задач
{
    public partial class frmTri : Form
    {
        public frmTri()
        {
            InitializeComponent();
        }
        Regex rxNums = new Regex(@"^\d+$"); //Создаем регулярные выражения
        int  max, maxi, c;
        static int N;
        int[,] a, d;
        int[,] a1;
        bool f = false;
        List<char> L = new List<char> { };
        private void frmTri_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            txtN.Text = "5";
            N = Convert.ToInt32(txtN.Text);
            dataGridView1.ColumnCount = N * 2 - 1;
            dataGridView1.RowCount = N;
            dataGridView2.ColumnCount = N * 2 - 1;
            dataGridView2.RowCount = N;
            dataGridView1[4, 0].Value = "7";
            dataGridView1[3, 1].Value = "3";
            dataGridView1[5, 1].Value = "8";
            dataGridView1[2, 2].Value = "8";
            dataGridView1[1, 3].Value = "2";
            dataGridView1[0, 4].Value = "4";
            dataGridView1[6, 2].Value = "0";
            dataGridView1[7, 3].Value = "4";
            dataGridView1[8, 4].Value = "5";
            dataGridView1[4, 2].Value = "1";
            dataGridView1[3, 3].Value = "7";
            dataGridView1[5, 3].Value = "4";
            dataGridView1[2, 4].Value = "5";
            dataGridView1[4, 4].Value = "2";
            dataGridView1[6, 4].Value = "6";
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N * 2 - 1; j++)
                {
                    dataGridView1[j, i].Style.Font = new Font("Times New Roman", 24);
                    dataGridView2[j, i].Style.Font = dataGridView1[j, i].Style.Font;
                }
            }
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSearchOptKilAndSum OptKS = new frmSearchOptKilAndSum();
            OptKS.Show();
            this.Hide();
        }

        private void frmTri_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Begin.g)
                Application.Exit(null);
            else
            {
                button2_Click(new object(), new EventArgs());
                e.Cancel = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            k = 0;
            button1.Enabled = true;
            button3.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton1.Checked = true;
            frmTri_Load(new object(), new EventArgs());
            lblAns.Text = "Відповідь: ";
            a = new int[N + 1, N + 1];
            d = new int[N + 1, N + 1];
            int sum1 = 0, sum2 = 0;
            int y = 1, u = 0;
            string s = "";
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < 2 * N - 1; j++)
                {
                    if (dataGridView1[j, i].Value != null)
                    {
                        a[i, u] = Convert.ToInt32(dataGridView1[j, i].Value);
                        dataGridView1[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dataGridView2[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dataGridView1[j, i].Style.BackColor = panel1.BackColor;
                        dataGridView1[j, i].Style.ForeColor = Color.FloralWhite;
                        u++;
                    }
                }
                u = 0;
            }

            d[1, 1] = a[0, 0];
            for (int i = 1; i <= N; i++)
            {
                sum2 += a[i - 1, i - 1];
                sum1 += a[i - 1, 0];
                d[i, 1] = sum1;
                d[i, i] = sum2;
            }
            for (int i = 2; i <= N; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    d[i, j] = Math.Max(d[i - 1, j - 1], d[i - 1, j]) + a[i - 1, j - 1];
                }
            }
            u = 1;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < 2 * N - 1; j++)
                {
                    if (dataGridView1[j, i].Value != null)
                    {
                        dataGridView2[j, i].Value = d[i + 1, u];
                        dataGridView2[j, i].Style.BackColor = Color.DarkBlue;
                        dataGridView2[j, i].Style.ForeColor = Color.FloralWhite;
                        u++;
                    }

                }
                u = 1;
            }
            max = -1000000;
            maxi = -1;
            c = 0;
            for (int j = 0; j < 2 * N - 1; j += 2)
            {
                if (max < Convert.ToInt32(dataGridView2[j, N - 1].Value))
                {
                    max = Convert.ToInt32(dataGridView2[j, N - 1].Value);
                    maxi = c + 1;
                }
                c++;
            }
            lblAns.Text += max + "";
        }

        private void button3_Click(object sender, EventArgs e) //Click на "Ввести випадково"
        {
            k = 0;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            lblAns.Text = "Відповідь: ";
            radioButton1.Checked = true;
            Random z = new Random();
            radioButton1.Checked = true;
            N = Convert.ToInt32(txtN.Text);
            lblAns.Text = "Відповідь: ";
            #region Настраиваем datagridview

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView1.ColumnCount = N * 2 - 1;
            dataGridView1.RowCount = N;
            dataGridView2.ColumnCount = N * 2 - 1;
            dataGridView2.RowCount = N;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N * 2 - 1; j++)
                {
                    dataGridView1[j, i].Style.Font = new Font("Times New Roman", 24);
                    dataGridView2[j, i].Style.Font = dataGridView1[j, i].Style.Font;
                    dataGridView1[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView2[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    if (check(i, j))
                    {
                        dataGridView1[j, i].Value = z.Next(0,10);
                        if (!rxNums.IsMatch(dataGridView1[j, i].Value.ToString()))
                            dataGridView1[j, i].Value = "0";
                    }
                }
            }
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();

            for (int i = 0; i < N; i++) //Проверяем, есть ли пустая ячейка в треугольнике, ставим вместо нее 0
                for (int j = 0; j < 2 * N - 1; j++)
                    if (dataGridView1[j, i].Value == null && check(i, j))
                        dataGridView1[j, i].Value = "0";
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            #endregion

            a = new int[N + 1, N + 1];
            d = new int[N + 1, N + 1];
            int sum1 = 0, sum2 = 0;
            int y = 1, u = 0;
            string s = "";
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < 2 * N - 1; j++)
                {
                    if (dataGridView1[j, i].Value != null)
                    {
                        a[i, u] = Convert.ToInt32(dataGridView1[j, i].Value);
                        dataGridView1[j, i].Style.BackColor = panel1.BackColor; 
                        dataGridView1[j, i].Style.ForeColor = Color.FloralWhite;
                        u++;
                    }
                }
                u = 0;
            }

            d[1, 1] = a[0, 0];
            for (int i = 1; i <= N; i++)
            {
                sum2 += a[i - 1, i - 1];
                sum1 += a[i - 1, 0];
                d[i, 1] = sum1;
                d[i, i] = sum2;
            }
            for (int i = 2; i <= N; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    d[i, j] = Math.Max(d[i - 1, j - 1], d[i - 1, j]) + a[i - 1, j - 1];
                }
            }
            u = 1;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < 2 * N - 1; j++)
                {
                    if (dataGridView1[j, i].Value != null)
                    {
                        dataGridView2[j, i].Value = d[i + 1, u];
                        dataGridView2[j, i].Style.BackColor = Color.DarkBlue;
                        dataGridView2[j, i].Style.ForeColor = Color.FloralWhite;
                        u++;
                    }

                }
                u = 1;
            }
            max = -1000000;
            maxi = -1;
            c = 0;
            for (int j = 0; j < 2 * N - 1; j += 2)
            {
                if (max < Convert.ToInt32(dataGridView2[j, N - 1].Value))
                {
                    max = Convert.ToInt32(dataGridView2[j, N - 1].Value);
                    maxi = c + 1;
                }
                c++;
            }
            lblAns.Text += max + "";
        }
    
        bool check(int i, int j)
        {
            i++;
            j++;
            int g = N - i + 1;
            while(true)
            {
                if (g > N + i)
                    return false;
                if (g == j)
                    return true;
                g += 2;
            }
        } //Проверяет, [i][j] есть ли частью треугольника

        int count = 0;
        int j = N - 1, i = 0, sum = 0, k = 0;
        int count1 = 0, S = 0;
        private void animation()
        {
            N = Convert.ToInt32(txtN.Text);
            count = 0;
            j = N - 1;
            i = 0;
            S = 0;
            sum = 0;
            timer1.Start();
        }
        private void radioButton2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button3.Enabled = false;
            k++;
            if (k == 1)
            {
                N = Convert.ToInt32(txtN.Text);
                int[,] d1 = new int[N + 1, N * 2 + 1];
                a1 = new int[N + 1, N * 2 + 1];
                int i, j, maxi1 = 0, max1 = -100000;
                string s = "";
                for (i = 0; i < N; i++)
                {
                    for (j = 0; j < 2 * N - 1; j++)
                    {
                        try
                        {
                            if (/*rxNums.IsMatch(dataGridView1[j, i].Value + "")*/dataGridView1[j, i].Value != null)
                                a1[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);
                            else
                                a1[i, j] = 0;
                            s += a1[i, j] + " ";
                            if (rxNums.IsMatch(dataGridView2[j, i].Value + ""))
                                d1[i, j] = Convert.ToInt32(dataGridView2[j, i].Value);
                            else
                                d1[i, j] = 0;
                            if (i == N - 1 && d1[i, j] > max1)
                            {
                                maxi1 = j;
                                max1 = d1[i, j];
                            }
                        }
                        catch
                        {
                            button3_Click(new object(), new EventArgs());
                            radioButton2_Click(new object(), new EventArgs());
                        }
                    }
                    s = "";
                }
                i = N - 1;
                j = maxi1;
                /*    dataGridView1[j, i].Style.BackColor = Color.DarkViolet;
                    dataGridView1[j, i].Style.ForeColor = Color.Snow;*/
                //  dataGridView1[j, i].Value = "⭙";
                L.Add('⭙');
                if (i > 0 && j > 0)
                {
                    if (d1[i, j] == d1[i - 1, j - 1] + a1[i, j])
                    {
                        i--;
                        j--;
                        if (i >= 0)
                        {
                            //  dataGridView1[j, i].Value = "↘";
                            L.Add('↘');
                            /*       dataGridView1[j, i].Style.BackColor = Color.DarkViolet;
                                   dataGridView1[j, i].Style.ForeColor = Color.Snow;*/
                        }
                    }
                    else
                    {
                        i--;
                        j++;
                        if (i >= 0)
                        {
                            // dataGridView1[j, i].Value = "↙";
                            L.Add('↙');
                            /*   dataGridView1[j, i].Style.BackColor = Color.DarkViolet;
                               dataGridView1[j, i].Style.ForeColor = Color.Snow;*/
                        }
                    }
                }
                while (i != 0)
                {
                    if (j == N - i - 1)
                    {
                        i--;
                        j++;
                        if (i >= 0)
                        {
                            // dataGridView1[j, i].Value = "↙";
                            L.Add('↙');
                            /*    dataGridView1[j, i].Style.BackColor = Color.DarkViolet;
                                dataGridView1[j, i].Style.ForeColor = Color.Snow;*/
                        }
                        continue;
                    }
                    if (j == N + i - 1)
                    {
                        i--;
                        j--;
                        if (i >= 0)
                        {
                            //  dataGridView1[j, i].Value = "↘";
                            L.Add('↘');
                            /*  dataGridView1[j, i].Style.BackColor = Color.DarkViolet;
                              dataGridView1[j, i].Style.ForeColor = Color.Snow;*/
                        }
                        continue;
                    }
                    if (d1[i, j] == d1[i - 1, j - 1] + a1[i, j])
                    {
                        i--;
                        j--;
                        if (i >= 0)
                        {
                            // dataGridView1[j, i].Value = "↘";
                            L.Add('↘');
                            /*    dataGridView1[j, i].Style.BackColor = Color.DarkViolet;
                                dataGridView1[j, i].Style.ForeColor = Color.Snow;*/
                        }
                    }
                    else
                    {
                        i--;
                        j++;
                        if (i >= 0)
                        {
                            // dataGridView1[j, i].Value = "↙";
                            L.Add('↙');
                            /*   dataGridView1[j, i].Style.BackColor = Color.DarkViolet;
                               dataGridView1[j, i].Style.ForeColor = Color.Snow;*/
                        }
                    }
                }
                f = true;
                L.Reverse();
                lblAns.Text = "Відповідь: ";
                animation();
            }
            else
                radioButton1_Click(new object(), new EventArgs());
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button3.Enabled = true;
            k = 0;
            f = true;
            int u = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < 2 * N - 1; j++)
                {
                    if (dataGridView1[j, i].Value != null)
                    {
                        dataGridView1[j, i].Value = a[i, u];
                        dataGridView1[j, i].Style.BackColor = panel1.BackColor;
                        dataGridView1[j, i].Style.ForeColor = Color.FloralWhite;
                        u++;
                    }

                }
                u = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(count == 0)
            {
                j = N - 1;
                i = 0;
            }
            dataGridView1[j, i].Value = L[count];
            sum = a1[i, j];
            lblNumber.Location = new Point(178, 502);
            timer2.Start();
            if (L[count] == '⭙')
                timer1.Stop();
            dataGridView1[j, i].Style.BackColor = Color.DarkViolet;
            dataGridView1[j, i].Style.ForeColor = Color.Snow;
            if (L[count] == '↙')
            {
                i++;
                j--;
            }else
            if (L[count] == '↘')
            {
                i++;
                j++;
            }
            count++;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            count1++;
            if(count1 == 1)
                S += sum;
            lblNumber.Visible = true;
            lblNumber.Location = new Point(lblNumber.Location.X, lblNumber.Location.Y + 3);
            lblNumber.Text = sum + "";
            lblAns.Text = "Відповідь: " + S;
            if (count1 == 8) {
                count1 = 0;
                lblNumber.Visible = false;
                timer2.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            k = 0;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton1.Checked = true;
            N = Convert.ToInt32(txtN.Text);
            lblAns.Text = "Відповідь: ";
            #region Настраиваем datagridview

                  dataGridView1.Rows.Clear();
                  dataGridView1.Columns.Clear();
                  dataGridView2.Rows.Clear();
                  dataGridView2.Columns.Clear();
                  dataGridView1.ColumnCount = N * 2 - 1;
                  dataGridView1.RowCount = N;
                  dataGridView2.ColumnCount = N * 2 - 1;
                  dataGridView2.RowCount = N;
              
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N * 2 - 1; j++)
                {
                    dataGridView1[j, i].Style.Font = new Font("Times New Roman", 24);
                    dataGridView2[j, i].Style.Font = dataGridView1[j, i].Style.Font;
                    dataGridView1[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView2[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    if (check(i, j))
                    {
                        dataGridView1[j, i].Value = Microsoft.VisualBasic.Interaction.InputBox("Введіть елемент трикутника");

                        if (!rxNums.IsMatch(dataGridView1[j, i].Value.ToString()))
                            dataGridView1[j, i].Value = "0";
                    }
                 }
            }
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            
            for (int i = 0; i < N; i++) //Проверяем, есть ли пустая ячейка в треугольнике, ставим вместо нее 0
                for (int j = 0; j < 2 * N - 1; j++)
                    if (dataGridView1[j, i].Value == null && check(i, j))
                        dataGridView1[j, i].Value = "0";
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            #endregion
            
            a = new int[N+1,N+1];
            d = new int[N+1, N+1];
            int sum1 = 0, sum2 = 0;
            int y=1, u=0;
            string s = "";
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < 2 * N - 1; j++)
                {
                    if (dataGridView1[j, i].Value != null)
                    {
                        a[i, u] = Convert.ToInt32(dataGridView1[j, i].Value);
                        dataGridView1[j, i].Style.BackColor = panel1.BackColor;
                        dataGridView1[j, i].Style.ForeColor = Color.FloralWhite;
                        u++;
                    }
                }
                u = 0;
            }

            d[1, 1] = a[0, 0];
            for (int i = 1; i <= N; i++)
            {
                sum2 += a[i-1,i-1];
                sum1 += a[i-1,0];
                d[i,1] = sum1;
                d[i,i] = sum2;
            }
            for (int i = 2; i <= N; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    d[i,j] = Math.Max(d[i - 1,j - 1], d[i - 1,j]) + a[i-1,j-1];
                }
            }
            u = 1;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < 2 * N - 1; j++)
                {
                    if (dataGridView1[j, i].Value != null)
                    {
                        dataGridView2[j, i].Value = d[i+1,u];
                        dataGridView2[j, i].Style.BackColor = Color.DarkBlue;
                        dataGridView2[j, i].Style.ForeColor = Color.FloralWhite;
                        u++;
                    }
              
                }
                u = 1;
            }
            max = -1000000;
            maxi = -1;
            c = 0;
            for (int j = 0; j < 2 * N - 1; j += 2)
            {
                 if (max < Convert.ToInt32(dataGridView2[j, N-1].Value))
                 {
                    max = Convert.ToInt32(dataGridView2[j, N-1].Value);
                    maxi = c + 1;
                 }
                c++;
            }
            lblAns.Text += max + "";
        } //Click на "Ввести власноруч"
    }
}
