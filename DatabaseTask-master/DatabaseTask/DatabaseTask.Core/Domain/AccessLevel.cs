using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class AccessLevel
    {
        [Key]
        public Guid AccessLevelId { get; set; }

        public string AccessLevelName { get; set; }

        public string AccessLevelDescription { get; set; }

        public string AccessLevelPermissionList { get; set; }
    }
}
