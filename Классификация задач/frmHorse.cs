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
    public partial class frmHorse : Form
    {
        public frmHorse()
        {
            InitializeComponent();
        }
        List<int> x = new List<int> { };
        List<int> y = new List<int> { };
        int[,] d;
        int Px, Py;
        bool check = false;
        int n, m, count = 0, finish = 0;
        private void frmHorse_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Begin.g)
                Application.Exit();
            else
            {
                frmRecFormula r = new frmRecFormula();
                r.Show();
                this.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count != 0)
            {
                dataGridHorse[Px, Py].Value = "✕";
                dataGridHorse[Px, Py].Style.BackColor = Color.DarkViolet;
            }
            if (count == finish - 1)
                timer1.Stop();
            
            dataGridHorse[x[count], y[count]].Value = "♞";
            Px = x[count];
            Py = y[count];
            count++;
        }

        private void btnHorse_Click(object sender, EventArgs e)
        {
            check = true;
            pctNew.Visible = false;
            lblAnsHorse.Text = "Відповідь: ";
            n = Convert.ToInt32(txtNHorse.Text);
            m = Convert.ToInt32(txtMHorse.Text);
            d = new int[n + 2, m + 2];
            dataGridHorse.Rows.Clear();
            dataGridHorse.Columns.Clear();
            dataGridHorse.RowCount = n;
            dataGridHorse.ColumnCount = m;
            dataGridHorse[0, 0].Style.BackColor = Color.Black;

            for (int i = 0; i < n + 2; i++)
            {
                for (int j = 0; j < m + 2; j++)
                    d[i, j] = 0;
                if (i < n)
                    dataGridHorse.Rows[i].Height = 50;
            }
            d[2, 2] = 1;
            for (int i = 2; i < n + 2; i++)
            {
                for (int j = 2; j < m + 2; j++)
                {
                    d[i, j] += d[i - 1, j - 2] + d[i - 2, j - 1];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridHorse[j, i].Style.Font = new Font("Times New Roman", 23, FontStyle.Regular);
                    dataGridHorse[j, i].Value = d[i + 2, j + 2] + "";
                    if (d[i + 2, j + 2] != 0)
                    {
                        dataGridHorse[j, i].Style.BackColor = panelPodskazkaHorse.BackColor;
                        dataGridHorse[j, i].Style.ForeColor = Color.Snow;
                    }
                    dataGridHorse.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            lblAnsHorse.Text += d[n + 1, m + 1] + "";

            dataGridHorse.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRecFormula r = new frmRecFormula();
            r.Show();
            this.Hide();
        }

        private void pictureHorse_Click(object sender, EventArgs e)
        {
            if (d[n + 1, m + 1] != 0)
            {
                x.Clear();
                y.Clear();
                if (check)
                {
                    Random z = new Random();
                    int g;
                    x.Add(m - 1);
                    y.Add(n - 1);
                    int i, j;
                    i = n - 1;
                    j = m - 1;
                    while (i != 0 && j != 0)
                    {
                        if (j == 1)
                        {
                            x.Add(j - 1);
                            y.Add(i - 2);
                            i -= 2;
                            j--;
                            continue;
                        }

                        if (j == 2 * i)
                        {
                            x.Add(j - 2);
                            y.Add(i - 1);
                            j -= 2;
                            i--;
                            continue;
                        }
                        g = z.Next(1, 3);
                        if (d[i - (3 - g) + 2, j - g + 2] != 0)
                        {
                            x.Add(j - g);
                            y.Add(i - (3 - g));
                            j -= g;
                            i -= (3 - g);
                        }
                        else
                        {
                            g = 3 - g;
                            x.Add(j - g);
                            y.Add(i - (3 - g));
                            j -= g;
                            i -= (3 - g);
                        }
                    }
                    finish = x.Count;
                    x.Reverse();
                    y.Reverse();
                    count = 0;
                    timer1.Start();
                }
                pctNew.Visible = true;
            }
            else
                MessageBox.Show("Ні одного маршруту не нашлось", "Повідомлення");
        }

        private void frmHorse_Load(object sender, EventArgs e)
        {

        }
    }
}
