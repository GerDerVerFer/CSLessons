using System;

class Hero
{
    IHit hit;
    IMove move;
    public string name { get; }

    public Hero(string _name, IHit _hit, IMove _move)
    {
        name = _name;
        hit = _hit;
        move = _move;
    }

    public void Hit()
    {
        Console.Write($"{name} ");
        hit.Hit();
    }
    public void Move()
    {
        Console.Write($"{name} ");
        move.Move();
    }
}