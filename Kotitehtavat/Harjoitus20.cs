/* **************************************
Harjoitus 20

Luotu 11.1.2017

Toiminta: Kolikonheitto. Käyttäjältä kysytään, kuinka monta kertaa hän haluaa 
heittää kolikkoa. Tuloksista pidetään kirjaa ja ne ilmoitetaan lopuksi.

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Harjoitus20
    {
        public static void Harj20()
        {
            int heitto = 0, numero = 0, kruuna = 0, klaava = 0;
            Random rand = new Random();

            Console.Write("Kuinka montaa kertaa heitetään kolikkoa? ");
            heitto = int.Parse(Console.ReadLine());

            for (int i = 0; i < heitto; i++)
            {
                numero = rand.Next(0, 2);

                if (numero == 0)
                { kruuna++;  }

                else
                { klaava++; }
            }

            Console.WriteLine("Kolikkoa heitetty {0} kertaa, tuloksena tuli {1} kruunaa ja {2} klaavaa.", heitto, kruuna, klaava);
        }
    }
}

