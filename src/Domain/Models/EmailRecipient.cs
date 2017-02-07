using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class EmailRecipient
    {
        public int Id { get; set; }

        public int EmailId { get; set; }
        public Email Email { get; set; }

        public int RecipientId { get; set; }
        public Recipient Recipient { get; set; }
    }
}
