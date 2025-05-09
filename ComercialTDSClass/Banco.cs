using MySql.Data.MySqlClient;


namespace ComercialTDSClass
{    
    public static class Banco
    {
        public static string StrConn { get; set; }
        
        public static MySqlCommand Abrir(string strconn="")
        {
            MySqlCommand cmd = new();
            StrConn = strconn;
            if (StrConn == string.Empty)
            StrConn = $@"server=10.91.47.35;database=comercialtdsdb01;user=root;password=root";
            MySqlConnection cn = new(StrConn);
            //cn.ConnectionString = StrConn;
            try
            {
                cn.Open();// ao passar por aqui terá uma conexão aberta
                cmd.Connection = cn;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return cmd;
        }
    }
}
