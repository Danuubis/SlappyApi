using System.ComponentModel.DataAnnotations.Schema;

namespace SlappyApi.DTO
{
    [Table("carta")]
    public class Carta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        [Column("url_imagen")]
        public string UrlImagen { get; set; }
        public string Dimension { get; set; }
        public int Ataque { get; set; }
        public int Vida { get; set; }
        public string Rareza { get; set; }
        public int Coste { get; set; }

        [Column("expansion_id")] 
        public int ExpansionId { get; set; }
    }

}
