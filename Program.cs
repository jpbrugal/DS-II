using System;

namespace primera
{
    class Program
    {
        static void Main(string[] args)
        {
            int vOp;
            Console.WriteLine("Digite el sueldo bruto: ");
            vOp = Convert.ToInt32(Console.ReadLine());

            double AFP, ISR, SSF, total, neto;

            AFP = vOp * 0.09;
            ISR = vOp * 0.07;
            SSF = vOp * 0.10;
            total = AFP + ISR + SSF;
            neto = vOp - total;
            
            Console.Clear();
            Console.WriteLine("DESCUENTO SALARIO");
            Console.WriteLine();
            Console.WriteLine("Sueldo bruto: " + vOp);
            Console.WriteLine();
            Console.WriteLine("Descuento AFP: " + AFP);
            Console.WriteLine("Descuento ISR: " + ISR);
            Console.WriteLine("Descuento SSF: " + SSF);
            Console.WriteLine();
            Console.WriteLine("El sueldo neto es: " + neto);

            
        }
    }
}
