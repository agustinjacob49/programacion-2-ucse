using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Deposito
    {
        private List<Producto> productos;

        public void agregarProducto(Monitor monitor)
        {
            //EVENTO ? 
            productos.Add(monitor);
        }

        public void agregarProducto(Computadora computadora)
        {
            //EVENTO ? 
            productos.Add(computadora);
        }

        public void eliminarProducto(string identificador)
        {
            Producto prod = productos.Find(p => p.identificador == identificador);
            if (prod != null)
            {
                productos.Remove(prod);
            }

        }

        public List<string> obtenerListaProducto()
        {
            List<string> listaDescripcion = new List<string>();
            productos.ForEach(producto => listaDescripcion.Add(producto.ObtenerDescripcion()));
            listaDescripcion.Sort();

            return listaDescripcion;
        }

    }
}
