using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseWeek3
{
    
    public class BelahKetupat : Persegi
    {
        private double Luas, Keliling, sisi1, Diagonal1, DIagonal2;
        
        public void input()
        {
            Console.WriteLine("Layang-Layang");
            Console.WriteLine("masukan sisi1 : ");
            sisi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("masukan Diagonal1 : ");
            Diagonal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("masukan Diagonal2 : ");
            DIagonal2 = Convert.ToInt32(Console.ReadLine());
        }

        public void Hitung(double Value1, double Value2, double Value3)
        {
            Luas = 0.5*(Value1 * Value2);
            Keliling = 4 * (Value3);

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
            return sisi1;
        }
        public double Diagonal()
        {
            return Diagonal1;
        }
        public double Diagonal2()
        {
            return DIagonal2;
        }
    }
    
}
