using Godot;
using System;

public partial class AutoloadSingleton<T> : Node where T : Node
{
    private static object m_Lock = new object();
    private static T instance;
    public static T Instance { get => instance; }

    public override void _EnterTree()
    {
        base._EnterTree();
        lock (m_Lock)
        {
            if (instance != null)
            {
                GD.PrintErr("An instance of GameApp already exists, this one will be destroyed");
                QueueFree();
                return;
            }

            instance = this as T;
        }
    }
}
