using System;

namespace baimau
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            do
            {
                Console.WriteLine("Moi nhap so bai tap ban muon xem (neu muon thoat vui long nhap 'quit'):");
                response = Console.ReadLine();
                Console.Clear();
                switch (response)
                {
                    case "6":
                        bai6 Bai6 = new bai6();
                        ushort year;

                        Console.WriteLine("Nhap nam sinh");
                        year = ushort.Parse(Console.ReadLine());
                        
                        Bai6.setNamsinh(year);
                        Bai6.setTuoi();

                        break;

                    case "7":
                        bai7 Bai7 = new bai7();
                        ushort height;
                        ushort weight;

                        Console.WriteLine("Nhap chieu cao:");
                        height = ushort.Parse(Console.ReadLine());

                        Console.WriteLine("Nhap can nang:");
                        weight = ushort.Parse(Console.ReadLine());

                        Bai7.setNhap(height, weight);
                        Bai7.tinhBMI();

                        break;

                    case "8":
                        bai8 Bai8 = new bai8();
                        byte ao;

                        Console.WriteLine("Nhap so luong ao can mua:");
                        ao = byte.Parse(Console.ReadLine());

                        Bai8.setAo(ao);
                        Bai8.tinhTien();

                        break;

                    case "9":
                        bai9 Bai9 = new bai9();
                        int time;

                        Console.WriteLine("Nhap so gio do xe:");
                        time = int.Parse(Console.ReadLine());
                        
                        Bai9.setTime(time);
                        Bai9.tinhTien();

                        break;

                    case "10":
                        bai10 Bai10 = new bai10();
                        float diem1, diem2, diem3;

                        Console.WriteLine("Nhap dtb nam 1:");
                        diem1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap dtb nam 2:");
                        diem2 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap dtb nam 3:");
                        diem3 = float.Parse(Console.ReadLine());

                        Bai10.setDiem(diem1, diem2, diem3);
                        Bai10.tinhDiem();

                        break;
                    case "11":
                        bai11 Bai11 = new bai11();
                        int mb;

                        Console.WriteLine("Nhap so MB:");
                        mb = int.Parse(Console.ReadLine());

                        Bai11.setMB(mb);
                        Bai11.tinhTien();

                        break;
                }
            } while (response != "quit");

        }
    }
    class bai6
    {
        private ushort namsinh;
        private int tuoi;
        public void setNamsinh(ushort year)
        {
            namsinh = year;
        }
        public void setTuoi()
        {
            tuoi = 2021 - namsinh;
            if (tuoi >= 18)
                Console.WriteLine("du tuoi lai xe");
            else
                Console.WriteLine("chua du tuoi lai xe");

        }
    }

    class bai7
    {
        private ushort height;
        private ushort weight;
        public double BMI;
         
        public void setNhap(ushort h, ushort w)
        {
            height = h;
            weight = w;
        }
        public void tinhBMI()
        {
            BMI = weight / (Math.Pow(height*0.01, 2));
            if (BMI < 18.5)
                Console.WriteLine("gay");
            else if (BMI <= 24.9)
                Console.WriteLine("can doi");
            else if (BMI <= 29.9)
                Console.WriteLine("Thua can");
            else if (BMI <= 34.9)
                Console.WriteLine("beo phi cap 1");
            else if (BMI <= 39.9)
                Console.WriteLine("beo phi cap 2");
            else
                Console.WriteLine("bao phi cap 3");
        }
    }

    class bai8
    {
        public int ao;
        public double tien;
        public void setAo(int a)
        {
            ao = a;
        }
        
        public void tinhTien()
        {
            if (ao < 5)
            {
                tien = 200000 * ao;
            }
            else if (ao == 5)
            {
                tien = 200000 * ao;
                ao+=1;
            }
            else 
            {
                tien = 200000 * 5 + (ao - 5) * 180000;
                ao = ao + (ao / 5);  
            }
            Console.WriteLine("so tien phai tra la: {0}, so luong ao nhan duoc: {1}", tien, ao);
        }
    }

    class bai9
    {
        public int time;
        public int tien;

        public void setTime(int t)
        {
            time = t;
        }
        public void tinhTien()
        {
            if (time<=3)
            {
                tien = 40000;
            }    
            else if (time <=24)
            {
                tien = 40000 + (time - 3) * 10000;
            }    
            else
            {
                tien = 200000;
            }
            Console.WriteLine("So tien phai tra cho {0}h la: {1}", time, tien);
        }
    }
    class bai10
    {
        public float diem1;
        public float diem2;
        public float diem3;

        public void setDiem(float d1, float d2, float d3)
        {
            diem1 = d1;
            diem2 = d2;
            diem3 = d3;
        }

        public void tinhDiem()
        {
            float diemtb = (diem1 + diem2 + diem3) / 3;
            float diem12 = (diem1 + diem2) / 2;
            float diem23 = (diem2 + diem3) / 2;
            float diem13 = (diem1 + diem3) / 2;
            if (diemtb >= 8.5)
            {
                Console.WriteLine("Ban nhan duoc 1 chiec laptop");
            }
            else if (diem12 >= 8.5 || diem23 >= 8.5 || diem13 >= 8.5)
            {
                Console.WriteLine("Ban nhan duoc 1 chiec xe dap");
            }
            else if (diemtb >= 6.5)
            {
                Console.WriteLine("Ban nhan duoc 1 chiec balo");
            }
            else
            {
                Console.WriteLine("Co gang lan sau");
            }
        }
    }

    class bai11
    {
        public int mb;
        public int tien;

        public void setMB(int MB)
        {
            mb = MB;
        }

        public void tinhTien()
        {
            if (mb <= 500)
            {
                tien = mb * 60;
            }
            else if (mb <= 850)
            {
                tien = 30000 + (mb - 500) * 55;
            }
            else if (mb <= 1100)
            {
                tien = 49250 + (mb - 850) * 45;
            }
            else if (mb <= 1300)
            {
                tien = 60500 + (mb - 1100) * 30;
            }
            else
            {
                tien = 66500 + (mb - 1300) * 15;
            }
            Console.WriteLine("so tien phai tra cho {0}MB la: {1}", mb, tien);
        }
    }
}
