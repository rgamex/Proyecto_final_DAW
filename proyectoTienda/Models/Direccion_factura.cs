namespace proyectoTienda.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Direccion_factura
    {
        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string Direccion { get; set; }

        public int CP { get; set; }

        [Required]
        [StringLength(50)]
        public string Localidad { get; set; }

        [Required]
        [StringLength(50)]
        public string Provincia { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_Usuario { get; set; }
    }
}
