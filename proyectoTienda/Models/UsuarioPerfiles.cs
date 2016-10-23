namespace proyectoTienda.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UsuarioPerfiles
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_usuario { get; set; }

        public int ID_Perfil { get; set; }
    }
}
