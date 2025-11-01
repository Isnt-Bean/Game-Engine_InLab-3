using UnityEngine;
using System.Collections;
using TMPro;

public class Observer : MonoBehaviour
{
    public NPC npc;
    public TextMeshProUGUI text;

    private void OnNPCSpeak()
    {
        text.text = npc.newText;
    }

    private void OnBlankDialog()
    {
        text.text = "";
    }

    private void Awake()
    {
        if (npc != null)
        {
            npc.EnteredSpace += OnNPCSpeak;
        }        
        if (npc != null)
        {
            npc.DialogEmpty += OnBlankDialog;
        }
    }

    private void OnDestroy()
    {
        if (npc != null)
        {
            npc.EnteredSpace -= OnNPCSpeak;
        }
        if (npc != null)
        {
            npc.DialogEmpty -= OnBlankDialog;
        }
    }
}