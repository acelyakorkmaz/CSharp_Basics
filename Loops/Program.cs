using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım1";
            string kurs2 = "Yazılım2";


            string[] kurslar = new string[] { "Yazılım1", "Yazılım2", "C#" };



            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.ReadLine();

        }

        
    }
}
