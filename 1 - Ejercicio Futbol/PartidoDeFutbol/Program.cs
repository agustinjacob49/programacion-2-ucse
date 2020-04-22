using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartidoDeFutbol
{
    class Program
    {
        static void Main(string[] args)
        {

            TorneoDeFutbol superliga = new TorneoDeFutbol();
            Arbitro laverni = new Arbitro();
            laverni.Edad = 50;
            laverni.Nacionalidad = "Argentino";
            laverni.Nacionalidad = "Argentino";
            laverni.Nombre = "Saul Laverni";
            string ciudad = "La Plata";

            Equipo estudiantes = GetLocal();
            Equipo gimnasia = GetVisitante();

            if (superliga.NuevoPartido(laverni, ciudad, estudiantes, gimnasia))
            {
                Console.WriteLine("Se juega el clasico de la plata");

                Tarjeta primerPolemica = new Tarjeta(gimnasia.Jugadores.Find(x => x.Nombre.Contains("Correa")), 18, ColorTarjeta.Amarilla);
                Console.WriteLine(primerPolemica.ObtenerDescripcionIncidencia());

                Gol primerGol = new Gol(gimnasia.Jugadores.Find(x => x.Nombre.Contains("Correa")), false, 22, false);
                Console.WriteLine(primerGol.ObtenerDescripcionIncidencia());

                Tarjeta segundaPolemica = new Tarjeta(gimnasia.Jugadores.Find(x => x.Nombre.Contains("Oreja")), 37, ColorTarjeta.Amarilla);
                Console.WriteLine(segundaPolemica.ObtenerDescripcionIncidencia());

                Tarjeta terceraPolemica = new Tarjeta(gimnasia.Jugadores.Find(x => x.Nombre.Contains("Oreja")), 37, ColorTarjeta.Roja);
                terceraPolemica.TarjetaAsociada = segundaPolemica;
                Console.WriteLine(terceraPolemica.ObtenerDescripcionIncidencia());

                Gol segundoGol = new Gol(estudiantes.Jugadores.Find(x => x.Nombre.Contains("Aguirregaray")), false, 60, false);
                Console.WriteLine(segundoGol.ObtenerDescripcionIncidencia());

                List<Incidencia> incidencias = new List<Incidencia>();
                incidencias.Add(primerPolemica);
                incidencias.Add(primerGol);
                incidencias.Add(segundaPolemica);
                incidencias.Add(terceraPolemica);
                incidencias.Add(segundoGol);


                incidencias.ForEach(incidencia => superliga.Partidos[0].AgregarIncidencia(primerPolemica));

                ResumenPartido resumen = superliga.Partidos[0].ObtenerResultadoFinal();

                Console.WriteLine("Resumen del partido");
                Console.WriteLine(resumen.EquipoLocal.Nombre + " " + resumen.GolesLocal + " - " + resumen.GolesVisitante + " " + resumen.EquipoVisitante.Nombre);

            } else
            {
                Console.WriteLine("Algo está mal");
            }

        }


        static Equipo GetLocal()
        {
            Equipo estudiantes = new Equipo();
            estudiantes.Nombre = "Estudiantes de La Plata";
            estudiantes.Puntos = 10;

            CuerpoTecnico pellegrino = new CuerpoTecnico();
            pellegrino.Nombre = "Mauricio Pellegrino.";
            pellegrino.Nacionalidad = "Argentino";
            pellegrino.Edad = 48;
            pellegrino.EsTecnicoPrincipal = true;

            CuerpoTecnico xaviTamarit = new CuerpoTecnico();
            pellegrino.Nombre = "Xavi Tamarit";
            pellegrino.Nacionalidad = "Argentino";
            pellegrino.Edad = 48;
            pellegrino.EsTecnicoPrincipal = false;
            pellegrino.NumeroAyudanteCampo = 1;

            Jugador aguirreGaray = new Jugador();
            aguirreGaray.Edad = 31;
            aguirreGaray.EsTitular = true;
            aguirreGaray.Nacionalidad = "Uruguayo";
            aguirreGaray.Nombre = "Matias Aguirregaray";
            aguirreGaray.Posicion = Posicion.Delantero;
            aguirreGaray.Equipo = estudiantes;

            Jugador damonte = new Jugador();
            damonte.Edad = 38;
            damonte.EsTitular = true;
            damonte.Nacionalidad = "Argentino";
            damonte.Nombre = "Israel Damonte";
            damonte.Posicion = Posicion.Mediocampista;
            damonte.Equipo = estudiantes;

            List<CuerpoTecnico> cuerpoTecnico = new List<CuerpoTecnico>();
            cuerpoTecnico.Add(pellegrino);
            cuerpoTecnico.Add(xaviTamarit);

            List<Jugador> plantel = new List<Jugador>();
            plantel.Add(aguirreGaray);
            plantel.Add(damonte);

            estudiantes.CuerpoTecnico = cuerpoTecnico;
            estudiantes.Jugadores = plantel;

            return estudiantes;
        }

        static Equipo GetVisitante()
        {

            Equipo gimnasia = new Equipo();
            gimnasia.Nombre = "Gimnasia y Esgrima de La Plata";
            gimnasia.Puntos = 8;

            CuerpoTecnico troglio = new CuerpoTecnico();
            troglio.Nombre = "Pedro Troglio";
            troglio.Nacionalidad = "Argentino";
            troglio.Edad = 48;
            troglio.EsTecnicoPrincipal = true;

            Jugador correa = new Jugador();
            correa.Edad = 27;
            correa.EsTitular = true;
            correa.Nacionalidad = "Colombiano";
            correa.Nombre = "Érik Correa";
            correa.Posicion = Posicion.Delantero;
            correa.Equipo = gimnasia;

            Jugador oreja = new Jugador();
            oreja.Edad = 37;
            oreja.EsTitular = true;
            oreja.Nacionalidad = "Argentino";
            oreja.Nombre = "Facundo Oreja";
            oreja.Posicion = Posicion.Mediocampista;
            oreja.Equipo = gimnasia;

            List<CuerpoTecnico> cuerpoTecnico = new List<CuerpoTecnico>();
            cuerpoTecnico.Add(troglio);

            List<Jugador> plantel = new List<Jugador>();
            plantel.Add(correa);
            plantel.Add(oreja);

            gimnasia.CuerpoTecnico = cuerpoTecnico;
            gimnasia.Jugadores = plantel;

            return gimnasia;
        }

    }
}
