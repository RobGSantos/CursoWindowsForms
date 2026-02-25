
using System.Data.SqlClient;
using System.Data;
using System;

namespace CursoWindowsFormsBiblioteca.DataBases
{
    public class LocalDBClass
    {
        public string stringConn;
        public SqlConnection connDB;

        public LocalDBClass()
        {
            try
            {
                stringConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataBases\Fichario.mdf;Integrated Security=True";
                
                connDB = new SqlConnection(stringConn);
                connDB.Open();

            }
            catch (Exception ex)
            {
                throw new Exception("Conexão falhou" + ex.Message + ex.StackTrace);
            }
        }

        public DataTable SQLQuery(string sql)
        {
            var dt = new DataTable();
            try
            {
                var myCommand = new SqlCommand(sql)
                {
                    CommandTimeout = 0
                };
                myCommand.Connection = connDB;
                SqlDataReader myReader = myCommand.ExecuteReader();
                dt.Load(myReader);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public string SQLCommand(string sql)
        {
            try
            {
                var myCommand = new SqlCommand(sql)
                {
                    CommandTimeout = 0
                };
                var myReader = myCommand.ExecuteReader();
                return string.Empty;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Close()
        {
            connDB.Close();
        }
    }
}
