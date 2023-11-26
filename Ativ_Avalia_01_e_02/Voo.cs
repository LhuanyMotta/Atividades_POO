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