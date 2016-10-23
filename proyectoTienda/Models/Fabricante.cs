namespace proyectoTienda.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Fabricante")]
    public partial class Fabricante
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        public string imagen { get; set; }
    }
}
