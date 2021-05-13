using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailAPI.Models
{
    public class MailSettings
    {
        public string Mail { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
    }
}
