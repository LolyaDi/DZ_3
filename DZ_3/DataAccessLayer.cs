using System.Data.Common;
using System.Data.SqlClient;

namespace DZ_3
{
    public class DataAccessLayer
    {
        public DbConnectionStringBuilder _connectionStringBuilder;
        
        public string SetConnection(string user, string password)
        {
            string message = "";

            try
            {
                _connectionStringBuilder = new DbConnectionStringBuilder
                {
                    ["Server"] = "(LocalDB)\\MSSQLLocalDB",
                    ["Database"] = "MyDB",
                    ["User Id"] = user,
                    ["Password"] = password
                };

                using (var connection = new SqlConnection())
                {
                    connection.ConnectionString = _connectionStringBuilder.ConnectionString;
                    connection.Open();
                }

                message = " Подключение установлено!";
            }
            catch (DbException)
            {
                message = " Ошибка подключения!\nПроверьте корректность введенных данных";
            }
            catch
            {
                message = " Ошибка подключения!";
            }

            return message;
        }
    }
}
