namespace Flyweight;

internal class TeaShop
{
    private Dictionary<int, KarakTea> _orders = new Dictionary<int, KarakTea>();
    private readonly TeaMaker _teaMaker;

    public TeaShop(TeaMaker teaMaker)
        => this._teaMaker = teaMaker ?? throw new ArgumentNullException(nameof(teaMaker), "teaMaker cannot be null");

    public void TakeOrder(string teaType, int table)
        => this._orders[table] = this._teaMaker.Make(teaType);

    public void Serve()
    {
        foreach (var table in this._orders.Keys)
        {
            Console.WriteLine($"Serving Tea to table # {table}");
        }
    }
}
