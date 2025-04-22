// tipi di dato

// interi
int intero_int = 999999999; // int è alias di Int32
Int32 itero32 = 999999999;

short intero_short = 9999; // short è alias di Int16
Int16 intero16 = 9999;

long intero_long = 999999999999999999; // long è alias di Int64
Int64 intero64 = 999999999999999999;

ushort us = 9999;
uint ui = 999999999;
ulong ul = 999999999999999999;

// decimali
float single_float = 1.5f; // float è alias di Single
Single single = 1.5f;

double dbl_double = 1.5d; // 1.5 (d) double è alias di Double
Double dbl = 1.5;

decimal dcml_decimal = 1.5m; // decimal è alias di Decimal
Decimal dcml = 1.5m;

// conversione/cast implicito (no perdita di dati)
int fromInt = 56;
double toDouble = fromInt;

// conversione/cast esplicito (possibile perdita di dati)
short toShort = (short)fromInt;

// https://learn.microsoft.com/it-it/dotnet/csharp/language-reference/builtin-types/numeric-conversions

// area del cerchio
decimal r = 2.5m;
double dd = 5.6;

double risultato = (double)r / dd;

double r2 = 4.5;

Console.WriteLine((double)r * (double)r * Math.PI);
Console.WriteLine(r2 * r2 * Math.PI);