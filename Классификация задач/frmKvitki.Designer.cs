namespace Классификация_задач
{
    partial class frmKvitki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKvitki));
            this.listBoxKvitki = new System.Windows.Forms.ListBox();
            this.dataGridKvitki2 = new System.Windows.Forms.DataGridView();
            this.dataGridKvitki = new System.Windows.Forms.DataGridView();
            this.btnKvitkiVruch = new System.Windows.Forms.Button();
            this.btnKvitkiRandom = new System.Windows.Forms.Button();
            this.txtNK = new System.Windows.Forms.TextBox();
            this.lblNKvitki = new System.Windows.Forms.Label();
            this.lblUmovaKvitki = new System.Windows.Forms.Label();
            this.lblAnsKvitki = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKvitki2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKvitki)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxKvitki
            // 
            this.listBoxKvitki.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxKvitki.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxKvitki.FormattingEnabled = true;
            this.listBoxKvitki.ItemHeight = 25;
            this.listBoxKvitki.Location = new System.Drawing.Point(357, 284);
            this.listBoxKvitki.Name = "listBoxKvitki";
            this.listBoxKvitki.Size = new System.Drawing.Size(463, 229);
            this.listBoxKvitki.TabIndex = 78;
            // 
            // dataGridKvitki2
            // 
            this.dataGridKvitki2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridKvitki2.ColumnHeadersVisible = false;
            this.dataGridKvitki2.Location = new System.Drawing.Point(209, 295);
            this.dataGridKvitki2.Name = "dataGridKvitki2";
            this.dataGridKvitki2.RowHeadersVisible = false;
            this.dataGridKvitki2.Size = new System.Drawing.Size(371, 93);
            this.dataGridKvitki2.TabIndex = 77;
            // 
            // dataGridKvitki
            // 
            this.dataGridKvitki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridKvitki.ColumnHeadersVisible = false;
            this.dataGridKvitki.Location = new System.Drawing.Point(146, 215);
            this.dataGridKvitki.Name = "dataGridKvitki";
            this.dataGridKvitki.RowHeadersVisible = false;
            this.dataGridKvitki.Size = new System.Drawing.Size(371, 93);
            this.dataGridKvitki.TabIndex = 76;
            // 
            // btnKvitkiVruch
            // 
            this.btnKvitkiVruch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKvitkiVruch.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKvitkiVruch.Location = new System.Drawing.Point(102, 250);
            this.btnKvitkiVruch.Name = "btnKvitkiVruch";
            this.btnKvitkiVruch.Size = new System.Drawing.Size(297, 58);
            this.btnKvitkiVruch.TabIndex = 75;
            this.btnKvitkiVruch.Text = "Ввести власноруч";
            this.btnKvitkiVruch.UseVisualStyleBackColor = true;
            this.btnKvitkiVruch.Click += new System.EventHandler(this.btnKvitkiVruch_Click_1);
            // 
            // btnKvitkiRandom
            // 
            this.btnKvitkiRandom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKvitkiRandom.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKvitkiRandom.Location = new System.Drawing.Point(102, 231);
            this.btnKvitkiRandom.Name = "btnKvitkiRandom";
            this.btnKvitkiRandom.Size = new System.Drawing.Size(297, 58);
            this.btnKvitkiRandom.TabIndex = 74;
            this.btnKvitkiRandom.Text = "Ввести випадково";
            this.btnKvitkiRandom.UseVisualStyleBackColor = true;
            this.btnKvitkiRandom.Click += new System.EventHandler(this.btnKvitkiRandom_Click_1);
            // 
            // txtNK
            // 
            this.txtNK.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNK.Location = new System.Drawing.Point(189, 138);
            this.txtNK.Name = "txtNK";
            this.txtNK.Size = new System.Drawing.Size(106, 46);
            this.txtNK.TabIndex = 72;
            // 
            // lblNKvitki
            // 
            this.lblNKvitki.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNKvitki.Location = new System.Drawing.Point(12, 141);
            this.lblNKvitki.Name = "lblNKvitki";
            this.lblNKvitki.Size = new System.Drawing.Size(171, 45);
            this.lblNKvitki.TabIndex = 71;
            this.lblNKvitki.Text = "Введіть N: ";
            // 
            // lblUmovaKvitki
            // 
            this.lblUmovaKvitki.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUmovaKvitki.Location = new System.Drawing.Point(12, 9);
            this.lblUmovaKvitki.Name = "lblUmovaKvitki";
            this.lblUmovaKvitki.Size = new System.Drawing.Size(379, 106);
            this.lblUmovaKvitki.TabIndex = 70;
            this.lblUmovaKvitki.Text = resources.GetString("lblUmovaKvitki.Text");
            // 
            // lblAnsKvitki
            // 
            this.lblAnsKvitki.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnsKvitki.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblAnsKvitki.Location = new System.Drawing.Point(74, 542);
            this.lblAnsKvitki.Name = "lblAnsKvitki";
            this.lblAnsKvitki.Size = new System.Drawing.Size(351, 37);
            this.lblAnsKvitki.TabIndex = 79;
            this.lblAnsKvitki.Text = "Відповідь:";
            this.lblAnsKvitki.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(970, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 59);
            this.button1.TabIndex = 80;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmKvitki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAnsKvitki);
            this.Controls.Add(this.listBoxKvitki);
            this.Controls.Add(this.dataGridKvitki2);
            this.Controls.Add(this.dataGridKvitki);
            this.Controls.Add(this.btnKvitkiVruch);
            this.Controls.Add(this.btnKvitkiRandom);
            this.Controls.Add(this.txtNK);
            this.Controls.Add(this.lblNKvitki);
            this.Controls.Add(this.lblUmovaKvitki);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmKvitki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задача купівля квитків";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKvitki_FormClosing);
            this.Load += new System.EventHandler(this.frmKvitki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKvitki2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKvitki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxKvitki;
        private System.Windows.Forms.DataGridView dataGridKvitki2;
        private System.Windows.Forms.DataGridView dataGridKvitki;
        private System.Windows.Forms.Button btnKvitkiVruch;
        private System.Windows.Forms.Button btnKvitkiRandom;
        private System.Windows.Forms.TextBox txtNK;
        private System.Windows.Forms.Label lblNKvitki;
        private System.Windows.Forms.Label lblUmovaKvitki;
        private System.Windows.Forms.Label lblAnsKvitki;
        private System.Windows.Forms.Button button1;
    }
}