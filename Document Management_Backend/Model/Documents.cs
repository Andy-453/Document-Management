using System.ComponentModel.DataAnnotations;

namespace Document_Management_Backend.Model
{
    public class Documents
    {
        public int Document_Id { get; set; }

        public required int Documents_Protected { get; set; }

        public required int Document_shared { get; set; }

        public required string Address { get; set; }

        public required string Type_Document { get; set; }
    }
}
