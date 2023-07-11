public class Matematico : Individuo
{
    public override Individuo Clone()
    {
        this.Moedas -= 10;
        return new Matematico();
    }
    public override bool Interagir()
    {
        var interagir = Random.Shared.Next(4) > 0;
        if (interagir)
            this.Moedas--;
        return interagir;
    }
}