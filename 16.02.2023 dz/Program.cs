using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._02._2023_dz
{
    internal class Program
    {
        struct TridimensionalVector
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; set; }
            public TridimensionalVector(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }
            public void MultValueVector(int a) { X *= a; Y *= a; Z *= a; }
            public static TridimensionalVector operator +(TridimensionalVector a, TridimensionalVector b)
            {
                TridimensionalVector v = new TridimensionalVector();
                v.X = a.X + b.X;
                v.Y = a.Y + b.Y;
                v.Z = a.Z + b.Z;
                return v;
            }
            public static TridimensionalVector operator -(TridimensionalVector a, TridimensionalVector b)
            {
                TridimensionalVector v = new TridimensionalVector();
                v.X = a.X - b.X;
                v.Y = a.Y - b.Y;
                v.Z = a.Z - b.Z;
                return v;
            }
        }
        struct Decimalnumber
        {
            public int value { get; set; }
            public Decimalnumber(int value) { this.value = value; }
            public void ToBinary()
            {
                Console.WriteLine("{0}", Convert.ToString(value, 2));
            }
            public void ToSixteen()
            {
                Console.WriteLine("{0}", Convert.ToString(value, 16));
            }
        }
        class RGB
        {
            public byte Red { get; set; }
            public byte Green { get; set; }
            public byte Blue { get; set; }
            public RGB(byte red, byte green, byte blue)
            {
                Red = red;
                Green = green;
                Blue = blue;
            }
            public void ConvertToHEX()
            {
                Console.Write("#");
                Console.Write("{0}", Convert.ToString(Red, 16));
                Console.Write("{0}", Convert.ToString(Green, 16));
                Console.Write("{0}", Convert.ToString(Blue, 16));
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            RGB color =  new RGB(255, 255,255);
            color.ConvertToHEX();
        }
    }
}
