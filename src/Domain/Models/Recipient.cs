using System.Collections.Generic;

namespace Domain.Models
{
    public class Recipient
    {
        public Recipient()
        {
            Emails = new List<EmailRecipient>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<EmailRecipient> Emails { get; set; }
    }
}