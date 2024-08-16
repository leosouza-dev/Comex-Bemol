namespace test.Modelos
{
    public class ItemDePedido
    {
        public ItemDePedido(Produto produto, int quantidade, double precoUnitario)
        {
            Produto = produto;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
            SubTotal = quantidade * precoUnitario;
        }

        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }
        public double PrecoUnitario { get; private set; }
        public double SubTotal { get; private set; }

        public override string ToString()
        {
            return $"Produto: {Produto.Nome}, " +
                $"Quantidade: {Quantidade}, " +
                $"Preço Unitario {PrecoUnitario}, " +
                $"SubTotal {SubTotal}";
        }
    }
}
