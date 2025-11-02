using UnityEngine;
using System;

public class NPC1 : MonoBehaviour
{
    public event Action EnteredSpace1;
    public event Action DialogEmpty;
    public Observer o;
    public String newText = "NPC 2 is talking";
    
    private void Start()
    {
        BlankText();
    }
    private void TalkToPlayer()
    {
        EnteredSpace1?.Invoke();
    }

    private void BlankText()
    {
        DialogEmpty?.Invoke();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //print("Player Entered");
            o.npcText = newText;
            TalkToPlayer();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //print("Player Exited");
            newText = "Why are you still talking to me?";
            BlankText();
        }
    }
}
