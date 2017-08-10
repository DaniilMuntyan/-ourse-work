using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Классификация_задач
{
    public partial class Form1 : Form
    {
        TheoryOfKnapsack theoryKnapsack;
        TheoryOfPodstroka theoryPodstroka;
        TheoryOfKvitki theoryKvitki;
        Mer1 mer1;
        TheoryOfHorse theoryHorse;
        CodeOfPodPosl codePodPosl;
        Begin bg;
        TheoryPodPosl theoryPodPosl;
        TheoryOfPodpalindrom theoryPodPalindrom;
        Theory t;
        public Form1(Begin bg)
        {
            InitializeComponent();
            theoryKnapsack = new TheoryOfKnapsack(this);
            mer1 = new Mer1(this);
            theoryKvitki = new TheoryOfKvitki(this);
            theoryPodPalindrom = new TheoryOfPodpalindrom(this);
            theoryPodPosl = new TheoryPodPosl(this);
            theoryHorse = new TheoryOfHorse(this);
           codePodPosl = new CodeOfPodPosl(this);
            this.bg = bg;
            theoryPodstroka = new TheoryOfPodstroka(this);
        }
        #region Вeclaration of variables (Объявление переменных)
        public int End;
        Panel[] p = new Panel[20]; //Массив панелей, которые буду использовать в качестве "страниц" программы.
        Panel PenlDefinition = new Panel();
        Size thisSize = new Size();
        float x, y;
        int time = 0;
        int ExitPanel; //Переменная, в которой мы будем хранить номер панели, которые будем скрывать
        Button exit = new Button();

        //Переменные для panel0
        GroupBox groupBoxTasks = new GroupBox();// Создаю группу из кнопок, для удобства
        Button Buttonsequence = new Button();//Кнопка "Послідовності"
        Button Buttontheory = new Button(); //Кнопка "Теорія"
        Label lblName = new Label();// Надпись "Динамічне программування"
        Button ButtonDefinition = new Button();//Кнопка "Визначення"
        Button ButtonString = new Button(); // Кнопка "Рядки"
        Button ButtonOptimality = new Button(); // Кнопка "Пошук оптимального рішення"
        Button ButtonWays = new Button(); // Кнопка "Підрахунок кількості способів"

        //Переменные для panel1
        Label LabelDifinition = new Label();//Само определение
        Label LabelCentral = new Label(); //Виды пересчета
        PictureBox pictureBackground1 = new PictureBox(); //Фон страницы "Визначення"
        PictureBox straightPicture = new PictureBox(); //Картинка с прямым порядком пересчёта
        PictureBox backPicture = new PictureBox(); //Картинка с обратным порядком пересчёта
        PictureBox lazyPicture = new PictureBox(); //Картинка с ленивым порядком
        Button CodeOfstraight = new Button(); //Кнопка, показывает код прямого порядка
        Button straightButton = new Button(); //Кнопка, которая вызывает решение числа Фибоначчи с помощью прямого порядка
        Button backButton = new Button(); //Кнопка вызывает Фибоначчи с помощью обратного порядка
        Button lazyButton = new Button(); //Кнопка вызывает Фибоначчи с помощью ленивой динамики 
        Button check = new Button(); // Кнопка вызова програми проверки чисел Фибоначчи

        //Переменные для panel2
        bool once2 = false;
        ComboBox cmbTasksPanel2 = new ComboBox();
        Panel[] Panel2Tasks = new Panel[20]; //Панели, которые будут отображать решения задач "Послідовності"
        int countPanel2; //В этой переменной будет номер "дочерней" панели, которую нужно закрыть, при открытии следующей
        TextBox txtN = new TextBox();
        Label lblPanelTasks0 = new Label();
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

        //Переменные для panel3
        ComboBox cmbTasksPanel3 = new ComboBox();
        Panel[] Panel3Tasks = new Panel[20]; // Панели, которые буду отображать решение задач на "Рядки"
        int countPanel3;  //В этой переменной будет номер "дочерней" панели, которую нужно закрыть, при открытии следующей (Используется при изменении в ComboBox())
      

        //Переменные для panel4
        ComboBox cmbTasksPanel4 = new ComboBox();
        Panel[] Panel4Tasks = new Panel[6]; //Панели с решениями задач на оптимальность
        int countPanel4; //В этой переменной будет номер "дочерней" панели, которую нужно закрыть, при открытии следующей (Используется при изменении в ComboBox())
        Label umova = new Label();
        Label lblMKnapsack = new Label();
        Label lblNKnapsack = new Label();
        TextBox txtNKnapsack = new TextBox();
        TextBox txtMKnapsack = new TextBox();
        Label lblMasD = new Label();
        List<int> ans = new List<int> { };

        //Переменные для panel5
        ComboBox cmbTasksPanel5 = new ComboBox();
        Panel[] Panel5Tasks = new Panel[6]; //Панели с решениями задач на оптимальность
        int countPanel5; //В этой переменной будет номер "дочерней" панели, которую нужно закрыть, при открытии следующей (Используется при изменении в ComboBox())



        #endregion

        #region Panel-Menu
        public void  panel0()
        {
           
            p[0] = new Panel();

         //   this.AutoScroll = false;

            groupBoxTasks.Controls.Add(Buttonsequence);

            ButtonDefinition.Size = new Size(this.Width/3, 50);
            ButtonDefinition.Text = "Визначення";
            ButtonDefinition.Font = new Font(FontFamily.GenericSansSerif,21,FontStyle.Bold);
            ButtonDefinition.Location = new Point(this.Width / 2 - (ButtonDefinition.Width / 2), this.Height / 2 - (ButtonDefinition.Height / 2)*5 - 105);
            p[0].Size = new Size(this.Width,this.Height);

            lblName.Size = new Size(600,50);
            lblName.Text = "Динамічне програмування";
            lblName.Font = new Font(Name, 29, FontStyle.Regular);
            lblName.Location = new Point((this.Width / 2) - lblName.Size.Width/2 + 50, ButtonDefinition.Location.Y - 98);



            Buttontheory.Location = new Point(ButtonDefinition.Location.X, ButtonDefinition.Location.Y + ButtonDefinition.Height + 20);
            Buttontheory.Size = ButtonDefinition.Size;
            Buttontheory.Text = "Теорія до задач";
            Buttontheory.Font = ButtonDefinition.Font;
            Buttontheory.Cursor = Cursors.Hand;
            Buttontheory.Click += Click_Theory;

            //Описываем groupTasks (добавляем в него кнопки с задачами)
            groupBoxTasks.Controls.Add(Buttonsequence);
            groupBoxTasks.Controls.Add(ButtonString);
            groupBoxTasks.Controls.Add(ButtonOptimality);
            groupBoxTasks.Controls.Add(ButtonWays);
            groupBoxTasks.Font = new Font(Name,20,FontStyle.Regular);
            groupBoxTasks.Size = new Size(2*this.Width/5, 400);
            groupBoxTasks.Location = new Point(ButtonDefinition.Location.X - 50, Buttontheory.Location.Y + Buttontheory.Height + 15);
            groupBoxTasks.ForeColor = Color.Black;
            groupBoxTasks.Text = "Задачі динамічного програмування";

            Buttonsequence.Size = new Size(ButtonDefinition.Width, ButtonDefinition.Height + 10);
            Buttonsequence.Location = new Point(50, 60);
            Buttonsequence.Text = "Послідовності";
            Buttonsequence.Font = new Font(FontFamily.GenericSansSerif, 21, FontStyle.Bold);
            Buttonsequence.Click += sequenceClick;
            
            ButtonString.Size = Buttonsequence.Size;
            ButtonString.Location = new Point(Buttonsequence.Location.X, Buttonsequence.Location.Y + Buttonsequence.Height + 10);
            ButtonString.Font = Buttonsequence.Font;
            ButtonString.Text = "Рядки";
            ButtonString.Click += stringClick;

            ButtonOptimality.Size = new Size(Buttonsequence.Width,Buttonsequence.Height + 20);
            ButtonOptimality.Location = new Point(Buttonsequence.Location.X, ButtonString.Location.Y + ButtonString.Height + 10);
            ButtonOptimality.Font = Buttonsequence.Font;
            ButtonOptimality.Text = "Пошук оптимального рішення";
            ButtonOptimality.Click += optimalityClick;

            ButtonWays.Size = ButtonOptimality.Size;
            ButtonWays.Location = new Point(ButtonOptimality.Location.X, ButtonOptimality.Location.Y + ButtonOptimality.Height + 10);
            ButtonWays.Font = ButtonOptimality.Font;
            ButtonWays.Text = "Підрахунок кількості способів";
            ButtonWays.Click += waysClick;

            p[0].Controls.Add(ButtonDefinition);
            p[0].Controls.Add(Buttontheory);
            p[0].Controls.Add(lblName);
            p[0].Controls.Add(groupBoxTasks);
            ButtonDefinition.MouseClick += ButtonDefinition_Click;
            this.Controls.Add(p[0]);
        }
        private void Click_Theory(object sender, EventArgs e)
        {
            t.Show();
        }
        private void stringClick(object sender, EventArgs e)
        {
            panel3();
        }
        private void sequenceClick(object sender, EventArgs e)
        {
            panel2();
        }
        private void optimalityClick(object sender, EventArgs e)
        {
            panel4();
        }
        private void waysClick(object sender, EventArgs e)
        {
            panel5();
        }
        #endregion

        #region Panel-difinition
        int c = 0;
        private void panel1()
        {
            p[0].Hide();

            //Настраиваем панель1
            p[1] = new Panel();
            p[1].Size = new Size(this.Width - 10, this.Height + 470);
            //   p[1].AutoScroll = true;


            exit.Size = new Size(70, 70);
            exit.Location = new Point(this.Width - exit.Width - 35, 60);
            exit.BackgroundImage = Image.FromFile("back2.png");
            exit.BackgroundImageLayout = ImageLayout.Stretch;
            ExitPanel = 1;
            exit.Click += exit_Click;

            pictureBackground1.Image = Image.FromFile("ФонОпределение2.jpg");
            pictureBackground1.Size = p[1].Size;
            pictureBackground1.SizeMode = PictureBoxSizeMode.StretchImage;

            LabelDifinition.AutoSize = true;
            LabelDifinition.Parent = pictureBackground1;
            LabelDifinition.BackColor = Color.Transparent;
            LabelDifinition.Text =
"Динамічне програмування — розділ математики, який присвячено теорії і " +
"методам розв'язання багатокрокових задач оптимального управління.";
            LabelDifinition.Font = new Font(FontFamily.GenericSerif, 22, FontStyle.Italic);
            LabelDifinition.Location = new Point(20, 8);
            LabelDifinition.MaximumSize = new Size(this.Width - 35, 100);
            LabelDifinition.ForeColor = Color.White;

            LabelCentral.AutoSize = true;
            LabelCentral.Text =
"Щоб успішно вирішити задачу динамічного програмування, потрібно:\n1) Стан динаміки: параметр(и), які однозначно задають стан дінаміки\n" +
"2) Початкові значення\n3) Переходи між станами: формула\n4) Порядок перерахунку" +
"\n5) Відповіть на завдання: це може бути сума, або, наприклад, максимум із значень кількох станів" +
"\nІснує три порядки перерахунку (За приклад візьмемо обчислення чисел Фібоначчі, параметр: номер числа):\n1) Прямий порядок: наступні значення послідовно перераховуються виходячі з уже порахованих";
            LabelCentral.Font = new Font(FontFamily.GenericSerif, 18, FontStyle.Bold);
            LabelCentral.Location = new Point(LabelDifinition.Location.X, LabelDifinition.Location.Y + LabelDifinition.Height + 6);
            LabelCentral.Parent = pictureBackground1;
            LabelCentral.BackColor = Color.Transparent;
            LabelCentral.ForeColor = Color.White;
            LabelCentral.MaximumSize = new Size(this.Width - 35, 2000);

            straightPicture.Size = new Size(180, 90);
            straightPicture.Location = new Point(LabelCentral.Location.X, LabelCentral.Location.Y + LabelCentral.Height + 7);
            straightPicture.BackgroundImage = Image.FromFile("Прямой порядок пересчета.png");
            straightPicture.BackgroundImageLayout = ImageLayout.Stretch;

            /* LabelCentral.Text += 
 "                           " + "За приклад візьмемо обчислення чисел Фібоначчі. Параметр: номер числа";*/
            CodeOfstraight.Location = new Point(straightPicture.Location.X + straightPicture.Width + 20, straightPicture.Location.Y + (straightPicture.Height / 2) - 20);
            CodeOfstraight.Size = new Size(150, 40);
            CodeOfstraight.Text = "Показати код";
            CodeOfstraight.Click += CodeStraightfib;

            // this.AutoScroll = true;
            LabelCentral.Text += "\n\n\n\n\n2) Зворотній порядок: перераховують всі стани, залежні від поточного";

            backPicture.BackgroundImage = Image.FromFile("Обратный порядок пересчета.png");
            backPicture.BackgroundImageLayout = ImageLayout.Stretch;
            backPicture.Size = straightPicture.Size;
            backPicture.Location = new Point(LabelCentral.Left, (LabelCentral.Location.Y + LabelCentral.Height + 5));

            backButton.Location = new Point(backPicture.Location.X + backPicture.Width + 20, backPicture.Location.Y + (backPicture.Height / 2) - 20);
            backButton.Text = "Показати код";
            backButton.Size = CodeOfstraight.Size;
            backButton.Click += CodeBackfib;
          

            LabelCentral.Text +=
"\n\n\n\n\n3) Лінива динаміка: рекурсивна функція перерахунку динаміки, дуже схоже на пошук у глибину по ациклічному графу станів, де ребра - це залежність між ними";

            lazyPicture.BackgroundImageLayout = ImageLayout.Stretch;
            lazyPicture.BackgroundImage = Image.FromFile("Ленивая динамика.png");
            lazyPicture.Size = backPicture.Size;
            lazyPicture.Location = new Point(backPicture.Location.X, LabelCentral.Location.Y + LabelCentral.Height + 10);

            lazyButton.Size = backButton.Size;
            lazyButton.Location = new Point(backButton.Location.X, lazyPicture.Top + lazyPicture.Height / 2 - 20);
            lazyButton.Text = "Показати код";
            lazyButton.Click += CodeLazyfib;

            check.Size = new Size(280, 70);
            check.Font = new Font(Name, 18, FontStyle.Bold);
            check.Text = "Перевірити роботу трьох порядків";
            check.Click += buttonCheck;
            check.Location = new Point(this.Width * 3 / 4, this.Height - check.Height - 60);

            p[1].Controls.Add(check);
            p[1].Controls.Add(lazyButton);
            p[1].Controls.Add(lazyPicture);
            p[1].Controls.Add(backPicture);
            p[1].Controls.Add(CodeOfstraight);
            p[1].Controls.Add(backButton);
            p[1].Controls.Add(straightPicture);
            p[1].Controls.Add(exit);
            p[1].Controls.Add(pictureBackground1);
            this.Controls.Add(p[1]);
        }
        //Код прямого порядка
        private void CodeStraightfib(object sender, EventArgs e) // ТУТ ЗАЦИКЛИВАНИЕ!
        {
            c++;
            string s = "";
            s = "f[1] = 1; //Початкові значення\nf[2] = 1; //Початкові значення\n" +
"for(int i = 3; i <= n; i++)\nf[i] = f[i-1] + f[i-2]; // Перерахунок стану i. У даному випадку n задається, f - масив чисел Фібоначі";
            if (c == 1)
            {
                MessageBox.Show(s, c + " Код програми обчислення чисел Фібоначчі");
                c = 0;
            }
        }
        //Код обратного порядка
        private void CodeBackfib(object sender, EventArgs e) // ТУТ ЗАЦИКЛИВАНИЕ!
        {
            string s =
"f[1] = 1 // Початкові значення\nfor(i = 1; i < n;i++)\n{\n    f[i+1] += f[i]; // Оновлення стану i+1\n    f[i+2] += f[i] // оновлення стану i+2\n}";
            c++;
            if (c == 1)
            {
                MessageBox.Show(s, "Код програми обчислення чисел Фібоначчі");
                c = 0;
            }
        }
        //Код ленивой динамики
        private void CodeLazyfib(object sender, EventArgs e) // ТУТ ЗАЦИКЛИВАНИЕ!
        {
            string s =
"void  get_fib(i)\n{\n    if(i <= 2) // Початкові значення\n        return 1;\n    if(f[i]!=-1)" +
" // Лінивість\n        return f[i];\n    f[i] = get_fib(i-1) + get_fib(i-2) // Перерахунок\n    return f[i];";
            c++;
            if (c == 1)
            {
                MessageBox.Show(s, "Код програми обчислення чисел Фібоначчі");
                c = 0;
            }
        }
        private void buttonCheck(object sender, EventArgs e)
        {
            mer1.Show();
        }
        private void fib(object sender, EventArgs e)
        {
            mer1.Show();
        }

        #endregion

        #region panelSequence(Послідовності)
        private void panel2()
        {
            p[2] = new Panel();
            p[0].Hide();
            
            p[2].Size = this.Size;
            p[2].Location = new Point(0,0);

            exit.Size = new Size(70, 70);
            exit.Location = new Point(this.Width - exit.Width - 50, 10);
            exit.BackgroundImage = Image.FromFile("back2.png");
            exit.BackgroundImageLayout = ImageLayout.Stretch;
            ExitPanel = 2;
            exit.Click += exit_Click;

            cmbTasksPanel2.Size = new Size(this.Width - 150,5);
            cmbTasksPanel2.Location = new Point(5, exit.Location.Y);
            cmbTasksPanel2.SelectedIndexChanged += changed;
            isfirst = 0;
            comboboxPanel2();
            isfirst = 0;

            p[2].Controls.Add(cmbTasksPanel2);
            p[2].Controls.Add(exit);
            this.Controls.Add(p[2]);
        }
        private void comboboxPanel2()
        {
            
            if (!once2)
            {
                cmbTasksPanel2.Items.Add("Три одиниці");
                cmbTasksPanel2.Items.Add("Найбільша зростаюча підпослідовність");
            }
                Panel2Tasks[0] = new Panel();
                Panel2Tasks[0].Size = new Size(this.Width, this.Height - (exit.Bottom + 30));
                Panel2Tasks[0].Location = new Point(0, exit.Bottom + 10);
                for (int i = 0; i < 6; i++) // Пишем цикл, чтобы сразу проинициализировать все панели с решенными задачами "Послідовності"
                {
                    Panel2Tasks[i] = new Panel();
                    Panel2Tasks[i].Size = new Size(this.Width, this.Height - (exit.Bottom + 30));
                    Panel2Tasks[i].Location = new Point(0, exit.Bottom + 10);
                    p[2].Controls.Add(Panel2Tasks[i]);
                    Panel2Tasks[i].Hide();
                }

                isfirst = 0;
                cmbTasksPanel2.SelectedIndex = 0;
                PanelTasks0();
                countPanel2 = 0;
                once2 = true;
                changed(new object(), new EventArgs());
        }
        private void changed(object sender, EventArgs e) // В этом методе будем проверять, какая задача выбрана, и будем выводить соответствующюю информацию
        {
            Panel2Tasks[countPanel2].Hide();
            Panel2Tasks[cmbTasksPanel2.SelectedIndex].Show();
            countPanel2 = cmbTasksPanel2.SelectedIndex;
            isfirst = 0;
            if (cmbTasksPanel2.SelectedIndex == 0)
                PanelTasks0();
            if (cmbTasksPanel2.SelectedIndex == 1)
                PanelTasks1();
        }
        private void PanelTasks0() // Метод, в котором обрабатываем PanelTasks[0] (Три единицы)
        {
            UsloviyThreeOne.Show();
            lblPanelTasks0 = UsloviyThreeOne;
            lblPanelTasks0.Size = new Size(this.Width -30, this.Height-cmbTasksPanel2.Location.Y - cmbTasksPanel2.Height);
            lblPanelTasks0.Location = new Point(0, cmbTasksPanel2.Location.Y - 10);

            ТриЕдин.Show();
            solutionPT0 = ТриЕдин;
            solutionPT0.Size = new Size(this.Width - 30, this.Height);
            solutionPT0.Location = new Point(lblPanelTasks0.Location.X, lblPanelTasks0.Location.Y + 90);

            threeE.Size = new Size(510,70);
            threeE.Location = new Point(solutionPT0.Location.X, solutionPT0.Location.Y + 350);
            threeE.Image = Image.FromFile("Три единицы.jpg");

            threeE2.Image = Image.FromFile("Три единицы2.jpg");
            threeE2.Location = new Point(threeE.Location.X + threeE.Width, threeE.Location.Y);
            threeE2.Size = new Size(250,70);

            lblN.Size = new Size(80,40);
            lblN.Font = new Font(Name,23,FontStyle.Regular);
            lblN.Text = "N = ";
            lblN.Location = new Point(threeE2.Location.X + threeE2.Width + 90, threeE2.Location.Y);

            txtN.Location = new Point(lblN.Location.X + lblN.Width, lblN.Location.Y + 5);
            txtN.Text = "10";

            btnAnsPT0.Size = new Size(155,50);
            btnAnsPT0.Location = new Point(txtN.Location.X + txtN.Width + 100, txtN.Location.Y - 20);
            btnAnsPT0.Font = new Font(Name,18,FontStyle.Regular);
            btnAnsPT0.Text = "Обчислити";
            btnAnsPT0.Click += btnAnsPT0_Click;

            btnCodePT0.Size = btnAnsPT0.Size;
            btnCodePT0.Location = new Point(btnAnsPT0.Location.X, btnAnsPT0.Location.Y + btnAnsPT0.Height+10);
            btnCodePT0.Font = btnAnsPT0.Font;
            btnCodePT0.Text = "Код";
            isfirst = 0;
            btnCodePT0.Click += btnCodePT0_Click;

            ansPT0.Font = new Font(Name, 20, FontStyle.Italic);
            ansPT0.Location = new Point(threeE.Location.X, threeE.Location.Y + threeE.Height+10);
            ansPT0.Size = new Size(this.Width - ansPT0.Location.X, this.Height);

            Panel2Tasks[0].Controls.Add(btnCodePT0);
            Panel2Tasks[0].Controls.Add(ansPT0);
            Panel2Tasks[0].Controls.Add(btnAnsPT0);
            Panel2Tasks[0].Controls.Add(txtN);
            Panel2Tasks[0].Controls.Add(lblN);
            Panel2Tasks[0].Controls.Add(threeE);
            Panel2Tasks[0].Controls.Add(threeE2);
            Panel2Tasks[0].Controls.Add(solutionPT0);
            Panel2Tasks[0].Controls.Add(lblPanelTasks0);
        }
        private void PanelTasks1() //Метод, в котором обрабатывается PanelTasks[1] (Наибольшая подпоследовательность)
        {
            lblPnPodsk2.Show();
            btnCodePodPosl.Show();
            lblPnPodsk1.Show();
            GridViewPod.Hide();
            panelPodskazka1.Show();
            panelPodskazka2.Show();
            btnTheoryPodPosl.Show();
            Label lblСondition = new Label(); //Надпись условие (Найбільша підпослідовність)
            vypadlovoPT1.Show(); // Кнопка "Випадково"
            vlasnoruchPT1.Show();
            txtPodN.Show();
            lblPodN.Show();


            Panel2Tasks[1].Size = Panel2Tasks[0].Size;
            Panel2Tasks[1].Location = Panel2Tasks[0].Location;

            UsloviyPodPosl.Show();
            lblСondition = UsloviyPodPosl;
            lblСondition.Location = new Point(0,exit.Location.Y);
            lblСondition.Size = new Size(this.Width - 30,130);
            
            solutionPT1.Location = new Point(0,lblСondition.Location.Y + lblСondition.Height);
            solutionPT1.Size = solutionPT0.Size;

            lblPodN.Location = new Point(cmbTasksPanel2.Location.X, solutionPT1.Location.Y +  50);
            txtPodN.Location = new Point(lblPodN.Location.X + 80, lblPodN.Location.Y + 7);
            txtPodN.Text = "6";

            vypadlovoPT1.Location = new Point(txtPodN.Location.X + txtPodN.Width + 50, txtPodN.Location.Y - 30);//Кнопка "випалдково" заповнити

            vlasnoruchPT1.Location = new Point(txtPodN.Location.X + txtPodN.Width+ vlasnoruchPT1.Width + 100, vypadlovoPT1.Location.Y);

            lblAnsPodPosl.Size = new Size(this.Width,100);

            //Панели для разъяснения цветов в последовательности
            panelPodskazka1.BackColor = Color.Red; //Красный цвет - те, которые не входят в наибольшую общую подпоследовательность
            panelPodskazka2.BackColor = Color.Blue; //Синий цвет - которые входят
            panelPodskazka1.Location = new Point(10, Panel2Tasks[1].Height - panelPodskazka1.Height - 40);
            lblPnPodsk1.Location = new Point(panelPodskazka1.Width + 10, panelPodskazka1.Location.Y);
            lblPnPodsk1.Size = new Size(400,80);
            panelPodskazka2.Location = new Point(500, Panel2Tasks[1].Height - panelPodskazka1.Height - 40);
            lblPnPodsk2.Location = new Point(panelPodskazka2.Width + panelPodskazka2.Location.X + 10, panelPodskazka2.Location.Y);
            lblPnPodsk2.Size = lblPnPodsk1.Size;

            
            btnTheoryPodPosl.Location = new Point(Panel2Tasks[1].Width - btnTheoryPodPosl.Width - 70, panelPodskazka2.Location.Y);
            btnCodePodPosl.Location = new Point(btnTheoryPodPosl.Location.X, btnTheoryPodPosl.Location.Y - btnCodePodPosl.Height);

            Panel2Tasks[1].Controls.Add(btnCodePodPosl);
            Panel2Tasks[1].Controls.Add(lblPnPodsk1);
            Panel2Tasks[1].Controls.Add(lblPnPodsk2);
            Panel2Tasks[1].Controls.Add(btnTheoryPodPosl);
            Panel2Tasks[1].Controls.Add(panelPodskazka1);
            Panel2Tasks[1].Controls.Add(panelPodskazka2);
            Panel2Tasks[1].Controls.Add(lblСondition);
            Panel2Tasks[1].Controls.Add(vlasnoruchPT1);
            Panel2Tasks[1].Controls.Add(vypadlovoPT1); // Кнопка "Випадково"
            Panel2Tasks[1].Controls.Add(txtPodN);
            Panel2Tasks[1].Controls.Add(lblPodN);
            Panel2Tasks[1].Controls.Add(GridViewPod);
            Panel2Tasks[1].Controls.Add(lblAnsPodPosl);
            Panel2Tasks[1].Controls.Add(solutionPT1);
        }
        private void resultPodPosl(int N) // В этом методе мы реализуем алгоритм нахождения наибольшей подпоследовательности
        {
            List<int> path = new List<int> { };
            path.Clear();
            string s; // Строка, которая будет содержать ответ на задачу наибольшей подпоследовательности
            int ans = 0;
            
            for(int i = 0; i < N; i++)
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
                       /* else
                            w[i] = 1;*/
                    }
                }
            }
            ans = d[0];
            int pos = 0, y = 0;
            for (int i = 0; i < N; ++i)
                if (d[i] > ans)
                {
                    ans = /*Math.Max(ans,d[i])*/d[i];
                    pos = i;
                }

            //lblAnsPodPosl.Text = "Довжина найбільшої підпослідовності: " + ans;
            
            while(pos!=-1)
            {
                path.Add(pos);
                pos = w[pos];
                y++;
            }
            path.Reverse();
            lblAnsPodPosl.Text = "Довжина найбільшої підпослідовності: " + /*path.Count*/ans;
            lblAnsPodPosl.Text += "\nЕлементи цієї підмножини:  ";
            for(int i = 0; i < (int)path.Count;i++)
            {
                lblAnsPodPosl.Text += a[path[i]] + " ";
                GridViewPod.Rows[0].Cells[path[i]].Style.BackColor = Color.Blue;
            }
           /* for (int i = 0; i < y; i++)
            {
                lblAnsPodPosl.Text += a[path[i]] + "  ";
                GridViewPod.Rows[0].Cells[path[i]].Style.BackColor = Color.Blue;
            }*/
            for (int i = 0; i < N; i++)
            {
                if (GridViewPod.Rows[0].Cells[i].Style.BackColor != Color.Blue)
                {
                    GridViewPod.Rows[0].Cells[i].Style.BackColor = Color.Red;
                    GridViewPod.Rows[0].Cells[i].Style.ForeColor = Color.White;
                }

            }
        }
        private void searchPod_Click(object sender, EventArgs e) // Клик на Рандомно заполнить
        {
            Random z = new Random();
            GridViewPod.Rows.Clear();
            GridViewPod.Columns.Clear();
            int N = 0;
            try {
                N = Convert.ToInt32(txtPodN.Text);

                GridViewPod.Enabled = true;
                GridViewPod.Show();
                lblAnsPodPosl.Show();
                GridViewPod.Location = new Point(lblPodN.Location.X, lblPodN.Location.Y + 100);
                GridViewPod.ColumnCount = N;
                GridViewPod.Rows[0].Height = 100;
                GridViewPod.Size = new Size(500, 97);
                for (int i = 0; i < N; i++)
                {
                    GridViewPod.Columns[i].Width = 100;
                    GridViewPod.Rows[0].Cells[i].Value = z.Next(-200, 200) + "";
                    a[i] = Convert.ToInt32(GridViewPod.Rows[0].Cells[i].Value);
                    GridViewPod.Rows[0].Cells[i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    GridViewPod.Rows[0].Cells[i].Style.Font = new Font("Tahoma", 24, FontStyle.Bold);
                }
                if (N < 13)
                {
                    GridViewPod.Width = N * 101;

                    GridViewPod.Enabled = false;// Не даем пользователю вписать вручную
                }
                else
                {
                    GridViewPod.Width = this.Width - GridViewPod.Location.X - 50;
                    GridViewPod.Height += 20;
                }
                lblAnsPodPosl.Location = new Point(0, GridViewPod.Location.Y + 115);
                resultPodPosl(N);
            }
            catch
            {
                MessageBox.Show("Неврне N", "Введіть вірне N");
            }
        }
        private void vlasnoruchPT1_Click(object sender, EventArgs e) // Клик вручную заполнить
        {
            GridViewPod.Rows.Clear();
            GridViewPod.Columns.Clear();
            int N;
            try {
                N = Convert.ToInt32(txtPodN.Text);
                GridViewPod.Enabled = true;
                GridViewPod.Show();
                lblAnsPodPosl.Show();

                GridViewPod.Location = new Point(lblPodN.Location.X, lblPodN.Location.Y + 100);
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
                    }else
                    a[i] = Convert.ToInt32(GridViewPod.Rows[0].Cells[i].Value);
                    if (a[i] > 999)
                        GridViewPod.Columns[i].Width = 110;
                    else
                        GridViewPod.Columns[i].Width = 100;
                    GridViewPod.Rows[0].Cells[i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    GridViewPod.Rows[0].Cells[i].Style.Font = new Font("Tahoma", 24, FontStyle.Bold);
                }
                if (N < 16)
                {
                    GridViewPod.Width = N * 101;
                    GridViewPod.Enabled = false; // Не даем пользователю вписать вручную

                }
                else
                {
                    GridViewPod.Width = this.Width - GridViewPod.Location.X - 50;
                    GridViewPod.Height += 20;
                }
                lblAnsPodPosl.Location = new Point(0, GridViewPod.Location.Y + 115);
                resultPodPosl(N);
            }
            catch
            {
                MessageBox.Show("Невірне N", "Введіть вірне N");
            }
        }
        private void btnTheoryPodPosl_Click(object sender, EventArgs e)
        {
            theoryPodPosl.Show();
        } // Клик на теорию Наибольшей Подпоследовательности
        private void btnCodePT0_Click(object sender, EventArgs e)
        {
            if (isfirst == 2)
            {
                string s = "int[] f = new int[N];\nint i;\nf[1] = 2;\nf[2] = 4;\nf[3] = 7;\n" +
    "for(i = 4; i <= N; i++)\n{\n    f[i] = f[i-1] + f[i-2] + f[i-3];\n}";
                MessageBox.Show(s, "Код три одиниці");
                isfirst = 0;
            }
            else
            {
                isfirst++;
            }
        } //Проблема: зацикливается событие
        private void btnAnsPT0_Click(object sender, EventArgs e) // Клик на вычисление Фиббоначчи
        {
            ansPT0.Text = "";
            int N = 0;
            try
            {
                
                N = Convert.ToInt32(txtN.Text);
                int[] f = new int[N + 1];
                switch (N)
                {
                    case 1:
                        ansPT0.Text = "Відповідь: 2";
                        break;

                    case 2:
                        ansPT0.Text = "Відповідь: 4";
                        break;

                    case 3:
                        ansPT0.Text = "Відповідь: 7";
                        break;

                    default:
                        f[0] = 2;
                        f[1] = 4;
                        f[2] = 7;
                        for (int i = 3; i < N; i++)
                        {
                            f[i] = f[i - 1] + f[i - 2] + f[i - 3];
                        }
                        ansPT0.Text = "Відповідь: " + f[N - 1];
                        break;

                }
            }
            catch(FormatException)
            {

            }
        } 
        #endregion

        #region panelString(Рядки)
        private void panel3()
        {
            p[3] = new Panel();
            p[0].Hide();

            p[3].Size = this.Size;
            p[3].Location = new Point(0,0);

            exit.Size = new Size(70, 70);
            exit.Location = new Point(this.Width - exit.Width - 50, 10);
            exit.BackgroundImage = Image.FromFile("back2.png");
            exit.BackgroundImageLayout = ImageLayout.Stretch;
            ExitPanel = 3;
            exit.Click += exit_Click;

            cmbTasksPanel3.Size = new Size(this.Width - 150, 5);
            cmbTasksPanel3.Location = new Point(5, exit.Location.Y);
            cmbTasksPanel3.SelectedIndexChanged += changed3;

            comboBoxPanel3(); //Вызываем метод, который будет инициализировать ComboBox "Рядках"

            p[3].Controls.Add(cmbTasksPanel3);
            p[3].Controls.Add(exit);
            this.Controls.Add(p[3]);
        }
        private void comboBoxPanel3()
        {
            cmbTasksPanel3.Items.Clear();
            cmbTasksPanel3.Items.Add("Максимальний підпаліндром");
            cmbTasksPanel3.Items.Add("Найбільший спільний підрядок");
            for (int i = 0; i < 6;i++)
            {
                Panel3Tasks[i] = new Panel();
                Panel3Tasks[i].Size = new Size(this.Width, this.Height - (exit.Bottom + 30));
                Panel3Tasks[i].Location = new Point(0, exit.Bottom + 10);
                p[3].Controls.Add(Panel3Tasks[i]);
                Panel3Tasks[i].Hide();
            }
            cmbTasksPanel3.SelectedIndex = 0;
            changed3(new object(), new EventArgs());
        }
        private void changed3(object sender, EventArgs e)
        {
            Panel3Tasks[countPanel3].Hide();
            Panel3Tasks[cmbTasksPanel3.SelectedIndex].Show();
            countPanel3 = cmbTasksPanel3.SelectedIndex;
            if (cmbTasksPanel3.SelectedIndex == 0)
                Panel3Tasks0();
            if (cmbTasksPanel3.SelectedIndex == 1)
                Panel3Tasks1();
        }
        private void Panel3Tasks0()
        {
            Label podskazka1 = new Label();
            Label podskazka2 = new Label();
            Label podskazka3 = new Label();
            panelPodskazkaPodpalindrom1.Show();
            panelPodskazkapodpalindrom2.Show();
            txtNKvitki.Show();
            lblAnsPodpalindrom.Show();
            btnTheoryOfPolindrom.Show();
            btnPodPalindrom.Show();
            lblUmovaPolindrom.Show();
            txtPodPolindrom.Show();
            lblUmovaPolindrom.Location = new Point(0,cmbTasksPanel3.Location.Y );
            lblUmovaPolindrom.Size = new Size(this.Width - lblUmovaPolindrom.Location.X - 10, 150);
            lblUmovaPolindrom.Text = File.ReadAllText("Умова задачі найбільший підполіндром.txt");

            lblPodPalindrom.Show(); //Введіть рядок
            lblPodPalindrom.Location = new Point(lblUmovaPolindrom.Location.X, lblUmovaPolindrom.Location.Y + 170);

            txtPodPolindrom.Location = new Point(lblPodPalindrom.Location.X + lblPodPalindrom.Width, lblPodPalindrom.Location.Y);
            txtPodPolindrom.Text = "AVFGA";

            btnPodPalindrom.Location = new Point(txtPodPolindrom.Location.X + txtPodPolindrom.Width + 100, txtPodPolindrom.Location.Y - txtPodPolindrom.Height/4);
            btnPodPalindrom.Click += btnPodPalindrom_Click;

            dataGridPodPalindrom.Rows.Clear();
            dataGridPodPalindrom.Columns.Clear();
            dataGridPodPalindrom.Location = new Point(lblPodPalindrom.Location.X + 10, lblPodPalindrom.Location.Y + lblPodPalindrom.Height + 10);
            dataGridPodPalindrom.Size = new Size(200, 100);

            btnTheoryOfPolindrom.Location = new Point(btnPodPalindrom.Location.X + btnPodPalindrom.Width + 50, btnPodPalindrom.Location.Y);
            
            lblAnsPodpalindrom.Location = new Point(900, Panel3Tasks[0].Height - 80);

            panelPodskazkaPodpalindrom1.Location = new Point(lblAnsPodpalindrom.Location.X, dataGridPodPalindrom.Location.Y + 20);
            panelPodskazkaPodpalindrom1.BackColor = Color.Blue;
            
            podskazka1.Size = new Size(300,50);
            podskazka1.Font = new Font("Tahoma",10,FontStyle.Bold);
            podskazka1.Location = new Point(panelPodskazkaPodpalindrom1.Location.X + panelPodskazkaPodpalindrom1.Width, panelPodskazkaPodpalindrom1.Location.Y + 10);
            podskazka1.Text = "- позначаються ті, що розташовані по діагоналі (сам рядок)";

            panelPodskazkapodpalindrom2.Location = new Point(panelPodskazkaPodpalindrom1.Location.X, panelPodskazkaPodpalindrom1.Location.Y + panelPodskazkaPodpalindrom1.Height + 20);
            panelPodskazkapodpalindrom2.BackColor = Color.GreenYellow;

            podskazka2.Size = podskazka1.Size;
            podskazka2.Font = podskazka1.Font;
            podskazka2.Location = new Point(panelPodskazkapodpalindrom2.Location.X + panelPodskazkapodpalindrom2.Width, panelPodskazkapodpalindrom2.Location.Y + 10);
            podskazka2.Text = "- позначаються ті, що використані на шляху до знаходження відповіді";

            txtNKvitki.Location = new Point(panelPodskazkapodpalindrom2.Location.X, panelPodskazkapodpalindrom2.Location.Y + panelPodskazkapodpalindrom2.Height + 20);
            txtNKvitki.BackColor = Color.Gold;

            podskazka3.Size = podskazka2.Size;
            podskazka3.Font = podskazka2.Font;
            podskazka3.Location = new Point(txtNKvitki.Location.X + txtNKvitki.Width,txtNKvitki.Location.Y + 10);
            podskazka3.Text = "- позначається відповідь до задачі";

            Panel3Tasks[0].Controls.Add(podskazka1);
            Panel3Tasks[0].Controls.Add(podskazka2);
            Panel3Tasks[0].Controls.Add(podskazka3);
            Panel3Tasks[0].Controls.Add(panelPodskazkaPodpalindrom1);
            Panel3Tasks[0].Controls.Add(panelPodskazkapodpalindrom2);
            Panel3Tasks[0].Controls.Add(txtNKvitki);
            Panel3Tasks[0].Controls.Add(btnTheoryOfPolindrom);
            Panel3Tasks[0].Controls.Add(dataGridPodPalindrom);
            Panel3Tasks[0].Controls.Add(btnPodPalindrom);
            Panel3Tasks[0].Controls.Add(lblAnsPodpalindrom);
            Panel3Tasks[0].Controls.Add(lblUmovaPolindrom);
            Panel3Tasks[0].Controls.Add(lblPodPalindrom);
            Panel3Tasks[0].Controls.Add(txtPodPolindrom);
        }
        private void btnPodPalindrom_Click(object sender, EventArgs e)
        {
            dataGridPodPalindrom.Show();
            lblAnsPodpalindrom.Text = "Відповідь:";
            int widght=0,height=0;
            dataGridPodPalindrom.Rows.Clear();
            dataGridPodPalindrom.Columns.Clear();
            string s;
            s = txtPodPolindrom.Text;
            int L = s.Length;
            dataGridPodPalindrom.ColumnCount = L;
            dataGridPodPalindrom.RowCount = L;
            string[,] d = new string[101,101];
            

            for (int i = 0; i < L; i++)
            {
                d[i, i] = Convert.ToString(s[i]);
                dataGridPodPalindrom.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridPodPalindrom.Columns[i].HeaderText = s[i] + "";

            }
            for (int i = 1; i < L;i++)
            {
                for(int j = i; j < L;j++)
                {
                    int g = j - i;
                    if (s[g] != s[j])
                        d[g, j] = max(d[g, j - 1], d[g + 1, j]);
                    else
                        d[g, j] = max(d[g,j-1], max(d[g+1,j],s[g] + d[g+1,j-1] + s[j]));
                  
                }
            }
           for (int i = 0; i < L; i++)
                dataGridPodPalindrom.Rows[i].Height = 50;//Подстравиваем ширину таблицы
            dataGridPodPalindrom.Enabled = true;
            dataGridPodPalindrom.Width = Panel3Tasks[0].Width*3/4;
            dataGridPodPalindrom.Height = Panel3Tasks[0].Height - dataGridPodPalindrom.Location.Y - 50; 
            //В следующих циклах заполняю таблицу для визулизации алгоритма
            for(int i = 0; i< L;i++)
            {
                for(int j = 0;j < L;j++)
                {
                    dataGridPodPalindrom.Rows[i].Cells[j].Value = d[i,j];
                    dataGridPodPalindrom.Rows[i].Cells[j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridPodPalindrom.Rows[i].Cells[j].Style.Font = new Font("Tahoma",22,FontStyle.Bold);
                    if (i <= j)
                        dataGridPodPalindrom.Rows[i].Cells[j].Style.BackColor = Color.GreenYellow;
                    else
                        dataGridPodPalindrom.Rows[i].Cells[j].Style.BackColor = Color.Gray;
                    if (i == j)
                        dataGridPodPalindrom.Rows[i].Cells[j].Style.BackColor = Color.Blue;
                    if(i == 0 && j == L-1)
                        dataGridPodPalindrom.Rows[i].Cells[j].Style.BackColor = Color.Gold;
                    if (i == 0)
                        widght += dataGridPodPalindrom.Columns[j].Width;
                }
                height += dataGridPodPalindrom.Rows[i].Height;
            }
            dataGridPodPalindrom.Columns[0].ReadOnly = true;             
            //В следующих циклах заполняю пустые клетки таблицы "-"
            for(int i = 0; i < L;i++)
            {
                for (int j = 0; j < L; j++)
                {
                    string h = Convert.ToString(dataGridPodPalindrom.Rows[i].Cells[j].Value);
                    h.Replace(" ","");
                    dataGridPodPalindrom.Rows[i].Cells[j].Value = h;
                    if (dataGridPodPalindrom.Rows[i].Cells[j].Value == "")
                        dataGridPodPalindrom.Rows[i].Cells[j].Value = "-";
                }
            }
            widght += dataGridPodPalindrom.RowHeadersWidth + 40;
            dataGridPodPalindrom.Width = widght;
            lblAnsPodpalindrom.Text += " " + d[0,L-1];

        }
        string max(string a, string b)
        {
            if (a.Length >= b.Length)
                return a;
            else
                return b;
        }
        private void btnTheoryOfPolindrom_Click(object sender, EventArgs e)
        {
            theoryPodPalindrom.Show();
        }
        private void Panel3Tasks1()
        {
            Label podsk1, podsk2, podsk3;
            podsk1 = new Label();
            podsk2 = new Label();
            podsk3 = new Label();
            panelPodskazka1Podstroka.Show();
            panelPodskazka2Podstroka.Show();
            panelPodskazka3Podstroka.Show();
            btnTheoryOfPodstroka.Show();
            lblAnsPodstroka.Text = "Відповідь: ";
            lblAnsPodstroka.Show();
            dataGridPodPalindrom.Rows.Clear();
            dataGridPodPalindrom.Columns.Clear();
            btnPodstroka.Show();
            lblPodstroka.Show();
            lblPodstrokaS1.Show();
            txtPodstrokaS1.Show();  
            lblPodstrokaS2.Show();
            txtPodstrokaS2.Show();
            lblPodstroka.Location = new Point(0,cmbTasksPanel3.Location.Y);
            lblPodstroka.Text = File.ReadAllText("Умова задачі найбільший підрядок.txt");
            lblPodstroka.Size = new Size(Panel3Tasks[1].Width, 130);
            lblPodstrokaS1.Location = new Point(lblPodstroka.Location.X, lblPodstroka.Location.Y + lblPodstroka.Height);
            txtPodstrokaS1.Location = new Point(lblPodstrokaS1.Location.X + lblPodstrokaS1.Width + 20,lblPodstrokaS1.Location.Y + 5);
            lblPodstrokaS2.Location = new Point(lblPodstrokaS1.Location.X, lblPodstrokaS1.Location.Y + lblPodstrokaS1.Height + 20);
            txtPodstrokaS2.Location = new Point(lblPodstrokaS2.Location.X + lblPodstrokaS2.Width + 20, lblPodstrokaS2.Location.Y + 5);
            btnPodstroka.Location = new Point(txtPodstrokaS1.Location.X + txtPodstrokaS1.Width + 85, txtPodstrokaS1.Location.Y);
            txtPodstrokaS1.Text = "qwe";
            txtPodstrokaS2.Text = "qwerty";
            lblAnsPodstroka.Location = new Point(lblPodstrokaS2.Location.X + 10 + Panel3Tasks[1].Width/2, lblPodstrokaS2.Location.Y + lblPodstrokaS2.Height + 20);
            btnTheoryOfPodstroka.Location = new Point(btnPodstroka.Location.X + btnPodstroka.Width + 30, btnPodstroka.Location.Y);

            panelPodskazka1Podstroka.Location = new Point(lblAnsPodstroka.Location.X + 10, lblAnsPodstroka.Location.Y + lblAnsPodstroka.Height);
            panelPodskazka1Podstroka.BackColor = Color.LawnGreen;
            panelPodskazka2Podstroka.Location = new Point(panelPodskazka1Podstroka.Location.X, panelPodskazka1Podstroka.Location.Y + panelPodskazka1Podstroka.Height + 10);
            panelPodskazka2Podstroka.BackColor = Color.LightBlue;
            panelPodskazka3Podstroka.Location = new Point(panelPodskazka2Podstroka.Location.X, panelPodskazka2Podstroka.Location.Y + panelPodskazka2Podstroka.Height + 10);
            panelPodskazka3Podstroka.BackColor = Color.Fuchsia;
            podsk1.AutoSize = false;
            podsk1.Font = new Font("Tahoma",16,FontStyle.Regular);
            podsk1.Size = new Size(500,40);
            podsk1.Location = new Point(panelPodskazka1Podstroka.Location.X + panelPodskazka1Podstroka.Width+5,panelPodskazka1Podstroka.Location.Y + panelPodskazka1Podstroka.Height/4);
            podsk1.Text = "- позначаються елементи першого рядка";
            podsk2.Location = new Point(podsk1.Location.X, panelPodskazka2Podstroka.Location.Y + panelPodskazka2Podstroka.Height / 4);
            podsk2.Text = "- позаначаються елементи другого рядка";
            podsk2.Font = podsk1.Font;
            podsk2.AutoSize = false;
            podsk2.Size = podsk1.Size;
            podsk3.AutoSize = false;
            podsk3.Size = new Size(600,40);
            podsk3.Location = new Point(podsk2.Location.X, panelPodskazka3Podstroka.Location.Y + panelPodskazka3Podstroka.Height / 4);
            podsk3.Font = podsk1.Font;
            podsk3.Text = "- позначаються ті, що задіяні у пошуку відповіді";


            Panel3Tasks[1].Controls.Add(podsk1);
            Panel3Tasks[1].Controls.Add(podsk2);
            Panel3Tasks[1].Controls.Add(podsk3);
            Panel3Tasks[1].Controls.Add(panelPodskazka1Podstroka);
            Panel3Tasks[1].Controls.Add(panelPodskazka2Podstroka);
            Panel3Tasks[1].Controls.Add(panelPodskazka3Podstroka);
            Panel3Tasks[1].Controls.Add(btnTheoryOfPodstroka);
            Panel3Tasks[1].Controls.Add(lblAnsPodstroka);
            Panel3Tasks[1].Controls.Add(lblPodstroka);
            Panel3Tasks[1].Controls.Add(btnPodstroka);
            Panel3Tasks[1].Controls.Add(lblPodstrokaS1);
            Panel3Tasks[1].Controls.Add(lblPodstrokaS2);
            Panel3Tasks[1].Controls.Add(txtPodstrokaS1);
            Panel3Tasks[1].Controls.Add(txtPodstrokaS2);
        }
        private void btnPodstroka_Click(object sender, EventArgs e)
        {
            lblAnsPodstroka.Text = "Відповідь: ";
            dataGridPodstroka.Enabled = true;
            dataGridPodPalindrom.Rows.Clear();
            dataGridPodPalindrom.Columns.Clear();
            int N1, N2;
            string s1 = "", s2 = "";
            dataGridPodstroka.Show();
            dataGridPodstroka.Width = Panel3Tasks[1].Width /2;
            dataGridPodstroka.Height = 280;
            dataGridPodstroka.Location = new Point(lblPodstrokaS2.Location.X + 10,lblPodstrokaS2.Location.Y + lblPodstrokaS2.Height + 20);
            s1 = txtPodstrokaS1.Text;
            s2 = txtPodstrokaS2.Text;
            if(s1 == string.Empty && s2 == string.Empty)
            {
                s1 = "qwe";
                s2 = "qwerty";
                txtPodstrokaS1.Text = s1;
                txtPodstrokaS2.Text = s2;
            }
            
            N1 = s1.Length;
            N2 = s2.Length;
            int[,] A = new int[N1+2,N2+2];
            dataGridPodstroka.ColumnCount = N2 + 2;
            dataGridPodstroka.RowCount = N1 + 2;
            int k = 0;
            for(int i = 0; i < N2 + 2; i++)
            {
                dataGridPodstroka.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                if (i > 1) {
                    dataGridPodstroka.Rows[0].Cells[i].Style.Font = new Font("Tahoma",20,FontStyle.Bold);
                    dataGridPodstroka.Rows[0].Cells[i].Value = s2[k];   
                    dataGridPodstroka.Rows[0].Cells[i].Style.BackColor = Color.LightBlue;
                    dataGridPodstroka.Rows[0].Cells[i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    k++;
                }
                if (i > 0)
                {
                    dataGridPodstroka.Rows[1].Cells[i].Value = "0";
                    dataGridPodstroka.Rows[1].Cells[i].Style.Font = new Font("Tahoma", 18, FontStyle.Italic);
                    dataGridPodstroka.Rows[1].Cells[i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (i < N2)
                    A[0, i] = 0;
            }
            k = 0;
            for(int i = 0; i < N1 + 2; i++)
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
                    dataGridPodstroka.Rows[i].Cells[1].Style.Font = new Font("Tahoma", 18, FontStyle.Italic);
                    dataGridPodstroka.Rows[i].Cells[1].Value = "0";
                    dataGridPodstroka.Rows[i].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                }
                if (i < N1)                                                                                       
                    A[i, 0] = 0;
            }
            k = 0;
            int max = -1, iMax = -1;
            for(int i = 1; i <= N1; i++)
            {
                for(int j = 1; j <= N2;j++)
                {
                    dataGridPodstroka.Rows[i + 1].Cells[j + 1].Style.BackColor = Color.White;
                    dataGridPodstroka.Rows[i + 1].Cells[j + 1].Style.ForeColor = Color.Black;
                    if (s1[i-1] != s2[j-1])
                        A[i, j] = 0;
                    else
                        A[i, j] = A[i - 1, j - 1] + 1;
                    dataGridPodstroka.Rows[i + 1].Cells[j + 1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridPodstroka.Rows[i + 1].Cells[j + 1].Style.Font = new Font("Tahoma",20,FontStyle.Italic);
                    if (A[i, j] != 0)
                    {
                        dataGridPodstroka.Rows[i + 1].Cells[j + 1].Style.BackColor = Color.Fuchsia;
                        dataGridPodstroka.Rows[i + 1].Cells[j + 1].Style.ForeColor = Color.Blue;
                    }
                    if(A[i,j] >= max)
                    {
                        max = A[i, j];
                        iMax = i;
                    }
                    dataGridPodstroka.Rows[i+1].Cells[j+1].Value = A[i, j] + "";

                }
            }
            int w = 0;
            for(int i = iMax-max; w < max; i++)//Выводим ответ в Label
            {
                lblAnsPodstroka.Text += s1[i];
                w++;
            }
            
            Panel3Tasks[1].Controls.Add(dataGridPodstroka);
        }
        private void btnTheoryOfPodstroka_Click(object sender, EventArgs e)
        {
            theoryPodstroka.Show();
        }

        #endregion

        #region panel4(Пошук оптимального рішення)
        private void panel4()
        {
            p[4] = new Panel();
            p[0].Hide();
            p[4].Size = this.Size;
            p[4].Location = new Point(0, 0);

            exit.Size = new Size(70, 70);
            exit.Location = new Point(this.Width - exit.Width - 50, 10);
            exit.BackgroundImage = Image.FromFile("back2.png");
            exit.BackgroundImageLayout = ImageLayout.Stretch;
            ExitPanel = 4;
            exit.Click += exit_Click;

            cmbTasksPanel4.Size = new Size(this.Width-150,5);
            cmbTasksPanel4.Location = new Point(5,exit.Location.Y);
            comboboxPanel4();
            cmbTasksPanel4.SelectedIndexChanged += changed4;

            p[4].Controls.Add(cmbTasksPanel4);
            p[4].Controls.Add(exit);
            this.Controls.Add(p[4]);
        }
        private void comboboxPanel4()
        {
            cmbTasksPanel4.Items.Clear();
            cmbTasksPanel4.Items.Add("Купівля квитків");
            cmbTasksPanel4.Items.Add("Задача про рюкзак");
            for(int i = 0; i < 6;i++)
            {
                Panel4Tasks[i] = new Panel();
                Panel4Tasks[i].Size = new Size(this.Width, this.Height - (exit.Bottom + 30));
                Panel4Tasks[i].Location = new Point(0, exit.Bottom + 10);
                p[4].Controls.Add(Panel4Tasks[i]);
                Panel4Tasks[i].Hide();
            }
            cmbTasksPanel4.SelectedIndex = 0;
            changed4(new object(), new EventArgs());
        }
        private void changed4(object sender, EventArgs e)
        {
            Panel4Tasks[countPanel4].Hide();
            Panel4Tasks[cmbTasksPanel4.SelectedIndex].Show();
            countPanel4 = cmbTasksPanel4.SelectedIndex;
            if(cmbTasksPanel4.SelectedIndex == 0)
                Panel4Tasks0();
            if(cmbTasksPanel4.SelectedIndex == 1)
                Panel4Tasks1();
            
        }
        private void Panel4Tasks0()
        {
            dataGridKvitki.Show();
            dataGridKvitki2.Show();
            dataGridKvitki2.Rows.Clear();
            dataGridKvitki2.Columns.Clear();
            dataGridKvitki.Rows.Clear();
            dataGridKvitki.Columns.Clear();
            btnKvitkiRandom.Show(); 
            lblUmovaKvitki.Show();
            dataGridKvitki.AllowUserToAddRows = false;
            dataGridKvitki2.ReadOnly = true;
            btnKvitkiVruch.Show();
            btnTheoryOfKvitki.Show();
            lblNKvitki.Show();
            txtNK.Show();
            lblUmovaKvitki.AutoSize = false;
            lblUmovaKvitki.Size = new Size(Panel4Tasks[0].Width - 20, 225);
            lblUmovaKvitki.Location = new Point(0, cmbTasksPanel4.Location.Y);
            lblUmovaKvitki.Text = File.ReadAllText("Умова Квитки.txt");

            lblNKvitki.Location = new Point(lblUmovaKvitki.Location.X, lblUmovaKvitki.Location.Y + lblUmovaKvitki.Height + 10);
            txtNK.Location = new Point(lblNKvitki.Location.X + lblNKvitki.Width, lblNKvitki.Location.Y);
            txtNK.Text = "5";
            btnKvitkiVruch.Location = new Point(txtNK.Location.X + txtNK.Width+10, txtNK.Location.Y - 10);
            btnKvitkiRandom.Location = new Point(btnKvitkiVruch.Location.X + btnKvitkiVruch.Width + 10, btnKvitkiVruch.Location.Y );
            btnTheoryOfKvitki.Location = new Point(btnKvitkiRandom.Location.X + btnKvitkiRandom.Width + 10, btnKvitkiRandom.Location.Y);
            dataGridKvitki.Location = new Point(lblNKvitki.Location.X + 10, lblNKvitki.Location.Y + lblNKvitki.Height + 10);
            dataGridKvitki.Size = new Size(733, 203);

            int n = Convert.ToInt32(txtNK.Text);
            dataGridKvitki.RowCount = 4;
            dataGridKvitki.ColumnCount = n + 1;
            dataGridKvitki.Rows[1].Cells[0].Value = "Час на продаж одного білету";
            dataGridKvitki.Rows[2].Cells[0].Value = "Час на продаж двух білетів";
            dataGridKvitki.Rows[3].Cells[0].Value = "Час на продаж трьох білетів";
            dataGridKvitki.AutoResizeColumns();
            dataGridKvitki.Rows[0].Cells[0].Value = "Номер людини в черзі";
            for (int i = 1; i <= n; i++)
            {
                dataGridKvitki.Rows[0].Cells[i].Style.Font = new Font("Tahoma", 24, FontStyle.Regular);
                dataGridKvitki.Rows[0].Cells[i].Style.ForeColor = Color.Coral;
                dataGridKvitki.Rows[0].Cells[i].Value = "" + i;
            }
            for (int i = 0; i <= 3; i++)
            {
                dataGridKvitki.Rows[i].Height = 50;
                dataGridKvitki.Rows[i].Cells[0].Style.Font = new Font("Tahoma", 18, FontStyle.Bold);
            }
            for (int j = 1; j <= n; j++)
            {
                dataGridKvitki[j, 1].Style.ForeColor = Color.Blue;
                dataGridKvitki.Rows[1].Cells[j].Style.Font = new Font("Tahoma", 24, FontStyle.Regular);
                dataGridKvitki.Rows[1].Cells[j].Value = "0";
                dataGridKvitki.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            for (int j = 1; j <= n; j++)
            {
                dataGridKvitki[j, 2].Style.ForeColor = Color.DarkViolet;
                dataGridKvitki.Rows[2].Cells[j].Style.Font = new Font("Tahoma", 24, FontStyle.Regular);
                dataGridKvitki.Rows[2].Cells[j].Value =  "0";
            }
            for (int j = 1; j <= n; j++)
            {
                dataGridKvitki[j, 3].Style.ForeColor = Color.Brown;
                dataGridKvitki.Rows[3].Cells[j].Style.Font = new Font("Tahoma", 24, FontStyle.Regular);
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
            dataGridKvitki2[1, 0].Style.Font = new Font("Tahoma", 22, FontStyle.Regular);
            dataGridKvitki2[2, 0].Style.Font = new Font("Tahoma", 22, FontStyle.Regular);
            dataGridKvitki2[3, 0].Style.Font = new Font("Tahoma", 22, FontStyle.Regular);
            dataGridKvitki2[0, 0].Style.Font = new Font("Tahoma", 24, FontStyle.Bold);
            dataGridKvitki2[1, 0].Value = 0 + "";
            dataGridKvitki2[2, 0].Value = "0";
            dataGridKvitki2[3, 0].Value = "0";
            dataGridKvitki2[0, 0].Value = "Масив динаміки:";
            dataGridKvitki.Columns[0].Width = 450;
            dataGridKvitki2.Rows[0].Height = 44;
            for (int i = 3; i <= n; i++)
            {
                dataGridKvitki2[i + 1, 0].Value = "0";
                dataGridKvitki2[i + 1, 0].Style.Font = new Font("Tahoma", 22, FontStyle.Regular);
                dataGridKvitki2[i + 1, 0].Style.BackColor = Color.Aqua;
            }
            dataGridKvitki2.AutoResizeColumns();
            
            Panel4Tasks[0].Controls.Add(dataGridKvitki);
            Panel4Tasks[0].Controls.Add(dataGridKvitki2);
            Panel4Tasks[0].Controls.Add(btnKvitkiRandom);
            Panel4Tasks[0].Controls.Add(btnTheoryOfKvitki);
            Panel4Tasks[0].Controls.Add(btnKvitkiVruch);
            Panel4Tasks[0].Controls.Add(lblNKvitki);
            Panel4Tasks[0].Controls.Add(txtNK); 
            Panel4Tasks[0].Controls.Add(lblUmovaKvitki);
        } //(Покупка билетов)
        private void btnKvitkiVruch_Click(object sender, EventArgs e)
        {
            lblAnsKvitki.Show();
            listBoxKvitki.Show();
            lblAnsKvitki.Text = "Відповідь:";
            int n = Convert.ToInt32(txtNK.Text);
            dataGridKvitki2.ColumnCount = n + 2;
            listBoxKvitki.Items.Clear();
            listBoxKvitki.Items.Add("Для оптимізації часу (мінімізації в нашому випадку):");
            int[] d = new int[n + 1];
            int[] a = new int[n + 1];
            int[] b = new int[n + 1];
            int[] c = new int[n + 1];
            dataGridKvitki.ColumnCount = n + 1;
            dataGridKvitki.Rows[1].Cells[0].Value = "Час на продаж одного білету";
            dataGridKvitki.Rows[2].Cells[0].Value = "Час на продаж двух білетів";
            dataGridKvitki.Rows[3].Cells[0].Value = "Час на продаж трьох білетів";
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
                dataGridKvitki.Rows[i].Cells[0].Style.Font = new Font("Tahoma", 18, FontStyle.Bold);
            }
            dataGridKvitki.Columns[0].Width = 450;
            for (int j = 1; j <= n; j++)
            {
                a[j] = Convert.ToInt32(dataGridKvitki.Rows[1].Cells[j].Value);
                dataGridKvitki[j, 1].Style.ForeColor = Color.Blue;
                dataGridKvitki.Rows[1].Cells[j].Style.Font = new Font("Tahoma", 24, FontStyle.Regular);
                dataGridKvitki.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            for (int j = 1; j <= n; j++)
            {
                b[j] = Convert.ToInt32(dataGridKvitki.Rows[2].Cells[j].Value);

                dataGridKvitki[j, 2].Style.ForeColor = Color.DarkViolet;
                dataGridKvitki.Rows[2].Cells[j].Style.Font = new Font("Tahoma", 24, FontStyle.Regular);
                dataGridKvitki.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            for (int j = 1; j <= n; j++)
            {
                c[j] = Convert.ToInt32(dataGridKvitki.Rows[3].Cells[j].Value);

                dataGridKvitki[j, 3].Style.ForeColor = Color.Brown;
                dataGridKvitki.Rows[3].Cells[j].Style.Font = new Font("Tahoma", 24, FontStyle.Regular);
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
                dataGridKvitki2[i + 1, 0].Style.Font = new Font("Tahoma", 22, FontStyle.Regular);
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
                        listBoxKvitki.Items.Add("Людина № " + r + " бере два білети(за себе і за наступну)");
                        r++;
                        break;
                    case 'c':
                        r++;
                        listBoxKvitki.Items.Add("Людина № " + r + " бере три білети(за себе і двох)");
                        r += 2;
                        break;
                    default:
                        break;

                }
            }

            dataGridKvitki2.Rows[0].Height = 44;
            dataGridKvitki2.AutoResizeColumns();
            dataGridKvitki.Columns[0].Width = 381;

            lblAnsKvitki.Location = new Point(dataGridKvitki.Location.X + dataGridKvitki.Width + 10, dataGridKvitki.Location.Y);
            listBoxKvitki.Location = new Point(lblAnsKvitki.Location.X + 7, lblAnsKvitki.Location.Y + lblAnsKvitki.Height + 10);
            lblAnsKvitki.Text += " " + d[n];

            Panel4Tasks[0].Controls.Add(lblAnsKvitki);
            Panel4Tasks[0].Controls.Add(listBoxKvitki);
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
            listBoxKvitki.Items.Add("Для оптимізації часу (мінімізації в нашому випадку):");
            int[] d = new int[n + 1];
            int[] a = new int[n + 1];
            int[] b = new int[n + 1];
            int[] c = new int[n + 1];
            dataGridKvitki.ColumnCount = n + 1;
            dataGridKvitki.Rows[1].Cells[0].Value = "Час на продаж одного білету";
            dataGridKvitki.Rows[2].Cells[0].Value = "Час на продаж двух білетів";
            dataGridKvitki.Rows[3].Cells[0].Value = "Час на продаж трьох білетів";
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
                dataGridKvitki.Rows[i].Cells[0].Style.Font = new Font("Tahoma", 18, FontStyle.Bold);
            }
            dataGridKvitki.Columns[0].Width = 450;
            for (int j = 1; j <= n; j++)
            {
                a[j] = z.Next(1, 200);
                dataGridKvitki[j, 1].Value = "" + a[j];
                dataGridKvitki[j, 1].Style.ForeColor = Color.Blue;
                dataGridKvitki.Rows[1].Cells[j].Style.Font = new Font("Tahoma", 24, FontStyle.Regular);
                dataGridKvitki.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            for (int j = 1; j <= n; j++)
            {
                b[j] = z.Next(1,200);
                dataGridKvitki[j, 2].Value = "" + b[j];
                dataGridKvitki[j, 2].Style.ForeColor = Color.DarkViolet;
                dataGridKvitki.Rows[2].Cells[j].Style.Font = new Font("Tahoma", 24, FontStyle.Regular);
                dataGridKvitki.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            for (int j = 1; j <= n; j++)
            {
                c[j] = z.Next(1,200);
                dataGridKvitki[j, 3].Value = "" + c[j];
                dataGridKvitki[j, 3].Style.ForeColor = Color.Brown;
                dataGridKvitki.Rows[3].Cells[j].Style.Font = new Font("Tahoma", 24, FontStyle.Regular);
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
                dataGridKvitki2[i + 1, 0].Style.Font = new Font("Tahoma", 22, FontStyle.Regular);
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
                        listBoxKvitki.Items.Add("Людина № " + r + " бере два білети(за себе і за наступну)");
                        r++;
                        break;
                    case 'c':
                        r++;
                        listBoxKvitki.Items.Add("Людина № " + r + " бере три білети(за себе і двох)");
                        r += 2;
                        break;
                    default:
                        break;

                }
            }

            dataGridKvitki2.Rows[0].Height = 44;
            dataGridKvitki2.AutoResizeColumns();
            dataGridKvitki.Columns[0].Width = 381;

            lblAnsKvitki.Location = new Point(dataGridKvitki.Location.X + dataGridKvitki.Width + 10, dataGridKvitki.Location.Y);
            listBoxKvitki.Location = new Point(lblAnsKvitki.Location.X + 7, lblAnsKvitki.Location.Y + lblAnsKvitki.Height + 10);
            lblAnsKvitki.Text += " " + d[n];

            Panel4Tasks[0].Controls.Add(lblAnsKvitki);
            Panel4Tasks[0].Controls.Add(listBoxKvitki);
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

            Panel4Tasks[0].Controls.Add(lblAnsKvitki);
            Panel4Tasks[0].Controls.Add(listBoxKvitki);
        }
        private void btnTheoryOfKvitki_Click(object sender, EventArgs e)
        {
            theoryKvitki.Show();
        }
        private void Panel4Tasks1() //"Задача о рюкзаке"
        {
            dataGridKnapsack.Rows.Clear();
            dataGridKnapsack.Columns.Clear();
            dataGridMasKnapsack.Rows.Clear();
            dataGridMasKnapsack.Columns.Clear();
            dataGridKnapsack.Show();
            btnKnapsackRandom.Show();
            btnKnapsackVruch.Show();
            btnTheoryOfKnapsack.Show();
            dataGridKnapsack.AllowUserToAddRows = false;
            umova.AutoSize = false;
            umova.Size = new Size(1270,120);
            umova.Font = lblUmovaKvitki.Font;
            umova.Text = File.ReadAllText("Умова рюкзак.txt");
            umova.Location = new Point(cmbTasksPanel4.Location.X, cmbTasksPanel4.Location.Y);
            lblNKnapsack.Location = new Point(umova.Location.X, umova.Location.Y + umova.Height);
            lblNKnapsack.Text = "Введіть N:";
            lblNKnapsack.AutoSize = false;
            lblNKnapsack.Size = new Size(183, 58); 
            lblNKnapsack.Font = new Font("Segoe UI",24,FontStyle.Bold);
            txtNKnapsack.Location = new Point(lblNKnapsack.Location.X + lblNKnapsack.Width + 10, lblNKnapsack.Location.Y + 5);
            txtNKnapsack.Font = new Font(Name, 22, FontStyle.Bold);
            lblMKnapsack.Size = lblNKnapsack.Size;
            lblMKnapsack.AutoSize = false;
            lblMKnapsack.Location = new Point(txtNKnapsack.Location.X + txtNKnapsack.Width, lblNKnapsack.Location.Y);
            lblMKnapsack.Size = new Size(190,58);
            lblMKnapsack.Text = "Введіть W:";
            lblMKnapsack.Font = lblNKnapsack.Font;
            txtMKnapsack.Location = new Point(lblMKnapsack.Location.X + lblMKnapsack.Width + 10, lblMKnapsack.Location.Y + 5);
            txtMKnapsack.Font = txtNKnapsack.Font;
            txtMKnapsack.Text = "10";
            txtNKnapsack.Text = "2";

            int n = Convert.ToInt32(txtNKnapsack.Text), m = Convert.ToInt32(txtMKnapsack.Text);
            
            btnKnapsackVruch.Location = new Point(txtMKnapsack.Location.X + txtMKnapsack.Width + 5, txtMKnapsack.Location.Y - 8);
            btnKnapsackRandom.Location = new Point(btnKnapsackVruch.Location.X + btnKnapsackVruch.Width + 10, btnKnapsackVruch.Location.Y);
            btnTheoryOfKnapsack.Location = new Point(btnKnapsackRandom.Location.X + btnKnapsackRandom.Width + 10, btnKnapsackRandom.Location.Y);

            dataGridKnapsack.Location = new Point(lblNKnapsack.Location.X, lblNKnapsack.Location.Y + lblNKnapsack.Height);
            dataGridKnapsack.Size = new Size(441,400);
            dataGridKnapsack.RowCount = 1+n;
            dataGridKnapsack.ColumnCount = 3;
            dataGridKnapsack.Rows[0].Height = 40;
            for (int i = 0; i <= n; i++)
                for (int j = 0; j < 3; j++)
                    dataGridKnapsack[j, i].Style.Font = new Font(Name, 19, FontStyle.Regular);

            dataGridKnapsack[1, 0].Style.Font = new Font(Name,21,FontStyle.Bold);
            dataGridKnapsack[2,0].Style.Font = new Font(Name, 21, FontStyle.Bold);
            dataGridKnapsack[0,0].Style.Font = new Font(Name, 21, FontStyle.Bold);
            dataGridKnapsack[1, 0].Value = "Масса";
            dataGridKnapsack[2, 0].Value = "Ціна";
            dataGridKnapsack[0, 0].Value = "Номер предмета";
            dataGridKnapsack[1, 1].Value = "3";
            dataGridKnapsack[1, 2].Value = "149";
            dataGridKnapsack[2, 1].Value = "46";
            dataGridKnapsack[2, 2].Value = "151";
            for(int j = 1; j <= n;j++)
            {
                dataGridKnapsack[0, j].Value = "Предмет № " + j;
                dataGridKnapsack[1, j].Style.BackColor = Color.Chartreuse;
                dataGridKnapsack[2, j].Style.BackColor = Color.BurlyWood;
                dataGridKnapsack.Rows[j].Height = 40;
            }
            dataGridKnapsack.AutoResizeColumns();


            Panel4Tasks[1].Controls.Add(btnTheoryOfKnapsack);
            Panel4Tasks[1].Controls.Add(dataGridKnapsack);
            Panel4Tasks[1].Controls.Add(txtNKnapsack);
            Panel4Tasks[1].Controls.Add(txtMKnapsack);
            Panel4Tasks[1].Controls.Add(lblMKnapsack);
            Panel4Tasks[1].Controls.Add(btnKnapsackRandom);
            Panel4Tasks[1].Controls.Add(btnKnapsackVruch);
            Panel4Tasks[1].Controls.Add(txtNKnapsack);
            Panel4Tasks[1].Controls.Add(lblNKnapsack);
            Panel4Tasks[1].Controls.Add(umova);
        }
        private void btnKnapsackVruch_Click(object sender, EventArgs e)//"Ввести власноруч"
        {
            lblAnsKnapsack.Show();
            lblAnsKnapsack.Text = "Відповідь:";
            dataGridMasKnapsack.Rows.Clear();
            dataGridMasKnapsack.Columns.Clear();
            lblMasD.Location = new Point(dataGridKnapsack.Location.X + dataGridKnapsack.Width + 10, dataGridKnapsack.Location.Y);
            lblMasD.Font = lblNKnapsack.Font;
            lblMasD.Text = "Масив динаміки:";
            lblMasD.AutoSize = false;
            lblMasD.Size = new Size(400, 50);
            dataGridMasKnapsack.Show();
            dataGridMasKnapsack.Location = new Point(dataGridKnapsack.Location.X + dataGridKnapsack.Width + 8, lblMasD.Location.Y + lblMasD.Height);
            dataGridMasKnapsack.Size = new Size(500, 350);
            Random z = new Random();
            int n = Convert.ToInt32(txtNKnapsack.Text), m = Convert.ToInt32(txtMKnapsack.Text);

            dataGridKnapsack.Location = new Point(lblNKnapsack.Location.X, lblNKnapsack.Location.Y + lblNKnapsack.Height);
            dataGridKnapsack.Size = new Size(441, 400);
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
            for (int j = 1; j <= n; j++)
            {
                dataGridKnapsack[0, j].Value = "Предмет № " + j;
                dataGridKnapsack.Rows[j].Height = 40;
                dataGridKnapsack[1, j].Style.BackColor = Color.Chartreuse;
                dataGridKnapsack[2, j].Style.BackColor = Color.BurlyWood;
            }
            dataGridKnapsack.AutoResizeColumns();

            dataGridMasKnapsack.RowCount = n + 1;
            dataGridMasKnapsack.ColumnCount = m + 1;
            int[] w = new int[n + 1];
            int[] p = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                w[i] = Convert.ToInt32(dataGridKnapsack.Rows[i].Cells[1].Value);
                p[i] = Convert.ToInt32(dataGridKnapsack.Rows[i].Cells[2].Value);
                dataGridKnapsack.Rows[i].Cells[1].Value = w[i] + "";
                dataGridKnapsack.Rows[i].Cells[2].Value = p[i] + ""; 
           }
            int[,] A = new int[n + 1, m + 1];
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
                    dataGridMasKnapsack[j, i].Style.Font = new Font(Name, 19, FontStyle.Regular);
                    dataGridMasKnapsack[j, i].Value = A[i, j] + "";
                    dataGridMasKnapsack.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            dataGridMasKnapsack.ClearSelection();//Убирает выдиление с первой ячейки таблицы
            dataGridMasKnapsack[m, n].Style.BackColor = Color.Gold;
            lblAnsKnapsack.Location = new Point(dataGridMasKnapsack.Location.X + dataGridMasKnapsack.Width, dataGridMasKnapsack.Location.Y);
          
            dataGridMasKnapsack[m, n].Style.BackColor = Color.Gold;
            lblAnsKnapsack.Location = new Point(dataGridMasKnapsack.Location.X + dataGridMasKnapsack.Width, dataGridMasKnapsack.Location.Y);
            lblAnsKnapsack.Text += " " + A[n, m];
            listBoxKnapsack.Show();
            listBoxKnapsack.Items.Clear();
            listBoxKnapsack.Location = new Point(lblAnsKnapsack.Location.X + 10, lblAnsKnapsack.Location.Y + lblAnsKnapsack.Height);
            ans.Clear();
            findAnsKnapsak(n, m, A);
            listBoxKnapsack.Items.Add("В рюкзак для максимізації цін:");
            foreach (int i in ans)
                listBoxKnapsack.Items.Add("Предмет № " + i);

            Panel4Tasks[1].Controls.Add(listBoxKnapsack);
            Panel4Tasks[1].Controls.Add(lblAnsKnapsack);
            Panel4Tasks[1].Controls.Add(lblMasD);
            Panel4Tasks[1].Controls.Add(dataGridMasKnapsack);
        }
        private void btnKnapsackRandom_Click(object sender, EventArgs e)//"Ввести випадково"
        {
            lblAnsKnapsack.Show();
            lblAnsKnapsack.Text = "Відповідь:";
            dataGridKnapsack.Rows.Clear();
            dataGridKnapsack.Columns.Clear();
            dataGridMasKnapsack.Rows.Clear();
            dataGridMasKnapsack.Columns.Clear();
            lblMasD.Location = new Point(dataGridKnapsack.Location.X + dataGridKnapsack.Width + 10, dataGridKnapsack.Location.Y);
            lblMasD.Font = lblNKnapsack.Font;
            lblMasD.Text = "Масив динаміки:";
            lblMasD.AutoSize = false;
            lblMasD.Size = new Size(400,50);
            dataGridMasKnapsack.Show();
            dataGridMasKnapsack.Location = new Point(dataGridKnapsack.Location.X + dataGridKnapsack.Width + 8, lblMasD.Location.Y + lblMasD.Height );
            dataGridMasKnapsack.Size = new Size(500,350);
            Random z = new Random();
            int n = Convert.ToInt32(txtNKnapsack.Text), m = Convert.ToInt32(txtMKnapsack.Text);

            dataGridKnapsack.Location = new Point(lblNKnapsack.Location.X, lblNKnapsack.Location.Y + lblNKnapsack.Height);
            dataGridKnapsack.Size = new Size(441, 400);
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
            for (int j = 1; j <= n; j++)
            {
                dataGridKnapsack[0, j].Value = "Предмет № " + j;
                dataGridKnapsack.Rows[j].Height = 40;
                dataGridKnapsack[1, j].Style.BackColor = Color.Chartreuse;
                dataGridKnapsack[2, j].Style.BackColor = Color.BurlyWood;
            }
            dataGridKnapsack.AutoResizeColumns();


            dataGridKnapsack.RowCount = n + 1;

            dataGridMasKnapsack.RowCount = n+1;
            dataGridMasKnapsack.ColumnCount = m+1;
            int[] w = new int[n+1];
            int[] p = new int[n+1];
            for(int i = 1; i <= n;i++)
            {
                w[i] = z.Next(1,30); //Convert.ToInt32(dataGridKnapsack.Rows[i].Cells[1].Value);
                p[i] = z.Next(1,50);// Convert.ToInt32(dataGridKnapsack.Rows[i].Cells[2].Value);
                dataGridKnapsack.Rows[i].Cells[1].Value = w[i] + "";
                dataGridKnapsack.Rows[i].Cells[2].Value = p[i] + "";
            }
            int[,] A = new int[n+1,m+1];
            for (int i = 0; i <= n; i++)
                A[i, 0] = 0;
            for (int i = 0; i <= m; i++)
                A[0, i] = 0;
            for (int i = 1; i <= n; i++)//i = k j = s
            {
                for(int j = 1; j <= m;j++)
                {
                    if (j >= w[i])
                        A[i, j] = Math.Max(A[i - 1, j], A[i - 1, j - w[i]] + p[i]);
                    else
                        A[i, j] = A[i - 1, j];
                }
            }
            for(int i = 0; i <= n;i++)
            {
                dataGridMasKnapsack.Rows[i].Height = 30;
                for (int j = 0; j <= m; j++)
                {
                    dataGridMasKnapsack[j, i].Style.Font = new Font(Name, 19, FontStyle.Regular);
                    dataGridMasKnapsack[j, i].Value = A[i, j] + "";
                    dataGridMasKnapsack.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            dataGridMasKnapsack.ClearSelection();//Убирает выдиление с первой ячейки таблицы
            dataGridMasKnapsack[m, n].Style.BackColor = Color.Gold;
            lblAnsKnapsack.Location = new Point(dataGridMasKnapsack.Location.X + dataGridMasKnapsack.Width, dataGridMasKnapsack.Location.Y);
            lblAnsKnapsack.Text += " " + A[n, m];
            listBoxKnapsack.Show();
            listBoxKnapsack.Items.Clear();
            listBoxKnapsack.Location = new Point(lblAnsKnapsack.Location.X + 10, lblAnsKnapsack.Location.Y + lblAnsKnapsack.Height);
            ans.Clear();
            findAnsKnapsak(n,m,A);
            listBoxKnapsack.Items.Add("В рюкзак для максимізації цін:");
            foreach (int i in ans)
                listBoxKnapsack.Items.Add("Предмет № " + i);

            Panel4Tasks[1].Controls.Add(listBoxKnapsack);
            Panel4Tasks[1].Controls.Add(lblAnsKnapsack);
            Panel4Tasks[1].Controls.Add(lblMasD);
            Panel4Tasks[1].Controls.Add(dataGridMasKnapsack);
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
        private void btnTheoryOfKnapsack_Click(object sender, EventArgs e)
        {
            theoryKnapsack.Show();
        }
        #endregion

        #region panel5(Підрахунок кількості способів)
        private void panel5()
        {
            p[5] = new Panel();
            p[0].Hide();
            p[5].Size = this.Size;
            p[5].Location = new Point(0,0);

            exit.Size = new Size(70, 70);
            exit.Location = new Point(this.Width - exit.Width - 50, 10);
            exit.BackgroundImage = Image.FromFile("back2.png");
            exit.BackgroundImageLayout = ImageLayout.Stretch;
            ExitPanel = 5;
            exit.Click += exit_Click;

            cmbTasksPanel5.Size = new Size(this.Width - 150, 5);
            cmbTasksPanel5.Location = new Point(5, exit.Location.Y);
            comboboxPanel5();
            cmbTasksPanel5.SelectedIndexChanged += changed5;

            p[5].Controls.Add(exit);
            p[5].Controls.Add(cmbTasksPanel5);
            this.Controls.Add(p[5]);
        }
        private void comboboxPanel5()
        {
            cmbTasksPanel5.Items.Clear();
            cmbTasksPanel5.Items.Add("Хід конем");
            for(int i = 0; i < 6; i++)
            {
                Panel5Tasks[i] = new Panel();
                Panel5Tasks[i].Size = new Size(this.Width, this.Height - (exit.Bottom + 30));
                Panel5Tasks[i].Location = new Point(0, exit.Bottom + 10);
                p[5].Controls.Add(Panel5Tasks[i]);
                Panel5Tasks[i].Hide();
            }
            cmbTasksPanel5.SelectedIndex = 0;
            changed5(new object(), new EventArgs());
        }
        private void changed5(object sender, EventArgs e)
        {
            Panel5Tasks[countPanel5].Hide();
            Panel5Tasks[cmbTasksPanel5.SelectedIndex].Show();
            countPanel5 = cmbTasksPanel5.SelectedIndex;
            if (cmbTasksPanel5.SelectedIndex == 0)
                Panel5Tasks0();
            if (cmbTasksPanel5.SelectedIndex == 1)
                Panel5Tasks1();
        }
        private void Panel5Tasks0()
        {
            pictureHorse.Show();
            btnTheoryOfHorse.Show();
            btnHorse.Show();
            txtNHorse.Show();
            txtMHorse.Show();
            lblMHorse.Show();
            lblNHorse.Show();
            lblUmovaHorse.Show();
            lblUmovaHorse.Location = new Point(cmbTasksPanel5.Location.X, cmbTasksPanel5.Location.Y);
            lblUmovaHorse.Size = new Size(1280, 150);
            lblUmovaHorse.Text = File.ReadAllText("Умова хід конем.txt");

         
            lblNHorse.Location = new Point(lblUmovaHorse.Location.X, lblUmovaHorse.Location.Y + lblUmovaHorse.Height);
            txtNHorse.Location = new Point(lblNHorse.Location.X + lblNHorse.Width + 10, lblNHorse.Location.Y);
            lblMHorse.Location = new Point(txtNHorse.Location.X + txtNHorse.Width + 20, txtNHorse.Location.Y);
            txtMHorse.Location = new Point(lblMHorse.Location.X + lblMHorse.Width + 10, lblMHorse.Location.Y);
            btnHorse.Location = new Point(txtMHorse.Location.X + txtMHorse.Width + 20, txtMHorse.Location.Y);
            txtNHorse.Text = "5";
            txtMHorse.Text = "9";
            btnTheoryOfHorse.Location = new Point(btnHorse.Location.X + btnHorse.Width + 60, btnHorse.Location.Y);
            pictureHorse.Location = new Point(btnTheoryOfHorse.Location.X + btnTheoryOfHorse.Width, 400);

            Panel5Tasks[0].Controls.Add(pictureHorse);
            Panel5Tasks[0].Controls.Add(btnTheoryOfHorse);
            Panel5Tasks[0].Controls.Add(btnHorse);
            Panel5Tasks[0].Controls.Add(lblNHorse);
            Panel5Tasks[0].Controls.Add(lblMHorse);
            Panel5Tasks[0].Controls.Add(txtMHorse);
            Panel5Tasks[0].Controls.Add(txtNHorse);
            Panel5Tasks[0].Controls.Add(lblUmovaHorse);
        }
        private void btnTheoryOfHorse_Click(object sender, EventArgs e)
        {
            theoryHorse.Show();
        }
        private void btnHorse_Click(object sender, EventArgs e)
        {
            lblAnsHorse.Text = "Відповідь: ";
            lblAnsHorse.Show();
            dataGridHorse.Show();
            int n, m;
            n = Convert.ToInt32(txtNHorse.Text);
            m = Convert.ToInt32(txtMHorse.Text);
            int[,] d = new int[n+2,m+2];
            dataGridHorse.RowCount = n;
            dataGridHorse.ColumnCount = m;
            dataGridHorse.Size = new Size(Panel5Tasks[0].Width / 2, 300);
            dataGridHorse.Location = new Point(lblNHorse.Location.X, lblNHorse.Location.Y + lblNHorse.Height + 20);
            dataGridHorse[0, 0].Style.BackColor = Color.Black;
            
            for (int i = 0; i < n + 2; i++)
            {
                for (int j = 0; j < m + 2; j++)
                    d[i, j] = 0;
                if(i < n)
                dataGridHorse.Rows[i].Height = 50;
            }
            d[2, 2] = 1;
            for(int i = 2; i < n+2; i++)
            {       
                for(int j = 2; j < m+2;j++)
                {
                    d[i, j] += d[i - 1, j  - 2] + d[i - 2, j - 1];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridHorse[j, i].Style.Font = new Font("Tahoma",23,FontStyle.Regular);
                    dataGridHorse[j, i].Value = d[i+2, j+2] + "";
                    if (d[i+2, j+2] != 0)
                        dataGridHorse[j, i].Style.BackColor = Color.Crimson;
                    else
                    dataGridHorse[j, i].Style.BackColor = Color.Cyan;
                    dataGridHorse.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            panelPodskazkaHorse2.Show();
            lblPodskHorse2.Show();
            panelPodskazkaHorse.Show();
            lblPodskazkaHorse.Show();
            lblAnsHorse.Text += d[n + 1,m + 1] + "";
            panelPodskazkaHorse.Location = new Point(dataGridHorse.Location.X + dataGridHorse.Width + 10, dataGridHorse.Location.Y + 10);
            lblPodskazkaHorse.Location = new Point(panelPodskazkaHorse.Location.X + panelPodskazkaHorse.Width + 10, panelPodskazkaHorse.Location.Y + 10);
            panelPodskazkaHorse2.Location = new Point(panelPodskazkaHorse.Location.X, panelPodskazkaHorse.Location.Y + panelPodskazkaHorse.Height + 10);
            lblPodskHorse2.Location = new Point(panelPodskazkaHorse2.Location.X + panelPodskazkaHorse2.Width + 10, panelPodskazkaHorse2.Location.Y + 10);

            lblAnsHorse.Location = new Point(dataGridHorse.Location.X + dataGridHorse.Width + 10, panelPodskazkaHorse2.Location.Y + panelPodskazkaHorse2.Height + 20);
            dataGridHorse.ClearSelection();

            Panel5Tasks[0].Controls.Add(panelPodskazkaHorse2);
            Panel5Tasks[0].Controls.Add(lblPodskHorse2);
            Panel5Tasks[0].Controls.Add(lblAnsHorse);
            Panel5Tasks[0].Controls.Add(lblPodskazkaHorse);
            Panel5Tasks[0].Controls.Add(panelPodskazkaHorse);
            Panel5Tasks[0].Controls.Add(dataGridHorse);
        }
        private void Panel5Tasks1()
        {

        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTheoryOfKnapsack.Hide();
            listBoxKnapsack.Hide();
            lblAnsKnapsack.Hide();
            dataGridMasKnapsack.Hide();
            dataGridKnapsack.Hide();
            btnKnapsackRandom.Hide();
            btnKnapsackVruch.Hide();
            pictureHorse.Hide();
            btnTheoryOfHorse.Hide();
            panelPodskazkaHorse2.Hide();
            lblPodskHorse2.Hide();
            lblPodskazkaHorse.Hide();
            panelPodskazkaHorse.Hide();
            lblAnsHorse.Hide();
            dataGridHorse.Hide();
            btnHorse.Hide();
            lblNHorse.Hide();
            lblMHorse.Hide();
            txtMHorse.Hide();
            txtNHorse.Hide();
            lblUmovaHorse.Hide();
            listBoxKvitki.Hide();
            lblAnsKvitki.Hide();
            ButtonDefinition.Cursor = Cursors.Hand;
            ButtonOptimality.Cursor = Cursors.Hand;
            ButtonString.Cursor = Cursors.Hand;
            ButtonWays.Cursor = Cursors.Hand;
            Buttonsequence.Cursor = Cursors.Hand;
            
            exit.Cursor = Cursors.Hand;
            dataGridKvitki2.Hide();
            dataGridKvitki.Hide();
            btnKvitkiRandom.Hide();
            btnTheoryOfKvitki.Hide();
            btnKvitkiVruch.Hide();
            lblNKvitki.Hide();
            txtNK.Hide();
            lblUmovaKvitki.Hide();
            panelPodskazka1Podstroka.Hide();
            panelPodskazka2Podstroka.Hide();
            panelPodskazka3Podstroka.Hide();
            btnTheoryOfPodstroka.Hide();
            lblAnsPodstroka.Hide();
            dataGridPodstroka.Hide();
            btnPodstroka.Hide();
            lblPodstrokaS1.Hide();
            lblPodstrokaS2.Hide();
            txtPodstrokaS1.Hide();
            txtPodstrokaS2.Hide();
            lblPodstroka.Hide();
            panelPodskazkaPodpalindrom1.Hide();
            panelPodskazkapodpalindrom2.Hide();
            txtNKvitki.Hide();
            lblAnsPodpalindrom.Hide();
            btnTheoryOfPolindrom.Hide();
            dataGridPodPalindrom.Hide();
            btnPodPalindrom.Hide();
            txtPodPolindrom.Hide();
            lblPodPalindrom.Hide();
            lblUmovaPolindrom.Hide();
            btnCodePodPosl.Hide();
            lblPnPodsk1.Hide();
            lblPnPodsk2.Hide();
            panelPodskazka1.Hide();
            panelPodskazka2.Hide();
            btnTheoryPodPosl.Hide();
            lblAnsPodPosl.Hide();
            vlasnoruchPT1.Hide();
            vypadlovoPT1.Hide();
            lblPodN.Hide();
            txtPodN.Hide();
            GridViewPod.Hide();
            UsloviyPodPosl.Hide();
            UsloviyThreeOne.Hide();
            ТриЕдин.Hide();
            thisSize = this.Size;
            this.Size = new Size(1330,720);//Ставим фиксированные размеры окна
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width-this.Width)/2,(Screen.PrimaryScreen.WorkingArea.Bottom - this.Height)/2);
            this.MaximizeBox = false;
            panel0(); //Панель-меню
        }

        //Обработчик события для кнопки "Визначення"
        private void ButtonDefinition_Click(object sender, EventArgs e)
        {
            panel1();
        }

        private void ExitTimer_Tick(object sender, EventArgs e)//Таймер, который убирает панель с экрана, и выставляет новую
        {
            time++;
            p[ExitPanel].Location = new Point(p[ExitPanel].Location.X - 10, p[ExitPanel].Location.Y);
            if (p[ExitPanel].Right < 0)
            {
                p[0].Show();
                ExitTimer.Stop();

            }
        }

        private void btnCodePodPosl_Click(object sender, EventArgs e)
        {
            codePodPosl.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try {
                this.Hide();
                bg.Show();
                e.Cancel = true;
            }catch
            {
                Application.Exit();
            }
        }
        



        #region Click on button EXIT(panel1)
        private void exit_Click(object sender,EventArgs e)
        {
            // ExitTimer.Start();
            p[ExitPanel].Hide();
            p[0].Show();
        }
        #endregion
    }
} 
