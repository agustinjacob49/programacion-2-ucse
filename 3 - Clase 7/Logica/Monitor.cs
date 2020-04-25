using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Monitor : Producto
    {
        private int anioFabricacion;
        private int? pulgadas;

        public Monitor(string _modelo, string _marca, double _numeroDeSerie, int anioFabricacion, int pulgadas) : base(_modelo, _marca, _numeroDeSerie)
        {
            this.anioFabricacion = anioFabricacion;
            this.pulgadas = pulgadas;
        }

        public bool esNuevo()
        {
            return this.anioFabricacion == DateTime.Now.Year;
        }

        public override string ObtenerDescripcion()
        {
            return $"MONITOR {marca} - {modelo} {pulgadas}";
        }
    }
}
