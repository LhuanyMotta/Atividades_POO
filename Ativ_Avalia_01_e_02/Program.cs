public class Program
{
    static void Main(string[] args)
    {
        while (true) // Verifica se é verdadeiro
        {
            Console.WriteLine("Escolha uma atividade:");
            Console.WriteLine("1 - Atividade 01");
            Console.WriteLine("2 - Atividade 02");
            Console.WriteLine("0 - Sair");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    // Atividade01();
                    break;
                case 2:
                    Atividade02();
                    break;
                case 0:
                    return;
                default: // Caso o usuário digite errado
                    Console.WriteLine("Escolha inválida. Digite novamente.");
                    break;
            }
        }
    }
    private static void Atividade01()
    {
        public class Voo
    {
        private DateTime dataHora;
        private bool[] cadeiras = new bool[10];
        private int nVoo;
        private List<char> nCadeira;

        public Voo(DateTime dataHora, int nVoo)
        {
            this.dataHora = dataHora;
            this.nVoo = nVoo;
        }

        public Voo(List<char> nCadeira)
        {
            this.nCadeira = nCadeira;
        }

        public int ProximoLivre()
        {
            for (int i = 0; i < cadeiras.Length; i++)
            {
                if (this.cadeiras[i] == false)
                {
                    return i + 1;
                    break;
                }
            }
            return -1;
        }

        public bool Verificar(int nCadeira)
        {
            if (this.cadeiras[nCadeira - 1] == false)
            {
                // retorna true se estiver livre
                return true;

            }

            else
            {
                return false;
            }
        }

        public bool Ocupar(int nCadeira)
        {
            if (this.cadeiras[nCadeira - 1] == false)
            {
                Console.WriteLine("Reserva realizada com sucesso!");
                this.cadeiras[nCadeira - 1] = true;
                return true;
            }
            else
            {
                Console.WriteLine("Não disponível!");
                return false;
            }
        }

        public int Vagas()
        {
            int contLivre = 0;
            for (int i = 0; i < cadeiras.Length; i++)
            {
                if (this.cadeiras[i] == false)
                {
                    contLivre++;
                    break;
                }
            }
            return contLivre;
        }

        public DateTime getDataHora()
        {
            return this.dataHora;
        }

        public int getNvoo()
        {
            return this.nVoo;
        }

    }
}

    private static void Atividade02()
    {
        List<char> gabaCerto = new List<char> { 'A', 'E', 'B', 'C', 'D'};


        Gabarito gab = new Gabarito(gabaCerto);

        while (true)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Informe o nome do aluno(a):");
            string nome = Console.ReadLine();
            Prova v = new Prova(gab);

            Console.WriteLine("===================================");
            Console.WriteLine($"{nome}\nInforme o gabarito:");

            for (int i = 0; i < gabaCerto.Count; i++)
            {
                char c = Convert.ToChar(Console.ReadLine());
                v.RespostaAluno(char.ToUpper(c));
            }

            Console.WriteLine("=================================================");
            Console.WriteLine($"{nome} ACERTOU: {v.Acertos()} QUESTÕES DA PROVA.");
            Console.WriteLine($"SUA NOTA É: {v.Nota()}");
            Console.WriteLine("=================================================");
            Console.WriteLine("QUER VERIFICAR OUTRO ALUNO(A)?\n1 - SIM, 2 - NÃO");
            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 2)
            {
                break;
            }
            Console.Clear();
        }
    }
}