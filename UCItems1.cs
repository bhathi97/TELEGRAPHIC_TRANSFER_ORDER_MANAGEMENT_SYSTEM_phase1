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
    public partial class UCItems1 : UserControl
    {
        public UCItems1()
        {
            InitializeComponent();
        }
        #region Properties
        private string _fileName;

        #endregion

        private void UCItems1_Load(object sender, EventArgs e)
        {
            lblFileNameShowing.Text = FileName;
        }

        private void btn_editTTs_Click(object sender, EventArgs e)
        {
            try
            {
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
            finally
            {

            }
        }

        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }


    }
}
