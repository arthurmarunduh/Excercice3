using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseWeek3
{
    
    public class PersegiPanjang : Persegi
    {
        private double Luas, Keliling, panjang, lebar;
        
        public void input()
        {
            Console.WriteLine("Persegi Panjang");
            Console.WriteLine("masukan panjang : ");
            panjang = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("masukan lebar : ");
            lebar = Convert.ToInt32(Console.ReadLine());

        }

        public void Hitung(double Value1, double Value2)
        {
            Luas = Value1 * Value2;
            Keliling = 2 * (Value1 + Value2);

        }
        public double GetLuas()
        {
            return Luas;
        }
        public double GetKeliling()
        {
            return Keliling;
        }
        public double GetPanjang()
        {
            return panjang;
        }
        public double GetLebar()
        {
            return lebar;
        }
    }
    
}
