using Barber_Shop_Project.Controllers;
using Microsoft.Extensions.Logging;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barber_Shop_Project.Services
{
    public class ServiceEmail
    {
        public async Task SendEmailMessageAsync(string adressUser, string subj, string message)
        {
            try
            {
                MimeMessage mimeMessage = new MimeMessage();
                mimeMessage.From.Add(new MailboxAddress(subj, adressUser));
                mimeMessage.To.Add(new MailboxAddress("Admin", "denis_aleksandrov_12@mail.ru"));
                mimeMessage.Subject = subj;
                mimeMessage.Body = new TextPart("Plain") { Text = message };

                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    await client.ConnectAsync("smtp.gmail.com", 465, true);
                    await client.AuthenticateAsync("aleksandrovdenis418@gmail.com", "3denis10sveta");
                    await client.SendAsync(mimeMessage);

                    await client.DisconnectAsync(true);
                }
            }
            catch
            { }
        }
    }
}