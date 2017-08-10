namespace Классификация_задач
{
    partial class frmPodposl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPodposl));
            this.lblPnPodsk2 = new System.Windows.Forms.Label();
            this.lblPnPodsk1 = new System.Windows.Forms.Label();
            this.panelPodskazka2 = new System.Windows.Forms.Panel();
            this.lblAnsPodPosl = new System.Windows.Forms.Label();
            this.panelPodskazka1 = new System.Windows.Forms.Panel();
            this.vlasnoruchPT1 = new System.Windows.Forms.Button();
            this.vypadlovoPT1 = new System.Windows.Forms.Button();
            this.txtPodN = new System.Windows.Forms.TextBox();
            this.lblPodN = new System.Windows.Forms.Label();
            this.GridViewPod = new System.Windows.Forms.DataGridView();
            this.UsloviyPodPosl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPod)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPnPodsk2
            // 
            this.lblPnPodsk2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPnPodsk2.Location = new System.Drawing.Point(77, 489);
            this.lblPnPodsk2.Name = "lblPnPodsk2";
            this.lblPnPodsk2.Size = new System.Drawing.Size(547, 48);
            this.lblPnPodsk2.TabIndex = 26;
            this.lblPnPodsk2.Text = "- позначаються ті елементи послідовності, які входять до множини елементів найбіл" +
    "ьшої зростаючої підпослідовності";
            // 
            // lblPnPodsk1
            // 
            this.lblPnPodsk1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPnPodsk1.Location = new System.Drawing.Point(73, 554);
            this.lblPnPodsk1.Name = "lblPnPodsk1";
            this.lblPnPodsk1.Size = new System.Drawing.Size(541, 76);
            this.lblPnPodsk1.TabIndex = 25;
            this.lblPnPodsk1.Text = "- позначаються ті елементи послідовності, які не входять до найбільшої зростаючої" +
    " підпослідовності";
            // 
            // panelPodskazka2
            // 
            this.panelPodskazka2.BackColor = System.Drawing.Color.Blue;
            this.panelPodskazka2.Location = new System.Drawing.Point(11, 483);
            this.panelPodskazka2.Name = "panelPodskazka2";
            this.panelPodskazka2.Size = new System.Drawing.Size(60, 60);
            this.panelPodskazka2.TabIndex = 24;
            // 
            // lblAnsPodPosl
            // 
            this.lblAnsPodPosl.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnsPodPosl.Location = new System.Drawing.Point(4, 395);
            this.lblAnsPodPosl.Name = "lblAnsPodPosl";
            this.lblAnsPodPosl.Size = new System.Drawing.Size(795, 83);
            this.lblAnsPodPosl.TabIndex = 9;
            // 
            // panelPodskazka1
            // 
            this.panelPodskazka1.BackColor = System.Drawing.Color.ForestGreen;
            this.panelPodskazka1.Location = new System.Drawing.Point(11, 551);
            this.panelPodskazka1.Name = "panelPodskazka1";
            this.panelPodskazka1.Size = new System.Drawing.Size(60, 60);
            this.panelPodskazka1.TabIndex = 23;
            // 
            // vlasnoruchPT1
            // 
            this.vlasnoruchPT1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vlasnoruchPT1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vlasnoruchPT1.Location = new System.Drawing.Point(237, 192);
            this.vlasnoruchPT1.Name = "vlasnoruchPT1";
            this.vlasnoruchPT1.Size = new System.Drawing.Size(266, 60);
            this.vlasnoruchPT1.TabIndex = 21;
            this.vlasnoruchPT1.Text = "Ввести власноруч";
            this.vlasnoruchPT1.UseVisualStyleBackColor = true;
            this.vlasnoruchPT1.Click += new System.EventHandler(this.vlasnoruchPT1_Click);
            // 
            // vypadlovoPT1
            // 
            this.vypadlovoPT1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vypadlovoPT1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vypadlovoPT1.Location = new System.Drawing.Point(522, 192);
            this.vypadlovoPT1.Name = "vypadlovoPT1";
            this.vypadlovoPT1.Size = new System.Drawing.Size(277, 60);
            this.vypadlovoPT1.TabIndex = 20;
            this.vypadlovoPT1.Text = "Ввести випадково";
            this.vypadlovoPT1.UseVisualStyleBackColor = true;
            this.vypadlovoPT1.Click += new System.EventHandler(this.vypadlovoPT1_Click);
            // 
            // txtPodN
            // 
            this.txtPodN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPodN.Location = new System.Drawing.Point(79, 212);
            this.txtPodN.Name = "txtPodN";
            this.txtPodN.Size = new System.Drawing.Size(94, 40);
            this.txtPodN.TabIndex = 19;
            this.txtPodN.Text = "6";
            // 
            // lblPodN
            // 
            this.lblPodN.AutoSize = true;
            this.lblPodN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPodN.Location = new System.Drawing.Point(12, 215);
            this.lblPodN.Name = "lblPodN";
            this.lblPodN.Size = new System.Drawing.Size(61, 33);
            this.lblPodN.TabIndex = 18;
            this.lblPodN.Text = "N =";
            // 
            // GridViewPod
            // 
            this.GridViewPod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridViewPod.ColumnHeadersVisible = false;
            this.GridViewPod.Enabled = false;
            this.GridViewPod.Location = new System.Drawing.Point(11, 265);
            this.GridViewPod.Name = "GridViewPod";
            this.GridViewPod.ReadOnly = true;
            this.GridViewPod.RowHeadersVisible = false;
            this.GridViewPod.Size = new System.Drawing.Size(378, 93);
            this.GridViewPod.TabIndex = 17;
            // 
            // UsloviyPodPosl
            // 
            this.UsloviyPodPosl.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsloviyPodPosl.Location = new System.Drawing.Point(5, 3);
            this.UsloviyPodPosl.Name = "UsloviyPodPosl";
            this.UsloviyPodPosl.Size = new System.Drawing.Size(735, 198);
            this.UsloviyPodPosl.TabIndex = 16;
            this.UsloviyPodPosl.Text = resources.GetString("UsloviyPodPosl.Text");
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(735, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 59);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPodposl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 619);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblAnsPodPosl);
            this.Controls.Add(this.lblPnPodsk2);
            this.Controls.Add(this.lblPnPodsk1);
            this.Controls.Add(this.panelPodskazka2);
            this.Controls.Add(this.panelPodskazka1);
            this.Controls.Add(this.vlasnoruchPT1);
            this.Controls.Add(this.vypadlovoPT1);
            this.Controls.Add(this.txtPodN);
            this.Controls.Add(this.lblPodN);
            this.Controls.Add(this.GridViewPod);
            this.Controls.Add(this.UsloviyPodPosl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmPodposl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задача знаходження найбільшої зростаючої підпослідовності";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPodposl_FormClosing);
            this.Load += new System.EventHandler(this.frmPodposl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPnPodsk2;
        private System.Windows.Forms.Label lblPnPodsk1;
        private System.Windows.Forms.Panel panelPodskazka2;
        private System.Windows.Forms.Label lblAnsPodPosl;
        private System.Windows.Forms.Panel panelPodskazka1;
        private System.Windows.Forms.Button vlasnoruchPT1;
        private System.Windows.Forms.Button vypadlovoPT1;
        private System.Windows.Forms.TextBox txtPodN;
        private System.Windows.Forms.Label lblPodN;
        private System.Windows.Forms.DataGridView GridViewPod;
        private System.Windows.Forms.Label UsloviyPodPosl;
        private System.Windows.Forms.Button button2;
    }
}