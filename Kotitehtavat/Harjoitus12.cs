/* **************************************
Harjoitus 12

Luotu 11.1.2017

Toiminta: Ohjelma kysyy käyttäjältä 5 kokonaislukua. Luvut tulee sijoittaa 
taulukkoon. Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä.

Esimerkkitoiminta:

    Anna Luku > 1 [Enter]
    Anna Luku > 2 [Enter]
    Anna Luku > 3 [Enter]
    Anna Luku > 4 [Enter]
    Anna Luku > 5 [Enter]
    Luvut ovat 5,4,3,2,1

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Harjoitus12
    {
        public static void Harj12()
        {
            int[] numerot = new int[5];
            int i;

            for (i = 0; i < numerot.Length; i++)
            {
                Console.Write("Anna numero: ");
                numerot[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Luvut olivat ");
            for (i = 4; i >= 0; i--)
            {
                Console.Write(numerot[i] + " ");
            }

            Console.WriteLine();
        }
    }
}

