namespace WebDemo14112023.Models
{
<<<<<<< HEAD
    public class ProductDao
    {
        private static ProductDao instance = null;
        private static readonly object instancelock = new object();
        public static ProductDao Instance
        {
            get
            {
                lock(instancelock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDao();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1,Name = "Laptop Acer", Description = "Laptop", Price= 12005500.500M},
            new Product { Id = 2, Name = "Laptop Dell", Description = "Laptop", Price = 15028500.200M },
            new Product { Id = 3, Name = "Bàn phím Acer", Description = "Bàn phím", Price = 1200820.000M },
            new Product { Id = 4, Name = "Bàn phím Logitech", Description = "Bàn phím", Price = 110500.800M },
            };
            return products;
        }
    }

=======
    public class ProductDAO
    {
    }
>>>>>>> 3db8a99d2fbc79370dbb0ccdcb69e61121276d48
}
