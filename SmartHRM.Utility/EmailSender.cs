﻿using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using MimeKit;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Utility
{
    public class EmailSender : IEmailSender
    {
        public string SendGridSecret { get; set; }
        public EmailSender(IConfiguration _config)
        {
            SendGridSecret = _config.GetValue<string>("SendGrid:SecretKey");
        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
			//var emailToSend = new MimeMessage();
			//emailToSend.From.Add(MailboxAddress.Parse("tickets@felsoftsystems.com"));
			//emailToSend.To.Add(MailboxAddress.Parse(email));
			//emailToSend.Subject = subject;
			//emailToSend.Body = new TextPart(MimeKit.Text.TextFormat.Html){Text = htmlMessage };

			////Send email
			//using(var emailClient=new SmtpClient())
			//{
			//    emailClient.Connect("felsoftsystems.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
			//    emailClient.Authenticate("tickets@felsoftsystems.com", "ydhtzVWjSekZ");
			//    emailClient.Send(emailToSend);
			//    emailClient.Disconnect(true);

			//}
			// return Task.CompletedTask;
			var client = new SendGridClient(SendGridSecret);
			var from = new EmailAddress("tickets@felsoftsystems.com", "Bulky Book");
			var to = new EmailAddress(email);
			var msg = MailHelper.CreateSingleEmail(from, to, subject,"", htmlMessage);
			return client.SendEmailAsync(msg);


           
        }
    }
}
