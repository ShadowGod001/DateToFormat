using System;

namespace Library
{   

    public class DateFormat
    {   

        // Se cambia el formato de la fecha invirtiendo la misma y agregando guiones.

        public static string DateToOneFormat(string cadena) 
        {   
            string fecha = cadena.Substring(6)+ "-" +cadena.Substring(3,2)+ "-" +cadena.Substring(0,2);
            if (VerifyDigits(fecha) || VerifyLength(fecha))
            {
                fecha = "00-00-00";
            }
            return fecha; 
        }   

        // Se cambia el formato de la fecha a la misma con guiones.

        public static string DateToAnotherFormat(string cadena) 
        {   
            string fecha = cadena.Substring(0,2)+ "-" +cadena.Substring(3,2)+ "-" +cadena.Substring(6);
            if (VerifyDigits(fecha) || VerifyLength(fecha))
            {
                fecha = "00-00-00";
            }
            return fecha;
        }

        // Se verifica que el largo de la cadena sea correcto.

        public static bool VerifyLength(string cadena)
        {
            return cadena.Length!=10;
        }  

        // Se verifica que la cadena tenga la cantidad correcta de numeros y guiones.

        public static bool VerifyDigits(string cadena) 
        {
            int contadorNum = 0;
            int contadorGuion = 0;

            foreach (var item in cadena)
            {
                if (char.IsNumber(item))
                {
                    contadorNum += 1;
                }
                else if (item.ToString() == "-")
                {
                    contadorGuion += 1;
                }
            }

            return !(contadorNum == 8 && contadorGuion == 2);


        }


    
    }

}