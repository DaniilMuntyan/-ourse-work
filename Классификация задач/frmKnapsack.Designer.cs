namespace Классификация_задач
{
    partial class frmKnapsack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKnapsack));
            this.listBoxKnapsack = new System.Windows.Forms.ListBox();
            this.lblAnsKnapsack = new System.Windows.Forms.Label();
            this.dataGridMasKnapsack = new System.Windows.Forms.DataGridView();
            this.dataGridKnapsack = new System.Windows.Forms.DataGridView();
            this.btnKnapsackRandom = new System.Windows.Forms.Button();
            this.btnKnapsackVruch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.umova = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNKnapsack = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMKnapsack = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMasKnapsack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKnapsack)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxKnapsack
            // 
            this.listBoxKnapsack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxKnapsack.FormattingEnabled = true;
            this.listBoxKnapsack.ItemHeight = 25;
            this.listBoxKnapsack.Location = new System.Drawing.Point(358, 457);
            this.listBoxKnapsack.Name = "listBoxKnapsack";
            this.listBoxKnapsack.Size = new System.Drawing.Size(476, 129);
            this.listBoxKnapsack.TabIndex = 74;
            // 
            // lblAnsKnapsack
            // 
            this.lblAnsKnapsack.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnsKnapsack.Location = new System.Drawing.Point(1, 503);
            this.lblAnsKnapsack.Name = "lblAnsKnapsack";
            this.lblAnsKnapsack.Size = new System.Drawing.Size(351, 37);
            this.lblAnsKnapsack.TabIndex = 73;
            this.lblAnsKnapsack.Text = "Відповідь:";
            // 
            // dataGridMasKnapsack
            // 
            this.dataGridMasKnapsack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridMasKnapsack.ColumnHeadersVisible = false;
            this.dataGridMasKnapsack.Location = new System.Drawing.Point(356, 303);
            this.dataGridMasKnapsack.Name = "dataGridMasKnapsack";
            this.dataGridMasKnapsack.ReadOnly = true;
            this.dataGridMasKnapsack.RowHeadersVisible = false;
            this.dataGridMasKnapsack.Size = new System.Drawing.Size(478, 148);
            this.dataGridMasKnapsack.TabIndex = 72;
            // 
            // dataGridKnapsack
            // 
            this.dataGridKnapsack.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridKnapsack.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridKnapsack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridKnapsack.ColumnHeadersVisible = false;
            this.dataGridKnapsack.Location = new System.Drawing.Point(7, 258);
            this.dataGridKnapsack.Name = "dataGridKnapsack";
            this.dataGridKnapsack.RowHeadersVisible = false;
            this.dataGridKnapsack.Size = new System.Drawing.Size(343, 225);
            this.dataGridKnapsack.TabIndex = 71;
            // 
            // btnKnapsackRandom
            // 
            this.btnKnapsackRandom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKnapsackRandom.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKnapsackRandom.Location = new System.Drawing.Point(579, 195);
            this.btnKnapsackRandom.Name = "btnKnapsackRandom";
            this.btnKnapsackRandom.Size = new System.Drawing.Size(255, 57);
            this.btnKnapsackRandom.TabIndex = 70;
            this.btnKnapsackRandom.Text = "Ввести випадково";
            this.btnKnapsackRandom.UseVisualStyleBackColor = true;
            this.btnKnapsackRandom.Click += new System.EventHandler(this.btnKnapsackRandom_Click);
            // 
            // btnKnapsackVruch
            // 
            this.btnKnapsackVruch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKnapsackVruch.Font = new System.Drawing.Font("Times New Roman", 21.75F);
            this.btnKnapsackVruch.Location = new System.Drawing.Point(316, 195);
            this.btnKnapsackVruch.Name = "btnKnapsackVruch";
            this.btnKnapsackVruch.Size = new System.Drawing.Size(255, 57);
            this.btnKnapsackVruch.TabIndex = 69;
            this.btnKnapsackVruch.Text = "Ввести власноруч";
            this.btnKnapsackVruch.UseVisualStyleBackColor = true;
            this.btnKnapsackVruch.Click += new System.EventHandler(this.btnKnapsackVruch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(180, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 31);
            this.label1.TabIndex = 76;
            this.label1.Text = "N = ";
            // 
            // umova
            // 
            this.umova.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.umova.Location = new System.Drawing.Point(1, 1);
            this.umova.Name = "umova";
            this.umova.Size = new System.Drawing.Size(763, 194);
            this.umova.TabIndex = 77;
            this.umova.Text = resources.GetString("umova.Text");
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(770, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 59);
            this.button1.TabIndex = 81;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 31);
            this.label2.TabIndex = 82;
            this.label2.Text = "N = ";
            // 
            // txtNKnapsack
            // 
            this.txtNKnapsack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNKnapsack.Location = new System.Drawing.Point(60, 198);
            this.txtNKnapsack.Name = "txtNKnapsack";
            this.txtNKnapsack.Size = new System.Drawing.Size(81, 38);
            this.txtNKnapsack.TabIndex = 83;
            this.txtNKnapsack.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(152, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 31);
            this.label3.TabIndex = 84;
            this.label3.Text = "W = ";
            // 
            // txtMKnapsack
            // 
            this.txtMKnapsack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMKnapsack.Location = new System.Drawing.Point(219, 198);
            this.txtMKnapsack.Name = "txtMKnapsack";
            this.txtMKnapsack.Size = new System.Drawing.Size(81, 38);
            this.txtMKnapsack.TabIndex = 85;
            this.txtMKnapsack.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(356, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 31);
            this.label4.TabIndex = 86;
            this.label4.Text = "Масив динаміки:";
            // 
            // frmKnapsack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 598);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMKnapsack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNKnapsack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.umova);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxKnapsack);
            this.Controls.Add(this.lblAnsKnapsack);
            this.Controls.Add(this.dataGridMasKnapsack);
            this.Controls.Add(this.dataGridKnapsack);
            this.Controls.Add(this.btnKnapsackRandom);
            this.Controls.Add(this.btnKnapsackVruch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmKnapsack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задача про рюкзак";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKnapsack_FormClosing);
            this.Load += new System.EventHandler(this.frmKnapsack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMasKnapsack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKnapsack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxKnapsack;
        private System.Windows.Forms.Label lblAnsKnapsack;
        private System.Windows.Forms.DataGridView dataGridMasKnapsack;
        private System.Windows.Forms.DataGridView dataGridKnapsack;
        private System.Windows.Forms.Button btnKnapsackRandom;
        private System.Windows.Forms.Button btnKnapsackVruch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label umova;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNKnapsack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMKnapsack;
        private System.Windows.Forms.Label label4;
    }
}