namespace proyectoTienda.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lineaPedido")]
    public partial class lineaPedido
    {
        public int ID { get; set; }

        public int ID_producto { get; set; }

        public int Cantidad { get; set; }

        public int Descuento { get; set; }

        public decimal precio { get; set; }

        public int ID_Factura { get; set; }

        public int ID_carrito { get; set; }
    }
}
