namespace project_TelegraphicTransfer
{
    partial class UCTelegraphicsListShow
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
            btn_CreateOrder = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // btn_CreateOrder
            // 
            btn_CreateOrder.BackColor = Color.FromArgb(76, 175, 80);
            btn_CreateOrder.Dock = DockStyle.Top;
            btn_CreateOrder.FlatAppearance.BorderSize = 0;
            btn_CreateOrder.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btn_CreateOrder.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btn_CreateOrder.FlatStyle = FlatStyle.Flat;
            btn_CreateOrder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CreateOrder.ForeColor = Color.White;
            btn_CreateOrder.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btn_CreateOrder.IconColor = Color.White;
            btn_CreateOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_CreateOrder.IconSize = 25;
            btn_CreateOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CreateOrder.Location = new Point(0, 0);
            btn_CreateOrder.Name = "btn_CreateOrder";
            btn_CreateOrder.Size = new Size(288, 37);
            btn_CreateOrder.TabIndex = 5;
            btn_CreateOrder.Text = "Create Transfer Order";
            btn_CreateOrder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_CreateOrder.UseVisualStyleBackColor = false;
            // 
            // UCTelegraphicsListShow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_CreateOrder);
            Name = "UCTelegraphicsListShow";
            Size = new Size(288, 366);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_CreateOrder;
    }
}
