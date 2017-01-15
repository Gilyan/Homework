/* **************************************
Harjoitus 2

Luotu 11.1.2017

Toiminta: Ohjelma, jossa annetaan oppilaalle koulunumero seuraavan taulukon mukaan 
(pistemäärä kysytään ja ohjelma tulostaa numeron):

pisteraja	numero
    0-1	    0
    2-3	    1
    4-5	    2
    6-7	    3
    8-9	    4
    10-12	5

Esimerkkitoiminta:

    Anna pistemäärä > 8 [Enter]
    Koulunumero on 4
    
Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Harjoitus2
    {
        public static void Harj2()
        {
            int pisteet;

            Console.Write("Paljonko oppilas on saanut pisteitä? (0-12) : ");
            pisteet = int.Parse(Console.ReadLine());

            if (pisteet >= 0 && pisteet <= 1)
            { Console.Write("Arvosanaksi tulee 0.\n\n"); }

            else if (pisteet >= 2 && pisteet <= 3)
            { Console.Write("Arvosanaksi tulee 1.\n\n"); }

            else if (pisteet >= 4 && pisteet <= 5)
            { Console.Write("Arvosanaksi tulee 2.\n\n"); }

            else if (pisteet >= 6 && pisteet <= 7)
            { Console.Write("Arvosanaksi tulee 3.\n\n"); }

            else if (pisteet >= 8 && pisteet <= 9)
            { Console.Write("Arvosanaksi tulee 4.\n\n"); }

            else if (pisteet >= 10 && pisteet <= 12)
            { Console.Write("Arvosanaksi tulee 5.\n\n"); }

            else
            { Console.Write("Syötettä ei voitu lukea.\n\n"); }

        }
    }
}

