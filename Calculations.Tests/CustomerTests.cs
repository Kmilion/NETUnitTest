using Xunit;

namespace Calculations.Tests;

[Collection("Customer")]
public class CustomerTests
{
    private readonly CustomerFixture _customerFixture;

    public CustomerTests(CustomerFixture customerFixture)
    {
        _customerFixture = customerFixture;
    }

    [Fact]
    public void CheckNameNotEmpty()
    {
        var customer = _customerFixture.Customer;
        Assert.NotNull(customer.Name);
        Assert.False(string.IsNullOrEmpty(customer.Name));
    }

    [Fact]
    public void CheckLegiForDiscount()
    {
        var customer = _customerFixture.Customer;
        Assert.InRange(customer.Age, 25, 35);
    }

    [Fact]
    public void GetOrdersByNameNotNull()
    {
        var customer = _customerFixture.Customer;
        var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(null));
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