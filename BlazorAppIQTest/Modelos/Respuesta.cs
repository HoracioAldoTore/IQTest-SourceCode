namespace BlazorAppIQTest.Modelos
{
    public class Respuesta : IComunes
    {
        public string Imagen {  get; set; }
        /// <summary>
        /// El la repuesta correcta.
        /// </summary>
        public bool Correcta {  get; set; }
        /// <summary>
        /// Es la respuesta que eligio la persona evaluada.
        /// </summary>
        public bool Seleccionada { get; set; }

        /// <summary>
        /// Retorna el numero unico que lo identifica.
        /// </summary>
        /// <returns></returns>
        public int Numero
        {
            get
            {
                string aux = Imagen.Substring(4, 2);
                return int.Parse(aux);
            }
        }
    }
}
