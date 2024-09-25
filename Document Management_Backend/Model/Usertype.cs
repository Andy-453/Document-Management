using System.ComponentModel.DataAnnotations;

namespace Document_Management_Backend.Model
{
    public class UserType
    {

        public int Id { get; set; }
        public required string Name { get; set; }
        //public required User Users { get; set; }
    }
}