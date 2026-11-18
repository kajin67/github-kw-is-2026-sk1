﻿string again = "a";

// Řídící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A"  
// Jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a" )
{
    // Vymazání konzole
    Console.Clear();
    
    // Hlavička programu
    Console.WriteLine("************************************");
    Console.WriteLine("***** Vykreslování obdélníků *******");
    Console.WriteLine("************************************");
    Console.WriteLine("*********** Karel Wepper ************");
    Console.WriteLine("************************************");
    Console.WriteLine();
    Console.WriteLine();

    // Načtení šířky
    Console.Write("Zadejte šířku obrazce (celé kladné číslo): ");
    int width;
    while(!int.TryParse(Console.ReadLine(), out width) || width <= 0 ) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste kladné celé číslo. Zadejte šířku znovu: ");
        Console.ResetColor();
    }

    // Načtení výšky
    Console.Write("Zadejte výšku obrazce (celé kladné číslo): ");
    int height;
    while(!int.TryParse(Console.ReadLine(), out height) || height <= 0 ) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste kladné celé číslo. Zadejte výšku znovu: ");
        Console.ResetColor();
    }

    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"Šířka: {width}; Výška: {height};");
    Console.WriteLine("=============================");
    Console.WriteLine();
    Console.WriteLine();

    // Zde budeme pokračovat konkrétním algoritmem
    /* 
    
    šířka 4
    výška 4

    * * * * 
    * * * * 
    * * * * 
    * * * * 
    
    */
    
    // Jádro vykreslovacího algoritmu
    // Vnější cyklus, který nám bude hlídat počet řádků (shora dolů)
    for(int i = 1; i <= height; i++)
    {   
        if(i % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }
        
        // Vnitřní cyklus, který se nám postará o to, aby se v každém řádku vykreslil správný počet znaků
        for (int j = 1; j <= width; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100)); // Zpoždění - program v tuto chvíli čeká
        }
        Console.WriteLine();
        
    }
    Console.ResetColor();    

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stislněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}