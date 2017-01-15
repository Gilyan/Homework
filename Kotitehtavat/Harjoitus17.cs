/* **************************************
Harjoitus 17

Luotu 11.1.2017

Toiminta: Ohjelma lajittelee kahdessa kokonaislukutaulukossa olevat alkiot suurusjärjestykseen 
kolmanteen kokonaislukutaulukkoon. Tulosta lopuksi lajitellun taulukon sisältö.

Esimerkkitoiminta:

    Luvut taulukossa 1 : 10,20,30,40,50
    Luvut taulukossa 2 : 5,15,25,35,45
    Luvut yhdistetyssä taulukossa : 5,10,15,20,25,30,35,40,45,50

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Harjoitus17
    {
        public static void Harj17()
        {
            int[] eka = new int[5] { 10, 20, 30, 40, 50 };
            int[] toka = new int[5] { 5, 15, 25, 35, 45 };
            int[] yhdistetty = new int[10];

            int i = 0;

            Array.Copy(eka, yhdistetty, eka.Length);
            Array.Copy(toka, 0, yhdistetty, eka.Length, toka.Length); 

            Array.Sort(yhdistetty);

            Console.Write("Luvut taulukossa 1 : ");
            for (i = 0; i < eka.Length; i++)
            {
                Console.Write(eka[i] + ", ");
            }

            Console.WriteLine();
            Console.Write("Luvut taulukossa 2 : ");
            for (i = 0; i < toka.Length; i++)
            {
                Console.Write(toka[i] + ", ");
            }

            Console.WriteLine();
            Console.Write("Taulukot yhdistetty : ");
            for (i = 0; i < yhdistetty.Length; i++)
            {
                Console.Write(yhdistetty[i] + ", ");
            }

            Console.WriteLine();

        }
    }
}

