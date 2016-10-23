namespace proyectoTienda.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Factura")]
    public partial class Factura
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_usuario { get; set; }

        public int ID_pedido { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        public int IVA { get; set; }
    }
}
