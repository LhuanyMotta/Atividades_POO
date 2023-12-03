// Classe Biblioteca

public class Biblioteca
{
    // Atributos públicos
    public List<Livro> livrosDisponiveis = new List<Livro>();
    public List<Revista> revistasDisponiveis = new List<Revista>();
    public List<Usuario> usuariosCadastrados = new List<Usuario>();
    public List<Emprestimo> emprestimos = new List<Emprestimo>();

    // Propriedades públicas com métodos de acesso
    public List<Livro> LivrosDisponiveis
    {
        get { return livrosDisponiveis; }
    }

    public List<Revista> RevistasDisponiveis
    {
        get { return revistasDisponiveis; }
    }

    public List<Usuario> UsuariosCadastrados
    {
        get { return usuariosCadastrados; }
    }

    public List<Emprestimo> Emprestimos
    {
        get { return emprestimos; }
    }

    // Métodos públicos
    public void AdicionarLivro(Livro livro)
    {
        livrosDisponiveis.Add(livro);
        Console.WriteLine($"Livro '{livro.Titulo}' adicionado à biblioteca.");
    }

    public void AdicionarRevista(Revista revista)
    {
        revistasDisponiveis.Add(revista);
        Console.WriteLine($"Revista '{revista.Titulo}' adicionada à biblioteca.");
    }

    public void CadastrarUsuario(Usuario usuario)
    {
        usuariosCadastrados.Add(usuario);
        Console.WriteLine($"Usuário '{usuario.Nome}' cadastrado na biblioteca.");
    }

    public void RealizarEmprestimo(Usuario usuario, Livro livro)
    {
        Emprestimo emprestimo = new Emprestimo
        {
            Usuario = usuario,
            LivroOuRevista = livro,
            DataEmprestimo = DateTime.Now,
            DataDevolucaoPrevista = DateTime.Now.AddDays(14)
        };

        emprestimos.Add(emprestimo);
        Console.WriteLine($"Empréstimo realizado para {usuario.Nome}: {livro.Titulo}");
    }

    // Método para realizar a devolução
    public void RealizarDevolucao(Usuario usuario, Livro livroOuRevista)
    {
        // Encontrar o empréstimo correspondente
        Emprestimo emprestimo = emprestimos.Find(e => e.Usuario == usuario && e.LivroOuRevista == livroOuRevista);

        if (emprestimo != null)
        {
            // Remover o empréstimo da lista
            emprestimos.Remove(emprestimo);

            // Registrar a devolução
            emprestimo.RegistrarDevolucao();

            Console.WriteLine($"Devolução realizada por {usuario.Nome}: {livroOuRevista.Titulo}");
        }
        else
        {
            Console.WriteLine("Empréstimo não encontrado para o usuário e item específicos.");
        }
    }
}