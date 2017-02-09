using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class EmailTemplate : ICreateAudit, IUpdateAudit, IDeleteAudit
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime DeletedDate { get; set; }
        public Guid DeletedBy { get; set; }
    }
}
