using UnityEngine;
using System;

public class NPC : MonoBehaviour
{
    public event Action EnteredSpace;
    public event Action DialogEmpty;

    public String newText = "NPC 1 is talking";
    
    private void Start()
    {
        BlankText();
    }
    private void TalkToPlayer()
    {
        EnteredSpace?.Invoke();
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
