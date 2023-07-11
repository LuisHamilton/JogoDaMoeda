public class Colaborativo : Individuo
{
    public override bool Interagir()
    {
        this.Moedas--;
        return true;
    }

    public override Individuo Clone()
    {
        this.Moedas -= 10;
        return new Colaborativo();
    }
}