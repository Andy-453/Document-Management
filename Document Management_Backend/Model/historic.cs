using System.ComponentModel.DataAnnotations;

namespace DocumentManagementBackend.Model
{
    public class Historic
    {
        [Key]
        public required int Id { get; set; }

        public required string DateCreated { get; set; }

        public required string UserModification { get; set; }

        public required string DateModification { get; set; }

        public required string Action { get; set; }

        public required string ReferenciaId { get; set; }

    }
}