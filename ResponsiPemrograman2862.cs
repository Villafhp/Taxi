using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Nama : Villa Febrianti Halisah Putri");
        Console.WriteLine("NIM  : 19.11.2862");
        Console.WriteLine("");

        Karyawan karyawan1 = new Karyawan();
        Karyawan karyawan2 = new Karyawan();
        Karyawan karyawan3 = new Karyawan();

        karyawan1.No = 1;
        karyawan1.Nik = 12349732;
        karyawan1.Nama = "Villa";
        karyawan1.Gaji = 2300000;

        karyawan2.No = 2;
        karyawan2.Nik = 77489020;
        karyawan2.Nama = "Ulala";
        karyawan2.Gaji = 4300000;

        karyawan3.No = 3;
        karyawan3.Nik = 19887726;
        karyawan3.Nama = "Tralala";
        karyawan3.Gaji = 5300000;

        Console.WriteLine("No NIK/Nama \t\tGaji Bulanan");
        Console.WriteLine("--------------------------------------");
        karyawan1.InfoKaryawan();
        karyawan2.InfoKaryawan();
        karyawan3.InfoKaryawan();
        Console.WriteLine("");
        Console.WriteLine("Asyiiiikkkk kenaikan gaji 10% !");
        Console.WriteLine("");
        Console.WriteLine("No NIK/Nama \t\tGaji Bulanan");
        Console.WriteLine("--------------------------------------");
        karyawan1.BonusGaji();
        karyawan2.BonusGaji();
        karyawan3.BonusGaji();
    }
    public class Karyawan
    {
        public int No { get; set; }
        public int Nik { get; set; }
        public string Nama { get; set; }
        public int Gaji { get; set; }



        public void InfoKaryawan()
        {
            if (Gaji < 0)
            {
                Gaji = 0;
            }

            Console.WriteLine("{0}. {1}/{2}\t{3}        ", No, Nik, Nama, Gaji);

        }

        public void BonusGaji()
        {
            if (Gaji < 0)
            {
                Gaji = 0;
            }

            Console.WriteLine("{0}. {1}/{2}\t{3}        ", No, Nik, Nama, Gaji * 0.1 + Gaji);

        }


    }
}