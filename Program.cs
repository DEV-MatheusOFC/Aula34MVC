using System;
using Aula_34_MVCConsole.Controllers;

namespace Aula_34_MVCConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController a = new ProdutoController();

            a.Buscar("1300");
        }
    }
}
