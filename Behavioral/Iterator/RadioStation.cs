namespace Iterator;

internal class RadioStation
{
    private float _frequency;

    public RadioStation(float frequency)
        => this._frequency = frequency;

    public float GetFrequecy()
        => this._frequency;
}
