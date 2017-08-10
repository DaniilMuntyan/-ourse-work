namespace Классификация_задач
{
    partial class frmWaySearch
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
            this.lblWay = new System.Windows.Forms.Label();
            this.lblCherep = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWay
            // 
            this.lblWay.AutoSize = true;
            this.lblWay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWay.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWay.Location = new System.Drawing.Point(116, 32);
            this.lblWay.Name = "lblWay";
            this.lblWay.Size = new System.Drawing.Size(170, 40);
            this.lblWay.TabIndex = 4;
            this.lblWay.Text = "Маршрут";
            this.lblWay.Click += new System.EventHandler(this.lblWay_Click);
            this.lblWay.MouseEnter += new System.EventHandler(this.lblWay_MouseEnter);
            // 
            // lblCherep
            // 
            this.lblCherep.AutoSize = true;
            this.lblCherep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCherep.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCherep.Location = new System.Drawing.Point(62, 118);
            this.lblCherep.Name = "lblCherep";
            this.lblCherep.Size = new System.Drawing.Size(306, 40);
            this.lblCherep.TabIndex = 5;
            this.lblCherep.Text = "Мишка і зернятка";
            this.lblCherep.MouseEnter += new System.EventHandler(this.lblCherep_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 29.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(112, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "Маршрут";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 29.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.Location = new System.Drawing.Point(47, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 44);
            this.label2.TabIndex = 7;
            this.label2.Text = "Мишка і зернятка";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // frmWaySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 221);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCherep);
            this.Controls.Add(this.lblWay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "frmWaySearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задачі на пошук оптимального шляху";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWaySearch_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWay;
        private System.Windows.Forms.Label lblCherep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}