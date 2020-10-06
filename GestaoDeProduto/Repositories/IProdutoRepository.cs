using GestaoDeProduto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProduto.Repositories
{
    public interface IProdutoRepository
    {
        public IList<Produto> ListaTodosProdutos();
        public Produto BuscaProdutoPorId(int id);
        public void InsereProduto(Produto produto);


    }
}
