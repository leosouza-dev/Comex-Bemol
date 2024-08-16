using test.Menus;
using test.Modelos;

string mensagemDeBoasVindas = "Boas Vindas ao COMEX!!!!";
List<Produto> listaDeProdutos = new List<Produto>();
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
        case -1:
            Console.WriteLine("Saindo do Programa...");
            break;
        default:
            Console.WriteLine("opção Inválida");
            break;
    }
}

await ExbibirOpcoesDoMenu();