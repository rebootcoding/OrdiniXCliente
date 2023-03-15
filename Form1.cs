using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrdiniXCliente
{
    public partial class Form1 : Form
    {
        public DataBase db;
        public Form1()
        {
            InitializeComponent();
            db = new DataBase();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection())
            {

                var rows = db.GetCustomers().DefaultView;
                cbx_customers.DisplayMember = "Nome Completo";
                cbx_customers.DataSource = rows;
            }
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            var selItem = cbx_customers.SelectedItem as DataRowView;

            var id_customer = $"{selItem["customer_id"]}";
            var table = db.GetAllOrdersByCustomer(id_customer);
            dataGridView1.DataSource = table;
        }
    }
}
