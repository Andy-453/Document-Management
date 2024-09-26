using System.ComponentModel.DataAnnotations;

namespace DocumentManagementBackend.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string  Password { get; set; }

        public virtual required UserType UserType { get; set; }

    }
}
