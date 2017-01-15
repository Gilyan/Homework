/* **************************************
Harjoitus 18

Luotu 11.1.2017

Toiminta: Ohjelma kysyy käyttäjältä merkkijonon (lause). Sovelluksen tulee 
ilmoittaa käyttäjälle oliko annettu merkkijono palidromi.

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;
using System.Text.RegularExpressions;

namespace JAMK.IT
{
    public class Harjoitus18
    {
        public static void Harj18()
        {
            string lause, kaannetty = "";

            Console.Write("Anna tarkistettava merkkijono: ");
            lause = Console.ReadLine();

            if (lause != null)
            {
                for (int i = lause.Length - 1; i >= 0; i--)
                { kaannetty += lause[i].ToString(); }

                string lause2 = Regex.Replace(lause, @"\s", "");            // Poistetaan turhia merkkejä välistä
                string kaannetty2 = Regex.Replace(kaannetty, @"\s", "");    // Poistetaan turhia merkkejä välistä

                if (string.Equals(lause2, kaannetty2, StringComparison.OrdinalIgnoreCase) == true) // Isoilla ja pienillä kirjaimilla ei merkitystä
                { Console.WriteLine("Kyseessä on palindromi."); }

                else
                { Console.WriteLine("Kyseessä ei ole palindromi."); }

            }
        }
    }
}

