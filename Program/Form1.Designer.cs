namespace Program
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("Глок 17");
            TreeNode treeNode2 = new TreeNode("Пистолет Макарова");
            TreeNode treeNode3 = new TreeNode("Пистолеты", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("Револьвер системы Нагана");
            TreeNode treeNode5 = new TreeNode("Револьверы", new TreeNode[] { treeNode4 });
            TreeNode treeNode6 = new TreeNode("Винтовки");
            TreeNode treeNode7 = new TreeNode("Автоматы");
            TreeNode treeNode8 = new TreeNode("Пулемёты");
            TreeNode treeNode9 = new TreeNode("Оружие", new TreeNode[] { treeNode3, treeNode5, treeNode6, treeNode7, treeNode8 });
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            treeView1 = new TreeView();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(931, 494);
            splitContainer1.SplitterDistance = 294;
            splitContainer1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(treeView1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 490);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выбор оружия";
            // 
            // treeView1
            // 
            treeView1.BackColor = SystemColors.Menu;
            treeView1.Dock = DockStyle.Fill;
            treeView1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            treeView1.Location = new Point(3, 33);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Glok17";
            treeNode1.Text = "Глок 17";
            treeNode2.Name = "GunMakarova";
            treeNode2.Text = "Пистолет Макарова";
            treeNode3.Name = "Guns";
            treeNode3.Text = "Пистолеты";
            treeNode4.Name = "NaganaSystemRevolver";
            treeNode4.Text = "Револьвер системы Нагана";
            treeNode5.Name = "Revolvers";
            treeNode5.Text = "Револьверы";
            treeNode6.Name = "Rifles";
            treeNode6.Text = "Винтовки";
            treeNode7.Name = "AssaultRifles";
            treeNode7.Text = "Автоматы";
            treeNode8.Name = "MachineGuns";
            treeNode8.Text = "Пулемёты";
            treeNode9.Name = "Weapon";
            treeNode9.Text = "Оружие";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode9 });
            treeView1.Size = new Size(284, 454);
            treeView1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 38);
            label2.Name = "label2";
            label2.Size = new Size(629, 120);
            label2.TabIndex = 1;
            label2.Text = "Тип: ......\r\nОписание: .....\r\n";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(629, 38);
            label1.TabIndex = 0;
            label1.Text = "Название";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 494);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            ShowIcon = false;
            Text = "Каталог оружия";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private TreeView treeView1;
        private Label label2;
        private Label label1;
    }
}