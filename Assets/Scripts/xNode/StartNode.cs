using UnityEngine;
using XNode;

[CreateNodeMenu("AI/Start Node")]
public class StartNode : BaseAINode
{
    public override BaseAINode Execute(AIController controller)
    {
        Debug.Log("AI: 시작 노드 실행");
        return GetOutputPort("output").Connection?.node as BaseAINode;
    }
}
