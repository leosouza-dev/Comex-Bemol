namespace test.Menus
{
    public class Menu
    {
        public void ExibirTituloDaOpcao(string titulo)
        {
            Console.Clear();
            int quantidadeDeLetras = titulo.Length;
            string astericos = string.Empty.PadLeft(quantidadeDeLetras, '*');
            Console.WriteLine(astericos);
            Console.WriteLine(titulo);
            Console.WriteLine(astericos);
        }

        public void FinalizarOperacao()
        {
            Console.WriteLine("\n Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
