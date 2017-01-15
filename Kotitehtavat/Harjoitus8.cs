/* **************************************
Harjoitus 8

Luotu 11.1.2017

Toiminta: Ohjelma kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.

Esimerkkitoiminta:

    Anna Luku > 5 [Enter]
    Anna Luku > 15 [Enter]
    Anna Luku > 7 [Enter]
    Suurin luku on 15

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Harjoitus8
    {
        public static void Harj8()
        {
            int[] numerot = new int[3];

            for (int i = 0; i < numerot.Length; i++)
            {
                Console.Write("Anna kokonaisluku: ");
                numerot[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numerot);

            Console.WriteLine("Suurin luku on {0}", numerot[2]);
        }
    }
}

