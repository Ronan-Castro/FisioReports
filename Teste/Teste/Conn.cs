using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Teste
{
    static class Conn
    {
        
        
            static private string servidor = "localhost";
            static private string bancoDados= "fisioreports";
            static private string user = "root";
            static private string senha= "dessa300";

            static public string strConn = $"server={servidor}; User Id={user}; database={bancoDados};password={senha}";
           
        
    }
}
