using System.ComponentModel.DataAnnotations;

namespace DocumentManagementBackend.Model
{
    public class DocumentsHasHistory
    {
        public virtual required Documents Documents { get; set; }

        public virtual required Historic Historic { get; set; } 
    }
}