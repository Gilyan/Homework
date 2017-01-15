/* **************************************
Harjoitus 11

Luotu 11.1.2017

Toiminta: Tee kahden sisäkkäisen for-silmukan avulla ohjelma, joka tulostaa seuraavanlaisen kuvion:

*
**
***
****
*****

Käyttäjä antaa syötteenä tähtirivien lukumäärän. Yllä olevassa esimerkissä käyttäjä on syöttänyt luvun 5.

Esimerkkitoiminta:

    Anna Luku > 3 [Enter]
    *
    **
    ***

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Harjoitus11
    {
        public static void Harj11()
        {
            int rivit, numerot, luku;

            Console.Write("Montako riviä laitetaan? ");
            rivit = int.Parse(Console.ReadLine());

            for (luku = 1; luku <= rivit; luku++)
            {
                Console.WriteLine();

                for (numerot = 1; numerot <= luku; numerot++)
                {
                    Console.Write("*");
                }
            }

            Console.WriteLine();
        }
    }
}

