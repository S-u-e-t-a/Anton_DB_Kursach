using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace db_course_work
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
            MaximizeBox = false;
            MaterialGrid.AllowUserToAddRows = false;
            MaterialGrid.AllowUserToDeleteRows = false;
            MaterialGrid.AllowUserToResizeRows = false;
            MaterialGrid.AllowUserToAddRows = false;
        }
        readonly DB db = new DB();
        MySqlCommand command;
        List<int> EnabledMatID = new List<int>();
        MySqlDataReader reader;
        List<int> amountMat = new List<int>();

        private void buttonEnterImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (EnabledMatID.Contains(Convert.ToInt32(numericUpDownMaterialID.Value)))
                {
                    db.OpenConnection();
                    command = new MySqlCommand("INSERT INTO custom (Mat_ID, Cus_amount, Cus_status, Cus_date) VALUES (@id, @amount, @status, @date)", db.GetConnection());
                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = numericUpDownMaterialID.Value;
                    command.Parameters.Add("@amount", MySqlDbType.Int32).Value = numericUpDownAmount.Value;
                    command.Parameters.Add("@status", MySqlDbType.Int32).Value = 1;
                    command.Parameters.Add("@date", MySqlDbType.DateTime).Value = DateTime.Now;
                    command.Connection = db.GetConnection();
                    command.ExecuteNonQuery();
                    

                    Close();
                }
                else
                {
                    MessageBox.Show("Указан некорректный ID продукта. Доступные для заказа товары указаны справа в таблице.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
                command = new MySqlCommand("SELECT Cont_amount FROM contains WHERE Mat_ID = @matid", db.GetConnection());
                command.Parameters.Add("@matid", MySqlDbType.Int32).Value = numericUpDownMaterialID.Value;

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    amountMat.Add(Convert.ToInt32(reader["Cont_amount"]));
                }
                reader.Close();
               

                if (amountMat[0] >= numericUpDownAmount.Value)
                {
                    
                    command = new MySqlCommand("UPDATE custom SET Cus_status = @status WHERE Mat_ID = @matid", db.GetConnection());
                    command.Parameters.Add("@status", MySqlDbType.Int32).Value = 0;
                    command.Parameters.Add("@matid", MySqlDbType.Int32).Value = numericUpDownMaterialID.Value;
                    command.Connection = db.GetConnection();
                    command.ExecuteNonQuery(); 

                    command = new MySqlCommand("UPDATE contains SET Cont_amount = @newCont WHERE Mat_ID = @matid AND St_ID = @st", db.GetConnection());
                    command.Parameters.Add("@newCont", MySqlDbType.Int32).Value = amountMat[0] - numericUpDownAmount.Value;
                    command.Parameters.Add("@st", MySqlDbType.Int32).Value = 1;
                    command.Parameters.Add("@matid", MySqlDbType.Int32).Value = numericUpDownMaterialID.Value;
                    command.Connection = db.GetConnection();
                    command.ExecuteNonQuery(); 

                }
                else if(amountMat[1] >= numericUpDownAmount.Value)
                {
                    
                    command = new MySqlCommand("UPDATE custom SET Cus_status = @status WHERE Mat_ID = @matid", db.GetConnection());
                    command.Parameters.Add("@status", MySqlDbType.Int32).Value = 0;
                    command.Parameters.Add("@matid", MySqlDbType.Int32).Value = numericUpDownMaterialID.Value;
                    command.Connection = db.GetConnection();
                    command.ExecuteNonQuery(); 
                    
                    command = new MySqlCommand("UPDATE contains SET Cont_amount = @newCont WHERE Mat_ID = @matid AND St_ID = @st", db.GetConnection());
                    command.Parameters.Add("@newCont", MySqlDbType.Int32).Value = amountMat[1] - numericUpDownAmount.Value;
                    command.Parameters.Add("@st", MySqlDbType.Int32).Value = 2;
                    command.Parameters.Add("@matid", MySqlDbType.Int32).Value = numericUpDownMaterialID.Value;
                    command.Connection = db.GetConnection();
                    command.ExecuteNonQuery(); 

                }

                db.CloseConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Order_Load(object sender, EventArgs e)
        {


            MaterialGrid.Columns.Clear();
            command = new MySqlCommand("SELECT Mat_ID, Mat_description FROM material WHERE Spec_ID IS NOT NULL ORDER BY Mat_ID");
            db.OpenConnection();
            command.Connection = db.GetConnection();
            reader = command.ExecuteReader();
            MaterialGrid.Columns.Add("Mat_ID", "ID Продукта"); MaterialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            MaterialGrid.Columns.Add("Mat_description", "Описание");
            while (reader.Read())
            {
                MaterialGrid.Rows.Add(reader["Mat_ID"].ToString(), reader["Mat_description"].ToString());
                EnabledMatID.Add(int.Parse(reader["Mat_ID"].ToString()));
            }
            reader.Close();
            numericUpDownMaterialID.Maximum = EnabledMatID.Max();

            db.CloseConnection();
        }
    }
}
