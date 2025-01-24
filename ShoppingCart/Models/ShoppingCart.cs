namespace ShoppingCartProject.Models
{
    public class ShoppingCart
    {
        private readonly List<Product> _products;

        public ShoppingCart()
        {
            _products = new List<Product>();
        }

        public int ProductCount => _products.Count;

        //TODO Készítse el a ShoppingCart osztályban azokat a metódusokat, amelyekkel sikeresen lefutnak a tesztesetek!

        public void AddProduct(string name, double price)
        {
            _products.Add(new Product(name, price));
        }

        public void RemoveProduct(string name)
        {
            var product = _products.FirstOrDefault(p => p.Name == name);
            if (product == null)
            {
                throw new InvalidOperationException();
            }

            _products.Remove(product);
        }

        public double GetTotalPrice()
        {
            return _products.Sum(p => p.Price);
        }

        public List<Product> GetProducts()
        {
            return _products;
        }
    }
}
