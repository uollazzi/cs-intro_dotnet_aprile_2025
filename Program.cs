// normalmente in C# array e liste contengono un elenco di dati dello STESSO TIPO
// array

// dichiarazione specificando la dimensione
int[] arr1 = new int[5];

// dichiarazione specificando gli elementi
int[] arr2 = new int[] { 1, 3, 5, 6 };
int[] arr3 = [3, 5, 6];

int[,,] arr4 = new int[3, 3, 6];

Mese[] mesiCaldi = [Mese.Giugno, Mese.Luglio, Mese.Agosto];

Console.WriteLine(mesiCaldi[1]);

// generics
// introducono il concetto di tipo come parametro
List<int> listaDiInteri2 = new List<int>() { 1, 3, 4 };
List<int> listaDiInteri = [1, 3, 4];

Console.WriteLine(listaDiInteri[1]);
Console.WriteLine(listaDiInteri.Count);

List<string> listaDiStringhe = ["ciao", "pippo"];

// list
// come array ma più "comode" da usare
List<int> numeriPrimi = [2, 3, 5];
numeriPrimi.Add(7); // [2,3,5,7]

int index = numeriPrimi.IndexOf(58);
Console.WriteLine(index);

numeriPrimi.Remove(2);
Console.WriteLine(string.Join(",", numeriPrimi));

numeriPrimi.Add(1);
Console.WriteLine(string.Join(",", numeriPrimi));

numeriPrimi.Sort();
Console.WriteLine(string.Join(",", numeriPrimi));

numeriPrimi.Reverse();
Console.WriteLine(string.Join(",", numeriPrimi));

numeriPrimi[0] = 19;
Console.WriteLine(string.Join(",", numeriPrimi));

numeriPrimi.Clear();
Console.WriteLine(string.Join(",", numeriPrimi));

// cicli
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(i);
}

List<string> nomi = ["Gigi", "Mario", "Betta"];

// alternativa for
for (int i = 0; i < nomi.Count; i++)
{
    var item = nomi[i];
    Console.WriteLine(item);
}

// alternativa foreach
foreach (var item in nomi)
{
    Console.WriteLine(item);
}

int numeroMax = 0;
List<int> numeri = [37, 6, 87, 63, 61];

foreach (var numero in numeri)
{
    if (numero > numeroMax)
    {
        numeroMax = numero;
    }
}

Console.WriteLine($"Numero massimo: {numeroMax}");

int somma = 0;
foreach (var numero in numeri)
{
    somma += numero;
}

Console.WriteLine($"Somma numeri: {somma}");

// ciclo do
// esegue in modo condizionale il corpo UNA o più volte
// esegue prima il codice E POI controlla la condizione
int contatore = 0;
do
{
    Console.WriteLine($"Ciclo do: {contatore}");
    contatore++;
} while (contatore < 5);

// ciclo while
// testa PRIMA la condizione poi eventualmente esegue il codice
// esegue in modo condizionale il corpo ZERO o più volte
contatore = 0;
while (contatore < 5)
{
    Console.WriteLine($"Ciclo while: {contatore}");
    contatore++;
}

// TODO: interruzioni cicli 