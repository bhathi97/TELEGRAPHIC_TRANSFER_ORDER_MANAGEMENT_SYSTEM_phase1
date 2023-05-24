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
    public partial class UCTTItems : UserControl
    {

        #region Properties
        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        private int _fileId;
        public int FileId
        {
            get { return _fileId; }
            set { _fileId = value; }
        }
        #endregion



        public UCTTItems()
        {
            InitializeComponent();
        }

        private void UCTTItems_Load(object sender, EventArgs e)
        {
            lblFormName.Text = FileName;
        }
    }
}
