public class Product
{
    private string _productName;
    private int _productId;
    private float _price;
    private int _quantity;

    public Product(string name, int id, float price, int quantity)
    {
        _price = price;
        _productId = id;
        _productName = name;
        _quantity = quantity;
    }

    public double GetTotal()
    {
        return  _price * _quantity;
    }
    public string GetPackingLabel()
    {
        return $"{_productName} (ID: {_productId})";
    }
}