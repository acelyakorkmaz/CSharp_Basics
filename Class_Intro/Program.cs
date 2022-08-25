using System;

namespace Class_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.IzlenmeOrani = "60";
            kurs1.Egitmen = "Açelya Korkmaz";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.IzlenmeOrani = "55";
            kurs2.Egitmen = "Engin Demiroğ";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python#";
            kurs3.IzlenmeOrani = "100";
            kurs3.Egitmen = "Ada Uysal";

            //Console.WriteLine(kurs1.Egitmen + " " + kurs1.KursAdi);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public string IzlenmeOrani { get; set; }
        }
       
    }
   
}
