using System;

namespace Domain.Models
{
    public interface ICreateAudit
    {
        DateTime CreatedDate { get; set; }
        Guid CreatedBy { get; set; }
    }
}