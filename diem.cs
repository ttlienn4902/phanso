using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diem
{
    internal class diem
    {
        private double x; //Hoành độ
        private double y; //Tung độ
        
        public diem()
        {
            x = 0;
            y = 0;
        }
        public diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void nhap()
        {
            Console.WriteLine("nhap x:");
            x = Double.Parse(Console.ReadLine());
            Console.WriteLine("nhap y:");
            y = Double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("toa do:({0},{1}) ", x, y);
        }
        public double kcach(diem d1, diem d2)
        {
            
           double kc = new double();
           kc = Math.Sqrt(Math.Pow(d2.x - d1.x, 2) + Math.Pow(d2.y - d1.y, 2));
            ;
            return kc;
            
        }
        public void xuattt()
        {
            diem d1 = new diem();
            diem d2 = new diem();
            
double kc = Convert.ToDouble(kcach(d1,d2));
            Console.WriteLine("Khoarng casch giuwax 2 diem:{0}", kc);
            

            ;
        }
       
      
            
      
          
    }
}



