using System;

namespace Classes_n_Structures_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    
    class Pen
    {
        public string color;
        public int cost;

        public Pen()
        {
            color = "black";
            cost = 100;
        }

        public Pen(string penColor,int penCost)
        {
            color = penColor;
            cost = penCost;
        }
    }

    class Rectangle
    {
        public int a;
        public int b;
        public Rectangle()
        {
            a = 6;
            b = 4;
        }
        public Rectangle(int side)
        {
            a = side;
            b = side;
        }
        public Rectangle(int first, int second)
        {
            a = first;
            b = second;
        }
        public int Square()
        {
            return a * b;
        }         
       
    }
}
