using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Program
    {
        static void Main()
        {
            Console.Write("Nhap phan so thu nhat duoi dang a/b: ");
            Fractional r = new Fractional(Console.ReadLine());
            Console.WriteLine("Hien thi phan so(Da rut gon):" + r);
            Console.Write("Nhap phan so thu hai duoi dang a/b: ");
            Fractional s = new Fractional(Console.ReadLine());
            Console.WriteLine("Hien thi phan so(Da rut gon): " + s); 
            Console.WriteLine(" Cong hai phan so: " + (r + s));
            Console.WriteLine(" Tru hai phan so: " + (r - s));
            Console.WriteLine(" Nhan hai phan so: " + r * s);
            Console.WriteLine("Chia hai phan so: " + r / s);
            Console.ReadKey();
        }
    }

