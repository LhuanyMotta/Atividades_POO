// Classe Usuário
public class Usuario
{
    // Atributos públicos
    public string nome;
    public int idade;
    public int identificadorUnico;

    // Propriedades públicas com métodos de acesso
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Idade
    {
        get { return idade; }
        set { idade = value; }
    }

    public int IdentificadorUnico
    {
        get { return identificadorUnico; }
        set { identificadorUnico = value; }
    }
}