namespace Calculations;

public class Customer
{
    public static string Name => "Gonzalo";
    public static int Age => 35;

    public virtual int GetOrdersByName(string? name)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException("Hello");
        return 100;
    }
}

public class LoyalCustomer : Customer
{
    public LoyalCustomer()
    {
        Discount = 10;
    }

    public int Discount { get; }

    public override int GetOrdersByName(string? name)
    {
        return 101;
    }
}

public static class CustomerFactory
{
    public static Customer CreateCustomerInstance(int orderCount)
    {
        return orderCount <= 100 ? new Customer() : new LoyalCustomer();
    }
}