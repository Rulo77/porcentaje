using System;


namespace porcentaje_hombres_y_mujeres
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, m, total, ph, pm;
            string entrada1, entrada2;
            Console.WriteLine("ingrese cantidad de hombres que hay en el grupo");
            entrada1 = Console.ReadLine();

            Console.WriteLine("ingrese cantidad de mujeres que hay en el grupo");
            entrada2 = Console.ReadLine();

            h = Convert.ToInt32(entrada1);
            m = Convert.ToInt32(entrada2);

            total = h + m;
            ph = h * 100 / total;
            pm = m * 100 / total;

            
            Console.WriteLine("el porcentaje de hombres es: {0} % y el de mujeres es: {1} %", ph,pm);
            Console.Read();

            
        }
    }
}
