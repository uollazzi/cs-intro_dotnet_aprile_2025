// dichiarazione di una variabile 
int valoreIntero;

// assegnazione valore
valoreIntero = 8;

// dichiarazione variabili multipla
int val1, val2, val3;

// dichiarazione e assegnazione
int val4 = 67;
var val5 = "pippo"; // type inference

// tipo string
string valStringa1;
valStringa1 = "stringa 1";

// tipo bool
bool valBool = true;
valBool = false;

// tipo numero con virgola
double numeroConVirgola = 4.9;

// tipo data
DateTime oggi = DateTime.Now;

// casting
int five = 5;

var fiveDouble = (double)five;

// casting implicito (no perdita dati)
double fiveDouble2 = five;

// casting esplicito
double dblFour = 4.7;
int intFour = (int)dblFour;

// cast non fattibile
string myString = "1987";
// int frase = (int)myString;

int anno = Convert.ToInt32(myString);


// parsing
string strTwo = "2";
int intTwo = int.Parse(strTwo);

DateTime adesso = DateTime.Parse("12/12/2024");

// coversione in stringa di qualsiasi tipo di dato
intTwo.ToString();
dblFour.ToString();

// operatore is
var mioValore = 6.5;

bool isDouble = mioValore is double;

// tipi nullable
int? anni = null;
bool? flag = null;

if (anni.HasValue)
{
    Console.WriteLine(anni.Value);
}

// operatore ??
int? a = 89;

int f = a ?? -1;
// è l'equivalente di
int e;
if (a.HasValue)
{
    e = a.Value;
}
else
{
    e = -1;
}

int b = (int)a; // compila ma va in errore se a è null


Console.WriteLine(anno);
Console.WriteLine("Tipo:", intFour.GetType(), "Valore:", intFour);
