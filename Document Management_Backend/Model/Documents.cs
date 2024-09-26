using System.ComponentModel.DataAnnotations;

namespace DocumentManagementBackend.Model
{
    public class Documents
    {
        [Key]
        public required int Id { get; set; }

        public required int DocumentsProtected { get; set; }

        public required int DocumentShared { get; set; }

        public required string Address { get; set; }

        public required string TypeDocument { get; set; }

    }
}
