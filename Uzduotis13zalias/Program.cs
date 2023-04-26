using System;

namespace Uzduotis13zalias
{
    public class Program
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
                    break;
            }
            Console.WriteLine();

            //Testas “žalias” jeigu šiandien trečiadienis 

            if (Tikrinimas.SavaitesDiena() == DayOfWeek.Wednesday.ToString())  // Wednesday = treciadienis
            {
                Console.WriteLine("Zalias - siandien yra treciadienis");
            }
            else
            {
                Console.WriteLine($"Test 'Zalias' failed");
            }
            Console.WriteLine();

            //    //Testas “žalias” jeigu dabar yra 13h 

            if (Tikrinimas.Valanda() == "13:00")
            {
                Console.WriteLine("Zalias");
            }
            else
            {
                Console.WriteLine($"Test 'Zalias' failed");
            }
            Console.WriteLine();

            //Bonus: Testas “žalias” jei nuo 1 iki 10 (imtinai) yra 4 lyginiai skaičiai

            if (Tikrinimas.ArKeturi() == true)
            {
                Console.WriteLine("Zalias, intervale nuo 1 iki 10 imtinai yra 4 lyginiai skaiciai");
            }
            else
            {
                Console.WriteLine("Test 'Zalias' failed");
            }
            Console.WriteLine();
        }
        public class Tikrinimas
        {
            public static double Dalyba(int skaicius1, int skaicius2)
            {
                return (double)skaicius1 % skaicius2;
            }
            public static string SavaitesDiena()
            {
                return DateTime.Today.DayOfWeek.ToString();
            }
            public static string Valanda()
            {
                return DateTime.Now.ToString("h:mm tt");
            }
            public static bool ArKeturi()
            {
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
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
