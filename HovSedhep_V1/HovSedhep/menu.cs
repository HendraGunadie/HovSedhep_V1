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
    public partial class menu : Form
    {

        connection conn = new connection();
        public menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            loadAllMenu();
            loadCmbCategory();
        }


        void loadAllMenu()
        {
            conn.openConnection();

            string query = "SELECT MenuItems.MenuItemID, Categories.Name AS CategoryName, MenuItems.Name, MenuItems.Price, MenuItems.Description FROM MenuItems JOIN Categories ON MenuItems.CategoryID = Categories.CategoryID";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn.getConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.closeConnection();

            dataGridMenu.DataSource = dt;
            dataGridMenu.Columns["Price"].DefaultCellStyle.Format = "c0";
            dataGridMenu.Columns["Price"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("id-ID");

        }

        void loadAllMenuFromFilter()
        {
            conn.openConnection();

            string category = (cmb_category.SelectedItem as DataRowView)?["Name"].ToString() ?? "All";
            string name = txb_name.Text;

            string query = "SELECT MenuItems.MenuItemID, Categories.Name AS CategoryName, MenuItems.Name, MenuItems.Price, MenuItems.Description FROM MenuItems JOIN Categories ON MenuItems.CategoryID = Categories.CategoryID WHERE (MenuItems.Name LIKE @nama)";

            if (category != "All")
            {
                query += " AND Categories.Name = @category";
            }

            SqlCommand cmd = new SqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@nama", "%" + name + "%");

            if (category != "All")
            {
                cmd.Parameters.AddWithValue("@category", category);
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.closeConnection();

            dataGridMenu.DataSource= dt;

        }

        void loadCmbCategory()
        {
            conn.openConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(@"SELECT Name FROM Categories", conn.getConnection());
            DataTable dataTable = new DataTable();
            cmd.Fill(dataTable);

            DataRow AllRow = dataTable.NewRow();
            AllRow["Name"] = "All";
            dataTable.Rows.InsertAt(AllRow, 0);

            conn.closeConnection();

            cmb_category.DataSource = dataTable;
            cmb_category.DisplayMember = "Name";
            cmb_category.SelectedIndex = 0;

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            loadAllMenuFromFilter();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
            this.Hide();
        }

        private void btn_table_seating_Click(object sender, EventArgs e)
        {
            Form1 tabseat = new Form1();
            tabseat.Show();
            this.Hide();
        }
    }
}
