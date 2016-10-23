namespace proyectoTienda.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Direccion_envio
    {
        [Required]
        [StringLength(250)]
        public string Direccion { get; set; }

        public int ID { get; set; }

        public int CP { get; set; }

        [Required]
        [StringLength(50)]
        public string Localidad { get; set; }

        [Required]
        [StringLength(50)]
        public string Provincia { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_usuario { get; set; }
    }
}
