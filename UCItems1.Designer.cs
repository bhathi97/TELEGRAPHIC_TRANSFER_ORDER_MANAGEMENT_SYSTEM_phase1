namespace project_TelegraphicTransfer
{
    partial class UCItems1
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
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lblFileNameShowing = new Label();
            btn_editTTs = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iconPictureBox1.BackColor = Color.FromArgb(0, 0, 26);
            iconPictureBox1.ForeColor = SystemColors.ControlLightLight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.File;
            iconPictureBox1.IconColor = SystemColors.ControlLightLight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox1.IconSize = 25;
            iconPictureBox1.Location = new Point(7, 15);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(25, 28);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // lblFileNameShowing
            // 
            lblFileNameShowing.AutoSize = true;
            lblFileNameShowing.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFileNameShowing.ForeColor = SystemColors.Window;
            lblFileNameShowing.Location = new Point(2, 17);
            lblFileNameShowing.Name = "lblFileNameShowing";
            lblFileNameShowing.Size = new Size(104, 17);
            lblFileNameShowing.TabIndex = 1;
            lblFileNameShowing.Text = "oooooooooooo";
            // 
            // btn_editTTs
            // 
            btn_editTTs.BackColor = Color.FromArgb(194, 194, 239);
            btn_editTTs.BackgroundImageLayout = ImageLayout.Center;
            btn_editTTs.Cursor = Cursors.Hand;
            btn_editTTs.Dock = DockStyle.Fill;
            btn_editTTs.FlatAppearance.BorderColor = Color.FromArgb(102, 102, 255);
            btn_editTTs.FlatAppearance.BorderSize = 0;
            btn_editTTs.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            btn_editTTs.FlatAppearance.MouseOverBackColor = SystemColors.ControlLightLight;
            btn_editTTs.FlatStyle = FlatStyle.Flat;
            btn_editTTs.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_editTTs.ForeColor = Color.Coral;
            btn_editTTs.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            btn_editTTs.IconColor = Color.FromArgb(0, 0, 26);
            btn_editTTs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_editTTs.IconSize = 20;
            btn_editTTs.Location = new Point(10, 10);
            btn_editTTs.Name = "btn_editTTs";
            btn_editTTs.Size = new Size(53, 39);
            btn_editTTs.TabIndex = 2;
            btn_editTTs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_editTTs.UseVisualStyleBackColor = false;
            btn_editTTs.Click += btn_editTTs_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 26);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new Size(38, 59);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 26);
            panel2.Controls.Add(btn_editTTs);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(213, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(73, 59);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 26);
            panel3.Controls.Add(lblFileNameShowing);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(38, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(175, 59);
            panel3.TabIndex = 5;
            // 
            // UCItems1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCItems1";
            Size = new Size(286, 59);
            Load += UCItems1_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label lblFileNameShowing;
        private FontAwesome.Sharp.IconButton btn_editTTs;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}
