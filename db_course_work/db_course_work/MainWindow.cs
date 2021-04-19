using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace db_course_work
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void ButtonAddPurchase_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM custom", db.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            MessageBox.Show(table.Rows.Count.ToString());
        }
    }
}
