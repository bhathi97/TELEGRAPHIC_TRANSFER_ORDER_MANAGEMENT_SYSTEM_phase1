using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_TelegraphicTransfer
{
    public partial class UCFileHandeling : UserControl
    {
        #region connection
        SqlConnection connsql = new SqlConnection(connectionString.ConnectionString);
        #endregion

        #region properties
        private string _lblTest;
        public string LblTest
        {
            get { return _lblTest; }
            set { _lblTest = value; }
        }
        #endregion
        //lblTest.Text = _lblTest;

        public UCFileHandeling()
        {
            InitializeComponent();

        }




        //++++++++++++++++++++++++++++++++ have to implement


        public void loadItems()
        {
            try
            {
                connsql.Open();
                // Create a SqlCommand to retrieve the rows
                SqlCommand cmdItemLoad = new SqlCommand("SELECT * FROM tbl_TEST", connsql);

                // Execute the query and retrieve the rows
                SqlDataReader reader = cmdItemLoad.ExecuteReader();

                while (reader.Read())
                {
                    UCItems1 uCItem = new UCItems1();
                    uCItem.FileName = reader["ID"].ToString();

                    // Add UCItems1 control to the panel
                    flp_fileItemsShowingPanel.Controls.Add(uCItem);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connsql.Close();
            }

        }

        private void UCFileHandeling_Load(object sender, EventArgs e)
        {
            loadItems();

        }
    }
}
