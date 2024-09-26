using System.ComponentModel.DataAnnotations;

namespace DocumentManagementBackend.Model
{
    public class UserTypeHasPermissions
    {
        public virtual required Permissions Permissions { get; set; }
        public virtual required UserType UserType { get; set; }
    }
}    