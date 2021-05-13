using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmailAPI.Models
{
    public class Mail
    {
        [Required]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage ="Invalid email address!")]
        public string Recipient { get; set; }
        [StringLength(998,ErrorMessage ="The email subject is too long!")]
        public string Subject { get; set; }
        [StringLength(384000,ErrorMessage ="The email body is too long!")]
        public string Body { get; set; }

    }
}
