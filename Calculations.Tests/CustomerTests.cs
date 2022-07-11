using Xunit;

namespace Calculations.Tests;

public class CustomerTests
{
    [Fact]
    public void CheckNameNotEmpty()
    {
        Assert.NotNull(Customer.Name);
        Assert.False(string.IsNullOrEmpty(Customer.Name));
    }

    [Fact]
    public void CheckLegiForDiscount()
    {
        Assert.InRange(Customer.Age, 25, 35);
    }

    [Fact]
    public void GetOrdersByNameNotNull()
    {
        var cust = new Customer();
        var exceptionDetails = Assert.Throws<ArgumentException>(() => cust.GetOrdersByName(null));
        Assert.Equal("Hello", exceptionDetails.Message);
    }

    [Fact]
    public void LoyalCustomerForOrdersG100()
    {
        var customer = CustomerFactory.CreateCustomerInstance(102);
        var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);
        Assert.Equal(10, loyalCustomer.Discount);
    }
}