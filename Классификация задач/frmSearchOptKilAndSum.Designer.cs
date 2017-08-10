namespace Классификация_задач
{
    partial class frmSearchOptKilAndSum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.p1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblCalc1 = new System.Windows.Forms.Label();
            this.lblKnapsack1 = new System.Windows.Forms.Label();
            this.lblCalc = new System.Windows.Forms.Label();
            this.lblKnapsack = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMaxPodposl1 = new System.Windows.Forms.Label();
            this.lblPodstroka1 = new System.Windows.Forms.Label();
            this.lblMaxPodposl = new System.Windows.Forms.Label();
            this.lblPodstroka = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPodpalindrom1 = new System.Windows.Forms.Label();
            this.lblPodpalindrom = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblKvitki1 = new System.Windows.Forms.Label();
            this.lblPlSh1 = new System.Windows.Forms.Label();
            this.lblTri1 = new System.Windows.Forms.Label();
            this.lblKvitki = new System.Windows.Forms.Label();
            this.lblPlSh = new System.Windows.Forms.Label();
            this.lblTrian = new System.Windows.Forms.Label();
            this.p1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.Controls.Add(this.groupBox4);
            this.p1.Controls.Add(this.groupBox3);
            this.p1.Controls.Add(this.groupBox1);
            this.p1.Controls.Add(this.groupBox2);
            this.p1.Location = new System.Drawing.Point(0, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(792, 500);
            this.p1.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblCalc1);
            this.groupBox4.Controls.Add(this.lblKnapsack1);
            this.groupBox4.Controls.Add(this.lblCalc);
            this.groupBox4.Controls.Add(this.lblKnapsack);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(444, 234);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(338, 261);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Шляхом від результату до оптимізації";
            // 
            // lblCalc1
            // 
            this.lblCalc1.AutoSize = true;
            this.lblCalc1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCalc1.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalc1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCalc1.Location = new System.Drawing.Point(55, 150);
            this.lblCalc1.Name = "lblCalc1";
            this.lblCalc1.Size = new System.Drawing.Size(240, 42);
            this.lblCalc1.TabIndex = 8;
            this.lblCalc1.Text = "Калькулятор";
            this.lblCalc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCalc1.Visible = false;
            this.lblCalc1.Click += new System.EventHandler(this.lblCalc1_Click);
            this.lblCalc1.MouseLeave += new System.EventHandler(this.lblCalc1_MouseLeave);
            // 
            // lblKnapsack1
            // 
            this.lblKnapsack1.AutoSize = true;
            this.lblKnapsack1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKnapsack1.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKnapsack1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKnapsack1.Location = new System.Drawing.Point(7, 87);
            this.lblKnapsack1.Name = "lblKnapsack1";
            this.lblKnapsack1.Size = new System.Drawing.Size(337, 42);
            this.lblKnapsack1.TabIndex = 7;
            this.lblKnapsack1.Text = "Задача про рюкзак";
            this.lblKnapsack1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKnapsack1.Click += new System.EventHandler(this.lblKnapsack1_Click);
            this.lblKnapsack1.MouseLeave += new System.EventHandler(this.lblKnapsack1_MouseLeave);
            // 
            // lblCalc
            // 
            this.lblCalc.AutoSize = true;
            this.lblCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCalc.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalc.Location = new System.Drawing.Point(59, 152);
            this.lblCalc.Name = "lblCalc";
            this.lblCalc.Size = new System.Drawing.Size(227, 40);
            this.lblCalc.TabIndex = 6;
            this.lblCalc.Text = "Калькулятор";
            this.lblCalc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCalc.MouseEnter += new System.EventHandler(this.lblCalc_MouseEnter);
            // 
            // lblKnapsack
            // 
            this.lblKnapsack.AutoSize = true;
            this.lblKnapsack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKnapsack.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKnapsack.Location = new System.Drawing.Point(13, 89);
            this.lblKnapsack.Name = "lblKnapsack";
            this.lblKnapsack.Size = new System.Drawing.Size(319, 40);
            this.lblKnapsack.TabIndex = 5;
            this.lblKnapsack.Text = "Задача про рюкзак";
            this.lblKnapsack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKnapsack.MouseEnter += new System.EventHandler(this.lblKnapsack_MouseEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblMaxPodposl1);
            this.groupBox3.Controls.Add(this.lblPodstroka1);
            this.groupBox3.Controls.Add(this.lblMaxPodposl);
            this.groupBox3.Controls.Add(this.lblPodstroka);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(11, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 261);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Максимальна кількість елементів у визначеному порядку";
            // 
            // lblMaxPodposl1
            // 
            this.lblMaxPodposl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMaxPodposl1.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaxPodposl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMaxPodposl1.Location = new System.Drawing.Point(1, 162);
            this.lblMaxPodposl1.Name = "lblMaxPodposl1";
            this.lblMaxPodposl1.Size = new System.Drawing.Size(417, 91);
            this.lblMaxPodposl1.TabIndex = 8;
            this.lblMaxPodposl1.Text = "Найбільша зростаюча підпослідовність";
            this.lblMaxPodposl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMaxPodposl1.Visible = false;
            this.lblMaxPodposl1.Click += new System.EventHandler(this.lblMaxPodposl1_Click);
            this.lblMaxPodposl1.MouseLeave += new System.EventHandler(this.lblMaxPodposl1_MouseLeave);
            // 
            // lblPodstroka1
            // 
            this.lblPodstroka1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPodstroka1.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPodstroka1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPodstroka1.Location = new System.Drawing.Point(4, 60);
            this.lblPodstroka1.Name = "lblPodstroka1";
            this.lblPodstroka1.Size = new System.Drawing.Size(407, 98);
            this.lblPodstroka1.TabIndex = 7;
            this.lblPodstroka1.Text = "Найбільший спільний підрядок";
            this.lblPodstroka1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPodstroka1.Click += new System.EventHandler(this.lblPodstroka1_Click);
            this.lblPodstroka1.MouseLeave += new System.EventHandler(this.lblPodstroka1_MouseLeave);
            // 
            // lblMaxPodposl
            // 
            this.lblMaxPodposl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMaxPodposl.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaxPodposl.Location = new System.Drawing.Point(6, 167);
            this.lblMaxPodposl.Name = "lblMaxPodposl";
            this.lblMaxPodposl.Size = new System.Drawing.Size(401, 81);
            this.lblMaxPodposl.TabIndex = 6;
            this.lblMaxPodposl.Text = "Найбільша зростаюча підпослідовність";
            this.lblMaxPodposl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMaxPodposl.MouseEnter += new System.EventHandler(this.lblMaxPodposl_MouseEnter);
            // 
            // lblPodstroka
            // 
            this.lblPodstroka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPodstroka.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPodstroka.Location = new System.Drawing.Point(6, 69);
            this.lblPodstroka.Name = "lblPodstroka";
            this.lblPodstroka.Size = new System.Drawing.Size(401, 81);
            this.lblPodstroka.TabIndex = 5;
            this.lblPodstroka.Text = "Найбільший спільний підрядок";
            this.lblPodstroka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPodstroka.Click += new System.EventHandler(this.lblPodstroka_Click);
            this.lblPodstroka.MouseEnter += new System.EventHandler(this.lblPodstroka_MouseEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPodpalindrom1);
            this.groupBox1.Controls.Add(this.lblPodpalindrom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(414, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 216);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Максимальна к-сть елементів";
            // 
            // lblPodpalindrom1
            // 
            this.lblPodpalindrom1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPodpalindrom1.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPodpalindrom1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPodpalindrom1.Location = new System.Drawing.Point(43, 75);
            this.lblPodpalindrom1.Name = "lblPodpalindrom1";
            this.lblPodpalindrom1.Size = new System.Drawing.Size(283, 85);
            this.lblPodpalindrom1.TabIndex = 7;
            this.lblPodpalindrom1.Text = "Максимальний підпаліндром";
            this.lblPodpalindrom1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPodpalindrom1.Visible = false;
            this.lblPodpalindrom1.Click += new System.EventHandler(this.lblPodpalindrom1_Click);
            this.lblPodpalindrom1.MouseLeave += new System.EventHandler(this.lblPodpalindrom1_MouseLeave);
            // 
            // lblPodpalindrom
            // 
            this.lblPodpalindrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPodpalindrom.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPodpalindrom.Location = new System.Drawing.Point(47, 78);
            this.lblPodpalindrom.Name = "lblPodpalindrom";
            this.lblPodpalindrom.Size = new System.Drawing.Size(269, 81);
            this.lblPodpalindrom.TabIndex = 6;
            this.lblPodpalindrom.Text = "Максимальний підпаліндром";
            this.lblPodpalindrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPodpalindrom.Click += new System.EventHandler(this.lblPodpalindrom_Click);
            this.lblPodpalindrom.MouseEnter += new System.EventHandler(this.lblPodpalindrom_MouseEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblKvitki1);
            this.groupBox2.Controls.Add(this.lblPlSh1);
            this.groupBox2.Controls.Add(this.lblTri1);
            this.groupBox2.Controls.Add(this.lblKvitki);
            this.groupBox2.Controls.Add(this.lblPlSh);
            this.groupBox2.Controls.Add(this.lblTrian);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(11, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 222);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Шляхом від оптимізації до результату";
            // 
            // lblKvitki1
            // 
            this.lblKvitki1.AutoSize = true;
            this.lblKvitki1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKvitki1.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKvitki1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKvitki1.Location = new System.Drawing.Point(53, 170);
            this.lblKvitki1.Name = "lblKvitki1";
            this.lblKvitki1.Size = new System.Drawing.Size(295, 42);
            this.lblKvitki1.TabIndex = 8;
            this.lblKvitki1.Text = "Купівля квитків";
            this.lblKvitki1.Visible = false;
            this.lblKvitki1.Click += new System.EventHandler(this.lblKvitki1_Click);
            this.lblKvitki1.MouseLeave += new System.EventHandler(this.lblKvitki1_MouseLeave);
            // 
            // lblPlSh1
            // 
            this.lblPlSh1.AutoSize = true;
            this.lblPlSh1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPlSh1.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlSh1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPlSh1.Location = new System.Drawing.Point(74, 117);
            this.lblPlSh1.Name = "lblPlSh1";
            this.lblPlSh1.Size = new System.Drawing.Size(235, 42);
            this.lblPlSh1.TabIndex = 7;
            this.lblPlSh1.Text = "Платні сходи";
            this.lblPlSh1.Visible = false;
            this.lblPlSh1.Click += new System.EventHandler(this.lblPlSh1_Click);
            this.lblPlSh1.MouseLeave += new System.EventHandler(this.lblPlSh1_MouseLeave);
            // 
            // lblTri1
            // 
            this.lblTri1.AutoSize = true;
            this.lblTri1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTri1.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTri1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTri1.Location = new System.Drawing.Point(89, 65);
            this.lblTri1.Name = "lblTri1";
            this.lblTri1.Size = new System.Drawing.Size(204, 42);
            this.lblTri1.TabIndex = 6;
            this.lblTri1.Text = "Трикутник";
            this.lblTri1.Visible = false;
            this.lblTri1.Click += new System.EventHandler(this.lblTri1_Click);
            this.lblTri1.MouseLeave += new System.EventHandler(this.lblTri1_MouseLeave);
            // 
            // lblKvitki
            // 
            this.lblKvitki.AutoSize = true;
            this.lblKvitki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKvitki.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKvitki.Location = new System.Drawing.Point(59, 172);
            this.lblKvitki.Name = "lblKvitki";
            this.lblKvitki.Size = new System.Drawing.Size(278, 40);
            this.lblKvitki.TabIndex = 5;
            this.lblKvitki.Text = "Купівля квитків";
            this.lblKvitki.Click += new System.EventHandler(this.lblKvitki_Click);
            this.lblKvitki.MouseEnter += new System.EventHandler(this.lblKvitki_MouseEnter);
            // 
            // lblPlSh
            // 
            this.lblPlSh.AutoSize = true;
            this.lblPlSh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPlSh.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlSh.Location = new System.Drawing.Point(78, 119);
            this.lblPlSh.Name = "lblPlSh";
            this.lblPlSh.Size = new System.Drawing.Size(224, 40);
            this.lblPlSh.TabIndex = 4;
            this.lblPlSh.Text = "Платні сходи";
            this.lblPlSh.Click += new System.EventHandler(this.lblPlSh_Click);
            this.lblPlSh.MouseEnter += new System.EventHandler(this.lblPlSh_MouseEnter);
            // 
            // lblTrian
            // 
            this.lblTrian.AutoSize = true;
            this.lblTrian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTrian.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTrian.Location = new System.Drawing.Point(93, 66);
            this.lblTrian.Name = "lblTrian";
            this.lblTrian.Size = new System.Drawing.Size(192, 40);
            this.lblTrian.TabIndex = 3;
            this.lblTrian.Text = "Трикутник";
            this.lblTrian.Click += new System.EventHandler(this.lblTrian_Click);
            this.lblTrian.MouseEnter += new System.EventHandler(this.lblTrian_MouseEnter);
            // 
            // frmSearchOptKilAndSum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 502);
            this.Controls.Add(this.p1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmSearchOptKilAndSum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задачі на пошук оптимальної кількості і суми";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSearchOptKilAndSum_FormClosing);
            this.Load += new System.EventHandler(this.frmSearchOptKilAndSum_Load);
            this.p1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblKvitki;
        private System.Windows.Forms.Label lblPlSh;
        private System.Windows.Forms.Label lblTrian;
        private System.Windows.Forms.Label lblPodstroka;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblCalc;
        private System.Windows.Forms.Label lblKnapsack;
        private System.Windows.Forms.Label lblMaxPodposl;
        private System.Windows.Forms.Label lblPodpalindrom;
        private System.Windows.Forms.Label lblTri1;
        private System.Windows.Forms.Label lblPlSh1;
        private System.Windows.Forms.Label lblKvitki1;
        private System.Windows.Forms.Label lblPodpalindrom1;
        private System.Windows.Forms.Label lblPodstroka1;
        private System.Windows.Forms.Label lblMaxPodposl1;
        private System.Windows.Forms.Label lblKnapsack1;
        private System.Windows.Forms.Label lblCalc1;
    }
}