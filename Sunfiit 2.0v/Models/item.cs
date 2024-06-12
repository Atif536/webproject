using System.ComponentModel.DataAnnotations;

namespace Sunfiit_2._0v.Models
{
    public class item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int price { get; set; }
         public byte[] photo { get; set; }
       
    }
}
