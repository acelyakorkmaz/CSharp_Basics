using System;
using System.Collections.Generic;

namespace Generic_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            Console.WriteLine(sehirler.Count);
            
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("ankara");
            sehirler2.Add("ankara");
            sehirler2.Add("ankara");
            Console.WriteLine(sehirler2.Count);




            Console.ReadLine();
        }
        class MyList<T>//Generic Clas T tipinde çalışır
        {
            //T type verilen genel isim
            T[] _array;
            T[] _tempArray;
            public MyList()//ctor
            {
                _array = new T[0];
            }
            public void Add(T item)//T hangi tipi kullanırsan ona dönüşür
            {
                _tempArray = _array;
                _array = new T[_array.Length + 1];//elemn sayısını arttırma
                for (int i = 0; i < _tempArray.Length; i++)
                {
                    _array[i] = _tempArray[i];

                }
                _array[_array.Length - 1] = item;
            }

            

            public int Count
            {
                get { return _array.Length; }
                
            }

        }
    }
}
