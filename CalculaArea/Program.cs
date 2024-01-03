Console.Write("Antes de tudo, comece escrevendo seu primeiro nome: ");
string userName = Console.ReadLine()!;
Console.Clear();

if (string.IsNullOrEmpty(userName))
{
    Console.WriteLine("Nome inválido/vazio");
} else
{
    int CacularAreaQuadradro(int x) 
    {
        int area = (int)Math.Pow(x, 2);
        return area;
    }

    int CalcularAreaTriangulo(int b, int h)
    {
        int area = (b * h) / 2;
        return area;
    }

    double CalcularAreaCirculo(double r)
    {
        double area = (double)(Math.PI * Math.Pow(r, 2));
        return area;
    }

    void ExibirBoasVindas(string mensagem)
    {
        Console.WriteLine("***************************************");
        Console.WriteLine($"Seja bem vindo, {mensagem}");
        Console.WriteLine("***************************************\n");
    }

    void ExibirMenu()
    {
        Console.WriteLine("Digite 1 para calcular a área de um quadrado.");
        Console.WriteLine("Digite 2 para calcular a área de um triângulo.");
        Console.WriteLine("Digite 3 para calcular a área de um círuclo.");
        Console.WriteLine("Digite 0 para sair.");
    }

    void ExecutarPrograma()
    {
        bool sair = false;

        while (!sair)
        {
            ExibirBoasVindas(userName);
            ExibirMenu();
            Console.Write("----> ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 0:
                    Console.WriteLine("\nAté uma próxima vez!!!");
                    sair = true;
                    break;
                case 1:
                    Console.WriteLine("\nInforme o valor de comprimento: ");
                    Console.Write("----> ");
                    int numQua = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"\nA área do quadrado é: {CacularAreaQuadradro(numQua)}\n");
                    break;
                case 2:
                    Console.WriteLine("\nInforme o valor da base: ");
                    Console.Write("----> ");
                    int numBase = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nInforme o valor da altura: ");
                    Console.Write("----> ");
                    int numAlt = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"\nA área do triângulo é: {CalcularAreaTriangulo(numBase, numAlt)}\n");
                    break;
                case 3:
                    Console.WriteLine("\nInforme o valor do Raio: ");
                    Console.Write("----> ");
                    double numRaio = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"\nA área do círculo é: {CalcularAreaCirculo(numRaio)}\n");
                    break;
                default:
                    Console.WriteLine("Opção Inválida!!!");
                    break;
            }

        }
    }

    ExecutarPrograma();
}