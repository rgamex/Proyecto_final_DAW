namespace proyectoTienda.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class img_prod
    {
        public int ID { get; set; }

        [Required]
        public string ruta { get; set; }

        public string descripción { get; set; }

        public int id_producto { get; set; }
    }
}
