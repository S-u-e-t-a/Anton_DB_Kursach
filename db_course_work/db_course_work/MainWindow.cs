using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace db_course_work
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            MaximizeBox = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToAddRows = false;
        }


        readonly DB db = new DB();
        MySqlDataReader reader;

        private void ButtonNomenclature_Click(object sender, EventArgs e)
        {
            labelNameTable.Text = "Номенклатура";
            dataGridView1.Columns.Clear();
            MySqlCommand command = new MySqlCommand("SELECT * FROM material");
            db.OpenConnection();
            command.Connection = db.GetConnection();
            reader = command.ExecuteReader();
            dataGridView1.Columns.Add("Mat_ID", "ID Продукта"); dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns.Add("Mat_description", "Описание");
            dataGridView1.Columns.Add("Spec_ID", "ID Спецификации");
            dataGridView1.Columns.Add("Map_ID", "ID Тех.карты");
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["Mat_ID"].ToString(), reader["Mat_description"].ToString(), reader["Spec_ID"].ToString(), reader["Map_ID"].ToString());
            }
            reader.Close();
            db.CloseConnection();

        }

        private void ButtonStocks_Click(object sender, EventArgs e)
        {
            labelNameTable.Text = "Запасы";
            dataGridView1.Columns.Clear();
            MySqlCommand command = new MySqlCommand("SELECT * FROM contains");
            db.OpenConnection();
            command.Connection = db.GetConnection();
            reader = command.ExecuteReader();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns.Add("Mat_ID", "ID Продукта");
            dataGridView1.Columns.Add("St_ID", "ID Склада");
            dataGridView1.Columns.Add("Cont_amount", "Количество");
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["Mat_ID"].ToString(),
                    reader["St_ID"].ToString(),
                    reader["Cont_amount"].ToString());
            }
            reader.Close();
            db.CloseConnection();
        }

        private void buttonCustoms_Click(object sender, EventArgs e)
        {
            labelNameTable.Text = "Заказы";
            dataGridView1.Columns.Clear();
            MySqlCommand command = new MySqlCommand("SELECT * FROM custom");
            db.OpenConnection();
            command.Connection = db.GetConnection();
            reader = command.ExecuteReader();
            dataGridView1.Columns.Add("Cus_ID", "ID Заказа"); dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns.Add("Cus_status", "Статус");
            dataGridView1.Columns.Add("Cus_date", "Дата");
            dataGridView1.Columns.Add("Cus_amount", "Количество");
            dataGridView1.Columns.Add("Mat_ID", "ID Продукта");
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["Cus_ID"].ToString(),
                    reader["Cus_status"].ToString(),
                    reader["Cus_date"].ToString(),
                    reader["Cus_amount"].ToString(),
                    reader["Mat_ID"].ToString());
            }
            reader.Close();
            db.CloseConnection();
        }

        private void buttonFactory_Click(object sender, EventArgs e)
        {
            labelNameTable.Text = "Рабочие центры";
            dataGridView1.Columns.Clear();
            MySqlCommand command = new MySqlCommand("SELECT * FROM factory");
            db.OpenConnection();
            command.Connection = db.GetConnection();
            reader = command.ExecuteReader();
            dataGridView1.Columns.Add("Fact_ID", "ID РЦ"); dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns.Add("Fact_status", "Статус РЦ");
            dataGridView1.Columns.Add("Fact_time", "Ост.время работы");

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["Fact_ID"].ToString(),
                    reader["Fact_status"].ToString(),
                    reader["Fact_time"].ToString());
            }
            reader.Close();
            db.CloseConnection();
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            labelNameTable.Text = "Группы заменимости";
            dataGridView1.Columns.Clear();
            MySqlCommand command = new MySqlCommand("SELECT * FROM group_change");
            db.OpenConnection();
            command.Connection = db.GetConnection();
            reader = command.ExecuteReader();
            dataGridView1.Columns.Add("Gr_ID", "ID группы"); dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns.Add("Fact_ID", "ID РЦ");

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["Gr_ID"].ToString(),
                    reader["Fact_ID"].ToString());
            }
            reader.Close();
            db.CloseConnection();
        }

        private void buttonStore_Click(object sender, EventArgs e)
        {
            labelNameTable.Text = "Склады";
            dataGridView1.Columns.Clear();
            MySqlCommand command = new MySqlCommand("SELECT * FROM storage");
            db.OpenConnection();
            command.Connection = db.GetConnection();
            reader = command.ExecuteReader();
            dataGridView1.Columns.Add("St_ID", "ID склада"); dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns.Add("St_description", "Описание");

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["St_ID"].ToString(),
                    reader["St_description"].ToString());
            }
            reader.Close();
            db.CloseConnection();
        }

        #region buttons save & delete
        //private void buttonSaveData_Click(object sender, EventArgs e)
        //{
        //    db.OpenConnection();
        //    MySqlCommand command = new MySqlCommand("DELETE FROM factory", db.GetConnection());
        //    command.ExecuteNonQuery();
        //    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
        //    {
        //        command = new MySqlCommand("INSERT INTO factory VALUES (@a, @b, @c )", db.GetConnection());
        //        command.Parameters.Add("@a", MySqlDbType.Int32).Value = dataGridView1.Rows[i].Cells[0].Value;
        //        command.Parameters.Add("@b", MySqlDbType.VarChar).Value = dataGridView1.Rows[i].Cells[1].Value;
        //        command.Parameters.Add("@c", MySqlDbType.VarChar).Value = dataGridView1.Rows[i].Cells[2].Value;
        //        command.ExecuteNonQuery();
        //    }
        //    db.CloseConnection();
        //}

        //private void buttonDeleteData_Click(object sender, EventArgs e)
        //{
        //    string index = dataGridView1.CurrentCell.Value.ToString();
        //    if (MessageBox.Show("Удалить кортеж? ", "Удаление кортежа", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //    {
        //        db.OpenConnection();
        //        MySqlCommand command = new MySqlCommand("DELETE FROM factory WHERE Fact_ID = @id", db.GetConnection());
        //        command.Parameters.Add("@id", MySqlDbType.VarChar).Value = index;
        //        command.ExecuteNonQuery();

        //        buttonFactory_Click(null, null);

        //        db.CloseConnection();
        //    }
        //}
        #endregion

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Можно посмотреть содержимое всех таблиц\n" +
                "Можно удалить и добавить информацию в таблицу РЦ");
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            var import = new Import();
            import.ShowDialog();
        }

        private void buttonShake_Click(object sender, EventArgs e)
        {
            var moving = new Moving();
            moving.ShowDialog();
        }

        private void ButtonAddPurchase_Click(object sender, EventArgs e)
        {
            var order = new Order();
            order.ShowDialog();
        }

        private void buttonManageFactory_Click(object sender, EventArgs e)
        {
            var factory = new Factory();
            factory.ShowDialog();
        }

        private void buttonUsing_Click(object sender, EventArgs e)
        {
            var usingStat = new StatUsingSpecification();
            usingStat.ShowDialog();
        }
    }
}
