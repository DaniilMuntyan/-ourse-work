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
    public partial class frmPodposl : Form
    {
        public frmPodposl()
        {
            InitializeComponent();
        }
        Label lblN = new Label();
        Button btnAnsPT0 = new Button();
        Button btnCodePT0 = new Button();
        PictureBox threeE = new PictureBox();
        PictureBox threeE2 = new PictureBox();
        Label solutionPT0 = new Label();
        Label solutionPT1 = new Label();
        Label ansPT0 = new Label();
        int isfirst = 0;
        int[] a = new int[1000]; // Массив чисел последовательности
        int[] d = new int[1000]; // Массив самой динамики
        int[] w = new int[1000]; // Массив, в котором будем содержать наибольшую подпоследовательность
        private void frmPodposl_Load(object sender, EventArgs e)
        {

        }

        private void vlasnoruchPT1_Click(object sender, EventArgs e)
        {

            GridViewPod.Rows.Clear();
            GridViewPod.Columns.Clear();
            int N;
            try
            {
                N = Convert.ToInt32(txtPodN.Text);
                GridViewPod.Enabled = true;

                //     GridViewPod.Location = new Point(lblPodN.Location.X, lblPodN.Location.Y + 100);
                GridViewPod.ColumnCount = N;
                GridViewPod.Rows[0].Height = 100;
                GridViewPod.Size = new Size(500, 97);
                for (int i = 0; i < N; i++)
                {
                    GridViewPod.Rows[0].Cells[i].Value = Microsoft.VisualBasic.Interaction.InputBox("Введіть " + (i + 1) + "-ий член послідовності");

                    if (Convert.ToString(GridViewPod.Rows[0].Cells[i].Value) == String.Empty)
                    {
                        GridViewPod.Rows[0].Cells[i].Value = "0";
                        a[i] = 0;
                    }
                    else
                        a[i] = Convert.ToInt32(GridViewPod.Rows[0].Cells[i].Value);
                    if (a[i] > 999)
                        GridViewPod.Columns[i].Width = 110;
                    else
                        GridViewPod.Columns[i].Width = 100;
                    GridViewPod.Rows[0].Cells[i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    GridViewPod.Rows[0].Cells[i].Style.Font = new Font("Tahoma", 24, FontStyle.Bold);
                }
                if (N < 8)
                {
                    GridViewPod.Width = N * 101;
                    GridViewPod.Enabled = false; // Не даем пользователю вписать вручную

                }
                else
                {
                    GridViewPod.Width = this.Width - GridViewPod.Location.X - 50;
                    GridViewPod.Height += 20;
                }
                //   lblAnsPodPosl.Location = new Point(0, GridViewPod.Location.Y + 115);
                resultPodPosl(N);
            }
            catch
            {
                MessageBox.Show("Невірне N", "Введіть вірне N");
            }
        }
        private void resultPodPosl(int N) // В этом методе мы реализуем алгоритм нахождения наибольшей подпоследовательности
        {
            List<int> path = new List<int> { };
            path.Clear();
            string s; // Строка, которая будет содержать ответ на задачу наибольшей подпоследовательности
            int ans = 0;

            for (int i = 0; i < N; i++)
            {
                d[i] = 1;
                w[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    if (a[j] < a[i])
                    {
                        if (d[i] < 1 + d[j])
                        {
                            d[i] = d[j] + 1;
                            w[i] = j;
                        }
                    }
                }
            }
            ans = d[0];
            int pos = 0, y = 0;
            for (int i = 0; i < N; ++i)
                if (d[i] > ans)
                {
                    ans = d[i];
                    pos = i;
                }

            while (pos != -1)
            {
                path.Add(pos);
                pos = w[pos];
                y++;
            }
            path.Reverse();
            lblAnsPodPosl.Text = "Довжина найбільшої підпослідовності: " + /*path.Count*/ans;
            lblAnsPodPosl.Text += "\nЕлементи цієї підмножини:  ";
            for (int i = 0; i < (int)path.Count; i++)
            {
                lblAnsPodPosl.Text += a[path[i]] + " ";
                GridViewPod.Rows[0].Cells[path[i]].Style.BackColor = Color.Blue;
                GridViewPod.Rows[0].Cells[path[i]].Style.ForeColor = Color.White;
            }
            for (int i = 0; i < N; i++)
            {
                if (GridViewPod.Rows[0].Cells[i].Style.BackColor != Color.Blue)
                {
                    GridViewPod.Rows[0].Cells[i].Style.BackColor = panelPodskazka1.BackColor;
                    GridViewPod.Rows[0].Cells[i].Style.ForeColor = Color.White;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSearchOptKilAndSum s = new frmSearchOptKilAndSum();
            s.Show();
            this.Hide();
        }

        private void frmPodposl_FormClosing(object sender, FormClosingEventArgs e)
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

        private void vypadlovoPT1_Click(object sender, EventArgs e)
        {
            Random z = new Random();
            GridViewPod.Rows.Clear();
            GridViewPod.Columns.Clear();
            int N;
            try
            {
                N = Convert.ToInt32(txtPodN.Text);
                GridViewPod.Enabled = true;

                //     GridViewPod.Location = new Point(lblPodN.Location.X, lblPodN.Location.Y + 100);
                GridViewPod.ColumnCount = N;
                GridViewPod.Rows[0].Height = 100;
                GridViewPod.Size = new Size(500, 97);
                for (int i = 0; i < N; i++)
                {
                    GridViewPod.Rows[0].Cells[i].Value = z.Next(-200, 200) + ""; 

                    if (Convert.ToString(GridViewPod.Rows[0].Cells[i].Value) == String.Empty)
                    {
                        GridViewPod.Rows[0].Cells[i].Value = "0";
                        a[i] = 0;
                    }
                    else
                        a[i] = Convert.ToInt32(GridViewPod.Rows[0].Cells[i].Value);
                    if (a[i] > 999)
                        GridViewPod.Columns[i].Width = 110;
                    else
                        GridViewPod.Columns[i].Width = 100;
                    GridViewPod.Rows[0].Cells[i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    GridViewPod.Rows[0].Cells[i].Style.Font = new Font("Tahoma", 24, FontStyle.Bold);
                }
                if (N < 8)
                {
                    GridViewPod.Width = N * 101;
                    GridViewPod.Enabled = false; // Не даем пользователю вписать вручную

                }
                else
                {
                    GridViewPod.Width = this.Width - GridViewPod.Location.X - 50;
                    GridViewPod.Height += 20;
                }
                //   lblAnsPodPosl.Location = new Point(0, GridViewPod.Location.Y + 115);
                resultPodPosl(N);
            }
            catch
            {
                MessageBox.Show("Невірне N", "Введіть вірне N");
            }
        }
    }
}
