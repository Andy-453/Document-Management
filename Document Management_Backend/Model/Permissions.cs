using System.ComponentModel.DataAnnotations;

namespace DocumentManagementBackend.Model
{
    public class Permissions
    {
        [Key]
        public required int Id { get; set; }

        public required string permissions { get; set; }
    }
}