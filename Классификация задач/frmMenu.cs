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
    public partial class frmMenu : Form
    {
        frmDefinition definition;
        public frmMenu()
        {
            InitializeComponent();
            definition = new frmDefinition(this);
        }
     /*   //Переменные для panel0
        GroupBox groupBoxTasks = new GroupBox();// Создаю группу из кнопок, для удобства
        Button Buttonsequence = new Button();//Кнопка "Послідовності"
        Button Buttontheory = new Button(); //Кнопка "Теорія"
        Label lblName = new Label();// Надпись "Динамічне программування"
        Button ButtonDefinition = new Button();//Кнопка "Визначення"
        Button ButtonString = new Button(); // Кнопка "Рядки"
        Button ButtonOptimality = new Button(); // Кнопка "Пошук оптимального рішення"
        Button ButtonWays = new Button(); // Кнопка "Підрахунок кількості способів"*/
        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        public void panel0()
        {
            

            //   this.AutoScroll = false;

      /*      groupBoxTasks.Controls.Add(Buttonsequence);

            btnDefinition.Size = new Size(this.Width / 3, 50);
            btnDefinition.Text = "Визначення";
            btnDefinition.Font = new Font(FontFamily.GenericSansSerif, 21, FontStyle.Bold);
            btnDefinition.Location = new Point(this.Width / 2 - (btnDefinition.Width / 2), this.Height / 2 - (btnDefinition.Height / 2) * 5 - 105);
            p[0].Size = new Size(this.Width, this.Height);

            lblName.Size = new Size(600, 50);
            lblName.Text = "Динамічне програмування";
            lblName.Font = new Font(Name, 29, FontStyle.Regular);
            lblName.Location = new Point((this.Width / 2) - lblName.Size.Width / 2 + 50, btnDefinition.Location.Y - 98);



            Buttontheory.Location = new Point(btnDefinition.Location.X, btnDefinition.Location.Y + btnDefinition.Height + 20);
            Buttontheory.Size = btnDefinition.Size;
            Buttontheory.Text = "Теорія до задач";
            Buttontheory.Font = btnDefinition.Font;
            Buttontheory.Cursor = Cursors.Hand;

            //Описываем groupTasks (добавляем в него кнопки с задачами)
            groupBoxTasks.Controls.Add(Buttonsequence);
            groupBoxTasks.Controls.Add(ButtonString);
            groupBoxTasks.Controls.Add(ButtonOptimality);
            groupBoxTasks.Controls.Add(ButtonWays);
            groupBoxTasks.Font = new Font(Name, 20, FontStyle.Regular);
            groupBoxTasks.Size = new Size(2 * this.Width / 5, 400);
            groupBoxTasks.Location = new Point(btnDefinition.Location.X - 50, Buttontheory.Location.Y + Buttontheory.Height + 15);
            groupBoxTasks.ForeColor = Color.Black;
            groupBoxTasks.Text = "Задачі динамічного програмування";

            Buttonsequence.Size = new Size(btnDefinition.Width, btnDefinition.Height + 10);
            Buttonsequence.Location = new Point(50, 60);
            Buttonsequence.Text = "Послідовності";
            Buttonsequence.Font = new Font(FontFamily.GenericSansSerif, 21, FontStyle.Bold);

            ButtonString.Size = Buttonsequence.Size;
            ButtonString.Location = new Point(Buttonsequence.Location.X, Buttonsequence.Location.Y + Buttonsequence.Height + 10);
            ButtonString.Font = Buttonsequence.Font;
            ButtonString.Text = "Рядки";

            ButtonOptimality.Size = new Size(Buttonsequence.Width, Buttonsequence.Height + 20);
            ButtonOptimality.Location = new Point(Buttonsequence.Location.X, ButtonString.Location.Y + ButtonString.Height + 10);
            ButtonOptimality.Font = Buttonsequence.Font;
            ButtonOptimality.Text = "Пошук оптимального рішення";

            ButtonWays.Size = ButtonOptimality.Size;
            ButtonWays.Location = new Point(ButtonOptimality.Location.X, ButtonOptimality.Location.Y + ButtonOptimality.Height + 10);
            ButtonWays.Font = ButtonOptimality.Font;
            ButtonWays.Text = "Підрахунок кількості способів";*/
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDefinition_Click(object sender, EventArgs e)
        {
            try {
                definition.Show();
                this.Hide();
            }
            catch { }
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Begin.g == true)
            {
                e.Cancel = false;
                Application.Exit(null);

            }
            else
            {

                Begin b = new Begin();
                b.Show();
                this.Hide();
                e.Cancel = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!Begin.g)
            {
                frmSearchOptKilAndSum o = new frmSearchOptKilAndSum();
                o.Show();
                this.Hide();
            }
            else
                Application.Exit(null);
        }

        private void btnOptL_Click(object sender, EventArgs e)
        {
            frmWaySearch way = new frmWaySearch();
            way.Show();
            this.Hide();
        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            frmRecFormula rec = new frmRecFormula();
            rec.Show();
            this.Hide();
        }

        private void btnTheory_Click(object sender, EventArgs e)
        {
            Theory rh = new Theory();
            rh.Show();
            this.Hide();
        }
    }
}
