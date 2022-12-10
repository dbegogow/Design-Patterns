namespace ChainOfResponsibility;

internal class Program
{
    static void Main()
    {
        var bank = new Bank(100);
        var paypal = new Paypal(200);
        var bitcoin = new Bitcoin(300);

        bank.SetNext(paypal);
        paypal.SetNext(bitcoin);

        bank.Pay(259);
    }
}