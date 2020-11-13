using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseWeek3
{
    
    public class Persegi
    {
        private double Luas,Keliling, sisi;
        
        public void input()
        {
            Console.WriteLine("Persegi");
            Console.WriteLine("masukan sisi : ");
            sisi = Convert.ToInt32(Console.ReadLine());

        }

        public void Hitung(double Value1)
        {
            Luas = Value1 * Value1;
            Keliling = 4 * Value1;
            
        }
        public double GetLuas()
        {
            return Luas;
        }
        public double GetKeliling()
        {
            return Keliling;
        }
        public double GetSisi()
        {
            return sisi;
        }
    }
    
}
