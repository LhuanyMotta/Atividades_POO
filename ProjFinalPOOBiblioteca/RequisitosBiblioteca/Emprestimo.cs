// Classe Empréstimo
public class Emprestimo
{
    // Atributos públicos
    public Usuario usuario;
    public Livro livroOuRevista;
    public DateTime dataEmprestimo;
    public DateTime dataDevolucaoPrevista;

    // Propriedades públicas com métodos de acesso
    public Usuario Usuario
    {
        get { return usuario; }
        set { usuario = value; }
    }

    public Livro LivroOuRevista
    {
        get { return livroOuRevista; }
        set { livroOuRevista = value; }
    }

    public DateTime DataEmprestimo
    {
        get { return dataEmprestimo; }
        set { dataEmprestimo = value; }
    }

    public DateTime DataDevolucaoPrevista
    {
        get { return dataDevolucaoPrevista; }
        set { dataDevolucaoPrevista = value; }
    }

    // Método para registrar a devolução
    public void RegistrarDevolucao()
    {
        // Lógica para registrar a devolução e calcular multa, se necessário
        Console.WriteLine($"Livro/Revista devolvido por {usuario.Nome}");
    }
}