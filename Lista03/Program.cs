public class program
{
    public static void Main(string[] args)
    {
        // Pede para o usuário informar um CPF e lê o que foi digitado
        Console.WriteLine("Digite um CPF para verificar se é válido.");
        string cpf = Console.ReadLine();

        // Chamando um método estático
        if (Validacoes.ValidaCPF(cpf))
        {
            Console.WriteLine("CPF válido!");
        }
        else
        {
            Console.WriteLine("CPF inválido!");
        }
    }
}