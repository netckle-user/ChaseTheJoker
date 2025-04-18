using UnityEngine;
using XNode;

public enum DecisionType
{ 
    BluffDetected,
    HighJokerChange,
    RandomDecision
}

[CreateNodeMenu("AI/Decision Node")]
public class DecisionNode : BaseAINode
{
    public DecisionType decisionType;
    public float threshold = 0.5f;

    [Output(backingValue = ShowBackingValue.Never, connectionType = ConnectionType.Override)]
    public BaseAINode truePath;

    [Output(backingValue = ShowBackingValue.Never, connectionType = ConnectionType.Override)]
    public BaseAINode falsePath;

    public override BaseAINode Execute(AIController controller)
    {
        bool decision = false;

        switch (decisionType)
        {
            case DecisionType.BluffDetected:
                decision = controller.BluffIntensity > threshold;
                break;
            case DecisionType.HighJokerChange:
                decision = controller.JokerChangeEstimate > threshold;
                break;
            case DecisionType.RandomDecision:
                decision = Random.value > threshold;
                break;
        }

        Debug.Log($"AI: DecisionNode - {decisionType} -> {decision}");
        string port = decision ? "truePath" : "falsePath";
        return GetOutputPort(port).Connection?.node as BaseAINode;
    }
}
