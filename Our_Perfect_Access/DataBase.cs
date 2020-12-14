using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Our_Perfect_Access
{
    class DataBase //Класс для подключения к БД
                   //В конструкторе в качестве параметра указывается имя базы данных
    {
        MySqlConnection connection;

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public DataBase(string dbName)
        {
            connection = new MySqlConnection($"server=localhost;port=3306;username=root;password=root;database={dbName}");
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

    }
}
