// costrutti condizionali
int eta = 14;

if (eta > 18)
{
    Console.WriteLine($"Hai {eta} anni e quindi sei maggiorenne.");
}
else if (eta == 18)
{
    Console.WriteLine($"Hai {eta} anni e quindi sei appena maggiorenne.");
}
else
{
    Console.WriteLine($"Hai {eta} anni e quindi sei minorenne.");
}

bool abilitatoAllaProfessione = true;

if (eta >= 18 && abilitatoAllaProfessione)
{
    Console.WriteLine("Puoi essere assunto.");
}
else
{
    Console.WriteLine("NON puoi essere assunto.");
}

if (eta >= 18)
{
    if (abilitatoAllaProfessione)
    {
        Console.WriteLine("Sei maggiorenne e abilitato, puoi essere assunto.");
    }
    else
    {
        Console.WriteLine("Sei maggiorenne ma non abilitato, NON puoi essere assunto.");
    }
}
else
{
    Console.WriteLine("Sei minorenne, NON puoi essere assunto.");
}