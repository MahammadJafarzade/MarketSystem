using System.Data.SqlTypes;

namespace Market.Models
{
    public class Order
    {
        public int Id { get; set; }
        public virtual List<Product> products { get; set; }
        public int CustomerId { get; set; }
        public double Price { get; set; }


        
    }
}
