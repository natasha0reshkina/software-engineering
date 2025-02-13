namespace minidz.Models.Things;
using minidz.Interfaces;
public abstract class Thing : IInventory
{
    public int Number { get; set; }
    public string Name { get; set; }

    protected Thing(string name, int number)
    {
        Name = name;
        Number = number;
    }

    public override string ToString()
    {
        return $"{Name} (ID: {Number})";
    }
}
