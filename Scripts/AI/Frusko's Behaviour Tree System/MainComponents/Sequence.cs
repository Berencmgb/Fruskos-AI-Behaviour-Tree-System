using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequence : Node
{ 
    private List<Node> nodeList = new List<Node>();

    public Sequence(List<Node> nodes)
    {
        nodeList = nodes;
    }

    public override NodeState Evaluate()  //!< Evaluate each node state in the list of nodes.
    {
        foreach(Node n in nodeList)
        {
            switch(n.Evaluate())
            {
                case NodeState.RUNNING:
                    SetNodeState(NodeState.RUNNING);
                    return GetNodeState();
                case NodeState.FAILURE:
                    SetNodeState(NodeState.FAILURE);
                    return GetNodeState();
            }
        }
        SetNodeState(NodeState.SUCCESS);
        return GetNodeState();

    }
}
