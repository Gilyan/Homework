/* **************************************
Harjoitus 14

Luotu 11.1.2017

Toiminta: Ohjelma pyytää käyttäjältä opiskelijoiden arvosanat 0-5 
ohjelmointi-opintojaksosta. Ohjelma päättyy, kun syöttää merkin 'x'.

Tulosta arvosanajakauma käyttäen tähtimerkkejä seuraavasti:

Arvosanajakauma: 
0:
1:****
2:**
3:******
4:*****
5:**

Esimerkkitoiminta:

    Anna arvosana > 5 [Enter]
    Anna arvosana > 5 [Enter]
    Anna arvosana > 4 [Enter]
    Anna arvosana > 3 [Enter]
    Anna arvosana > 2 [Enter]
    Anna arvosana > 1 [Enter]
    Anna arvosana > 0 [Enter]
    Anna arvosana > 0 [Enter]
    Arvosanat:
    0:**
    1:*
    2:*
    3:*
    4:*
    5:**

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Harjoitus14
    {
        public static void Harj14()
        {
            string lopetus;
            int arvosana = 0;
            int[] jakauma = new int[6];

            do
            {
                Console.Write("Anna arvosana: ");
                lopetus = System.Console.ReadLine();

                if (lopetus == "x")
                {
                    break;
                }

                try
                {
                    arvosana = Convert.ToInt32(lopetus);

                    switch (arvosana)
                    {
                        case 0:
                            jakauma[0]++;
                            break;

                        case 1:
                            jakauma[1]++;
                            break;

                        case 2:
                            jakauma[2]++;
                            break;

                        case 3:
                            jakauma[3]++;
                            break;

                        case 4:
                            jakauma[4]++;
                            break;

                        case 5:
                            jakauma[5]++;
                            break;
                    }
                }

                catch (FormatException e)
                {
                    Console.WriteLine("Anna numero väliltä 0-5. Lopetus = x");
                }

            } while (true);

            Console.WriteLine("Arvosanajakauma: ");

            for (int i = 0; i <= 5; i++)
            {
                Console.Write(i + ": ");

                for (int j = 0; j < jakauma[i]; j++)
                {
                    Console.Write("*");

                }

                Console.WriteLine();
            }
        }
    }
}

