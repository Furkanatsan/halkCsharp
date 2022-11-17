using LooselyCoupled;

namespace LooselyCoupled
{
    public class DataSource
    {
        public void AddToSource(Product product)
        {
            Console.WriteLine($"{product.Name} kaynağa eklendi...");
        }
    }

    public class Product
    {
        public string Name { get; set; }
    }
}

public class ProductStorage
{
    public DataSource DataSource { get; set; }
    public void Add(Product product)
    {
        DataSource.AddToSource(product);
    }
}

public class Shirt
{

}

public interface IWear { }

public class Player
{
    public void TakeOn(IWear shirt)
    {

    }
}


