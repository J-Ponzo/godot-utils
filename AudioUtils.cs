using Godot;
using System;

public class AudioUtils
{
    public static float LinearToDb(float linear)
    {
        float Db = 20f * Mathf.Log(linear);
        return Db;
    }

    public static float DbToLinear(float db)
    {
        float linear = Mathf.Pow(10f, db / 20f);
        return linear;
    }
}
