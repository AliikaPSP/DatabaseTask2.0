using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Position
    {
        [Key]
        public Guid PositionId { get; set; }

        public decimal Salary { get; set; }

        public string PositionTitle { get; set; }

        public string Description { get; set; }
    }
}