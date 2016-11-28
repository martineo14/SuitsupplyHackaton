using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using Suitsupply.SalesRep.API.DAL.Entities;

namespace Suitsupply.SalesRep.API.DAL
{
    public class SaleRepresentativeRepository : IRepository
    {
        private readonly SaleRepresentativeContext _context;

        public SaleRepresentativeRepository(SaleRepresentativeContext context)
        {
            this._context = context;
        }

        public IEnumerable<SaleRepresentative> GetSalesRepresentatives()
        {
            return _context.SalesRepresentatives.Include(representative => representative.Reviews).ToList();
        }

        public SaleRepresentative GetSalesRepresentatiesById(int salesRepId)
        {
            return _context.SalesRepresentatives.FirstOrDefault(x => x.SalesRepId == salesRepId);
        }

        public void InsertSaleRepresentative(SaleRepresentative saleRepresentative)
        {
            _context.SalesRepresentatives.Add(saleRepresentative);
        }

        public void DeleteSaleRepresentative(int salesRepId)
        {
            SaleRepresentative customer =
                _context.SalesRepresentatives.FirstOrDefault(x => x.SalesRepId == salesRepId);
            _context.SalesRepresentatives.Remove(customer);
        }

        public void UpdateSaleRepresentative(SaleRepresentative saleRepresentative)
        {
            _context.Entry(saleRepresentative).State = EntityState.Modified;
        }

        public IEnumerable<Appointment> GetAppointments()
        {
            return _context.Appointments.ToList();
        }

        public Appointment GetAppointmentById(int appointmentId)
        {
            return _context.Appointments.FirstOrDefault(x => x.Id == appointmentId);
        }

        public void InsertAppoinment(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}