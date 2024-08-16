using test.Modelos;

namespace test.Menus
{
    public class MenuCriarPedido : Menu
    {
        public void Executar(List<Produto> listaDeProdutos, List<Pedido> listaDePedidos) 
        {
            ExibirTituloDaOpcao("Criar um novo Pedido");

            Console.Write("Digite o nome do Cliente: ");
            string nomeCliente = Console.ReadLine();
            var cliente = new Cliente();
            cliente.Nome = nomeCliente;

            var pedido = new Pedido(cliente);

            while (true) 
            {
                Console.Clear();
                Console.WriteLine("\n Produtos Disponíveis:");
                for (int i = 0; i < listaDeProdutos.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {listaDeProdutos[i].Nome}");
                }

                Console.WriteLine("Digite o número do produto que deseja adicionar (ou 0 para finalizar): ");
                int numeroProduto = int.Parse(Console.ReadLine());

                if (numeroProduto == 0) 
                    break;
                
                var produtoEscolhido = listaDeProdutos[numeroProduto - 0];

                Console.Write("Digite a Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                var itemDePedido = new ItemDePedido(produtoEscolhido, quantidade, produtoEscolhido.PrecoUnitario);

                pedido.AdicionarItem(itemDePedido);

                Console.WriteLine($"Item Adicionado com Sucesso: {itemDePedido}\n");
                Console.WriteLine("Digite Qualquer tecla para continuar...");
                Console.ReadKey();
            }

            listaDePedidos.Add(pedido);
            Console.WriteLine($"Pedido criado com Sucesso! \n {pedido}");

            FinalizarOperacao();
        }
    }
}
