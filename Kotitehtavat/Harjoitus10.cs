/* **************************************
Harjoitus 10

Luotu 11.1.2017

Toiminta: Ohjelma alustaa sovellukseen käyttöö seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100]. 
Käy sovelluksessa taulukko läpi ja tulosta ruutuun "HEP"-sana aina kun taulukossa oleva luku on parillinen.

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Harjoitus10
    {
        public static void Harj10()
        {
            int[] taulukko = new int[9] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            double tarkistus;

            for (int i = 0; i < 9; i++)
            {
                tarkistus = taulukko[i] % 2;        // Otetaan jakojäännös

                if (tarkistus == 0)
                     { Console.WriteLine(taulukko[i] + " HEP"); }

                else
                     { Console.WriteLine(taulukko[i]); }
                }

            Console.WriteLine();
        }
    }
}

