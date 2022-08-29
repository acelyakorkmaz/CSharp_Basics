using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            //Difference between list and array = the size of the array cant be changed,
            //it can be added to or removed from the list.
            
            
            
            //string[] isimler = new string[] { "Ali", "Veli", "Ayşe", "Fatma" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            List<string> isimler2 = new List<string> { "Ali", "Veli", "Ayşe", "Fatma" };
            Console.WriteLine(isimler2[0]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            
        }
    }
}
