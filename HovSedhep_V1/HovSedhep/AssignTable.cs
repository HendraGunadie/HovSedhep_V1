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
    public partial class AssignTable : Form
    {

        connection conn = new connection();

        public int TableID { get; set; }
        public Button btn { get; set; }

        public AssignTable()
        {
            InitializeComponent();
        }

        private void AssignTable_Load(object sender, EventArgs e)
        {
            loadCmbWaitress();
            loadNameTable();
        }

        void loadCmbWaitress()
        {
            conn.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name, EmployeeID FROM Employees WHERE Role = 'Waitress'", conn.getConnection());
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            conn.closeConnection();

            cmb_waitress.DataSource = dataTable;
            cmb_waitress.DisplayMember = "Name";
            cmb_waitress.ValueMember = "EmployeeID";

        }

        void AssignTheTable()
        {
            conn.openConnection();

            string waitressName = cmb_waitress.SelectedItem.ToString();
            string customerName = txb_customer_name.Text;
            int pax = Convert.ToInt32(num_pax.Value);


            if (string.IsNullOrEmpty(waitressName))
            {
                MessageBox.Show("Waitress Harus Di Isi");
                return;
            }
            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Customer Harus Di Isi");
                return;
            }

            if (pax >= 6 || pax < 0)
            {
                MessageBox.Show("Kapasitas Meja Hanya 1 - 6");
                return;
            }


            int idealCapacity = 0;

            if (pax <= 2)
            {
                idealCapacity = 2;
            } else if (pax <= 4)
            {
                idealCapacity = 4;
            } else if (pax <= 6)
            {
                idealCapacity = 6;
            } else
            {
                MessageBox.Show("Jumlah pax melebihi kapasitas meja");
                return;
            }

            var cmd = new SqlCommand(@"SELECT TOP 1 TableID FROM RestaurantTables WHERE Capacity = @cap AND TableID NOT IN (SELECT TableID FROM Transactions WHERE Status = 'Ongoing')", conn.getConnection()); 
            cmd.Parameters.AddWithValue("@cap", idealCapacity);
            var result = cmd.ExecuteScalar();

            if (result == null)
            {
                MessageBox.Show("Tidak ada meja yang kosong dengan kapasitas yang sesuai");
                return;
            }

            int tableID = (int)result;

            SqlCommand insertTransaction = new SqlCommand(@"INSERT INTO Transactions (TableID, CustomerName, TransactionDate, Status) VALUES
                                                        (@tblID, @custName, GETDATE(), 'Ongoing')", conn.getConnection());
            insertTransaction.Parameters.AddWithValue("@tblID", tableID);
            insertTransaction.Parameters.AddWithValue("@custName", customerName);
            insertTransaction.ExecuteNonQuery();

            SqlCommand getTransactionID = new SqlCommand(@"SELECT TransactionID FROM Transactions WHERE TableID = @tblID AND Status = 'Ongoing'", conn.getConnection());
            getTransactionID.Parameters.AddWithValue("@tblID", tableID);
            int TransactionID = Convert.ToInt32(getTransactionID.ExecuteScalar());

            SqlCommand insertOrders = new SqlCommand(@"INSERT INTO Orders (TransactionID, EmployeeID, OrderTime) VALUES (@transID, @empID, GETDATE())", conn.getConnection());
            insertOrders.Parameters.AddWithValue("@transID", TransactionID);
            insertOrders.Parameters.AddWithValue("@empID", cmb_waitress.SelectedValue);
            insertOrders.ExecuteNonQuery();

            conn.closeConnection();

            MessageBox.Show("Meja Berhasil di Assign", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        void loadNameTable()
        {
            conn.openConnection();

            SqlCommand cmd = new SqlCommand(@"SELECT Name FROM RestaurantTables WHERE TableID = @tblID", conn.getConnection());
            cmd.Parameters.AddWithValue("@tblID", TableID);

            string nameTable = cmd.ExecuteScalar().ToString();

            this.Text = "Assign Table - " + nameTable;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            AssignTheTable();
        }
    }
}
