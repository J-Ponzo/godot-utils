using Godot;
using System;

public class RandUtils
{
    public static Vector2 RandomPointInCircle(Vector2 center, float radius)
    {
        return RandUtils.RandomPointInRing(center, 0f, radius);
    }

    public static Vector2 RandomPointInRing(Vector2 center, float minRadius, float maxRadius)
    {
        Vector2 randDir = RandUtils.RandomDirection();
        float randMagnitude = (float)GD.RandRange(minRadius, maxRadius);
        return center + randDir * randMagnitude;
    }

    public static Vector2 RandomDirection()
    {
        float randAngle = Mathf.DegToRad((float)GD.RandRange(0f, 360f));
        Vector2 randUnitDir = new Vector2(Mathf.Cos(randAngle), Mathf.Sin(randAngle));
        return randUnitDir;
    }

    public static int RandomRange(int minInclusive, int maxExclusive)
    {
        float rand = GD.RandRange(minInclusive, maxExclusive);
        if (rand == maxExclusive) rand--;
        return (int)rand;
    }
}
