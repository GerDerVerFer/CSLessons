class Car
{
    public string Color { get; set; }
    public string Name { get; set; }
    public uint MaxSpeed { get; set; }
    public int VIN;

    public override bool Equals(object obj)
    {
        var other = obj as Car;
        return VIN.Equals(other.VIN);
    }
}
