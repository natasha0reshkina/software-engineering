namespace minidz.Models.Animals;

public abstract class Predator : Animal
{
    protected Predator(string name, int food, int number)
        : base(name, food, number) { }
}
