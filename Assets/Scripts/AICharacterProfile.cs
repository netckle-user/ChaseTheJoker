using UnityEngine;
using XNode;

[CreateAssetMenu(menuName = "AI/CharacterProfile")]
public class AICharacterProfile : ScriptableObject
{
    public string aiName;
    public float riskAffinity;
    public float bluffSusceptibility;
    public float minThinkTime;
    public float maxThinkTime;
    public AIGraph decisionGraph;
}
