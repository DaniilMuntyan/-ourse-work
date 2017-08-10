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
    public partial class frmKnapsack : Form
    {
        public frmKnapsack()
        {
            InitializeComponent();
        }
        int[] p,w;
        int[,] A;
        List<int> ans = new List<int> { };
        private void frmKnapsack_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmKnapsack_Load(object sender, EventArgs e)
        {
            dataGridKnapsack.Rows.Clear();
            dataGridKnapsack.Columns.Clear();
            dataGridMasKnapsack.Rows.Clear();
            dataGridMasKnapsack.Columns.Clear();
            dataGridKnapsack.AllowUserToAddRows = false;

            int n = Convert.ToInt32(txtNKnapsack.Text), m = Convert.ToInt32(txtMKnapsack.Text);
            
       
            dataGridKnapsack.RowCount = 1 + n;
            dataGridKnapsack.ColumnCount = 3;
            dataGridKnapsack.Rows[0].Height = 40;
            for (int i = 0; i <= n; i++)
                for (int j = 0; j < 3; j++)
                    dataGridKnapsack[j, i].Style.Font = new Font(Name, 19, FontStyle.Regular);

            dataGridKnapsack[1, 0].Style.Font = new Font(Name, 21, FontStyle.Bold);
            dataGridKnapsack[2, 0].Style.Font = new Font(Name, 21, FontStyle.Bold);
            dataGridKnapsack[0, 0].Style.Font = new Font(Name, 21, FontStyle.Bold);
            dataGridKnapsack[1, 0].Value = "Масса";
            dataGridKnapsack[2, 0].Value = "Ціна";
            dataGridKnapsack[0, 0].Value = "Номер предмета";
            dataGridKnapsack[1, 1].Value = "3";
            dataGridKnapsack[1, 2].Value = "149";
            dataGridKnapsack[2, 1].Value = "46";
            dataGridKnapsack[2, 2].Value = "151";
            for (int j = 1; j <= n; j++)
            {
                dataGridKnapsack[0, j].Value = "Предмет № " + j;
                dataGridKnapsack[1, j].Style.BackColor = Color.Chartreuse;
                dataGridKnapsack[2, j].Style.BackColor = Color.BurlyWood;
                dataGridKnapsack.Rows[j].Height = 40;
            }
            dataGridKnapsack.AutoResizeColumns();
            dataGridKnapsack.ClearSelection();
            btnKnapsackVruch_Click(new object(), new EventArgs());

        }

        private void btnKnapsackVruch_Click(object sender, EventArgs e)
        {
            lblAnsKnapsack.Text = "Відповідь:";
            dataGridMasKnapsack.Rows.Clear();
            dataGridMasKnapsack.Columns.Clear();
            Random z = new Random();
            int n = Convert.ToInt32(txtNKnapsack.Text), m = Convert.ToInt32(txtMKnapsack.Text);
            
            dataGridKnapsack.RowCount = 1 + n;
            dataGridKnapsack.ColumnCount = 3;
            for (int i = 0; i <= n; i++)
                for (int j = 0; j < 3; j++)
                    dataGridKnapsack[j, i].Style.Font = new Font(Name, 19, FontStyle.Regular);

            dataGridKnapsack[1, 0].Style.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            dataGridKnapsack[2, 0].Style.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            dataGridKnapsack[0, 0].Style.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            dataGridKnapsack[1, 0].Value = "Масса";
            dataGridKnapsack[2, 0].Value = "Ціна";
            dataGridKnapsack[0, 0].Value = "Номер предмета";
            for (int j = 1; j <= n; j++)
            {
                dataGridKnapsack[0, j].Value = "Предмет № " + j;
                dataGridKnapsack[1, j].Style.BackColor = Color.Chartreuse;
                dataGridKnapsack[2, j].Style.BackColor = Color.BurlyWood;
            }
            dataGridKnapsack.AutoResizeColumns();

            dataGridMasKnapsack.RowCount = n + 1;
            dataGridMasKnapsack.ColumnCount = m + 1;
            w = new int[n + 1];
            p = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                w[i] = Convert.ToInt32(dataGridKnapsack.Rows[i].Cells[1].Value);
                p[i] = Convert.ToInt32(dataGridKnapsack.Rows[i].Cells[2].Value);
                dataGridKnapsack.Rows[i].Cells[1].Value = w[i] + "";
                dataGridKnapsack.Rows[i].Cells[2].Value = p[i] + "";
            }
            A = new int[n + 1, m + 1];
            for (int i = 0; i <= n; i++)
                A[i, 0] = 0;
            for (int i = 0; i <= m; i++)
                A[0, i] = 0;
            for (int i = 1; i <= n; i++)//i = k j = s
            {
                for (int j = 1; j <= m; j++)
                {
                    if (j >= w[i])
                        A[i, j] = Math.Max(A[i - 1, j], A[i - 1, j - w[i]] + p[i]);
                    else
                        A[i, j] = A[i - 1, j];
                }
            }
            for (int i = 0; i <= n; i++)
            {
                dataGridMasKnapsack.Rows[i].Height = 30;
                for (int j = 0; j <= m; j++)
                {
                    dataGridMasKnapsack[j, i].Style.Font = new Font("Times New Roman", 20, FontStyle.Regular);
                    dataGridMasKnapsack[j, i].Value = A[i, j] + "";
                    dataGridMasKnapsack.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            dataGridMasKnapsack.ClearSelection();//Убирает выдиление с первой ячейки таблицы
            dataGridMasKnapsack[m, n].Style.BackColor = Color.Gold;
            dataGridMasKnapsack[m, n].Style.BackColor = Color.Gold;
            lblAnsKnapsack.Text += " " + A[n, m];
            listBoxKnapsack.Items.Clear();
            ans.Clear();
            findAnsKnapsak(n, m, A);
            listBoxKnapsack.Items.Add("В рюкзак для максимізації цін кладемо:");
            foreach (int i in ans)
                listBoxKnapsack.Items.Add("Предмет № " + i);
            dataGridKnapsack.ClearSelection();

        }
        void findAnsKnapsak(int k, int s, int[,] A)
        {
            if (A[k, s] == 0)//Ошибка
                return;
            if (A[k - 1, s] == A[k, s])
                findAnsKnapsak(k - 1, s, A);
            else
            {
                findAnsKnapsak(k - 1, s - w[k], A);
                ans.Add(k);
            }
        }

        private void btnKnapsackRandom_Click(object sender, EventArgs e)
        {

            lblAnsKnapsack.Text = "Відповідь:";
            dataGridMasKnapsack.Rows.Clear();
            dataGridMasKnapsack.Columns.Clear();
            Random z = new Random();
            int n = Convert.ToInt32(txtNKnapsack.Text), m = Convert.ToInt32(txtMKnapsack.Text);

            dataGridKnapsack.RowCount = 1 + n;
            dataGridKnapsack.ColumnCount = 3;
            for (int i = 0; i <= n; i++)
                for (int j = 0; j < 3; j++)
                    dataGridKnapsack[j, i].Style.Font = new Font(Name, 19, FontStyle.Regular);

            dataGridKnapsack[1, 0].Style.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            dataGridKnapsack[2, 0].Style.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            dataGridKnapsack[0, 0].Style.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            dataGridKnapsack[1, 0].Value = "Масса";
            dataGridKnapsack[2, 0].Value = "Ціна";
            dataGridKnapsack[0, 0].Value = "Номер предмета";
            for (int j = 1; j <= n; j++)
            {
                dataGridKnapsack[0, j].Value = "Предмет № " + j;
                dataGridKnapsack[1, j].Style.BackColor = Color.Chartreuse;
                dataGridKnapsack[2, j].Style.BackColor = Color.BurlyWood;
            }
            dataGridKnapsack.AutoResizeColumns();

            dataGridMasKnapsack.RowCount = n + 1;
            dataGridMasKnapsack.ColumnCount = m + 1;
            w = new int[n + 1];
            p = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                w[i] = z.Next(1,m+2*m);
                p[i] = z.Next(1,130);
                dataGridKnapsack.Rows[i].Cells[1].Value = w[i] + "";
                dataGridKnapsack.Rows[i].Cells[2].Value = p[i] + "";
            }
            A = new int[n + 1, m + 1];
            for (int i = 0; i <= n; i++)
                A[i, 0] = 0;
            for (int i = 0; i <= m; i++)
                A[0, i] = 0;
            for (int i = 1; i <= n; i++)//i = k j = s
            {
                for (int j = 1; j <= m; j++)
                {
                    if (j >= w[i])
                        A[i, j] = Math.Max(A[i - 1, j], A[i - 1, j - w[i]] + p[i]);
                    else
                        A[i, j] = A[i - 1, j];
                }
            }
            for (int i = 0; i <= n; i++)
            {
                dataGridMasKnapsack.Rows[i].Height = 30;
                for (int j = 0; j <= m; j++)
                {
                    dataGridMasKnapsack[j, i].Style.Font = new Font("Times New Roman", 20, FontStyle.Regular);
                    dataGridMasKnapsack[j, i].Value = A[i, j] + "";
                    dataGridMasKnapsack.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            dataGridMasKnapsack.ClearSelection();//Убирает выдиление с первой ячейки таблицы
            dataGridMasKnapsack[m, n].Style.BackColor = Color.Gold;
            dataGridMasKnapsack[m, n].Style.BackColor = Color.Gold;
            lblAnsKnapsack.Text += " " + A[n, m];
            listBoxKnapsack.Items.Clear();
            ans.Clear();
            findAnsKnapsak(n, m, A);
            listBoxKnapsack.Items.Add("В рюкзак для максимізації цін кладемо:");
            foreach (int i in ans)
                listBoxKnapsack.Items.Add("Предмет № " + i);
            dataGridKnapsack.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSearchOptKilAndSum s = new frmSearchOptKilAndSum();
            s.Show();
            this.Hide();
        }
    }
}
