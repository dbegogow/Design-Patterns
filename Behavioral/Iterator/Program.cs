namespace Iterator;

internal class Program
{
    static void Main()
    {
        var stations = new StationList();
        var station1 = new RadioStation(89);
        stations.Add(station1);

        var station2 = new RadioStation(101);
        stations.Add(station2);

        var station3 = new RadioStation(102);
        stations.Add(station3);

        foreach (var x in stations)
        {
            Console.Write(x.GetFrequecy());
        }

        var q = stations.Where(x => x.GetFrequecy() == 89).FirstOrDefault();
        Console.WriteLine(q.GetFrequecy());
    }
}