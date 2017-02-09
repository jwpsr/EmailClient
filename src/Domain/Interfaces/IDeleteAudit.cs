using System;

namespace Domain.Models
{
    internal interface IDeleteAudit
    {
        DateTime DeletedDate { get; set; }
        Guid DeletedBy { get; set; }
    }
}