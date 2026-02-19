using System.Data.SqlTypes;

namespace inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook(
                "Lenovo Legion",
                "Gaming notebook",
                0,
                false,
                2500,
                16,
                512
                );

            notebook.sale();
            notebook.ShowFullData();
        }
    }
}
public class Product
{
    public string Name
    {
        get;
        set;
    }
    public string Description
    {
        get;
        set;
    }
    public int Count
    {
        get;
        set;
    }
    public bool IsStock
    {
        get;
        set;
    }

    private double price;
    public double Price
    {
        get { return price; }
        set
        {
            if (value > 0)
                price = value;
        }
    }

    public Product(string name, string description, int count, bool isStock, double price)
    {
        Name = name;
        Description = description;
        Count = count;
        IsStock = isStock;
        Price = Price;
    }

    public void sale()
    {
        if (!IsStock | Count <= 0)
        {
            Console.WriteLine("Mehsul yoxdur!");
        }
        else
        {
            Count--;
            Console.WriteLine("Satish ugurla basha chatdi.");
        }
    }
}

public class Notebook : Product
{
    private byte ram;
    public byte RAM
    {
        get { return ram; }
        set
        {
            if (value > 0)
                ram = value;
        }
    }

    public int Storage
    {
        get;
        set;
    }
    public Notebook(string name, string description, int count, bool isStock, double price, byte ram, int storage)
        : base(name, description, count, isStock, price)
    {
        RAM = ram;
        Storage = storage;
    }
    public string GetFullInfo()
    {
        return $"Ad: {Name}, Say: {Count}, Qiymet: {Price},RAM: {RAM}GB, Storage: {Storage}GB";
    }
    public void ShowFullData()
    {
        Console.WriteLine(GetFullInfo());
    }
}