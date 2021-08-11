using Microsoft.AspNetCore.Mvc;
using ManagementSystemAPI.DataAccess;
using System;
using System.Collections.Generic;
using ManagementSystemAPI.Models;

namespace ManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]

    public class OrdersController : ControllerBase
    {
        private readonly IOrdersProvider _dataAccessProvider;

        public OrdersController(IOrdersProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        public IEnumerable<Orders> Get()
        {
            return _dataAccessProvider.GetOrdersRecords();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Orders orders)
        {
            if (ModelState.IsValid)
            {
                Guid obj = Guid.NewGuid();
               // orders.id = obj.ToString();
                _dataAccessProvider.AddOrdersRecord(orders);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public Orders Details(int id)
        {
            return _dataAccessProvider.GetOrdersSingleRecord(id);
        }

        [HttpPut]
        public IActionResult Edit([FromBody] Orders orders)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateOrdersRecord(orders);
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteConfirmed(int id)
        {
            var data = _dataAccessProvider.GetOrdersSingleRecord(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteOrdersRecord(id);
            return Ok();
        }
    }
}
