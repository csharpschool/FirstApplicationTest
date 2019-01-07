using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApplication.Services
{
    public class StaticReadService : IMessageService
    {
        public string Read()
        {
            return "Message from static read service.";
        }
    }
}
