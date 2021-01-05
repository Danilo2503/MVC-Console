using System.Collections.Generic;
using MVC_Console.Models;
using MVC_Console.Views;

namespace MVC_Console.Controllers
{
    public class ProdutoController
    {

        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void Listar()
        {
            List<Produto> lista = produto.Ler();
            produtoView.MostrarNoConsole(lista);
        }

        public void Buscar(string termo)
        {
            List<Produto> lista = produto.Ler().FindAll(x => x.Preco == float.Parse(termo));
            produtoView.MostrarNoConsole(lista);
        }       
    }
}