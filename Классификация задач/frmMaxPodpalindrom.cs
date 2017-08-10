using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Классификация_задач
{
    public partial class frmMaxPodpalindrom : Form
    {
        public frmMaxPodpalindrom()
        {
            InitializeComponent();
        }

        private void frmMaxPodpalindrom_Load(object sender, EventArgs e)
        {
            Label podskazka1 = new Label();
            Label podskazka2 = new Label();
            Label podskazka3 = new Label();
            lblUmovaPolindrom.Location = new Point(0, 5);
            lblUmovaPolindrom.Size = new Size(this.Width - lblUmovaPolindrom.Location.X - 100, 175);
        //    lblUmovaPolindrom.Text = File.ReadAllText("Умови\\Умова задачі найбільший підпаліндром.txt");

            lblPodPalindrom.Show(); //Введіть рядок
            lblPodPalindrom.Location = new Point(lblUmovaPolindrom.Location.X, lblUmovaPolindrom.Location.Y + 170);

            txtPodPolindrom.Location = new Point(lblPodPalindrom.Location.X + lblPodPalindrom.Width, lblPodPalindrom.Location.Y);
            txtPodPolindrom.Text = "AVFGA";

            btnPodPalindrom.Location = new Point(txtPodPolindrom.Location.X + txtPodPolindrom.Width + 80, txtPodPolindrom.Location.Y - txtPodPolindrom.Height / 4 + 10);
            btnPodPalindrom.Click += btnPodPalindrom_Click;

            dataGridPodPalindrom.Rows.Clear();
            dataGridPodPalindrom.Columns.Clear();
            dataGridPodPalindrom.Location = new Point(lblPodPalindrom.Location.X + 10, lblPodPalindrom.Location.Y + lblPodPalindrom.Height + 10);
       //     dataGridPodPalindrom.Size = new Size(200, 100);
            
            lblAnsPodpalindrom.Location = new Point(900, this.Height - 80);

            panelPodskazkaPodpalindrom1.Location = new Point(dataGridPodPalindrom.Location.X + dataGridPodPalindrom.Width + 10, dataGridPodPalindrom.Location.Y);

            panelPodskazkaPodpalindrom1.BackColor = Color.DodgerBlue;

            podskazka1.Size = new Size(300, 50);
            podskazka1.Font = new Font("Tahoma", 10, FontStyle.Bold);
            podskazka1.Location = new Point(panelPodskazkaPodpalindrom1.Location.X + panelPodskazkaPodpalindrom1.Width, panelPodskazkaPodpalindrom1.Location.Y + 10);
            podskazka1.Text = "- позначаються ті, що розташовані по діагоналі (сам рядок)";

            panelPodskazkapodpalindrom2.Location = new Point(panelPodskazkaPodpalindrom1.Location.X, panelPodskazkaPodpalindrom1.Location.Y + panelPodskazkaPodpalindrom1.Height + 20);
            panelPodskazkapodpalindrom2.BackColor = Color.GreenYellow;

            podskazka2.Size = podskazka1.Size;
            podskazka2.Font = podskazka1.Font;
            podskazka2.Location = new Point(panelPodskazkapodpalindrom2.Location.X + panelPodskazkapodpalindrom2.Width, panelPodskazkapodpalindrom2.Location.Y + 10);
            podskazka2.Text = "- позначаються ті, що використані на шляху до знаходження відповіді";

            panelPodskazkapodpalindrom3.Location = new Point(panelPodskazkapodpalindrom2.Location.X, panelPodskazkapodpalindrom2.Location.Y + panelPodskazkapodpalindrom2.Height + 20);
            panelPodskazkapodpalindrom3.BackColor = Color.Gold;

            lblAnsPodpalindrom.Location = new Point(panelPodskazkaPodpalindrom1.Location.X, panelPodskazkapodpalindrom3.Location.Y + panelPodskazkapodpalindrom3.Height + 30);
            
            podskazka3.Size = podskazka2.Size;
            podskazka3.Font = podskazka2.Font;
            podskazka3.Location = new Point(panelPodskazkapodpalindrom3.Location.X + panelPodskazkapodpalindrom3.Width, panelPodskazkapodpalindrom3.Location.Y + 10);
            podskazka3.Text = "- позначається відповідь до задачі";
            dataGridPodPalindrom.ClearSelection();
            this.Controls.Add(podskazka1);
            this.Controls.Add(podskazka2);
            this.Controls.Add(podskazka3);

        }
        private void btnPodPalindrom_Click(object sender, EventArgs e)
        {
            dataGridPodPalindrom.Show();
            lblAnsPodpalindrom.Text = "Відповідь:";
            int widght = 0, height = 0;
            dataGridPodPalindrom.Rows.Clear();
            dataGridPodPalindrom.Columns.Clear();
            string s;
            s = txtPodPolindrom.Text;
            int L = s.Length;
            dataGridPodPalindrom.ColumnCount = L;
            dataGridPodPalindrom.RowCount = L;
            string[,] d = new string[101, 101];


            for (int i = 0; i < L; i++)
            {
                d[i, i] = Convert.ToString(s[i]);
                dataGridPodPalindrom.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridPodPalindrom.Columns[i].HeaderText = s[i] + "";

            }
            for (int i = 1; i < L; i++)
            {
                for (int j = i; j < L; j++)
                {
                    int g = j - i;
                    if (s[g] != s[j])
                        d[g, j] = max(d[g, j - 1], d[g + 1, j]);
                    else
                        d[g, j] = max(d[g, j - 1], max(d[g + 1, j], s[g] + d[g + 1, j - 1] + s[j]));

                }
            }
            for (int i = 0; i < L; i++)
                dataGridPodPalindrom.Rows[i].Height = 50;//Подстравиваем ширину таблицы
            dataGridPodPalindrom.Enabled = true;
           // dataGridPodPalindrom.Width = this.Width * 3 / 4;
          //  dataGridPodPalindrom.Height = this.Height - dataGridPodPalindrom.Location.Y - 50;
            //В следующих циклах заполняю таблицу для визулизации алгоритма
            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < L; j++)
                {
                    dataGridPodPalindrom.Rows[i].Cells[j].Value = d[i, j];
                    dataGridPodPalindrom.Rows[i].Cells[j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridPodPalindrom.Rows[i].Cells[j].Style.Font = new Font("Tahoma", 22, FontStyle.Bold);
                    if (i <= j)
                        dataGridPodPalindrom.Rows[i].Cells[j].Style.BackColor = Color.GreenYellow;
                    else
                        dataGridPodPalindrom.Rows[i].Cells[j].Style.BackColor = Color.Gray;
                    if (i == j)
                    {
                        dataGridPodPalindrom.Rows[i].Cells[j].Style.ForeColor = Color.Snow;
                        dataGridPodPalindrom.Rows[i].Cells[j].Style.BackColor = Color.DodgerBlue;
                    }
                    if (i == 0 && j == L - 1)
                        dataGridPodPalindrom.Rows[i].Cells[j].Style.BackColor = Color.Gold;
                    if (i == 0)
                        widght += dataGridPodPalindrom.Columns[j].Width;
                }
                height += dataGridPodPalindrom.Rows[i].Height;
            }
            dataGridPodPalindrom.Columns[0].ReadOnly = true;
            //В следующих циклах заполняю пустые клетки таблицы "-"
            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < L; j++)
                {
                    string h = Convert.ToString(dataGridPodPalindrom.Rows[i].Cells[j].Value);
                    h.Replace(" ", "");
                    dataGridPodPalindrom.Rows[i].Cells[j].Value = h;
                    if (dataGridPodPalindrom.Rows[i].Cells[j].Value == "")
                        dataGridPodPalindrom.Rows[i].Cells[j].Value = "-";
                }
            }
            widght += dataGridPodPalindrom.RowHeadersWidth + 40;
           // dataGridPodPalindrom.Width = widght;
            lblAnsPodpalindrom.Text += " " + d[0, L - 1];
            dataGridPodPalindrom.ClearSelection();
        }
        string max(string a, string b)
        {
            if (a.Length >= b.Length)
                return a;
            else
                return b;
        }

        private void frmMaxPodpalindrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Begin.g)
                Application.Exit();
            else
            {
                frmSearchOptKilAndSum s = new frmSearchOptKilAndSum();
                s.Show();
                this.Hide();
                e.Cancel = true;
            }
            
        }

        private void btnPodPalindrom_Click_1(object sender, EventArgs e)
        {
            btnPodPalindrom_Click(new object(), new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSearchOptKilAndSum s = new frmSearchOptKilAndSum();
            s.Show();
            this.Hide();
        }
    }
}
