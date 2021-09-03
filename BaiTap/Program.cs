using System;

namespace BaiTap
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
                    case "1":
                        bai1 Bai1 = new bai1();
                        int tuoi;
                        int tuoi25;
                        ushort year;
                        string name;

                        Console.WriteLine("Nhap ten");
                        name = Console.ReadLine();
                        //Bai1.setTen(name);
                        Console.WriteLine("Nhap nam sinh");
                        year = ushort.Parse(Console.ReadLine());
                        Bai1.setNamsinh(year);

                        tuoi = Bai1.setTuoi();
                        tuoi25 = Bai1.setTuoinam2025();
                        Console.WriteLine("Hi {0}. Nam nay ban {1} tuoi. Tuoi vao nam 2025 cua ban se la {2}", name, tuoi, tuoi25);

                        Console.ReadKey();
                        break;
                    case "2":
                        bai2 Bai2 = new bai2();
                        double luong;
                        double luongThuviec;

                        Console.WriteLine("Nhap luong");
                        luong = double.Parse(Console.ReadLine());
                        Bai2.setLuong(luong);

                        luongThuviec = Bai2.setTinhLuong();
                        Console.WriteLine("Muc luong thu viec la: {0}", luongThuviec);
                        break;
                    case "3":
                        bai3 Bai3nu = new bai3();
                        bai3 Bai3nam = new bai3();
                        byte slNam;
                        byte slNu;
                        byte siSo;
                        int tile_Nam;
                        int tile_Nu;

                        Console.WriteLine("Nhap so luong nam");
                        slNam = byte.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap so luong nu");
                        slNu = byte.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap si so lop");
                        siSo = byte.Parse(Console.ReadLine());

                        Bai3nu.setSL(slNu);
                        Bai3nu.setSS(siSo);
                        tile_Nu = Bai3nu.setPercent();

                        Bai3nam.setSL(slNam);
                        Bai3nam.setSS(siSo);
                        tile_Nam = Bai3nam.setPercent();

                        Console.WriteLine("Ti le nam la {0}%, ti le nu la {1}%", tile_Nam, tile_Nu);
                        break;
                    case "4":
                        bai4 Bai4 = new bai4();
                        byte siso;
                        byte vang;
                        int tile_Vang;
                        int tile_cc;

                        Console.WriteLine("Nhap si so lop");
                        siso = byte.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap so HS vang:");
                        vang = byte.Parse(Console.ReadLine());

                        Bai4.setSL(vang);
                        Bai4.setSS(siso);
                        tile_Vang = Bai4.setPercentv();
                        tile_cc = Bai4.setPercenth();
                        Console.WriteLine("Ti le chuyen can: {0}%, ti le vang: {1}%", tile_cc, tile_Vang);
                        break;
                    case "5":
                        bai5 Bai5 = new bai5();
                        byte kihan;
                        double soTien;
                        double lai;
                        double tong;

                        Console.WriteLine("Nhap so tien gui");
                        soTien = double.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap ki han");
                        kihan = byte.Parse(Console.ReadLine());

                        Bai5.setKyhan(kihan);
                        Bai5.setTiengui(soTien);

                        lai = Bai5.setLai();
                        tong = Bai5.setTong();
                        Console.WriteLine("Lai suat hang thang: {0:F0}. Tong tien gui sau ki han: {1:F0}", lai, tong);
                        break;
                    default:
                        break;
                }    
            } while (response != "quit");

        }
    }
    class bai1
    {
        private ushort namsinh;
        public void setNamsinh(ushort year)
        {
            namsinh = year;
        }
        public int setTuoi()
        {
            return 2021 - namsinh;
        }
        public int setTuoinam2025()
        {
            return 2025 - namsinh;
        }
    }
    class bai2
    {
        private double luong;
        public void setLuong(double salary)
        {
            luong = salary;
        }
        public double setTinhLuong()
        {
            return (luong * 85) / 100;
        }
    }

    class bai3
    {
        private byte soluong;
        private byte siSo;
        public void setSL(byte sl)
        {
            soluong = sl;
        }
        public void setSS(byte ss)
        {
            siSo = ss;
        }
        public int setPercent()
        {
            return (soluong * 100) / siSo;
        }
    }
    class bai4
    {
        private byte vang;
        private byte siSo;
        public void setSS(byte ss)
        {
            siSo = ss;
        }
        public void setSL(byte miss)
        {
            vang = miss;
        }
        
        public int setPercentv()
        {
            return (vang * 100) / siSo;
        }
        public int setPercenth()
        {
            return ((siSo-vang) * 100) / siSo;
        }
    }
    class bai5
    {
        private double tiengui;
        private byte kihan;
        public void setTiengui(double money)
        {
            tiengui = money;
        }
        public void setKyhan(byte kh)
        {
            kihan = kh;
        }

        public double setLai()
        {
            return (tiengui * 0.07) / 12;
        }
        public double setTong()
        {
            return (tiengui + ((tiengui * 0.07) / 12)* kihan);
        }
    }
}
