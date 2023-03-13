using System;

namespace CalculatorMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            string ulang = "";
            do
            {

                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Penjumlahan");
                Console.WriteLine("2. Pengurangan");
                Console.WriteLine("3. Penrkalian");
                Console.WriteLine("4. Pembagian");
                Console.Write("Pilih Menu: ");
                int menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        pertambahan();
                        break;

                    case 2:
                        pengurangan();
                        break;

                    case 3:
                        perkalian();
                        break;

                    case 4:
                        pembagian();
                        break;
                    default: 
                        Console.WriteLine("Tidak ada di menu");
                        break;
                }
                Console.Write("\nApakah anda ingin menghitung lagi? (Y / N): ");
                ulang = Console.ReadLine();
                string hr = String.Concat(Enumerable.Repeat("=", 45));
                Console.WriteLine(hr);
            } while (ulang == "y" || ulang == "Y");
            Console.WriteLine("!!SELESAI!!".PadLeft(28));
        }
        static void pertambahan()
        {
            Console.Write("\nAngka pertama: ");
            decimal pertama = Convert.ToInt32(Console.ReadLine());
            Console.Write("Angka kedua: ");
            decimal kedua = Convert.ToInt32(Console.ReadLine());

            decimal hasil = pertama + kedua;
            Console.WriteLine($"{pertama} + {kedua} = {hasil}");
        }
        static void pengurangan()
        {
            Console.Write("\nAngka pertama: ");
            decimal pertama = Convert.ToInt32(Console.ReadLine());
            Console.Write("Angka kedua: ");
            decimal kedua = Convert.ToInt32(Console.ReadLine());

            decimal hasil = pertama - kedua;
            Console.WriteLine($"{pertama} - {kedua} = {hasil}");
        }
        static void perkalian()
        {
            Console.Write("\nAngka pertama: ");
            decimal pertama = Convert.ToInt32(Console.ReadLine());
            Console.Write("Angka kedua: ");
            decimal kedua = Convert.ToInt32(Console.ReadLine());

            decimal hasil = pertama * kedua;
            Console.WriteLine($"{pertama} * {kedua} = {hasil}");
        }
        static void pembagian()
        {
            Console.Write("\nAngka pertama: ");
            decimal pertama = Convert.ToInt32(Console.ReadLine());
            Console.Write("Angka kedua: ");
            decimal kedua = Convert.ToInt32(Console.ReadLine());

            decimal hasil = pertama / kedua;
            Console.WriteLine($"{pertama} / {kedua} = {hasil}");
        }

    }
}