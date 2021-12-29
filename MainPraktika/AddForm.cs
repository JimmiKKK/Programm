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
    public partial class AddForm : Form
    {
        string connectionStribng = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Zachet;Integrated Security=True";
        public SqlConnection myConnection;
        public AddForm()
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

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand PP = new SqlCommand("INSERT INTO [Zachet] (FioStudenta,FioPrepodovatelya,Ochenka,Dischiplina,Data) VALUES (@S,@P,@O,@D,@Da)", myConnection);
            PP.Parameters.AddWithValue("@S", textBox1.Text);
            PP.Parameters.AddWithValue("@P", textBox2.Text);
            PP.Parameters.AddWithValue("@O", textBox3.Text);
            PP.Parameters.AddWithValue("@D", textBox4.Text);
            PP.Parameters.AddWithValue("@Da", textBox5.Text);
            PP.ExecuteNonQuery();
            MessageBox.Show("Save");
            this.Close();
        }
    }
}
