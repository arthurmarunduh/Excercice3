using ExerciseWeek3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseWeek3_Arthur
{
    class Program
    {
        static void Main(string[] args)
        {
            int acc;
            int counter = 1;
            do
            {
                Console.WriteLine("1. Persegi \n" +
                "2. Persegi Panjang \n" +
                "3. Segitiga \n" +
                "4. Layang-Layang \n" +
                "5. Belah Ketupat \n" +
                "6. exit");
                Console.Write("pilih menu : ");
                acc = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("------------------------");
                

                switch (acc)
                {
                    case 1:
                        try
                        {
                            // bangun datar 1 -> persegi
                            Persegi persegi = new Persegi();

                            persegi.input();

                            persegi.Hitung(persegi.GetSisi());
                            Console.WriteLine("Luas : " + persegi.GetLuas());
                            Console.WriteLine("Keliling : " + persegi.GetKeliling() + "\n");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                        break;

                    case 2:
                        try
                        {
                            // bangun datar 2 -> persegi panjang
                            PersegiPanjang persegiPanjang = new PersegiPanjang();

                            persegiPanjang.input();

                            persegiPanjang.Hitung(persegiPanjang.GetPanjang(), persegiPanjang.GetLebar());
                            Console.WriteLine("Luas : " + persegiPanjang.GetLuas());
                            Console.WriteLine("Keliling : " + persegiPanjang.GetKeliling() + "\n");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                        break;

                    case 3:
                        try
                        {
                            // bangun datar 3 -> segitiga
                            Segitiga segitiga = new Segitiga();

                            segitiga.input();

                            segitiga.Hitung(segitiga.GetAlas(), segitiga.GetTinggi(), segitiga.GetMiring());
                            Console.WriteLine("Luas : " + segitiga.GetLuas());
                            Console.WriteLine("Keliling : " + segitiga.GetKeliling() + "\n");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                        break;

                    case 4:
                        try
                        {
                            // bangun datar 4 -> Layang-Layang
                            Layang layang = new Layang();

                            layang.input();

                            layang.Hitung(layang.GetDLebar(), layang.GetDPanjang(), layang.GetLLebar(), layang.GetLPanjang());
                            Console.WriteLine("Luas : " + layang.GetLuas());
                            Console.WriteLine("Keliling : " + layang.GetKeliling() + "\n");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                        break;

                    case 5:
                        try
                        {
                            // bangun datar 5 -> Layang-Layang
                            BelahKetupat belahKetupat = new BelahKetupat();

                            belahKetupat.input();

                            belahKetupat.Hitung(belahKetupat.Diagonal(), belahKetupat.Diagonal2(), belahKetupat.GetSisi());
                            Console.WriteLine("Luas : " + belahKetupat.GetLuas());
                            Console.WriteLine("Keliling : " + belahKetupat.GetKeliling() + "\n");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                        break;
                    case 6:
                        counter = 0;
                        Console.WriteLine("EXIT");
                        break;
                }
                Console.WriteLine("------------------------");
            } while (counter == 1);
        }
    }
}
