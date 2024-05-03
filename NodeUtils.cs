using Godot;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public static class NodeUtils
{
    public static List<T> FindNodesInChildren<T>(Node node, bool includeCurrent = true, int depth = -1) where T : Node
    {
        List<T> tNodes = new List<T>();

        if (includeCurrent && node is T) tNodes.Add((T)node);
        if (depth != 0)
        {
            foreach (Node child in node.GetChildren())
                tNodes.AddRange(FindNodesInChildren<T>(child, true, depth - 1));
        }

        return tNodes;
    }

    public static List<T> FindNodesInParents<T>(Node node, bool includeCurrent = true, int depth = -1) where T : Node
    {
        List<T> tNodes = new List<T>();
        if (includeCurrent && node is T) tNodes.Add((T)node);

        if (depth != 0)
        {
            Node parent = node.GetParent();
            if (parent != null)
                tNodes.AddRange(FindNodesInParents<T>(parent, true, depth - 1));
        }

        return tNodes;
    }

    public static async void Invoke(this Node node, string methodName, float time, params Variant[] args)
    {
        await node.ToSignal(node.GetTree().CreateTimer(time), "timeout");
        node.Call(methodName, args);
    }
}
