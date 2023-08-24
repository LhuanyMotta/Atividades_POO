class Program
{
    static void Main(string[] args)
    {
        List<Conta> contas = new List<Conta>();

        while (true)
        {
            Console.WriteLine("Cadastro de Conta");
            Console.Write("Nome do Titular: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Número da Agência: ");
            string numeroAgencia = Console.ReadLine();

            Console.Write("Número da Conta: ");
            string numeroConta = Console.ReadLine();

            Console.Write("Saldo Inicial: ");
            double saldoInicial = double.Parse(Console.ReadLine());

            Conta conta = new Conta(nomeTitular, numeroAgencia, numeroConta, saldoInicial);
            contas.Add(conta);

            Console.WriteLine("Conta cadastrada com sucesso!");

            Console.Write("Deseja cadastrar outra conta? (S/N): ");
            string resposta = Console.ReadLine();
            if (resposta.ToLower() != "s")
                break;
        }

        Console.WriteLine("\nSaldo das Contas:");
        foreach (Conta conta in contas)
        {
            Console.WriteLine($"Titular: {conta.NomeTitular} | Saldo: R${conta.ObterSaldo():F2}");
        }
    }
}