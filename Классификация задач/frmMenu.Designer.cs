namespace Классификация_задач
{
    partial class frmMenu
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
            this.btnDefinition = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKilAndSum = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRec = new System.Windows.Forms.Button();
            this.btnOptL = new System.Windows.Forms.Button();
            this.btnTheory = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDefinition
            // 
            this.btnDefinition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDefinition.Location = new System.Drawing.Point(227, 93);
            this.btnDefinition.Name = "btnDefinition";
            this.btnDefinition.Size = new System.Drawing.Size(274, 53);
            this.btnDefinition.TabIndex = 2;
            this.btnDefinition.Text = "Визначення";
            this.btnDefinition.UseVisualStyleBackColor = true;
            this.btnDefinition.Click += new System.EventHandler(this.btnDefinition_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(102, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Динамічне програмування";
            // 
            // btnKilAndSum
            // 
            this.btnKilAndSum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKilAndSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKilAndSum.Location = new System.Drawing.Point(32, 57);
            this.btnKilAndSum.Name = "btnKilAndSum";
            this.btnKilAndSum.Size = new System.Drawing.Size(454, 52);
            this.btnKilAndSum.TabIndex = 6;
            this.btnKilAndSum.Text = "Оптимальна кількість та сума";
            this.btnKilAndSum.UseVisualStyleBackColor = true;
            this.btnKilAndSum.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRec);
            this.groupBox4.Controls.Add(this.btnOptL);
            this.groupBox4.Controls.Add(this.btnKilAndSum);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(110, 209);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(517, 239);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Задачі";
            // 
            // btnRec
            // 
            this.btnRec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRec.Location = new System.Drawing.Point(32, 171);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(454, 50);
            this.btnRec.TabIndex = 8;
            this.btnRec.Text = "Рекурентна формула";
            this.btnRec.UseVisualStyleBackColor = true;
            this.btnRec.Click += new System.EventHandler(this.btnRec_Click);
            // 
            // btnOptL
            // 
            this.btnOptL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptL.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOptL.Location = new System.Drawing.Point(32, 115);
            this.btnOptL.Name = "btnOptL";
            this.btnOptL.Size = new System.Drawing.Size(454, 50);
            this.btnOptL.TabIndex = 7;
            this.btnOptL.Text = "Оптимальний шлях";
            this.btnOptL.UseVisualStyleBackColor = true;
            this.btnOptL.Click += new System.EventHandler(this.btnOptL_Click);
            // 
            // btnTheory
            // 
            this.btnTheory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTheory.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTheory.Location = new System.Drawing.Point(227, 152);
            this.btnTheory.Name = "btnTheory";
            this.btnTheory.Size = new System.Drawing.Size(274, 53);
            this.btnTheory.TabIndex = 3;
            this.btnTheory.Text = "Теорія до задач";
            this.btnTheory.UseVisualStyleBackColor = true;
            this.btnTheory.Click += new System.EventHandler(this.btnTheory_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 466);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTheory);
            this.Controls.Add(this.btnDefinition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDefinition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKilAndSum;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRec;
        private System.Windows.Forms.Button btnOptL;
        private System.Windows.Forms.Button btnTheory;
    }
}