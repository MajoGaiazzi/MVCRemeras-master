using System;
using System.ComponentModel.DataAnnotations;

namespace MVCMerchandising.Models
{
    public class Merchandising
    {
        public int Id { get; set; }


        [StringLength(60, MinimumLength = 3)]

        [Required]
        public string Producto { get; set; }

        public string Talles { get; set; }

        public string Descripcion { get; set; }



        [Range(1, 100)]

        [DataType(DataType.Currency)]

        /*[Column(TypeName = "decimal(18, 2)")]*/
        public decimal Precio { get; set; }

        public string Colores { get; set; }

        public string Imagen { get; set; }

    }
}
