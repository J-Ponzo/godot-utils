using Godot;
using System;

public static class Transform3DExt
{
    public static Vector3 forward(this Transform3D thisTransform3D)
    {
        return thisTransform3D.Basis.Z;
    }

    public static Vector3 right(this Transform3D thisTransform3D)
    {
        return thisTransform3D.Basis.X;
    }

    public static Vector3 up(this Transform3D thisTransform3D)
    {
        return thisTransform3D.Basis.X;
    }
}
