using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Suitsupply.SalesRep.API.DAL;
using Suitsupply.SalesRep.API.DAL.Entities;

namespace Suitsupply.SalesRep.API.Controllers
{
    [Route("api/[controller]")]
    public class SalesRepresentativesController : Controller
    {
        private readonly IRepository _repository;

        public SalesRepresentativesController(IRepository salesRepresentativesRepository)
        {
            _repository = salesRepresentativesRepository;
        }

        // GET: api/salesrepresentatives
        [HttpGet]
        public IEnumerable<SaleRepresentative> Get()
        {
            return _repository.GetSalesRepresentatives();
        }

        // GET api/salesrepresentatives/5
        [HttpGet("{id}")]
        public SaleRepresentative Get(int id)
        {
            return _repository.GetSalesRepresentatiesById(id);
        }

        // POST api/salesrepresentatives
        [HttpPost]
        public void Post([FromBody] SaleRepresentative saleRepresentative)
        {
            _repository.InsertSaleRepresentative(saleRepresentative);
            _repository.Save();
        }

        // PUT api/salesrepresentatives/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] SaleRepresentative saleRepresentative)
        {
            _repository.UpdateSaleRepresentative(saleRepresentative);
            _repository.Save();
        }

        // DELETE api/salesrepresentatives/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.DeleteSaleRepresentative(id);
            _repository.Save();
        }
    }
}