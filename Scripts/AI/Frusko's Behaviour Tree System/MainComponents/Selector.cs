
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : Node
{
    protected List<Node> nodeList = new List<Node>();

    public Selector(List<Node> nodes)
    {
        nodeList = nodes;
    }

    public override NodeState Evaluate()  //!< Evaluate each node state in the list of nodes.
    {
        foreach (Node n in nodeList) //!< Iterate through each node in the list.
        {
            switch (n.Evaluate())
            {
                case NodeState.RUNNING: //!< If any node in this list is running
                    SetNodeState(NodeState.RUNNING);  //!< Set the selector to running
                    return GetNodeState();    //!< Return node state
                case NodeState.SUCCESS: //!< If any node in this list is successfull
                    SetNodeState(NodeState.SUCCESS);  //!< Set the selector to success
                    return GetNodeState();
                case NodeState.FAILURE: 
                    break;
                default:
                    break;
            }
        }
        SetNodeState(NodeState.FAILURE);
        return GetNodeState();
    }
}
