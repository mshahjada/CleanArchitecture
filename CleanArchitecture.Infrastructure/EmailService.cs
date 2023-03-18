using CleanArchitecture.Application.Contracts.Infrastructure;
using CleanArchitecture.Application.Model;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure
{
    public class EmailService : IEmailService
    {
        private readonly EmailSettings _emailSettings;
        public EmailService(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }
        public Task<bool> SendEmailAsync(Email email)
        {
            return Task.FromResult(true);
        }
    }
}
