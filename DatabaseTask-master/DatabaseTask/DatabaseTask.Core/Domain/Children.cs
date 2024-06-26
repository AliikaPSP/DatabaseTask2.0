﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Children
    {
        [Key]
        public Guid ChildrenId { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        // Foreign key
        public Guid EmployeeId { get; set; }

        // Navigation properties
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}