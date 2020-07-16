using System.Collections.Generic;
using Aula_34_MVCConsole.Models;

namespace Aula_34_MVCConsole.Views
{
    public class ProdutoView
    {
        public void MostrarNoConsole(List<Produto> lista){
            foreach (Produto item in lista){
                System.Console.WriteLine($"R${item.Preco} - {item.Nome}");
            }
        }
    }
}