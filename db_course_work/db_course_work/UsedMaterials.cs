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
    public partial class UsedMaterials : Form
    {
        public UsedMaterials()
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

        private void UsedMaterials_Load(object sender, EventArgs e)
        {
            try
            {
                OrderGrid.Columns.Clear();
                command = new MySqlCommand("SELECT * FROM custom INNER JOIN material ON custom.Mat_ID = material.Mat_ID WHERE Cus_status = \"Производится\"");
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
                ButtonLoadOut.Enabled = false;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("В таблице \"Заказы\" отсутствуют заказы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpDownOrderID.Enabled = false;
                buttonShow.Enabled = false;
                ButtonLoadOut.Enabled = false;
            }


        }

        UsingInfo info = new UsingInfo();
        private void buttonShow_Click(object sender, EventArgs e)
        {
            ButtonLoadOut.Enabled = true;

            int amount = 0;

            int n = 0;

            if (EnabledCusID.Contains(Convert.ToInt32(numericUpDownOrderID.Value)))
            {
                db.OpenConnection();
                command = new MySqlCommand("SELECT Mat_ID, Cus_amount FROM custom WHERE Cus_ID = @id");
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = numericUpDownOrderID.Value;
                command.Connection = db.GetConnection();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    info.IdOfUsedMaterials.Add(reader["Mat_ID"].ToString());
                    amount = Convert.ToInt32(reader["Cus_amount"]);
                    info.AmountMaterials.Add(amount.ToString());
                }
                reader.Close();

                while (true)
                {
                    for (int i = 0; i < info.IdOfUsedMaterials.Count; i++)
                    {
                        command = new MySqlCommand("SELECT Spec_ID, Map_ID FROM material WHERE Mat_ID = @id");
                        command.Parameters.Add("@id", MySqlDbType.Int32).Value = info.IdOfUsedMaterials[i];
                        command.Connection = db.GetConnection();
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            if (!string.IsNullOrWhiteSpace(reader["Spec_ID"].ToString()) && (!string.IsNullOrWhiteSpace(reader["Map_ID"].ToString())))
                            {
                                info.IdOfUsedSpecificatons.Add(reader["Spec_ID"].ToString());
                                info.IdOfUsedMap.Add(reader["Map_ID"].ToString());
                            }
                        }
                        reader.Close();


                        for (int k = n; k < info.IdOfUsedSpecificatons.Count; k++)
                        {
                            if (!string.IsNullOrWhiteSpace(info.IdOfUsedSpecificatons[k]))
                            {
                                command = new MySqlCommand("SELECT Mat_ID, Comp_amount FROM comp_spec WHERE Spec_ID = @id");
                                command.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(info.IdOfUsedSpecificatons[k]);
                                command.Connection = db.GetConnection();
                                reader = command.ExecuteReader();
                                while (reader.Read())
                                {
                                    if (!info.IdOfUsedMaterials.Contains(reader["Mat_ID"].ToString()))
                                    {
                                        info.IdOfUsedMaterials.Add(reader["Mat_ID"].ToString());
                                        info.AmountMaterials.Add(reader["Comp_amount"].ToString());
                                    }
                                }
                                reader.Close();
                                n++;
                            }
                        }
                    }
                    break;
                }

                info.AmountMaterials.Reverse();
                info.IdOfUsedMap.Reverse(); info.IdOfUsedMaterials.Reverse(); info.IdOfUsedSpecificatons.Reverse();

                StatUsingGrid.Columns.Clear();

                StatUsingGrid.Columns.Add("Step", "Номер шага");
                StatUsingGrid.Columns.Add("Cus_ID", "ID заказа"); StatUsingGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                StatUsingGrid.Columns.Add("Used_Materials", "Используемые материалы");
                StatUsingGrid.Columns.Add("Amount", "Кол-во");

                for (int i = 0; i < info.IdOfUsedMaterials.Count; i++)
                {
                    if (i != info.IdOfUsedMaterials.Count - 1)
                    {
                        StatUsingGrid.Rows.Add(i + 1, numericUpDownOrderID.Value, info.IdOfUsedMaterials[i], (Convert.ToInt32(info.AmountMaterials[i]) * amount).ToString());
                    }
                    else
                        StatUsingGrid.Rows.Add(i + 1, numericUpDownOrderID.Value, info.IdOfUsedMaterials[i], info.AmountMaterials[i]);
                }

            }
            else
            {
                ButtonLoadOut.Enabled = false;
                MessageBox.Show("Указан некорректный ID заказа. Доступные для просмотра отчета заказы указаны в таблице.", "Ошибка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonLoadOut_Click(object sender, EventArgs e)
        {
            db.OpenConnection();

            int currentMatID = 0;
            int amount = 0;
            int countRedCells = 0;

            List<int> amountOnStorage = new List<int>();

            try
            {
                for (int i = 0; i < StatUsingGrid.RowCount - 1; i++)
                {
                    currentMatID = Convert.ToInt32(StatUsingGrid["Used_Materials", i].Value);
                    amount = Convert.ToInt32(StatUsingGrid["Amount", i].Value);

                    command = new MySqlCommand("SELECT Cont_amount FROM contains WHERE Mat_ID = @matid");
                    command.Parameters.Add("@matid", MySqlDbType.Int32).Value = currentMatID;
                    command.Connection = db.GetConnection();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        amountOnStorage.Add(Convert.ToInt32(reader["Cont_amount"]));
                    }
                    reader.Close();

                    #region Проверка наличия заказанного материала на складах и списание

                    for (int j = 0; j < amountOnStorage.Count; j++)
                    {
                        if (amountOnStorage[j] >= amount)
                        {
                            command = new MySqlCommand("UPDATE contains SET Cont_amount = @newCont WHERE Mat_ID = @matid AND St_ID = @st", db.GetConnection());
                            command.Parameters.Add("@newCont", MySqlDbType.Int32).Value = amountOnStorage[j] - amount;
                            command.Parameters.Add("@st", MySqlDbType.Int32).Value = j + 1;
                            command.Parameters.Add("@matid", MySqlDbType.Int32).Value = currentMatID;
                            command.Connection = db.GetConnection();
                            command.ExecuteNonQuery();
                            amount = 0;

                        }
                        else
                        {
                            command = new MySqlCommand("UPDATE contains SET Cont_amount = @newCont WHERE Mat_ID = @matid AND St_ID = @st", db.GetConnection());
                            command.Parameters.Add("@newCont", MySqlDbType.Int32).Value = 0;
                            command.Parameters.Add("@st", MySqlDbType.Int32).Value = j + 1;
                            command.Parameters.Add("@matid", MySqlDbType.Int32).Value = currentMatID;
                            amount -= amountOnStorage[j];
                            command.Connection = db.GetConnection();
                            command.ExecuteNonQuery();
                        }
                        if (amount == 0)
                        {
                            StatUsingGrid["Amount", i].Style.BackColor = Color.GreenYellow;
                            break;
                        }
                        if (amount != 0 && j == amountOnStorage.Count - 1)
                        {
                            StatUsingGrid["Amount", i].Style.BackColor = Color.Red;
                            countRedCells++;
                        }

                    }
                    amountOnStorage.Clear();
                    #endregion

                }
                if (countRedCells == 0)
                {
                    int haveAmountMat = 0;
                    command = new MySqlCommand("SELECT Cont_amount FROM contains WHERE Mat_ID = @matid AND St_ID = 1");
                    command.Parameters.Add("@matid", MySqlDbType.Int32).Value = StatUsingGrid["Used_Materials", Convert.ToInt32(info.AmountMaterials.Last())].Value;
                    command.Connection = db.GetConnection();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        haveAmountMat = Convert.ToInt32(reader["Cont_amount"]);
                    }
                    reader.Close();

                    amount = Convert.ToInt32(StatUsingGrid["Amount", Convert.ToInt32(info.AmountMaterials.Last())].Value);
                    command = new MySqlCommand("UPDATE contains SET Cont_amount = @newCont WHERE Mat_ID = @matid AND St_ID = @st", db.GetConnection());
                    command.Parameters.Add("@newCont", MySqlDbType.Int32).Value = haveAmountMat + amount;
                    command.Parameters.Add("@st", MySqlDbType.Int32).Value = 1;
                    command.Parameters.Add("@matid", MySqlDbType.Int32).Value = StatUsingGrid["Used_Materials", Convert.ToInt32(info.AmountMaterials.Last())].Value;
                    command.Connection = db.GetConnection();
                    command.ExecuteNonQuery();

                }
                db.CloseConnection();
            }
            catch (MySqlException ex)
            {
                ButtonLoadOut.Enabled = false;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
