using System.Runtime.InteropServices.JavaScript;

/*
string championName = "uthy";
string symbolOnMap = "!";
int levelOfExperinece = 10000;
int numberOfGold = 1000;
int weightOfBackpack = numberOfGold;
Console.WriteLine("== EKWIPUNEK == ");
Console.WriteLine($"Imie:  {championName}");
Console.WriteLine($"Symbol:  {symbolOnMap}");
Console.WriteLine($"Poziom:  {levelOfExperinece}");
Console.WriteLine($"zloto:  {numberOfGold}");
Console.WriteLine($"waga:  {weightOfBackpack}");

levelOfExperinece -= 25;
levelOfExperinece = levelOfExperinece * 2;
numberOfGold -= 8;
levelOfExperinece += 15;
Console.WriteLine($"doswiadczenie:  {levelOfExperinece}");
Console.WriteLine($"zloto:  {numberOfGold}");

Console.WriteLine("Liczba racji zywnosciowych: ");
float liczbaRacji = float.Parse(Console.ReadLine());

Console.WriteLine("Liczba czlonkow druzyny: ");
int liczbaCzlonkow = int.Parse(Console.ReadLine());

Console.WriteLine("Liczba dni do wyprawy: ");
int dniDoWyprawy = int.Parse(Console.ReadLine());

Console.WriteLine($"Kazdy czlonek druzyny otrzyma:  {(double)liczbaRacji / liczbaCzlonkow}");
Console.WriteLine($"Ile racji pozostanie po rownym podziale:  {(double)liczbaRacji % liczbaCzlonkow}");
Console.WriteLine($"ile racji dziennie przypadnie na cala druzyne:  {(double)liczbaRacji % dniDoWyprawy}");
Console.WriteLine($"ile racji dziennie przypadnie srednio na jedna osobe:  {(double)liczbaRacji / dniDoWyprawy / liczbaCzlonkow}");

Console.WriteLine("Podaj punkty zycia ");
int hP = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj liczbe mikstur");
int numberOfPotions = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj czy ma klucz");
bool haveKey = bool.Parse(Console.ReadLine());
Console.WriteLine("Podaj czy ma mape");
bool haveMap = bool.Parse(Console.ReadLine());

bool zyje = hP > 0;
bool maPelneZdrowie = hP == 100;
bool maZaopatrzenie = numberOfPotions >= 1;
bool maPrzedmiotNawigacyjny = false;
if (haveMap == true && haveKey == true || 
    haveMap == true && haveKey == false ||
    haveMap == false && haveKey == true)
{
     maPrzedmiotNawigacyjny = true;
} 
else
{
     maPrzedmiotNawigacyjny = false;
}

bool gotowyDoWyprawy = false;
if (zyje == true && maZaopatrzenie == true || gotowyDoWyprawy == true)
{
    gotowyDoWyprawy = true;
}

Console.WriteLine($"Zyje: {zyje}");
Console.WriteLine($"Ma pelne zdrowie: {maZaopatrzenie}");
Console.WriteLine($"wymaga leczenia: {!maPelneZdrowie}");
Console.WriteLine($"Ma zaopatrzenie: {maZaopatrzenie}");
Console.WriteLine($"Ma klucz lub mape: {maPrzedmiotNawigacyjny}");
Console.WriteLine($"gotowy do wyprawy: {gotowyDoWyprawy}");*/

Console.WriteLine("Podaj imie bohatera ");
string imie = Console.ReadLine();
Console.WriteLine("maksynalne punkty zycia");
int maxPointsOfHealth = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj punkty zycia przed walka");
int hPBeforeFight = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj podstawowe obrazenia broni");
int minimalAtackDamage = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj premie do sily");
int additionalAttackDamage =  int.Parse(Console.ReadLine());
Console.WriteLine("Podaj mnoznik ataku");
float multiplyAttakDamage = float.Parse(Console.ReadLine());
Console.WriteLine("Podaj liczbe wykonanych zwyklych atakow");
int numberOfNormalAttacks = int.Parse(Console.ReadLine());


Console.WriteLine($"Zwykly atak: {minimalAtackDamage + additionalAttackDamage}");
Console.WriteLine($"Atak specjalny: {(int)multiplyAttakDamage * minimalAtackDamage}");
Console.WriteLine($"Atak specjalny: {numberOfNormalAttacks * minimalAtackDamage + ((int)multiplyAttakDamage * minimalAtackDamage)}");
Console.WriteLine($"Procent pozostalego zdrowia bohatera: {(hPBeforeFight/(float)maxPointsOfHealth)* 100f}");
Console.WriteLine($"Żyje: {hPBeforeFight > 0}");
Console.WriteLine($"pelne zdrowie {hPBeforeFight == maxPointsOfHealth}");


