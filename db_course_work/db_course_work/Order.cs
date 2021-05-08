using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace db_course_work
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
            MaximizeBox = false;
        }
        readonly DB db = new DB();
        private void buttonEnterImport_Click(object sender, EventArgs e)
        {
            try
            {
                var command = new MySqlCommand("INSERT INTO custom (Mat_ID, Cus_amount, Cus_status, Cus_date) VALUES (@id, @amount, @status, @date)");
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = numericUpDownMaterialID.Value;
                command.Parameters.Add("@amount", MySqlDbType.Int32).Value = numericUpDownAmount.Value;
                command.Parameters.Add("@status", MySqlDbType.Int32).Value = 1;
                command.Parameters.Add("@date", MySqlDbType.DateTime).Value = DateTime.Now;
                db.OpenConnection();
                command.Connection = db.GetConnection();
                command.ExecuteNonQuery();
                db.CloseConnection();
            }
            catch (MySqlException)
            {

            }
        }
    }
}
