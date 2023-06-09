﻿namespace project_TelegraphicTransfer
{
    partial class FormMAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMAIN));
            panelmain = new Panel();
            panelbody = new Panel();
            pnllLoadSpace = new Panel();
            pnlButtons = new Panel();
            btnDataBase = new FontAwesome.Sharp.IconButton();
            btnConfirmRecord = new FontAwesome.Sharp.IconButton();
            btnNewRecord = new FontAwesome.Sharp.IconButton();
            panelheader = new Panel();
            panel1 = new Panel();
            pnlUserShowing = new Panel();
            lblFormNameShow = new Label();
            lblSystemName = new Label();
            panellogo = new Panel();
            pbLOGO = new PictureBox();
            panelmain.SuspendLayout();
            panelbody.SuspendLayout();
            pnlButtons.SuspendLayout();
            panelheader.SuspendLayout();
            panel1.SuspendLayout();
            pnlUserShowing.SuspendLayout();
            panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLOGO).BeginInit();
            SuspendLayout();
            // 
            // panelmain
            // 
            panelmain.BackColor = SystemColors.Menu;
            panelmain.Controls.Add(panelbody);
            panelmain.Controls.Add(panelheader);
            panelmain.Dock = DockStyle.Fill;
            panelmain.Location = new Point(0, 0);
            panelmain.Name = "panelmain";
            panelmain.Size = new Size(800, 450);
            panelmain.TabIndex = 0;
            // 
            // panelbody
            // 
            panelbody.Controls.Add(pnllLoadSpace);
            panelbody.Controls.Add(pnlButtons);
            panelbody.Dock = DockStyle.Fill;
            panelbody.Location = new Point(0, 65);
            panelbody.Name = "panelbody";
            panelbody.Size = new Size(800, 385);
            panelbody.TabIndex = 2;
            // 
            // pnllLoadSpace
            // 
            pnllLoadSpace.Cursor = Cursors.Hand;
            pnllLoadSpace.Dock = DockStyle.Fill;
            pnllLoadSpace.Location = new Point(65, 0);
            pnllLoadSpace.Name = "pnllLoadSpace";
            pnllLoadSpace.Size = new Size(735, 385);
            pnllLoadSpace.TabIndex = 2;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.FromArgb(1, 12, 71);
            pnlButtons.Controls.Add(btnDataBase);
            pnlButtons.Controls.Add(btnConfirmRecord);
            pnlButtons.Controls.Add(btnNewRecord);
            pnlButtons.Dock = DockStyle.Left;
            pnlButtons.ForeColor = Color.White;
            pnlButtons.Location = new Point(0, 0);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(65, 385);
            pnlButtons.TabIndex = 1;
            // 
            // btnDataBase
            // 
            btnDataBase.Cursor = Cursors.Hand;
            btnDataBase.FlatAppearance.BorderSize = 0;
            btnDataBase.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            btnDataBase.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            btnDataBase.FlatStyle = FlatStyle.Flat;
            btnDataBase.IconChar = FontAwesome.Sharp.IconChar.Database;
            btnDataBase.IconColor = Color.White;
            btnDataBase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDataBase.IconSize = 30;
            btnDataBase.Location = new Point(0, 137);
            btnDataBase.Name = "btnDataBase";
            btnDataBase.Size = new Size(65, 65);
            btnDataBase.TabIndex = 2;
            btnDataBase.UseVisualStyleBackColor = true;
            // 
            // btnConfirmRecord
            // 
            btnConfirmRecord.Cursor = Cursors.Hand;
            btnConfirmRecord.FlatAppearance.BorderSize = 0;
            btnConfirmRecord.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            btnConfirmRecord.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            btnConfirmRecord.FlatStyle = FlatStyle.Flat;
            btnConfirmRecord.IconChar = FontAwesome.Sharp.IconChar.Tags;
            btnConfirmRecord.IconColor = Color.White;
            btnConfirmRecord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfirmRecord.IconSize = 35;
            btnConfirmRecord.Location = new Point(0, 69);
            btnConfirmRecord.Name = "btnConfirmRecord";
            btnConfirmRecord.Size = new Size(65, 65);
            btnConfirmRecord.TabIndex = 1;
            btnConfirmRecord.UseVisualStyleBackColor = true;
            // 
            // btnNewRecord
            // 
            btnNewRecord.Cursor = Cursors.Hand;
            btnNewRecord.FlatAppearance.BorderSize = 0;
            btnNewRecord.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            btnNewRecord.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            btnNewRecord.FlatStyle = FlatStyle.Flat;
            btnNewRecord.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            btnNewRecord.IconColor = Color.White;
            btnNewRecord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNewRecord.IconSize = 28;
            btnNewRecord.Location = new Point(0, 0);
            btnNewRecord.Name = "btnNewRecord";
            btnNewRecord.Size = new Size(65, 65);
            btnNewRecord.TabIndex = 0;
            btnNewRecord.UseVisualStyleBackColor = true;
            btnNewRecord.Click += btnNewRecord_Click;
            // 
            // panelheader
            // 
            panelheader.BackColor = Color.White;
            panelheader.Controls.Add(panel1);
            panelheader.Controls.Add(panellogo);
            panelheader.Dock = DockStyle.Top;
            panelheader.Location = new Point(0, 0);
            panelheader.Name = "panelheader";
            panelheader.Size = new Size(800, 65);
            panelheader.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 12, 71);
            panel1.Controls.Add(pnlUserShowing);
            panel1.Controls.Add(lblSystemName);
            panel1.Dock = DockStyle.Top;
            panel1.ImeMode = ImeMode.Off;
            panel1.Location = new Point(65, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(735, 65);
            panel1.TabIndex = 1;
            // 
            // pnlUserShowing
            // 
            pnlUserShowing.BackColor = Color.FromArgb(194, 194, 239);
            pnlUserShowing.Controls.Add(lblFormNameShow);
            pnlUserShowing.Dock = DockStyle.Bottom;
            pnlUserShowing.Location = new Point(0, 40);
            pnlUserShowing.Name = "pnlUserShowing";
            pnlUserShowing.Size = new Size(735, 25);
            pnlUserShowing.TabIndex = 1;
            // 
            // lblFormNameShow
            // 
            lblFormNameShow.AutoSize = true;
            lblFormNameShow.BackColor = Color.FromArgb(194, 194, 239);
            lblFormNameShow.BorderStyle = BorderStyle.FixedSingle;
            lblFormNameShow.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormNameShow.Location = new Point(9, 4);
            lblFormNameShow.Name = "lblFormNameShow";
            lblFormNameShow.Size = new Size(2, 17);
            lblFormNameShow.TabIndex = 0;
            lblFormNameShow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSystemName
            // 
            lblSystemName.AutoSize = true;
            lblSystemName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSystemName.ForeColor = SystemColors.Window;
            lblSystemName.Location = new Point(6, 11);
            lblSystemName.Name = "lblSystemName";
            lblSystemName.Size = new Size(685, 21);
            lblSystemName.TabIndex = 0;
            lblSystemName.Text = "TELEGRAPHIC TRANSFER ORDER MANAGEMENT SYSTEM | Ceylon Petroleum Corporation";
            lblSystemName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panellogo
            // 
            panellogo.BackColor = Color.FromArgb(1, 12, 71);
            panellogo.Controls.Add(pbLOGO);
            panellogo.Dock = DockStyle.Left;
            panellogo.ImeMode = ImeMode.Off;
            panellogo.Location = new Point(0, 0);
            panellogo.Name = "panellogo";
            panellogo.Size = new Size(65, 65);
            panellogo.TabIndex = 0;
            // 
            // pbLOGO
            // 
            pbLOGO.Image = (Image)resources.GetObject("pbLOGO.Image");
            pbLOGO.Location = new Point(5, 8);
            pbLOGO.Name = "pbLOGO";
            pbLOGO.Padding = new Padding(5);
            pbLOGO.Size = new Size(55, 50);
            pbLOGO.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLOGO.TabIndex = 0;
            pbLOGO.TabStop = false;
            // 
            // FormMAIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelmain);
            Name = "FormMAIN";
            Text = "HOME";
            Load += FormMAIN_Load;
            panelmain.ResumeLayout(false);
            panelbody.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            panelheader.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlUserShowing.ResumeLayout(false);
            pnlUserShowing.PerformLayout();
            panellogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLOGO).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelmain;
        private Panel panelheader;
        private Panel panellogo;
        private Panel panel1;
        private Label lblSystemName;
        private Panel pnlButtons;
        private Panel panelbody;
        private Panel pnllLoadSpace;
        private FontAwesome.Sharp.IconButton btnNewRecord;
        private PictureBox pbLOGO;
        private Panel pnlUserShowing;
        private FontAwesome.Sharp.IconButton btnConfirmRecord;
        private FontAwesome.Sharp.IconButton btnDataBase;
        private Label lblFormNameShow;
    }
}