class HeroFactory
{
    public static Hero createRanger()
    {
        return new Hero("DragonWithDaGun", new Shoot(), new Fly());
    }
    public static Hero createWinger()
    {
        return new Hero("Knigten", new Swing(), new Run());
    }
    public static Hero createTank()
    {
        return new Hero("TAAANK", new Flamethrower(), new Ride());
    }
}
