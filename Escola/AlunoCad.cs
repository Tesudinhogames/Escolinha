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

    public class Frequencia
    {
        public int alunoid;
        public int freq1;
        public int freq2;
        public int freq3;
        public int freq4;

    }

    public class TurmaCadastro
    {
        public string Nome;
        public string? Escola;
        public int Ano_letivo;
        public string serie;
    }

    public class EscolaCadastro
    {
        public string Nome_fantasia;
        public string Razao_social;
        public string Cnpj;
        public string Endereco;
        public int Telefone;
    }
}
