using System;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
            // her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.
            //(Array sınıfını kullanarak yazınız.)

            int[] numbers = new int[20];
            int[] lowNumbers = new int[3];
            int[] toUpperNumbers = new int[3];

            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine($"{i}. sayiyi giriniz: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(numbers);
            lowNumbers[0] = numbers[0];
            lowNumbers[1] = numbers[1];
            lowNumbers[2] = numbers[2];

            int toplam = 0;

            Console.WriteLine("Küçük Sayilar");
            foreach (var lowNu in lowNumbers)
            {
                Console.WriteLine(lowNu);
                toplam += lowNu;
            }
            Console.WriteLine($"küçük sayilarin toplami: " + toplam);
            Console.WriteLine($"küçük sayilarin ortalamasi: " + toplam/3);

            toUpperNumbers[0] = numbers[0];
            toUpperNumbers[1] = numbers[1];
            toUpperNumbers[2] = numbers[2];

            int toplam2 = 0;

            Console.WriteLine("Küçük Sayilar");
            foreach (var toUpp in lowNumbers)
            {
                Console.WriteLine(toUpp);
                toplam2 += toUpp;
            }
            Console.WriteLine($"küçük sayilarin toplami: " + toplam2);
            Console.WriteLine($"küçük sayilarin ortalamasi: " + toplam2/3);
        }
    }
}
