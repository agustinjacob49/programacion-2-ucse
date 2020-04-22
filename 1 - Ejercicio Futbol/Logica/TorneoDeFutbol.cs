using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class TorneoDeFutbol
    {
        public List<Partido> Partidos { get; set; }

        public bool NuevoPartido(Arbitro arbitro, string ciudad, Equipo equipoLocal, Equipo equipoVisitante)
        {
            List<Arbitro> arbitros = new List<Arbitro>();
            arbitros.Add(arbitro);

            Partido nuevoPartido = new Partido()
            {
                Arbitros = arbitros,
                Ciudad = ciudad,
                EquipoLocal = equipoLocal,
                EquipoVisitante = equipoVisitante
            };

            this.Partidos = new List<Partido>();

            this.Partidos.Add(nuevoPartido);

            return true;
        }
    }
}
