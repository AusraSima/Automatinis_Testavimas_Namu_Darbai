using System;

namespace Uzduotis13__zalias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Testas "zalias", jei 995 dalijasi is 3 be liekanos

            switch (Tikrinimas.Dalyba(995, 3))
            {
                case 0:
                    Console.WriteLine("Zalias, skaicius 995 dalijasi is 3 be liekanos");
                    break;
                default:
                    Console.WriteLine("Test 'Zalias' failed");
                    Console.WriteLine("Skaicius 995 is 3 be liekanos nesidalija");
                    break;
            }

            //Testas “žalias” jeigu šiandien trečiadienis 

            //    if (Tikrinimas.SavaitesDiena(DayOfWeek) == DayOfWeek.Wednesday.ToString())  // Wednesday = treciadienis
            //    {
            //        Console.WriteLine("Zalias - siandien yra treciadienis");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Test 'Zalias' failed, today is {DayOfWeek}");
            //    }
            //    Console.WriteLine();

            //    //Testas “žalias” jeigu dabar yra 13h 

            //    if (Tikrinimas.Valanda(DateTime) == "13:00")
            //    {
            //        Console.WriteLine("Zalias");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Test 'Zalias' failed, now it is {DateTime}");
            //    }
            //    Console.WriteLine();

            //    //Bonus: Testas “žalias” jei nuo 1 iki 10 (imtinai) yra 4 lyginiai skaičiai

            int kiekis = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (Tikrinimas.Dalyba(i, 2) == 0)
                {
                    kiekis++;
                }
            }
            if (kiekis == 4)
            {
                Console.WriteLine("Zalias, intervale nuo 1 iki 10 imtinai yra 4 lyginiai skaiciai");
            }
            else
            {
                Console.WriteLine("Test 'Zalias' failed");
                Console.WriteLine($"Intervale nuo 1 iki 10 imtinai yra {kiekis} lyginiai skaiciai");
            }
            Console.WriteLine();
        }

        public class Tikrinimas
        {
            public static double Dalyba(int skaicius1, int skaicius2)
            {
                return (double)skaicius1 % skaicius2;
            }

            //public static string SavaitesDiena(DayOfWeek)
            //{
            //    return DateTime.Today.DayOfWeek.ToString();
            //}
            //public static string Valanda(DateTime)
            //{
            //    return DateTime.Now.ToString("h:mm tt");
            //}
        }
    }
}
