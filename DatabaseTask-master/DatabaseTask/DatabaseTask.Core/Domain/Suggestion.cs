using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Suggestion
    {
        [Key]
        public Guid SuggestionId { get; set; }

        public string Topic { get; set; }

        public string Content { get; set; }

        public string Status { get; set; }
    }
}
