using Godot;
using System;

public static class DirAccessExt
{
    public static void RemoveRecursive(this DirAccess dirAccess)
    {
        foreach(string fileName in dirAccess.GetFiles())
        {
            dirAccess.Remove(fileName);
        }

        foreach (string dirName in dirAccess.GetDirectories())
        {
            DirAccess childDirAccess = DirAccess.Open(dirAccess.GetCurrentDir() + "/" + dirName);
            childDirAccess.RemoveRecursive();
        }

        DirAccess.RemoveAbsolute(dirAccess.GetCurrentDir());
    }
}
