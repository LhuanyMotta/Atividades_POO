public class Prova
{
    private Gabarito gab;
    public List<char> resp = new List<char>();

    public Prova(Gabarito gab)
    {
        this.gab = gab;
    }
    public void RespostaAluno(char respostaQuestao)
    {
        resp.Add(respostaQuestao);
    }
    public List<char> getResposta()
    {
        return this.resp;
    }
    public int Acertos()
    {
        int contAcertos = 0;
        for (int i = 0; i < this.resp.Count; i++)
        {
            if (this.resp[i] == this.gab.RespostaQuestao(i))
            {
                contAcertos++;
            }
        }
        return contAcertos;
    }

    public double Nota()
    {
        double nota = 0;

        for (int i = 0; i < this.resp.Count; i++)
        {
            if (this.resp[i] == this.gab.RespostaQuestao(i))
            {
                if (i < 10)
                {
                    nota += 2.0;
                }
                else
                {
                    nota += 1.0;
                }
            }
        }
        return nota;
    }    
}        