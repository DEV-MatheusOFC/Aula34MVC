using System.Collections.Generic;
using Aula_34_MVCConsole.Models;
using Aula_34_MVCConsole.Views;

namespace Aula_34_MVCConsole.Controllers
{
    public class ProdutoController
    {
        Produto produtoModel    = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void Listar(){
            produtoView.MostrarNoConsole(produtoModel.Ler());
        }
        public void Buscar(string _preco){
            List<Produto> busca = produtoModel.Ler().FindAll(
                x => x.Preco == float.Parse(_preco)
                );
            
            produtoView.MostrarNoConsole(busca);
        }
    }
}