using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Классификация_задач
{
    public partial class frmStrib : Form
    {
        public frmStrib()
        {
            InitializeComponent();
        }
        int N, K, sum = 1, count = 0, g=0, f;
        Random z = new Random();
        int[] dp;
        private void frmStrib_FormClosing(object sender, FormClosingEventArgs e)
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

        private void lblAns_Click(object sender, EventArgs e)
        {

        }

        private void frmStrib_Load(object sender, EventArgs e)
        {
            button2_Click(new object(), new EventArgs());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2_Click(new object(), new EventArgs());
            count = 0;
            f = 0;
            dataGridView2[0, 0].Style.Font = new Font("Times New Roman",25);
            dataGridView2[0, 0].Value = "☺";
            dataGridView2[0, 0].Style.BackColor = Color.LightCyan;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (K == 1)
                g = 0;
            else
                g = z.Next(1, K);
            if (count + g <= N)
            {
                dataGridView2[f, 0].Value = "✕";
                dataGridView2[f, 0].Style.BackColor = Color.White;
                dataGridView2[count + g - 1, 0].Value = "☺";
                dataGridView2[count + g - 1, 0].Style.Font = dataGridView2[0, 0].Style.Font;
                dataGridView2[count + g - 1, 0].Style.BackColor = Color.LightCyan;
            }
            else
            {
                dataGridView2[f, 0].Value = "✕";
                dataGridView2[f, 0].Style.BackColor = Color.White;
                dataGridView2[N - 1, 0].Value = "☺";
                dataGridView2[N - 1, 0].Style.Font = dataGridView2[0, 0].Style.Font;
                dataGridView2[N - 1, 0].Style.BackColor = Color.LightCyan;
                timer1.Stop();
            }
            f = count + g - 1;
            count = count + g;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRecFormula r = new frmRecFormula();
            r.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            N = Convert.ToInt32(txtN.Text);
            K = Convert.ToInt32(txtK.Text);
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView2.RowCount = 1;
            dataGridView2.ColumnCount = N;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.RowCount = 2;
            dataGridView1.ColumnCount = N+1;
            sum = 1;
            if (N > 8)
            {
                dataGridView1.BorderStyle = BorderStyle.FixedSingle;
                dataGridView2.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                dataGridView2.BorderStyle = BorderStyle.None;
                dataGridView1.BorderStyle = BorderStyle.None;
            }
            dp = new int[Math.Max(K,N) + 1];
            dp[0] = 0;
            dp[1] = 1;
            for(int i = 2; i <= K; i++)
            {
                dp[i] = sum;
                sum += sum;
            }
            for(int i = K+1;i <= N;i++)
            {
                dp[i] = sum;
                sum = sum - dp[i - K] + dp[i];
            }
            dataGridView1[0, 1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1[0, 0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1[0, 0].Style.Font = new Font("Times New Roman", 17, FontStyle.Bold);
            dataGridView1[0, 1].Style.Font = new Font("Times New Roman", 17,FontStyle.Bold);
            dataGridView1[0, 0].Value = "Номер крока:";
            dataGridView1[0, 1].Value = "Рішення підзадач:";
            dataGridView2.Rows[0].Height = 58;
            for (int i = 1; i <= N; i++)
            {
                dataGridView2.Columns[i-1].Width = 58;
           //     dataGridView2[i-1, 0].Style.BackColor = panel2.BackColor;
                dataGridView1[i, 0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1[i, 1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1[i, 0].Style.Font = new Font("Times New Roman", 23);
                dataGridView1[i, 0].Style.BackColor = Color.LightCyan;
                dataGridView1[i, 0].Style.ForeColor = Color.Blue;
                dataGridView1[i, 0].Value = (i) + "";
                dataGridView1[i, 1].Style.Font = new Font("Times New Roman", 24);
                dataGridView1[i, 1].Style.BackColor = Color.Bisque;
                dataGridView1[i, 1].Value = (dp[i]);
            }
            dataGridView1[N, 1].Style.BackColor = Color.DarkRed;
            dataGridView1[N, 1].Style.ForeColor = Color.Snow;
            lblAns.Text = "Відповідь: " + dp[N];
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }
    }
}
