namespace Классификация_задач
{
    partial class Theory
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Купівля квитків");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Платні сходи");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Трикутник");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Максимальний підпаліндром");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Максимальний загальний підрядок");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Найбільша зростаюча підпослідовність");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Задача про рюкзак");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Калькулятор");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Пошук оптимальної кількості і суми", 3, 0, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Маршрут");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Мишка і зернятка");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Пошук оптимального маршруту", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Стрибунець");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Хід конем");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Трикутник Паскаля");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Рекурентна формула", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Theory));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.ImageIndex = 3;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Indent = 20;
            this.treeView1.ItemHeight = 34;
            this.treeView1.Location = new System.Drawing.Point(12, 67);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Th11";
            treeNode1.SelectedImageIndex = 0;
            treeNode1.Text = "Купівля квитків";
            treeNode2.Name = "Th12";
            treeNode2.Text = "Платні сходи";
            treeNode3.Name = "Th13";
            treeNode3.Text = "Трикутник";
            treeNode4.Name = "Th14";
            treeNode4.Text = "Максимальний підпаліндром";
            treeNode5.Name = "Th15";
            treeNode5.Text = "Максимальний загальний підрядок";
            treeNode6.Name = "Th16";
            treeNode6.Text = "Найбільша зростаюча підпослідовність";
            treeNode7.Name = "Th17";
            treeNode7.Text = "Задача про рюкзак";
            treeNode8.Name = "Th18";
            treeNode8.Text = "Калькулятор";
            treeNode9.ImageIndex = 3;
            treeNode9.Name = "Th1";
            treeNode9.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode9.SelectedImageIndex = 0;
            treeNode9.Text = "Пошук оптимальної кількості і суми";
            treeNode10.Name = "Th21";
            treeNode10.SelectedImageIndex = 2;
            treeNode10.Text = "Маршрут";
            treeNode11.Name = "Th22";
            treeNode11.SelectedImageIndex = 2;
            treeNode11.Text = "Мишка і зернятка";
            treeNode12.Name = "Th2";
            treeNode12.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            treeNode12.SelectedImageIndex = 2;
            treeNode12.Text = "Пошук оптимального маршруту";
            treeNode13.Name = "Th31";
            treeNode13.SelectedImageIndex = 1;
            treeNode13.Text = "Стрибунець";
            treeNode14.Name = "Th32";
            treeNode14.SelectedImageIndex = 1;
            treeNode14.Text = "Хід конем";
            treeNode15.Name = "Th33";
            treeNode15.SelectedImageIndex = 1;
            treeNode15.Text = "Трикутник Паскаля";
            treeNode16.Name = "Th3";
            treeNode16.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            treeNode16.SelectedImageIndex = 1;
            treeNode16.Text = "Рекурентна формула";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode12,
            treeNode16});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(395, 500);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ImageList(Sum).png");
            this.imageList1.Images.SetKeyName(1, "ImageList(Selected).png");
            this.imageList1.Images.SetKeyName(2, "ImageList(Marsh).png");
            this.imageList1.Images.SetKeyName(3, "ImageList(Phone).png");
            this.imageList1.Images.SetKeyName(4, "ImageList(Fib).png");
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(413, 67);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(529, 500);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(948, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 59);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Код рішення задач представлено на мові C++";
            // 
            // Theory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Theory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Теорія до задач";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Theory_FormClosing);
            this.Load += new System.EventHandler(this.Theory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}