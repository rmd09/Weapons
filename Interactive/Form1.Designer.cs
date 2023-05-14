namespace Interactive
{
    partial class FormInteractive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInteractive));
            splitMain = new SplitContainer();
            groupDoings = new GroupBox();
            bNewMagazine = new Button();
            bInsertMagazine = new Button();
            bShoot = new Button();
            bRecharge = new Button();
            bTakeMagazine = new Button();
            groupState = new GroupBox();
            lState = new Label();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            groupDoings.SuspendLayout();
            groupState.SuspendLayout();
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
            splitMain.Panel1.Controls.Add(groupDoings);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(groupState);
            splitMain.Size = new Size(872, 508);
            splitMain.SplitterDistance = 311;
            splitMain.TabIndex = 0;
            // 
            // groupDoings
            // 
            groupDoings.Controls.Add(bNewMagazine);
            groupDoings.Controls.Add(bInsertMagazine);
            groupDoings.Controls.Add(bShoot);
            groupDoings.Controls.Add(bRecharge);
            groupDoings.Controls.Add(bTakeMagazine);
            groupDoings.Dock = DockStyle.Fill;
            groupDoings.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupDoings.Location = new Point(0, 0);
            groupDoings.Name = "groupDoings";
            groupDoings.Size = new Size(307, 504);
            groupDoings.TabIndex = 0;
            groupDoings.TabStop = false;
            groupDoings.Text = "Действия";
            // 
            // bNewMagazine
            // 
            bNewMagazine.Location = new Point(10, 85);
            bNewMagazine.Name = "bNewMagazine";
            bNewMagazine.Size = new Size(288, 57);
            bNewMagazine.TabIndex = 5;
            bNewMagazine.Text = "Новый магазин";
            bNewMagazine.UseVisualStyleBackColor = true;
            // 
            // bInsertMagazine
            // 
            bInsertMagazine.Location = new Point(10, 166);
            bInsertMagazine.Name = "bInsertMagazine";
            bInsertMagazine.Size = new Size(288, 57);
            bInsertMagazine.TabIndex = 4;
            bInsertMagazine.Text = "Вставить магазин";
            bInsertMagazine.UseVisualStyleBackColor = true;
            // 
            // bShoot
            // 
            bShoot.Location = new Point(10, 417);
            bShoot.Name = "bShoot";
            bShoot.Size = new Size(288, 57);
            bShoot.TabIndex = 3;
            bShoot.Text = "Стрельнуть";
            bShoot.UseVisualStyleBackColor = true;
            // 
            // bRecharge
            // 
            bRecharge.Location = new Point(10, 334);
            bRecharge.Name = "bRecharge";
            bRecharge.Size = new Size(288, 57);
            bRecharge.TabIndex = 2;
            bRecharge.Text = "Презарядить";
            bRecharge.UseVisualStyleBackColor = true;
            // 
            // bTakeMagazine
            // 
            bTakeMagazine.Location = new Point(10, 249);
            bTakeMagazine.Name = "bTakeMagazine";
            bTakeMagazine.Size = new Size(288, 57);
            bTakeMagazine.TabIndex = 1;
            bTakeMagazine.Text = "Вынуть магазин";
            bTakeMagazine.UseVisualStyleBackColor = true;
            // 
            // groupState
            // 
            groupState.Controls.Add(lState);
            groupState.Dock = DockStyle.Fill;
            groupState.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupState.Location = new Point(0, 0);
            groupState.Name = "groupState";
            groupState.Size = new Size(553, 504);
            groupState.TabIndex = 0;
            groupState.TabStop = false;
            groupState.Text = "Состояние";
            // 
            // lState
            // 
            lState.Dock = DockStyle.Fill;
            lState.Location = new Point(3, 43);
            lState.Name = "lState";
            lState.Size = new Size(547, 458);
            lState.TabIndex = 0;
            lState.Text = "\r\nМагазин:\r\nКол-во патронов:\r\nПерезаряжен:";
            // 
            // FormInteractive
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 508);
            Controls.Add(splitMain);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInteractive";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Интерактив";
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            groupDoings.ResumeLayout(false);
            groupState.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitMain;
        private GroupBox groupDoings;
        private Button bShoot;
        private Button bRecharge;
        private Button bTakeMagazine;
        private Button bInsertMagazine;
        private Button bNewMagazine;
        private GroupBox groupState;
        private Label lState;
    }
}