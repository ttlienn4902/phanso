using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            diem diem1 = new diem();
            diem1.nhap();
            diem1.xuat();
            diem diem2 = new diem();
            diem2.nhap();
            diem2.xuat();
            diem diem3 = new diem();
            diem3.kcach(diem1, diem2);
           diem3.xuattt();
            Console.ReadLine(); 
           

        }
    }
}
