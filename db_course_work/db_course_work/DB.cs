using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_course_work
{
    class DB
    {
        readonly MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=password;database=course_work"); // "User Id=root;Host=localhost;Character Set=utf8"
    
        public void OpenConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
                MessageBox.Show("Done");
            }
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }

    }

}
