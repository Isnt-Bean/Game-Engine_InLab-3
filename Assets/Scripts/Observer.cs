using UnityEngine;
using System.Collections;
using TMPro;

public class Observer : MonoBehaviour
{
    public NPC npc;
    public TextMeshProUGUI text;

    private void OnNPCSpeak()
    {
        text.text = "NPC Is Speaking";
    }

    private void Awake()
    {
        if (npc != null)
        {
            npc.EnteredSpace += OnNPCSpeak;
        }
    }

    private void OnDestroy()
    {
        if (npc != null)
        {
            npc.EnteredSpace -= OnNPCSpeak;
        }
    }
}