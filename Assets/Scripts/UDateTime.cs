using System;

[Serializable]
public struct UDateTime
{
    public int Year;
    public int Month;
    public int Day;

    public int Hour;
    public int Minute;
    public int Second;

    public override string ToString()
    {
        return new DateTime(Year, Month, Day, Hour, Minute, Second).ToString("dd MMM yyyy");
    }
}
