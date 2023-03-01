using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnMayorEdad
{ /// <summary>
/// Nombre: Laura Serena Rivera Mejía
/// Fecha: 24-02-2023
/// Descripción: Este programa identifica si eres mayor o menor de edad e imprime un mensaje por 
/// pantalla.
/// </summary>

    internal class ClsMayorEdad

    {   //Declaración de variables
        int Edad;
        string Nombre;
        static void Main(string[] args)
        {
            //Se crea un objeto de la Clase mayor edad
            ClsMayorEdad oMayorEdad = new ClsMayorEdad();
            //Se llaman los métodos a partir del objeto mayor edad
            oMayorEdad.SolicitarDatos();
            oMayorEdad.EvaluacionDatos();
            //Instrucción de espera al final de toda la ejecución.
            Console.ReadLine();


        }
        public void SolicitarDatos()
        {
            //Mensaje de salida
            Console.WriteLine("Por favor ingrese su edad");
            //Captura el dato de entrada
            Edad = int.Parse(Console.ReadLine());
            //Mensaje de salida
            Console.WriteLine("Por favor ingrese su nombre");
            //Captura el dato de entrada
            Nombre = Console.ReadLine();
        }

        //Método 2
        public void EvaluacionDatos()
        {
            //Ciclo lógico
            if (Edad < 18)
            {
                Console.WriteLine(Nombre + " eres menor de edad");
            }

            else if (Edad >= 18)
            {
                Console.WriteLine(Nombre + " eres mayor de edad");

            }
        }



    }
}
