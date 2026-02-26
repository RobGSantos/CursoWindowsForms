
using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CursoWindowsFormsBiblioteca.DataBases
{
    public class SQLServerClass
    {
        public string stringConn;
        public SqlConnection connDB;

        public SQLServerClass()
        {
            try
            {
                //stringConn = "Data Source = sgmgabc10837; Initial Catalog = ByteBank; User ID = sa; Password = Banco#2025#cgp;TrustServerCertificate=True";
                
                stringConn = ConfigurationManager.ConnectionStrings["ConexaoSQLServer"].ConnectionString;
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
                myCommand.Connection = connDB;
                var myReader = myCommand.ExecuteReader();
                myReader.Close();
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
