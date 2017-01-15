/* **************************************
Harjoitus 3

Luotu 11.1.2017

Toiminta: Ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden 
summan ja keskiarvon.

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Harjoitus3
    {
        public static void Harj3()
        {
            double[] numerot = new double[3];
            double summa = 0, keskiarvo = 0;

            for (int i = 0; i < numerot.Length; i++)
            {
                Console.WriteLine("Anna numero: ");
                numerot[i] = double.Parse(Console.ReadLine());
            }

            summa = numerot[0] + numerot[1] + numerot[2];
            keskiarvo = summa / 3;

            Console.WriteLine("Syöttämäsi numerot olivat {0}, {1} ja {2}", numerot[0], numerot[1], numerot[2]);
            Console.WriteLine("Lukujen summa on " + summa);
            Console.WriteLine("Lukujen keskiarvo on " + keskiarvo);
        }
    }
}