using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone
{
    public interface ITelefono
    {
        void llamar();
        string colgar();
        string sonar();
        string vibrar();
    }
}
