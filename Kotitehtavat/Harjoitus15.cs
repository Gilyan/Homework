/* **************************************
Harjoitus 15

Luotu 11.1.2017

Toiminta: Ohjelma tulostaa seuraavanlaisen kuvion. Kysy käyttäjältä puunkorkeus käytä juurena kaksi korkeuden yksikkö.

    Anna Luku > 7 [Enter]    
        *
       ***
      *****
     *******
    *********
        *
        *

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Harjoitus15
    {
        public static void Harj15()
        {
            int rivit = 0;

            Console.WriteLine("Kuinka korkea kuusi laitetaan? ");
            rivit = int.Parse(Console.ReadLine());
            rivit = rivit - 2;

            for (int i = 0; i < rivit; i++)
            {
                for (int a = 0; a < rivit - i - 1; a++)
                {
                    Console.Write(" ");
                }

                for (int y = 0; y < i * 2 + 1; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 2; i++)
            {
                for (int y = 0; y < rivit - 1; y++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine();
            } 

        }
    }
}

