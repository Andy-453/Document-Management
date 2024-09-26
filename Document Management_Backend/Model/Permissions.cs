using System.ComponentModel.DataAnnotations;

namespace DocumentManagementBackend.Model
{
    public class Permissions
    {
        public int Permissions_Id { get; set; }

        public required string permissions { get; set; }
    }
}