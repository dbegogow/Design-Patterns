namespace Flyweight;

internal class TeaMaker
{
    private Dictionary<string, KarakTea> _availableTea = new Dictionary<string, KarakTea>();

    public KarakTea Make(string preference)
    {
        if (!this._availableTea.ContainsKey(preference))
        {
            this._availableTea[preference] = new KarakTea();
        }

        return this._availableTea[preference];
    }
}
