using System.Collections;
using UnityEngine;
using XNode;

public class AIController : MonoBehaviour
{
    public AICharacterProfile profile;

    public float BluffIntensity => Random.value;
    public float JokerChangeEstimate => Random.value;

    public void Start()
    {
        StartCoroutine(ExecuteGraph());
    }

    public void PickRandomCard()
    {
        Debug.Log("AI�� ī�带 �̽��ϴ�.");
    }

    public void SkipTurn()
    {
        Debug.Log("AI�� ���� �ѱ�ϴ�.");
    }

    public void PlayExpression(string emoji)
    {
        Debug.Log($"AI ǥ��: {emoji}");
    }

    private IEnumerator ExecuteGraph()
    {
        var currentNode = profile.decisionGraph.nodes[0] as BaseAINode;
        while (currentNode != null)
        {
            yield return new WaitForSeconds(Random.Range(profile.minThinkTime, profile.maxThinkTime));
            currentNode = currentNode.Execute(this);
        }

        Debug.Log("AI �� ����");
    }
}
