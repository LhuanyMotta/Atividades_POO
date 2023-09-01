/*

string nomeT = Console.ReadLine();
Titular t = new Titular();
t.nome = nomeT;
Conta c = new Conta(t, "01","001",0);

string novoNome = Console.ReadLine();

Console.WriteLine(c.titular.cpf);

*/


/*
List<Conta> contas = new List<Conta>();
Conta c2 = new Conta();
Titular t2 = new Titular();
t2.cpf = "222";
t2.nome = "Lhuany";
t2.email = "email";
c2.numeroConta = "01";
c2.titular = t2;
contas.Add(c2);
*/

List<Conta> contas = new List<Conta>();
Conta c2 = new Conta();
Titular t2 = new Titular();

Console.WriteLine("Informe o nome do titular"); t2.nome = Console.ReadLine();
Console.WriteLine("Informe o CPF do titular"); t2.cpf = Console.ReadLine();
Console.WriteLine("Informe o email do titular"); t2.email = Console.ReadLine();
Console.WriteLine("Informe o número da conta do titular"); c2.numeroConta = Console.ReadLine();
c2.titular = t2;
contas.Add(c2);

Console.WriteLine($"{t2.nome}\n{t2.cpf}");

/*
Conta c3 = new Conta();
c3.SetNomeTitular("Elias 2");
c3.numeroConta = "02";
contas.Add(c3);

int index = contas.FindIndex(x => x.numeroConta == "02");
Conta c4 = contas.ElementAt(index);
Console.WriteLine("N "+ c4.nomeTitular);
*/

/*
List <Conta> contas = new List<Conta>();
while (true)
{
    Console.WriteLine("Digite 1 para cadastrar uma conta, 2 para listar todos");
    int opcao = Convert.ToInt32(Console.ReadLine());    
    if(opcao == 1)
    {
        Console.WriteLine("Informe o titular, agência, conta e o saldo");
        string titular = Console.ReadLine();
        string agencia = Console.ReadLine();
        string conta = Console.ReadLine();
        double saldo = Convert.ToDouble(Console.ReadLine());
        Conta c = new Conta(titular,agencia,conta,saldo);
        contas.Add(c);
    }else if(opcao == 2)
    {
        foreach(Conta conta in contas)
        {
            //Console.WriteLine($"Titular {conta.nomeTitular}, saldo {conta.saldoConta}");
            Console.WriteLine(conta.ToString());
        }
    }
    else
    {
        break;
    }

}
*/