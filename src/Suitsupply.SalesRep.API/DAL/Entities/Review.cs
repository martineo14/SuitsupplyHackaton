using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Suitsupply.SalesRep.API.DAL.Entities
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }

        [Required]
        [ForeignKey("SaleRepresentative")]
        public int SaleRepresentativeId { get; set; }

        public virtual SaleRepresentative SaleRepresentative { get; set; }
    }
}