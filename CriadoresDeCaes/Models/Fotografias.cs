namespace CriadoresDeCaes.Models
{
    public class Fotografias
    {
        /// <summary>
        /// PK
        /// </summary>
        public int Id { get; set; }

        public string Ficheiro { get; set; }

        public DateTime Data { get; set; }

        public string Local { get; set; }
    }
}
