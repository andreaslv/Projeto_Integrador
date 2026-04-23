using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Tela_Inicial
{
    internal class Produtos
    {
        public class Produto
        {
            public int IdProduto { get; set; }
            public string Nome { get; set; }
            public string Categoria { get; set; }
            public decimal Preco { get; set; }
            public TimeSpan TempoPreparoEstimado { get; set; }
            public bool Ativo { get; set; }
        }


        public class ProdutoDAO
        {
            private string conexao = "server=localhost; database=bdthebuuger; Uid=root; password=;";

        }

    }
}
