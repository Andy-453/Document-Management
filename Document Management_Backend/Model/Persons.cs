using System.ComponentModel.DataAnnotations;

namespace Document_Management_Backend.Model
{
    public class Persons
    {
        public int Persons_Id { get; set; }

        public required string Name { get; set; }

        public required string Date_Birth { get; set; }

        public required string Email { get; set; }

        public required int Phone { get; set; }

        public required string Date_registration { get; set; }

        public required string Profile_Picture { get; set; }

        public required string Account_Status { get; set; }

        public required string Last_Login { get; set; }

        public required string Token_Recovery { get; set; }

        public int Users_Usertype_Id { get; set; }
    }
}