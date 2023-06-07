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
        for (int i = 0; i < Products.Length; i++)
        {
            WriteLine("{0}.{1} {2}руб. - {3} {4}.",i+1, Products[i].Name, Products[i].Price, Products[i].Count, Products[i].Ed);
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
        Ed = "шт";
    }
    public ProductClass(string name, double price)
    {
        Id = 0;
        Name = name;
        Price = price;
        Count = 1;
        Ed = "шт";
    }
    public void Display()
    {
        WriteLine("{0}.{1} {2}руб. - 1 {3}.", Id,Name,Price,Ed);
    }
}
enum DeliveryType { NotDelivered = 0, Home, Point, Shop }

abstract class Delivery
{
    public int? NumberFlat; //Ставим ? когда сомневаемся в воде пустого значения
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
        WriteLine("Заказ №{0}. Тип:{1}, доставка по адресу: {2} {3} статус доставки: {4}", List, DeliveryType, Address, NumberFlat, IsStatus);
    }
    public static int GetIntValue()
    {
        string strValue = ReadLine()+"";
        bool isParse = int.TryParse(strValue, out int val);
        while (strValue == "" || val <= 0 || isParse == false) 
        {
            Write("Повторите ввод: ");
            strValue = ReadLine()+"";
            int.TryParse(strValue, out val);
        }
        return val;
    }
}

class HomeDelivery : Delivery
{
    public HomeDelivery(string adress, string telephon, int order) : base(adress, telephon, order)
    {
    }
    public void Status(int numberFlat)
    {
        DeliveryType = DeliveryType.NotDelivered;
        Write("Введите номер квартиры:");
        NumberFlat = GetIntValue(); 
        if (NumberFlat == numberFlat)
        {
            Write("Введите статус 0/1 доставки:");
            int status = GetIntValue();
            if (status == 1)
            {
                DeliveryType = DeliveryType.Home;
                FixIsStatus();
            }
        }
    }

}

class PickPointDelivery : Delivery
{
    private int? PinCode;
    public PickPointDelivery(string adress, string telephon, int order) : base(adress, telephon, order)
    {
    }
    public void Status(int pinCode)
    {
        DeliveryType = DeliveryType.NotDelivered;
        Write("Введите пинкод:");
        PinCode= GetIntValue();
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
        DeliveryType = DeliveryType.NotDelivered;
        Write("Введите имя менеджера магазина:");
        string NameMenedger = ReadLine() + "";
        
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

        HomeDelivery kv15 = new ("ул.Маяковского", "+79027621205", 15);
        kv15.Status(15);
        kv15.DisplayDelivery();

        PickPointDelivery p2625 = new("ул.Маяковского", "+79027621205", 657);
        p2625.Status(2625);
        p2625.DisplayDelivery();

        ShopDelivery shop = new("ул.Маяковского", "+79027621205", 111);
        shop.Status("Max");
        shop.DisplayDelivery();
    }
}
