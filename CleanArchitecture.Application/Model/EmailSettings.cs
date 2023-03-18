using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Model
{
    public class EmailSettings
    {
        public string APIKey { get; set; }
        public string Password { get; set; }
        public string FromAddress  { get; set; }
        public string FromName { get; set; }
    }
}
