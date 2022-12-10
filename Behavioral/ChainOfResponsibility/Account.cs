namespace ChainOfResponsibility;

abstract class Account
{
    private Account _successor;
    protected decimal _balance;

    public void SetNext(Account account)
        => this._successor = account;

    public void Pay(decimal amountToPay)
    {
        if (this.CanPay(amountToPay))
        {
            Console.WriteLine($"Paid {amountToPay:c} using {this.GetType().Name}.");
        }
        else if (this._successor != null)
        {
            Console.WriteLine($"Cannot pay using {this.GetType().Name}. Proceeding..");
            this._successor.Pay(amountToPay);
        }
        else
        {
            throw new Exception("None of the accounts have enough balance");
        }
    }

    private bool CanPay(decimal amount)
        => this._balance >= amount;
}
