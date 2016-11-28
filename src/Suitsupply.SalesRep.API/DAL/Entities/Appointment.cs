using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Suitsupply.SalesRep.API.DAL.Entities
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        public int SalesRepId { get; set; }
        public string SalesRepEmail { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}