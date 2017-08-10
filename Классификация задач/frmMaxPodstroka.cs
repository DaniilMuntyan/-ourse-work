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
    public partial class frmMaxPodstroka : Form
    {
        public frmMaxPodstroka()
        {
            InitializeComponent();
        }

        private void frmMaxPodstroka_Load(object sender, EventArgs e)
        {
            dataGridPodstroka.Rows.Clear();
            dataGridPodstroka.Columns.Clear();
            lblPodstroka.Text = File.ReadAllText("Умови\\Умова задачі найбільший підрядок.txt");
          //  lblPodstroka.Size = new Size(this.Width-10, 130);
         /*   lblPodstrokaS1.Location = new Point(lblPodstroka.Location.X, lblPodstroka.Location.Y + lblPodstroka.Height);
            txtPodstrokaS1.Location = new Point(lblPodstrokaS1.Location.X + lblPodstrokaS1.Width + 20, lblPodstrokaS1.Location.Y + 5);
            lblPodstrokaS2.Location = new Point(lblPodstrokaS1.Location.X, lblPodstrokaS1.Location.Y + lblPodstrokaS1.Height + 20);
            txtPodstrokaS2.Location = new Point(lblPodstrokaS2.Location.X + lblPodstrokaS2.Width + 20, lblPodstrokaS2.Location.Y + 5);
            btnPodstroka.Location = new Point(txtPodstrokaS1.Location.X + txtPodstrokaS1.Width + 85, txtPodstrokaS1.Location.Y);
            txtPodstrokaS1.Text = "qwe";
            txtPodstrokaS2.Text = "qwerty";
            lblAnsPodstroka.Location = new Point(lblPodstrokaS2.Location.X + 10 + this.Width / 2, lblPodstrokaS2.Location.Y + lblPodstrokaS2.Height + 20);
            */
          /*  panelPodskazka1Podstroka.Location = new Point(lblAnsPodstroka.Location.X + 10, lblAnsPodstroka.Location.Y + lblAnsPodstroka.Height);
            panelPodskazka1Podstroka.BackColor = Color.LawnGreen;
            panelPodskazka2Podstroka.Location = new Point(panelPodskazka1Podstroka.Location.X, panelPodskazka1Podstroka.Location.Y + panelPodskazka1Podstroka.Height + 10);
            panelPodskazka2Podstroka.BackColor = Color.LightBlue;
            panelPodskazka3Podstroka.Location = new Point(panelPodskazka2Podstroka.Location.X, panelPodskazka2Podstroka.Location.Y + panelPodskazka2Podstroka.Height + 10);
            panelPodskazka3Podstroka.BackColor = Color.Fuchsia;*/
           /* podsk1.AutoSize = false;
            podsk1.Font = new Font("Tahoma", 16, FontStyle.Regular);
            podsk1.Size = new Size(500, 40);
            podsk1.Location = new Point(panelPodskazka1Podstroka.Location.X + panelPodskazka1Podstroka.Width + 5, panelPodskazka1Podstroka.Location.Y + panelPodskazka1Podstroka.Height / 4);
            podsk1.Text = "- позначаються елементи першого рядка";
            podsk2.Location = new Point(podsk1.Location.X, panelPodskazka2Podstroka.Location.Y + panelPodskazka2Podstroka.Height / 4);
            podsk2.Text = "- позначаються елементи другого рядка";
            podsk2.Font = podsk1.Font;
            podsk2.AutoSize = false;
            podsk2.Size = podsk1.Size;
            podsk3.AutoSize = false;
            podsk3.Size = new Size(600, 40);
            podsk3.Location = new Point(podsk2.Location.X, panelPodskazka3Podstroka.Location.Y + panelPodskazka3Podstroka.Height / 4);
            podsk3.Font = podsk1.Font;
            podsk3.Text = "- позначаються ті, що задіяні у пошуку відповіді";

    
            this.Controls.Add(podsk1);
            this.Controls.Add(podsk2);
            this.Controls.Add(podsk3);*/
        }

        private void frmMaxPodstroka_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnPodstroka_Click(object sender, EventArgs e)
        {
            lblAnsPodstroka.Text = "Відповідь: ";
            dataGridPodstroka.Enabled = true;
            dataGridPodstroka.Rows.Clear();
            dataGridPodstroka.Columns.Clear();
            int N1, N2;
            string s1 = "", s2 = "";
            s1 = txtPodstrokaS1.Text;
            s2 = txtPodstrokaS2.Text;
            if (s1 == string.Empty && s2 == string.Empty)
            {
                s1 = "qwe";
                s2 = "qwerty";
                txtPodstrokaS1.Text = s1;
                txtPodstrokaS2.Text = s2;
            }

            N1 = s1.Length;
            N2 = s2.Length;
            int[,] A = new int[N1 + 2, N2 + 2];
            dataGridPodstroka.ColumnCount = N2 + 2;
            dataGridPodstroka.RowCount = N1 + 2;
            int k = 0;
            for (int i = 0; i < N2 + 2; i++)
            {
                dataGridPodstroka.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                if (i > 1)
                {
                    dataGridPodstroka.Rows[0].Cells[i].Style.Font = new Font("Tahoma", 20, FontStyle.Bold);
                    dataGridPodstroka.Rows[0].Cells[i].Value = s2[k];
                    dataGridPodstroka.Rows[0].Cells[i].Style.BackColor = Color.LightBlue;
                    dataGridPodstroka.Rows[0].Cells[i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    k++;
                }
                if (i > 0)
                {
                    dataGridPodstroka.Rows[1].Cells[i].Value = "0";
                    dataGridPodstroka.Rows[1].Cells[i].Style.Font = new Font("Tahoma", 18);
                    dataGridPodstroka.Rows[1].Cells[i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (i < N2)
                    A[0, i] = 0;
            }
            k = 0;
            for (int i = 0; i < N1 + 2; i++)
            {
                dataGridPodstroka.Rows[i].MinimumHeight = 50;
                if (i > 1)
                {
                    dataGridPodstroka.Rows[i].Cells[0].Style.Font = new Font("Tahoma", 20, FontStyle.Bold);
                    dataGridPodstroka.Rows[i].Cells[0].Value = s1[k];
                    dataGridPodstroka.Rows[i].Cells[0].Style.BackColor = Color.LawnGreen;
                    dataGridPodstroka.Rows[i].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    k++;
                }
                if (i > 0)
                {
                    dataGridPodstroka.Rows[i].Cells[1].Style.Font = new Font("Tahoma", 18);
                    dataGridPodstroka.Rows[i].Cells[1].Value = "0";
                    dataGridPodstroka.Rows[i].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                }
                if (i < N1)
                    A[i, 0] = 0;
            }
            k = 0;
            int max = -1, iMax = -1;
            for (int i = 1; i <= N1; i++)
            {
                for (int j = 1; j <= N2; j++)
                {
                    dataGridPodstroka.Rows[i + 1].Cells[j + 1].Style.BackColor = Color.White;
                    dataGridPodstroka.Rows[i + 1].Cells[j + 1].Style.ForeColor = Color.Black;
                    if (s1[i - 1] != s2[j - 1])
                        A[i, j] = 0;
                    else
                        A[i, j] = A[i - 1, j - 1] + 1;
                    dataGridPodstroka.Rows[i + 1].Cells[j + 1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridPodstroka.Rows[i + 1].Cells[j + 1].Style.Font = new Font("Tahoma", 20);
                    if (A[i, j] != 0)
                    {
                        dataGridPodstroka.Rows[i + 1].Cells[j + 1].Style.BackColor = Color.Fuchsia;
                        dataGridPodstroka.Rows[i + 1].Cells[j + 1].Style.ForeColor = Color.GhostWhite;
                    }
                    if (A[i, j] >= max)
                    {
                        max = A[i, j];
                        iMax = i;
                    }
                    dataGridPodstroka.Rows[i + 1].Cells[j + 1].Value = A[i, j] + "";

                }
            }
            int w = 0;
            for (int i = iMax - max; w < max; i++)//Выводим ответ в Label
            {
                lblAnsPodstroka.Text += s1[i];
                w++;
            }
            dataGridPodstroka.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSearchOptKilAndSum s = new frmSearchOptKilAndSum();
            s.Show();
            this.Hide();
        }
    }
}
