using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MainPraktika
{
    public partial class DeletForm : Form
    {
        string connectionStribng = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Zachet;Integrated Security=True";
        public SqlConnection myConnection;
        public DeletForm()
        {
            InitializeComponent();
            myConnection = new SqlConnection(connectionStribng);
            try
            {
                myConnection.Open();
            }
            catch
            {

            }

        }

        private void DeletForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            SqlCommand dell = new SqlCommand("DELETE FROM [Zachet] Where [IdZacheta]=@Zac", myConnection);
            dell.Parameters.AddWithValue("@Zac", textBox5.Text);
            dell.ExecuteNonQuery();
            MessageBox.Show("Dell");
            this.Close();
        }
    }
}
