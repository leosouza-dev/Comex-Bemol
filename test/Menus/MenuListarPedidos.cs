using test.Modelos;

namespace test.Menus
{
    public class MenuListarPedidos : Menu
    {
        public void Executar(List<Pedido> pedidos)
        {
            ExibirTituloDaOpcao("Exibindo os Pedidos registrados na Aplicação");

            var pedidosOrdenados = pedidos.OrderBy(p => p.Cliente.Nome).ToList();

            foreach (var pedido in pedidosOrdenados)
            {
                Console.WriteLine(pedido);
                //Console.WriteLine($"Cliente: {pedido.Cliente.Nome}, Total {pedido.Total:F2}");
            }

            FinalizarOperacao();
        }
    }
}
