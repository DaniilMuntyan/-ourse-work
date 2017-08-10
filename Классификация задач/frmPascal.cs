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
    public partial class frmPascal : Form
    {
        public frmPascal()
        {
            InitializeComponent();
        }
        int N;
        Regex rxNums = new Regex(@"^\d+$");
        int[,] d;

        bool check(int i, int j)
        {
            i++;
            j++;
            int g = N - i + 1;
            while (true)
            {
                if (g > N + i)
                    return false;
                if (g == j)
                    return true;
                g += 2;
            }
        } //Проверяет, [i][j] есть ли частью треугольника
        private void button1_Click(object sender, EventArgs e)
        {
            N = Convert.ToInt32(txtN.Text);
            #region Настраиваем datagridview

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = N * 2 - 1;
            dataGridView1.RowCount = N;

            #endregion
            d = new int[N + 1, N + 1];
            d[1, 1] = 1;
            for (int i = 2; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || i == j)
                        d[i, j] = 1;
                    else
                        d[i, j] = d[i - 1, j - 1] + d[i - 1, j];
                }
            }
            int u = 1;
                
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < 2 * N - 1; j++)
                {
                    dataGridView1[j, i].Style.Font = new Font("Times New Roman", 24,FontStyle.Bold);
                    dataGridView1[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    if (check(i, j))
                    {
                        dataGridView1[j, i].Value = d[i + 1, u];
                        dataGridView1[j, i].Style.BackColor = Color.DarkBlue;
                        dataGridView1[j, i].Style.ForeColor = Color.FloralWhite;
                        u++;
                    }

                }
                u = 1;
            }
            dataGridView1.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRecFormula r = new frmRecFormula();
            r.Show();
            this.Hide();
        }

        private void frmPascal_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
