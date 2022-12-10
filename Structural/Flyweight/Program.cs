namespace Flyweight;

internal class Program
{
    static void Main()
    {
        var teaMaker = new TeaMaker();
        var teaShop = new TeaShop(teaMaker);

        teaShop.TakeOrder("less sugar", 1);
        teaShop.TakeOrder("more milk", 2);
        teaShop.TakeOrder("without sugar", 5);

        teaShop.Serve();
    }
}