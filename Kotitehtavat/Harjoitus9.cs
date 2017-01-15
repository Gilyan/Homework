/* **************************************
Harjoitus 9

Luotu 11.1.2017

Toiminta: Ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. 
Ohjelman tulee tulostaa syötettyjen lukujen summa.

Esimerkkitoiminta:

    Anna Luku > 10 [Enter]
    Anna Luku > 20 [Enter]
    Anna Luku > 30 [Enter]
    Anna Luku > 0 [Enter]
    Lukujen summa on 60

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Harjoitus9
    {
        public static void Harj9()
        {
            int numero, summa = 0, lopetus = 0;

            do
            {
                Console.Write("Summa on nyt {0}. Syötä lisättävä numero : ", summa);
                numero = int.Parse(Console.ReadLine());

                summa += numero;

            } while (numero.CompareTo(lopetus) != 0);

            Console.WriteLine("Syöttämiesi lukujen summa on {0}.\n\n", summa);
        }
    }
}

