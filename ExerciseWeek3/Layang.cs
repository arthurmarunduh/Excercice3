using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseWeek3
{
    
    public class Layang : Persegi
    {
        private double Luas, Keliling, Dpanjang, Dlebar, Lpanjang, Llebar;
        
        public void input()
        {
            Console.WriteLine("Layang-Layang");
            Console.WriteLine("masukan DalamPanjang : ");
            Dpanjang = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("masukan DalamLebar : ");
            Dlebar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("masukan luarMiring1 : ");
            Lpanjang = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("masukan luarMiring2 : ");
            Llebar = Convert.ToInt32(Console.ReadLine());
        }

        public void Hitung(double Value1, double Value2, double Value3, double Value4)
        {
            Luas = 0.5*(Value1 * Value2);
            Keliling = 2 * (Value3 + Value4);

        }
        public double GetLuas()
        {
            return Luas;
        }
        public double GetKeliling()
        {
            return Keliling;
        }
        public double GetDPanjang()
        {
            return Dpanjang;
        }
        public double GetDLebar()
        {
            return Dlebar;
        }
        public double GetLPanjang()
        {
            return Lpanjang;
        }
        public double GetLLebar()
        {
            return Llebar;
        }
    }
    
}
