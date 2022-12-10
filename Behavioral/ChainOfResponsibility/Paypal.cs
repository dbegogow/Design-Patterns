namespace ChainOfResponsibility;

internal class Paypal : Account
{
    public Paypal(decimal balance)
        => this._balance = balance;
}
