using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Modelos;

namespace test.Menus
{
    public class MenuOrdernarProdutosPorPreco : Menu
    {
        public void Executar(List<Produto> listaDeProdutos)
        {
            var produtosOrdenados = listaDeProdutos.OrderBy(produto => produto.PrecoUnitario).ToList();

            ExibirTituloDaOpcao("Produtos Ordenados Pelo Preço");
            foreach (var produto in produtosOrdenados)
            {
                Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.PrecoUnitario:F2}");
            }

            FinalizarOperacao();
        }
    }
}
