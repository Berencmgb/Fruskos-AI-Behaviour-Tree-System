using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]       //!< Allows for the node to be created in the inspector/file manager.
public abstract class Node
{
    protected NodeState m_NodeState;    //!< Stores the current state of the node.

    public NodeState GetNodeState()   //!< This returns the current node state.
    {
        return m_NodeState; //!< Returning the current state
    }

    public abstract NodeState Evaluate(); //!< This evaluates which state the node should be in.

    public void SetNodeState(NodeState state) //!< Set the node state of the node
    {
        m_NodeState = state;
    }
}

public enum NodeState
{
    SUCCESS, FAILURE, RUNNING,
}
