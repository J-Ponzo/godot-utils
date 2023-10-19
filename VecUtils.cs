using Godot;
using System;

public class VecUtils
{
    public readonly static Vector3 back = new Vector3(0f, 0f, -1f);
    public readonly static Vector3 down = new Vector3(0f, -1f, 0f);
    public readonly static Vector3 forward = new Vector3(0f, 0f, 1f);
    public readonly static Vector3 left = new Vector3(-1f, 0f, 0f);
    public readonly static Vector3 negativeInfinity = new Vector3(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity);
    public readonly static Vector3 one = new Vector3(1f, 1f, 1f);
    public readonly static Vector3 positiveInfinity = new Vector3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);
    public readonly static Vector3 right = new Vector3(1f, 0f, 1f);
    public readonly static Vector3 up = new Vector3(0f, 1f, 0f);
    public readonly static Vector3 zero = new Vector3(0f, 0f, 0f);

    public static float Angle(Vector3 from, Vector3 to)
    {
        return from.AngleTo(to);
    }

    public static Vector3 ClampMagnitude(Vector3 vector, float maxLength)
    {
        float magnitude = Mathf.Min(vector.Length(), maxLength);
        return vector.Normalized() * magnitude;
    }

    public static Vector3 Cross(Vector3 lhs, Vector3 rhs)
    {
        return lhs.Cross(rhs);
    }

    public static float Distance(Vector3 a, Vector3 b)
    {
        return a.DistanceTo(b);
    }

    public static float Dot(Vector3 lhs, Vector3 rhs)
    {
        return lhs.Dot(rhs);
    }

    public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
    {
        t = MathUtils.Clamp01(t);
        return a.Lerp(b, t);
    }

    public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t)
    {
        return a.Lerp(b, t);
    }

    public static Vector3 Max(Vector3 lhs, Vector3 rhs)
    {
        return new Vector3(Mathf.Max(lhs.X, rhs.X), Mathf.Max(lhs.Y, rhs.Y), Mathf.Max(lhs.Z, rhs.Z));
    }

    public static Vector3 Min(Vector3 lhs, Vector3 rhs)
    {
        return new Vector3(Mathf.Min(lhs.X, rhs.X), Mathf.Min(lhs.Y, rhs.Y), Mathf.Min(lhs.Z, rhs.Z));
    }

    public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta)
    {
        return current.MoveToward(target, maxDistanceDelta);
    }

    public static Vector3 Normalize(Vector3 value)
    {
        throw new NotImplementedException();
    }

    public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent)
    {
        throw new NotImplementedException();
    }

    public static Vector3 Project(Vector3 vector, Vector3 onNormal)
    {
        return vector.Project(onNormal);
    }

    public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal)
    {
        Plane plane = new Plane(planeNormal);
        return plane.Project(vector);
    }

    public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal)
    {
        return inDirection.Reflect(inNormal);
    }

    public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta)
    {
        throw new NotImplementedException();
    }

    public static Vector3 Scale(Vector3 a, Vector3 b)
    {
        return new Vector3(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
    }

    public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis)
    {
        return from.SignedAngleTo(to, axis);
    }

    public static Vector3 Slerp(Vector3 a, Vector3 b, float t)
    {
        t = MathUtils.Clamp01(t);
        return a.Slerp(b, t);
    }

    public static Vector3 SlerpUnclamped(Vector3 a, Vector3 b, float t)
    {
        return a.Slerp(b, t);
    }

    public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime/*, float maxSpeed = Mathf.Infinity, float deltaTime = Time.deltaTime*/)
    {
        throw new NotImplementedException();
    }
}
