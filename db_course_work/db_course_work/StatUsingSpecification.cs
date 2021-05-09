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
    public partial class StatUsingSpecification : Form
    {
        public StatUsingSpecification()
        {
            InitializeComponent();
            MaximizeBox = false;
            OrderGrid.AllowUserToAddRows = false;
            OrderGrid.AllowUserToDeleteRows = false;
            OrderGrid.AllowUserToResizeRows = false;
            OrderGrid.AllowUserToAddRows = false;

            StatUsingGrid.AllowUserToAddRows = false;
            StatUsingGrid.AllowUserToDeleteRows = false;
            StatUsingGrid.AllowUserToResizeRows = false;
            StatUsingGrid.AllowUserToAddRows = false;
        }
        readonly DB db = new DB();
        MySqlCommand command;
        MySqlDataReader reader;
        List<int> EnabledCusID = new List<int>();

        private void StatUsingSpecification_Load(object sender, EventArgs e)
        {
            try
            {
                OrderGrid.Columns.Clear();
                command = new MySqlCommand("SELECT * FROM custom INNER JOIN material ON custom.Mat_ID = material.Mat_ID");
                db.OpenConnection();
                command.Connection = db.GetConnection();
                reader = command.ExecuteReader();
                OrderGrid.Columns.Add("Cus_ID", "ID заказа"); OrderGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                OrderGrid.Columns.Add("Cus_status", "Статус заказа");
                OrderGrid.Columns.Add("Cus_date", "Дата заказа");
                OrderGrid.Columns.Add("Cus_amount", "Количество");
                OrderGrid.Columns.Add("Mat_description", "Наименование Продукта");
                while (reader.Read())
                {
                    OrderGrid.Rows.Add(reader["Cus_ID"].ToString(), reader["Cus_status"].ToString(),
                        reader["Cus_date"].ToString(), reader["Cus_amount"].ToString(), reader["Mat_description"].ToString());
                    EnabledCusID.Add(int.Parse(reader["Cus_ID"].ToString()));
                }
                reader.Close();
                numericUpDownOrderID.Maximum = EnabledCusID.Max();

                db.CloseConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("В таблице \"Заказы\" отсутствуют заказы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpDownOrderID.Enabled = false;
                buttonShow.Enabled = false;
            }

        }


        private void buttonShow_Click(object sender, EventArgs e)
        {
            List<string> IdOfUsedSpecificatons = new List<string>();
            List<string> IdOfUsedMap = new List<string>();
            List<string> IdOfUsedMaterials = new List<string>();
           
        }
    }
}



