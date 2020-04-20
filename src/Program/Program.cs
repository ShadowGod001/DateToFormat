using System;

namespace EjercicioCambioFecha
{
    class Program
    {
        public static void Main(string[] args)
        {   
            string test_date = "10/11/1977";
            Console.WriteLine($"{test_date} se convierte a: {Library.DateFormat.DateToOneFormat("10/11/1977")}");
        } 
    }
}

