/* **************************************
Harjoitus 19

Luotu 11.1.2017

Toiminta: Tee tekstipohjainen Hirsipuu-peli. Voit kovakoodata arvattavan sanan ja toteuta 
looppi, jossa käyttäjältä kysytään seuraavaa kirjainta. Muista näyttää aina kirjaimen 
jälkeen oikein arvatut kirjaimet sanan oikealla kohdalla (käytä esim _-alaviivaa ei 
arvattujen kirjainten kohdalla). Voit näyttää myös jo arvatut ei käytetyt -kirjaimet. 
Päätä itse milloin pelaaja joutuu hirteen.

Arvattava sana tässä pelissä on 'koulu'.

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Harjoitus19
    {
        public static void Harj19()
        {
            int kierros = 1, i = 0, k = 0;
            char[] sana = new char[5] { '_', '_', '_', '_', '_' };
            char[] arvattu = new char[10];
            char arvaus;

            Console.WriteLine("* * * * * * * H I R S I P U U * * * * * * * ");
            Console.WriteLine("Arvaa sana kirjaimia yksitellen syöttämällä.");
            Console.WriteLine("Viidestä väärästä arvauksesta peli päättyy.");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * ");
            Console.WriteLine();

            do
                {
                    Console.Write("Arvattava sana : ");
                    for (i = 0; i < sana.Length; i++)
                    {
                        Console.Write(sana[i] + " ");
                    }

                    Console.WriteLine();
                    Console.Write("Arvatut kirjaimet: ");
                    for (i = 0; i < arvattu.Length; i++)
                    {
                        Console.Write(arvattu[i] + " ");
                    }

                    Console.WriteLine();
                    Console.Write("Anna kirjain : ");
                    arvaus = Console.ReadKey().KeyChar;

                    arvattu[k] = arvaus;
                    k++;

                if (arvaus == 'k' || arvaus == 'K')
                    {
                        sana[0] = 'k';
                        Console.Clear();
                    }

                else if (arvaus == 'o' || arvaus == 'O')
                    {
                        sana[1] = 'o';
                        Console.Clear();
                    }

                else if (arvaus == 'u' || arvaus == 'U')
                    {
                        sana[2] = 'u';
                        sana[4] = 'u';
                        Console.Clear();
                    }

                else if (arvaus == 'l' || arvaus == 'L')
                    {
                        sana[03] = 'l';
                        Console.Clear();
                    }

                else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Väärin meni, " + kierros + " väärää arvausta käytetty.");
                        kierros++;
                        Console.Clear();
                }

                string testi = new string(sana);
                if (testi == "koulu")
                {
                    Console.WriteLine("ONNEKSI OLKOON! Arvasit sanan 'koulu'.");
                    break;
                }

            } while (kierros <= 5);

            if (kierros == 6)
            {
                Console.WriteLine("Et tällä kertaa arvannut sanaa, parempi onni ensi kerralla!");
            }

            Console.WriteLine();
        }
    }
}

