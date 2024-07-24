
using test;

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

void ExbibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para Criar Produto");
    Console.WriteLine("Digite 2 para Listar Produtos");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine();
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            CriarProduto();
            break;
        case 2:
            ListarProdutos();
            break;
        case -1:
            Console.WriteLine("Saindo do Programa...");
            break;
        default:
            Console.WriteLine("opção Inválida");
            break;
    }
}

void ListarProdutos()
{
    Console.Clear();
    //Console.WriteLine("Exibindo todos os produtos Registrados");
    ExibirTituloDaOpcao("Exibindo todos os produtos Registrados");

    foreach (var produto in listaDeProdutos)
    {
        Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.PrecoUnitario:f2}");
    }

    Console.WriteLine("\n Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExbibirOpcoesDoMenu();
}

void CriarProduto()
{
    Console.Clear();
    //Console.WriteLine("Registro de Produto");
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
    Console.WriteLine("\n Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExbibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string astericos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(astericos);
    Console.WriteLine(titulo);
    Console.WriteLine(astericos);
}

ExbibirOpcoesDoMenu();