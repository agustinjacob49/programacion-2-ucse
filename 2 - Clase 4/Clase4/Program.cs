using Clase4Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";
            Console.WriteLine("Ej 1 - Contador de palabras");
            Console.WriteLine("Texto : " + text);
            Console.WriteLine("Total palabras : " + text.countWords());
            Console.WriteLine("Presione enter para continuar");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ej 2 - Contador de palabras con separador");
            Console.WriteLine("Texto : " + text);
            Console.WriteLine("Ingrese un separador");
            Char separator = Console.ReadLine().ToCharArray()[0];
            Console.WriteLine("Total palabras : "+ text.countWords(separator));
            Console.WriteLine("Presione enter para continuar");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ej 3 - Diferencia entre fechas");
            DateTime fecha1 = DateTime.Today;
            DateTime fecha2 = DateTime.Today.AddMinutes(-37);
            fecha2 = fecha2.AddSeconds(15);
            Console.WriteLine("Fecha 1 " + fecha1);
            Console.WriteLine("Fecha 2 " + fecha2);
            Console.WriteLine("Diferencia en minutos: " + fecha1.differenceInMinutes(fecha2));
            Console.WriteLine("Presione enter para continuar");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ej 4 - Lista de enteros y promedio");
            List<int> listaEnteros = new List<int>();
            listaEnteros.Add(1);
            listaEnteros.Add(4);
            listaEnteros.Add(5);
            listaEnteros.Add(4);
            listaEnteros.Add(6);
            listaEnteros.Add(2);
            listaEnteros.Add(7);

            Console.WriteLine("Promedio: " + listaEnteros.averageValue());
            Console.WriteLine("Presione enter para continuar");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ej 5 - Multiplicacion de pares y resta de impares");
            Console.WriteLine("Resultado: " + listaEnteros.pairsValuesMultiplyNonPairs());
            Console.WriteLine("Presione enter para continuar");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ej 6 - Fecha a partir de string");
            Console.WriteLine("Ingrese una fecha en formato MES DD, AAA");
            Console.WriteLine("Si se produce un error, se retornara un valor minimo");
            string dateNonCasted = Console.ReadLine();
            Console.WriteLine("Resultado: " + dateNonCasted.toDateTime());
            Console.WriteLine("Presione enter para continuar");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ej 7 - Invertir string");
            Console.WriteLine("Ingrese una oracion");
            string oracionInvertida = Console.ReadLine();
            Console.WriteLine("Resultado: " + oracionInvertida.reverseString());
            Console.WriteLine("Presione enter para continuar");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ej 8 - Concatenar lista de strings");
            List<string> listaOraciones = new List<string>();
            listaOraciones.Add("Crear un método de");
            listaOraciones.Add("extensión que retorne una fecha en formato");
            listaOraciones.Add("DateTime a partir de un string");
            listaOraciones.Add("si se genera una excepción por mal formato retornar el MinValue del tipo de datos");
            Console.WriteLine("Ingrese un separador");
            Char separatorList = Console.ReadLine().ToCharArray()[0];
            Console.WriteLine("Resultado: " + listaOraciones.concatStringValues(separatorList));
            Console.WriteLine("Presione enter para continuar");
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("Ej 9 - Saber si un string es un mail valido");
            Console.WriteLine("Ingrese un string");
            string emailAValidar = Console.ReadLine();
            Console.WriteLine("Resultado: " + emailAValidar.isEmail());
            Console.WriteLine("Presione enter para continuar");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ej 10 - Sobrecarga de operadores");
            Cliente cliente1 = new Cliente("Agustin", "2040774549", 125);
            Cliente cliente2 = new Cliente("Pepito", "2040774549", 110);
            Cliente cliente3 = cliente1 - cliente2;
            Console.WriteLine("Resultado: " + cliente3.saldo);
            Console.WriteLine("Presione enter para continuar");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ej 11 - transformar temperaturas");
            decimal temperaturaCelsius = 24;
            Console.WriteLine("Resultado: " + temperaturaCelsius.toCelsius());
            Console.WriteLine("Presione enter para continuar");
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("Ej 12 - resta");
            int numero1 = 24;
            int numero2 = 10;
            Console.WriteLine("Resultado: " + numero1.diff(numero2));
            Console.WriteLine("Presione enter para continuar");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
