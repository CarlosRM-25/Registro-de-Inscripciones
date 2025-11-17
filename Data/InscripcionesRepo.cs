using Registro_de_Inscripciones.Models;

namespace Registro_de_Inscripciones.Data
{
    public class InscripcionesRepo
    {
        private static readonly List<Inscripcion> _inscripciones = new List<Inscripcion>();
        private static int _nextId = 1;

        public void AgregarInscripcion(Inscripcion inscripcion)
        {
            if (inscripcion == null) return;
            inscripcion.Id = _nextId++;
            _inscripciones.Add(inscripcion);
        }

        public List<Inscripcion> ObtenerInscripciones()
        {
            // retornar copia para evitar modificaciones externas
            return _inscripciones.Select(i => i).ToList();
        }
    }
}