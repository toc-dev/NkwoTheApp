using Microsoft.AspNetCore.Mvc;
using NkwoTheApp.AppCore.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Presentation.Controllers
{
    [Route("api/sellers")]
    [ApiController]
    public class SellerController: ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public SellerController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public IActionResult GetSellers()
        {
            var sellers = _serviceManager.SellerService.GetAllSellers(trackChanges: false);
            return Ok(sellers);
        }
        [HttpGet("{id:guid}")]

        public IActionResult GetSeller(Guid id)
        {
            var seller = _serviceManager.SellerService.GetSeller(id, trackChanges: false);
            return Ok(seller);
        }
    }
}
