using Godot;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public static class NodeUtils
{
    public static List<T> FindNodesInChildren<T>(Node node, bool includeCurrent = true) where T : Node
    {
        List<T> tNodes = new List<T>();

        if (includeCurrent && node is T) tNodes.Add((T)node);
        foreach(Node child in node.GetChildren())
            tNodes.AddRange(FindNodesInChildren<T>(child));

        return tNodes;
    }

    public static List<T> FindNodesInParents<T>(Node node, bool includeCurrent = true) where T : Node
    {
        List<T> tNodes = new List<T>();
        if (includeCurrent && node is T) tNodes.Add((T)node);

        Node parent = node.GetParent();
        if (parent != null)
            tNodes.AddRange(FindNodesInParents<T>(parent));

        return tNodes;
    }

    public static async void Invoke(this Node node, string methodName, float time, params Variant[] args)
    {
        await node.ToSignal(node.GetTree().CreateTimer(time), "timeout");
        node.Call(methodName, args);
    }
}
