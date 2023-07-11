public abstract class Individuo
{
    public int Moedas { get; set; } = 10;
    public bool Vivo { get; set; } = true;

    public int Trapaceado { get; set; } = 0;
    public int Trapaceou { get; set; } = 0;

    public abstract bool Interagir();
    public abstract Individuo Clone();

    public virtual void RecebeInteracao(bool interacao)
    {
        if (!interacao)
            this.Trapaceado++;
    }

    public void Azar()
    {
        Random rand = Random.Shared;
        if(rand.Next(100) < 10)
            this.Moedas--;
    }

    public void Pagamento()
    {
        this.Azar();

        this.Moedas--;

        if (this.Moedas <= 0)
            this.Vivo = false;
    }

}