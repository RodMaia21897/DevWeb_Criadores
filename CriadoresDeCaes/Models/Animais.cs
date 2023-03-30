namespace CriadoresDeCaes.Models
{
    public class Animais
    {
        /// <summary>
        /// PK
        /// </summary>
        public int Id { get; set; }
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }
        public DateTime DataCompra { get; set; }

        public String Sexo { get; set; }

        public String NumLOP { get; set; }
    }
}
