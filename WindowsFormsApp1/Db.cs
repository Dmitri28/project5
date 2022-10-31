using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class Db
    {
        MySqlConnection conection=new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=people");
      public void open()
        {
            if (conection.State == System.Data.ConnectionState.Closed)
                conection.Open();
        }
        public void close()
        {
            if (conection.State == System.Data.ConnectionState.Open)
                conection.Close();
        }
        public MySqlConnection GetConnection()
        {
           return conection;
        }

        

        }
    }

