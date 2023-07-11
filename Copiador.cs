public class Copiador : Individuo
{
    private bool proxInteracao = true;

    public override void RecebeInteracao(bool interacao)
    {
        if(!interacao)
            this.Trapaceado++;

        this.proxInteracao = interacao;
    }

    public override bool Interagir()
    {
        if(!proxInteracao)
            return false;
        
        this.Moedas--;
        return true;
    }

    public override Individuo Clone()
    {
        this.Moedas -= 10;
        return new Copiador();
    }
}