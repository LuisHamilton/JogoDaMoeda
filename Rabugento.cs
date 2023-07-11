public class Rabugento : Individuo
{
    public override bool Interagir()
    {
        if (this.Trapaceado >= 1)
            return false;
        
        this.Moedas--;
        return true;
    }

    public override Individuo Clone()
    {
        this.Moedas -= 10;
        return new Rabugento();
    }
}