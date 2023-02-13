using System.ComponentModel.DataAnnotations;

namespace ThriftshopRazorWeb.Model
{
    public class Class
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int DisplayOrder { get; set; }
    }
}
