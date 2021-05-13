using EmailAPI.Models;
using EmailAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EmailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly IMailService mailService;

        public MailController(IMailService mailService)
        {
            this.mailService = mailService;
        }

        [HttpPost]
        public async Task<IActionResult> SendMail([FromBody] Mail mail)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await mailService.SendEmailAsync(mail);
                    return Ok(mail);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
