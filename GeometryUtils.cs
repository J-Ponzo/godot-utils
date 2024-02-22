using Godot;
using System;

public class GeometryUtils
{
    public static Vector2 ClampInCircle(Vector2 location, Vector2 center, float radius)
    {
        if (location.DistanceTo(center) < radius) return location;

        return center + (location - center).Normalized() * radius;
    }

    public static bool IsLocationInCone(Vector2 location, Vector2 coneOrigin, Vector2 coneDircection, float coneHalfAngle, float coneRange)
    {
        if (!GeometryUtils.IsLocationInCircle(location, coneOrigin, coneRange))
            return false;

        return GeometryUtils.IsLocationInEndlessCone(location, coneOrigin, coneDircection, coneHalfAngle);
    }

    public static bool IsLocationInEndlessCone(Vector2 location, Vector2 coneOrigin, Vector2 coneDircection, float coneHalfAngle)
    {
        float angle = Mathf.Abs(Mathf.RadToDeg(coneDircection.AngleTo((location - coneOrigin).Normalized())));
        return angle < coneHalfAngle;
    }

    public static bool IsLocationInCircle(Vector2 location, Vector2 center, float radius)
    {
        return location.DistanceTo(center) < radius;
    }
}
