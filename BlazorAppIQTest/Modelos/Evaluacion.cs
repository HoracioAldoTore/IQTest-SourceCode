namespace BlazorAppIQTest.Modelos
{
    /// <summary>
    /// Evaluacion completa.
    /// </summary>
    public class Evaluacion
    {
        public Evaluacion() 
        {
            this.Tests = new List<Test>();
            this.TiempoRestante = DuracionMaxima;
        }

        public List<Test> Tests { get; set; }

        /// <summary>
        /// Tiempo de duracion maxima de una evaluación.
        /// </summary>
        public TimeSpan DuracionMaxima
        {
            get { 
                return new TimeSpan(0, 0, 40);
            }
        }

        /// <summary>
        /// Represnta el tiempo que queda para finalizar la evaluacion
        /// </summary>
        public TimeSpan TiempoRestante { get; set; }

        /// <summary>
        /// Represnta el TiempoRestante en valor porcentual.
        /// </summary>
        public int TiempoRestantePorcentual
        {
            get
            {
                double porcentajeAux = (this.TiempoRestante.TotalSeconds /
                this.DuracionMaxima.TotalSeconds) * 100;
                int porcentaje = Convert.ToInt32(porcentajeAux);
                return porcentaje;
            }            
        }

        /// <summary>
        /// Reorna la lista de tests correctos,
        /// seleccionados por el usuario.
        /// </summary>
        /// <returns></returns>
        public List<Test> GetTestsCorrectos()
        {
            List<Test> correctos = new List<Test>();
            correctos = this.Tests.Where(
                t => t.Respuestas.Any(r => r.Correcta && r.Seleccionada)
                ).ToList();

            return correctos;
        }

        /// <summary>
        /// Indica que el tiempo dado para realizar la evaluacion se ha agotado.
        /// </summary>
        public bool TiempoEstaAgotado
        {
            get
            {
                var cero = new TimeSpan(0, 0, 0);
                bool esTiempoAgotado = this.TiempoRestante.Equals(cero);
                return esTiempoAgotado;
            }
        }
    }
}
