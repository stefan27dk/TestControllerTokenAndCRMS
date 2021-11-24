using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sheduler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Admin : ControllerBase
    {
        private readonly IConfiguration configuration;

        // Cosntructor
        public Admin(IConfiguration configuration)
        {
            this.configuration = configuration;
        }



        [HttpPost]
        [Route("SendAllInvoices")]
        public async Task<IActionResult> SendAllInvoices(string token)
        {
            if(token == configuration["Token"])
            {
                // Build Invoices
               // Send all Invoices
               // Get all Mails
               // Send Mails - All Invoices are sendt
            }
            return StatusCode(200);
        }




        [HttpPost]
        [Route("ChangeToken")]
        public async Task<IActionResult> ChangeToken(string token)
        {
            configuration["Token"] = token;
            return StatusCode(200);
        }


        


        [HttpGet]
        [Route("GetToken")]
        public async Task<IActionResult> GetToken()
        {   
            return StatusCode(200, configuration["Token"]);
        }


        [HttpPost]
        [Route("GenerateToken")]
        public async Task<IActionResult> GenerateToken()
        {     
            configuration["Token"] = Guid.NewGuid().ToString("N");
            return StatusCode(200, configuration["Token"]);
        }
    }
}
