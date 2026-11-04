
string again = "a";

// Ridici cyklus programu
while (again.ToLower() == "a")
{
    // Vymazani konzole
    Console.Clear();

    // Hlavicka programu
    Console.WriteLine("*************************************");
    Console.WriteLine("********** Ciferný součet ***********");
    Console.WriteLine("*************************************");
    Console.WriteLine("*********** Karel Wepper ************");
    Console.WriteLine("*************************************");
    Console.WriteLine();
    Console.WriteLine();

    // Nacteni cisla
    Console.Write("Zadejte celé cislo: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste cele cislo. Zadejte cislo znovu: ");
    }

    // Zde budeme pokracovat konkretnim algoritmem

    // Priprava promennych
    int numberBackup = number;
    int sum = 0; // Neutralni hodnota pro scitani je 0
    int soucin = 1; // Neutralni hodnota pro nasobeni je 1
    int digit; // Promenna pro vlozeni prave zjistene cislice

    // Vypocet souctu a soucinu cifer
    if (number < 0)
    {
        number = -number;
    }

    // Zvlastni priklad pro nulu
    if (number == 0)
    {
        sum = 0;
        soucin = 0;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Prubeh rozkladu cisla (zprava)");

        while (number > 0)
        {
            digit = number % 10; // Modulo 10

            sum = sum + digit; // Pricteni cislice k celkovemu souctu
            soucin = soucin * digit; // Vynasobeni cislice k celkovemu soucinu

            Console.WriteLine($"Ziskana cislice: {digit}");

            number = number / 10; // Celočíselné dělení
        }
    }

    // Vypis vysledku
    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"Soucet cislic cisla: {numberBackup} je {sum}");
    Console.WriteLine($"Soucin cislic cisla: {numberBackup} je {soucin}");
    Console.WriteLine("=============================");

    // Rekapitulace zadane hodnoty a vysledku
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakovani programu stisknete klavesu a.");
    Console.WriteLine("Jakoukoliv jinou klavesou program ukoncite.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}
