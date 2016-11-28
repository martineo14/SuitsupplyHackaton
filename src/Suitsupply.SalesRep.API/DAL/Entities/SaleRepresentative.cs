using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Suitsupply.SalesRep.API.DAL.Entities
{
    public class SaleRepresentative
    {
        public SaleRepresentative()
        {
            Reviews = new HashSet<Review>();
        }
        [Key]
        public int SalesRepId { get; set; }
        public int SalesForceId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public int Rating { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Story { get; set; }
        public string PictureUrl { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}