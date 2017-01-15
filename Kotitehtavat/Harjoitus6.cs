/* **************************************
Harjoitus 6

Luotu 11.1.2017

Toiminta: Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja 
bensan hinta on 1.595 Euroa. Tee ohjelma, joka tulostaa ajetulla 
matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan 
menevän rahan määrän.

Esimerkkitoiminta:

    Anna matka > 250 [Enter]
    Bensaa kuluu 17,55 litraa, kustannus 27,99 euroa

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Harjoitus6
    {
        public static void Harj6()
        {
            double matka = 0;
            double kulutus = 7.02;
            double hinta = 1.595;

            double kustannus = 0;
            double litra = 0;

            Console.WriteLine("Kuinka pitkä matka on tiedossa (km)? ");
            matka = double.Parse(Console.ReadLine());

            litra = (kulutus / 100) * matka;
            kustannus = litra * hinta;

            Console.WriteLine("Bensaa kuluu yhteensä {0:F2} litraa, joten reissu tulee maksamaan sinulle {1:F2} euroa.", litra, kustannus);

        }
    }
}

