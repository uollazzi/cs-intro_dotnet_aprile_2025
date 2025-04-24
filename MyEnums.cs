// enum
// tipo che può assumere solo specifici valori

enum Stagione
{
    Primavera,
    Estate,
    Autunno,
    Inverno
}

enum Mese
{
    Gennaio = 1,
    Febbraio = 2,
    Marzo = 3,
    Aprile = 4,
    Maggio = 5,
    Giugno = 6,
    Luglio = 7,
    Agosto = 8,
    Settembre = 9,
    Ottobre = 10,
    Novembre = 11,
    Dicembre = 12
}

enum HttpStatusCode : ushort
{
    OK = 200,
    NotFound = 404,
    ServerError = 500
}