using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld.Services
{
    public interface IMailService
    {
        void SendMail(string to, string from, string subject, string body);
    }

    public class DebugMailService : IMailService
    {
        public void SendMail(string to, string from, string subject, string body)
        {
            Debug.WriteLine($"Sending E-Mail to: {to} from: {from} subject: {subject}");
        }
    }
}
