using System.ComponentModel.DataAnnotations.Schema;

namespace DocumentManagementBackend.Model
{
    public class DocumentsHasUsers
    {
        public required string Members { get; set; }

        public virtual required Documents Documents { get; set; }

        public virtual required User User { get; set; }
        

    }
}
