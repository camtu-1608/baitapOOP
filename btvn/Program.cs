using System.Data;
using Internal;
using System;

namespace btvn
{
    class Program
    {
        static void Main(string[] args)
        {
            bai1 Bai1 = new bai1();
            ushort tuoi;

            Console.WriteLine("Nhap ten");
            name = Console.ReadLine();
            Bai1.setTen(name);
            Console.WriteLine("Nhap nam sinh");
            year = Console.Readline();
            Bai1.setNamsinh(year);

            tuoi= Bai1.setTuoi();
            Consle.WriteLine ("Hi {0}. Nam nay ban {1} tuoi", Bai1.ten, tuoi);

            Console.ReadKey();
        }
    }

    class bai1 
    {
        private string ten;
        private ushort namsinh;
        public void setTen (string name)
        {
            ten = name;
        }
        public void setNamsinh (ushort year)
        {
            namsinh = year;
        }
        public ushort setTuoi ()
        {
            return 2021 - year;
        }
    }
}
