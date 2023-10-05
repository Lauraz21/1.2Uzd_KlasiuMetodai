using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2Uzd_KlasiuMetodai
{
    public class Rectangle
    {
        public double Heigth { get; set; }
        public double Width { get; set; }



        public double Perimeter() 
        {
            double sum = Heigth + Width;
            double per = sum * 2;
            return per;

        }
        public double Area()
        {
            double area = Heigth * Width;
            return area;
        }
    }
}
