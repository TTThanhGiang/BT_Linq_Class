using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Linq_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = 'e';
            while (c == 'E' || c == 'e')
            {
                Menu();
                Console.WriteLine("\nNhap e/E de tro ve Menu va phim bat ky de ket thuc");
                c = Convert.ToChar(Console.ReadLine());
            }
            Console.ReadLine();
        }
        public static void Menu()
        {
            Console.WriteLine("---------Menu---------");
            Console.WriteLine("1. Tao danh sach cac Car");
            Console.WriteLine("2. Tao danh sach cac Truck");
            Console.WriteLine("Nhap lua chon: ");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    List<Car> dscars = new List<Car>
                    {
                        new Car("Bugatti","Bugatti V16",2024,"Black",1100000,2,true),
                        new Car("Bugatti","Chiron Super Sport 300+",2019,"Black",3100000,2,true),
                        new Car("Toyota","Camry 2.0G",2021,"Silver",150000,4,true),
                        new Car("Rolls-Royce","Phantom VI",1968,"Red",700000,4,true),
                        new Car("VinFast","VF 5 Plus",2022,"Black",200000,4,true)
                    };
                    Console.WriteLine("Danh sach cac Car: ");
                    foreach (var xe in dscars)
                    {
                        Console.WriteLine(xe.ToString());
                    }
                    char c = 'y';
                    while (c == 'Y' || c == 'y')
                    {
                        SubMenuCar(dscars);
                        Console.WriteLine("\nNhap y/Y de tro ve SubMenu va phim bat ky de ve Menu");
                        c = Convert.ToChar(Console.ReadLine());
                    }
                    break;
                case 2:
                    List<Truck> dstrucks = new List<Truck>()
                    {
                        new Truck("Toyota", "Hino", 2019, "White", 320000, 10, true, "Cong ty TNHH Toyota Viet Nam"),
                        new Truck("Hyundai", "HD78", 2022, "Blue", 144000, 8, true, "Cong ty Co phan O to Hyundai Thanh Cong"),
                        new Truck("Thaco", "Fuso", 2023, "Yellow", 400200, 5, false, "Tap doan Thaco"),
                        new Truck("Isuzu", "QKR", 2017, "Red", 433000, 3, false, "Cong ty TNHH Isuzu Viet Nam")
                    };
                    Console.WriteLine("Danh sach cac Truck :");
                    foreach (var xe in dstrucks)
                    {
                        Console.WriteLine($"{xe.manufacturer} {xe.name} - {xe.year} - {xe.weight} tan - {xe.price} - {xe.companyName}");
                    }
                    char d = 'y';
                    while (d == 'Y' || d == 'y')
                    {
                        SubMenuTruck(dstrucks);
                        Console.WriteLine("\nNhap y/Y de tro ve SubMenu va phim bat ky de ve Menu");
                        c = Convert.ToChar(Console.ReadLine());
                    }
                    break;
            }
        }
        public static void SubMenuCar(List<Car> dscar)
        {
            Console.WriteLine("-------------------------SubMenu-------------------------");
            Console.WriteLine("1. Hien thi cac xe co gia trong khoang 100.000 den 250.000");
            Console.WriteLine("2. Cac xe co nam san xuat > 1990");
            Console.WriteLine("3. Gom cac xe theo hang san xuat, tinh tong gia tri theo nhom");
            Console.WriteLine("Chon: ");
            int lc = Convert.ToInt32(Console.ReadLine());
            switch (lc)
            {
                case 1:
                    var dsxe1 = dscar.Where(car => car.price > 100000 && car.price < 200000);
                    Console.WriteLine("\nDanh sach cac xe co gia tu 100000 den 200000:\n---");
                    foreach (var c in dsxe1)
                    {
                        Console.WriteLine($"{c.manufacturer} {c.name} - {c.price}");
                    }
                    break;
                case 2:
                    var dsxe2 = dscar.Where(car => car.year > 1990);
                    Console.WriteLine("\nDanh sach cac xe san xuat sau nam 1990:\n---");
                    foreach (var c in dsxe2)
                    {
                        Console.WriteLine($"{c.manufacturer} {c.name} - {c.year}");
                    }
                    break;
                case 3:
                    var dsxe3 = dscar
                        .GroupBy(car => car.manufacturer)
                        .Select(group => new
                        {
                            manufacturer = group.Key,
                            Total = group.Sum(car => car.price)
                        });
                    foreach (var c in dsxe3)
                    {
                        Console.WriteLine(c.ToString());
                    }
                    break;
            }
        }
        public static void SubMenuTruck(List<Truck> dstruck)
        {
            Console.WriteLine("-------------------------SubMenu-------------------------");
            Console.WriteLine("1. Hien thi danh sach xe theo thu tu nam san xuat moi nhat");
            Console.WriteLine("2. Hien thi ten cong ty chu quan cua Truck");
            Console.WriteLine("Chon: ");
            int lc = Convert.ToInt32(Console.ReadLine());
            switch (lc)
            {
                case 1:
                    var dsxetai1 = dstruck.OrderByDescending(truck => truck.year);
                    Console.WriteLine("\nDanh sach cac xe theo thu tu nam san xuat moi nhat:\n---");
                    foreach (var t in dsxetai1)
                    {
                        Console.WriteLine($"{t.manufacturer} {t.name} - {t.year}");
                    }
                    break;
                case 2:
                    Console.WriteLine("\nHien thi ten cong ty chu quan cua Truck:\n---");
                    foreach (var t in dstruck)
                    {
                        Console.WriteLine($"{t.manufacturer} {t.name} - {t.companyName}");
                    }
                    break;
            }
        }
    }
}
