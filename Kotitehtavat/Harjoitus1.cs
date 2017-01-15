/* **************************************
Harjoitus 1

Luotu 11.1.2017

Toiminta: Ohjelma tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana 
(yksi, kaksi tai kolme). Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa 
teksti: "joku muu luku".

Esimerkkitoiminta:

    Anna luku > 1 [Enter]
    Annoit luvun yksi

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Harjoitus1
    {
        public static void Harj1()
        {
            int numero;

            Console.Write("Syötä joku numero (1, 2, 3) : ");
            numero = int.Parse(Console.ReadLine());

            if (numero == 1)
            { Console.Write("Syötit numeron yksi.\n\n"); }

            else if (numero == 2)
            { Console.Write("Syötit numeron kaksi.\n\n"); }

            else if (numero == 3)
            { Console.Write("Syötit numeron kolme.\n\n"); }

            else
            { Console.Write("Syötit jonkun muun luvun.\n\n"); }

        }
    }
}

