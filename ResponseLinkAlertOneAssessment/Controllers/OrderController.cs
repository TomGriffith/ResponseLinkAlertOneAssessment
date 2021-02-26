using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResponseLinkAlertOneAssessment.Data;
using ResponseLinkAlertOneAssessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResponseLinkAlertOneAssessment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private StoreContext _context;
        public OrderController(StoreContext context)
        {
            _context = context;
        }
        // OrderController
        public ActionResult Get()
        {
            throw new NotImplementedException();
        }

        // OrderController/Details/5
        public ActionResult Get(int id)
        {
            throw new NotImplementedException();
        }

        // OrderController/Create
        [HttpPost]
        public async Task<ActionResult<Order>> CreateOrder(Order order)
        {
            // this will create duplicates in all tables since these objects are not
            // pulled from the database and inserted into the component
            // this is OK for demo purposes only
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            throw new NotImplementedException();
        }

        // OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
