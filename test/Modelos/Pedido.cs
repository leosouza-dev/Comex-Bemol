namespace test.Modelos
{
    public class Pedido
    {
        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
            Data = DateTime.Now;
            Itens = new List<ItemDePedido>();
        }

        public Cliente Cliente { get; private set; }
        public DateTime Data { get; private set; }
        public List<ItemDePedido> Itens { get; private set; }
        public double Total { get ; private set; }

        public void AdicionarItem(ItemDePedido item)
        {
            // Validações necessárias...
            Itens.Add(item);
            Total += item.SubTotal;
        }

        public override string ToString()
        {
            return $"Cliente: {Cliente.Nome}, Data: {Data}, Total: {Total:f2}";
        }
    }
}
