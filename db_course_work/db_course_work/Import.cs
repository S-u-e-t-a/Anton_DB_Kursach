using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace db_course_work
{
    public partial class Import : Form
    {
        public Import()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        readonly DB db = new DB();
        private MySqlDataReader reader;

        private void buttonEnterImport_Click(object sender, EventArgs e)
        {
            try
            {
                int oldAmount = 0;
                MySqlCommand command = new MySqlCommand("SELECT Cont_amount FROM contains WHERE Mat_ID = @mat AND St_ID = @stor");
                command.Parameters.Add("@mat", MySqlDbType.Int32).Value = numericUpDownStorageID.Value;
                command.Parameters.Add("@stor", MySqlDbType.Int32).Value = numericUpDownAmount.Value;

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    oldAmount = (int)reader["Cont_amount"];
                }
                reader.Close();

                command = new MySqlCommand("UPDATE contains SET Cont_amount = @newAm WHERE Mat_ID = @mat AND St_ID = @stor");
                command.Parameters.Add("@newAm", MySqlDbType.Int32).Value = numericUpDownMaterialID.Value;
                command.Parameters.Add("@mat", MySqlDbType.Int32).Value = numericUpDownStorageID.Value;
                command.Parameters.Add("@stor", MySqlDbType.Int32).Value = oldAmount + numericUpDownAmount.Value;
                db.OpenConnection();
                command.Connection = db.GetConnection();
                command.ExecuteNonQuery();
                db.CloseConnection();
            }
            catch(MySqlException)
            {

            }
        }

    }
}
