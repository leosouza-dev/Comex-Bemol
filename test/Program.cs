using test.Menus;
using test.Modelos;

string mensagemDeBoasVindas = "Boas Vindas ao COMEX!!!!";
List<Produto> listaDeProdutos = new List<Produto>
{
    new Produto("Notebook")
    {
        Descricao = "Notebook Dell Inspiron",
        PrecoUnitario = 5500.00,
        Quantidade = 10
    },
    new Produto("Smartphone")
    {
        Descricao = "Smartphone Samsung Galaxy",
        PrecoUnitario = 3500.00,
        Quantidade = 25
    },
    new Produto("Monitor")
    {
        Descricao = "Monitor LG Ultrawide",
        PrecoUnitario = 1500.00,
        Quantidade = 15
    },
    new Produto("Teclado")
    {
        Descricao = "Teclado Mecânico RGB",
        PrecoUnitario = 500.00,
        Quantidade = 50
    },
};

var listaDePedidos = new List<Pedido>();

void ExibirLogo()
{
    Console.WriteLine(@"
────────────────────────────────────────────────────────────────────────────────────────
─██████████████─██████████████─██████──────────██████─██████████████─████████──████████─
─██░░░░░░░░░░██─██░░░░░░░░░░██─██░░██████████████░░██─██░░░░░░░░░░██─██░░░░██──██░░░░██─
─██░░██████████─██░░██████░░██─██░░░░░░░░░░░░░░░░░░██─██░░██████████─████░░██──██░░████─
─██░░██─────────██░░██──██░░██─██░░██████░░██████░░██─██░░██───────────██░░░░██░░░░██───
─██░░██─────────██░░██──██░░██─██░░██──██░░██──██░░██─██░░██████████───████░░░░░░████───
─██░░██─────────██░░██──██░░██─██░░██──██░░██──██░░██─██░░░░░░░░░░██─────██░░░░░░██─────
─██░░██─────────██░░██──██░░██─██░░██──██████──██░░██─██░░██████████───████░░░░░░████───
─██░░██─────────██░░██──██░░██─██░░██──────────██░░██─██░░██───────────██░░░░██░░░░██───
─██░░██████████─██░░██████░░██─██░░██──────────██░░██─██░░██████████─████░░██──██░░████─
─██░░░░░░░░░░██─██░░░░░░░░░░██─██░░██──────────██░░██─██░░░░░░░░░░██─██░░░░██──██░░░░██─
─██████████████─██████████████─██████──────────██████─██████████████─████████──████████─
────────────────────────────────────────────────────────────────────────────────────────");
    Console.WriteLine(mensagemDeBoasVindas);
}

async Task ExbibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para Criar Produto");
    Console.WriteLine("Digite 2 para Listar Produtos");
    Console.WriteLine("Digite 3 para Consulta a API Externa");
    Console.WriteLine("Digite 4 para Ordenar Produtos Pelo Titulo");
    Console.WriteLine("Digite 5 para Ordenar Produtos Pelo Preco");
    Console.WriteLine("Digite 6 para Criar um Pedido");
    Console.WriteLine("Digite 7 para Listar os Pedidos");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine();
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            new MenuCriarProduto().Executar(listaDeProdutos);
            await ExbibirOpcoesDoMenu();
            break;
        case 2:
            new MenuListarProdutos().Executar(listaDeProdutos);
            await ExbibirOpcoesDoMenu();
            break;
        case 3:
            await new MenuConsultarApiExterna().Executar();
            await ExbibirOpcoesDoMenu();
            break;
        case 4:
            new MenuOrdernarProdutosPorTitulo().Executar(listaDeProdutos);
            await ExbibirOpcoesDoMenu();
            break;
        case 5:
            new MenuOrdernarProdutosPorPreco().Executar(listaDeProdutos);
            await ExbibirOpcoesDoMenu();
            break;
        case 6:
            new MenuCriarPedido().Executar(listaDeProdutos, listaDePedidos);
            await ExbibirOpcoesDoMenu();
            break;
        case 7:
            new MenuListarPedidos().Executar(listaDePedidos);
            await ExbibirOpcoesDoMenu();
            break;
        case -1:
            Console.WriteLine("Saindo do Programa...");
            break;
        default:
            Console.WriteLine("opção Inválida");
            break;
    }
}

await ExbibirOpcoesDoMenu();