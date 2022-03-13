using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class phanso
    {
        static void Main(string[] args)
        {
            Class1 ps1 = new Class1();
            Class1 ps2 = new Class1();
            Class1 ps3 = new Class1();
            Class1 ps4 = new Class1();
            Class1 ps5 = new Class1();
            Class1 ps6 = new Class1();
            Class1 ps7 = new Class1();
            Class1 ps8 = new Class1();
            Console.WriteLine(" ttin ps1:");
            
            ps1.nhap();
            
           
            ps1=ps1.RutGonPhanSo();
            ps1.intt();
            
            Console.WriteLine("nhap ttin ps2:");
            
            ps2.nhap();
            
            ps2=ps2.RutGonPhanSo();
            ps2.intt();
           
            ps3 = ps3.tinhtong( ps1,  ps2);
            ps3.intt();
            ps4 = ps4.tinhhieu( ps1,ps2);
            ps4.intt();
            ps5 = ps5.tinhtich(ps1,ps2);
            ps5.intt();
            ps6 = ps6.tinhthuong(ps1,ps2)
                ;
            ps6.intt();
            Console.ReadLine();
            




        }
    }
}
