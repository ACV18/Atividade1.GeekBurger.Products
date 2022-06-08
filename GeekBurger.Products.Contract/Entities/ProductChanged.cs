using GeekBurger.Products.Contract.Enum;

namespace GeekBurger.Products.Contract.Entities
{
    public class ProductChanged
    {
        public ProductState State { get; set; }
        public Product Product { get; set; }
    }

}
