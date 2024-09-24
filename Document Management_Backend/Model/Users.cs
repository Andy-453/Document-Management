using System.ComponentModel.DataAnnotations;

namespace Document_Management_Backend.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string  Password { get; set; }

    }
}
