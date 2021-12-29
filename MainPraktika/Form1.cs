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
    public partial class MainForm : Form
    {
        string connectionStribng = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Zachet;Integrated Security=True";
        public SqlConnection myConnection;
        public MainForm()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zachetDataSet.Zachet". При необходимости она может быть перемещена или удалена.
            this.zachetTableAdapter.Fill(this.zachetDataSet.Zachet);

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddForm AF = new AddForm();
            AF.Show();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            DeletForm DF = new DeletForm();
            DF.Show();
        }

        private void RedakBtn_Click(object sender, EventArgs e)
        {
            RedakForm RF = new RedakForm();
            RF.Show();
        }
    }
}
