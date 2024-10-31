using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaDeHoyHallowen
{
    internal class Estudiante
    {
        int[] edades = new int[0];
        int posicion = 0;
        string seguir;

        public void insertar()
        {
            do
            {
                

                int ed;
                Console.WriteLine("Ingresa una edad: ");

                while (!int.TryParse(Console.ReadLine(), out ed) || ed < 14 || ed > 120)
                {
                    Console.WriteLine("Error: Ingrese otra vez: ");
                }
                Array.Resize(ref edades, edades.Length + 1);
                edades[posicion] = ed;
                posicion++;
                Console.WriteLine("Edad ingresada correctamente");
                Console.Write("\nDesea seguir registrando: ");
            } while (seguir == "si");
        }
        public void mostrar()
        {
            Console.SetCursorPosition(10, 12);
            Console.Write("Position");
            Console.SetCursorPosition(30, 12);
            Console.Write("EDADES");
            for(int i= 0; i< edades.Length; i++)
            {
                Console.SetCursorPosition(10, 13+i);
                Console.Write(i);
                Console.SetCursorPosition(30, 13+i);
                Console.Write(edades[i]);


            }

        }
        public void eliminar(int ed1)
        {
            int indice = Array.IndexOf(edades, ed1);
            if(indice != -1)
            {
                for (int i = indice; i < edades.Length-1; i++)
                {
                    edades[i] = edades[i + 1];
                }
                Array.Resize(ref edades, edades.Length-1);
                posicion--;
                Console.Write("\nEliminado correctamente");
            }
            else
            {
                Console.WriteLine("\nNo se puede eliminar Porque no existe");
            }
        
        }

    }
}
