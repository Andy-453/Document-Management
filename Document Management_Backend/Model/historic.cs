using System.ComponentModel.DataAnnotations;

namespace DocumentManagementBackend.Model
{
    public class historic
    {
        public int Historic_Id { get; set; }

        public required string Date_Created { get; set; }

        public required string user_modification { get; set; }

        public required string date_modification { get; set; }

        public required string Action { get; set; }

        public required string Referencia_Id { get; set; }

    }
}