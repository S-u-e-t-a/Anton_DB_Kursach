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
                command = new MySqlCommand("SELECT * FROM custom INNER JOIN material ON custom.Mat_ID = material.Mat_ID WHERE Cus_status = \"Производится\" ");
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
            var info = new UsingInfo();

            int amount = 0;
           // int enabledTimeOfwork = 0;

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
                                command = new MySqlCommand("SELECT Mat_ID FROM comp_spec WHERE Spec_ID = @id");
                                command.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(info.IdOfUsedSpecificatons[k]);
                                command.Connection = db.GetConnection();
                                reader = command.ExecuteReader();
                                while (reader.Read())
                                {
                                    if (!info.IdOfUsedMaterials.Contains(reader["Mat_ID"].ToString()))
                                    {
                                        info.IdOfUsedMaterials.Add(reader["Mat_ID"].ToString());
                                    }
                                }
                                reader.Close();
                                n++;
                            }
                        }
                    }
                    break;
                }
                for (int i = 0; i < info.IdOfUsedMap.Count; i++)
                {
                    command = new MySqlCommand("SELECT Oper_ID, Oper_time, Fact_ID FROM comp_map WHERE Map_ID = @id");
                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(info.IdOfUsedMap[i]);
                    command.Connection = db.GetConnection();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        info.IdOfUsedOper.Add(reader["Oper_ID"].ToString());
                        info.IdOfUsedTime.Add((Convert.ToInt32(reader["Oper_time"]) * amount).ToString());
                        info.IdOfUsedFactory.Add(reader["Fact_ID"].ToString());
                        
                    }
                    reader.Close();
                }
                info.IdOfUsedFactory.Reverse(); info.IdOfUsedTime.Reverse(); info.IdOfUsedOper.Reverse();
                info.IdOfUsedMap.Reverse(); info.IdOfUsedMaterials.Reverse(); info.IdOfUsedSpecificatons.Reverse();

                if (comboBoxType.Text == "Спецификации и тех.карты")
                {
                    StatUsingGrid.Columns.Clear();

                    StatUsingGrid.Columns.Add("Step", "Номер шага");
                    StatUsingGrid.Columns.Add("Cus_ID", "ID заказа"); StatUsingGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    StatUsingGrid.Columns.Add("Used_Spec", "Использованные спецификации");
                    StatUsingGrid.Columns.Add("Used_Map", "Использованные тех.карты");

                    for (int i = 0; i < info.IdOfUsedSpecificatons.Count; i++)
                    {
                        StatUsingGrid.Rows.Add(i + 1, numericUpDownOrderID.Value, info.IdOfUsedSpecificatons[i], info.IdOfUsedMap[i]);
                    }
                }
                else
                {
                    StatUsingGrid.Columns.Clear();

                    StatUsingGrid.Columns.Add("Step", "Номер шага");
                    StatUsingGrid.Columns.Add("Cus_ID", "ID заказа"); StatUsingGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    StatUsingGrid.Columns.Add("Used_Spec", "Использованные операции");
                    StatUsingGrid.Columns.Add("Used_Map", "Затраченное время (план)");
                    StatUsingGrid.Columns.Add("Used_Map", "Использованные РЦ (план)");

                    for (int i = 0; i < info.IdOfUsedOper.Count; i++)
                    {
                        StatUsingGrid.Rows.Add(i + 1, numericUpDownOrderID.Value, info.IdOfUsedOper[i], info.IdOfUsedTime[i], info.IdOfUsedFactory[i]);
                    }
                }

            }
            else
            {
                MessageBox.Show("Указан некорректный ID заказа. Доступные для просмотра отчета заказы указаны в таблице.", "Ошибка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            db.CloseConnection();
        }

    }
}
