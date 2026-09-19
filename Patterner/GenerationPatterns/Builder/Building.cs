class Building
{
    public string foundation { get; set; }
    public string walls { get; set; }
    public string roof { get; set; }
    public string interior { get; set; }

    public override string ToString()
    {
        return $"Building\n - Foundation: {foundation} \n - Walls: {walls}\n - Roof: {roof}\n - Interior: {interior}";
    }
}