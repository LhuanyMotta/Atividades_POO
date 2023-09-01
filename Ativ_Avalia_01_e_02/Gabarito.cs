public class Gabarito
{
    List<char> gab = new List<char>();

    public Gabarito(List<char> gab)
    {
        this.gab = gab;
    }

    public char RespostaQuestao(int nQuestao)
    {
        return this.gab[nQuestao];
    }
    public List<char> getGab()
    {
        return this.gab;
    }
}