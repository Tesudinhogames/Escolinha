using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    public static class Conexao
    {
        public static string server = "127.0.0.1";
        public static string user = "root";
        public static string banco = "escolaDavi";
        public static string porta = "3306";

        public static string caminho = $"server={server}; port={porta}; Uid={user}; database={banco}";
    }

    public class Aluno
    {
        public string Nome { get; set; } 
        public string Media { get; set; }
        public string Frequencia { get; set; }
        public string Situacao { get; set; }
    }
}
