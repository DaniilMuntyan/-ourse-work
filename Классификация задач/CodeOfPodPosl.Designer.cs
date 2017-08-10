namespace Классификация_задач
{
    partial class CodeOfPodPosl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeOfPodPosl));
            this.richtxtCodeofPodPosl = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richtxtCodeofPodPosl
            // 
            this.richtxtCodeofPodPosl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richtxtCodeofPodPosl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richtxtCodeofPodPosl.Location = new System.Drawing.Point(12, 12);
            this.richtxtCodeofPodPosl.Name = "richtxtCodeofPodPosl";
            this.richtxtCodeofPodPosl.ReadOnly = true;
            this.richtxtCodeofPodPosl.Size = new System.Drawing.Size(558, 535);
            this.richtxtCodeofPodPosl.TabIndex = 0;
            this.richtxtCodeofPodPosl.Text = resources.GetString("richtxtCodeofPodPosl.Text");
            // 
            // CodeOfPodPosl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 559);
            this.Controls.Add(this.richtxtCodeofPodPosl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "CodeOfPodPosl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeOfPodPosl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CodeOfPodPosl_FormClosing);
            this.Load += new System.EventHandler(this.CodeOfPodPosl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtxtCodeofPodPosl;
    }
}