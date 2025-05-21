using HovSedhep_V1.HovSedhep;
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

namespace HovSedhep_V1
{


    public partial class Form1 : Form
    {

        connection conn = new connection();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadAllTables();

            this.Text = "HovSedhep POS System";
        }

        public void loadAllTables()
        {
            conn.openConnection();
            panelTables.Controls.Clear();

            SqlCommand cmd = new SqlCommand("SELECT TableID, Name, Capacity FROM RestaurantTables", conn.getConnection());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int tableID = Convert.ToInt32(reader["TableID"]);
                string nameTable = reader["Name"].ToString();
                int capacity = Convert.ToInt32(reader["Capacity"]);


                Button btn = new Button();
                btn.Text = nameTable;
                btn.Tag = tableID;

                int width = 80 + (capacity * 40);
                int height = 120;

                btn.Size = new Size(width, height);

                switch(nameTable)
                {
                    case "A1": btn.Location = new Point(20,20); break;
                    case "A2": btn.Location = new Point(600,20); break;
                    case "A3": btn.Location = new Point(20,380); break;
                    case "A4": btn.Location = new Point(600,380); break;
                    case "B1": btn.Location = new Point(20,200); break;
                    case "B2": btn.Location = new Point(520,200); break;
                    case "C1": btn.Location = new Point(230, 20); break;
                    case "C2": btn.Location = new Point(230, 380); break;
                }

                btn.Click += (s, e) => AssignTable_click(s, e, tableID, btn);

                panelTables.Controls.Add(btn);

            }

            reader.Close();
            conn.closeConnection();
            updateTableColor();

        }

        void updateTableColor()
        {
            conn.openConnection();

            foreach(Control ctrl in  panelTables.Controls)
            {
                if (ctrl is Button btn && btn.Tag != null)
                {
                    int TableID = Convert.ToInt32(btn.Tag);

                    SqlCommand cmd = new SqlCommand(@"SELECT COUNT(*) FROM Transactions WHERE TableID = @tblID AND Status = 'Ongoing'", conn.getConnection());
                    cmd.Parameters.AddWithValue("@tblID", TableID);

                    int result = Convert.ToInt32(cmd.ExecuteScalar());

                    btn.BackColor = result > 0 ? Color.Yellow : Color.White;
                }
            }
        }



      void AssignTable_click(object sender, EventArgs e, int tableID, Button button)
        {
            
            if (button.BackColor == Color.Yellow)
            {
                conn.openConnection();

                SqlCommand cmdTransactionID = new SqlCommand(@"SELECT TransactionID FROM Transactions WHERE TableID = @tblID AND Status = 'Ongoing'", conn.getConnection());
                cmdTransactionID.Parameters.AddWithValue("@tblID", tableID);
                int transactionID = Convert.ToInt32(cmdTransactionID.ExecuteScalar());

                SqlCommand cmdEmployeeID = new SqlCommand(@"SELECT EmployeeID FROM Orders WHERE TransactionID = @transID", conn.getConnection());
                cmdEmployeeID.Parameters.AddWithValue("@transID", transactionID);
                int EmployeeID = Convert.ToInt32(cmdEmployeeID.ExecuteScalar());

                SqlCommand cmdEmployeeName = new SqlCommand(@"SELECT Name FROM Employees WHERE EmployeeID = @empID AND Role = 'Waitress'", conn.getConnection());
                cmdEmployeeName.Parameters.AddWithValue("@empID", EmployeeID);
                string EmployeesName = cmdEmployeeName.ExecuteScalar().ToString();

                SqlCommand cmdCustomerName = new SqlCommand(@"SELECT CustomerName FROM Transactions WHERE TableID = @tblID AND Status = 'Ongoing'", conn.getConnection());
                cmdCustomerName.Parameters.AddWithValue("tblID", tableID);
                string CustomerName = cmdCustomerName.ExecuteScalar().ToString();

                SqlCommand cmdCapacity = new SqlCommand(@"SELECT Capacity FROM RestaurantTables WHERE TableID = @tblID", conn.getConnection());
                cmdCapacity.Parameters.AddWithValue("@tblID", tableID);
                int Capacity = Convert.ToInt32(cmdCapacity.ExecuteScalar());

                TableSeat tableSeat = new TableSeat();
                tableSeat.TableID = tableID;
                tableSeat.button = button;
                tableSeat.customerName = CustomerName;
                tableSeat.waitressName = EmployeesName;
                tableSeat.pax = Capacity;
                tableSeat.FormClosed += (s, arg) => { this.Show(); loadAllTables(); };
                tableSeat.Show();
                    this.Hide();  


            } else
            {
                AssignTable asTable = new AssignTable();
                asTable.TableID = tableID;
                asTable.btn = button;
                asTable.FormClosed += (s, arg) => { this.Show(); loadAllTables(); };
                asTable.Show();
                this.Hide();
            }

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            menu Menu = new menu();
            Menu.Show();
            this.Hide();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
            this.Hide();
        }

        private void btn_table_seating_Click(object sender, EventArgs e)
        {

        }
    }
}
