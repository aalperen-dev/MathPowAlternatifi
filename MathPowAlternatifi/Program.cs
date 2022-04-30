using System;

namespace MathPowAlternatifi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Math sınıfı metodlarından Math.Pow(2, 3) metodu ile aynı işlevdeki kendi metodunuzu yazın.
            //(Bu metot pozitif integer değerler için çalışsın ve içinde hiçbir Math sınıfından metot kullanılmasın.)

            //Math.Pow() üslü sayı hesabını yapan bit metot.
            //Math.Pow() kullanmadan üstü sayı hesabı yapabilmek için iki parametleri bir metot yazdım.
            //Bu metotun "sadece pozitif ve interger" değer ile çalışması için
            //taban ve üs olarak girilecek sayıların bu kurala uyup uymadığını sonsuz döngü ile kontrol ettim.

            Console.Write("Taban sayıyı girin: ");
            int taban = int.Parse(Console.ReadLine());
            while (true)
            {
                if (taban <= 0)
                {
                    Console.Write("Taban için POZİTİF bir sayı girin: ");
                    taban = int.Parse(Console.ReadLine());
                }
                else break;
            }
            Console.Write("Üs sayıyı girin: ");
            int us = int.Parse(Console.ReadLine());

            while (true)
            {
                if (us <= 0)
                {
                    Console.Write("Üs için POZİTİF bir sayı girin: ");
                    us = int.Parse(Console.ReadLine());
                }
                else break;
            }
            Console.WriteLine("Tabanı " + taban + " ve üssü " + us + " olan sayının değeri: " + UsAlma(taban, us));
        }

        static int UsAlma(int sayi1, int sayi2)
        {
            int sonuc = 1;
            for (int i = 1; i <= sayi2; i++)
            {
                sonuc = sonuc * sayi1;
            }
            return sonuc;
        }

    }
}

