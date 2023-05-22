﻿namespace project_TelegraphicTransfer
{
    partial class UCFileHandeling
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainerToShowFiles = new SplitContainer();
            pnlFilesShow = new Panel();
            panel1 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainerToShowFiles).BeginInit();
            splitContainerToShowFiles.Panel1.SuspendLayout();
            splitContainerToShowFiles.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainerToShowFiles
            // 
            splitContainerToShowFiles.BackColor = Color.FromArgb(194, 194, 239);
            splitContainerToShowFiles.BorderStyle = BorderStyle.Fixed3D;
            splitContainerToShowFiles.Dock = DockStyle.Fill;
            splitContainerToShowFiles.ForeColor = SystemColors.ControlText;
            splitContainerToShowFiles.Location = new Point(0, 0);
            splitContainerToShowFiles.Name = "splitContainerToShowFiles";
            // 
            // splitContainerToShowFiles.Panel1
            // 
            splitContainerToShowFiles.Panel1.BackColor = SystemColors.MenuBar;
            splitContainerToShowFiles.Panel1.Controls.Add(pnlFilesShow);
            splitContainerToShowFiles.Panel1.Controls.Add(panel1);
            // 
            // splitContainerToShowFiles.Panel2
            // 
            splitContainerToShowFiles.Panel2.BackColor = Color.White;
            splitContainerToShowFiles.Size = new Size(781, 505);
            splitContainerToShowFiles.SplitterDistance = 202;
            splitContainerToShowFiles.TabIndex = 0;
            // 
            // pnlFilesShow
            // 
            pnlFilesShow.Dock = DockStyle.Fill;
            pnlFilesShow.Location = new Point(0, 57);
            pnlFilesShow.Name = "pnlFilesShow";
            pnlFilesShow.Size = new Size(198, 444);
            pnlFilesShow.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(198, 57);
            panel1.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(76, 175, 80);
            iconButton1.Dock = DockStyle.Right;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            iconButton1.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(85, 10);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(103, 37);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "New File";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(56, 30);
            label1.TabIndex = 0;
            label1.Text = "Files";
            // 
            // UCFileHandeling
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainerToShowFiles);
            Name = "UCFileHandeling";
            Size = new Size(781, 505);
            splitContainerToShowFiles.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerToShowFiles).EndInit();
            splitContainerToShowFiles.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainerToShowFiles;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label1;
        private Panel pnlFilesShow;
    }
}