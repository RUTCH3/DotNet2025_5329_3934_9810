namespace DO;


public record Product(int productId, string productName, Catagories catagory, double productPrice, int quantityInStock)
{
    public Product() : this(1, "DisneyPajamas", Catagories.Pajamas, 120, 52) { }

}
