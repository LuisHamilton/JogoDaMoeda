public class Tolerante : Individuo
{
    public override bool Interagir()
    {
        if (this.Trapaceado >=3)
        {
            if (this.Trapaceou == 3)
            {
                this.Trapaceou = 0;
                this.Trapaceado = 0;
            }
            this.Trapaceou++;
            return false;
        }

        this.Moedas--;
        return true;
    }

    public override Individuo Clone()
    {
        this.Moedas -= 10;
        return new Tolerante();
    }
}