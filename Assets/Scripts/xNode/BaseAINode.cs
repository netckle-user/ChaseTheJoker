using UnityEngine;
using XNode;

public abstract class BaseAINode : Node
{
    [Input] public BaseAINode input;
    [Output] public BaseAINode output;

    public abstract BaseAINode Execute(AIController controller);
}
