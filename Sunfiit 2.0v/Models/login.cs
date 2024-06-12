using System.ComponentModel.DataAnnotations;

namespace Sunfiit_2._0v.Models
{
    public class login
    {
        [Key]
        public String email { get; set; }
        public String password { get; set; }

    }
}
