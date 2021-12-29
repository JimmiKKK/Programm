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
    public partial class RedakForm : Form
    {
        string connectionStribng = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Zachet;Integrated Security=True";
        public SqlConnection myConnection;
        public RedakForm()
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

        private void RedakForm_Load(object sender, EventArgs e)
        {

        }

        private void RedAdd_Click(object sender, EventArgs e)
        {
            SqlCommand Red = new SqlCommand("UPDATE [Zachet] SET [FioStudenta]=@FioStudenta, [FioPrepodovatelya]=@FioPrepodovatelya, [Ochenka]=@Ochenka, [Dischiplina]=@Dischiplina, [Data]=@Data WHERE [IdZacheta]=@IdZacheta", myConnection);
            Red.Parameters.AddWithValue("FioStudenta", textBox1.Text);
            Red.Parameters.AddWithValue("FioPrepodovatelya", textBox2.Text);
            Red.Parameters.AddWithValue("Ochenka", textBox3.Text);
            Red.Parameters.AddWithValue("Dischiplina", textBox4.Text);
            Red.Parameters.AddWithValue("Data", textBox5.Text);
            Red.Parameters.AddWithValue("IdZacheta", TbId.Text);
            Red.ExecuteNonQuery();
            MessageBox.Show("Red");
            this.Close();
        }
    }
}
