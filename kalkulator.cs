using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Apliakasi Kalkulator";

            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.Write("\nInput Nomor Menu [1..4] : ");
            int menu = int.Parse(Console.ReadLine());

            Console.Write("Input Nilai a : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Input Nilai b : ");
            int b = int.Parse(Console.ReadLine());

            if(menu == 1)
            {
                Console.WriteLine("Hasil penambahan " + a + "+" + b + " = " + penambahan(a, b));
            }
            else if(menu == 2)
            {
                Console.WriteLine("Hasil pengurangan " + a + "-" + b + " = " + pengurangan(a, b));
            }
            else if(menu == 3)
            {
                Console.WriteLine("Hasil perkalian " + a + "*" + b + " = " + perkalian(a, b));
            }
            else if(menu == 4)
            {
                Console.WriteLine("Hasil pembagian " + a + "/" + b + " = " + pembagian(a, b));
            }
            else
            {
                Console.WriteLine("\nMaaf, menu yang Anda pilih tidak tersedia");
            }

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
