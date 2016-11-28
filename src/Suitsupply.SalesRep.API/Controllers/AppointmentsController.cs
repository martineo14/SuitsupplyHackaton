using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Suitsupply.SalesRep.API.DAL;
using Suitsupply.SalesRep.API.DAL.Entities;

namespace Suitsupply.SalesRep.API.Controllers
{
    [Route("api/[controller]")]
    public class AppointmentsController : Controller
    {
        private readonly IRepository _repository;

        public AppointmentsController(IRepository salesRepresentativesRepository)
        {
            _repository = salesRepresentativesRepository;
        }

        // GET: api/appointments
        [HttpGet]
        public IEnumerable<Appointment> Get()
        {
            return _repository.GetAppointments();
        }

        // GET api/appointments/5
        [HttpGet("{id}")]
        public Appointment Get(int id)
        {
            return _repository.GetAppointmentById(id);
        }

        // POST api/appointments
        [HttpPost]
        public void Post([FromBody] Appointment appointment)
        {
            _repository.InsertAppoinment(appointment);
            _repository.Save();
        }
    }
}