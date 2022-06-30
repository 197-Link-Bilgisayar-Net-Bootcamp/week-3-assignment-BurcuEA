using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NLayer.Data.Models
{
    public class ProductFeature
    {
        //[Key]
        //[ForeignKey("Product")]
        public int Id { get; set; }
        public string Color { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Product Product { get; set; }
    }
}
