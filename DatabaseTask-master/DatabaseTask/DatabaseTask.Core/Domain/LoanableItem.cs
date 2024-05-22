using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class LoanableItem
    {
        [Key]
        public Guid LoanableItemId { get; set; }

        public string ItemName { get; set; }

        public bool LoanStatus { get; set; }
    }
}
