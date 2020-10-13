using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone
{
    public abstract class AparatoElectronico
    {
        protected string _modelo;
        protected string _marca;
        protected double _tamaño;
        public string Color { get; set; }

        protected AparatoElectronico(string _modelo, string _marca)
        {
            this._modelo = _modelo;
            this._marca = _marca;
        }

        protected abstract void prender();
        protected abstract void Apagar();
        protected abstract void Reiniciar();

    }
}
