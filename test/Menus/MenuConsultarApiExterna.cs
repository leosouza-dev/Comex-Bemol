using System.Text.Json;
using test.Modelos;

namespace test.Menus
{
    public class MenuConsultarApiExterna : Menu
    {
        public async Task Executar()
        {
            using HttpClient client = new HttpClient();

            ExibirTituloDaOpcao("Exibindo Produtos");

            try
            {
                string resposta = await client.GetStringAsync("http://fakestoreapi.com/products");
                var produtos = JsonSerializer.Deserialize<List<Produto>>(resposta);
                foreach (var produto in produtos)
                {
                    Console.WriteLine($"Nome: {produto.Nome}, " +
                        $"Descrição: {produto.Descricao}, " +
                        $"Preço {produto.PrecoUnitario} \n");       
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Temos um problema: {ex.Message}");
            }
            finally 
            {
                FinalizarOperacao();
            }
        }
    }
}
