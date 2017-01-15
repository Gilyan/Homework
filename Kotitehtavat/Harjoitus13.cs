/* **************************************
Harjoitus 13

Luotu 11.1.2017

Toiminta: Mäkihypyssä käytetään viittä arvostelutuomaria. Kirjoita ohjelma, joka kysyy 
arvostelupisteet yhdelle hypylle ja tulostaa tyylipisteiden summan siten, että summasta 
on vähennetty pois pienin ja suurin tyylipiste.

Esimerkkitoiminta:

    Anna pisteet > 18 [Enter]
    Anna pisteet > 15 [Enter]
    Anna pisteet > 20 [Enter]
    Anna pisteet > 19 [Enter]
    Anna pisteet > 17 [Enter]
    Kokonaispisteet ovat 54

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Harjoitus13
    {
        public static void Harj13()
        {
            int[] numerot = new int[5];
            int pisteet = 0;

            for (int i = 0; i < numerot.Length; i++)
            {
                Console.Write("Anna pisteet: ");
                numerot[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numerot);

            pisteet = numerot[1] + numerot[2] + numerot[3];

            Console.WriteLine("Kokonaispisteet ovat {0}", pisteet);

        }
    }
}

