using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     class HCN
    {
        private float Dai, Rong;
        public float ChuVi()
        {

            return (Dai + Rong) * 2;

        }
        public float DienTich()
        {

            return Dai * Rong;

        }
        public void Nhap()
        {

            Console.WriteLine("Nhap chieu dai: ");
            Dai = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            Rong = float.Parse(Console.ReadLine());

        }
        public void XUAT()
        {
            Console.WriteLine("CHIEU DAI HCN:{0};CRONG HCN:{1};CHU VI HCN{2};S HCN:{3}",Dai,Rong,ChuVi(),DienTich());
        }

    }
}
