using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UAS
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Makanan makanan;

        Console.WriteLine();
            makanan = new Soto();
        makanan.deskripsi();

            Console.WriteLine();
            makanan = new Gudeg();
        makanan.deskripsi();

            Console.WriteLine();
            makanan = new SateKlatak();
        makanan.deskripsi();

            Console.ReadKey();
        }
}
}