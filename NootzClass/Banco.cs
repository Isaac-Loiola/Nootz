using MySql.Data.MySqlClient;

namespace NootzClass
{
    public class Banco
    {
        public static MySqlCommand Abrir()
        {
            MySqlCommand cmd = new();
            string strConn = @"server=192.168.18.157;database=nootz;user=isaac;password=Az.103098";
            MySqlConnection cn = new(strConn);
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return cmd;
        }
    }
}
