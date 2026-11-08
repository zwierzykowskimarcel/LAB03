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
    
    Console.WriteLine("Podaj złoto");
    int gold = int.Parse(Console.ReadLine());
    if (gold < 0)
    {
        while (true)
        {
            Console.WriteLine("Złoto nie może być ujemne, Podaj złoto:");
            gold = int.Parse(Console.ReadLine());
            if (gold >= 0)
            {
                break;
            }
        }
    }

    Console.WriteLine("Podaj Zdrowie: ");
    int healthPoints = int.Parse(Console.ReadLine());
    if (healthPoints > 100) {
        while (true)
        {
            Console.WriteLine("Zdrowie nie może być wieksze od 100, Podaj zdrowie: ");
            healthPoints = int.Parse(Console.ReadLine());
            if (healthPoints <= 100) 
            {
                break;
            }
    }
    }

    Console.WriteLine("Podaj liczbe mikstur: ");
    int countOfPotions = int.Parse(Console.ReadLine());
    if (countOfPotions < 0)
    {
        while (true)
        {
            Console.WriteLine("Liczba mikstur nie może być ujemna, Podaj liczbe mikstur: ");
            countOfPotions = int.Parse(Console.ReadLine());
            if (countOfPotions >= 0)
            {
                break;
            }
        }
    }
    
int numberOfRound = 1;

bool active = true;

while (active)
{
    Console.WriteLine("1 - Eksploruj loch");
    Console.WriteLine("2 - Użyj mikstury");
    Console.WriteLine("3 - Odpocznij");
    Console.WriteLine("4 - Pokaż statystyki");
    Console.WriteLine("5 - Zakończ grę");
    int option = int.Parse(Console.ReadLine());
    
    switch (option)
    {
        case 1:
            if (healthPoints < 8)
            {
                Console.WriteLine("Akcja jest niemozliwa, Umrzesz");
                break;
            }
            gold += 10;
            healthPoints -= 8;
            numberOfRound++;
            break;
        case 2:
            if (healthPoints == 100) 
            {
                Console.WriteLine("Już posiadasz maksymalne zdrowie");   
                break;
            }
            
            if (countOfPotions > 0)
            {
                if (healthPoints + 20 > 100)
                {
                    healthPoints = 100;
                    countOfPotions--;
                    numberOfRound++;
                    break;
                }
                healthPoints += 20;
                countOfPotions--;
                numberOfRound++;

            }
            else
            {
                Console.WriteLine("Nie mozesz sie wyleczyc, Brak mikstur");
            }
            break;
        case 3:
            if (gold < 3) 
            {
                Console.WriteLine("Akcja jest niemożliwa, za mało złota");
                break;
            }

            if (healthPoints >= 98 && healthPoints <= 100)
            {
                healthPoints = 100;
            }
            else
            {
            healthPoints += 3;
            }
            gold -= 3;
            numberOfRound++;
            break;
        case 4:
            Console.WriteLine("STATYSTYKI:");
            Console.WriteLine($"Aktualna tura: {numberOfRound}");
            Console.WriteLine($"Punkty zdrowia: {healthPoints}");
            Console.WriteLine($"Posiadasz {countOfPotions} mikstur");
            break;
        case 5:
            active = true;
            break;
        default:
            Console.WriteLine("Błąd, nieznana opcja");
            break;
    }
}


