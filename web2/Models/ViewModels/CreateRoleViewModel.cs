using System.ComponentModel.DataAnnotations;

namespace web2.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
