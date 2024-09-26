using System.ComponentModel.DataAnnotations;

namespace DocumentManagementBackend.Model
{
    public class UserType
    {

        public int Id { get; set; }
        public required string Name { get; set; }
        //public required User Users { get; set; }
    }
}