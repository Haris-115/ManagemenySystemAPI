using Microsoft.AspNetCore.Mvc;
using ManagementSystemAPI.DataAccess;
using System;
using System.Collections.Generic;
using ManagementSystemAPI.Models;

namespace ManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]

    public class DistributorsController : ControllerBase
    {
        private readonly IDistributorsProvider _dataAccessProvider;

        public DistributorsController(IDistributorsProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        public IEnumerable<Distributors> Get()
        {
            return _dataAccessProvider.GetDistributorsRecords();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Distributors distributors)
        {
            if (ModelState.IsValid)
            {
                    Guid obj = Guid.NewGuid();
                //distributors.distributors_id = obj.ToString();
                _dataAccessProvider.AddDistributorsRecord(distributors);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public Distributors Details(int id)
        {
            return _dataAccessProvider.GetDistributorsSingleRecord(id);
        }

        [HttpPut]
        public IActionResult Edit([FromBody] Distributors distributors)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateDistributorsRecord(distributors);
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteConfirmed(int id)
        {
            var data = _dataAccessProvider.GetDistributorsSingleRecord(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteDistributorsRecord(id);
            return Ok();
        }
    }
}
