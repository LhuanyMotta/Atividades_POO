// Classe Livro
public class Livro
{
    // Atributos públicos
    public string titulo;
    public string autor;
    public int anoPublicacao;
    public int numeroPaginas;

    // Propriedades públicas com métodos de acesso (getters e setters)
    public string Titulo
    {
        get { return titulo; }
        set { titulo = value; }
    }

    public string Autor
    {
        get { return autor; }
        set { autor = value; }
    }

    public int AnoPublicacao
    {
        get { return anoPublicacao; }
        set { anoPublicacao = value; }
    }

    public int NumeroPaginas
    {
        get { return numeroPaginas; }
        set { numeroPaginas = value; }
    }
}