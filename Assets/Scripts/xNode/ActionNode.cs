using UnityEngine;
using XNode;

public enum AIActionType
{
    PickCard,
    Delay,
    ShowExpression,
    SkipTurn
}

[CreateNodeMenu("AI/Action Node")]
public class ActionNode : BaseAINode 
{
    public AIActionType actionType;

    public override BaseAINode Execute(AIController controller)
    {
        Debug.Log($"AI: ActionNode - {actionType}");

        // 실제 게임 로직 연결은 이후에 처리
        switch (actionType)
        {
            case AIActionType.PickCard:
                controller.PickRandomCard();
                break;
            case AIActionType.SkipTurn:
                controller.SkipTurn();
                break;
            case AIActionType.Delay:
                // 연출 타이밍에 쓰일 수 있음
                break;
            case AIActionType.ShowExpression:
                controller.PlayExpression("a");
                break;
        }

        return GetOutputPort("output").Connection?.node as BaseAINode;
    }
}
