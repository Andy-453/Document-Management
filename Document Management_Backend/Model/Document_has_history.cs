using System.ComponentModel.DataAnnotations;

namespace Document_Management_Backend.Model
{
    public class Documents_has_history
    {
        public int Documents_Document_Id { get; set; }

        public int historic_Historic_Id { get; set; }
    }
}