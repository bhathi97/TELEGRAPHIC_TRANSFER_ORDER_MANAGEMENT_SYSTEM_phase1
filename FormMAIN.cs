using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_TelegraphicTransfer
{
    public partial class FormMAIN : Form
    {

        #region properties
        private string _lblTest;
        public string LblTest
        {
            get { return _lblTest; }
            set
            {
                _lblTest = value;
                lblFormNameShow.Text = value;
            }
        }
        #endregion


        public FormMAIN()
        {
            InitializeComponent();
        }

        //create a property to access anywhere
        public string LabelToShowFileName { get; set; }


        //to save usercontrols **********************************
        //FileHandeling button
        private UCFileHandeling _fileHandelingUserControl;
        public UCFileHandeling FileHandelingUserControl
        {
            get { return _fileHandelingUserControl; }
            set { _fileHandelingUserControl = value; }
        }

        private void FormMAIN_Load(object sender, EventArgs e)
        {
            //make the Window maximize
            this.WindowState = FormWindowState.Maximized;

            // Create a ToolTip instance
            ToolTip toolTip = new ToolTip();

            // Set the tooltip text for buttons
            toolTip.SetToolTip(btnNewRecord, "Add new TELEGRAPHIC TRANSFER");
            toolTip.SetToolTip(btnConfirmRecord, "Confirm typed TELEGRAPHIC TRANSFER");
            toolTip.SetToolTip(btnDataBase, "Database Manager");

            lblFormNameShow.Text = LabelToShowFileName;


        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (_fileHandelingUserControl == null)
                {
                    FileHandelingUserControl = new UCFileHandeling();

                }

                // Hide all other controls within panel1
                foreach (Control control in pnllLoadSpace.Controls)
                {
                    control.Visible = false;
                }

                //show this
                FileHandelingUserControl.Show();

                //change the dock property
                FileHandelingUserControl.Dock = DockStyle.Fill;

                //add to the panal
                pnllLoadSpace.Controls.Add(FileHandelingUserControl);

            }
            catch (Exception ex)
            {

            }


        }
    }
}
