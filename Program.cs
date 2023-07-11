using static System.Console;

Mundo.AddIndividuo<Matematico>(4);

int dias = 0;
bool populacaoViva = true;

while(populacaoViva)
{
    WriteLine($"Indivíduos vivos: {Mundo.Populacao.Count}");
    Mundo.Interacoes();
    Mundo.HoraPagamento();
    if (Mundo.Populacao.Count == 0)
        populacaoViva = false;
    dias++;
}

WriteLine($"A população sobreviveu {dias} dias");