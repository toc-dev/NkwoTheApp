using Microsoft.AspNetCore.Mvc;
using NkwoTheApp.AppCore.Shared.Interfaces;
using NkwoTheApp.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Presentation.Controllers
{
    [Route("api/buyers")]
    [ApiController]
    public class BuyerController: ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public BuyerController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        [HttpGet]
        public IActionResult GetBuyers()
        {
            var buyers = _serviceManager.BuyerService.GetAllBuyers(trackChanges: false);
            return Ok(buyers);
        }
        [HttpGet("{id:guid}", Name = "BuyerById")]
        public IActionResult GetBuyer(Guid id)
        {
            var buyer = _serviceManager.BuyerService.GetBuyer(id, trackChanges: false);
            return Ok(buyer);
        }

        [HttpPost]
        public IActionResult CreateBuyer([FromBody] BuyerCreationDto buyer)
        {
            if (buyer is null)
            {
                return BadRequest("BuyerCreationDto is null");
            }
            var createdBuyer = _serviceManager.BuyerService.CreateBuyer(buyer);
            return CreatedAtRoute("BuyerById", new {Id=createdBuyer.Id}, createdBuyer);
        }
    }
}
