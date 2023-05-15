namespace Program
{
    partial class MainForm
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
            TreeNode treeNode5 = new TreeNode("Револьвер Веблера");
            TreeNode treeNode6 = new TreeNode("Револьверы", new TreeNode[] { treeNode4, treeNode5 });
            TreeNode treeNode7 = new TreeNode("BarrettM82");
            TreeNode treeNode8 = new TreeNode("Снайперская винтовка Драгунова");
            TreeNode treeNode9 = new TreeNode("Винтовки", new TreeNode[] { treeNode7, treeNode8 });
            TreeNode treeNode10 = new TreeNode("АС Вал");
            TreeNode treeNode11 = new TreeNode("АК-47");
            TreeNode treeNode12 = new TreeNode("Автоматы", new TreeNode[] { treeNode10, treeNode11 });
            TreeNode treeNode13 = new TreeNode("ДТ");
            TreeNode treeNode14 = new TreeNode("Пулемёт Максим");
            TreeNode treeNode15 = new TreeNode("Пулемёты", new TreeNode[] { treeNode13, treeNode14 });
            TreeNode treeNode16 = new TreeNode("Оружие", new TreeNode[] { treeNode3, treeNode6, treeNode9, treeNode12, treeNode15 });
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            splitMain = new SplitContainer();
            groupChoose = new GroupBox();
            treeWeapon = new TreeView();
            groupDescription = new GroupBox();
            splitDescription = new SplitContainer();
            lChoose = new Label();
            lDescription = new Label();
            bInteractive = new Button();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            groupChoose.SuspendLayout();
            groupDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitDescription).BeginInit();
            splitDescription.Panel1.SuspendLayout();
            splitDescription.Panel2.SuspendLayout();
            splitDescription.SuspendLayout();
            SuspendLayout();
            // 
            // splitMain
            // 
            splitMain.BorderStyle = BorderStyle.Fixed3D;
            splitMain.Dock = DockStyle.Fill;
            splitMain.IsSplitterFixed = true;
            splitMain.Location = new Point(0, 0);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(groupChoose);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(groupDescription);
            splitMain.Size = new Size(931, 494);
            splitMain.SplitterDistance = 306;
            splitMain.TabIndex = 3;
            // 
            // groupChoose
            // 
            groupChoose.Controls.Add(treeWeapon);
            groupChoose.Dock = DockStyle.Fill;
            groupChoose.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold, GraphicsUnit.Point);
            groupChoose.Location = new Point(0, 0);
            groupChoose.Name = "groupChoose";
            groupChoose.Size = new Size(302, 490);
            groupChoose.TabIndex = 3;
            groupChoose.TabStop = false;
            groupChoose.Text = "Выбор оружия";
            // 
            // treeWeapon
            // 
            treeWeapon.BackColor = SystemColors.Menu;
            treeWeapon.Dock = DockStyle.Fill;
            treeWeapon.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            treeWeapon.Location = new Point(3, 33);
            treeWeapon.Name = "treeWeapon";
            treeNode1.Name = "Glock17";
            treeNode1.Text = "Глок 17";
            treeNode2.Name = "GunMakarova";
            treeNode2.Text = "Пистолет Макарова";
            treeNode3.Name = "Guns";
            treeNode3.Text = "Пистолеты";
            treeNode4.Name = "NaganaSystemRevolver";
            treeNode4.Text = "Револьвер системы Нагана";
            treeNode5.Name = "WebleyRevolver";
            treeNode5.Text = "Револьвер Веблера";
            treeNode6.Name = "Revolvers";
            treeNode6.Text = "Револьверы";
            treeNode7.Name = "BarrettM82";
            treeNode7.Text = "BarrettM82";
            treeNode8.Name = "DragunovSniperRifle";
            treeNode8.Text = "Снайперская винтовка Драгунова";
            treeNode9.Name = "Rifles";
            treeNode9.Text = "Винтовки";
            treeNode10.Name = "AC_VAL";
            treeNode10.Text = "АС Вал";
            treeNode11.Name = "AK_47";
            treeNode11.Text = "АК-47";
            treeNode12.Name = "AssaultRifles";
            treeNode12.Text = "Автоматы";
            treeNode13.Name = "DT";
            treeNode13.Text = "ДТ";
            treeNode14.Name = "MaksimMachineGun";
            treeNode14.Text = "Пулемёт Максим";
            treeNode15.Name = "MachineGuns";
            treeNode15.Text = "Пулемёты";
            treeNode16.Name = "Weapon";
            treeNode16.Text = "Оружие";
            treeWeapon.Nodes.AddRange(new TreeNode[] { treeNode16 });
            treeWeapon.Size = new Size(296, 454);
            treeWeapon.TabIndex = 0;
            treeWeapon.AfterSelect += treeWeapon_AfterSelect;
            // 
            // groupDescription
            // 
            groupDescription.Controls.Add(splitDescription);
            groupDescription.Dock = DockStyle.Fill;
            groupDescription.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupDescription.Location = new Point(0, 0);
            groupDescription.Name = "groupDescription";
            groupDescription.Size = new Size(617, 490);
            groupDescription.TabIndex = 0;
            groupDescription.TabStop = false;
            groupDescription.Text = "Название";
            // 
            // splitDescription
            // 
            splitDescription.BorderStyle = BorderStyle.Fixed3D;
            splitDescription.Dock = DockStyle.Fill;
            splitDescription.IsSplitterFixed = true;
            splitDescription.Location = new Point(3, 43);
            splitDescription.Name = "splitDescription";
            splitDescription.Orientation = Orientation.Horizontal;
            // 
            // splitDescription.Panel1
            // 
            splitDescription.Panel1.Controls.Add(lChoose);
            splitDescription.Panel1.Controls.Add(lDescription);
            // 
            // splitDescription.Panel2
            // 
            splitDescription.Panel2.Controls.Add(bInteractive);
            splitDescription.Size = new Size(611, 444);
            splitDescription.SplitterDistance = 363;
            splitDescription.TabIndex = 0;
            // 
            // lChoose
            // 
            lChoose.AutoSize = true;
            lChoose.ForeColor = SystemColors.ControlDarkDark;
            lChoose.Location = new Point(165, 141);
            lChoose.Name = "lChoose";
            lChoose.Size = new Size(284, 41);
            lChoose.TabIndex = 1;
            lChoose.Text = "Выберите оружие";
            // 
            // lDescription
            // 
            lDescription.Dock = DockStyle.Fill;
            lDescription.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lDescription.Location = new Point(0, 0);
            lDescription.Name = "lDescription";
            lDescription.Size = new Size(607, 359);
            lDescription.TabIndex = 0;
            lDescription.Text = "Описание";
            // 
            // bInteractive
            // 
            bInteractive.Enabled = false;
            bInteractive.Location = new Point(168, 14);
            bInteractive.Name = "bInteractive";
            bInteractive.Size = new Size(281, 54);
            bInteractive.TabIndex = 0;
            bInteractive.Text = "Интерактив";
            bInteractive.UseVisualStyleBackColor = true;
            bInteractive.Click += bInteractive_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 494);
            Controls.Add(splitMain);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Каталог оружия";
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            groupChoose.ResumeLayout(false);
            groupDescription.ResumeLayout(false);
            splitDescription.Panel1.ResumeLayout(false);
            splitDescription.Panel1.PerformLayout();
            splitDescription.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitDescription).EndInit();
            splitDescription.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitMain;
        private GroupBox groupChoose;
        private TreeView treeWeapon;
        private GroupBox groupDescription;
        private SplitContainer splitDescription;
        private Label lDescription;
        private Button bInteractive;
        private Label lChoose;
    }
}