using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_course_work
{
    public partial class LoadOut : Form
    {
        public LoadOut()
        {
            InitializeComponent();
        }
        readonly DB db = new DB();
        MySqlCommand command;
        List<int> EnabledMatID = new List<int>();
        List<int> EnabledStorageID = new List<int>();
        int necessaryAmount = 0;
        int factAmount = 0;
        MySqlDataReader reader;

        private void buttonMakeLoadOut_Click(object sender, EventArgs e)
        {
            if(EnabledMatID.Contains(Convert.ToInt32(numericUpDownMaterialID.Value)) && EnabledStorageID.Contains(Convert.ToInt32(numericUpDownStorageID.Value)))
            {
                db.OpenConnection();
                try
                {
                    necessaryAmount = Convert.ToInt32(numericUpDownAmount.Value);

                    command = new MySqlCommand("SELECT Cont_amount FROM contains WHERE Mat_ID = @matID AND St_ID = @stID");
                    command.Parameters.Add("@matID", MySqlDbType.Int32).Value = numericUpDownMaterialID.Value;
                    command.Parameters.Add("@stID", MySqlDbType.Int32).Value = numericUpDownStorageID.Value;
                    command.Connection = db.GetConnection();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        factAmount = (int.Parse(reader["Cont_amount"].ToString()));
                    }
                    reader.Close();
                    
                    if(factAmount >= necessaryAmount)
                    {
                        command = new MySqlCommand("UPDATE contains SET Cont_amount = @newAm WHERE St_ID = @stID AND Mat_ID = @matID", db.GetConnection());
                        command.Parameters.Add("@newAm", MySqlDbType.Int32).Value = factAmount - necessaryAmount;
                        command.Parameters.Add("@stID", MySqlDbType.Int32).Value = numericUpDownStorageID.Value;
                        command.Parameters.Add("@matID", MySqlDbType.Int32).Value = numericUpDownMaterialID.Value;
                        command.Connection = db.GetConnection();
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно указанного товара на указанном складе. Произведите операцию перемещения и/или закупки", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.CloseConnection();
            }
            else
            {
                MessageBox.Show("Указанный товар и/или указанный номер склада не существует. Уточните ID списываемого материала и ID склада списывания", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }

        private void LoadOut_Load(object sender, EventArgs e)
        {
            db.OpenConnection();

            command = new MySqlCommand("SELECT Mat_ID FROM material");
            command.Connection = db.GetConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                EnabledMatID.Add(int.Parse(reader["Mat_ID"].ToString()));
            }
            reader.Close();

            command = new MySqlCommand("SELECT St_ID FROM storage");
            command.Connection = db.GetConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                EnabledStorageID.Add(int.Parse(reader["St_ID"].ToString()));
            }
            reader.Close();

            numericUpDownStorageID.Maximum = EnabledStorageID.Max();
            numericUpDownMaterialID.Maximum = EnabledMatID.Max();

            db.CloseConnection();
        }
    }
}
