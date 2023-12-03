// Classe Revista
public class Revista : Livro
{
    // Atributo específico para o número de edição da revista
    public int numeroEdicao;

    // Propriedade pública para o número de edição com método de acesso
    public int NumeroEdicao
    {
        get { return numeroEdicao; }
        set { numeroEdicao = value; }
    }
}