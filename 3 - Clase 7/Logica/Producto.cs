using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public abstract class Producto
    {
        protected string modelo { get; set; }
        protected string marca { get; set; }
        protected double numeroSerie { get; set; }

        public string identificador { get; }

        public Producto(string _modelo, string _marca, double _numeroDeSerie)
        {
            this.modelo = _modelo;
            this.marca = _marca;
            this.numeroSerie = _numeroDeSerie;
            this.identificador = _modelo + _marca + _numeroDeSerie;
        }

        public abstract string ObtenerDescripcion();

    }
}
