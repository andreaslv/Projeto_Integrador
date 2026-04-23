using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Tela_Inicial
{
    internal class Conexao
    {
        private static string conectar = "server=localhost; database=bdthebuurger; Uid=root; password=;";


        public static MySqlConnection Connection()
        {
            return new MySqlConnection(conectar);
        }

        public static MySqlConnection Abrir()
        {
            MySqlConnection con = new MySqlConnection(conectar);
            con.Open();
            return con;
        }
    }
}


