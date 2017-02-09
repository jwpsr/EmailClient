using System;

namespace Domain.Models
{
    internal interface IUpdateAudit
    {
        DateTime UpdatedDate { get; set; }
        Guid UpdatedBy { get; set; }
    }
}