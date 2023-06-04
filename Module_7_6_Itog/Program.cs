
namespace Module_7_6_Itog;

class ListProduct
{
    public int Id { get; set; }
    public ProductClass[] Products;
    public ListProduct(int id)
    {
        Id = id;
        Products = new ProductClass[0];
    }
    public void DisplayList()
    {
        string strOut;
        for (int i = 0; i < Products.Length; i++)
        {
            strOut = "";
            strOut = strOut = (i+1).ToString() + ". " + Products[i].Name + ", " +
                Products[i].Price.ToString() + " руб., " + Products[i].Count.ToString() + " " + Products[i].Ed;
            Console.WriteLine(strOut);
        }
    }
    public void AppendList(ProductClass product)
    {
        Products = Products.Append(product).ToArray();
    }
    public double GetSumma(ProductClass[] products)
    {
        double sum = 0;
        for (int i = 0; i < products.Length; i++)
        {
            sum += products[i].Price * products[i].Count;
        }

        return sum;
    }
}
class ProductClass
{
    public int Id { get; set; }
    public string Name;
    public int Count = 0;
    public double Price;
    public string Ed;
    public ProductClass(int id, string name, double price, int count)
    {
        Id = id;
        Name = name;
        Price = price;
        Count = count;
        Ed = "шт.";
    }
    public void Display()
    {
            string strOut = "";
            strOut = Id.ToString() + ". " +Name + ", " + Price.ToString() + " руб. - " + 
            Count.ToString() + " " + Ed; 
            Console.WriteLine(strOut);
        }
    }

abstract class Delivery
{
    public string Address;
    public string Telephon;
    public int List;

    public Delivery(string adress, string telephon, int order)
    {
        Address = adress;
        Telephon = telephon;
        List = order;
    }
}

class HomeDelivery : Delivery
{
    /* ... */
    public HomeDelivery(string adress, string telephon, int order) : base(adress, telephon, order)
    {
    }
}

class PickPointDelivery : Delivery
{
    /* ... */
    public PickPointDelivery(string adress, string telephon, int order) : base(adress, telephon, order)
    {
    }
}

internal class ShopDelivery : Delivery
{
    /* ... */
    public ShopDelivery(string adress, string telephon, int order) : base(adress, telephon, order)
    {
    }
}

class Order<TDelivery,TStruct> where TDelivery : Delivery
{
    public TDelivery Delivery;

    public int Number;

    public string Description;

    public void DisplayAddress()
    {
        Console.WriteLine(Delivery.Address);
    }

    // ... Другие поля
}
internal class Program
{
    static void Main(string[] args)
    {
        ProductClass pr = new ProductClass(14, "Салат", 120.00, 2);
        ProductClass pr2 = new ProductClass(21, "Кофе", 40.00, 1);
        pr.Display();
        pr2.Display();
        ListProduct prS = new ListProduct(0);
        prS.AppendList(pr);
        prS.AppendList(pr2);
        prS.DisplayList();
    }
}
