public class Trapaceiro : Individuo
{
    public override bool Interagir() => false;
    public override Individuo Clone()
    {
        this.Moedas -= 10;
        return new Trapaceiro();
    }
}