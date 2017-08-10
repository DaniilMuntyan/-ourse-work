namespace Классификация_задач
{
    partial class frmHorse
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHorse));
            this.pictureHorse = new System.Windows.Forms.PictureBox();
            this.lblPodskHorse2 = new System.Windows.Forms.Label();
            this.panelPodskazkaHorse2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPodskazkaHorse = new System.Windows.Forms.Label();
            this.panelPodskazkaHorse = new System.Windows.Forms.Panel();
            this.dataGridHorse = new System.Windows.Forms.DataGridView();
            this.lblAnsHorse = new System.Windows.Forms.Label();
            this.btnHorse = new System.Windows.Forms.Button();
            this.txtMHorse = new System.Windows.Forms.TextBox();
            this.txtNHorse = new System.Windows.Forms.TextBox();
            this.lblMHorse = new System.Windows.Forms.Label();
            this.lblNHorse = new System.Windows.Forms.Label();
            this.lblUmovaHorse = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pctNew = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHorse)).BeginInit();
            this.panelPodskazkaHorse2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHorse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNew)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureHorse
            // 
            this.pictureHorse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureHorse.BackgroundImage")));
            this.pictureHorse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureHorse.ImageLocation = "";
            this.pictureHorse.Location = new System.Drawing.Point(662, 256);
            this.pictureHorse.Name = "pictureHorse";
            this.pictureHorse.Size = new System.Drawing.Size(178, 181);
            this.pictureHorse.TabIndex = 73;
            this.pictureHorse.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureHorse, "Вивести будь-який маршрут");
            this.pictureHorse.Click += new System.EventHandler(this.pictureHorse_Click);
            // 
            // lblPodskHorse2
            // 
            this.lblPodskHorse2.Location = new System.Drawing.Point(87, 564);
            this.lblPodskHorse2.Name = "lblPodskHorse2";
            this.lblPodskHorse2.Size = new System.Drawing.Size(325, 60);
            this.lblPodskHorse2.TabIndex = 71;
            this.lblPodskHorse2.Text = "- позначаються пройдені конем елементи";
            // 
            // panelPodskazkaHorse2
            // 
            this.panelPodskazkaHorse2.BackColor = System.Drawing.Color.DarkViolet;
            this.panelPodskazkaHorse2.Controls.Add(this.label1);
            this.panelPodskazkaHorse2.Location = new System.Drawing.Point(12, 560);
            this.panelPodskazkaHorse2.Name = "panelPodskazkaHorse2";
            this.panelPodskazkaHorse2.Size = new System.Drawing.Size(69, 69);
            this.panelPodskazkaHorse2.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "✕";
            // 
            // lblPodskazkaHorse
            // 
            this.lblPodskazkaHorse.Location = new System.Drawing.Point(501, 564);
            this.lblPodskazkaHorse.Name = "lblPodskazkaHorse";
            this.lblPodskazkaHorse.Size = new System.Drawing.Size(387, 60);
            this.lblPodskazkaHorse.TabIndex = 70;
            this.lblPodskazkaHorse.Text = "- позначаються елементи, в які ми можемо піти конем (згідно з умовою)";
            // 
            // panelPodskazkaHorse
            // 
            this.panelPodskazkaHorse.BackColor = System.Drawing.Color.Blue;
            this.panelPodskazkaHorse.Location = new System.Drawing.Point(426, 560);
            this.panelPodskazkaHorse.Name = "panelPodskazkaHorse";
            this.panelPodskazkaHorse.Size = new System.Drawing.Size(69, 69);
            this.panelPodskazkaHorse.TabIndex = 68;
            // 
            // dataGridHorse
            // 
            this.dataGridHorse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridHorse.ColumnHeadersVisible = false;
            this.dataGridHorse.Location = new System.Drawing.Point(6, 256);
            this.dataGridHorse.Name = "dataGridHorse";
            this.dataGridHorse.ReadOnly = true;
            this.dataGridHorse.RowHeadersVisible = false;
            this.dataGridHorse.Size = new System.Drawing.Size(587, 298);
            this.dataGridHorse.TabIndex = 67;
            // 
            // lblAnsHorse
            // 
            this.lblAnsHorse.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnsHorse.Location = new System.Drawing.Point(599, 455);
            this.lblAnsHorse.Name = "lblAnsHorse";
            this.lblAnsHorse.Size = new System.Drawing.Size(284, 109);
            this.lblAnsHorse.TabIndex = 66;
            this.lblAnsHorse.Text = "Відповідь:";
            // 
            // btnHorse
            // 
            this.btnHorse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHorse.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHorse.Location = new System.Drawing.Point(658, 185);
            this.btnHorse.Name = "btnHorse";
            this.btnHorse.Size = new System.Drawing.Size(186, 62);
            this.btnHorse.TabIndex = 65;
            this.btnHorse.Text = "Почати";
            this.btnHorse.UseVisualStyleBackColor = true;
            this.btnHorse.Click += new System.EventHandler(this.btnHorse_Click);
            // 
            // txtMHorse
            // 
            this.txtMHorse.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMHorse.Location = new System.Drawing.Point(491, 195);
            this.txtMHorse.Name = "txtMHorse";
            this.txtMHorse.Size = new System.Drawing.Size(102, 46);
            this.txtMHorse.TabIndex = 64;
            this.txtMHorse.Text = "9";
            // 
            // txtNHorse
            // 
            this.txtNHorse.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNHorse.Location = new System.Drawing.Point(175, 196);
            this.txtNHorse.Name = "txtNHorse";
            this.txtNHorse.Size = new System.Drawing.Size(102, 46);
            this.txtNHorse.TabIndex = 63;
            this.txtNHorse.Text = "5";
            // 
            // lblMHorse
            // 
            this.lblMHorse.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMHorse.Location = new System.Drawing.Point(294, 194);
            this.lblMHorse.Name = "lblMHorse";
            this.lblMHorse.Size = new System.Drawing.Size(191, 47);
            this.lblMHorse.TabIndex = 62;
            this.lblMHorse.Text = "Введіть M:";
            // 
            // lblNHorse
            // 
            this.lblNHorse.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNHorse.Location = new System.Drawing.Point(-2, 195);
            this.lblNHorse.Name = "lblNHorse";
            this.lblNHorse.Size = new System.Drawing.Size(183, 58);
            this.lblNHorse.TabIndex = 61;
            this.lblNHorse.Text = "Введіть N:";
            // 
            // lblUmovaHorse
            // 
            this.lblUmovaHorse.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUmovaHorse.Location = new System.Drawing.Point(1, 3);
            this.lblUmovaHorse.Name = "lblUmovaHorse";
            this.lblUmovaHorse.Size = new System.Drawing.Size(806, 192);
            this.lblUmovaHorse.TabIndex = 60;
            this.lblUmovaHorse.Text = resources.GetString("lblUmovaHorse.Text");
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(813, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 59);
            this.button1.TabIndex = 81;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pctNew
            // 
            this.pctNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctNew.BackgroundImage")));
            this.pctNew.Cursor = System.Windows.Forms.Cursors.No;
            this.pctNew.ImageLocation = "";
            this.pctNew.Location = new System.Drawing.Point(662, 256);
            this.pctNew.Name = "pctNew";
            this.pctNew.Size = new System.Drawing.Size(178, 181);
            this.pctNew.TabIndex = 82;
            this.pctNew.TabStop = false;
            this.toolTip1.SetToolTip(this.pctNew, "Заблоковано");
            // 
            // timer1
            // 
            this.timer1.Interval = 510;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmHorse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 633);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPodskHorse2);
            this.Controls.Add(this.panelPodskazkaHorse2);
            this.Controls.Add(this.lblPodskazkaHorse);
            this.Controls.Add(this.panelPodskazkaHorse);
            this.Controls.Add(this.dataGridHorse);
            this.Controls.Add(this.lblAnsHorse);
            this.Controls.Add(this.btnHorse);
            this.Controls.Add(this.txtMHorse);
            this.Controls.Add(this.txtNHorse);
            this.Controls.Add(this.lblMHorse);
            this.Controls.Add(this.lblNHorse);
            this.Controls.Add(this.lblUmovaHorse);
            this.Controls.Add(this.pctNew);
            this.Controls.Add(this.pictureHorse);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmHorse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задача хід конем";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHorse_FormClosing);
            this.Load += new System.EventHandler(this.frmHorse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHorse)).EndInit();
            this.panelPodskazkaHorse2.ResumeLayout(false);
            this.panelPodskazkaHorse2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHorse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureHorse;
        private System.Windows.Forms.Label lblPodskHorse2;
        private System.Windows.Forms.Panel panelPodskazkaHorse2;
        private System.Windows.Forms.Label lblPodskazkaHorse;
        private System.Windows.Forms.Panel panelPodskazkaHorse;
        private System.Windows.Forms.DataGridView dataGridHorse;
        private System.Windows.Forms.Label lblAnsHorse;
        private System.Windows.Forms.Button btnHorse;
        private System.Windows.Forms.TextBox txtMHorse;
        private System.Windows.Forms.TextBox txtNHorse;
        private System.Windows.Forms.Label lblMHorse;
        private System.Windows.Forms.Label lblNHorse;
        private System.Windows.Forms.Label lblUmovaHorse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pctNew;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}