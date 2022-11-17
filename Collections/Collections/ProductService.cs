namespace Collections
{
    public class ProductService
    {
        private List<Product> productsGallery = new List<Product>()
        {
            new(){ Id=1, Name="Tisort", Price=150, Rating=4.8, Description="Basic Tişört"},
            new(){ Id=2, Name="sort", Price=250, Rating=4.5, Description="Bildiğiniz şort"},
            new(){ Id=3, Name="Svitsort", Price=150, Rating=4.8, Description="Kapşonlu svitşört"},
            new(){ Id=4, Name="Pantolon", Price=450, Rating=4.3, Description="Kot pantolon"}
        };

        public void AddProduct(Product product)
        {
            productsGallery.Add(product);

        }

        public List<Product> GetAllProducts()
        {
            return productsGallery;
        }

        public List<Product> SearchProductsByName(string name)
        {
            List<Product> findingProducts = new List<Product>();
            foreach (var product in productsGallery)
            {
                if (product.Name.Contains(name))
                {
                    findingProducts.Add(product);
                }
            }

            return findingProducts;
        }

        public int TotalItemsCount { get { return productsGallery.Count; } }

        public double TotalPriceInRepository()
        {
            var totalPrice = 0.0;
            foreach (var product in productsGallery)
            {
                totalPrice += product.Price;
            }

            return totalPrice;
        }



    }
}
