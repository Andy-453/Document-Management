using System.ComponentModel.DataAnnotations;

namespace Document_Management_Backend.Model
{
    public class Permissions
    {
        public int Permissions_Id { get; set; }

        public required string permissions { get; set; }
    }
}