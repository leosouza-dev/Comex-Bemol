using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Modelos;

namespace test.Menus
{
    public class MenuOrdernarProdutosPorTitulo : Menu
    {
        public void Executar(List<Produto> listaDeProdutos)
        {
            var produtosOrdenados = listaDeProdutos.OrderBy(produto => produto.Nome).ToList();

            ExibirTituloDaOpcao("Produtos Ordenados Pelo Titulo");
            foreach (var produto in produtosOrdenados)
            {
                Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.PrecoUnitario:F2}");
            }

            FinalizarOperacao();
        }
    }
}
