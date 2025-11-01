using UnityEngine;
using TMPro;

public class Observer : MonoBehaviour
{
    //public NPC npc;
    //public NPC2 npc2;
    public TextMeshProUGUI text;

    public NPC[] NPCs;
    private void OnNPCSpeak()
    {
        for (int i = 0; i < NPCs.Length; i++)
        {
            text.text = NPCs[i].newText;
        }
    }    

    private void OnBlankDialog()
    {
        text.text = "";
    }    

    private void Awake()
    {
        //Testing
        for (int i = 0; NPCs.Length > i; i++)
        {
            if (NPCs[i] != null)
            {
                NPCs[i].EnteredSpace += OnNPCSpeak;
            }
            if (NPCs[i] != null)
            {
                NPCs[i].DialogEmpty += OnBlankDialog;
            }
        }
        //Testing Section Over
        /*
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
            npc2.EnteredSpace2 += OnNPCSpeak2;
        }        
        if (npc2 != null)
        {
            npc2.DialogEmpty2 += OnBlankDialog;
        }
        */
    }

    private void OnDestroy()
    {
        //Testing
        for (int i = 0; NPCs.Length > i; i++)
        {
            if (NPCs[i] != null)
            {
                NPCs[i].EnteredSpace -= OnNPCSpeak;
            }
            if (NPCs[i] != null)
            {
                NPCs[i].DialogEmpty -= OnBlankDialog;
            }
        }
        //Testing Section Over
        /*
        if (npc != null)
        {
            npc.EnteredSpace -= OnNPCSpeak;
        }
        if (npc != null)
        {
            npc.DialogEmpty -= OnBlankDialog;
        }        
        if (npc2 != null)
        {
            npc2.EnteredSpace2 -= OnNPCSpeak2;
        }
        if (npc2 != null)
        {
            npc2.DialogEmpty2 -= OnBlankDialog;
        }
        */
    }
    
}