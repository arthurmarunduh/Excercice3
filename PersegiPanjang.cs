using System;

public class Class1
{
    public class PersegiPanjang : Persegi
    {
        private double Luas, Keliling;
        public void Hitung(int Value1, int Value2)
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
    }
}
