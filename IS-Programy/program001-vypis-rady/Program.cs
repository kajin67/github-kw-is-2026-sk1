string again = "a";

// Řídící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A"
// jakýkoli jiný vstup program ukončí
while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("************************************");
    Console.WriteLine("************ Výpis řady ************");
    Console.WriteLine("************************************");
    Console.WriteLine("*********** Karel Wepper ***********");
    Console.WriteLine("************************************");

    //  Načtení počáteční hodnoty
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first)) {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");   
    }

    //  Načtení poslední hodnoty
    Console.Write("Zadejte poslední číslo řady (celé číslo): ");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last)) {
        Console.Write("Nezadali jste celé číslo. Zadejte poslední číslo řady znovu: ");   
    }

    //  Načtení siference
    Console.Write("Zadejte diferenci (kladné celé číslo): ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step)) || step <= 0 {
        Console.Write("Nezadali jste kladné celé číslo. Zadejte poslední číslo řady znovu: ");   
    }

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter: .");
    again = Console.ReadLine() ?? "";    

}