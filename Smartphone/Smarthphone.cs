using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Smartphone
{
    public class Smarthphone : AparatoElectronico
    {
        private int _codigoIMEI;

        private int _resolucionPantalla;

        private string _sistemaOperativo;

        private bool _encendido;

        AppLlamadas DefaulAppLlamadas;

        AppBrowser DefaultBrowser;

        public List<Aplicacion> Aplicaciones = new List<Aplicacion> { };


        public int NumeroCelular { get; set; }


        public Smarthphone(string modelo,string marca) :base(modelo,marca)
        {
            DefaulAppLlamadas = new AppLlamadas("Llamadas","LlamadasAPP",40);
            Aplicaciones.Add(DefaulAppLlamadas);
            DefaultBrowser = new AppBrowser("Chrome","Logo De Chrome",50);
            Aplicaciones.Add(DefaultBrowser);
            _codigoIMEI = new Random().Next(0, 100);
            _resolucionPantalla = 1080;
            _sistemaOperativo = "Android";
            _encendido = true;
        }


        public void MostrarAplicaciones()
        {
            for (int i = 0; i < Aplicaciones.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + Aplicaciones[i].MostrarIcono());
            }
        }

        public void MostrarPantallaInicio()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("---------"+_marca +" "+_modelo+"---------");
                Console.WriteLine("1. Llamar");
                Console.WriteLine("2. Mostrar Aplicaciones");
                Console.WriteLine("3. Instalar Aplicacion");
                Console.WriteLine("4. Reiniciar");
                Console.WriteLine("5. Apagar");
                Console.Write("Escoja una opcion:");
                int op = Convert.ToInt16(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        DefaulAppLlamadas.Menu();
                        break;
                    case 2:
                        MostrarAplicaciones();
                        break;
                    case 3:
                        InstalarAplicaciones();
                        break;
                    case 4:
                        Reiniciar();
                        break;
                    case 5:
                        Apagar();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            } while (_encendido);

        }

        public void InstalarAplicaciones()
        {
            Console.Write("Ingrese el nombre de la App a instalar:");
            string nombreApp = Console.ReadLine();
            Aplicaciones.Add(new Aplicacion(nombreApp,nombreApp,40));
        }

        protected override void prender()
        {
            Console.WriteLine(_marca+"...");
            Thread.Sleep(1000);
            Console.WriteLine("Caragando sistema operativo"+_sistemaOperativo+"...");
            Thread.Sleep(1000);
            Console.WriteLine("¡¡BIENVENIDO!!");
            Thread.Sleep(1000);
            Console.Clear();
            MostrarPantallaInicio();
        }

        protected override void Apagar()
        {
            Console.WriteLine("Cerrando Aplicaciones...");
            Console.WriteLine("Apagando el telefono...");
            _encendido = false;
        }

        protected override void Reiniciar()
        {
            Console.Clear();
            Console.WriteLine("Cerrando Aplicaciones...");
            Console.WriteLine("Reiniciando...");
            Thread.Sleep(2000);
        }
    }
}

