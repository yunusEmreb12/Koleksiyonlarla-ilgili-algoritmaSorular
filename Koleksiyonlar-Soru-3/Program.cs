using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan 
            //ve dizinin elemanlarını sıralayan programı yazınız.

            ArrayList vowel = new ArrayList();
            Console.WriteLine("Lütfen bir cümle giriniz:");

            char[] harf = (Console.ReadLine().ToCharArray());
            foreach (char x in harf)
            {
                if(x == 'a' || x == 'e' || x == 'ı' || x == 'i' || x == 'o' || x == 'ö' || x == 'u' || x == 'ü' )
                {
                    vowel.Add(x);
                }
            }

            vowel.Sort();
            foreach (var item in vowel)
            {
                Console.WriteLine(item);
            }
        }
    }
}
