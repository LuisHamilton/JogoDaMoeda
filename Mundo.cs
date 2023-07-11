public static class Mundo
{
    public static List<Individuo> Populacao = new List<Individuo>();

    public static void AddIndividuo<T>(int quantidade)
        where T : Individuo, new()
    {
        for(int i = 0; i < quantidade; i++)
            Populacao.Add(new T());
    }

    public static void Interacoes()
    {
        if(Populacao.Count <= 1)
            return;
        
        for (int i = 0; i < Populacao.Count; i+=2)
        {
            Interacao();
        }
    }

    public static void Interacao()
    {
        Random rand = Random.Shared;

        int rIndex = rand.Next(Populacao.Count);
        Individuo individuo1 = Populacao[rIndex];

        rIndex += rand.Next(Populacao.Count - 1);
        Individuo individuo2 = Populacao[rIndex % Populacao.Count];

        bool interacao1 = individuo1.Interagir();
        bool interacao2 = individuo2.Interagir();

        individuo1.RecebeInteracao(interacao2);
        individuo2.RecebeInteracao(interacao1);

        switch(interacao1, interacao2)
        {
            case (true, true):
                individuo1.Moedas += 2;
                individuo2.Moedas += 2;
                break;
            case (true, false):
                individuo2.Moedas += 4;
                break;
            case (false, true):
                individuo1.Moedas += 4;
                break;
            default:
                break;
        }
    }

    public static void HoraPagamento()
    {
        for (int i = 0; i < Populacao.Count; i++)
        {
            Populacao[i].Pagamento();

            if(Populacao[i].Moedas >= 20)
                Populacao.Add(Populacao[i].Clone());

            if(!Populacao[i].Vivo)
            {
                Populacao.Remove(Populacao[i]);
                i--;
            }
        }
    }
}