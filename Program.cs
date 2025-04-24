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

string etichetta = "";

etichetta = eta >= 18 ? "maggiorenne" : "minorenne";

var stagioneCorrente = Stagione.Primavera;
Stagione stagionePrecendente = Stagione.Inverno;

Console.WriteLine(stagioneCorrente);

// conversione
int stagioneCorrenteInt = (int)stagioneCorrente;
Console.WriteLine(stagioneCorrenteInt);

var autunno = (Stagione)2;
Console.WriteLine(autunno);

if (stagioneCorrente == Stagione.Primavera)
{
    Console.WriteLine("In primavera sbocciano i fiori.");
}

Mese meseCorrente = Mese.Febbraio;
Console.WriteLine((int)meseCorrente);

switch (meseCorrente)
{
    case Mese.Gennaio:
        Console.WriteLine($"{meseCorrente} è il mese numero {(int)meseCorrente}");
        break;
    case Mese.Febbraio:
        Console.WriteLine($"{meseCorrente} è il mese numero {(int)meseCorrente}");
        break;
    case Mese.Marzo:
        Console.WriteLine($"{meseCorrente} è il mese numero {(int)meseCorrente}");
        break;
    default:
        Console.WriteLine("Altri mesi dopo Marzo");
        break;
}

Console.Write("Inserire un mese (1-12): ");
var m = Console.ReadLine();

if (m != null)
{
    int meseInNumero = Convert.ToInt32(m);
    meseCorrente = (Mese)meseInNumero;
}

switch (meseCorrente)
{
    case Mese.Novembre:
    case Mese.Aprile:
    case Mese.Giugno:
    case Mese.Settembre:
        Console.WriteLine($"{meseCorrente} ha 30 giorni.");
        break;
    case Mese.Febbraio:
        Console.WriteLine($"{meseCorrente} ha 28 giorni (a volte 29).");
        break;
    default:
        Console.WriteLine($"Tutti gli altri ne hanno 31, compreso {meseCorrente}");
        break;
}