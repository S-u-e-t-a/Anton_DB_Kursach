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
    public partial class FactoryOrder : Form
    {
        public FactoryOrder()
        {
            InitializeComponent();
            MaximizeBox = false;

            FactoryOrderGrid.AllowUserToAddRows = false;
            FactoryOrderGrid.AllowUserToDeleteRows = false;
            FactoryOrderGrid.AllowUserToResizeRows = false;
            FactoryOrderGrid.AllowUserToAddRows = false;
        }

        readonly DB db = new DB();
        MySqlCommand command;
        MySqlDataReader reader;
        List<int> EnabledCusID = new List<int>();

        private void FactoryOrder_Load(object sender, EventArgs e)
        {
            FactoryOrderGrid.Columns.Clear();
            command = new MySqlCommand("SELECT Cus_ID, Cus_amount, Mat_description FROM custom INNER JOIN material ON custom.Mat_ID = material.Mat_ID WHERE Cus_status = \"Создан\"");
            db.OpenConnection();
            command.Connection = db.GetConnection();
            reader = command.ExecuteReader();
            FactoryOrderGrid.Columns.Add("Cus_ID", "ID заказа"); FactoryOrderGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            FactoryOrderGrid.Columns.Add("Cus_amount", "Количество");
            FactoryOrderGrid.Columns.Add("Mat_description", "Товар");
            while (reader.Read())
            {
                FactoryOrderGrid.Rows.Add(reader["Cus_ID"].ToString(), reader["Cus_amount"].ToString(), reader["Mat_description"].ToString());
                EnabledCusID.Add(int.Parse(reader["Cus_ID"].ToString()));
            }
            reader.Close();
            IDFactoryOrderNumericUpDown.Maximum = EnabledCusID.Max();

            db.CloseConnection();
        }

        private void ButtonCloseOrder_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonStartProcess_Click(object sender, EventArgs e)
        {
            if (EnabledCusID.Contains((int)IDFactoryOrderNumericUpDown.Value))
            {
                db.OpenConnection();
                try
                {
                    command = new MySqlCommand("UPDATE custom SET Cus_status = @status WHERE Cus_ID = @cusid", db.GetConnection());
                    command.Parameters.Add("@status", MySqlDbType.VarChar).Value = "Производится";
                    command.Parameters.Add("@cusid", MySqlDbType.Int32).Value = IDFactoryOrderNumericUpDown.Value;
                    command.Connection = db.GetConnection();
                    command.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.CloseConnection();
                Close();
            }
            else
            {
                MessageBox.Show("Указан некорректный ID заказа. Доступные заказы указаны справа в таблице.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
