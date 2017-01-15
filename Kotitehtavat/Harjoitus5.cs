/* **************************************
Harjoitus 5

Luotu 11.1.2017

Toiminta: Ohjelma näyttää annetun sekuntimäärän tunteina, minuutteina ja 
sekunteina. Aikamääre sekunteina kysytään käyttäjältä.

Esimerkkitoiminta:

    Anna sekunnit > 3661 [Enter]
    Antamasi sekunttiaika voidaan ilmaista muodossa: 1 tunti 1 minuutti 1 sekunti

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Harjoitus5
    {
        public static void Harj5()
        {
            int sekunnit = 0;

            Console.WriteLine("Kuinka monta sekuntia muunnetaan? ");
            sekunnit = int.Parse(Console.ReadLine());

            TimeSpan aika = TimeSpan.FromSeconds(sekunnit);

            Console.WriteLine(aika);

            string sek = aika.ToString("%s");
            string min = aika.ToString("%m");
            string tun = aika.ToString("%h");

            Console.WriteLine("{0} sekuntia on sama asia kuin {1} tuntia, {2} minuuttia ja {3} sekuntia.", sekunnit, tun, min, sek);
        }
    }
}