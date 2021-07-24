# Fruskos-AI-Behaviour-Tree-System
A behaviour tree system developed from the ground up for Unity projects.


This is a Behaviour Tree system designed for use in Unity Projects.
To use the system, the developer must create classes that inherit the abstarcted node class within this system and reference the created class in a separate AI class.
The developer will write their desired conditions for behaviours within these node classes.
Selector and Sequence node instances are created in this same class.

Nodes have three states: RUNNING, SUCCESS, FAILURE.

Sequence; Constructor is a list of nodes. The Selector will iterate through and check if all child nodes are success. Else the sequence will fail. Inhertis Node class.
Selector; Constructor is a list of nodes. The Selector will iterate through child nodes to find the first successful child. If no children are successful, the selector fails. Inherits Node Class.
Node; This is the base node, used as a base class for all behaviour nodes.

Currently, there is no visual editor for the system. This is a planned feature.

There is no example project as of yet, coming soon.

This system has been used in many of my personal projects to develop complex AI.

# PLANNED FEATURES #
* A visual node editor
* Inverter node
