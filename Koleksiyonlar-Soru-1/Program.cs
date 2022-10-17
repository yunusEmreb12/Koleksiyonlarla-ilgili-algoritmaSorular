using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
            // (ArrayList sınıfını kullanara yazınız.)
            // Negatif ve numeric olmayan girişleri engelleyin.
            // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.  

            ArrayList asalSayi = new ArrayList();
            ArrayList AsalOlmayan = new ArrayList();
            Regex desen = new Regex("^[0-9]*$");
            
            int sayac = 1;
            while (sayac<21)
            {
                Console.Write($"{sayac}. Sayıyı giriniz:");
                string sayi = Console.ReadLine();
                if ( !desen.IsMatch(sayi) || (Convert.ToInt32(sayi) < 0)) 
                {
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz: Sayı sıfırdan büyük ve harf içermememlidir. ");                    
                }
                else
                {
                    int sayi1 = Convert.ToInt32(sayi);
                    int sonuc = Asalmi(sayi1);
                    if (sonuc == 0)
                    {
                        AsalOlmayan.Add(sayi1);
                        sayac++;                        
                    }
                    else
                    {
                        asalSayi.Add(sayi1);
                        sayac++;                        
                    }                    
                }
            }
            int asalTop = 0;
            int asalDegilTop = 0;
            asalSayi.Sort();
            AsalOlmayan.Sort();
            Console.WriteLine();

            Console.WriteLine("***** Asal Sayılar *****");
            foreach (int item in asalSayi)
            {
                Console.WriteLine(item);
                asalTop = asalTop + item;
            }
            Console.WriteLine();
            Console.WriteLine("***** Asal olmayan Sayılar *****");
            foreach (int item in AsalOlmayan)
            {
                Console.WriteLine(item);
                asalDegilTop = asalDegilTop + item;
            }
           
            Console.WriteLine($"Klavyeden Toplamda {asalSayi.Count} asal sayı girilmiştir");
            Console.WriteLine($"Klavyeden toplamda {AsalOlmayan.Count} asal olmayan sayı girilmiştir");
            Console.WriteLine($"Asal sayı ortalaması: {asalTop / asalSayi.Count} ");
            Console.WriteLine($"Asal olmayan sayı Ortalaması: {asalDegilTop / AsalOlmayan.Count} ");
        }

        private static int Asalmi(int sayi)
        {
            int i;
            for (i = 2; i <= sayi - 1; i++)
            {
                if (sayi % i == 0)
                    return 0;
            }

            if (i == sayi)
            {
                return 1;
            }
            return 0;
        }    
    }
  
}