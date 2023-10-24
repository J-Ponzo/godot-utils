using Godot;
using System;
using System.Collections.Generic;

public class NodeUtils
{
    public static List<T> FindNodeInChilds<T>(Node node) where T : Node
    {
        List<T> tNodes = new List<T>();

        if (node is T) tNodes.Add((T)node);
        foreach(Node child in node.GetChildren())
            tNodes.AddRange(FindNodeInChilds<T>(child));

        return tNodes;
    }
}
