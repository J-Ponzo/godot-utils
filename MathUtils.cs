using Godot;
using System;

public class MathUtils
{
    public readonly static float Deg2Rad = (Mathf.Pi * 2f) / 360f;
    public readonly static float Rad2Deg = 360f / (Mathf.Pi * 2f);

    public static float Clamp01(float value)
    {
        return Mathf.Clamp(value, 0f, 1f);
    }
}
