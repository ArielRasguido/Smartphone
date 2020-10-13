using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone
{
    public class AppBrowser: Aplicacion
    {
        public List<string> Busquedas = new List<string> { };
        public AppBrowser(string _nombre, string _icono, int _tamanio) : base(_nombre, _icono, _tamanio)
        {
        }

        public string BuscarPalabra()
        {
            Console.Write("Ingrese una palabra:");
            string palabra = Console.ReadLine();
            Busquedas.Add(palabra);
            return "Se encontro la palabra" + palabra;
        }   

        public bool BorrarHistorial()
        {
            Busquedas.Clear();
            return true;
        }

        public void VerHistorial()
        {
            foreach(var busqueda in Busquedas)
            {
                Console.WriteLine(busqueda);
            }
        }

        public override void Menu()
        {
            int op = 1;
            do
            {
                Console.Clear();
                MostrarTituloApp();
                Console.WriteLine("1. Buscar");
                Console.WriteLine("2. Ver Historial");
                Console.WriteLine("3. Borrar Historial");
                Console.WriteLine("0. Salir");
                Console.Write("Escoja una opcion:");
                op = Convert.ToInt16(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        BuscarPalabra();
                        break;
                    case 2:
                        VerHistorial();
                        break;
                    case 3:
                        BorrarHistorial();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            } while (op != 0);

        }
    }
}

