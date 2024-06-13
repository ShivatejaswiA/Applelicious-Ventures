using System.ComponentModel.DataAnnotations;

namespace Applelicious_Ventures.Models;

    public class Apple
    {
        
        public int Id { get; set; }
        public string? Origin { get; set; }
        [DataType(DataType.Date)]
        public DateTime ImportDate{ get; set; }
        public string? Color { get; set; }
        public decimal Price { get; set; }
   //public string? Taste { get; set; }
   // public string? Taste { get; set; }
}
