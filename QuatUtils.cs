using Godot;
using System;

public class QuatUtils
{
    public static float Angle(Quaternion a, Quaternion b)
    {
        return a.AngleTo(b);
    }

    public static Quaternion AngleAxis(float angle, Vector3 axis)
    {
        return new Quaternion(axis, angle);
    }

    public static float Dot(Quaternion a, Quaternion b)
    {
        return a.Dot(b);
    }

    public static Quaternion Euler(float x, float y, float z)
    {
        return Quaternion.FromEuler(new Vector3(x, y, z));
    }

    public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection)
    {
        throw new NotImplementedException();
    }

    public static Quaternion Inverse(Quaternion rotation)
    {
        return rotation.Inverse();
    }

    public static Quaternion Lerp(Quaternion a, Quaternion b, float t)
    {
        t = MathUtils.Clamp01(t);
        throw new NotImplementedException();
    }

    public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t)
    {
        throw new NotImplementedException();
    }

    public static Quaternion LookRotation(Vector3 forward)
    {
        return LookRotation(forward, VecUtils.up);
    }

    public static Quaternion LookRotation(Vector3 forward, Vector3 upwards)
    {
        throw new NotImplementedException();
    }

    public static Quaternion Normalize(Quaternion q)
    {
        throw new NotImplementedException();
    }

    public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta)
    {
        throw new NotImplementedException();
    }

    public static Quaternion Slerp(Quaternion a, Quaternion b, float t)
    {
        t = MathUtils.Clamp01(t);
        return a.Slerp(b, t);
    }

    public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t)
    {
        return a.Slerp(b, t);
    }
}
