using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SlappyApi.DTO
{
    [Table("productos")]
    public class Producto
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }

        [Column("descripcion")]
        public string Descripcion { get; set; }

        [Column("url_imagen")]
        public string UrlImagen { get; set; }

        [Column("coste")]
        public decimal Coste { get; set; }

        [Column("tipo")]
        public string Tipo { get; set; }

        [Column("category")]
        public string Category { get; set; }

        [Column("in_stock")]
        public bool InStock { get; set; }

        [Column("stock_quantity")]
        public int StockQuantity { get; set; }

        [Column("is_new")]
        public bool IsNew { get; set; }

        [Column("on_sale")]
        public bool OnSale { get; set; }

        [Column("featured")]
        public bool Featured { get; set; }

        [Column("tags")]
        public string Tags { get; set; }

        [Column("review_count")]
        public int ReviewCount { get; set; }
    }
}
