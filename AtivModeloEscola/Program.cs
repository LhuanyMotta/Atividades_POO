// Classe principal de execução
using AtivModeloEscola.EquipeEscola;

// Classe principal (Program)
public class Program
{
    public static void Main(string[] args)
    {
        // Interação com o usuário
        Console.WriteLine("Chegou a hora de modelarmos uma escola.\nNeste sistem básico teremos diferentes tipos de funcionários, como professores e funcionários administrativos.\nPreencha os campos a seguir.");

        // Exibe a mensagem para continuar ou sair
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Deseja continuar? (S/N)");
        Console.WriteLine("--------------------------------------------------");
        string resposta = Console.ReadLine();

        // Corrige se a resposta é minúscula
        resposta = resposta.ToUpper();

        // Verifica a resposta do usuário
        switch (resposta)
        {
            case "S":
                // Continua a execução
                // Criando um array de objetos do tipo Funcionario
                Funcionario[] funcionarios = new Funcionario[2];

                // Lendo os dados do usuário
                string nomeProfessor, disciplinaProfessor;
                int idadeProfessor, salarioProfessor;
                string nomeAdministrativo, setorAdministrativo;
                int idadeAdministrativo, salarioAdministrativo;

                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Informe os dados do professor(a):");
                Console.WriteLine("Nome: ");
                nomeProfessor = Console.ReadLine();
                Console.WriteLine("Idade: ");
                idadeProfessor = int.Parse(Console.ReadLine());
                Console.WriteLine("Salário: ");
                salarioProfessor = (int)float.Parse(Console.ReadLine());
                Console.WriteLine("Disciplina: ");
                disciplinaProfessor = Console.ReadLine();
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("Informe os dados do funcionário(a) administrativo:");
                Console.WriteLine("Nome: ");
                nomeAdministrativo = Console.ReadLine();
                Console.WriteLine("Idade: ");
                idadeAdministrativo = int.Parse(Console.ReadLine());
                Console.WriteLine("Salário: ");
                salarioAdministrativo = (int)float.Parse(Console.ReadLine());
                Console.WriteLine("Setor: ");
                setorAdministrativo = Console.ReadLine();
                Console.WriteLine("--------------------------------------------------");

                // Instanciando os objetos
                funcionarios[0] = new Professor { Nome = nomeProfessor, Idade = idadeProfessor, Salario = salarioProfessor, Disciplina = disciplinaProfessor };
                funcionarios[1] = new Administrativo { Nome = nomeAdministrativo, Idade = idadeAdministrativo, Salario = salarioAdministrativo, Setor = setorAdministrativo };

                // Chamando o método CalcularSalario() para cada objeto
                for (int i = 0; i < funcionarios.Length; i++)
                {
                    float salario = funcionarios[i].CalcularSalario();
                    Console.WriteLine("Nome: {0}, Idade: {1}, Salário: {2}", funcionarios[i].Nome, funcionarios[i].Idade, salario);
                    Console.WriteLine("--------------------------------------------------");
                }
                break;
            case "N":
                // Saindo da depuração
                return;
            default:
                // Mensagem de erro
                Console.WriteLine("Resposta inválida.");
                break;
        }
    }
}