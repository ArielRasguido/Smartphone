using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Smartphone
{
    public class AppLlamadas : Aplicacion, ITelefono
    {
        private List<string> llamadas = new List<string>{};
        public AppLlamadas(string _nombre,string _icono,int _tamanio) : base(_nombre,_icono,_tamanio)
        {
        }

        public string colgar()
        {
            return "Se terminó la llamada";
        }

        public void llamar()
        {
            DateTime today = DateTime.Today;
            string llamada = today.ToString("dd/MM/yyyy") + "Llamada" + llamadas.Count+1;
            llamadas.Add(llamada);
        }

        public string sonar()
        {
            return "El telefono esta sonando...";
        }

        public string vibrar()
        {
            return "El telefono esta vibrando...";
        }

        public override void Menu()
        {
            int op = 1;
            do
            {
                Console.Clear();
                MostrarTituloApp();
                Console.WriteLine("1. Realizar llamada");
                Console.WriteLine("2. Sonar");
                Console.WriteLine("3. Vibrar");
                Console.WriteLine("0. Salir");
                Console.Write("Escoja una opcion:");
                op= Convert.ToInt16(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Llamando..");
                        llamar();
                        Thread.Sleep(1000);
                        Console.WriteLine(colgar());
                        break;
                    case 2:
                        Console.WriteLine(sonar());
                        break;
                    case 3:
                        Console.WriteLine(vibrar());
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
