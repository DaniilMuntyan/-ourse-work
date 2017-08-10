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
    public partial class Mer1 : Form
    {
        Form1 frm1;
        public Mer1(Form1 frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;
        }
        Panel[] p2 = new Panel[20];
        ComboBox combo1 = new ComboBox();
        Button exit2 = new Button();
        string s;
        const int N = 6;
        string[] d = new string[N];

        private void combo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            s = combo1.Items[combo1.SelectedIndex].ToString();
        }

        private void Mer1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            p2[0] = new Panel();
            p2[0].Size = this.Size;
            p2[0].Location = new Point(0,0);
            d[0] = "Динамическое программирование: один параметр";
            d[1] = "Динамическое программирование с несколькими параметрами";
            exit2.Size = new Size(120,60);
            exit2.Font = new Font(Name,13,FontStyle.Regular);
            exit2.Location = new Point(this.Width-150,10);
            exit2.Text = "Вернуться в меню";
            exit2.MouseClick += exit2_Click;
            /*  d[2] = "Платная лестница";
              d[3] = "Покупка билетов";
              d[4] = "Гвоздики";*/
            combo1.Size = new Size(this.Width - 170, this.Height);
            combo1.Location = new Point(10, 10);
            combo1.Items.Add(d[0]);
            /*combo1.Items.Add("Задача о черепашке");
            combo1.Items.Add("Платная лестница");
            combo1.Items.Add("Покупка билетов");
            combo1.Items.Add("Гвоздики");*/
            combo1.SelectedIndex = 0;
            s = combo1.Items[combo1.SelectedIndex].ToString();
            combo1.SelectedIndexChanged += combo1_SelectedIndexChanged;
            p2[0].Controls.Add(combo1);
            p2[0].Controls.Add(exit2);
            this.Controls.Add(p2[0]);
        }
        private void exit2_Click(object sender, EventArgs e)
        {
            frm1.Show();
            this.Hide();
        }

        private void Mer1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
