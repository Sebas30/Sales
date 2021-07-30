namespace Sale.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        [Key]
        public int ProductoId { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public Decimal Price { get; set; }

        public bool IsAvailable { get; set; }

        public DateTime PublishOn { get; set; }
    }
}
