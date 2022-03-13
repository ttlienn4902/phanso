using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mang1chieu
{
    internal class mang
    {
        private int n; //Số phần tử của mảng
        int[] a; //Mảng 1 chiều
        public mang(int n)
        {
            this.n = n;
        }
        public void nhap()
        {
            Console.WriteLine("nhap so phan tu cua mang:");
            n=int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("nhap phan tu thu  i:",i);
                a[i]=int.Parse(Console.ReadLine());
            }
        }
        public void xuat()
        {
            for(int i=0;i<n;i++)
            Console.WriteLine("MANG a gom:{0}",a[i]);


        }
        public void sapxep(int thutu)
        {
            for(int i=0;i<n;i++)
            {    
                for(int j=i+1;j<n;j++)
            {
                    int r;
                    thutu = 0;
                    if (a[i] < a[j])
                    {
                          r=a[i];
                        a[i]=a[j];
                        a[j]=r;

                    }
                    if(thutu!=0)
                    {
                        r = a[j];
                        a[j]=a[i];
                        a[i] = r;
                    }    
                        


            }
            }

        }
         public int timkiem(int m)
        {
            m=int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                if (a[i] == m) return m = i;
                else return m = -1;
            }  
            return m;
        }
        
    }
}
