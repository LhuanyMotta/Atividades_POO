/* LHUANY THAINARA MOTTA EUZÉBIO
 * 3º PERÍODO - ADS
 * 
 *  --- DESAFIOS ENFRENTADOS ---
 * 
 * Ao meu ponto de vista, para quem está começando na programação, os conceitos estudados podem ser complicados para alguns alunos.
 * O conceito de herança e polimorfismo, foi desafiador. Pois, entender a criar uma classe derivada (subclasse) da forma correta é confuso no início.
 * Sobre encapsulamento, os mais comuns e que já utilizava eram o public e private, não tive tanta dificuldade por já utilizar desde os primeiros períodos.
 * Quanto a abstração, estou começando a entender suas propriedades, como implementar corretamente seus métodos.
 * O fato de pensar um pouco sobre o sistema de gerencimento de uma biblioteca exigiu um pouco de tempo, pois entender a sintaxe geral de uma biblioteca e como funciona.
 * Posso dizer que foi um tanto complicado a elbaoração da atividade, mas como um programa inicial e simples, ficou bacana.
 * Apesar das dificuldades de compreensão do conteúdo estudado, tentei implementar e manipular o sistema para desenvolver operações simples e comuns que uma biblioteca exige.
 * 
 */

// Programa principal
public class Program
{
    public static void Main(string[] args)
    {
        // Criando uma instância da classe Biblioteca
        Biblioteca biblioteca = new Biblioteca();

        // Loop principal do menu
        while (true)
        {
            Console.WriteLine("===== Menu Principal =====");
            Console.WriteLine("1. Adicionar Livro");
            Console.WriteLine("2. Adicionar Revista");
            Console.WriteLine("3. Cadastrar Usuário");
            Console.WriteLine("4. Realizar Empréstimo");
            Console.WriteLine("5. Realizar Devolução");
            Console.WriteLine("6. Sair");
            Console.WriteLine("==========================");

            Console.Write("Escolha uma opção: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            // Switch case para lidar com as opções do menu
            switch (opcao)
            {
                case 1:
                    // Lógica para adicionar livro
                    Console.Write("Digite o título do livro: ");
                    string tituloLivro = Console.ReadLine();

                    Console.Write("Digite o autor do livro: ");
                    string autorLivro = Console.ReadLine();

                    Console.Write("Digite o ano de publicação do livro: ");
                    int anoPublicacaoLivro = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite o número de páginas do livro: ");
                    int numeroPaginasLivro = Convert.ToInt32(Console.ReadLine());

                    // Criando uma instância de Livro com os dados fornecidos
                    Livro novoLivro = new Livro
                    {
                        Titulo = tituloLivro,
                        Autor = autorLivro,
                        AnoPublicacao = anoPublicacaoLivro,
                        NumeroPaginas = numeroPaginasLivro
                    };

                    // Adicionando o livro à biblioteca
                    biblioteca.AdicionarLivro(novoLivro);
                    break;

                case 2:
                    // Lógica para adicionar revista
                    Console.Write("Digite o título da revista: ");
                    string tituloRevista = Console.ReadLine();

                    Console.Write("Digite o autor da revista: ");
                    string autorRevista = Console.ReadLine();

                    Console.Write("Digite o ano de publicação da revista: ");
                    int anoPublicacaoRevista = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite o número de páginas da revista: ");
                    int numeroPaginasRevista = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite o número da edição da revista: ");
                    int numeroEdicaoRevista = Convert.ToInt32(Console.ReadLine());

                    // Criando uma instância de Revista com os dados fornecidos
                    Revista novaRevista = new Revista
                    {
                        Titulo = tituloRevista,
                        Autor = autorRevista,
                        AnoPublicacao = anoPublicacaoRevista,
                        NumeroPaginas = numeroPaginasRevista,
                        NumeroEdicao = numeroEdicaoRevista
                    };

                    // Adicionando a revista à biblioteca
                    biblioteca.AdicionarRevista(novaRevista);
                    break;

                case 3:
                    // Lógica para cadastrar usuário
                    Console.Write("Digite o nome do usuário: ");
                    string nomeUsuario = Console.ReadLine();

                    Console.Write("Digite a idade do usuário: ");
                    int idadeUsuario = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite o identificador único do usuário: ");
                    int identificadorUsuario = Convert.ToInt32(Console.ReadLine());

                    // Criando uma instância de Usuario com os dados fornecidos
                    Usuario novoUsuario = new Usuario
                    {
                        Nome = nomeUsuario,
                        Idade = idadeUsuario,
                        IdentificadorUnico = identificadorUsuario
                    };

                    // Cadastrando o usuário na biblioteca
                    biblioteca.CadastrarUsuario(novoUsuario);
                    break;

                case 4:
                    // Lógica para realizar empréstimo
                    Console.Write("Digite o nome do usuário: ");
                    string nomeUsuarioEmprestimo = Console.ReadLine();

                    // Procurando o usuário na lista
                    Usuario usuarioEmprestimo = biblioteca.UsuariosCadastrados.Find(u => u.Nome == nomeUsuarioEmprestimo);

                    if (usuarioEmprestimo != null)
                    {
                        // Exibindo os itens disponíveis para empréstimo
                        Console.WriteLine("Itens Disponíveis:");
                        Console.WriteLine("1. Livros");
                        Console.WriteLine("2. Revistas");

                        Console.Write("Escolha o tipo de item a ser emprestado: ");
                        int tipoItem = Convert.ToInt32(Console.ReadLine());

                        switch (tipoItem)
                        {
                            case 1:
                                // Exibindo os livros disponíveis
                                Console.WriteLine("Livros Disponíveis:");
                                foreach (var livro in biblioteca.LivrosDisponiveis)
                                {
                                    Console.WriteLine(value: $"{livro.Titulo} - {livro.Autor}");
                                }

                                Console.Write("Digite o título do livro a ser emprestado: ");
                                string tituloLivroEmprestimo = Console.ReadLine();

                                // Procurando o livro na lista
                                Livro livroEmprestimo = biblioteca.LivrosDisponiveis.Find(l => l.Titulo == tituloLivroEmprestimo);

                                if (livroEmprestimo != null)
                                {
                                    // Realizando o empréstimo
                                    biblioteca.RealizarEmprestimo(usuarioEmprestimo, livroEmprestimo);
                                }
                                else
                                {
                                    Console.WriteLine("Livro não encontrado.");
                                }
                                break;

                            case 2:
                                // Exibindo as revistas disponíveis
                                Console.WriteLine("Revistas Disponíveis:");
                                foreach (var revista in biblioteca.RevistasDisponiveis)
                                {
                                    Console.WriteLine($"{revista.Titulo} - {revista.Autor}");
                                }

                                Console.Write("Digite o título da revista a ser emprestada: ");
                                string tituloRevistaEmprestimo = Console.ReadLine();

                                // Procurando a revista na lista
                                Revista revistaEmprestimo = biblioteca.RevistasDisponiveis.Find(r => r.Titulo == tituloRevistaEmprestimo);

                                if (revistaEmprestimo != null)
                                {
                                    // Realizando o empréstimo
                                    biblioteca.RealizarEmprestimo(usuarioEmprestimo, revistaEmprestimo);
                                }
                                else
                                {
                                    Console.WriteLine("Revista não encontrada.");
                                }
                                break;

                            default:
                                Console.WriteLine("Opção inválida. Tente novamente.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Usuário não encontrado.");
                    }
                    break;

                case 5:
                    // Lógica para realizar devolução
                    Console.Write("Digite o nome do usuário: ");
                    string nomeUsuarioDevolucao = Console.ReadLine();

                    // Procurando o usuário na lista
                    Usuario usuarioDevolucao = biblioteca.UsuariosCadastrados.Find(u => u.Nome == nomeUsuarioDevolucao);

                    if (usuarioDevolucao != null)
                    {
                        // Exibindo os itens emprestados pelo usuário
                        Console.WriteLine("Itens Emprestados:");
                        foreach (var emprestimo in biblioteca.Emprestimos)
                        {
                            if (emprestimo.Usuario == usuarioDevolucao)
                            {
                                Console.WriteLine($"{emprestimo.LivroOuRevista.Titulo} - {emprestimo.DataEmprestimo}");
                            }
                        }

                        Console.Write("Digite o título do item a ser devolvido: ");
                        string tituloItemDevolucao = Console.ReadLine();

                        // Procurando o item na lista de empréstimos
                        Livro livroDevolucao = biblioteca.LivrosDisponiveis.Find(l => l.Titulo == tituloItemDevolucao);
                        Revista revistaDevolucao = biblioteca.RevistasDisponiveis.Find(r => r.Titulo == tituloItemDevolucao);

                        if (livroDevolucao != null)
                        {
                            // Realizando a devolução do livro
                            biblioteca.RealizarDevolucao(usuarioDevolucao, livroDevolucao);
                        }
                        else if (revistaDevolucao != null)
                        {
                            // Realizando a devolução da revista
                            biblioteca.RealizarDevolucao(usuarioDevolucao, revistaDevolucao);
                        }
                        else
                        {
                            Console.WriteLine("Item não encontrado nos empréstimos do usuário.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Usuário não encontrado.");
                    }
                    break;

                case 6:
                    Console.WriteLine("Saindo do programa.");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}