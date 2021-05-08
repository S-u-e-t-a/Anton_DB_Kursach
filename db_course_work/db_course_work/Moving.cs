using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace db_course_work
{
    public partial class Moving : Form
    {
        public Moving()
        {
            InitializeComponent();
        }
        readonly DB db = new DB();
        private MySqlDataReader reader;
        private void buttonEnterMoving_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();
                int amountFrom = 0;
                int amountTo = 0;

                MySqlCommand command = new MySqlCommand("SELECT Cont_amount FROM contains WHERE Mat_ID = @mat AND St_ID = @stor", db.GetConnection());
                command.Parameters.Add("@mat", MySqlDbType.Int32).Value = numericUpDownStorageIDFrom.Value;
                command.Parameters.Add("@stor", MySqlDbType.Int32).Value = numericUpDownAmount.Value;

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    amountFrom = (int)reader["Cont_amount"];
                }
                reader.Close();

                command = new MySqlCommand("SELECT Cont_amount FROM contains WHERE Mat_ID = @mat AND St_ID = @stor", db.GetConnection());
                command.Parameters.Add("@mat", MySqlDbType.Int32).Value = numericUpDownStorageIDTo.Value;
                command.Parameters.Add("@stor", MySqlDbType.Int32).Value = numericUpDownAmount.Value;

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    amountTo = (int)reader["Cont_amount"];
                }
                reader.Close();

                numericUpDownAmount.Maximum = amountFrom;

                command = new MySqlCommand("UPDATE contains SET Cont_amount = @newAm WHERE Mat_ID = @mat AND St_ID = @stor", db.GetConnection());
                command.Parameters.Add("@newAm", MySqlDbType.Int32).Value = numericUpDownMaterialID.Value;
                command.Parameters.Add("@mat", MySqlDbType.Int32).Value = numericUpDownStorageIDFrom.Value;
                command.Parameters.Add("@stor", MySqlDbType.Int32).Value = amountFrom - numericUpDownAmount.Value;
                command.Connection = db.GetConnection();
                command.ExecuteNonQuery();

                command = new MySqlCommand("UPDATE contains SET Cont_amount = @newAm WHERE Mat_ID = @mat AND St_ID = @stor", db.GetConnection());
                command.Parameters.Add("@newAm", MySqlDbType.Int32).Value = numericUpDownMaterialID.Value;
                command.Parameters.Add("@mat", MySqlDbType.Int32).Value = numericUpDownStorageIDTo.Value;
                command.Parameters.Add("@stor", MySqlDbType.Int32).Value = amountTo + numericUpDownAmount.Value;
                command.Connection = db.GetConnection();
                command.ExecuteNonQuery();
                db.CloseConnection();
                Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
