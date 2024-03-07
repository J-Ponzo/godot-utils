using Godot;
using System;

public class AudioUtils
{
    public static float LinearToDb(float linear)
    {
        float Db = 20f * Mathf.Log(linear);
        return Db;
    }
}
