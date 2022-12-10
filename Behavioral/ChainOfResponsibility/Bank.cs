namespace ChainOfResponsibility;

internal class Bank : Account
{
    public Bank(decimal balance)
        => this._balance = balance;
}
