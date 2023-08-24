public class Triangulo
{
    public double LadoA { get; set; }
    public double LadoB { get; set; }
    public double LadoC { get; set; }

    public double CalcularArea()
    {
        double p = (LadoA + LadoB + LadoC) / 2;
        return Math.Sqrt(p * (p - LadoA) * (p - LadoB) * (p - LadoC));
    }
}