using UnityEngine;
using XNode;

[CreateNodeMenu("AI/Start Node")]
public class StartNode : BaseAINode
{
    public override BaseAINode Execute(AIController controller)
    {
        Debug.Log("AI: ���� ��� ����");
        return GetOutputPort("output").Connection?.node as BaseAINode;
    }
}
