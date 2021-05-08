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
        MySqlCommand command;
        private void buttonEnterMoving_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(numericUpDownStorageIDFrom.Value == numericUpDownStorageIDTo.Value))
                {
                    db.OpenConnection();
                    int amountFrom = 0;
                    int amountTo = 0;

                    command = new MySqlCommand("SELECT Cont_amount FROM contains WHERE Mat_ID = @mat AND St_ID = @stor", db.GetConnection());
                    command.Parameters.Add("@stor", MySqlDbType.Int32).Value = numericUpDownStorageIDFrom.Value;
                    command.Parameters.Add("@mat", MySqlDbType.Int32).Value = numericUpDownMaterialID.Value;

                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        amountFrom = (int)reader["Cont_amount"];
                    }
                    reader.Close();

                    command = new MySqlCommand("SELECT Cont_amount FROM contains WHERE Mat_ID = @mat AND St_ID = @stor", db.GetConnection());
                    command.Parameters.Add("@stor", MySqlDbType.Int32).Value = numericUpDownStorageIDTo.Value;
                    command.Parameters.Add("@mat", MySqlDbType.Int32).Value = numericUpDownMaterialID.Value;

                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        amountTo = (int)reader["Cont_amount"];
                    }
                    reader.Close();

                    if (amountFrom >= numericUpDownAmount.Value)
                    {

                        command = new MySqlCommand("UPDATE contains SET Cont_amount = @newAm WHERE Mat_ID = @mat AND St_ID = @stor", db.GetConnection());
                        command.Parameters.Add("@mat", MySqlDbType.Int32).Value = numericUpDownMaterialID.Value;
                        command.Parameters.Add("@stor", MySqlDbType.Int32).Value = numericUpDownStorageIDFrom.Value;
                        command.Parameters.Add("@newAm", MySqlDbType.Int32).Value = amountFrom - numericUpDownAmount.Value;
                        command.Connection = db.GetConnection();
                        command.ExecuteNonQuery();

                        command = new MySqlCommand("UPDATE contains SET Cont_amount = @newAm WHERE Mat_ID = @mat AND St_ID = @stor", db.GetConnection());
                        command.Parameters.Add("@mat", MySqlDbType.Int32).Value = numericUpDownMaterialID.Value;
                        command.Parameters.Add("@stor", MySqlDbType.Int32).Value = numericUpDownStorageIDTo.Value;
                        command.Parameters.Add("@newAm", MySqlDbType.Int32).Value = amountTo + numericUpDownAmount.Value;
                        command.Connection = db.GetConnection();
                        command.ExecuteNonQuery();
                       
                    }
                    else
                    {
                        MessageBox.Show("Вы не можете переместить бо́льшее количество материала, чем имеется на складе отправки", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    
                }
                else
                {
                    MessageBox.Show("Перемещения возможны между различными складами", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Moving_Load(object sender, EventArgs e)
        {
            db.OpenConnection();

            int сountStorage = 0;
            int сountMaterials = 0;

            command = new MySqlCommand("SELECT COUNT(St_ID) FROM storage", db.GetConnection());
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                сountStorage = Convert.ToInt32(reader["COUNT(St_ID)"]);
            }
            reader.Close();
            numericUpDownStorageIDFrom.Maximum = сountStorage;
            numericUpDownStorageIDTo.Maximum = сountStorage;

            command = new MySqlCommand("SELECT MAX(Mat_ID) FROM material", db.GetConnection());
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                сountMaterials = Convert.ToInt32(reader["MAX(Mat_ID)"]);
            }
            reader.Close();
            numericUpDownMaterialID.Maximum = сountMaterials;

            db.CloseConnection();
        }
    }
}
