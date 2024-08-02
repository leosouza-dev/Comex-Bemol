using test.Modelos;

namespace test.Menus
{
    public class MenuListarProdutos : Menu
    {
        public void Executar(List<Produto> listaDeProdutos)
        {
            ExibirTituloDaOpcao("Exibindo todos os produtos Registrados");

            foreach (var produto in listaDeProdutos)
            {
                Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.PrecoUnitario:f2}");
            }

            FinalizarOperacao();
        }
    }
}
