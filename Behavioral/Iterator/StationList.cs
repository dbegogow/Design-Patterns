using System.Collections;

namespace Iterator;

internal class StationList : IEnumerable<RadioStation>
{
    List<RadioStation> _stations = new();

    public RadioStation this[int index]
    {
        get => this._stations[index];
        set => this._stations.Insert(index, value);
    }

    public void Add(RadioStation station)
        => this._stations.Add(station);

    public void Remove(RadioStation station)
        => this._stations.Remove(station);

    public IEnumerator<RadioStation> GetEnumerator()
        => this.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator()
    {
        foreach (var x in this._stations)
        {
            yield return x;
        }
    }
}
