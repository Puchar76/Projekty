var name = "Ewa";
string plec = "man";
int wiek = 17;

if (wiek < 30)
{
    if (plec == "kobieta")
    {
        Console.WriteLine("Kobieta poniżej 30 lat.");
    }
    else if (plec == "man" && wiek < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna.");
    }

}
else if (wiek == 30 && name == "Ewa")
{
    Console.WriteLine("Kobieta, lat 30.");
}




//if (plec == "kobieta" && wiek < 30)
//{
//    Console.WriteLine("Kobieta poniżej 30 lat.");
//}
//else if (name == "Ewa" && wiek == 30)
//{
//    Console.WriteLine("Ewa, lat 30.");
//}
//else if (plec == "man" && wiek < 18)
//{
//    Console.WriteLine("Niepełnoletni mężczyzna.");
//}
//else
//{
//    Console.WriteLine("Brak wyników.");
//}