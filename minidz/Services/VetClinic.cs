using System;

namespace minidz.Services;
public class VetClinic
{
    private static readonly Random _random = new();

    public static bool CheckHealth(Random random = null)
    {
        random ??= new Random();
        return random.Next(100) > 50;
    }
}
