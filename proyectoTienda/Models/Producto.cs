namespace proyectoTienda.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producto")]
    public partial class Producto
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        public int Precio { get; set; }

        public bool Oferta { get; set; }

        public bool Nuevo { get; set; }

        public int Promocion { get; set; }

        public bool Disponible { get; set; }

        public bool Reservar { get; set; }

        public bool Stock { get; set; }

        [Display(Name="Descripción corta")]
        public string desc_corta { get; set; }

        [Display(Name = "Descripción Larga")]
        public string desc_larga { get; set; }

        public int Garantia { get; set; }

        [Display(Name = "Categoria")]
        public int CategoriasId { get; set; }

        [Display(Name = "Fabricante")]
        public int? Id_fabricante { get; set; }
    }
}
