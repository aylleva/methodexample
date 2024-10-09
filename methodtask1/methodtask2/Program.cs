using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;
using System.Xml;

namespace methodtask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cevrenin sahesi:");
            Console.WriteLine(Area(4.11));

            Console.WriteLine("duzbucaqlinin sahesi:");
            Console.WriteLine(Area(2.6f,5.8f));

            Console.WriteLine("paralepipedin sahesi:");
            Console.WriteLine(Area(23,54,76));

            Console.WriteLine("cevrenin sahesi:");
            Console.WriteLine(Area(3,7,5,6.5));
        }
        public static double  Area(double r)//cevrenin sahesi
        {
             
           double S = 0;
            int p = 3;
            S = p * r * r;

            return S;
        }
       public static float Area(float a,float b)//duzbucaqlinin sahesi
        {
            float S = 0;
            S = a * b;

            return S;
        }
        public static double Area(double a,double b,double c)//paralepipedin tam sethinin sahesi
        {
            double S = 0;
            S = 2 * (a * b + a * c + b * c);

            return S;
        }
        public static double Area(double a, double b, double c, double r)
        {
            double S = 0;
            double p = (a + b + c) / 2;
            S = p * r;

            return S;
        }
    }
}