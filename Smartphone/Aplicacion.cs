using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone
{
    public class Aplicacion
    {
        protected string _icono;
        protected int _tamanio;
        protected string _nombre;

        public Aplicacion(string _nombre,string _icono,int _tamanio)
        {
            this._nombre = _nombre;
            this._icono = _icono;
            this._tamanio = _tamanio;
        }

        public string MostrarIcono()
        {
            return _icono;
        }

        public void MostrarTituloApp()
        {
            Console.WriteLine("---------" + _nombre + " " + _icono + "---------");
        }

        public virtual void Menu()
        {

        }

    }
}
