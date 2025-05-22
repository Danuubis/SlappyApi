using System.ComponentModel.DataAnnotations.Schema;

namespace SlappyApi.DTO
{
    [Table("cartamazo")]
    public class CartaMazo
    {
        public int Id { get; set; }
        [Column("carta_id")]
        public int CartaId { get; set; }
        [Column("mazo_id")]
        public int MazoId { get; set; }
        public int Cantidad { get; set; }
    }

}
