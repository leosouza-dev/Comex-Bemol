using test.Modelos;

namespace test.Menus
{
    public class MenuCriarProduto : Menu
    {
        public void Executar(List<Produto> listaDeProdutos)
        {
            ExibirTituloDaOpcao("Registro de Produto");

            Console.Write("Digite o nome do Produto: ");
            string nomeProduto = Console.ReadLine();

            Console.Write("Digite a descrição do Produto: ");
            string descricaoProduto = Console.ReadLine();

            Console.Write("Digite o Preço do Produto: ");
            double precoProduto = double.Parse(Console.ReadLine());

            Console.Write("Digite a Quantidade do Produto: ");
            int quantidadeProduto = int.Parse(Console.ReadLine());

            var produto = new Produto(nomeProduto);
            produto.PrecoUnitario = precoProduto;
            produto.Descricao = descricaoProduto;
            produto.Quantidade = quantidadeProduto;

            listaDeProdutos.Add(produto);

            Console.WriteLine($"O Produto {produto.Nome} foi registrado com sucesso!");
            FinalizarOperacao();
        }
    }
}
