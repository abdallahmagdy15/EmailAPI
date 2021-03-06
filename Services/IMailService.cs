using EmailAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmailAPI.Services
{
    public interface IMailService
    {
        public Task SendEmailAsync(Mail mail); 
    }
}
