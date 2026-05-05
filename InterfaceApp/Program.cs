namespace InterfaceApp;

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}

public class CreditCardProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount}");
    }
}

public class PayPalProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of {amount}");
    }
}

public class PaymentService(IPaymentProcessor paymentProcessor)
{
    // this field is of type IPaymentProcessor, which is an interface. This allows us to use any class that implements this interface, such as CreditCardProcessor or PayPalProcessor.
    private readonly IPaymentProcessor _paymentProcessor = paymentProcessor;

    public void OrderPayment(decimal amount)
    {
        _paymentProcessor.ProcessPayment(amount);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // we can create an instance of CreditCardProcessor and pass it to the PaymentService,
        // or we can create an instance of PayPalProcessor and pass it to the PaymentService,
        // without changing the PaymentService code.
        IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
        IPaymentProcessor payPalProcessor = new PayPalProcessor();

        PaymentService paymentService1 = new PaymentService(creditCardProcessor);
        PaymentService paymentService2 = new PaymentService(payPalProcessor);

        paymentService1.OrderPayment(100.21m);
        paymentService2.OrderPayment(200.21m);
    }
}
