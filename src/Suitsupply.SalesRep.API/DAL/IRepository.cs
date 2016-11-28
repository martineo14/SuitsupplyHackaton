using System;
using System.Collections.Generic;
using Suitsupply.SalesRep.API.DAL.Entities;

namespace Suitsupply.SalesRep.API.DAL
{
    public interface IRepository : IDisposable
    {
        IEnumerable<SaleRepresentative> GetSalesRepresentatives();
        SaleRepresentative GetSalesRepresentatiesById(int salesRepId);
        void InsertSaleRepresentative(SaleRepresentative saleRepresentative);
        void DeleteSaleRepresentative(int salesRepId);
        void UpdateSaleRepresentative(SaleRepresentative saleRepresentative);
        IEnumerable<Appointment> GetAppointments();
        Appointment GetAppointmentById(int appointmentId);
        void InsertAppoinment(Appointment appointment);
        void Save();
    }
}