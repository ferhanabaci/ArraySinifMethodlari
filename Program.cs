using System;

namespace array_sınıf
{
    class Program
    {
        static void Main(string[] args)
        {
            // sort yani sıralama islemi
            int[] sayiDizisi={23,12,4,86,72,3,11,17};
            Console.WriteLine("***** sırasız dizi***");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("***** Sıralı dizi***");
            Array.Sort(sayiDizisi);
             foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            // clear dizide verdiğiniz indexten baslayrak verdiginiz eleman sayısı kadar sıfırlıyor
            Console.WriteLine("**** Array Clear*****");
            // sayıdizisi elamanları kullanarak ikinci den itibaren 2 tane eleman 0lar.
            Array.Clear(sayiDizisi,2,2);

             foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            //Reverse verdiğimiz değişkeni aynalıyormus gibi yer degistiriyor
            Array.Reverse(sayiDizisi);
            Console.WriteLine("**** Array Reverse*****");

             foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //IndexOf
            Console.WriteLine("*****Array Indexof");
            Array.IndexOf(sayiDizisi,23);
            
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));
            //Resize yeniden boyutlandırma
            Console.WriteLine("**** Array Resize*****");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=99;
            foreach (var sayi in sayiDizisi)
            {   
                Console.WriteLine(sayi);
                
            }


            

    
        }
    }
}
