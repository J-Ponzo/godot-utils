using Godot;
using System;
using System.Collections.Generic;

public class NodeUtils
{
    public static List<T> FindNodesInChildren<T>(Node node) where T : Node
    {
        List<T> tNodes = new List<T>();

        if (node is T) tNodes.Add((T)node);
        foreach(Node child in node.GetChildren())
            tNodes.AddRange(FindNodesInChildren<T>(child));

        return tNodes;
    }

    public static List<T> FindNodesInParents<T>(Node node) where T : Node
    {
        List<T> tNodes = new List<T>();
        if (node is T) tNodes.Add((T)node);

        Node parent = node.GetParent();
        if (parent != null)
            tNodes.AddRange(FindNodesInParents<T>(parent));

        return tNodes;
    }
}
