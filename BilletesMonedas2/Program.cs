using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bille = new int[7] { 500, 200, 100, 50, 20, 10, 5 };
            double[] mone = new double[5] { 0.50, 0.25, 0.10, 0.05, 0.01 };
            int[] cantidadBilletes = new int[7];
            int[] cantidadMonedas = new int[5];
            decimal importe;

            Console.Write("Ingrese su importe: $ ");
            importe = Convert.ToDecimal(Console.ReadLine());

            for (int i = 0; i < bille.Length; i++)
            {
                while (importe >= bille[i])
                {
                    importe = importe - bille[i];
                    cantidadBilletes[i] = cantidadBilletes[i] + 1;
                    if (importe < bille[i])
                        Console.WriteLine("Cantidad de billetes " + bille[i] + ":" + cantidadBilletes[i]);
                }
            }

            for (int j = 0; j < mone.Length; j++)
            {
                while (importe >= Convert.ToDecimal(mone[j]))
                {
                    importe = importe - Convert.ToDecimal(mone[j]);
                    cantidadMonedas[j] = cantidadMonedas[j] + 1;
                    if (importe < Convert.ToDecimal(mone[j]))
                        Console.WriteLine("Cantidad de monedas " + mone[j] + ":" + cantidadMonedas[j]);
                }
            }

            Console.Read();
        }
    }
}
