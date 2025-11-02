using UnityEngine;
using System.Collections;
using TMPro;

public class Observer : MonoBehaviour
{
    public NPC npc;
    public NPC1 npc2;
    public TextMeshProUGUI text;
    public string npcText;

    private void OnNPCSpeak()
    {
        text.text = npcText;
        //get the correct text file from either script


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
        if (npc2 != null)
        {
            npc2.EnteredSpace1 += OnNPCSpeak;
        }        
        if (npc2 != null)
        {
            npc2.DialogEmpty += OnBlankDialog;
        }
    }
}