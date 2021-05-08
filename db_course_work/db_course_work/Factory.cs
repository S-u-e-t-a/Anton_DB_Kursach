using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace db_course_work
{
    public partial class Factory : Form
    {
        public Factory()
        {
            InitializeComponent();
            MaximizeBox = false;
        }
        readonly DB db = new DB();
        private void buttonEnterFactory_Click(object sender, EventArgs e)
        {
            try
            {
                var command = new MySqlCommand("UPDATE factoty SET Fact_status = @stat, Fact_time = @time WHERE Fact_ID = @id");
                command.Parameters.Add("@stat", MySqlDbType.VarChar).Value = textBoxStatus.Text;
                command.Parameters.Add("@time", MySqlDbType.Int32).Value = numericUpDownTime.Value;
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = numericUpDownFactID.Value;
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
