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
                if (!string.IsNullOrWhiteSpace(textBoxStatus.Text))
                {
                    db.OpenConnection();
                    var command = new MySqlCommand("UPDATE factory SET Fact_status = @stat, Fact_time = @time WHERE Fact_ID = @id", db.GetConnection());
                    command.Parameters.Add("@stat", MySqlDbType.VarChar).Value = textBoxStatus.Text;
                    command.Parameters.Add("@time", MySqlDbType.Int32).Value = numericUpDownTime.Value;
                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(comboBoxFactID.Text);
                    command.Connection = db.GetConnection();
                    command.ExecuteNonQuery();
                    db.CloseConnection();
                    Close();
                }
                else
                {
                    MessageBox.Show("Вы не указали статус РЦ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
