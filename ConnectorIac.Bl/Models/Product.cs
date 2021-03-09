using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConnectorIac.Bl.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(9, ErrorMessage = "Length must be less then 9 characters")]
        public string Code { get; set; }

        [Required]
        [MaxLength(150, ErrorMessage = "Length must be less then 150 characters")]
        public string Description { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Length must be less then 20 characters")]
        public string Ean { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Volume { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Weight { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Price { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public bool Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        [ForeignKey("ProductGroup")]
        [Required]
        public int ProductGroupId { get; set; }
        public ProductGroup ProductGroup { get; set; }

    }
}
