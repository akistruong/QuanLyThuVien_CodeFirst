using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Threading.Tasks;

namespace QLTV2._0.Helper
{
    public class SendMailService
    {
        MailConfig _mailConfig { set; get; }
        public IConfiguration _configuration { get; }

        public SendMailService(IOptions<MailConfig>  mailConfig, IConfiguration configuration)
        {
            _mailConfig = mailConfig.Value;
            _configuration = configuration;
            //_mailConfig.Address = _configuration.GetSection("MailConfig:Address").Value;
            //_mailConfig.NameDisplay = _configuration.GetSection("MailConfig:NameDisplay").Value;
            //_mailConfig.Host = _configuration.GetSection("MailConfig:Host").Value;
            //_mailConfig.Port = Int32(_configuration.GetSection("MailConfig:Port").Value);
        }

        public async Task<bool> SendMail(MailBody mailContent)
        {
            var email = new MimeMessage();
            email.Sender = new MailboxAddress(_mailConfig.NameDisplay, _mailConfig.Address);
            email.From.Add(new MailboxAddress(_mailConfig.NameDisplay, _mailConfig.Address));
            email.To.Add(new MailboxAddress(mailContent.To, mailContent.To));
            email.Subject = mailContent.Subject;
            var builder = new BodyBuilder();
            builder.HtmlBody = mailContent.Body;
            email.Body = builder.ToMessageBody();
            using var smtp = new MailKit.Net.Smtp.SmtpClient();
            try
            {
                await smtp.ConnectAsync(_mailConfig.Host, _mailConfig.Port, MailKit.Security.SecureSocketOptions.StartTls);
                smtp.Authenticate(_mailConfig.Address,_mailConfig.Password);
                await smtp.SendAsync(email);
              
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
                return false;
            }
            smtp.Disconnect(true);
            return true;
        }
    }
    public class MailBody
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }    
    }
}
