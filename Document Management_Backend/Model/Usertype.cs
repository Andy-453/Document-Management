using System.ComponentModel.DataAnnotations;

namespace DocumentManagementBackend.Model
{
    public class UserType
    {
        [Key]
        public int Id { get; set; }
        public int UserTypes { get; set; }
    }
}