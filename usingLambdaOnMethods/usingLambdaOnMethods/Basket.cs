namespace usingLambdaOnMethods
{
    public class Basket
    {
        private List<ProductInBasket> products = new List<ProductInBasket>();

        public void AddProduct(ProductInBasket product)
        {
            var existingProduct = products.FirstOrDefault(p => p.Product.Id == product.Product.Id);
            if (existingProduct != null)
            {
                existingProduct.Quantity += product.Quantity;
            }
            else
            {
                products.Add(product);
            }
        }

        public void Clear() => products.Clear();

        public double GetTotalPrice() => products.Sum(p => p.Product.Price * p.Quantity);

        public bool IsEmpty() => products.Any();

        public void UpdateQuantity(int productId, int quantity)
        {
            var existingProduct = products.FirstOrDefault(p => p.Product.Id == productId);
            //var sample = existingProduct?.Quantity;
            if (existingProduct == null)
            {
                throw new ArgumentException($"{productId} id'li bir ürün sepetinizde bulunamadı");
            }
            existingProduct.Quantity = quantity;

        }

    }
}
