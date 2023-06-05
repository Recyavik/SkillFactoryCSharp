
using System.Xml;
using static System.Console;

namespace Module_7_6_Itog;

class ListProduct
{
    public int Id;
    public ProductClass[] Products;
    public ListProduct(int id)
    {
        Id = id;
        Products = Array.Empty<ProductClass>();
    }
    public void DisplayList()
    {
        string strOut;
        for (int i = 0; i < Products.Length; i++)
        {
            strOut = (i + 1).ToString() + ". " + Products[i].Name + ", " +
                Products[i].Price.ToString() + " руб., " + Products[i].Count.ToString() + " " + Products[i].Ed;
            WriteLine(strOut);
        }
    }
    public void AppendList(ProductClass product)
    {
        Products = Products.Append(product).ToArray();
    }
    public double GetSumma()
    {
        double sum = 0;
        for (int i = 0; i < Products.Length; i++)
        {
            sum += Products[i].Price * Products[i].Count;
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
    public ProductClass(string name, double price)
    {
        Id = 0;
        Name = name;
        Price = price;
        Count = 1;
        Ed = "шт.";
    }
    public void Display()
    {
        string strOut = Id.ToString() + ". " + Name + ", " + Price.ToString() + " руб. - " +
        Count.ToString() + " " + Ed;
        Console.WriteLine(strOut);
    }
}
enum DeliveryType { Home = 0, Point, Shop }

abstract class Delivery
{
    public string? Address;
    public string? Telephon;
    public int? List;
    public bool IsStatus { get; set; }
    public DeliveryType DeliveryType { get; set; }

    public Delivery(string adress, string telephon, int order)
    {
        Address = adress;
        Telephon = telephon;
        List = order;
    }
    public void FixIsStatus()
    {
        IsStatus = true;
    }
    public void DisplayDelivery()
    {
        Console.WriteLine("Заказ №{0} тип:{1} по адресу:{2} статус доставки: {3}", List, DeliveryType, Address, IsStatus);
    }
}

class HomeDelivery : Delivery
{
    private int? NumberFlat;
    /* ... */
    public HomeDelivery(string adress, string telephon, int order) : base(adress, telephon, order)
    {
    }
    public void Status(int numberFlat)
    {
        Console.Write("Введите номер квартиры:");
        NumberFlat = Convert.ToInt32(Console.ReadLine());
        if (NumberFlat == numberFlat)
        {
            DeliveryType = DeliveryType.Home;
            Console.Write("Введите статус 0/1 доставки");
            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                FixIsStatus();
            }
        }
    }

}

class PickPointDelivery : Delivery
{
    private int? PinCode;
    /* ... */
    public PickPointDelivery(string adress, string telephon, int order) : base(adress, telephon, order)
    {
    }
    public void Status(int pinCode)
    {
        Console.Write("Введите пинкод:");
        PinCode = Convert.ToInt32(Console.ReadLine());
        if (PinCode == pinCode)
        {
            DeliveryType = DeliveryType.Point;
            FixIsStatus();
        }
    }
}

internal class ShopDelivery : Delivery
{
    public string? NameMenedger;
    /* ... */
    public ShopDelivery(string adress, string telephon, int order) : base(adress, telephon, order)
    {

    }
    public void Status(string nameMenedger)
    {
        Console.Write("Введите имя менеджера магазина:");
        string? NameMenedger = Console.ReadLine();
        
        if (NameMenedger == nameMenedger)
        {
            DeliveryType = DeliveryType.Shop;
            FixIsStatus();
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        ProductClass pr = new(14, "Салат", 120.50, 2);
        ProductClass pr2 = new(21, "Кофе", 40.00, 1);
        pr.Display();
        pr2.Display();
        var prS = new ListProduct(888);
        prS.AppendList(pr);
        prS.AppendList(pr2);
        prS.DisplayList();

        double summa = prS.GetSumma();
        WriteLine("Заказ №{0}. Сумма к оплате: {1} руб.", prS.Id, summa);

        HomeDelivery kv15 = new ("ул.Маяковского", "+79027621205", 12);
        kv15.DisplayDelivery();
        kv15.Status(15);
        kv15.DisplayDelivery();
    }
}
