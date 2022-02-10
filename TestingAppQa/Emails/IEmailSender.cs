using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingAppQa.Emails
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
    }
}
