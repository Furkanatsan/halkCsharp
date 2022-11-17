
using NullableTypes;

Product product = new Product();
product.Price = null;

void SendMail(string from, string to, Nullable<bool> isEncrypted)
{
	if (isEncrypted != null)
	{

	}
}
