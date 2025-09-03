using static System.Net.Mime.MediaTypeNames;

namespace BlazorAppIQTest.Modelos
{
    public class Test : IComunes
    {
        public string Imagen { get; set; }
        public List<Respuesta> Respuestas { get; set; } = new List<Respuesta>();
        public Evaluacion Evaluacion { get; set; }

        /// <summary>
        /// Retorna el numero unico que lo identifica.
        /// </summary>
        /// <returns></returns>
        public int Numero
        {
            get
            {
                string aux = Imagen.Substring(0, 3);
                return int.Parse(aux);
            }
        }

        /// <summary>
        /// Retorna la respuesta que selecciono el usuario.
        /// </summary>
        /// <returns></returns>
        public Respuesta GetRespuestaSeleccionada()
        {
            Respuesta seleccionada = null;
            seleccionada = this.Respuestas.Find(r => r.Seleccionada == true);
            return seleccionada;
        }

        /// <summary>
        /// Indica si el test ha sido resuelto correctamente.
        /// </summary>
        public bool EsCorrecto
        {
            get 
            {
                bool esCorrecto = this.Respuestas.Any(r => r.Correcta && r.Seleccionada && r.Seleccionada == true);
                return esCorrecto;
            }
        }
    }
}
