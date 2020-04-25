using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Computadora : Producto
    {
        private string descripcionProcesador;
        private CapacidadMemoria capacidadMemoria;
        private string fabricante;

        public Computadora(string _modelo, string _marca, double _numeroDeSerie, string _descripcionProcesador, CapacidadMemoria _capacidadMemoria, string _fabricante) : base(_modelo, _marca, _numeroDeSerie)
        {
            this.descripcionProcesador = _descripcionProcesador;
            this.capacidadMemoria = _capacidadMemoria;
            this.fabricante = _fabricante;
        }

        public override string ObtenerDescripcion()
        {
            return $"PC {modelo} - {marca} - {descripcionProcesador} {capacidadMemoria} RAM - {fabricante}";
        }
    }
}
