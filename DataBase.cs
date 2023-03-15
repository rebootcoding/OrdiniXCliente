using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdiniXCliente
{
    public class DataBase
    {
    private SqlConnectionStringBuilder connectionStringBuilder
    {
        get
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = "WINAPHS2OH2TH8K\\SQLEXPRESS";
            builder.InitialCatalog = "AcademyNet";
            builder.IntegratedSecurity = true;
            return builder;
        }
    }

    private SqlConnection GetConnection()
    {
        return new SqlConnection(connectionStringBuilder.ConnectionString);
    }

    public DataTable GetCustomers()
    {
        using (var conn = GetConnection())
        {
            var command = new SqlCommand();
            command.CommandText = "SELECT (c.last_name + ' ' + c.first_name) AS 'Nome Completo', c.customer_id " + "FROM sales.customers c " + "ORDER BY c.last_name";
            command.Connection = conn;

            try
            {
                conn.Open();
                var reader = command.ExecuteReader();
                var dt = new DataTable();
                dt.Load(reader);
                reader.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
    public DataTable GetAllOrdersByCustomer(string id_customer)
    {
        using (var connection = GetConnection())
        {
            var command = new SqlCommand();
            command.CommandText = $"SELECT o.order_id, o.order_status, o.order_date, o.shipped_date " + "FROM sales.customers c JOIN sales.orders o ON c.customer_id = o.customer_id " + "WHERE c.customer_id =" + id_customer;
            command.Connection = connection;
            try
            {
                connection.Open();
                var reader = command.ExecuteReader();
                var dt = new DataTable();
                dt.Load(reader);
                reader.Close();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}
}
