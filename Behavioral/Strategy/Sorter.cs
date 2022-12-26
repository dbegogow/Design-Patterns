namespace Strategy;

internal class Sorter
{
    private readonly ISortStrategy _sorter;

    public Sorter(ISortStrategy sorter)
        => this._sorter = sorter;

    public List<int> Sort(List<int> unSortedList)
        => this._sorter.Sort(unSortedList);
}
