using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4_1302200104
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Penjumlahan.JumlahTigaAngka<double>(13, 22, 04)
        }
    }
    public class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T Q, T W, T E)
        {
            dynamic TemptA = Q;
            dynamic TemptB = W;
            dynamic TemptC = E;

            Console.WriteLine(Q + W + E);
        }
    }
}