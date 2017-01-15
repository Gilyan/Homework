/* **************************************
Harjoitus 16

Luotu 11.1.2017

Toiminta: Ohjelma arpoo satunnaisluvun väliltä 0-100. Käytä C#:n Random -luokkaa. Tämän 
jälkeen ohjelman käyttäjää kehoitetaan arvaaman arvottu luku. Ohjelman tulee antaa vihje 
arvauksen jälkeen onko arvottu luku pienempi vai suurempi. Tämän jälkeen vihjeitä toistetaan 
kunnes käyttäjä arvaa oikean luvun. Tulosta lopuksi arvausten määrä näytölle. 

PS Satunnaislukujen arpomisesta tietokoneella löytyy mielenkiintoista luettavaa esimerkiksi 
tästä artikkelista: Computers are lousy random number generators.

Esimerkkitoiminta:

    Arvaa luku > 50 [Enter]
    Luku on suurempi
    Arvaa luku > 75 [Enter]
    Luku on pienempi
    Arvaa luku > 66 [Enter]
    Hienoa, arvasit luvun 3 kerralla.
    

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Harjoitus16
    {
        public static void Harj16()
        {
            int numero, arvaus, kierros = 0;
            string muuttuja;

            Random rand = new Random();

            numero = rand.Next(0, 100);

            do
            {
                System.Console.Write("Arvaa, mitä numeroa ajattelen väliltä 0-100? (lopetus = x) > ");

                muuttuja = System.Console.ReadLine();

                if (muuttuja == "x")
                {
                    break;
                }

                try
                {
                    arvaus = Convert.ToInt32(muuttuja);

                    if (arvaus < numero)
                    {
                        //System.Console.Write(numero);
                        Console.WriteLine("Ei mennyt oikein, minun numeroni on suurempi!");
                        kierros++;
                    }

                    else if (arvaus > numero)
                    {
                        //System.Console.Write(numero);
                        Console.WriteLine("Ei mennyt oikein, minun numeroni on pienempi!");
                        kierros++;
                    }

                    else if (arvaus == numero)
                    {
                        kierros++;
                        Console.WriteLine("Oikein! Arvasit numeroni {0} yrityksellä.", kierros);
                        break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Arvaa joku numero väliltä 0-100. Jos haluat lopettaa, paina 'x'.");
                }

            } while (true);

        }
    }
}

