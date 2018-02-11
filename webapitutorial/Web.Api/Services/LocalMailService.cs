using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Api.Services
{
    public class LocalMailService : IMailService
    {
        private string _mailTo { get; set; } = Startup.Configuration["mailSettings:mailToAdress"];
        private string _mailFrom { get; set; } = Startup.Configuration["mailSettings:mailFromAdress"];

        public void Send(string subject, string message) {
            Debug.WriteLine($"Mail from {_mailFrom} to {_mailTo}");
            Debug.WriteLine($"Subject: {subject}");
            Debug.WriteLine($"Message: {message}");
        }

    }
}
