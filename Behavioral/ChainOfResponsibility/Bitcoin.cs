namespace ChainOfResponsibility;

internal class Bitcoin : Account
{
    public Bitcoin(decimal balance)
        => this._balance = balance;
}
