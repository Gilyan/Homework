/* **************************************
Harjoitus 4

Luotu 11.1.2017

Toiminta: Ohjelma, jossa kysytään käyttäjältä tämän ikä. 

Jos ikä on alle 18 vuotta, tulosta "alaikäinen", 
jos se on 18-65 vuotta, tulosta "aikuinen", 
muussa tapauksessa tulosta "seniori".

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Harjoitus4
    {
        public static void Harj4()
        {
            double ika = 0;

            Console.WriteLine("Anna ikäsi: ");
            ika = double.Parse(Console.ReadLine());

            if (ika >= 0 && ika <= 17.99)
            { Console.WriteLine("Olet alaikäinen.\n"); }

            else if (ika >= 18 && ika <= 65.99)
            { Console.WriteLine("Olet aikuinen.\n"); }

            else if (ika >= 66 && ika <= 120.99)
            { Console.WriteLine("Olet seniori.\n"); }

            else
            { Console.WriteLine("Syötitkö varmasti ikäsi oikein?.\n\n"); }
        }
    }
}

