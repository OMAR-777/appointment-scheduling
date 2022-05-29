using System;
using System.Threading.Tasks;
using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.AspNetCore.Identity.UI.Services;
using Newtonsoft.Json.Linq;

namespace AppointmentScheduling.Utility
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            MailjetClient client = new MailjetClient("ce618e4cff6a28d9569f2e6dcc7c3112", "4fd9fb21ed32030edaf9fbe4090d9cce")
            {

            };

            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
           .Property(Send.FromEmail, "quizzitweb@gmail.com")
           .Property(Send.FromName, "Appointment Scheduler")
           .Property(Send.Subject, subject)
           .Property(Send.HtmlPart, htmlMessage)
           .Property(Send.Recipients, new JArray {
                new JObject {
                 {"Email", email}
                 }
               });
            MailjetResponse response = await client.PostAsync(request);


     //       MailjetRequest request = new MailjetRequest
     //       {
     //           Resource = Send.Resource,
     //       }
     //        .Property(Send.Messages, new JArray {
     //new JObject {
     // {
     //  "From",
     //  new JObject {
     //   {"Email", "quizzitweb@gmail.com"},
     //   {"Name", "Appointment Scheduler"}
     //  }
     // }, {
     //  "To",
     //  new JArray {
     //   new JObject {
     //    {"Email",email}
     //   }
     //  }},
     // {"Subject",subject},
     // {"HTMLPart", htmlMessage},
     // {"CustomID",
     //  "AppGettingStartedTest"
     // }
     //}
     //        });
     //       MailjetResponse response = await client.PostAsync(request);
        }
    }
}
