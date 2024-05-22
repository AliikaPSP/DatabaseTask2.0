﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class SickLeave
    {
        [Key]
        public Guid Id { get; set; }

        // Foreign key
        [ForeignKey("Employee")]
        public Guid EmployeeId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        // Navigation property
        public Employee Employee { get; set; }
    }
}
