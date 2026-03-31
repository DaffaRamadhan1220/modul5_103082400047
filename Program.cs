using System;

namespace modul5_103082400047
{
    
    public class Penjumlahan
    {
        public T JumlahTigaAngka<T>(T a, T b, T c)
        {
            dynamic angka1 = a;
            dynamic angka2 = b;
            dynamic angka3 = c;
            return angka1 + angka2 + angka3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            

            int angka1 = 10;
            int angka2 = 82;
            int angka3 = 47;

            Penjumlahan penjumlahan = new Penjumlahan();
            int hasil = penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);

            Console.WriteLine($"Hasil penjumlahan {angka1} + {angka2} + {angka3} = {hasil}");
            Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }
    }
}