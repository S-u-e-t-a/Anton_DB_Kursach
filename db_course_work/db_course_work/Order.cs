using MySql.Data.MySqlClient;
using System;
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
        private void buttonEnterImport_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();
                command = new MySqlCommand("INSERT INTO custom (Mat_ID, Cus_amount, Cus_status, Cus_date) VALUES (@id, @amount, @status, @date)", db.GetConnection());
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = numericUpDownMaterialID.Value;
                command.Parameters.Add("@amount", MySqlDbType.Int32).Value = numericUpDownAmount.Value;
                command.Parameters.Add("@status", MySqlDbType.Int32).Value = 1;
                command.Parameters.Add("@date", MySqlDbType.DateTime).Value = DateTime.Now;
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

        private void Order_Load(object sender, EventArgs e)
        {
            MySqlDataReader reader;

            MaterialGrid.Columns.Clear();
            command = new MySqlCommand("SELECT Mat_ID, Mat_description FROM material");
            db.OpenConnection();
            command.Connection = db.GetConnection();
            reader = command.ExecuteReader();
            MaterialGrid.Columns.Add("Mat_ID", "ID Продукта"); MaterialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            MaterialGrid.Columns.Add("Mat_description", "Описание");
            while (reader.Read())
            {
                MaterialGrid.Rows.Add(reader["Mat_ID"].ToString(), reader["Mat_description"].ToString());
            }
            reader.Close();

            int сountMaterials = 0;
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
