using System.Collections.Generic;

namespace Domain.Models
{
    public class Email
    {
        public Email()
        {
            Recipients = new List<EmailRecipient>();
        }

        public int Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public ICollection<EmailRecipient> Recipients { get; set; }
    }
}
