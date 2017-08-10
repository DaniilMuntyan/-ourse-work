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
    public partial class frmKvitki : Form
    {
        public frmKvitki()
        {
            InitializeComponent();
        }

        private void frmKvitki_Load(object sender, EventArgs e)
        {
            lblUmovaKvitki.AutoSize = false;
            lblUmovaKvitki.Size = new Size(this.Width - 90, 225);
            lblUmovaKvitki.Location = new Point(0, 10);
           // lblUmovaKvitki.Text = File.ReadAllText("Умови\\Умова Квитки.txt");

            lblNKvitki.Location = new Point(lblUmovaKvitki.Location.X, lblUmovaKvitki.Location.Y + lblUmovaKvitki.Height + 10);
            txtNK.Location = new Point(lblNKvitki.Location.X + lblNKvitki.Width, lblNKvitki.Location.Y);
            txtNK.Text = "5";
            btnKvitkiVruch.Location = new Point(txtNK.Location.X + txtNK.Width + 10, txtNK.Location.Y - 10);
            btnKvitkiRandom.Location = new Point(btnKvitkiVruch.Location.X + btnKvitkiVruch.Width + 10, btnKvitkiVruch.Location.Y);
            dataGridKvitki.Location = new Point(lblNKvitki.Location.X + 10, lblNKvitki.Location.Y + lblNKvitki.Height + 10);
            dataGridKvitki.Size = new Size(554, 207);

            int n = Convert.ToInt32(txtNK.Text);
            dataGridKvitki.RowCount = 4;
            dataGridKvitki.ColumnCount = n + 1;
            dataGridKvitki.Rows[1].Cells[0].Value = "Продаж одного білету";
            dataGridKvitki.Rows[2].Cells[0].Value = "Продаж двух білетів";
            dataGridKvitki.Rows[3].Cells[0].Value = "Продаж трьох білетів";
            dataGridKvitki.AutoResizeColumns();
            dataGridKvitki.Rows[0].Cells[0].Value = "Номер людини в черзі";
            for (int i = 1; i <= n; i++)
            {
                dataGridKvitki.Rows[0].Cells[i].Style.Font = new Font("Tahoma", 20, FontStyle.Regular);
                dataGridKvitki.Rows[0].Cells[i].Style.ForeColor = Color.Coral;
                dataGridKvitki.Rows[0].Cells[i].Value = "" + i;
            }
            for (int i = 0; i <= 3; i++)
            {
                dataGridKvitki.Rows[i].Height = 50;
                dataGridKvitki.Rows[i].Cells[0].Style.Font = new Font("Tahoma", 12, FontStyle.Bold);
            }
            for (int j = 1; j <= n; j++)
            {
                dataGridKvitki[j, 1].Style.ForeColor = Color.Blue;
                dataGridKvitki.Rows[1].Cells[j].Style.Font = new Font("Tahoma", 20, FontStyle.Regular);
                dataGridKvitki.Rows[1].Cells[j].Value = "0";
                dataGridKvitki.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            for (int j = 1; j <= n; j++)
            {
                dataGridKvitki[j, 2].Style.ForeColor = Color.DarkViolet;
                dataGridKvitki.Rows[2].Cells[j].Style.Font = new Font("Tahoma", 20, FontStyle.Regular);
                dataGridKvitki.Rows[2].Cells[j].Value = "0";
            }
            for (int j = 1; j <= n; j++)
            {
                dataGridKvitki[j, 3].Style.ForeColor = Color.Brown;
                dataGridKvitki.Rows[3].Cells[j].Style.Font = new Font("Tahoma", 20, FontStyle.Regular);
                dataGridKvitki.Rows[3].Cells[j].Value = "0";
            }
            dataGridKvitki2.Width = dataGridKvitki.Width;
            dataGridKvitki2.Height = 45;
            dataGridKvitki2.RowCount = 1;
            dataGridKvitki2.Location = new Point(dataGridKvitki.Location.X, dataGridKvitki.Location.Y + dataGridKvitki.Height + 5);

            dataGridKvitki2.ColumnCount = n + 2;
            dataGridKvitki2[1, 0].Style.BackColor = Color.Aqua;
            dataGridKvitki2[2, 0].Style.BackColor = Color.Aqua;
            dataGridKvitki2[3, 0].Style.BackColor = Color.Aqua;
            dataGridKvitki2[1, 0].Style.Font = new Font("Tahoma", 18, FontStyle.Regular);
            dataGridKvitki2[2, 0].Style.Font = new Font("Tahoma", 18, FontStyle.Regular);
            dataGridKvitki2[3, 0].Style.Font = new Font("Tahoma", 18, FontStyle.Regular);
            dataGridKvitki2[0, 0].Style.Font = new Font("Tahoma", 20, FontStyle.Bold);
            dataGridKvitki2[1, 0].Value = 0 + "";
            dataGridKvitki2[2, 0].Value = "0";
            dataGridKvitki2[3, 0].Value = "0";
            dataGridKvitki2[0, 0].Value = "Масив динаміки:";
            dataGridKvitki.Columns[0].Width = 300;
            dataGridKvitki2.Rows[0].Height = 44;
            for (int i = 3; i <= n; i++)
            {
                dataGridKvitki2[i + 1, 0].Value = "0";
                dataGridKvitki2[i + 1, 0].Style.Font = new Font("Tahoma", 18, FontStyle.Regular);
                dataGridKvitki2[i + 1, 0].Style.BackColor = Color.Aqua;
            }
            dataGridKvitki2.AutoResizeColumns();
            listBoxKvitki.Size = new Size(listBoxKvitki.Width,dataGridKvitki.Height + 52);
            listBoxKvitki.Location = new Point(dataGridKvitki.Location.X + dataGridKvitki.Width+10,dataGridKvitki.Location.Y);
         //   this.Height = lblAnsKvitki.Location.Y + 110;
        }
        private void btnKvitkiVruch_Click(object sender, EventArgs e)
        {
            lblAnsKvitki.Show();
            listBoxKvitki.Show();
            lblAnsKvitki.Text = "Відповідь:";
            int n = Convert.ToInt32(txtNK.Text);
            dataGridKvitki2.ColumnCount = n + 2;
            listBoxKvitki.Items.Clear();
            listBoxKvitki.Items.Add("Для оптимізації часу:");
            int[] d = new int[n + 1];
            int[] a = new int[n + 1];
            int[] b = new int[n + 1];
            int[] c = new int[n + 1];
            dataGridKvitki.ColumnCount = n + 1;
            dataGridKvitki.Rows[1].Cells[0].Value = "Продаж одного білету";
            dataGridKvitki.Rows[2].Cells[0].Value = "Продаж двух білетів";
            dataGridKvitki.Rows[3].Cells[0].Value = "Продаж трьох білетів";
            dataGridKvitki.Rows[0].Cells[0].Value = "Номер людини в черзі";
            for (int i = 1; i <= n; i++)
            {
                //ans[i] = -1;
                dataGridKvitki.Rows[0].Cells[i].Style.Font = new Font("Tahoma", 24, FontStyle.Regular);
                dataGridKvitki.Rows[0].Cells[i].Style.ForeColor = Color.Coral;
                dataGridKvitki.Rows[0].Cells[i].Value = "" + i;

            }
            for (int i = 0; i <= 3; i++)
            {
                dataGridKvitki.Rows[i].Height = 50;
                dataGridKvitki.Rows[i].Cells[0].Style.Font = new Font("Tahoma", 14, FontStyle.Bold);
            }
            dataGridKvitki.Columns[0].Width = 450;
            for (int j = 1; j <= n; j++)
            {
                a[j] = Convert.ToInt32(dataGridKvitki.Rows[1].Cells[j].Value);
                dataGridKvitki[j, 1].Style.ForeColor = Color.Blue;
                dataGridKvitki.Rows[1].Cells[j].Style.Font = new Font("Tahoma", 20, FontStyle.Regular);
                dataGridKvitki.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            for (int j = 1; j <= n; j++)
            {
                b[j] = Convert.ToInt32(dataGridKvitki.Rows[2].Cells[j].Value);

                dataGridKvitki[j, 2].Style.ForeColor = Color.DarkViolet;
                dataGridKvitki.Rows[2].Cells[j].Style.Font = new Font("Tahoma", 20, FontStyle.Regular);
                dataGridKvitki.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            for (int j = 1; j <= n; j++)
            {
                c[j] = Convert.ToInt32(dataGridKvitki.Rows[3].Cells[j].Value);

                dataGridKvitki[j, 3].Style.ForeColor = Color.Brown;
                dataGridKvitki.Rows[3].Cells[j].Style.Font = new Font("Tahoma", 20, FontStyle.Regular);
                dataGridKvitki.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }


            d[0] = 0;
            d[1] = a[1];
            d[2] = Math.Min(a[1] + a[2], b[1]);
            string[] s = new string[n + 1];
            for (int i = 0; i <= n; i++)
                s[i] = "Нічого";
            s[1] = "a[1]";
            if (d[2] == a[1] + a[2])
            {
                s[2] = "a[1] + a[2]";
            }
            else
            {
                s[1] = "b[1]";
                s[2] = "b[1]";
            }
            dataGridKvitki2[1, 0].Value = 0 + "";
            dataGridKvitki2[2, 0].Value = d[1] + "";
            dataGridKvitki2[3, 0].Value = d[2] + "";
            for (int i = 3; i <= n; i++)
            {
                d[i] = Math.Min(d[i - 1] + a[i], Math.Min(d[i - 2] + b[i - 1], d[i - 3] + c[i - 2]));
                if (d[i] == d[i - 1] + a[i])
                {
                    s[i] = s[i - 1] + " + a[" + i + "]";
                }
                if (d[i] == d[i - 2] + b[i - 1])
                {
                    s[i] = s[i - 2] + " + b[" + (i - 1) + "]";

                }
                if (d[i] == d[i - 3] + c[i - 2])
                {
                    s[i] = s[i - 3] + " + c[" + (i - 2) + "]";
                }
                dataGridKvitki2[i + 1, 0].Value = d[i] + "";
                dataGridKvitki2[i + 1, 0].Style.Font = new Font("Tahoma", 18, FontStyle.Regular);
                dataGridKvitki2[i + 1, 0].Style.BackColor = Color.Aqua;
            }
            string[] u = new string[n + 1];
            u = s[n].Split('+');
            string t = "";
            int r = 0;
            foreach (string h in u)
            {
                t = h.Trim();
                switch (t[0])
                {
                    case 'a':
                        r++;
                        listBoxKvitki.Items.Add("Людина № " + r + " бере один білет");
                        break;
                    case 'b':
                        r++;
                        listBoxKvitki.Items.Add("Людина № " + r + " бере два білети");
                        r++;
                        break;
                    case 'c':
                        r++;
                        listBoxKvitki.Items.Add("Людина № " + r + " бере три білети");
                        r += 2;
                        break;
                    default:
                        break;

                }
            }

            dataGridKvitki2.Rows[0].Height = 44;
            dataGridKvitki2.AutoResizeColumns();
            dataGridKvitki.Columns[0].Width = 242;

            lblAnsKvitki.Location = new Point(dataGridKvitki2.Location.X, dataGridKvitki2.Location.Y + dataGridKvitki2.Height + 5);
        //    listBoxKvitki.Location = new Point(lblAnsKvitki.Location.X + 7, lblAnsKvitki.Location.Y + lblAnsKvitki.Height + 10);
            lblAnsKvitki.Text += " " + d[n];
            
        }
        private void btnKvitkiRandom_Click(object sender, EventArgs e)
        {
            Random z = new Random();
            lblAnsKvitki.Show();
            listBoxKvitki.Show();
            lblAnsKvitki.Text = "Відповідь:";
            int n = Convert.ToInt32(txtNK.Text);
            dataGridKvitki2.ColumnCount = n + 2;
            listBoxKvitki.Items.Clear();
            listBoxKvitki.Items.Add("Для оптимізації часу:");
            int[] d = new int[n + 1];
            int[] a = new int[n + 1];
            int[] b = new int[n + 1];
            int[] c = new int[n + 1];
            dataGridKvitki.ColumnCount = n + 1;
            dataGridKvitki.Rows[1].Cells[0].Value = "Продаж одного білету";
            dataGridKvitki.Rows[2].Cells[0].Value = "Продаж двух білетів";
            dataGridKvitki.Rows[3].Cells[0].Value = "Продаж трьох білетів";
            dataGridKvitki.Rows[0].Cells[0].Value = "Номер людини в черзі";
            for (int i = 1; i <= n; i++)
            {
                //ans[i] = -1;
                dataGridKvitki.Rows[0].Cells[i].Style.Font = new Font("Tahoma", 24, FontStyle.Regular);
                dataGridKvitki.Rows[0].Cells[i].Style.ForeColor = Color.Coral;
                dataGridKvitki.Rows[0].Cells[i].Value = "" + i;

            }
            for (int i = 0; i <= 3; i++)
            {
                dataGridKvitki.Rows[i].Height = 50;
                dataGridKvitki.Rows[i].Cells[0].Style.Font = new Font("Tahoma", 14, FontStyle.Bold);
            }
            for (int j = 1; j <= n; j++)
            {
                a[j] = z.Next(1, 60);
                dataGridKvitki[j, 1].Value = "" + a[j];
                dataGridKvitki[j, 1].Style.ForeColor = Color.Blue;
                dataGridKvitki.Rows[1].Cells[j].Style.Font = new Font("Tahoma", 20, FontStyle.Regular);
                dataGridKvitki.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            for (int j = 1; j <= n; j++)
            {
                b[j] = z.Next(a[j], 140);
                dataGridKvitki[j, 2].Value = "" + b[j];
                dataGridKvitki[j, 2].Style.ForeColor = Color.DarkViolet;
                dataGridKvitki.Rows[2].Cells[j].Style.Font = new Font("Tahoma", 20, FontStyle.Regular);
                dataGridKvitki.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            for (int j = 1; j <= n; j++)
            {
                c[j] = z.Next(b[j], 200);
                dataGridKvitki[j, 3].Value = "" + c[j];
                dataGridKvitki[j, 3].Style.ForeColor = Color.Brown;
                dataGridKvitki.Rows[3].Cells[j].Style.Font = new Font("Tahoma", 20, FontStyle.Regular);
                dataGridKvitki.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }


            d[0] = 0;
            d[1] = a[1];
            d[2] = Math.Min(a[1] + a[2], b[1]);
            string[] s = new string[n + 1];
            for (int i = 0; i <= n; i++)
                s[i] = "Нічого";
            s[1] = "a[1]";
            if (d[2] == a[1] + a[2])
            {
                s[2] = "a[1] + a[2]";
            }
            else
            {
                s[1] = "b[1]";
                s[2] = "b[1]";
            }
            dataGridKvitki2[1, 0].Value = 0 + "";
            dataGridKvitki2[2, 0].Value = d[1] + "";
            dataGridKvitki2[3, 0].Value = d[2] + "";
            for (int i = 3; i <= n; i++)
            {
                d[i] = Math.Min(d[i - 1] + a[i], Math.Min(d[i - 2] + b[i - 1], d[i - 3] + c[i - 2]));
                if (d[i] == d[i - 1] + a[i])
                {
                    s[i] = s[i - 1] + " + a[" + i + "]";
                }
                if (d[i] == d[i - 2] + b[i - 1])
                {
                    s[i] = s[i - 2] + " + b[" + (i - 1) + "]";

                }
                if (d[i] == d[i - 3] + c[i - 2])
                {
                    s[i] = s[i - 3] + " + c[" + (i - 2) + "]";
                }
                dataGridKvitki2[i + 1, 0].Value = d[i] + "";
                dataGridKvitki2[i + 1, 0].Style.Font = new Font("Tahoma", 18, FontStyle.Regular);
                dataGridKvitki2[i + 1, 0].Style.BackColor = Color.Aqua;
            }
            string[] u = new string[n + 1];
            u = s[n].Split('+');
            string t = "";
            int r = 0;
            foreach (string h in u)
            {
                t = h.Trim();
                switch (t[0])
                {
                    case 'a':
                        r++;
                        listBoxKvitki.Items.Add("Людина № " + r + " бере один білет");
                        break;
                    case 'b':
                        r++;
                        listBoxKvitki.Items.Add("Людина № " + r + " бере два білети");
                        r++;
                        break;
                    case 'c':
                        r++;
                        listBoxKvitki.Items.Add("Людина № " + r + " бере три білети");
                        r += 2;
                        break;
                    default:
                        break;

                }
            }

            dataGridKvitki2.Rows[0].Height = 44;
            dataGridKvitki2.AutoResizeColumns();
            dataGridKvitki.Columns[0].Width = 242;

            lblAnsKvitki.Location = new Point(dataGridKvitki2.Location.X, dataGridKvitki2.Location.Y + dataGridKvitki2.Height + 5);
            //listBoxKvitki.Location = new Point(lblAnsKvitki.Location.X + 7, lblAnsKvitki.Location.Y + lblAnsKvitki.Height + 10);
            lblAnsKvitki.Text += " " + d[n];
            
        }
        private void dataGridKvitki_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = Convert.ToInt32(txtNK.Text);
            for (int j = 1; j <= n; j++)
            {
                dataGridKvitki[j, 1].Style.ForeColor = Color.Blue;
                dataGridKvitki.Rows[1].Cells[j].Style.Font = new Font("Tahoma", 24, FontStyle.Regular);
                dataGridKvitki.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            for (int j = 1; j <= n; j++)
            {
                dataGridKvitki[j, 2].Style.ForeColor = Color.DarkViolet;
                dataGridKvitki.Rows[2].Cells[j].Style.Font = new Font("Tahoma", 24, FontStyle.Regular);

                dataGridKvitki.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            for (int j = 1; j <= n; j++)
            {
                dataGridKvitki[j, 3].Style.ForeColor = Color.Brown;
                dataGridKvitki.Rows[3].Cells[j].Style.Font = new Font("Tahoma", 24, FontStyle.Regular);

                dataGridKvitki.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            lblAnsKvitki.Location = new Point(dataGridKvitki.Location.X + dataGridKvitki.Width + 10, dataGridKvitki.Location.Y);
            listBoxKvitki.Location = new Point(lblAnsKvitki.Location.X + 7, lblAnsKvitki.Location.Y + lblAnsKvitki.Height + 10);
            
        }

        private void frmKvitki_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnKvitkiVruch_Click_1(object sender, EventArgs e)
        {
            btnKvitkiVruch_Click(new object(), new EventArgs());
        }

        private void btnKvitkiRandom_Click_1(object sender, EventArgs e)
        {
            btnKvitkiRandom_Click(new object(), new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSearchOptKilAndSum OptKS = new frmSearchOptKilAndSum();
            OptKS.Show();
            this.Hide();
        }
    }
}
