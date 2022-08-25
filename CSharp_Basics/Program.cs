using System;

namespace CSharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";

            
            Console.WriteLine(kategoriEtiketi);

            bool sitemeGirisYapmisMi = true;
            if (sitemeGirisYapmisMi==true)
            {
                Console.WriteLine("Hoşgeldiniz");

            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }
        }
    }
}
