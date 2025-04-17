// operatori di assegnazione
int x = 10;
string y = "ciao";
x = 78;

// operatori aritmetici
int risultato = 0;
int j = 9;
int k = 3;

risultato = j + k;
risultato = j - k;
risultato = j * k;
risultato = j / k;
risultato = j % k; // ritorna in RESTO di una divisione

risultato++; // incrementa di 1
risultato = risultato + 1; // incrementa di 1

risultato--; // decrementa di 1

risultato += 3; // incrementa di 3
risultato = risultato + 3; // incrementa di 3

risultato *= 5;
risultato = risultato * 5;

// operatori di confronto
bool blnRisultato = true;
blnRisultato = j == k;
blnRisultato = j != k;
blnRisultato = j >= k; // >=
blnRisultato = j > k;

// operatori logici
bool bello = true;
bool buono = false;

blnRisultato = bello && buono; // AND

blnRisultato = bello || buono; // OR

blnRisultato = !bello; // false

// ! ha la massima precendena
// && ha priorità maggiore rispetto a || 