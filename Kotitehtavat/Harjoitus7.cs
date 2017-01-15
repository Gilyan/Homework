/* **************************************
Harjoitus 7

Luotu 11.1.2017

Toiminta: Ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.
4:llä jaolliset on, paitsi täydet vuosisadat. Kuitenkin 400:lla jaolliset vuosisadat ovat.

Esim. 
1991 -> ei
1992 -> on
1900 -> ei
2000 -> on

Esimerkkitoiminta:

    Anna vuosi > 1992 [Enter]
    Vuosi on karkausvuosi.

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Harjoitus7
    {
        public static void Harj7()
        {
            int vuosi = 0;

            Console.Write("Anna haluamasi vuosiluku : ");
            vuosi = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(vuosi))
            {
                Console.Write("Kyseessä on karkausvuosi. ");
            }
            else
            {
                Console.Write("Kyseessä ei ole karkausvuosi. ");
            }

        }
    }
}

