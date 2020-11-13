using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseWeek3
{
    
    public class Segitiga : Persegi
    {
        private double Luas, Keliling, alas, tinggi, miring;
        
        public void input()
        {
            Console.WriteLine("Segitiga");
            Console.WriteLine("masukan alas : ");
            alas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("masukan tinggi : ");
            tinggi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("masukan miring : ");
            miring = Convert.ToInt32(Console.ReadLine());

        }

        public void Hitung(double Value1, double Value2, double Value3)
        {
            Luas = Value1 * Value2;
            Keliling = (Value1 + Value2 + Value3);

        }
        public double GetLuas()
        {
            return Luas;
        }
        public double GetKeliling()
        {
            return Keliling;
        }
        public double GetAlas()
        {
            return alas;
        }
        public double GetTinggi()
        {
            return tinggi;
        }
        public double GetMiring()
        {
            return miring;
        }
    }
    
}
