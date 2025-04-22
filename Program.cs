// concatenazione
string amico = "Gigi";
string saluto = "Ciao " + amico + "!";

Console.WriteLine(saluto);

// interpolazione
Console.WriteLine($"Ciao {amico}!");

var altroAmico = "Mario";
Console.WriteLine($"I miei amici sono {amico} e {altroAmico}.");

// proprietà delle stringhe
Console.WriteLine($"Il nome {amico} ha {amico.Length} lettere.");
Console.WriteLine($"Il nome {altroAmico} ha {altroAmico.Length} lettere.");

// conversione
char a = 'a';
int eta = 31;
double altezza = 1.56;

Console.WriteLine($"La mia amica {amico}{a} ha {eta} anni ed è alta {altezza} metri.");

// operazioni sulle stringhe
string saluti = "      Ciao Mondo!       ";
Console.WriteLine($"[{saluti}]");

string trimmedSaluti = saluti.Trim();
Console.WriteLine($"[{trimmedSaluti}]");

Console.WriteLine($"[{saluti.TrimStart()}]");
Console.WriteLine($"[{saluti.TrimEnd()}]");

// replace
string ciao = "Ciao Mondo!";
Console.WriteLine(ciao);

string ciao2 = ciao.Replace("Ciao", "Buongiorno");
Console.WriteLine(ciao2);

ciao2 = ciao.Replace("ciao", "Buongiorno");
Console.WriteLine(ciao2);

ciao2 = ciao.Replace("ciao", "Buongiorno", true, null);
Console.WriteLine(ciao2);

// upper, lower
Console.WriteLine(ciao.ToUpper());
Console.WriteLine(ciao.ToLower());

// ricerca
string songLyrics = "Tu dici addio, io dico arrivederci";
Console.WriteLine(songLyrics.Contains("addio"));
Console.WriteLine(songLyrics.Contains("saluti"));

Console.WriteLine(songLyrics.StartsWith("Tu"));
Console.WriteLine(songLyrics.StartsWith("tu", true, null));
Console.WriteLine(songLyrics.EndsWith("rci"));

string albero = "albERo";
Console.WriteLine(albero.Substring(0, 1)); // a
Console.WriteLine(albero.Substring(2, 3)); // bER

// range operator
Console.WriteLine(albero[..2]); // al
Console.WriteLine(albero[2..]); // bERo
Console.WriteLine(albero[2..5]); // bER - dal carattere 2 al carattere 5 compresi

// trasformare "albERo" in "Albero" usando substring
string albero2 = $"{albero[..1].ToUpper()}{albero[1..].ToLower()}";
Console.WriteLine(albero2);

albero2 = $"{albero.Substring(0, 1).ToUpper()}{albero.Substring(1).ToLower()}";
Console.WriteLine(albero2);