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
    public partial class TableSeat : Form
    {

        connection conn = new connection();
        public int TableID {  get; set; }

        public Button button {  get; set; }

        public string waitressName { get; set; }
        public string customerName { get; set; }
        public int pax {  get; set; }

        public TableSeat()
        {
            InitializeComponent();
        }

        private void TableSeat_Load(object sender, EventArgs e)
        {
            loadNameTable();
            loadTableSeat();
        }

        void loadNameTable()
        {
            conn.openConnection();

            SqlCommand cmd = new SqlCommand(@"SELECT Name FROM RestaurantTables WHERE TableID = @tblID", conn.getConnection());
            cmd.Parameters.AddWithValue("@tblID", TableID);

            string nameTable = cmd.ExecuteScalar().ToString();

            this.Text = "Assign Table - " + nameTable;
        }

        void loadTableSeat()
        {
            txb_customer_name.Text = customerName;
            txb_waitress.Text = waitressName;
            txb_pax.Text = pax.ToString();

        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            conn.openConnection();

            SqlCommand cmd = new SqlCommand(@"UPDATE Transactions SET Status = 'Completed' WHERE TableID = @tblID", conn.getConnection());
            cmd.Parameters.AddWithValue("@tblID", TableID);
            cmd.ExecuteNonQuery();

            conn.closeConnection();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            conn.openConnection();

            SqlCommand cmd = new SqlCommand(@"UPDATE Transactions SET Status = 'Cancelled' WHERE TableID = @tblID", conn.getConnection());
            cmd.Parameters.AddWithValue("@tblID", TableID);
            cmd.ExecuteNonQuery();

            conn.closeConnection();
            this.Close();
        }
    }
}
