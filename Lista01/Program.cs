public class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Escolha uma atividade:");
            Console.WriteLine("1 - Funcionário com Maior Salário");
            Console.WriteLine("2 - Área de um Triângulo");
            Console.WriteLine("3 - Área de um Círculo");
            Console.WriteLine("0 - Sair");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    AtividadeFuncionario();
                    break;
                case 2:
                    AtividadeTriangulo();
                    break;
                case 3:
                    AtividadeCirculo();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Escolha inválida. Digite novamente.");
                    break;
            }
        }
    }

    static void AtividadeFuncionario()
    {
        Funcionario funcionario1 = new Funcionario();
        Console.Write("Digite a matrícula do primeiro funcionário: ");
        funcionario1.Matricula = int.Parse(Console.ReadLine());
        Console.Write("Digite o nome do primeiro funcionário: ");
        funcionario1.Nome = Console.ReadLine();
        Console.Write("Digite o CPF do primeiro funcionário: ");
        funcionario1.CPF = Console.ReadLine();
        Console.Write("Digite o salário do primeiro funcionário: ");
        funcionario1.Salario = double.Parse(Console.ReadLine());

        Funcionario funcionario2 = new Funcionario();
        Console.Write("\nDigite a matrícula do segundo funcionário: ");
        funcionario2.Matricula = int.Parse(Console.ReadLine());
        Console.Write("Digite o nome do segundo funcionário: ");
        funcionario2.Nome = Console.ReadLine();
        Console.Write("Digite o CPF do segundo funcionário: ");
        funcionario2.CPF = Console.ReadLine();
        Console.Write("Digite o salário do segundo funcionário: ");
        funcionario2.Salario = double.Parse(Console.ReadLine());

        if (funcionario1.Salario > funcionario2.Salario)
        {
            Console.WriteLine($"\nFuncionário com maior salário: {funcionario1.Nome}");
        }
        else if (funcionario2.Salario > funcionario1.Salario)
        {
            Console.WriteLine($"\nFuncionário com maior salário: {funcionario2.Nome}");
        }
        else
        {
            Console.WriteLine("\nAmbos os funcionários possuem salários iguais.");
        }
    }

    static void AtividadeTriangulo()
    {
        Triangulo triangulo = new Triangulo();

        Console.Write("Digite o valor do lado A: ");
        triangulo.LadoA = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor do lado B: ");
        triangulo.LadoB = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor do lado C: ");
        triangulo.LadoC = double.Parse(Console.ReadLine());

        double area = triangulo.CalcularArea();
        Console.WriteLine($"A área do triângulo é: {area:F2}");
    }

    static void AtividadeCirculo()
    {
        Circulo circulo = new Circulo();

        Console.Write("Digite o valor do raio do círculo: ");
        circulo.Raio = double.Parse(Console.ReadLine());

        double area = circulo.CalcularArea();
        Console.WriteLine($"A área do círculo é: {area:F2}");
    }
}