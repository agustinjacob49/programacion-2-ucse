using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4Logica
{
    public class Cliente
    {
        private string nombre { get; set; }
        private string cuit { get; set; }
        public decimal saldo { get; set; }

        public Cliente(string nombre, string cuit, decimal saldo)
        {
            this.nombre = nombre;
            this.cuit = cuit;
            this.saldo = saldo;
        }

        public static Cliente operator -(Cliente a, Cliente b)
        {
            if (a.cuit == b.cuit)
            {
                return new Cliente("Cliente resta", "20-123456-20", a.saldo - b.saldo);
            } else
            {
                return new Cliente("Cliente resta", "20-123456-20", a.saldo < b.saldo ? a.saldo : b.saldo);
            }
        }

    }
}
