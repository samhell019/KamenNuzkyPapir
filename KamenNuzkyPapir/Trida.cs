using System;
using System.Collections.Generic;
using System.Text;

namespace KamenNuzkyPapir
{
    class Trida
    {
        public string Hra()
        {
            bool vstup = false;
            int uzivatel = 0;
            Random pocitac = new Random();
            int VyhraUzivatele = 0; // výhry uživatele
            int VyhraPc = 0; // výhry počítače
            for (int i = 0; i < 5; i++) // opakování cyklu 5x
            {


                do
                {
                    Console.WriteLine("0 = kámen; 1 = nůžky; 2 = papír"); // vypíše na obrazovku výběr: "0 = kámen; 1 = nůžky; 2 = papír"
                    Console.WriteLine("Vyber činnost: "); //Obrazovka vyzve uživatele, aby zadal jednu z výše uvedených možností
                    string koeficient = Console.ReadLine();  // přečte koeficienty
                    vstup = int.TryParse(koeficient, out uzivatel);  // v proměnné vstup se převede kouficient na číslo
                    if (vstup == true) // pokud se koeficient správně převedl na číslo
                    {
                        Console.WriteLine("Zadal jsi " + uzivatel); // na obrazovku se vypíše, jakou možnost uživatel zvolil
                    }
                    else
                    {
                        Console.WriteLine("Zadal jsi neplatnou hodnotu "); // vypíše se na obrazovku, pokud uživatel zadá hodnotu mimo číslo (string, boll...)
                    }
                }
                while (vstup == false || uzivatel > 2 || uzivatel < 0); // opakuj znovu, pokud je vstup neplatný nebo zadavé hodnoty větší jak 2 nebo menší jak 0
                int pc = pocitac.Next(0, 2); // počítač má na výběr z možností čísel 0,1,2 (random)
                if (uzivatel == 0 || pc == 1)
                {
                    VyhraUzivatele++;  // výhra uživatele = přičte se 1 bod za výhru
                    Console.WriteLine("Vyhrál uživatel! ");
                }
                else if (uzivatel == 0 || pc == 2)
                {
                    VyhraPc++;
                    Console.WriteLine("Vyhrál počítač! "); // výhra počítače = přičte se 1 bod za výhru
                }
                else if (uzivatel == 1 || pc == 0)
                {
                    VyhraPc++;
                    Console.WriteLine("Vyhrál počítač! ");
                }
                else if (uzivatel == 1 || pc == 2)
                {
                    VyhraUzivatele++;
                    Console.WriteLine("Vyhrál uživatel! ");
                }
                else if (uzivatel == 2 || pc == 1)
                {
                    VyhraUzivatele++;
                    Console.WriteLine("Vyhrál uživatel! ");
                }
                else if (uzivatel == 2 || pc == 0)
                {
                    VyhraPc++;
                    Console.WriteLine("Vyhrál počítač! ");
                }
                
                else { }
            }
            if (VyhraUzivatele < VyhraPc)
            {
                return("VYHRÁL POČÍTAČ!");
            }
            else if (VyhraUzivatele > VyhraPc)
            {
                return("VYHRÁL UŽIVATEL!");
            }
            else
            {
                return("REMÍZA!");
            }
        }
    }
}


