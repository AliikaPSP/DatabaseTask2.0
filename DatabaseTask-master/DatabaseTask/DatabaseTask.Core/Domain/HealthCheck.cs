using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class HealthCheck
    {
        [Key]
        public Guid HealthCheckId { get; set; }

        public DateTime Date { get; set; }

        [StringLength(50)]
        public string DoctorName { get; set; }

        // Foreign key
        [ForeignKey("Employee")]
        public Guid EmployeeId { get; set; }

        // Navigation property
        public Employee Employee { get; set; }
    }
}
