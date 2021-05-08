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
        MySqlCommand command;

        private void buttonEnterImport_Click(object sender, EventArgs e)
        {
            try
            {
                int oldAmount = 0;
                db.OpenConnection();
                                
                command = new MySqlCommand("SELECT Cont_amount FROM contains WHERE Mat_ID = @mat AND St_ID = @stor", db.GetConnection());
                command.Parameters.Add("@stor", MySqlDbType.Int32).Value = numericUpDownStorageID.Value;
                command.Parameters.Add("@mat", MySqlDbType.Int32).Value = numericUpDownMaterialID.Value;

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    oldAmount = (int)reader["Cont_amount"];
                }
                reader.Close();

                command = new MySqlCommand("UPDATE contains SET Cont_amount = @newAm WHERE Mat_ID = @mat AND St_ID = @stor", db.GetConnection());
                command.Parameters.Add("@mat", MySqlDbType.Int32).Value = numericUpDownMaterialID.Value;
                command.Parameters.Add("@stor", MySqlDbType.Int32).Value = numericUpDownStorageID.Value;
                oldAmount += Convert.ToInt32(numericUpDownAmount.Value);
                command.Parameters.Add("@newAm", MySqlDbType.Int32).Value = oldAmount;
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

        private void Import_Load(object sender, EventArgs e)
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
            numericUpDownStorageID.Maximum = сountStorage;

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
