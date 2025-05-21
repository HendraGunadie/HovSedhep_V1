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

namespace HovSedhep_V1.HovSedhep
{
    public partial class History : Form
    {

        connection conn = new connection();
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            loadMenuGridTransactions();
            loadCmbTable();

            dataGridTransactions.SelectionChanged += DataGridTransactions_SelectionChanged;
            dataGridOrders.SelectionChanged += DataGridOrders_SelectionChanged;
        }


        void loadMenuGridTransactions()
        {
            conn.openConnection();

            string query = "SELECT Transactions.TransactionID, RestaurantTables.Name AS nameTable, Transactions.CustomerName, Transactions.TransactionDate FROM Transactions JOIN RestaurantTables ON Transactions.TableID = RestaurantTables.TableID";

            SqlDataAdapter adapter = new SqlDataAdapter(query,conn.getConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            dt.Columns.Add("totalPrice", typeof(decimal));
            dt.Columns.Add("Date", typeof(string));


            foreach (DataRow dr in dt.Rows)
            {
                DateTime tgl = Convert.ToDateTime(dr["TransactionDate"]);
                dr["Date"] = tgl.ToString("dd MMMM yyyy", new System.Globalization.CultureInfo("id-ID"));

                string transactionID = dr["TransactionID"].ToString();

                decimal totalPrice = loadTotalPrice(transactionID);

                dr["totalPrice"] = totalPrice;
            }

            dt.Columns.Remove("TransactionDate");
            conn.closeConnection();

            dataGridTransactions.DataSource = dt;
            dataGridTransactions.Columns["Date"].DisplayIndex = 3;
            dataGridTransactions.Columns["totalPrice"].DefaultCellStyle.Format = "c0";
            dataGridTransactions.Columns["totalPrice"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("id-ID");

            if (dataGridTransactions.Rows.Count > 0)
            {
                dataGridTransactions.Rows[0].Selected = true;
                dataGridTransactions.CurrentCell = dataGridTransactions.Rows[0].Cells[0];

                DataGridTransactions_SelectionChanged(null, null);
            }


        }

        private decimal loadTotalPrice(string transactionID)
        {
            conn.openConnection();
            decimal totalPrice = 0;

            SqlCommand cmdOrderID = new SqlCommand(@"SELECT OrderID FROM Orders WHERE TransactionID = @transID", conn.getConnection());
            cmdOrderID.Parameters.AddWithValue("@transID", Convert.ToInt32(transactionID));
            int OrderID = Convert.ToInt32(cmdOrderID.ExecuteScalar());

            SqlCommand cmdTotal = new SqlCommand(@"SELECT Quantity, Price FROM OrderDetails WHERE OrderID = @ordID", conn.getConnection());
            cmdTotal.Parameters.AddWithValue("@ordID", OrderID);

            using (SqlDataReader reader = cmdTotal.ExecuteReader())
            {
                while (reader.Read())
                {
                    int quantity = Convert.ToInt32(reader["Quantity"]);
                    decimal price = Convert.ToDecimal(reader["Price"]);

                    totalPrice += quantity * price;
                }
            }

            conn.closeConnection();
            return totalPrice;

        }


        void loadMenuGridOrders(string transactionID)
        {
            string query = @"SELECT Orders.TransactionID, Orders.OrderID, Orders.OrderTime, Employees.Name AS Waitress FROM Orders JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID WHERE Orders.TransactionID = @transID";

            SqlCommand cmd = new SqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@transID", transactionID);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            dt.Columns.Add("NumberOfItemOrdered");

            foreach (DataRow dr in dt.Rows)
            {
                string orderID = dr["OrderID"].ToString();

                int itemOrdered = numberOfItemsOrdered(orderID);

                dr["NumberOfItemOrdered"] = itemOrdered;


            }

            dataGridOrders.DataSource = dt;
            conn.closeConnection( );

        }

        private int numberOfItemsOrdered(string orderID)
        {
            conn.openConnection( );
            int itemOrdered = 0;

            SqlCommand cmd = new SqlCommand(@"SELECT Quantity FROM OrderDetails WHERE OrderID = @ordID", conn.getConnection());
            cmd.Parameters.AddWithValue("@ordID", orderID);
           
            using ( SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int quantity = Convert.ToInt32(reader["Quantity"]);

                    itemOrdered += quantity;
                }
            }

            conn.closeConnection();
            return itemOrdered;

        }

        private void loadMenuGridOrderDetails(string orderID)
        {
            conn.openConnection();

            string query = @"SELECT OrderDetails.OrderID, OrderDetails.OrderDetailID, MenuItems.Name AS MenuName, OrderDetails.Quantity, OrderDetails.Price FROM OrderDetails JOIN MenuItems ON OrderDetails.MenuItemID = MenuItems.MenuItemID WHERE OrderDetails.OrderID = @ordID";

            SqlCommand cmd = new SqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@ordID", orderID);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.closeConnection();
            dataGridOrderDetails.DataSource = dt;
            dataGridOrderDetails.Columns["Price"].DefaultCellStyle.Format = "c0";
            dataGridOrderDetails.Columns["Price"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("id-ID");

        }

        private void loadFromFilter()
        {
            conn.openConnection();

            DateTime date = dtp_date.Value.Date;
            DateTime nextDate = date.AddDays(1);
            string tableName = (cmb_table_name.SelectedItem as DataRowView)?["Name"].ToString()?? "All";

            string query = "SELECT Transactions.TransactionID, RestaurantTables.Name AS nameTable, Transactions.CustomerName, Transactions.TransactionDate FROM Transactions JOIN RestaurantTables ON Transactions.TableID = RestaurantTables.TableID WHERE Transactions.TransactionDate >= @startDate AND Transactions.TransactionDate < @endDate";

            if (tableName != "All")
            {
                query += " AND RestaurantTables.Name LIKE @tableName";
            }

            SqlCommand cmd = new SqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@startDate", date);
            cmd.Parameters.AddWithValue("@endDate", nextDate);

            if (tableName != "All")
            {
                cmd.Parameters.AddWithValue("@tableName", "%" + tableName + "%");
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dt.Columns.Add("totalPrice", typeof(decimal));
            dt.Columns.Add("Date", typeof(string));

            foreach (DataRow dr in dt.Rows)
            {
                DateTime tgl = Convert.ToDateTime(dr["TransactionDate"]);
                dr["Date"] = tgl.ToString("dd MMMM yyyy", new System.Globalization.CultureInfo("id-ID"));

                string transactionID = dr["TransactionID"].ToString();

                decimal totalPrice = loadTotalPrice(transactionID);

                dr["totalPrice"] = totalPrice;
            }

            dt.Columns.Remove("TransactionDate");
            conn.closeConnection();
            dataGridTransactions.DataSource = dt;

            if (dataGridTransactions.Rows.Count > 0)
            {
                dataGridTransactions.Rows[0].Selected = true;
                dataGridTransactions.CurrentCell = dataGridTransactions.Rows[0].Cells[0];

                DataGridTransactions_SelectionChanged(null, null);
            }


        }

        private void loadCmbTable()
        {
            conn.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name FROM RestaurantTables", conn.getConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            DataRow dr = dt.NewRow();
            dr["Name"] = "All";
            dt.Rows.InsertAt(dr, 0);

            conn.closeConnection();

            cmb_table_name.DataSource = dt;
            cmb_table_name.DisplayMember = "Name";
            cmb_table_name.SelectedIndex = 0;

        }


        private void DataGridOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridOrders.CurrentRow != null)
            {
                string orderID = dataGridOrders.CurrentRow.Cells["OrderID"].Value.ToString();
                loadMenuGridOrderDetails(orderID);
            }
        }

        private void DataGridTransactions_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridTransactions.CurrentRow != null)
            {
                string transactionID = dataGridTransactions.CurrentRow.Cells["TransactionID"].Value.ToString();
                loadMenuGridOrders(transactionID);

                if (dataGridOrders.Rows.Count > 0)
                {
                    dataGridOrders.Rows[0].Selected = true;

                    DataGridOrders_SelectionChanged(null, null);
                }
            }
        }




        private void btn_menu_Click(object sender, EventArgs e)
        {
            menu Menu = new menu();
            Menu.Show();
            this.Hide();
        }

        private void btn_table_seating_Click(object sender, EventArgs e)
        {
            Form1 tableseat = new Form1();
            tableseat.Show();
            this.Hide();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            loadFromFilter();
        }
    }
}
