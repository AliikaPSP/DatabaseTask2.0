using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Loaning
    {
        [Key]
        public Guid LoaningId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        // Foreign keys
        [ForeignKey("Employee")]
        public Guid EmployeeId { get; set; }

        [ForeignKey("LoanableItem")]
        public Guid LoanableItemId { get; set; }

        // Navigation properties
        public Employee Employee { get; set; }

        public LoanableItem LoanableItem { get; set; }
    }
}