using System;

namespace BaiTapTuan3
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            do
            {
                Console.WriteLine("Moi nhap so bai tap ban muon xem (neu muon thoat vui long nhap 'q'):");
                response = Console.ReadLine();
                Console.Clear();
                switch (response)
                {
                    case "13":
                        bai13 Bai13 = new bai13();
                        int n;

                        Console.WriteLine("Moi nhap so nguyen to N:");
                        n = int.Parse(Console.ReadLine());

                        Bai13.setN(n);
                        Bai13.chayYC();
                        break;
                    case "14":
                        bai14 Bai14 = new bai14();
                        int N;

                        Console.WriteLine("Moi nhap so nguyen to N:");
                        N = int.Parse(Console.ReadLine());

                        Bai14.setN(N);
                        Bai14.chayYC();
                        break;
                    case "15":
                        bai15 Bai15 = new bai15();
                        Bai15.inSodo();
                        break;
                    case "16":
                        bai16 Bai16 = new bai16();
                        Bai16.troChoi();
                        break;
                }
            } while (response != "q");

        }
    }

    class bai13
    {
        public int n;

        public void setN(int N)
        {
            n = N;
        }

        static void Yeucau1(int N)
        {
            int i;
            for (i = 1; i <= N; i++)
            {
                Console.Write("{0},", i);
                //i = i + 1;
            }
        }
        static void Yeucau2(int N)
        {
            int i;
            for (i = 1; i >=N; i++)
            {
                Console.Write("{0},", i);
                //i = i + 1;
            }
        }

        static void Yeucau3(int N)
        {
            int i;
            for (i = N; i >= 1; i--)
            {
                if (i % 2 == 1) { 
                Console.Write("{0},", i);
                //i = i + 1;
                }
            }
        }

        static void Yeucau4(int N)
        {
            int i;
            for (i = N; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0},", i);
                    //i = i + 1;
                }
            }
        }

        public void chayYC()
        {
            string res;
            do
            {
                Console.WriteLine("Moi nhap so yeu cau (neu muon thoat nhap q):");
                res = Console.ReadLine();
                Console.Clear();
                switch (res)
                {
                    case "1":
                        Yeucau1(n);
                        break;
                    case "2":
                        Yeucau2(n);
                        break;
                    case "3":
                        Yeucau3(n);
                        break;
                    case "4":
                        Yeucau4(n);
                        break;
                }
            } while (res != "q");
        }
    }

    class bai14
    {
        public int n;

        public void setN(int N)
        {
            n = N;
        }

        public void Yeucau1(int N)
        {
            int kq = 1;
            for (int i = 1; i <= N; i++)
            {
                kq *= i; 
            }
            Console.WriteLine("Giai thua cua {0} la: {1}", N, kq);
        }

        public void Yeucau2(int N)
        {
            int kq = 1;
            int t = 0;
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    kq *= j;
                }
                t = t + kq;
                kq = 1;
            }
            Console.WriteLine("Tong cac giai thua tu 1 den {0} la: {1}", N, t);
        }

        public void Yeucau3(int N)
        {
            int dem = 0;
            for (int i = 1; i <= N; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    dem += 1; 
                }
            }
            Console.WriteLine("So luong so nguyen chia het cho 3 va 7 trong pham vi tu 1-{0} la: {1}",N, dem);
        }

        public void chayYC()
        {
            string res;
            do
            {
                Console.WriteLine("Moi nhap so yeu cau (neu muon thoat nhap q):");
                res = Console.ReadLine();
                Console.Clear();
                switch (res)
                {
                    case "1":
                        Yeucau1(n);
                        break;
                    case "2":
                        Yeucau2(n);
                        break;
                    case "3":
                        Yeucau3(n);
                        break;
                }
            } while (res != "q");
        }
    }

    class bai15
    {
        public void inSodo()
        {
            Console.WriteLine("SO DO CHO NGOI".PadLeft(64));
            Console.WriteLine("".PadRight(115, '='));
            Console.WriteLine("MAN HINH".PadLeft(61));
            Console.WriteLine("".PadRight(115, '='));

            for (char i='A'; i <= 'K'; i++)
            {
                Console.Write(i+"".PadRight(7));
                for (int j = 1; j <= 12; ++j)
                {
                    string a = Convert.ToString(j);
                    Console.Write("[" + a.PadLeft(2, '0') + "]".PadRight(6)); ;
                }
                Console.WriteLine("\n");
            }
        }
    }

    class bai16
    {
        public void troChoi()
        {

            Random r = new Random();
            byte gia = (byte)r.Next(1, 11); 
            int nhap;
            byte diem = 10, dem = 0;

            Console.Write("Nhap gia doan: ");
            do
            {
                nhap = int.Parse(Console.ReadLine());
                if (nhap > gia)
                {
                    Console.WriteLine("Gia ban nhap dang cao hon. Nhap lai: ");
                    dem++;
                    diem--;

                }
                else if (nhap < gia)
                {
                    Console.WriteLine("Gia ban nhap dang thap hon. Nhap lai: ");
                    dem++;
                    diem--;
                }
                else
                {

                }
            } while (nhap != gia);

            Console.WriteLine("Ban da doan gia dung. Diem ban co duoc {0}. So lan doan sai: {1}", diem, dem);
        }
    }
}
