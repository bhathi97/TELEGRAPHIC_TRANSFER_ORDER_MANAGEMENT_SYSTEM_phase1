namespace project_TelegraphicTransfer
{
    partial class UCTTForm
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
            lblFormName = new Label();
            SuspendLayout();
            // 
            // lblFormName
            // 
            lblFormName.AutoSize = true;
            lblFormName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormName.Location = new Point(11, 10);
            lblFormName.Name = "lblFormName";
            lblFormName.Size = new Size(93, 21);
            lblFormName.TabIndex = 0;
            lblFormName.Text = "formName";
            // 
            // UCTTForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblFormName);
            Name = "UCTTForm";
            Size = new Size(455, 459);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormName;
    }
}
